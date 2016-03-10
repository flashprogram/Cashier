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
    public partial class frmMainMenu : Form
    {
        private frmHome.MsgHandler Selected;


        public frmMainMenu(frmHome.MsgHandler s)
        {
            InitializeComponent();
            Selected = s;

            listView1.Items.Add("Order Of Payment", 0);
            listView1.Items.Add("Process Payment",2);
            listView1.Items.Add("Reports", 7);
            listView1.Items.Add("Dummy 2", 4);
            listView1.Items.Add("Dummy 3", 5);

            listView1.Items.Add("Dummy 4", 6);
            listView1.Items.Add("Dummy 5", 7);
            
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems[0].Text == "Order Of Payment")
            {
                Selected("orderOfPayment");
            }
            else if (listView1.SelectedItems[0].Text == "Process Payment")
            {
                Selected("manageOrderOfPayment");
            }
            else if (listView1.SelectedItems[0].Text == "Reports")
            {
                Selected("reports");
            }
            else
            {
                Close();
            }
        }





        
    }
}
