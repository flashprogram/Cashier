using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cashier.classes;
using System.Windows.Forms;

namespace Cashier.classes
{
    class OrderOfPayment
    {
        // Fillable 
       private float amountNumeric;
       private string amountWords;
       private int StudID;
       private int orderOfPaymentNo;
       private string orderOfPaymentDate;
       private string payorName;
       private string purpose;
       private string query;
       private string remarks;
       public int ORNumber;
       public string paymentStatus;
       public string paymentType;

        // check details
       public string bankName;
       public string checkNo;
       public string checkDate;
       public float checkAmount;


       public Dictionary<string,string> orderOfPaymentDetails = new Dictionary<string,string>();
      
       // Simple Constructor
       public OrderOfPayment()
       {
           // initialize Details
           orderOfPaymentDetails["tuitionFee"] = "";
           orderOfPaymentDetails["mscFee"] = "";
       }

       public Dictionary<string, string> getOPDataWOOR(int orderOfPaymentNo)
       {
           this.orderOfPaymentNo = orderOfPaymentNo;
           Dictionary<string, string> data = new Dictionary<string, string>();
           string query = "SELECT DISTINCT OP.SeqNo,OP.OPNo, OP.DateIssued, OP.Payor as Payor ,S.GAddress as Address,OP.AmtInWords,OP.Purpose as Purpose, OP.Amount, OP.OPNo, SC.ProgCode, OP.Remarks, ISNULL(OP.BankName,'') as BankName,ISNULL(OP.CheckNo,'') as CheckNo ,ISNULL(OP.CheckDate,'') as CheckDate, ISNULL(OP.CheckAmount,'') as CheckAmount FROM tbl_PayOrder as OP LEFT JOIN Student_Account as SA ON OP.StudID = SA.StudID LEFT JOIN StudentCourse as SC ON OP.StudID = SC.StudID LEFT JOIN student as S ON OP.StudID = S.StudID WHERE OP.OPNo = "+orderOfPaymentNo+" GROUP BY OP.DateIssued,Payor, OP.AmtInWords,OP.Amount, OP.OPNo, S.FName, S.MName, S.LName, OP.Payor, S.GAddress, OP.OPNo, OP.SeqNo,SC.ProgCode, OP.remarks,OP.BankName, OP.CheckNo,OP.CheckDate,OP.CheckAmount, OP.Purpose";

           if (!new clsDB().Con().SelectDataDictionary(query, data))
           {

           }

           return data;
       }
       public Dictionary<string, string> getOPData(int orderOfPaymentNo)
       {
           Dictionary<string, string> data = new Dictionary<string, string>();
           string query = "SELECT *,OP.Payor as Payor ,OP.Amount FROM tbl_PayOrder as OP LEFT JOIN Student as S ON S.StudID = OP.StudID  WHERE OP.OPNo = " + orderOfPaymentNo;

           if (!new clsDB().Con().SelectDataDictionary(query, data))
           {
               
           }
           orderOfPaymentDetails = data;
           return data;
       }

        // 
       public string[][] getOrderOfPaymentItem(int orderOfPaymentNo)
       {
           string query = "SELECT particular, Assess.AssessmentID, TPD.Amount, Assess.Is_Misc, Assess.ShortName FROM tbl_PayOrder_Details as TPD LEFT JOIN Assessment as Assess ON TPD.particular LIKE Assess.AssessmentName WHERE OPSeqNo =  " + orderOfPaymentNo;
           string[][] obj = new string[new clsDB().Con().countRecord(query)][];

           new clsDB().Con().SelectData(query, obj);

           return obj;
       }


       // Modified 
       public string modConcatOrderOfPaymentItem(string[][] OPItem, string OPPaymentType = null)
       {
           string finalValue = null;

           for (int i = 0; i < OPItem.Count(); i++)
           {
               
               if (OPItem[i][3] == "0" || OPPaymentType == "Other Fees")
               {
                   finalValue += OPItem[i][4];
                   if (i != OPItem.Count() - 1)
                       finalValue += "/";
               }

               if (i == OPItem.Count() - 1 && OPPaymentType != "Other Fees")
               {
                   finalValue += "/Misc";
               }
           }

           return finalValue;
       }

