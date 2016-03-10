using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cashier.classes;

namespace Cashier.classes
{
    class Student
    {

        public string[] studentData = new string[35];
        public int StudID;
        public bool isStudent = false;
        // constructor
        public Student(string StudID = null)
        {
            if (StudID != null)
            {
                this.StudID = int.Parse(StudID);
                new clsDB().Con().SelectData("SELECT * FROM student WHERE StudID = " + StudID, studentData);
            }
        }

        public string course()
        {
            string course = "";
            string[] obj = new string[1];

            new clsDB().Con().SelectData("SELECT ProgCode FROM StudentCourse as SC JOIN Student as S ON SC.StudID = S.StudID WHERE SC.StudID = " + StudID, obj);

            course = obj[0];

            return course;
        }

        public Student (Dictionary<string, string> data)
        {
            // Remember that the data format is :
            // Index 0 will be the student Number 
            // Index 1 will be the lastname
            // Index 2 will be the firstname and middlename (because it's hard to identify the middlename and firstname)

            if (new clsDB().Con().SelectData("SELECT StudID,StudNo,FName,MName,LName FROM student WHERE " + data.Keys.ToList()[0] + " = '" + data[data.Keys.ToList()[0]] + "' AND datalength(StudNo) > 0 OR LName = '" + data[data.Keys.ToList()[1]] + "' AND CONCAT(FName,' ', MName) = '" + data[data.Keys.ToList()[2]] + "' ", studentData))
            {
                isStudent = true;
                StudID = int.Parse(studentData[0]);
            }
            else
                isStudent = false;
        }

  



    }
}
