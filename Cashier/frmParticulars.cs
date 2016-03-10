using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Cashier.classes;

namespace Cashier
{
    public partial class frmParticulars : frmDataEntry
    {
        public string[][] checkedItems;

        public int selectedAssessmentID = 0;

        public string query = "SELECT AssessmentID, AssessmentName, Amount FROM Assessment";
        public frmParticulars()
        {
            InitializeComponent();
        }



        private void frmParticulars_Load(object sender, EventArgs e)
        {

            new clsDB().Con().FillLvw(listView1, query);
        }

        public void RefreshData(string s = "")
        {
            s = (s != "" && s != " ") ? s : query;

            new clsDB().Con().FillLvw(listView1, s);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (listView1.CheckedItems.Count > 0)
            {
                checkedItems = Payor.getCheckedItems(listView1);
               
                
                Close();
            }
            else
                MessageBox.Show("Please Select a particular");
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = tbSearch.Text;

            string query = "SELECT AssessmentID,AssessmentName, Amount FROM Assessment WHERE AssessmentName LIKE '%" + searchTerm + "%'";

            RefreshData(query);

        }

        private void listView1_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            
            if (listView1.CheckedItems.Count > 1)
            {
                for (int i = 0; i < listView1.CheckedItems.Count; i++)
                {
                    //listView1.CheckedItems[i].Checked = false;  
                }
            }
        }

        private void tbEdit_Click(object sender, EventArgs e)
        {
            if (listView1.CheckedItems.Count > 0 && listView1.CheckedItems.Count < 2)
            {
                editPanel.Visible = true;

                int assessmentID = int.Parse(listView1.CheckedItems[0].SubItems[0].Text);
                selectedAssessmentID = assessmentID;

                Dictionary<string, string> data = new Dictionary<string, string>();
                new clsDB().Con().SelectDataDictionary("SELECT AssessmentID, AssessmentName, Amount, ShortName FROM Assessment WHERE AssessmentID = " + assessmentID, data);

                tbParticularName.Text = data["AssessmentName"];
                tbShortDesc.Text = data["ShortName"];
                tbAmount.Text = data["Amount"];
            }
            else
                MessageBox.Show("List Selection is Invalid");

        }

        private void mtbSave_Click(object sender, EventArgs e)
        {
            if (listView1.CheckedItems.Count > 0 && editPanel.Visible)
            {
                if (Helper.strIsEmpty(tbParticularName.Text) || Helper.strIsEmpty(tbShortDesc.Text) || Helper.strIsEmpty(tbAmount.Text))
                {
                    MessageBox.Show("There is an empty field");
                }
                else
                {
                    string query = "UPDATE Assessment SET AssessmentName = '" + tbParticularName.Text + "',Shortname = '" + tbShortDesc.Text + "', Amount = " + tbAmount.Text + " WHERE AssessmentID = " + selectedAssessmentID;

                    if (new clsDB().Con().ExecuteSql(query))
                    {
                        MessageBox.Show("Assessment Updated ... ");
                        editPanel.Visible = false;
                        //RefreshData(" ");
                    }
                }

               
            }
        }

        private void tbDelete_Click(object sender, EventArgs e)
        {
            if (listView1.CheckedItems.Count > 0 && listView1.CheckedItems.Count < 2)
            {
                int assessmentID = int.Parse(listView1.CheckedItems[0].SubItems[0].Text);

                DialogResult dr = MessageBox.Show("Are you sure you want to delete this item?", "Confirm!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {

                    if (new clsDB().Con().ExecuteSql("DELETE FROM Assessment WHERE AssessmentID = " + assessmentID))
                    {
                        MessageBox.Show("Item Deleted", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshData(" ");
                    }

                    
                }
            }
            else
                MessageBox.Show("List Selection is Invalid");
        }

        private void mtbClose_Click(object sender, EventArgs e)
        {
            editPanel.Visible = false;


            tbParticularName.Text = "";
            tbShortDesc.Text = "";
            tbAmount.Text = "";
        }

        private void tbAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                mtbSave_Click(null, null);
            }
        }

       

    }
}
