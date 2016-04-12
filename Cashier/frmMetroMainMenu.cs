using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Cashier
{
    public partial class frmMetroMainMenu : MetroForm
    {
        private frmHome.MsgHandler Selected;
        public string user_type;

        public frmMetroMainMenu(frmHome.MsgHandler s)
        {
            InitializeComponent();
            Selected = s;

            mtInfoOPIssued.Text += " ["+  DateTime.Now.ToShortDateString() +"]";
            mtInfoOPPaid.Text += " [" + DateTime.Now.ToShortDateString() + "]";
            label1.Width = base.Size.Width;
        }

   

        private void mtCashier_Click(object sender, EventArgs e)
        {
            Selected("manageOrderOfPayment");
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            Selected("reports");
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Selected("orderOfPayment");
        }

        public void validateUserType()
        {
            switch(user_type)
            {
                case("Cashier"):
                {
                    mtOP.Enabled = false;
                    mtCashier.Enabled = true;
                    mtReports.Enabled = true;
                    mtOPSearch.Enabled = true;
                    mtbCancelOR.Enabled = true;

                    set_cashier();
                 
                    break;
                }
                case ("Accounting"):
                {
                    mtOP.Enabled = true;
                    mtCashier.Enabled = false;

                    mtReports.Enabled = false;
                    mtOPSearch.Enabled = false;
                    mtbCancelOR.Enabled = false;

                    set_cashier(false);

                    break;
                }
                    
            }
        }


        private void set_cashier(bool set = true)
        {
            mtTotalCollection.Visible = set;
            lbTotalCollection.Visible = set;

            lbSummaryOfCollection.Visible = set;
            lvSummaryOfCollection.Visible = set;

            string date = DateTime.Now.ToShortDateString();
            Cashier.classes.clsCollection c = new Cashier.classes.clsCollection();
            Dictionary<string, float> summary = c.summaryOfCollection(2, date);

            if (lvSummaryOfCollection.Items.Count > 0)
                lvSummaryOfCollection.Items.Clear();

            for (int i = 0; i < summary.Count; i++)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.SubItems[0].Text = summary.Keys.ToList()[i];
                ListViewItem.ListViewSubItem item = new ListViewItem.ListViewSubItem();
                item.Text = Convert.ToString(summary[summary.Keys.ToList()[i]]);
                lvi.SubItems.Add(item);
               

                lvSummaryOfCollection.Items.Add(lvi);
               

            }

            
            mtTotalCollection.Text = "Total Collection as of : " + date;

            lbTotalCollection.Text = String.Format("{0:#,##0.##}", Cashier.classes.clsCollection.getDailyAccumulatedAmount(date)); 
        }

        private void mtOPSearch_Click(object sender, EventArgs e)
        {
            frmPaymentGetOP f = new frmPaymentGetOP();
            f.parent = this;
            f.ShowDialog();
        }

        private void mtbCancelOR_Click(object sender, EventArgs e)
        {
            frmCancelOR f = new frmCancelOR();
            f.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            set_cashier();
        }

        private void lbSummaryOfCollection_Click(object sender, EventArgs e)
        {

        }

  

     
    }
}
