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
    public partial class frmPaymentDataEntry : frmDataEntry
    {
        private bool isValid = false;
        public float total;
        public int orderOfPaymentNo;
        public int listLength;
         OrderOfPayment OP ;
        public Dictionary<string, string> OPData ;

        public frmPaymentDataEntry()
        {
            InitializeComponent();
            tbORNo.Text = OrderOfPayment.getLastORNo();
            OP = new OrderOfPayment();
            
        }

        private void tbAmount_TextChanged(object sender, EventArgs e)
        {
            if (Helper.IsNumeric(tbAmount.Text))
            {
                tbAmount.BackColor = Color.White;

                // Compute Change After amount > total
                if (float.Parse(tbAmount.Text) >= total)
                {
                    float temp = float.Parse(tbAmount.Text) - total;
                    lbChange.Text = Convert.ToString(temp);
                }

                isValid = true;
            }
            else
            {
                tbAmount.BackColor = Color.Maroon;
                isValid = false;
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            bool hasPayment = false;
            if (float.Parse(tbAmount.Text) < float.Parse(lblAmountToPay.Text))
            {
                MessageBox.Show(" Invalid Amount");
            }
            else
            {
               
                string query = "SELECT SA.SeqNo, SA.StudID, SA.SemNo, SA.Particular, SA.Amount, ISNULL(SA.Payment,0), ISNULL(SA.Balance,0),OP.Amount FROM Student_Account as SA JOIN tbl_PayOrder as OP ON SA.StudID = OP.StudID WHERE OP.OPNo = ";
                int recordCount = new clsDB().Con().countRecord(query + orderOfPaymentNo);
                string[][] data = new string[recordCount][];

                // if it is for Student Account 
                if (recordCount > 0)
                {
                    new clsDB().Con().SelectData(query + orderOfPaymentNo, data);


                    StudentAccount sa = new StudentAccount();
                    Dictionary<string, string> studentAccountData = sa.getData(data);

                    int tuitionSeqNo = int.Parse(studentAccountData["tuitionSeqNo"]);
                    float mFee = float.Parse(studentAccountData["mFee"]);
                    int StudID = int.Parse(studentAccountData["StudID"]);
                    int semNo = int.Parse(studentAccountData["SemNo"]);



                    if (StudentAccount.updatePayment(sa.seqNo, tuitionSeqNo, float.Parse(tbAmount.Text), StudID, mFee, semNo))
                    {
                        hasPayment = true;
                    }
                    else
                    {
                        MessageBox.Show("There was an error!");
                    }

                }
                // if for Misc Fees and other payments
                else
                {
                    hasPayment = true;
                }
               
            }
           
            // Final Procedure
            if (hasPayment)
            {
                string checkAmount = null, checkDate = null, checkNo = null, bankName = null, PaymentType = null ;
                
                OPData.TryGetValue("CheckAmount", out checkAmount);
                OPData.TryGetValue("CheckNo", out checkNo);
                OPData.TryGetValue("CheckDate", out checkDate);
                OPData.TryGetValue("BankName", out bankName);
                 OPData.TryGetValue("PaymentType", out PaymentType);

  

                clsCollection col = new clsCollection(orderOfPaymentNo, int.Parse(OrderOfPayment.getLastORNo()), dtORDate.Value.ToShortDateString(), float.Parse(tbAmount.Text), OPData["Payor"].Replace("'","''"), checkNo,bankName, checkDate, float.Parse(checkAmount), int.Parse(PaymentType));

                if (OP.updateOP(int.Parse(tbORNo.Text), orderOfPaymentNo))
                    if (col.create())
                    {
                        OP.paidOP(orderOfPaymentNo);
                        col.addCollectionItem();

                        string[][] particularsAmount = OP.getOrderOfPaymentItem(orderOfPaymentNo);

                        OPData["collectionDate"] = dtORDate.Value.ToShortDateString();
                        int currOrNumber = int.Parse(OrderOfPayment.getLastORNo()) - 1;
                        OPData["ORNumber"] = ""+currOrNumber;
                        
                        ePrinting print = new ePrinting(OPData, particularsAmount);
                        
                        // temporary fix for OTHER Payment
                        if (OPData["Purpose"] == "Other Fees")
                            print.isOtherPayment = true;

                        print.ePrint("OR");
                        
                        Close();
                    }
            }
        }

        private void tbORNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmPaymentDataEntry_Load(object sender, EventArgs e)
        {
            lblAmountToPay.Text = total.ToString();
            OPData = OP.getOPData(orderOfPaymentNo);

            Dictionary<string, string> data = new Dictionary<string, string>();

            new clsDB().Con().SelectDataDictionary("SELECT DISTINCT OP.SemNO , OP.Payor as Payor,OP.DateIssued  FROM tbl_PayOrder as OP LEFT JOIN Student_Account as SA ON OP.StudID = SA.StudID LEFT JOIN Student as S ON S.StudID = OP.StudID WHERE OP.OPNo = " + orderOfPaymentNo, data);

            lbName.Text = data["Payor"];

            DateTime dt = DateTime.Parse(data["DateIssued"]);

            lbDate.Text = dt.ToString("MMMM dd, yyyy");


            string query = "SELECT AcctCode, Particular, Amount FROM tbl_PayOrder_Details WHERE OPSeqNo = '" + orderOfPaymentNo + "'";

            new clsDB().Con().FillLvw(listView1, query);

            if (OP.hasCheck() && !string.IsNullOrEmpty(OPData["CheckNo"]) && OPData["CheckNo"] != "" && !Helper.strIsEmpty(OPData["CheckNo"]))
            {
                checkDetails.Visible = true;
                lbCheckNo.Text = OPData["CheckNo"];
                lbCheckDate.Text = OPData["CheckDate"];
                lbBankName.Text = OPData["BankName"];
                lbCheckAmount.Text = OPData["CheckAmount"];

                tbAmount.Text = OPData["CheckAmount"];
                tbAmount.Enabled = false;



            }
            else
            {
                particularBox.Location = new Point(particularBox.Location.X, particularBox.Location.Y - 60);
                particularBox.Height += 63;
                listView1.Height += 61;

                //changeBox.Height += 30;
                //changeBox.Location = new Point(changeBox.Location.X, changeBox.Location.Y - 50);
                checkDetails.Visible = false;
                tbAmount.Enabled = true;
                tbAmount.Text = lblAmountToPay.Text;
            }
        }

        private void tbAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                btnSave_Click(null, null);
        }

        private void tbORNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave_Click(null, null);
            }
        }

  



   
    }
}
