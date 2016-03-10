using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cashier
{
    public partial class frmOrderOfPaymentPrint : Form
    {
        private int OPID, OPNO;
        public frmOrderOfPaymentPrint()
        {
            InitializeComponent();
        }
        public frmOrderOfPaymentPrint(int orderOfPaymentID, int orderOfPaymentNo)
        {
            OPID = orderOfPaymentID;
            OPNO = orderOfPaymentNo;
           
            InitializeComponent();
        }

        private void frmOrderOfPaymentPrint_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cashierDataSet1.getOrderOfPayment' table. You can move, or remove it, as needed.
            this.getOrderOfPaymentTableAdapter.Fill(this.cashierDataSet1.getOrderOfPayment,OPID,OPNO);
            

            this.reportViewer1.RefreshReport();
        }
    }
}
