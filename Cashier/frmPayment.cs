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
    public partial class frmPayment : frmManageRecord
    {
        public string sql = "SELECT TOP 50 OPNo, OP.Amount, CAST( CASE WHEN OP.Payor IS NULL OR OP.Payor = '' THEN CONCAT(FName,' ',MName,' ',LName) ELSE OP.Payor END AS varchar(100))  as Payor, CAST (CASE WHEN  PAID = 0 OR PAID IS NULL OR PAID = '' THEN 'Not Paid' ELSE 'Paid' END as varchar(10) ) as Paid From tbl_PayOrder as OP LEFT JOIN Student as S ON S.StudID = OP.StudID ORDER BY OP.OPNo DESC";

       

        public float temp;
        public int orderOfPaymentID;

        public frmPayment()
        {
            InitializeComponent();

           
            RefreshData(" ");
           
        }



        public static frmPayment CreateInstance()
        {
            frmPayment f;
            if (thisForm == null)
            {
                thisForm = new frmPayment();
            }
            else if (thisForm != new frmPayment())
            {
                thisForm = new frmPayment();
            }

            f = (frmPayment)thisForm;

            return f;
        }

        public void RefreshData(string s = "")
        {
            s = (s != "" && s != " ") ? s : sql;

            new clsDB().Con().FillLvw(lvManageRecord, s);

        }

        public void DbAction(string msg)
        {
            if (msg == "add")
            {
                
            }
            else if (msg == "update")
            {

            }
            else if (msg == "delete")
            {

            }
            else if (msg == "view")
            {

            }
            else
                Close();
        }

        private void lvManageRecord_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvManageRecord.SelectedItems.Count > 0)
            {
                lbPaid.Visible = false;
                btnPay.Enabled = true;
                lbPaid.Text = "PAID( OR # ";
                orderOfPaymentID = int.Parse(lvManageRecord.SelectedItems[0].SubItems[0].Text);

                string query = "SELECT AcctCode, Particular, Amount FROM tbl_PayOrder_Details WHERE OPSeqNo = '" + orderOfPaymentID +"'";

                new clsDB().Con().FillLvw(listView1, query);

                Dictionary<string, string> data = new Dictionary<string, string>();

                new clsDB().Con().SelectDataDictionary("SELECT DISTINCT OP.SemNO , OP.Payor as Payor,OP.DateIssued  FROM tbl_PayOrder as OP LEFT JOIN Student_Account as SA ON OP.StudID = SA.StudID LEFT JOIN Student as S ON S.StudID = OP.StudID WHERE OP.OPNo = " + orderOfPaymentID, data);

                //new clsDB().Con().SelectDataDictionary("SELECT * FROM Student_Account as SA JOIN student as S on SA.StudID = S.StudID JOIN tbl_PayOrder as OP ON SA.StudID = OP.StudID  WHERE OP.OPNo = "+ orderOfPaymentID , data);

                lbFName.Text = data["Payor"] ;

                DateTime dt = DateTime.Parse(data["DateIssued"]);

                lbDate.Text = dt.ToShortDateString();

                OrderOfPayment OP = new OrderOfPayment();

                if (OP.hasORNumber(orderOfPaymentID))
                {
                    btnPay.Enabled = false;
                    lbPaid.Visible = true;
                    lbPaid.Text += OP.ORNumber.ToString() +")";
                }
                 

                
                // Compute Total
                float[] total = Payor.computeAccount(listView1);
                temp = total[0] + total[1];

                lbTotal.Text = "Total = " + Convert.ToString(temp);
                lbTuition.Text = "Tuition = " + Convert.ToString(total[0]);
                lbMsc.Text = "Msc = " + Convert.ToString(total[1]);

                
                listView1.Visible = true;
            }
        }



        private void btnPay_Click(object sender, EventArgs e)
        {
            if (lvManageRecord.SelectedItems.Count > 0)
            {
                frmPaymentDataEntry f = new frmPaymentDataEntry();
                f.total = temp;
                f.orderOfPaymentNo = orderOfPaymentID;
                f.listLength = listView1.Items.Count;
                f.ShowDialog();
            }
            else
                MessageBox.Show(" Please Select an item");
        }



        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
             string searchTerm = tbSearch.Text;

             string searchSql = "SELECT DISTINCT OPNo, OP.amount FROM tbl_PayOrder as OP JOIN Student_Account as SA ON OP.StudID = SA.StudID JOIN student as ST ON ST.StudID = SA.StudID WHERE OP.OPNo LIKE '%"+searchTerm+"%' OR CONCAT(ST.FName, ' ', ST.LName) LIKE '%"+searchTerm+"%' OR CONCAT(ST.LName,' ', ST.LName) LIKE '%"+searchTerm+"%'" ;

             RefreshData(searchSql);
        
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            ePrinting ePrint = new ePrinting();
            ePrint.ePrint();
        }

        private void mtcHideOP_CheckedChanged(object sender, EventArgs e)
        {
            if (mtcHideOP.Checked)
                RefreshData("SELECT OPNo, OP.Amount, OP.Payor, ISNULL(Paid, 0 ) as PAID From tbl_PayOrder as OP RIGHT JOIN Collections as col on col.OPNumber = OP.OPNo ");
            else
                RefreshData(sql);
        }

        private void frmPayment_Load(object sender, EventArgs e)
        {

        }



 

        /*
         * 
         * 
*/





    }
}
