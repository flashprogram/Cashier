using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cashier.classes;

namespace Cashier.classes
{
    class User
    {
        public bool isLoggedIn = false;
        public int userID ;
        public Dictionary<string, string> userData = new Dictionary<string, string>();
        public string username = "";
        public string password = "";

        public User(int userID = 0)
        {
            if (userID > 0)
            {
                this.userID = userID;
                getUserData();
            }
        }

        public bool Login(string username , string password)
        {
            bool isValid = false;
            this.username = username;
            this.password = password;

            if (new clsDB().Con().countRecord("SELECT * FROM user_accounts WHERE username = '" + username + "' AND password = '" + password + "'") > 0)
            {
                isValid = true;
                isLoggedIn = true;
            }


            return isValid;
        }

        public void getUserData()
        {
            string query = "SELECT salt,userID,username, fullname, userDept, usersPermission FROM user_accounts as UA JOIN user_type as UT ON UA.userType = UT.userTypeID WHERE  ( username = '" + username + "' AND password = '" + password + "' ) OR userID = "+ userID;

            if (new clsDB().Con().SelectDataDictionary(query, userData))
            {
                userID = int.Parse(userData["userID"]);
            }
        
        }

    }
}
