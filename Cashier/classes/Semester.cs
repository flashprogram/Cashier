using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cashier.classes;

namespace Cashier.classes
{
    class Semester
    {
        public static int getCurrentSemester(string semYrName = "")
        {
            string addQuery = "";
            int final;
            if (!Helper.strIsEmpty(semYrName) || !string.IsNullOrEmpty(semYrName) || semYrName != "")
            {
                addQuery = "JOIN SemesterYr as SY ON SY.SemNo = SA.SemNo WHERE SY.SemYr = '" + semYrName + "'";
            }
            string query = "SELECT TOP 1 SA.SemNo FROM Student_Account as SA "+addQuery+" ORDER BY SA.SemNo DESC";

            string[] obj = new string[1] ;

            new clsDB().Con().SelectData(query, obj);

            if (string.IsNullOrEmpty(obj[0]))
                final = 0;
            else
                final = int.Parse(obj[0]);

            return final;

        }

        public static string getCurrentSemesterString()
        {
            string query = "SELECT TOP 1 SemYr From SemesterYr as SY JOIN Student_Account as SA ON SA.SemNo = SY.SemNo ORDER BY SA.SemNo DESC";

            string[] obj = new string[1];

            new clsDB().Con().SelectData(query, obj);

            return obj[0];
        }
    }


}
