using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;

namespace Cashier.classes
{
    class clsADO
    {
        private string mConnstring;
        private DataSet dtset = new DataSet("tbl");
        private int Prev=0;
        private int Next=0;
        private int recordCount;

        public int RecordCount
        {
            get { return recordCount; }
        }

        public int CurrentRow
        {
            get { return Prev; }
        }
/*--------------------------------------------------------------------------------------------------------------*/
//      CONSTRUCTOR
/*--------------------------------------------------------------------------------------------------------------*/
        #region Constructor
        //constructor without a parameter defaults to 0
        public clsADO()
        {
            mConnstring = "";
        }

        //constructor with parameter
        public clsADO(string Connstring)
        {
            mConnstring = Connstring;
            
        }

        //destructor
        ~clsADO()
        {
            mConnstring = "";
        }
        #endregion
/*--------------------------------------------------------------------------------------------------------------*/
//      PROPERTIES
/*--------------------------------------------------------------------------------------------------------------*/
        #region ConnectionString
        public string ConnectionString
        {
            get
            {
                return mConnstring;
            }
            set
            {
                mConnstring = value;
            }
        }
        #endregion
/*--------------------------------------------------------------------------------------------------------------*/
//      METHODS
/*--------------------------------------------------------------------------------------------------------------*/
        #region FillLvw
        public void FillLvw(ListView lvw, String sql)
        {
            
            try
            {
                SqlConnection conn = new SqlConnection(mConnstring);
                SqlDataAdapter dtadapter = new SqlDataAdapter(sql, conn);


                conn.Open();

                dtset.Clear();
                dtadapter.Fill(dtset, "tbl");

                lvw.Items.Clear();//clears listview

                recordCount = dtset.Tables["tbl"].Rows.Count;//set RecordCount

                for(int itr = 0; itr < recordCount; itr++)
                {
                    ListViewItem lvitem = new ListViewItem(Convert.ToString(dtset.Tables["tbl"].Rows[itr].ItemArray[0]),0);
                    for (int x = 1; x <= dtset.Tables["tbl"].Columns.Count - 1; x++)
                    {
                        lvitem.SubItems.Add(Convert.ToString(dtset.Tables["tbl"].Rows[itr].ItemArray[x]));
                    }
                    lvw.Items.Add(lvitem);
                }

                conn.Close();
                conn.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error:" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        #endregion //end of filllvw

        #region TranFillvw
        public void TranFillLvw(ListView lvw, String sql)
        {

            try
            {
                SqlConnection conn = new SqlConnection(mConnstring);
                SqlDataAdapter dtadapter = new SqlDataAdapter(sql, conn);


                conn.Open();

                dtset.Clear();
                dtadapter.Fill(dtset, "tbl");

                lvw.Items.Clear();//clears listview

                recordCount = dtset.Tables["tbl"].Rows.Count;//set RecordCount

                for (int itr = 0; itr < recordCount; itr++)
                {
                    ListViewItem lvitem = new ListViewItem(Convert.ToString(dtset.Tables["tbl"].Rows[itr].ItemArray[0]), 0);
                    lvitem.SubItems.Add(Convert.ToString(dtset.Tables["tbl"].Rows[itr].ItemArray[3]));
                    lvitem.SubItems.Add(Convert.ToString(dtset.Tables["tbl"].Rows[itr].ItemArray[4]));
                    lvitem.SubItems.Add(Convert.ToString(dtset.Tables["tbl"].Rows[itr].ItemArray[5]));
                    lvitem.SubItems.Add(Convert.ToString(dtset.Tables["tbl"].Rows[itr].ItemArray[6]));
                    lvitem.SubItems.Add(Convert.ToString(dtset.Tables["tbl"].Rows[itr].ItemArray[7]));
                    if (Convert.ToDouble(dtset.Tables["tbl"].Rows[itr].ItemArray[8]) < 0)
                    {
                        lvitem.SubItems.Add("");
                        lvitem.SubItems.Add(Convert.ToString(dtset.Tables["tbl"].Rows[itr].ItemArray[8]));

                        //lvitem.SubItems.Add("");
                    }
                    else
                    {
                        lvitem.SubItems.Add(Convert.ToString(dtset.Tables["tbl"].Rows[itr].ItemArray[8]));
                        lvitem.SubItems.Add("");

                    }
                    lvitem.SubItems.Add(Convert.ToString(dtset.Tables["tbl"].Rows[itr].ItemArray[9]));

                    //for (int x = 3; x <= dtset.Tables["tbl"].Columns.Count - 1; x++)
                    //{
                    //    lvitem.SubItems.Add(Convert.ToString(dtset.Tables["tbl"].Rows[itr].ItemArray[x]));

                    //    if (x==8)
                    //        if ((float.Parse(lvitem.SubItems.Add(Convert.ToString(dtset.Tables["tbl"].Rows[itr].ItemArray[x])).Text)) < 0)
                    //        {
                    //            lvitem.SubItems.Add("");
                    //            lvitem.SubItems.Add(Convert.ToString(dtset.Tables["tbl"].Rows[itr].ItemArray[x]));
                    //        }
                    //        else
                    //        {
                    //            lvitem.SubItems.Add(Convert.ToString(dtset.Tables["tbl"].Rows[itr].ItemArray[x]));
                    //            lvitem.SubItems.Add("");

                    //        }
                    //}
                    lvw.Items.Add(lvitem);
                }

                conn.Close();
                conn.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error:" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        #endregion
        #region FillListBox
        public void FillListBox(ListBox lb, string sql)
        {
            try
            {
                SqlConnection conn = new SqlConnection(mConnstring);
                SqlDataAdapter dtadapter = new SqlDataAdapter(sql, conn);


                conn.Open();

                dtset.Clear();
                dtadapter.Fill(dtset, "tbl");

                lb.Items.Clear();//clears listview

                recordCount = dtset.Tables["tbl"].Rows.Count;//set RecordCount

                for (int itr = 0; itr < recordCount; itr++)
                {
                    lb.Items.Add(Convert.ToString(dtset.Tables["tbl"].Rows[itr].ItemArray[0]));
                }

                conn.Close();
                conn.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error:" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        #endregion
        #region FillCombobox
        public void FillCombobox(ComboBox cb, String sql)
        {

            try
            {
              SqlConnection conn = new SqlConnection(mConnstring);
                SqlDataAdapter dtadapter = new SqlDataAdapter(sql, conn);


                conn.Open();

                dtset.Clear();
                dtadapter.Fill(dtset, "tbl");

                cb.Items.Clear();//clears listview

                recordCount = dtset.Tables["tbl"].Rows.Count;//set RecordCount

                for (int itr = 0; itr < recordCount; itr++)
                {
                     cb.Items.Add( Convert.ToString(dtset.Tables["tbl"].Rows[itr].ItemArray[0]));
                }

                conn.Close();
                conn.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error:" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        #endregion //end of fillCombobox

        #region Multiple FillCombobox
        public void MultiFillCombobox(ComboBox cb, String sql)
        {

            try
            {
                SqlConnection conn = new SqlConnection(mConnstring);
                SqlDataAdapter dtadapter = new SqlDataAdapter(sql, conn);


                conn.Open();

                dtset.Clear();
                dtadapter.Fill(dtset, "tbl");

                DataTable dtTable = new DataTable();
                dtTable.Columns.Add("code", typeof(string));
                dtTable.Columns.Add("name", typeof(string));
                cb.Items.Clear();//clears listview

                recordCount = dtset.Tables["tbl"].Rows.Count;//set RecordCount

                for (int itr = 0; itr < recordCount; itr++)
                {
                    //cb.Items.Add(Convert.ToString(dtset.Tables["tbl"].Rows[itr][0] + "   " + Convert.ToString(dtset.Tables["tbl"].Rows[itr][1])));
                    dtTable.Rows.Add(Convert.ToString(dtset.Tables["tbl"].Rows[itr][0]),Convert.ToString(dtset.Tables["tbl"].Rows[itr][1]));
                }

                cb.DataSource = dtTable;
                cb.DisplayMember = "name";//Convert.ToString(dtset.Tables["tbl"].Columns[0]);
                cb.ValueMember = "code";//Convert.ToString(dtset.Tables["tbl"].Columns[1]);

                conn.Close();
                conn.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error:" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        #endregion //end of fillCombobox

        #region FillDataGridView
        public void FillDgVw(DataGridView dg, string sql)
        {
            try
            {
                SqlConnection conn = new SqlConnection(mConnstring);
                SqlDataAdapter dtadapter = new SqlDataAdapter(sql, conn);


                conn.Open();

                dtset.Clear();
                dtadapter.Fill(dtset, "tbl");

                //dg.Rows.Clear();//clears DataGridView
                dg.DataSource = dtset.Tables["tbl"];

                recordCount = dtset.Tables["tbl"].Rows.Count;//set RecordCount


                conn.Close();
                conn.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error:" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region SelectData
        public bool SelectData(String sql)
        {
            
            try
            {
                SqlConnection conn = new SqlConnection(mConnstring);
                SqlDataAdapter dtadapter = new SqlDataAdapter(sql, conn);

                conn.Open();

                dtset.Clear();
                dtadapter.Fill(dtset, "tbl");

                recordCount = dtset.Tables["tbl"].Rows.Count;//set RecordCount

                conn.Close();
                conn.Dispose();

                if (recordCount > 0)
                {
                    return true;
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Error:" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return false;
        }

        public bool SelectData(String sql, string[] obj)
        {

            try
            {
                SqlConnection conn = new SqlConnection(mConnstring);
                SqlDataAdapter dtadapter = new SqlDataAdapter(sql, conn);

                conn.Open();

                dtset.Clear();
                dtadapter.Fill(dtset, "tbl");

                recordCount = dtset.Tables["tbl"].Rows.Count;//set RecordCount

                conn.Close();
                conn.Dispose();

                if (recordCount <= 0)
                {
                    return false;
                }

                if (obj != null)
                {
                    obj[0] = Convert.ToString(dtset.Tables["tbl"].Rows[0].ItemArray[0]);

                    for (int x = 1; x <= dtset.Tables["tbl"].Columns.Count - 1; x++)
                    {
                       obj[x] = Convert.ToString(dtset.Tables["tbl"].Rows[0].ItemArray[x]);
                    }
                }

                return true;

            }
            catch (Exception e)
            {
                MessageBox.Show("Error:" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return false;
        }
        #endregion //end of SelectData

        #region ExecuteSql
        public bool ExecuteSql(string sql)
        {
            //string mConnstring = 
            try
            {
                SqlConnection conn = new SqlConnection(mConnstring);
                SqlCommand cmdExecute = new SqlCommand(sql, conn);

                conn.Open();
                cmdExecute.ExecuteNonQuery();

                conn.Close();
                cmdExecute.Dispose();
                conn.Dispose();

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error:" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            return false;
        }
        #endregion //end of ExecuteSql

        #region RecordsetPosition
        public DataSet Recordset(int x)
        {
            if (x <= 0 || x > recordCount)
            {
                x = 0;
            }

            Prev = x;
            Next = x;
            object[] obj = dtset.Tables["tbl"].Rows[x].ItemArray;
            return dtset;
        }
        #endregion //end of recordset position

        #region Previous
        public DataSet PreviousRecord()
        {
            if (Next <= 0)
            {
                Prev = 0;
            }
            else
            {
                Prev = Next - 1;
                Next = Prev;
            }
            if (Prev <= 0)
            {
                Prev = 0;
            }
            return Recordset(Prev);
        }
        #endregion //previous

        #region Next
        public DataSet NextRecord()
        {
            Next += 1;
            if (Next >= recordCount)
            {
                Next = recordCount-1;
            }
            return Recordset(Next);
        }
        #endregion //next

        public void checkAllListView(ListView lv)
        {
            foreach (ListViewItem item in lv.Items)
            {
                item.Checked = !item.Checked;
            }
        }



        // customized
        public void listViewRemoveSelectedIndex(ListView lv)
        {
            if (lv.SelectedItems.Count > 0)
                lv.SelectedItems[0].Remove();
        }

        public bool listViewTransferData(string[][] data, ListView lv, string[] columnList = null)
        {
            bool isValid = false;

            if (data.Length > 0)
            {
                int row = data.Length;
                int count = 0;
                for (int i = 0; i < row; i++)
                {
                    ListViewItem item = new ListViewItem();

                    for(int j = 0 ; j < data[row -1].Length; j++)
                    {
                        item.SubItems.Clear();
                        for (int d = 0; d < lv.Columns.Count ; d++)
                        {
                            if (lv.Columns[d].Text == columnList[count])
                            {
                                item.SubItems.Add(data[i][count]);
                                count++;

                                count = (count >= columnList.Length) ? 0 : count;
                            }
                            else if(count > 0)
                                item.SubItems.Add("");
                        }
                         
                    }

                    lv.Items.Add(item);
                }
                isValid = true;
            }

            return isValid;
        }
        public bool SelectDataDictionary(String sql, Dictionary<string,string> obj)
        {

            try
            {
                SqlConnection conn = new SqlConnection(mConnstring);
                SqlDataAdapter dtadapter = new SqlDataAdapter(sql, conn);

                conn.Open();

                dtset.Clear();
                dtadapter.Fill(dtset, "tbl");

                recordCount = dtset.Tables["tbl"].Rows.Count;//set RecordCount

                conn.Close();
                conn.Dispose();

                if (recordCount <= 0)
                {
                    return false;
                }

                if (obj != null)
                {
            

                    for (int x = 1; x <= dtset.Tables["tbl"].Columns.Count - 1 ; x++)
                    {
                        
                       obj[Convert.ToString(dtset.Tables["tbl"].Columns[x].Caption)] = Convert.ToString(dtset.Tables["tbl"].Rows[0].ItemArray[x]);
                    }
                }

                return true;

            }
            catch (Exception e)
            {
                MessageBox.Show("Error:" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return false;
        }

        public int countRecord(String sql)
        {
            SqlConnection conn = new SqlConnection(mConnstring);
            SqlDataAdapter dtadapter = new SqlDataAdapter(sql, conn);

            try
            {
                conn.Open();

                dtset.Clear();
                dtadapter.Fill(dtset, "tbl");



                recordCount = dtset.Tables["tbl"].Rows.Count;//set RecordCount

            }
            catch(Exception ex)
            {
                MessageBox.Show("Cannot connect to server please check your connection or contact the ICT Dept");
            }
            
            return recordCount;
        }

        public bool checkConnection()
        {
            try
            {
                SqlConnection conn = new SqlConnection(mConnstring);

                conn.Open();
                conn.Close();
                conn.Dispose();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

            return true;
          
        }

        public string[][] SelectData(String sql, string[][] obj)
        {

            try
            {
                SqlConnection conn = new SqlConnection(mConnstring);
                SqlDataAdapter dtadapter = new SqlDataAdapter(sql, conn);


                conn.Open();

                dtset.Clear();
                dtadapter.Fill(dtset, "tbl");

                  

                recordCount = dtset.Tables["tbl"].Rows.Count;//set RecordCount


                 
                for (int itr = 0; itr < recordCount; itr++)
                {

                    string[] tempObj = new string[dtset.Tables["tbl"].Columns.Count];
                    for (int x = 0; x <= dtset.Tables["tbl"].Columns.Count - 1 ; x++)
                    {
                          
                            tempObj[x] = Convert.ToString(dtset.Tables["tbl"].Rows[itr].ItemArray[x]);
                    }

                    obj[itr] = tempObj;
                }

                conn.Close();
                conn.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error:" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return obj;

        }
   
    }
    
}