       public string ConcatOrderOfPaymentItem(string[][] OPItem, string OPPaymentType = null)
       {
           string finalValue = null;
           Dictionary<string, string> abrevWord = new Dictionary<string, string>();
          
           abrevWord["TuitionFee"] = "TF";
           abrevWord["Laboratory"] = "Lab";
           abrevWord["Good Moral Certificate"] = "GMC";
           abrevWord["Certification Fee"] = "CF";
           abrevWord["Completion Fee"] = "COF";
           abrevWord["Class Card"] = "CC";
           abrevWord["Qualifying Fee"] = "QEF";
           abrevWord["Graduation Fee"] = "GF";

           for (int i = 0; i < OPItem.Count(); i++)
           {
                string key = OPItem[i][0].Replace(" ", "");
                if (abrevWord.Keys.ToList().IndexOf(key) >= 0)
                {
                    finalValue += abrevWord[key] ;
                    if (i != OPItem.Count() - 1)
                        finalValue += "/";
                }
                else if (OPItem[i][3] == "0" || OPPaymentType == "Other Fees")
                {
                    finalValue += OPItem[i][0];
                    if (i != OPItem.Count() - 1)
                        finalValue += "/";
                }

             

                if (i == OPItem.Count() - 1 && OPPaymentType != "Other Fees")
                {
                    finalValue += "/Misc";
                }
           }



           return finalValue;
       }

       

       public OrderOfPayment(float amount, int orderOfPaymentNo, string orderOfPaymentDate, string purpose, string payor = null, int StudID = 0, string remarks = null, string bankName = null, string checkNo = null, string checkDate = null, float checkAmount = 0, int paymentType = 0)
       {
           amountWords = NumberTextExtensionMethod.ToText("" + amount);
           amountNumeric = amount;
           this.StudID = StudID;
           this.orderOfPaymentNo = hasNoDuplicate(orderOfPaymentNo) ? 0 : orderOfPaymentNo ;
           this.orderOfPaymentDate = orderOfPaymentDate;
           this.purpose = purpose;
           this.payorName = payor;
           this.remarks = (string.IsNullOrEmpty(remarks)) ? null : remarks;
           this.bankName = bankName;
           this.checkNo = checkNo;
           this.checkDate = checkDate;
           this.checkAmount = checkAmount;
           this.paymentType = (paymentType == 0) ? "NULL" : ""+paymentType;
       }

       public bool hasCheck()
       {
           bool isValid = false;

           if (bankName != null && checkDate != null && checkNo != null || orderOfPaymentDetails["CheckNo"] != null)
               isValid = true;

           return isValid;
       }
       public bool createOP()
       {
           if (orderOfPaymentNo > 0)
           {
                

               string finalStudID = (StudID == 0) ? "null" : Convert.ToString(StudID);
               query = "INSERT INTO tbl_PayOrder (Amount, SemNo,AmtInWords, StudID, OPNo, DateIssued,Purpose,Payor,Remarks,BankName, CheckNo, CheckDate, CheckAmount, PaymentType) VALUES( " + amountNumeric + ","+ Semester.getCurrentSemester()+", '" + amountWords + "'," + finalStudID + "," + orderOfPaymentNo + ",'" + orderOfPaymentDate + "' "+",'" + purpose+"', '"+ payorName+ "','"+remarks+"','"+bankName+"','"+checkNo+"','"+checkDate+"',"+checkAmount+"," + paymentType+") ";
               if (!new clsDB().Con().ExecuteSql(query))
               {
                   MessageBox.Show("There is an error");
                   return false;
               }
           }
           else
           {
               MessageBox.Show(" Duplicate Order of Payment Number ");
               return false;
           }

           return true;
       }

       public string getPaymentStatus()
       {
           string[] obj = new string[1];
           if (string.IsNullOrEmpty(paymentStatus))
           {

               new clsDB().Con().SelectData("SELECT CAST(Case WHEN Paid IS NULL OR Paid = '' OR Paid = 0 THEN 'Not Paid' ELSE 'Paid' END as varchar(50) ) as Paid FROM tbl_PayOrder WHERE OPNo = "+ orderOfPaymentNo ,obj);
           }

           return obj[0];
       }

       public string getOPType()
       {
           string[] obj = new string[1];
           if (string.IsNullOrEmpty(paymentStatus))
           {

               new clsDB().Con().SelectData("SELECT OPTypeName From rColType as CT JOIN (SELECT TOP 1 OPType FROM tbl_PayOrder_Details as OPD JOIN tbl_PayOrder as OP ON OP.OPNo = OPD.OPSeqNo WHERE OPNo = "+orderOfPaymentNo+") AS OPFinal ON OPFinal.OPType = CT.OPTypeID", obj);
           }

           return obj[0];
       }

