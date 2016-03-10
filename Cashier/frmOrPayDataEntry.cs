using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Cashier.classes;
//using Shortcut;

namespace Cashier
{
    public partial class frmOrPayDataEntry : frmDataEntry
    {
        public static string[] obj;
        public static string[] studentData;
        public static string[][] checkedItems;
        public static string paymentType;

        public static string dbAction;
        //private readonly HotkeyBinder hotkeyBinder = new HotkeyBinder();

        private static frmOrPayManageData.MsgHandler modRefreshData;
        private static int[] seqNo;
        private static int tuitionMarker;

        public bool isTuitionFee = false;
       
        public frmOrPayDataEntry()
        {
            InitializeComponent();
            tPaymentOrNo.Text = OrderOfPayment.getLastOPNo();
            new clsDB().Con().FillCombobox(cmbParticular, "SELECT AssessmentName FROM assessment");

            // ***** HOTKEYS *******
            //hotkeyBinder.Bind(Modifiers.Control, Keys.P).To(showPayor);
            //hotkeyBinder.Bind(Modifiers.Control, Keys.I).To(showParticulars);
            // ***** END OF HOTKEYS *******
        }

        // ---------- HOTKEY EVENTS --------
        private void showPayor(Form f)
        {
            f.ShowDialog();
        }
        private void showParticulars()
        {
            btnAddParticular_Click_1(null, null);
        }


        // --------- END OF HOTKEY EVENTS --------




        private  void showPayor()
        {
            btnPayor_Click(null, null);
        }

        //  "show as" functions

        public static void show_asAdd(frmOrPayManageData.MsgHandler msg)
        {

            dbAction = "add";
            modRefreshData = msg;

            frmOrPayDataEntry f = new frmOrPayDataEntry();

            if (studentData != null && checkedItems != null)
            {
                // hide text boxes

                f.tbFirstname.Visible = false;
                f.tbLastname.Visible = false;
                f.tbMiddlename.Visible = false;

            

            }
      

            f.showPayor(f);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lvDataEntryOP.Items.Count > 0)
            {
                float total = float.Parse(lbTotal.Text);

                if (total > 0 && (!string.IsNullOrEmpty(tbFirstname.Text) && !string.IsNullOrEmpty(tbLastname.Text)))
                {
                    OrderOfPayment OP = null;
                    StudentAccount SAccount = new StudentAccount();
                    Dictionary<string, float> amountPerParticular = SAccount.getAmountPerParticular(lvDataEntryOP,2);
                    string payor = tbFirstname.Text.Replace("'","''") + " " + tbMiddlename.Text + " " + tbLastname.Text;

                    int orderOfPaymentType = 0 ;
                    try
                    {
                        orderOfPaymentType = int.Parse((mrbUndergrad.Checked) ? mrbUndergrad.Tag.ToString() : (mrbMasteral.Checked) ? mrbMasteral.Tag.ToString() : (mrbFiduciary.Checked) ? mrbFiduciary.Tag.ToString() : (mrbBtr.Checked) ? mrbBtr.Tag.ToString() : (mrbIGD.Checked) ? mrbIGD.Tag.ToString() : "0" );
                        paymentType = (mtrbCash.Checked) ? mtrbCash.Tag.ToString() : (mtrbCheck.Checked) ? mtrbCheck.Tag.ToString() : "0";
                    }
                    catch (Exception ex)
                    {
                       
                        MessageBox.Show(ex.Message);
                    }

                    // check payment type
                    // check if has student ID
                    int studentID = 0;
                    if(lbStudID.Text != "[ Student ID ]")
                        studentID = int.Parse(lbStudID.Text);

                    string purpose = "Other Fees";

                    // Purpose
                    if (isTuitionFee)
                    {
                        purpose = "Tuition Fee/Misc";
                    }

                    // has check details
                    if (Payor.validateCheckDetails(mtbBankName.Text, mtbCheckNo.Text, mtdCheckDate.Value.ToShortDateString(), mtbCheckAmount.Text) && mtrbCheck.Checked)
                    {
                        OP = new OrderOfPayment(float.Parse(tAmount.Text), int.Parse(tPaymentOrNo.Text), dtOrDate.Value.ToShortDateString(), purpose, payor, studentID, tbRemarks.Text, mtbBankName.Text, mtbCheckNo.Text, mtdCheckDate.Value.ToShortDateString(), float.Parse(mtbCheckAmount.Text),int.Parse(paymentType));
                    }
                    else if (mtrbCash.Checked)
                        OP = new OrderOfPayment(float.Parse(tAmount.Text), int.Parse(tPaymentOrNo.Text), dtOrDate.Value.ToShortDateString(), purpose, payor, studentID, tbRemarks.Text, null, null, null, 0, int.Parse(paymentType));
                    else
                        MessageBox.Show("There are some fields missing!");
                    // final validation
                    if (OP != null)
                    {
                        if (OP.createOP())
                        {
                            OP.addOPItem(int.Parse(tPaymentOrNo.Text), amountPerParticular, orderOfPaymentType);
                            MessageBox.Show("Successful! \n \t Please Proceed to Payment");

                            Dictionary<string, string> OPData = OP.getOPDataWOOR(int.Parse(tPaymentOrNo.Text));
                            ePrinting print = new ePrinting(OPData);
                            print.ePrint("OP");

                            this.Dispose();
                            frmOrPayDataEntry  temp  = new frmOrPayDataEntry();
                            temp.ShowDialog();


                        }
                    }
                    
                }
                else
                {
                    MessageBox.Show("Invalid Input / Missing Field");
                }
            }
            else
            {
                MessageBox.Show("Please add an item");
            }
          
           
        }








