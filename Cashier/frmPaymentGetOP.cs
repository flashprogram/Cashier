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
            int OPNo = int.Parse(tOPNo.Text);
            float temp = 0;
            string query = "SELECT * FROM tbl_PayOrder WHERE OPNo = " + OPNo;

            if (new clsDB().Con().countRecord(query) > 0)
            {
                // Compute Total
                query = "SELECT AcctCode, Particular, Amount FROM tbl_PayOrder_Details WHERE OPSeqNo = '" + OPNo + "'";

                new clsDB().Con().FillLvw(listView1, query);
                float[] total = Payor.computeAccount(listView1);
                temp = total[0] + total[1];
                frmPaymentDataEntry f = new frmPaymentDataEntry();
                f.total = temp;
                f.orderOfPaymentNo = OPNo;
                f.listLength = listView1.Items.Count;
                f.ShowDialog();
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

    }
}
