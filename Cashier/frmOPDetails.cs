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
    public partial class frmOPDetails : MetroForm
    {
        public int OPNo;

        public frmOPDetails()
        {
            InitializeComponent();
        }

        private void frmOPDetails_Load(object sender, EventArgs e)
        {
            OrderOfPayment OP = new OrderOfPayment();
            Dictionary<string,string> data = OP.getOPDataWOOR(OPNo);

            mtOPNo.Text = "" + OPNo;
            mtPayor.Text = data["Payor"];
            mtTotal.Text = data["Amount"];
            mtDateIssued.Text = data["DateIssued"];
            mtPaid.Text = OP.getPaymentStatus();
            mtOPType.Text = OP.getOPType();
            this.ControlBox = true;

            string[][] particulars =  OP.getOrderOfPaymentItem(OPNo);
            new clsDB().Con().listViewTransferData(particulars, listView1);

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmOPDetails_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                this.Close();
            }
        }

  
    }
}
