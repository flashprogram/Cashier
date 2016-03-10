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
    public partial class frmReportDaily : MetroForm
    {
        public frmReportDaily()
        {
            InitializeComponent();
        }

        private void frmReportDaily_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'SCIISDataSet.cashierDailyReport' table. You can move, or remove it, as needed.
            this.cashierDailyReportTableAdapter.Fill(this.SCIISDataSet.cashierDailyReport, dtDailyReportDate.Value.ToShortDateString());
            

            this.reportViewer1.RefreshReport();
           
        }

        private void dtDailyReportDate_ValueChanged(object sender, EventArgs e)
        {
            frmReportDaily_Load(null, null);
        }

        private void mtDetailed_Click(object sender, EventArgs e)
        {
            frmDailyReportParticular f = new frmDailyReportParticular();
            f.date = dtDailyReportDate.Value.ToShortDateString();
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ePrinting print = new ePrinting();
            print.isLandscape = true;
            print.forReport = true;
            print.date = dtDailyReportDate.Value.ToShortDateString();
            print.OPType = (cmbOPType.Text == "BTR") ? 1 : (cmbOPType.Text == "UNDERGRAD") ? 2 : (cmbOPType.Text == "MASTERAL") ? 3 : (cmbOPType.Text == "FIDUCIARY") ? 4 : (cmbOPType.Text == "IGP") ? 5 : 0;
            print.OPTypeText = cmbOPType.Text;
            
            print.ePrint("DRLayoutOne");
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            ePrinting print = new ePrinting();
            print.isLandscape = true;
            print.forReport = true;
            print.date = dtDailyReportDate.Value.ToShortDateString();
            print.OPType = (cmbOPType.Text == "BTR") ? 1 : (cmbOPType.Text == "UNDERGRAD") ? 2 : (cmbOPType.Text == "MASTERAL") ? 3 : (cmbOPType.Text == "FIDUCIARY") ? 4 : (cmbOPType.Text == "IGP") ? 5 : 0;
            print.OPTypeText = cmbOPType.Text;

            print.ePrint("DRLayoutOne");
        }


    }
}
