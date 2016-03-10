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
    public partial class frmCancelOR : MetroForm
    {
        public frmCancelOR()
        {
            InitializeComponent();
        }


        // Cancel OR button
        private void metroButton1_Click(object sender, EventArgs e)
        {
            // Validate OR Number

            string query = "SELECT Fund,* FROM Collections WHERE ORNumber = " + tbCancelOR.Text + " AND ISNULL(PaymentType,0) !=  9";
            Dictionary<string, string> data = new Dictionary<string, string>();

            new clsDB().Con().SelectDataDictionary(query, data);

            if (new clsDB().Con().countRecord(query) > 0)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to Cancel this OR ?" + data["ORNumber"], "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    query = "UPDATE Collections SET PaymentType = 9, Remarks = 'Cancelled' WHERE ORNumber = " + tbCancelOR.Text;

                    if (new clsDB().Con().ExecuteSql(query))
                    {
                        MessageBox.Show("OR was successfully Canceled ");
                    }


                }
            }
            else
                MessageBox.Show("Invalid OR Number / OR have already been cancelled ");

        }

        private void tbCancelOR_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                metroButton1_Click(null, null);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
