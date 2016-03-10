using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections.ObjectModel;

namespace Cashier.classes
{
    class StudentAccount
    {
        public int tuitionMarker;
        public float total, tuitionFee, mscFee, balance, payment, amount;
        public Dictionary<string, float> amountPerParticular = new Dictionary<string,float>();
        public Dictionary<string, string> data = new Dictionary<string,string>();
        public int[] seqNo = new int[20];
        public bool hasNSTPPick = false;

     


        public StudentAccount(int StudID = 0)
        {
            
        }

        public Dictionary<string, string> getData(string[][] qData)
        {
            
            for (int i = 0; i < qData.Length; i++)
            {
                bool isTuition = false;
                for (int j = 0; j < qData[i].Count(); j++)
                {
                    if (qData[i][j] != null)
                    {
                        if (j == 3 && qData[i][j] == "Tuition Fee")
                        {
                            data["tuitionSeqNo"] = qData[i][0];
                            isTuition = true;
                        }
                       
                        
                    }
                    
                }

                if (!isTuition)
                {
                    if(float.Parse(qData[i][4]) > float.Parse(qData[i][5]))
                        mscFee += float.Parse(qData[i][4]);
                }
                
                data["StudID"] = qData[i][1];
                data["SemNo"] = qData[i][2];

                seqNo[i] = int.Parse(qData[i][0]);

               data["amountNumeric"] = qData[i][7];
                data["mFee"] = Convert.ToString(mscFee);
            }

            

            return data;
        }

        public  bool hasNSTP(ListView lv)
        {
            bool isTrue = false;
            if (lv.FindItemWithText("CWTS/ROTC").Index > 0)
            {
                isTrue = true;
                hasNSTPPick = true;
            }

            return isTrue;
        }

        public Dictionary<string, float> getAmountPerParticular(ListView lv, int startIndex = 3, string purpose = "")
        {
            // Problem with having same index since the index is a string so if multiple instance of the same name is entered only one remains (02/05/20
            
            // OTHER PAYMENTS
            if (lv.CheckedItems.Count < 1 && purpose == "" )
            {
                for (int i = 0; i < lv.Items.Count; i++)
                {
                    try
                    {
                        if (lv.Items[i].SubItems[startIndex].Text != "Tuition Fee")
                        {
                            foreach (string key in amountPerParticular.Keys)
                            {
                                if (key == lv.Items[i].SubItems[startIndex + 2].Text)
                                {
                                    amountPerParticular[key] += float.Parse(lv.Items[i].SubItems[startIndex + 3].Text);
                                    continue;
                                }
                            }

                            amountPerParticular[lv.Items[i].SubItems[startIndex + 2].Text] = float.Parse(lv.Items[i].SubItems[startIndex + 3].Text);
                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("There is an error");
                    }

                }
            }

            // Payment for Tuition & Misc
            else
            {
                for (int i = 0; i < lv.Items.Count; i++)
                {

                    float amount = float.Parse(lv.Items[i].SubItems[startIndex + 1].Text);
                    float payment = float.Parse(lv.Items[i].SubItems[startIndex + 2].Text);
                    float balance = float.Parse(lv.Items[i].SubItems[startIndex + 3].Text);
                    string particular = lv.Items[i].SubItems[startIndex].Text;

                    try
                    {
                        if (balance > 0 ||amount >= payment)
                        {
                            if (payment == amount)
                            {
                                // do nothing
                            }
                                // for tuition fee
                            else if (payment == 0)
                                amountPerParticular[particular] = amount;
                            else
                            {
                                amountPerParticular[particular] = amount - payment;
                            }


                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("There is an error");
                    }

                }
            }
            
            return amountPerParticular;
        }


        // ################# STATIC FUNCTIONS ##############################


        // store query string for student account
        public static string searchAccount(string keyword)
        {
            string query;

            query = "SELECT TOP 18  SA.SemNo,sa.StudID,s.StudNo, SUM(Amount - ISNULL(Payment, 0 )), s.FName, s.MName, s.LName, ProgCode FROM Student_Account as sa LEFT JOIN student as s ON sa.StudID = s.StudID JOIN StudentCourse as SC ON SC.StudID = SA.StudID WHERE S.StudNo LIKE '%" + keyword + "%' OR CONCAT(LName,' ',FName) LIKE '%"+keyword+"%'  GROUP BY SA.SemNo,sa.StudID,s.StudNo, FName, MName,LName,ProgCode";
           
            return query;
        }

        public static string searchBySemester(string keyword, string studNo)
        {
            string query;

            query = "SELECT SeqNo,StudID, SemNo, Particular, Amount, ISNULL(Payment, 0 ), ISNULL(Balance, 0) FROM Student_Account WHERE SemNo = " + keyword + " AND StudID = " + studNo + ""; 

            return query;
        }



        public static bool updatePayment(int[] seqNo, int tuitionSeqNo, float payment, int StudID, float mscFee, int semNo, float checkAmount = 0)
        {
            // query for mscFee
            string queryMscFee = "UPDATE Student_Account SET Payment = Amount , Balance = (Amount - ISNULL(Payment,0)) WHERE StudID = " + StudID + " AND SeqNo != " + tuitionSeqNo + " AND SemNo = " + semNo;

            // query for tuitionFee
            // Some adjustments for check payment
            string queryTuitionFee = "UPDATE Student_Account SET Payment = ISNULL(Payment, 0 ) + (" + (payment - mscFee) + ") , Balance = (Amount -  (ISNULL(Payment,0) +" + (payment - mscFee) +  "   ) ) WHERE SeqNo = " + tuitionSeqNo + " AND StudID = " + StudID + " AND SemNo = " + semNo;

            // count seqNo
            int count = seqNo.Count();
            bool result = false;

            for (int i = 0; i < count; i++)
            {
                result = new clsDB().Con().ExecuteSql(queryMscFee);
            }

            if (result)
            {
                 if( new clsDB().Con().ExecuteSql(queryTuitionFee))
                 {
                     return true;
                 }
            }


            return result;
        }

        

        public static bool validateAmout(string paymentType, float totalFee, float paymentAmount, float tuitionFee, float mscFee, bool isCheck = false)
        {
            bool isValid = false;

            // ----- VALIDATIONS --------

            // payment validatation
            if (paymentAmount > totalFee && paymentType == "full" && isCheck == false)
                MessageBox.Show(" Payment is more than the total Fee");

            // Payment Type
            if (paymentType == "partial")
            {
                // check if the payment is less than 30% of the given tuition fee plus the mscfee
                if (paymentAmount < (tuitionFee * 0.3 + mscFee))
                {
                    MessageBox.Show(" Payment must be atleast 30% of the Tuition Fee \n plus the Miscellaneous Fee = \n \n \t30% (" + tuitionFee * 0.3 + ") + (" + mscFee + ")");
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Payment is valid \n\n Details : \n \t Payment : " + paymentAmount + "\n\t Payment Type : " + paymentType + "\n \t Total Amount : " + totalFee + "\n\n     Continue saving & printing ?", "Final Check", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                        isValid = true;
                }
            }
            else
            {
                if (paymentAmount != totalFee && isCheck == false)
                    MessageBox.Show(" Payment Amount must be equal to the total amount");
                else
                {
                    paymentType = (paymentType == null) ? "Full" : paymentType;
                    DialogResult dr = MessageBox.Show("Payment is valid \n\n Details :  \n \t Payment : " + paymentAmount + "\n\t Payment Type : " + paymentType + "\n \t Total Amount : " + totalFee + "\n\n     Continue saving & printing ?", "Final Check", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                        isValid = true;

                }
            }




            return isValid;

        }
        


    }



}
