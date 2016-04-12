using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using Cashier.classes;

namespace Cashier
{
    public partial class frmPaymentGetOP : MetroForm
    {
        public int lastORNumber = int.Parse(OrderOfPayment.getLastORNo());
        public frmMetroMainMenu parent;

        public frmPaymentGetOP()
        {
            InitializeComponent();
            
        }

        private void mtbToManageData_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mtbSearch_Click(object sender, EventArgs e)
        {
            // check if OPNo is valid
            int OPNo = 0;
            try
            {
                OPNo = int.Parse(tOPNo.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid OP Number");
                return;
            }

            float temp = 0;
            string query = "SELECT * FROM tbl_PayOrder WHERE OPNo = " + OPNo;

            if (new clsDB().Con().countRecord(query) > 0)
            {
                // Compute Total
                query = "SELECT AcctCode, Particular, Amount FROM tbl_PayOrder_Details WHERE OPSeqNo = '" + OPNo + "'";

                new clsDB().Con().FillLvw(listView1, query);
                float[] total = Payor.computeAccount(listView1);
                temp = total[0] + total[1];
                frmPaymentDataEntry f = new frmPaymentDataEntry(this.lastORNumber);
                f.total = temp;
                f.orderOfPaymentNo = OPNo;
                f.listLength = listView1.Items.Count;
                f.ShowDialog();
                this.lastORNumber = f.lastORNumber;

               
                parent.lbTotalCollection.Text = "" + Cashier.classes.clsCollection.getDailyAccumulatedAmount(DateTime.Now.ToShortDateString());
                string date = DateTime.Now.ToShortDateString();
                Cashier.classes.clsCollection c = new Cashier.classes.clsCollection();
                Dictionary<string, float> summary = c.summaryOfCollection(2, date);

                for (int i = 0; i < summary.Count; i++)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.SubItems[0].Text = summary.Keys.ToList()[i];
                    ListViewItem.ListViewSubItem item = new ListViewItem.ListViewSubItem();
                    item.Text = Convert.ToString(summary[summary.Keys.ToList()[i]]);
                    lvi.SubItems.Add(item);


                    parent.lvSummaryOfCollection.Items.Add(lvi);

                }
            }
            else
            {
                
                MessageBox.Show("Invalid Order of Payment Number", "Input Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
         }

        private void showDetails(bool show = false)
        {
            if (show)
            {
                this.Height = 430;
                
                gbDetails.Visible = true;
            }
            else
            {
                this.Height = 130;
                
                    
                gbDetails.Visible = false;
            }

        }

        private void tOPNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                mtbSearch_Click(null, null);
            }
        }

        private void frmPaymentGetOP_Load(object sender, EventArgs e)
        {
            
            tOPNo.Focus();
        }

        private void mtbDeleteOR_Click(object sender, EventArgs e)
        {
            if (mtbDeleteOR.Tag.ToString() == "ViewDelete")
            {
                gbORDELETE.Visible = true;
                mtbDeleteOR.Tag = "DeleteOR";
                mtbDeleteOR.Text = "Confirm Delete";
            }

            if (mtbDeleteOR.Tag.ToString() == "DeleteOR")
            {

                if (!string.IsNullOrEmpty(tbORNoDelete.Text) && int.Parse(tbORNoDelete.Text) > 0)
                {
                    try
                    {

                        // transfer Data for Future reference
                        clsCollection collection = new clsCollection(int.Parse(tbORNoDelete.Text));
                        Dictionary<string,string> collectionData = collection.collectionData;
                        
                        string[][] collectionItems = collection.getCollectionItem(int.Parse(tbORNoDelete.Text));
                        string collectionItemsSummary = "";
                        for (int i = 0; i < collectionItems.Count(); i++)
                        {
                            collectionItemsSummary += collectionItems[i][0].ToString() + " : " + collectionItems[i][2].ToString() +" , ";
                        }

                        string collectionDetails = " { " +
                                                   "   OPNumber : " + collectionData["OPNumber"] + "," +
                                                   "   Date_Paid : " + collectionData["Date_Paid"] + "," +
                                                   "   Payor : " + collectionData["Payor"] + "," +
                                                   " Amount : " + collectionData["OPNumber"] + "," +
                                                   "   PaymentType : " + collectionData["PaymentType"] + "," +
                                                   "   CollectionDetails : {  " +
                                                   "   " + collectionItemsSummary + " } }";

                        string insertQuery = "INSERT INTO collection_deleted(ORNumber,Collection_Details) VALUES(" + int.Parse(tbORNoDelete.Text) + ",'" + collectionDetails + "' )";

                        if (new clsDB().Con().ExecuteSql(insertQuery))
                        {
                            string query = "DELETE FROM Collections WHERE ORNumber = " + tbORNoDelete.Text;
                            if (new clsDB().Con().ExecuteSql(query))
                            {
                                query = "DELETE FROM Collection_Details WHERE ORNumber = " + tbORNoDelete.Text;
                                if (new clsDB().Con().ExecuteSql(query))
                                {
                                    mtbDeleteOR.Text = "Delete OR";
                                    mtbDeleteOR.Tag = "ViewDelete";
                                    gbDetails.Visible = false;
                                    MessageBox.Show("Delete Successful");
                                }
                            }
                        }

                       

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Invalid ORNo - Error Message : " + ex.Message);
                    }
                }

           
            }
        }

    }
}
