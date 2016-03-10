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
    public partial class frmDailyReportParticular : MetroForm
    {
        public string date;
        public frmDailyReportParticular()
        {
            InitializeComponent();
        }

        private void frmDailyReportParticular_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'SCIISDataSet2.dailyReportPerParticular' table. You can move, or remove it, as needed.
            this.dailyReportPerParticularTableAdapter.Fill(this.SCIISDataSet2.dailyReportPerParticular, date);
            this.mtDate.Text = date;
            this.reportViewer1.RefreshReport();
        }
    }
}
