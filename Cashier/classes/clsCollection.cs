using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cashier.classes;
using System.Windows.Forms;

namespace Cashier.classes
{
    class clsCollection
    {
        private int orderOfPaymentNo;
        private int officialReceiptNo;
        private string collectionDate;
        private float amount;
        private string payor, paymentType = "";
        // check details
        string checkNo, checkDate, bankName;
        float checkAmount;
        

        public clsCollection()
        {

        }

        public clsCollection(int OPNo, int ORNo, string cDate, float amount, string payor, string checkNo = null, string bankName = null, string checkDate = null, float checkAmount = 0, int paymentType = 0)
        {
            orderOfPaymentNo = OPNo;
            officialReceiptNo = ORNo;
            collectionDate = cDate;
            this.amount = amount;
            this.payor = payor;

            this.checkNo = checkNo;
            this.checkDate = checkDate;
            this.bankName = bankName;
            this.checkAmount = checkAmount;
            this.paymentType = (paymentType == 0) ? "NULL" : paymentType.ToString();
        }

        public bool create()
        {
            bool isValid = false;
            string query = "INSERT INTO collections (ORNumber, OPNumber, Date_Paid, Payor, Amount, CheckNo, CheckDate, BankName, CheckAmount, PaymentType ) VALUES ("+ officialReceiptNo+","+ orderOfPaymentNo+",'"+ collectionDate + "', '" + payor + "', " + amount +",'" + checkNo +"','" + checkDate +"','" + bankName +"'," + checkAmount+ ", " + paymentType + ")";

            if (new clsDB().Con().ExecuteSql(query))
            {
                isValid = true;
            }

            return isValid;
        }

        public bool addCollectionItem()
        {
            bool isValid = false;
            string query = "SELECT AcctCode, Particular, Amount, OPType From tbl_PayOrder_Details WHERE OPSeqNo = " + orderOfPaymentNo;
            string[][] obj = new string[new clsDB().Con().countRecord(query)][];

            new clsDB().Con().SelectData(query, obj);
            string insertQuery = "";
            for(int i = 0 ; i < obj.Count(); i++)
            {
                insertQuery = "INSERT INTO Collection_Details (ORNumber, AccoutCode, Particular, Amount, OPType) VALUES ( " +officialReceiptNo +"," + obj[i][0] + ",'" + obj[i][1] + "'," + obj[i][2] + "," + obj[i][3] + ")";
                if (new clsDB().Con().ExecuteSql(insertQuery))
                    isValid = true;
            }


            return isValid;
        }

        public string[][] getCollectionItem(int ORNo)
        {
            string query = "SELECT particular, Assess.AssessmentID, CD.Amount, Assess.Is_Misc, Assess.ShortName  FROM Collection_Details as CD LEFT JOIN Assessment as Assess ON CD.particular LIKE Assess.AssessmentName WHERE ORNumber =  " + ORNo;
            string[][] obj = new string[new clsDB().Con().countRecord(query)][];

            new clsDB().Con().SelectData(query, obj);

            return obj;
        }

        public Dictionary<string, float> summaryOfCollection(int OPType = 0, string datePaid = null)
        {
           
           
            //Dictionary<string, string> tempHolder = new Dictionary<string, string>();
            Dictionary<string, float> summaryData = new Dictionary<string, float>();

            // **** QUERY SETTINGS ****
            string query = "SELECT Particular,CD.Amount From Collection_Details as CD JOIN Collections as Col ON Col.ORNumber = CD.ORNumber ";
            string addQuery = "WHERE OPType = " + OPType + " AND Date_Paid = '" + datePaid +"' AND ISNULL(Col.PaymentType,0) != 9";
            query = query + addQuery;

            string[][] tempHolder = new string[new clsDB().Con().countRecord(query)][]; 

            if (OPType > 0 && !string.IsNullOrEmpty(datePaid) )
            {
              
                new clsDB().Con().SelectData(query, tempHolder);


                for (int i = 0; i < tempHolder.Count(); i++)
                {
                    if (summaryData.Keys.ToList().IndexOf(tempHolder[i][0]) < 0)
                    {
                        summaryData[tempHolder[i][0]] = float.Parse(tempHolder[i][1]);
                    }
                    else
                    {
                        summaryData[tempHolder[i][0]] += float.Parse(tempHolder[i][1]);
                    }
                }



            }
            

            return summaryData;
        }

    }
}
