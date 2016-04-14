using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Cashier.classes;
using System.Data.SqlClient;

namespace Cashier
{
    public partial class frmOrPayManageData : frmManageRecord
        
    {
        //, IMessageFilter
        // query string ( table name can be orderOfPayment or StudentAccount[in the server]) 
        //string sql = "SELECT * FROM studentAccount JOIN student ON student.StudID = studentAccount.StudID WHERE Balance > 0";
        AutoCompleteStringCollection DataCollection;
        string sql = "SELECT  TOP 50 SA.SemNo, SA.StudID,S.StudNo, SUM(Amount - ISNULL(Payment, 0 )) as Amount ,FName, MName, LName, ProgCode  FROM Student_Account as SA JOIN Student as S ON SA.StudID = S.StudID JOIN StudentCourse as SC ON SC.StudID = SA.StudID WHERE SA.semNo = " + Semester.getCurrentSemester() + " GROUP BY SA.StudID,S.StudNo, SA.SemNo,FName, MName,LName, ProgCode ";
        string opQuery = "SELECT TOP 50 OPNo, OP.Amount, CAST( CASE WHEN OP.Payor IS NULL OR OP.Payor = '' THEN CONCAT(FName,' ',MName,' ',LName) ELSE OP.Payor END AS varchar(100))  as Payor, CAST (CASE WHEN  PAID = 0 THEN 'Not Paid' ELSE 'Paid' END as varchar(50) ) as Paid From tbl_PayOrder as OP LEFT JOIN Student as S ON S.StudID = OP.StudID WHERE Paid = 0 ORDER BY OP.DateIssued DESC";
       
        public int lastOPNumber = int.Parse(OrderOfPayment.getLastOPNo());
        public int tempStudID = 0;

        public frmOrPayManageData()
        {
            InitializeComponent();
            

            //Application.AddMessageFilter(this);
            RefreshData(" ");

            new clsDB().Con().FillLvw(lvOP, opQuery);

            lbOPCount.Text = ""+OrderOfPayment.getNumberOfOP();
            lbPaidOPCount.Text = ""+OrderOfPayment.getNumberOfPaidOP();
            mtbStudent.Focus();
        }

       

        public static frmOrPayManageData CreateInstance()
        {
            frmOrPayManageData f;
            if (thisForm == null)
            {
                thisForm = new frmOrPayManageData();
            }
            else if (thisForm != new frmOrPayManageData())
            {
                thisForm = new frmOrPayManageData();
            }

            f = (frmOrPayManageData)thisForm;
            f.mtbStudent.Focus();
            return f;
        }

        public void RefreshData(string s = "")
        {
            s = (s != "" && s != " " ) ? s : sql;

            new clsDB().Con().FillLvw(lvManageRecord, s);
            new clsDB().Con().FillLvw(lvOP, opQuery);
        }

        public void DbAction(string msg)
        {
            if (msg == "add")
            {
                addPayment();
            }
            else if (msg == "update")
            {

            }
            else if (msg == "delete")
            {

            }
            else if (msg == "view")
            {

            }
            else if (msg == "refresh")
            {
                RefreshData(" ");
            }
            else
                Close();
        }

        // #  --------------------   DBACTIONS ---------------------------
        private void addPayment()
        {
            if (lvManageRecord.CheckedItems.Count < 1)
            {
                frmOrPayDataEntry f = frmOrPayDataEntry.show_asAdd(new MsgHandler(RefreshData), this.lastOPNumber);
                if (f.hasUpdated)
                    this.lastOPNumber = f.lastOPNumber;
            }
            else
            {
                // instantiate an object of student
                Student st = new Student(lvManageRecord.CheckedItems[0].SubItems[1].Text);

                // pass values to form

                frmOrPayDataEntry.checkedItems = Payor.getCheckedItems(lvManageRecord);
                frmOrPayDataEntry.studentData = st.studentData;


                frmOrPayDataEntry f = frmOrPayDataEntry.show_asAdd(new MsgHandler(RefreshData), this.lastOPNumber);

                if (f.hasUpdated)
                    this.lastOPNumber = f.lastOPNumber;
              
            }
            

        }
        // # ---------------   END OF DB ACTIONS --------------------------


