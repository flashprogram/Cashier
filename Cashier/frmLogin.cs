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
    public partial class frmLogin : MetroForm
    {
        private frmHome.MsgHandler Selected;
        public int userID;
        

        public frmLogin(frmHome.MsgHandler s)
        {
            clsCollection col = new clsCollection();

            col.summaryOfCollection(3);

            InitializeComponent();
            Selected = s;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            progress.Visible = true;
            
            string username = Helper.strIsEmpty(tbUsername.Text, true) ? "" : tbUsername.Text;
            string password = Helper.strIsEmpty(tbPassword.Text,true) ? "" : tbPassword.Text ;

            if ((username != "" && password != ""))
            {
                User user = new User();
                if (user.Login(username, password))
                {
                    user.getUserData();
                    userID = user.userID;
                    Selected("home");
                }
                else
                    MessageBox.Show("Invalid username or password", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            progress.Visible = false;
        }

        private void tbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                progress.Visible = true;
                btnLogin_Click(null, null);
            }
        }

      

     
    }
}
