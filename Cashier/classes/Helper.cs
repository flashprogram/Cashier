using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cashier.classes
{
    class Helper
    {
        //static helpers

        public static bool strIsEmpty(string text, bool hasMessage = false)
        {
            if (text == "" || text == " ")
            {
                if (hasMessage)
                    MessageBox.Show("There are some fields missing!");

                return true;
            }

            return false;
        }

        public static bool hasDuplicate(string columnName, string colValue, string table)
        {
            string sql;
            if (IsNumeric(colValue))
                 sql = "SELECT * FROM " + table + " WHERE " + columnName + " = " + colValue ;
            else
                 sql = "SELECT * FROM " + table + " WHERE " + columnName + " = '" + colValue +"'";

          
            bool hasDuplicate = new clsDB().Con().SelectData(sql);
           
            if (hasDuplicate)
            {
                MessageBox.Show("Duplicate Entry ( " + columnName + ")" );
                return true;
            }

            return false;
        }

        // Source : http://stackoverflow.com/questions/894263/how-to-identify-if-a-string-is-a-number
        public static bool IsNumeric(object Expression)
        {
            double retNum;

            bool isNum = Double.TryParse(Convert.ToString(Expression), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);
            return isNum;
        }

        public static void closeOtherForm(string formName)
        {
            for (int index = Application.OpenForms.Count - 1; index >= 0; index--)
            {
               
                if (Application.OpenForms[index].Name == formName)
                {
                    Application.OpenForms[index].Close();
                }
            }
        }


  


    }
}