        // #EVENT LISTENER
        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = tbSearch.Text;
            if(string.IsNullOrEmpty(searchTerm) || Helper.strIsEmpty(searchTerm))
               new clsDB().Con().FillLvw(lvManageRecord, sql);
            else
                new clsDB().Con().FillLvw(lvManageRecord, StudentAccount.searchAccount(searchTerm));
                
        }

        public void btnPartialPayment_Click(object sender, EventArgs e)
        {
            if ( lvManageRecord.CheckedItems.Count > 0)
            {
          
                    Student st = new Student(lvManageRecord.CheckedItems[0].SubItems[1].Text);
                    frmPartialPayment f = new frmPartialPayment(this.lastOPNumber);
                    f.ControlBox = false;
                    f.studentData = st.studentData;

                    f.ShowDialog();
                    
                    if(f.hasUpdated)
                        this.lastOPNumber = f.lastOPNumber;

                    RefreshData(" ");
    
            }
            else if(!string.IsNullOrEmpty(mtlStudID.Text) && !Helper.strIsEmpty(mtlStudID.Text))
            {
                  Student st = new Student(mtlStudID.Text);
                frmPartialPayment f = new frmPartialPayment(this.lastOPNumber);
                f.ControlBox = false;
                f.studentData = st.studentData;

                f.ShowDialog();
                if(f.hasUpdated)
                    this.lastOPNumber = f.lastOPNumber;

                RefreshData(" ");
            }
            else
            {
                MessageBox.Show("Please Select/Search a student first ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        // from : http://stackoverflow.com/questions/6697306/c-sharp-capture-main-form-keyboard-events
       /*
        public bool PreFilterMessage(ref Message m)
        {
            //here you can specify  which key you need to filter

            if (m.Msg == 0x0100 && (Keys)m.WParam.ToInt32() == Keys.L &&  ModifierKeys == Keys.Control)
            {
                
                btnPartialPayment_Click(null, null);
                return true;
            }
            else if (m.Msg == 0x0100 && (Keys)m.WParam.ToInt32() == Keys.Q && ModifierKeys == Keys.Control)
            {
                MessageBox.Show("2");
                tbSearch.Focus();
                return true;
            }
            else
            {
                return false;
            }
        }
        */
        private void lvManageRecord_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (lvManageRecord.CheckedItems.Count > 0)
            {
                btnPartialPayment_Click(sender, null);
            }
        }

        private void frmOrPayManageData_FormClosed(object sender, FormClosedEventArgs e)
        {
            thisForm = null;
        }

        private void mtcViewPaid_CheckedChanged(object sender, EventArgs e)
        {
            if (mtcViewPaid.Checked)
                new clsDB().Con().FillLvw(lvOP, "SELECT TOP 50 OPNo, OP.Amount, CAST( CASE WHEN OP.Payor IS NULL OR OP.Payor = '' THEN CONCAT(FName,' ',MName,' ',LName) ELSE OP.Payor END AS varchar(100))  as Payor, CAST (CASE WHEN  PAID = 0 THEN 'Not Paid' ELSE 'Paid' END as varchar(50) ) as Paid From tbl_PayOrder as OP  LEFT JOIN Student as S ON S.StudID = OP.StudID WHERE Paid = 1 ORDER BY OP.DateIssued DESC ");
            else
                new clsDB().Con().FillLvw(lvOP, opQuery);
        }

        private void mtcbBalance_CheckedChanged(object sender, EventArgs e)
        {
            if (mtcViewPaid.Checked)
                new clsDB().Con().FillLvw(lvManageRecord, "SELECT  TOP 50 SA.SemNo, SA.StudID,S.StudNo, SUM(Amount - ISNULL(Payment, 0 )) as Amount ,FName, MName, LName, ProgCode  FROM Student_Account as SA JOIN Student as S ON SA.StudID = S.StudID JOIN StudentCourse as SC ON SC.StudID = SA.StudID WHERE SA.semNo = " + Semester.getCurrentSemester() + " AND ISNULL(SA.Balance,0)  >   0 AND Amount >= ISNULL(Payment, 0)   GROUP BY SA.StudID,S.StudNo, SA.SemNo,FName, MName,LName, ProgCode ");
            else
                new clsDB().Con().FillLvw(lvManageRecord, sql);
        }

        private void lvOP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvOP.SelectedItems.Count > 0)
            {
                mtOPDetails.Enabled = true;
                mtPaymentHistory.Enabled = true;
                mtReissue.Enabled = true;
            }
            else
            {
                mtOPDetails.Enabled = false;
                mtPaymentHistory.Enabled = false;
                mtReissue.Enabled = false;
            }
        }

