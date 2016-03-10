using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Cashier.classes
{
   class clsDB
    {
        public clsADO Con()
        {

            string connstr = Connect.ToDB();
            clsADO db = new clsADO(connstr);

           

            if (!db.checkConnection())
                 db = new clsADO(Connect.ToDB("DB-ALT"));
                 

            return db;
        }

    }
}