        private void frmOrPayDataEntry_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            Helper.closeOtherForm("frmPartialPayment");  
        }


        private void btnAddParticular_Click(object sender, EventArgs e)
        {
            
            frmParticulars f = new frmParticulars();
            f.ShowDialog();
            string[][] data = f.checkedItems;
            string[] col = new string[f.listView1.Columns.Count];

            if (f.listView1.CheckedItems.Count > 0)
            {
                for (int i = 0; i < f.listView1.Columns.Count; i++)
                {
                    col[i] = f.listView1.Columns[i].Text;
                }
                try
                {
                    if (new clsDB().Con().listViewTransferData(data, lvDataEntryOP, col))
                    {
                        f.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                try
                {
                    float[] account = Payor.computeAccount(lvDataEntryOP);
                    lbTotal.Text = Convert.ToString(account[1]);
                    tAmount.Text = Convert.ToString(account[1]);
                }
                catch (Exception ex)
                {
                    lvDataEntryOP.Items.Clear();
                    MessageBox.Show("Particular Has no Amount");
                }
               
            }
            

        }

        private void btnAddParticular_Click_1(object sender, EventArgs e)
        {
            string particular = "";
             string query = "Select AssessmentID, AssessmentName, ISNULL(Amount,0) from assessment WHERE AssessmentName = '";
             if (cmbParticular.SelectedIndex > -1)
                 particular = cmbParticular.SelectedItem.ToString();
             else
                 particular = cmbParticular.Text;
           
            try
            {
                if (!string.IsNullOrEmpty(particular))
                {
                    int count = new clsDB().Con().countRecord(query + particular + "'");
                    string[] column = { "No", "Particulars", "Amount"};
                    string[][] data = new string[count][];
                    string[] obj = new string[3];
                    bool hasAmount = false;

                    // if has record in the database - get data for transfer
                    if (count > 0)
                    {
                        if (new clsDB().Con().SelectData(query + particular + "'", obj))
                        {
                            data[0] = obj;
                            // check if the amount is zero and ask for input
                            if (float.Parse(data[0][2]) == 0 || data[0][1] == "Tuition Fee")
                            {
                                frmParticularAmountDataEntry f = new frmParticularAmountDataEntry(int.Parse(data[0][0]));
                                
                                // FLAG for TUITION FEE
                                if (data[0][1] == "Tuition Fee")
                                {
                                    f.isTuitionFee = true;
                                    isTuitionFee = true;
                                }
                                
                                f.ShowDialog();
                                data[0][2] = Convert.ToString(f.amount);
                                hasAmount = f.hasAmount;
                            }
                            else
                                hasAmount = true;

                            if (hasAmount && new clsDB().Con().listViewTransferData(data, lvDataEntryOP, column))
                            {
                                float[] account = Payor.computeAccount(lvDataEntryOP);

                                // Set TEMPORARY FIX for TUITION PAYMENT - G

                                lbTotal.Text = Convert.ToString(account[0] + account[1]);
                                tAmount.Text = Convert.ToString(account[0] + account[1]);
                              
                                /**
                                lbTotal.Text = Convert.ToString(account[1]);
                                tAmount.Text = Convert.ToString(account[1]);
                                 */
                            }
                        }
                       
                    }
                    else
                    {
                        pNewParticular.Visible = true;
                    }
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

     


        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {


                new clsDB().Con().listViewRemoveSelectedIndex(lvDataEntryOP);

                float[] account = Payor.computeAccount(lvDataEntryOP);

                lbTotal.Text = Convert.ToString(account[1]);
                tAmount.Text = Convert.ToString(account[1]);

                lvDataEntryOP.Items[lvDataEntryOP.Items.Count - 1].Focused = true;
                lvDataEntryOP.Items[lvDataEntryOP.Items.Count - 1].Selected = true;
            }
            catch (Exception ex)
            {
                // Test
            }
        }

        private void btnPayor_Click(object sender, EventArgs e)
        {
            frmPayorDataEntry f = new frmPayorDataEntry();
            f.ShowDialog();

            if (f.wName.Count() > 0)
            {
                tbFirstname.Text = f.wName["firstname"];
                tbMiddlename.Text = f.wName["middlename"];
                tbLastname.Text = f.wName["lastname"];
                lbStudID.Text = Convert.ToString(f.ID);

                lbStudID.Visible = true;
                tbFirstname.ReadOnly = true;
                tbMiddlename.ReadOnly = true;
                tbLastname.ReadOnly = true;
                btnReset.Visible = true;

                // focus next item
                cmbParticular.Focus();
            }
           

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            tbFirstname.ReadOnly = false;
            tbMiddlename.ReadOnly = false;
            tbLastname.ReadOnly = false;
            lbStudID.Visible = false;

            tbFirstname.Text = "Firstname"; tbMiddlename.Text = "Middlename"; tbLastname.Text = "Lastname";

            btnReset.Visible = false;
        }


  

        

        private void btnNewParticularExit_Click(object sender, EventArgs e)
        {
            pNewParticular.Visible = false;
            tbNewParticularAmount.Text = "";
            tbNewParticularShortDesc.Text = "";
        }

        private void btnNewParticular_Click(object sender, EventArgs e)
        {
            if (Helper.strIsEmpty(tbNewParticularAmount.Text, true) == false && Helper.strIsEmpty(tbNewParticularShortDesc.Text) == false)
            {
                if (Helper.IsNumeric(tbNewParticularAmount.Text))
                {
                    string query = "INSERT INTO assessment (AssessmentName, amount,ShortName) VALUES ('" + cmbParticular.Text + "',  " + tbNewParticularAmount.Text + ",'" + tbNewParticularShortDesc.Text + "')";

                    if (new clsDB().Con().ExecuteSql(query))
                    {
                        MessageBox.Show("Particular Added");
                        btnNewParticularExit_Click(null, null);
                        new clsDB().Con().FillCombobox(cmbParticular, "SELECT AssessmentName FROM assessment");
                    }
                }
            }
            else
                MessageBox.Show("There is an empty Field");

        }

 
        private void cmbParticular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                MessageBox.Show("test");
                btnAddParticular_Click_1(null, null);
            }
        }



        private void mtrbCash_CheckedChanged_1(object sender, EventArgs e)
        {
            if (mtrbCheck.Checked)
                lvDataEntryOP.Height -= 76;
        }

        private void mtrbCheck_CheckedChanged_1(object sender, EventArgs e)
        {
            if (mtrbCash.Checked)
                lvDataEntryOP.Height += 76;
        }

        private void cmbParticular_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Right)
            {
                tAmount.Focus();
            }
            if (e.KeyCode == Keys.Enter)
            {
                btnAddParticular_Click_1(null, null);
            }
        }

        private void btnPayor_Enter(object sender, EventArgs e)
        {
           
            metroToolTip1.Show("Select Payor or Add new payor", btnPayor, btnPayor.Width,btnPayor.Height,10000000);
            metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
        }

        private void btnPayor_Leave(object sender, EventArgs e)
        {
            metroToolTip1.Hide(btnPayor);
        }

        private void cmbParticular_Enter(object sender, EventArgs e)
        {
            metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            metroToolTip1.Show("Select Particular", cmbParticular, cmbParticular.Width, cmbParticular.Height, 10000000);
        }

        private void cmbParticular_Leave(object sender, EventArgs e)
        {
            metroToolTip1.Hide(cmbParticular);
        }

        private void tAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave_Click(null,null);
            }
        }

        private void tAmount_Enter(object sender, EventArgs e)
        {
            metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            metroToolTip1.Show(" ** Enter to Submit ** \n Or Edit Amount ", tAmount, tAmount.Width / 2, 0, 10000000);
        }

        private void tAmount_Leave(object sender, EventArgs e)
        {
            metroToolTip1.Hide(tAmount);
        }
   

     








 

   
   

      
   

   






     
    }
}
