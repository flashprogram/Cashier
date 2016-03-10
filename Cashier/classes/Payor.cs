using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cashier.classes;
using System.Windows.Forms;

namespace Cashier.classes
{
    class Payor
    {
        public static float[] computeAccount(ListView lv)
        {
            // tuition fee is index 0 msc fee is index 1
            float[] account = { 0, 0 };

            foreach (ListViewItem item in lv.Items)
            {
                bool isTution = false;
                int count = 0;

                foreach (ListViewItem.ListViewSubItem subitem in item.SubItems)
                {
                   

                    if (isTution)
                    {
                        if (count + 1 < item.SubItems.Count )
                            account[0] = float.Parse(subitem.Text) - float.Parse(item.SubItems[count + 1].Text);
                        else
                            account[0] = float.Parse(subitem.Text);
                        isTution = false;
                    }
                    else if (lv.Columns[count].Text == "Amount")
                    {

                        if(item.SubItems.Count > 3 && count < item.SubItems.Count -1)
                             account[1] += (float.Parse(subitem.Text) - float.Parse(item.SubItems[count + 1].Text));
                        else
                            account[1] += (float.Parse(subitem.Text) );
                    }


                    if (subitem.Text == "Tuition Fee")
                    {
                        isTution = true;

                    }

                    count++;
                }

            }

            return account;
        }

        public static bool isPayorStudent(string FName, string MName, string LName)
        {
            string query = "SELECT * FROM Student WHERE FName = '" + FName + "' AND LName = '" + LName + "'";
            bool isValid = false;

            if (new clsDB().Con().countRecord(query) > 0)
                isValid = true;

            return isValid;
        }


        public static bool validateCheckDetails(string bankname, string checkNo, string checkDate, string checkAmount)
        {
            bool isValid = false;

            if (!Helper.strIsEmpty(bankname) && !Helper.strIsEmpty(checkNo) &&  !Helper.strIsEmpty(checkDate) && Helper.IsNumeric(checkAmount))
            {
                isValid = true;
            }


            return isValid;

        }

        public static string[][] getCheckedItems(ListView lv)
        {
            // get the column and row count of the records
            int columnCount = lv.CheckedItems[0].SubItems.Count;
            int rowCount = lv.CheckedItems.Count;


            // use multidimensional array to store an array of string
            string[][] checkedItems = new string[rowCount][];
            string[] subItems = new String[columnCount];

            // check if student selected is more that 1 ( Note studentID is in column # 2 )
            string currStudent = lv.CheckedItems[0].SubItems[1].Text;
        

            // loop through the values
            for (int j = 0; j < rowCount; j++)
            {
                subItems = new string[columnCount];

                for (int i = 0; i < columnCount; i++)
                {


                    subItems[i] = lv.CheckedItems[j].SubItems[i].Text;
                }
                checkedItems[j] = subItems;
            }

            return checkedItems;
        }

    }
}