        private void lvOP_Leave(object sender, EventArgs e)
        {
            
            /*mtOPDetails.Enabled = false;
            mtPaymentHistory.Enabled = false;
            mtReissue.Enabled = false;*/
        }

        public void manageTopMenu(ToolStrip ts)
        {
           
            ts.Items[3].Text = "Other Payments";
            ts.Items[3].Width = 150;
            ts.Items[3].Visible = true;
            ts.Items[4].Visible = false;
            ts.Items[5].Visible = false;
            ts.Items[6].Visible = false;

        }

        private void mtOPDetails_Click(object sender, EventArgs e)
        {
          
            if (lvOP.SelectedItems.Count > 0)
            {
                frmOPDetails f = new frmOPDetails();
                f.OPNo = int.Parse(lvOP.SelectedItems[0].SubItems[0].Text);
                f.ShowDialog();
            }
        }

        private void metroTabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = metroTabControl1.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = metroTabControl1.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {

                // Draw a different background color, and don't paint a focus rectangle.
                _textBrush = new SolidBrush(Color.Red);
                g.FillRectangle(Brushes.Gray, e.Bounds);
            }
            else
            {
                _textBrush = new System.Drawing.SolidBrush(e.ForeColor);
                e.DrawBackground();
            }

            // Use our own font.
            Font _tabFont = new Font("Arial", (float)10.0, FontStyle.Bold, GraphicsUnit.Pixel);

            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }


        private void metroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvManageRecord.Visible = false;
            groupBox1.Visible = false;
            lvManageRecord.SendToBack();
            groupBox1.SendToBack();

            if (metroTabControl1.SelectedTab == metroTabControl1.TabPages["studList"])
            {
                lvManageRecord.Visible = true;
                groupBox1.Visible = true;
                lvManageRecord.BringToFront();
                groupBox1.BringToFront();
            }
            else
            {
                mtpStudInfo.Visible = false;
                mtbOP.Visible = false;
            }
            
        }

        private void lvStudSearch_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            using (var sf = new StringFormat())
            {
                sf.Alignment = StringAlignment.Center;

                using (var headerFont = new Font("Microsoft Sans Serif", 12, FontStyle.Bold))
                {
                    e.Graphics.FillRectangle(Brushes.Pink, e.Bounds);
                    e.Graphics.DrawString(e.Header.Text, headerFont,
                        Brushes.Black, e.Bounds, sf);
                }
            }
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            frmSearchStudent f;
            if (mtbStudent.Text.Length > 0)
                f = new frmSearchStudent(mtbStudent.Text);
            else
                f = new frmSearchStudent();
            f.ShowDialog();

            if(f.StudID > 0 )
            {
                this.tempStudID = f.StudID;
                Student st = new Student(this.tempStudID.ToString());

                mtbStudent.Text = st.studentData[2] + ", " + st.studentData[3] + " " + st.studentData[4];
                mtbStudent_KeyDown(null, null);
            }


        }

        private void metroLink2_Click(object sender, EventArgs e)
        {
            metroTabControl1.SelectedTab = metroTabControl1.TabPages["studList"];
        }

        private void metroLink3_Click(object sender, EventArgs e)
        {
            metroTabControl1.SelectedTab = metroTabControl1.TabPages["studInfo"];
        }

        private void metroLink4_Click(object sender, EventArgs e)
        {
            metroTabControl1.SelectedTab = metroTabControl1.TabPages["payHistory"];
        }

        private void metroLink5_Click(object sender, EventArgs e)
        {
            metroTabControl1.SelectedTab = metroTabControl1.TabPages["opList"];
        }

        private void mtSearch_Click(object sender, EventArgs e)
        {
            metroTabControl1.SelectedTab = metroTabControl1.TabPages["studSearch"];
        }

        private void mtInfo_Click(object sender, EventArgs e)
        {
            metroTabControl1.SelectedTab = metroTabControl1.TabPages["studInfo"];
        }

        private void mtOPList_Click(object sender, EventArgs e)
        {
            metroTabControl1.SelectedTab = metroTabControl1.TabPages["opList"];
        }

        private void mtHistory_Click(object sender, EventArgs e)
        {
            metroTabControl1.SelectedTab = metroTabControl1.TabPages["payHistory"];
        }

        private void mtStudList_Click(object sender, EventArgs e)
        {
            metroTabControl1.SelectedTab = metroTabControl1.TabPages["studList"];
        }



      
        //from http://net-informations.com/q/faq/autocomplete.html
       
        private void frmOrPayManageData_Load(object sender, EventArgs e)
        {
            mtbStudent.AutoCompleteMode = AutoCompleteMode.Suggest;
            mtbStudent.AutoCompleteSource = AutoCompleteSource.CustomSource;
            DataCollection = new AutoCompleteStringCollection();

          
                getData(DataCollection);
                mtbStudent.AutoCompleteCustomSource = DataCollection;
           

          
        
        }

        private void getData(AutoCompleteStringCollection dataCollection)
        {
            
            SqlConnection connection;
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet ds = new DataSet();

            string sql = "SELECT DISTINCT TOP 30  CONCAT(LName,',',FName,' ',MName,'(',StudNo,')') FROM Student WHERE  ( StudNo Like '%" + mtbStudent.Text + "%' )  OR  ( CONCAT(LName,', ', FName) LIKE '%" + mtbStudent.Text + "%'    OR CONCAT(FName,' ',LName) LIKE '%" + mtbStudent.Text +"%' )";
            connection = new SqlConnection( Connect.ToDB());
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                adapter.SelectCommand = command;
                adapter.Fill(ds);
                adapter.Dispose();
                command.Dispose();
                connection.Close();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    dataCollection.Add(row[0].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }

    

        private void mtbStudent_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(mtbStudent.Text) && !Helper.strIsEmpty(mtbStudent.Text))
            {
               // getData(DataCollection);
               // mtbStudent.AutoCompleteCustomSource = DataCollection;
            }
        }

 

        private void mtbStudent_KeyDown(object sender, KeyEventArgs e) 
        {
            try
            {
                if (e.KeyCode == Keys.F5)
                {
                    metroLink1_Click(null, null);
                }
                if (e.KeyCode == Keys.Enter)
                {
                    metroLink1_Click(null, null);
                }
            }
            catch (Exception ex) { }

            if (this.tempStudID > 0)
            {
              
                Student st = new Student(""+tempStudID);

                if (st.isStudent)
                {
                    mtpStudInfo.Visible = true;
                    mtbOP.Visible = true;
                    mtlName.Text =   st.studentData[2] + ", " + st.studentData[3] + " " + st.studentData[4];
                    mtlCourse.Text = st.course();
                    mtlStudID.Text = st.studentData[0];
                    mtlLastAttended.Text = st.lastAttended();

                    StudentAccount SA = new StudentAccount(tempStudID);
                    Dictionary<string, float> dict = SA.getStudentAccountBalances();
                }
                else
                    MessageBox.Show("Invalid Student Data");

            }
            else
                mtbOP.Visible = false;
        }

        private void mtbOP_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(mtlStudID.Text) && !Helper.strIsEmpty(mtlStudID.Text))
                btnPartialPayment_Click(sender, null);
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            new clsDB().Con().FillLvw(lvOP, opQuery);
            lbOPCount.Text = "" + OrderOfPayment.getNumberOfOP();
            lbPaidOPCount.Text = "" + OrderOfPayment.getNumberOfPaidOP();
        }

        private void mtbStudent_Click(object sender, EventArgs e)
        {

        }

        private void mtbStudent_Enter(object sender, EventArgs e)
        {
            metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            metroToolTip1.Show(" Press : F5/Enter to Search  ", mtbStudent, mtbStudent.Width / 2, mtbStudent.Height, 10000000);
        }

        private void mtbStudent_Leave(object sender, EventArgs e)
        {
            metroToolTip1.Hide(mtbStudent);
        }




























        // END OF EVENT LISTENER

    }
}