       public bool addOPItem(int orderOfPaymentNo, Dictionary<string,float> amountPerParticular, int OPType = 0, string NSTPType = null)
       {
           string query = "";
           bool isValid = false;
           int accountCode = 0; 

           for(int i = 0 ; i < amountPerParticular.Count; i++)
           {
               if (!string.IsNullOrEmpty(NSTPType))
               {
                   if (amountPerParticular.Keys.ToList()[i] == "CWTS/ROTC")
                   {
                       // Need to remove a existing key in the dictionary because it is not possible to update a key value
                       float temp = amountPerParticular[amountPerParticular.Keys.ToList()[i]];
                       amountPerParticular.Remove("CWTS/ROTC");
                       amountPerParticular.Add(NSTPType, temp);
                       accountCode = OrderOfPayment.assessmentID(NSTPType);
                   }
                   else
                       accountCode = OrderOfPayment.assessmentID(amountPerParticular.Keys.ToList()[i]);
                  
               }
               else
                   accountCode = OrderOfPayment.assessmentID(amountPerParticular.Keys.ToList()[i]);

               
               query =  "INSERT INTO tbl_PayOrder_Details (OPSeqNo, AcctCode, particular, amount, OPType) VALUES ("+orderOfPaymentNo+","+accountCode+", '"+ amountPerParticular.Keys.ToList()[i] +"',"+ amountPerParticular[amountPerParticular.Keys.ToList()[i]] + "," + OPType +")";
               isValid = new clsDB().Con().ExecuteSql(query);
           }
            

           return isValid;
       }

       public bool createOPItem()
       {
           return true;
       }

       public bool updateOP(int ORNo, int OPNo)
       {
           bool isValid = true;

           string query = "UPDATE collections SET ORNumber = " + ORNo + " WHERE OPNumber = " + OPNo;

           if (new clsDB().Con().ExecuteSql(query))
           {
               isValid = true;
           }
           
           return isValid;
       }

       public void paidOP(int OPNo )
       {
           string query = "UPDATE tbl_PayOrder SET Paid = 1 WHERE OPNo = " + OPNo;

           new clsDB().Con().ExecuteSql(query);
       }

       private bool hasNoDuplicate(int orderOfPaymentNo)
       {
           string[] obj = new string[6];
           bool isValid = new clsDB().Con().SelectData("Select * FROM tbl_PayOrder WHERE OPNo = " + orderOfPaymentNo, obj);

           return isValid;
       }


       public bool hasORNumber(int OPNo)
       {
           bool hasRecord = false;
           string query = "SELECT TOP 1 ORNumber FROM Collections WHERE OPNumber = " + OPNo;

           if (new clsDB().Con().countRecord(query) > 0)
           {
               string[] obj = new string[1];
               new clsDB().Con().SelectData(query, obj);
               this.ORNumber = int.Parse(obj[0]);
               hasRecord = true;
           }

           return hasRecord;
       }



        // static functions
       public static string getLastOPNo()
       {
           string[] obj = new string[2];
           new clsDB().Con().SelectData("SELECT TOP 1 SeqNo, OPNo FROM tbl_PayOrder  ORDER BY SeqNo DESC ",obj );
           int newOP = int.Parse((obj[1] == null) ? "100000" : obj[1]) + 1;
           obj[1] = Convert.ToString(newOP);

           return obj[1];
       }

       public static string getLastORNo()
       {
           string[] obj = new string[2];
           new clsDB().Con().SelectData("SELECT TOP 1 OPNumber, ORNumber FROM collections ORDER BY ORNumber DESC", obj);

           int lastORNo = int.Parse((obj[1] == null) ? "100000" : obj[1]) + 1;
    
           return Convert.ToString(lastORNo);
       }


       public static int getNumberOfOP()
       {
           string query = "SELECT OPNo From tbl_PayOrder WHERE DateIssued = " + DateTime.Now.ToShortDateString();
           int NoOfOP = new clsDB().Con().countRecord(query);

           return NoOfOP;
       }

       public static int assessmentID(string particular)
       {
           int assessmentID = 0;
           string[] particularID = new string[1];

           new clsDB().Con().SelectData("SELECT AssessmentID FROM Assessment WHERE AssessmentName = '" + particular + "'", particularID);

           assessmentID = int.Parse(particularID[0]);
           return assessmentID;
       }
       


      
    }
}
