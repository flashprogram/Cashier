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
    public partial class frmManageRecord : MetroForm
    {

        public delegate void MsgHandler(string msg);


        protected static frmManageRecord thisForm;


        public frmManageRecord()
        {
            InitializeComponent();
        }

        private void frmManageRecord_FormClosed(object sender, FormClosedEventArgs e)
        {
            thisForm = null;
        }

        
    }
}
