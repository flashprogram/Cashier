using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Drawing;

namespace Cashier.classes
{
    class ePrinting
    {


        public Dictionary<string, string> printData = new Dictionary<string, string>();
        public string[][] particularsAmount;
        public bool isOtherPayment, isLandscape = false, forReport = false, hasMorePages = false, forSummary = false;
       
        public int PageNo = 0, OPType = 0;
        public string pageIdentifier = null, date = null, OPTypeText = null;

        public float ORTotal = 0, OPTotal = 0, OPGrandTotal = 0, ORGrandTotal = 0, summaryTotal = 0;

        public ePrinting(Dictionary<string, string> data = null, string[][] pAmount = null, bool isOtherPayment = false)
        {
            printData = data;
            particularsAmount = pAmount;
            this.isOtherPayment = isOtherPayment;
        }
        public void ePrint(string printPage = "OR")
        {
            PrintDialog printDioalog = new PrintDialog();
            PrintDocument printDocument = new PrintDocument();
            PrintPreviewDialog previewDialog = new PrintPreviewDialog();

            previewDialog.Height = 600;
            previewDialog.Width = 800;

          
            previewDialog.PrintPreviewControl.Rows = 10;
            

            // set properties
            if (isLandscape)
                printDocument.DefaultPageSettings.Landscape = true;

           

            printDioalog.Document = printDocument;

            switch (printPage)
            {
                case "OR":
                {
                   
                    printDocument.PrintPage += new PrintPageEventHandler(ePrint_officialReceipt);
                    break;
                }
                case "OP":
                {
                    printDocument.PrintPage += new PrintPageEventHandler(ePrint_orderOfPayment);
                    break;
                }
                case "DRLayoutOne":
                {
                    printDocument.PrintPage += new PrintPageEventHandler(ePrint_dailyReportLayoutOne);
                    break;
                }
               
            }
            
            if (forReport)
            {
                // do some Stuff 
                // Show Print Preview Dialog
                previewDialog.Document = printDocument;
               
                previewDialog.ShowDialog();
                printDocument.DefaultPageSettings.PaperSize = new PaperSize("Legal", 850, 1400);
            }

          
            DialogResult result = printDioalog.ShowDialog();

            if (result == DialogResult.OK)
            {
                printDocument.Print();
            }
        }
        // ***************** ORDER OF PAYMENT PRINTING *******************
        void ePrint_orderOfPayment(object sender, PrintPageEventArgs e)
        {
            Graphics graphic = e.Graphics;
            Font font = new Font("Courier New", 12);

            float fontHeight = font.GetHeight();

            //string strDestination;
            string Remarks;
            int startX = 10;
            int startY = 100;
            int offset = 40;

            int CenterPage = Convert.ToInt16(e.PageBounds.Width / 2 - e.Graphics.MeasureString(printData["DateIssued"], new Font("Courier New", 10)).Width) ;
            // Mark
            graphic.DrawString("© " + "NEW", new Font("Arial", 12, FontStyle.Bold), new SolidBrush(Color.Black), CenterPage / 2 - 40, startY + (offset - 90));


            // Purpose
            graphic.DrawString("☑ " + printData["Purpose"], new Font("Courier New", 10), new SolidBrush(Color.Black), CenterPage / 2, startY + (offset - 40));
            // Date Line
            graphic.DrawString(printData["DateIssued"], new Font("Courier New", 10), new SolidBrush(Color.Black), CenterPage + (offset * 2 - 20), startY + (offset - 40));
            offset += (int)fontHeight + 90;

            CenterPage = Convert.ToInt16(e.PageBounds.Width / 2 - e.Graphics.MeasureString("Address", new Font("Courier New", 10)).Width) / 4;

            // Address Line
            graphic.DrawString(printData["Address"], new Font("Courier New", 10), new SolidBrush(Color.Black), CenterPage - 20, (startY + (offset / 2)) + 10);
            offset += (int)fontHeight - 60;

            CenterPage = Convert.ToInt16(e.PageBounds.Width / 2 - e.Graphics.MeasureString(printData["Payor"], new Font("Courier New", 10, FontStyle.Bold)).Width / 2) / 4;

            // Payor Line
            graphic.DrawString(printData["Payor"], new Font("Courier New", 10), new SolidBrush(Color.Black), CenterPage - 20, (startY + (offset / 2)) + 8);
            offset += (int)fontHeight - 10;

            CenterPage = Convert.ToInt16(e.PageBounds.Width / 2 - e.Graphics.MeasureString(printData["AmtInWords"], new Font("Courier New", 10, FontStyle.Bold)).Width / 2) / 4;

            // Amount Line
            graphic.DrawString(printData["AmtInWords"].PadRight(printData["AmtInWords"].Length + 5), new Font("Arial", 8, FontStyle.Bold), new SolidBrush(Color.Black), CenterPage / 4 - 10, startY + offset - 12);
            graphic.DrawString(printData["Amount"], new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), CenterPage + 300, startY + offset - 12);
           
            
            offset = offset + (int)fontHeight + 5;

            CenterPage = Convert.ToInt16(e.PageBounds.Width / 2 - e.Graphics.MeasureString("", new Font("Courier New", 10, FontStyle.Bold)).Width / 2) / 4;

            // Course Line
            graphic.DrawString(printData["ProgCode"].PadLeft(40) , new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), CenterPage / 2 + 20, startY + offset  - 15);
            offset = offset + (int)fontHeight + 20;


            // remarks
            printData["Remarks"] = (string.IsNullOrEmpty(printData["Remarks"])) ? " " : printData["Remarks"];
            CenterPage = Convert.ToInt16(e.PageBounds.Width / 2 - e.Graphics.MeasureString(printData["Remarks"], new Font("Courier New", 10, FontStyle.Bold)).Width / 2) / 4;
            graphic.DrawString(printData["Remarks"], new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), CenterPage  + 200, startY + offset - 23);


            if ( float.Parse(printData["CheckAmount"]) != 0 )
            {
                // IF HAS CHECK -------------- CHECK DETAILS
                graphic.DrawString(printData["CheckNo"].PadRight(5), new Font("Courier New", 8, FontStyle.Bold), new SolidBrush(Color.Black), CenterPage / 4, startY + offset + 20);
                graphic.DrawString(printData["BankName"], new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), CenterPage + 100, startY + offset + 20);
                graphic.DrawString(printData["CheckAmount"] + " (" + printData["CheckDate"] + ")", new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), CenterPage + 280, startY + offset + 20);
            }

            


            offset = offset + (int)fontHeight + 80;

            CenterPage = Convert.ToInt16(e.PageBounds.Width / 2 - e.Graphics.MeasureString("", new Font("Courier New", 10, FontStyle.Bold)).Width / 2) / 4;
          


            // Last Line
            graphic.DrawString(printData["OPNo"], new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), CenterPage / 2 + 20, startY + offset  );
            offset = offset + (int)fontHeight ;

            CenterPage = Convert.ToInt16(e.PageBounds.Width / 2 - e.Graphics.MeasureString("", new Font("Courier New", 10, FontStyle.Bold)).Width / 2) / 4;



        }


        // ***************** OFFICIAL RECEIPT PRINTING *******************
        void ePrint_officialReceipt(object sender, PrintPageEventArgs e)
        {
            Graphics graphic = e.Graphics;
            Font font = new Font("Arial", 12);

            float fontHeight = font.GetHeight();

            //string strDestination;
            string Remarks;
            int startX = 10;
            int startY = 175;
            int offset = 40;

            int CenterPage = Convert.ToInt16(e.PageBounds.Width / 2 - e.Graphics.MeasureString(printData["ORNumber"], new Font("Arial", 12)).Width ) / 4;

            // First Line
            graphic.DrawString(printData["ORNumber"], new Font("Arial", 11), new SolidBrush(Color.Black), CenterPage + offset * 2, startY + (offset - 10));
            offset +=   (int)fontHeight +  70;

            CenterPage = Convert.ToInt16(e.PageBounds.Width / 2 - e.Graphics.MeasureString(printData["collectionDate"], new Font("Arial", 10)).Width) / 4;

            // Second Line
            graphic.DrawString(printData["collectionDate"], new Font("Arial", 11), new SolidBrush(Color.Black), CenterPage * 2, (startY + (offset / 2)) - 10);
            offset += (int)fontHeight - 45;

            CenterPage = Convert.ToInt16(e.PageBounds.Width / 2 - e.Graphics.MeasureString("Sorsogon State College", new Font("Arial", 10, FontStyle.Bold)).Width / 2) / 4;
          
            // Third Line
            graphic.DrawString("Sorsogon State College", new Font("Arial", 11, FontStyle.Bold), new SolidBrush(Color.Black), CenterPage / 2 + 20, startY + offset - 10 );
            offset = offset + (int)fontHeight + 5;

            CenterPage = Convert.ToInt16(e.PageBounds.Width / 2 - e.Graphics.MeasureString("", new Font("Arial", 12, FontStyle.Bold)).Width / 2) / 4;

            // Payor
            string studentName = printData["LName"] + ", " + printData["FName"] + " " + printData["MName"] ;
            string payor = String.IsNullOrEmpty(printData["Payor"]) ? studentName : printData["Payor"];

            // Fourth Line
            graphic.DrawString(payor, new Font("Arial", 11), new SolidBrush(Color.Black), CenterPage / 2 + 20, startY + offset);
            offset = offset + (int)fontHeight + 5;

            // add more offset for particular items 
            offset += (int)fontHeight + 25;

            int tempDiff = 0;
            int particularLength = 0;
             float MscAmount = 0;
            for (int i = 0; i < particularsAmount.Length; i++)
            {
               
               

                if (particularLength > 0)
                    tempDiff = particularLength;

                // measure nature of collection name
                particularLength = Convert.ToInt16(e.Graphics.MeasureString(particularsAmount[i][0], new Font("Arial", 11, FontStyle.Bold)).Width / 2) / 4;

                if (tempDiff > 0 && tempDiff != particularLength && i != particularsAmount.Length -1)
                    tempDiff = tempDiff - particularLength;

                int tempFinal = particularLength + tempDiff;

                if (particularsAmount[i][3] !=  "1" || isOtherPayment)
                {
                    graphic.DrawString(particularsAmount[i][0] ,new Font("Arial", 11,FontStyle.Bold), new SolidBrush(Color.Black), startX + 10, startY + offset);
                    graphic.DrawString(particularsAmount[i][1].PadRight(10), new Font("Arial", 11, FontStyle.Bold), new SolidBrush(Color.Black), startX + 225, startY + offset);
                    graphic.DrawString(particularsAmount[i][2], new Font("Arial", 11, FontStyle.Bold), new SolidBrush(Color.Black), startX + 275, startY + offset);

                    if (particularsAmount.Length > 8)
                        offset = offset + (int)fontHeight + 2;
                    else
                        offset = offset + (int)fontHeight + 5;
                }
                else
                {
                    MscAmount += float.Parse(particularsAmount[i][2]);
                }
              
                if(MscAmount > 0 && i == particularsAmount.Length - 1)
                {
                    graphic.DrawString("Miscl. Fee".PadRight(28) + " ".PadRight(10) + MscAmount.ToString().PadRight(tempFinal),new Font("Arial", 13), new SolidBrush(Color.Black), startX + 10, startY + offset);
                }
                
            }

           

           
            // For Total
            int totalPosY = 550;
            offset += 60;


            //  if has Check 
            string amount,  amountInWords;
            
            if (!string.IsNullOrEmpty(printData["CheckNo"]) && !string.IsNullOrEmpty(printData["CheckAmount"]))
            {
                amount = printData["CheckAmount"];
                amountInWords = NumberTextExtensionMethod.ToText("" + printData["CheckAmount"]);
            }
            else
            {
                amount = printData["Amount"];
                amountInWords = printData["AmtInWords"];
            }


            graphic.DrawString(amount, new Font("Arial", 10), new SolidBrush(Color.Black), CenterPage * 3 - 40 , totalPosY);
           
            totalPosY = totalPosY + (int)fontHeight + 25;

            // For Amount in Words
            graphic.DrawString(amountInWords, new Font("Arial", 10, FontStyle.Bold), new SolidBrush(Color.Black), CenterPage / 4, totalPosY);

            //  if has check or not
            if (!string.IsNullOrEmpty(printData["CheckNo"]) && !string.IsNullOrEmpty(printData["CheckAmount"]))
            {
              
                // for the x mark
                graphic.DrawString("X - Check", new Font("Arial", 10), new SolidBrush(Color.Black), 30, totalPosY + 48);

                // for check details

                graphic.DrawString(printData["BankName"], new Font("Arial", 10), new SolidBrush(Color.Black), CenterPage / 2 + 100, totalPosY + 45);
                graphic.DrawString(printData["CheckNo"], new Font("Arial", 10), new SolidBrush(Color.Black), CenterPage / 2 + 150, totalPosY + 45);
                graphic.DrawString(printData["CheckDate"], new Font("Arial", 10), new SolidBrush(Color.Black), CenterPage / 2 + 230, totalPosY + 45);
            }
            else
            {
               
                // for the x mark
                graphic.DrawString("X - Cash", new Font("Arial", 10), new SolidBrush(Color.Black), 30, totalPosY + 40);
            }
          

       
        }



         // ***************** DAILY REPORT LAYOUT 1 PRINTING *******************
        void ePrint_dailyReportLayoutOne(object sender, PrintPageEventArgs e)
        {

            // ------- VARIABLES -------
            string queryMain = "SELECT OP.SeqNo,OP.SemNo,OfRec.Date_Paid, OfRec.ORNumber,OP.Payor,OfRec.Amount as ORAmount,OP.DateIssued,OP.OPNo,OP.Amount as OPAmount,OP.Purpose as Purpose,ISNULL(OfRec.PaymentType,0) as PaymentType FROM Collections as OfRec JOIN tbl_PayOrder as OP ON OP.OPNo = OfRec.OPNumber JOIN Collection_Details as CD ON CD.ORNumber = OfRec.ORNumber WHERE Date_Paid = '" + date + "' AND OPType = " + OPType + " " + pageIdentifier + " ORDER BY OfRec.ORNumber   ASC";
            string queryTemp = queryMain;
            int xInc = 0, lineCounter = 0, recordCount = new clsDB().Con().countRecord(queryMain);
            OPTotal = 0; ORTotal = 0;
            clsCollection col = new clsCollection();

            Graphics graphic = e.Graphics;
            Font font = new Font("Arial", 10);

            PageNo++;
            // *** PRINT HEADER ***
            headerPrintLayout1(graphic, e);

            // check if For Summary
            // SUMMARY
            if (forSummary)
            {
                Dictionary<string, float> dataSummary = col.summaryOfCollection(OPType, date);
               
                // SPACING
                string[] space = { "", "", "", "", "", "", "", "", "" };
                rowPrinting(graphic, e, xInc, space);
                xInc += 21;

                // For Summary Heading 
                string[] summaryOne = { "Summary : ", "", "", "", "", "", "", "", "" };
                rowPrinting(graphic, e, xInc, summaryOne);
                xInc += 21;

                // Main Operation
                for (int i = 0; i < dataSummary.Count; i++)
                {
                    string[] summaryTwo = { "", "", dataSummary.Keys.ToList()[i], Convert.ToString(dataSummary[dataSummary.Keys.ToList()[i]]), "", "", "", "", ""};

                    summaryTotal += dataSummary[dataSummary.Keys.ToList()[i]];
                    
                    rowPrinting(graphic, e, xInc, summaryTwo);
                    xInc += 21;
                }

                // For Summary Total
                string[] summaryTotalHeader = { "", "", "Total : ", summaryTotal.ToString(), "", "", "", "", "" };
                rowPrinting(graphic, e, xInc, summaryTotalHeader);

                // *** PRINT FOOTER ***
                footerPrintLayout1(graphic, e);


                e.HasMorePages = false;
                forSummary = false;
                return;
            }

            

            // ******* MAIN PROCESS *******
           
            for (int j = 0; j < recordCount; j++ )
            {

                
                Dictionary<string, string> reportData = new Dictionary<string, string>();
                new clsDB().Con().SelectDataDictionary(queryTemp, reportData);

             
                // get Final Particular

                if (reportData.Count() > 0)
                {
                    OrderOfPayment OP = new OrderOfPayment();

                    // Check if Order Of Payment is Cancelled

                    if (int.Parse(reportData["PaymentType"]) == 9)
                    {
                        string[] data = { reportData["ORNumber"], "Code", "Cancelled", "", "", "", "", "", "" };
                        rowPrinting(graphic, e, xInc, data);
                        xInc += 21;
                    }
                    else
                    {
                        string particulars = OP.modConcatOrderOfPaymentItem(col.getCollectionItem(int.Parse(reportData["ORNumber"])), reportData["Purpose"]);

                        // get Semester 
                        particulars += "-" + Semester.getCurrentSemesterString().Replace("Semester", "Sem").Replace("20", "");

                        string[] dataA = { reportData["ORNumber"], "Code", reportData["Payor"], particulars, reportData["ORAmount"], reportData["DateIssued"], reportData["OPNo"], reportData["OPAmount"], "" };

                        // Compute Total
                        OPTotal += float.Parse(reportData["OPAmount"]);
                        ORTotal += float.Parse(reportData["ORAmount"]);

                        rowPrinting(graphic, e, xInc, dataA);
                        xInc += 21;
                    }

                   

                    // quick fix
                    queryTemp = "SELECT TOP 1 OP.SeqNo,OP.SemNo,OfRec.Date_Paid, OfRec.ORNumber,OP.Payor,OfRec.Amount as ORAmount,OP.DateIssued,OP.OPNo,OP.Amount as OPAmount,OP.Purpose as Purpose,ISNULL(OfRec.PaymentType,0) as PaymentType FROM Collections as OfRec JOIN tbl_PayOrder as OP ON OP.OPNo = OfRec.OPNumber JOIN Collection_Details as CD ON CD.ORNumber = OfRec.ORNumber WHERE Date_Paid = '" + date + "' AND OPType = " + OPType + " AND OPNo >" + reportData["OPNo"];
                    lineCounter++;
                }

                if (lineCounter > 19)
                {

                    OPGrandTotal += OPTotal;
                    ORGrandTotal += ORTotal; 
                    if (recordCount > 20)
                    {
                        hasMorePages = true;

                        pageIdentifier = " AND OPNo >" + reportData["OPNo"];
                        string[] dataTotal = { "", "", "", "Sub-Total", Convert.ToString(ORTotal), "", "", Convert.ToString(OPTotal), "" };
                        rowPrinting(graphic, e, xInc, dataTotal);


                        // *** PRINT FOOTER ***
                        footerPrintLayout1(graphic, e);
                        e.HasMorePages = true;
                        return;
                    }
                   
                  
                }

            }


            /************ FINAL PRINTING  ***************/
            if (hasMorePages)
            {
                OPGrandTotal += OPTotal;
                ORGrandTotal += ORTotal;

                /*string[] dataTotal = { "", "", "", "Sub-Total", Convert.ToString(ORTotal), "", "", Convert.ToString(OPTotal), "" };
                rowPrinting(graphic, e, xInc, dataTotal);

                string[] dataGrandTotal = { "", "", "", "Grand Total", Convert.ToString(ORGrandTotal), "", "", Convert.ToString(OPGrandTotal), "" };
                rowPrinting(graphic, e, xInc + 21, dataGrandTotal);
                */

                // *** PRINT FOOTER ***
                footerPrintLayout1(graphic, e);

                e.HasMorePages = false;
                hasMorePages = false;
            }
            
            if(hasMorePages == false)
            {
                if (OPGrandTotal == 0 && ORGrandTotal == 0)
                {
                    OPGrandTotal += OPTotal;
                    ORGrandTotal += ORTotal;
                }
   

                string[] dataTotal = { "", "", "", "Sub-Total", Convert.ToString(ORTotal), "", "", Convert.ToString(OPTotal), "" };
                rowPrinting(graphic, e, xInc, dataTotal);

                string[] dataGrandTotal = { "", "", "", "Grand Total", Convert.ToString(ORGrandTotal), "", "", Convert.ToString(OPGrandTotal), "" };
                rowPrinting(graphic, e, xInc + 21, dataGrandTotal);


                // *** PRINT FOOTER ***
                footerPrintLayout1(graphic, e);

                forSummary = true;
                e.HasMorePages = true;
            }

          


        

           
              
            
           


        }

        // ------------------------------ DAILY REPORT PAGE COMPOSITION ------------------------------

        private void headerPrintLayout1(Graphics g, PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 10);
            float fontHeight = font.GetHeight();

            int startX = 10;
            int startY = 10;
            int offset = 40;
            int CenterPage = Convert.ToInt16(e.PageBounds.Width / 2 - e.Graphics.MeasureString("REPORT OF COLLECTION", new Font("Courier new", 15)).Width / 2);
            g.DrawString("REPORT OF COLLECTION", new Font("Courier new", 15, FontStyle.Bold), new SolidBrush(Color.Black), CenterPage, startY + offset);
            offset = offset + (int)fontHeight + 5;

            CenterPage = Convert.ToInt16(e.PageBounds.Width / 2 - e.Graphics.MeasureString("SORSOGON STATE COLLEGE", new Font("Arial", 10, FontStyle.Bold)).Width / 2);
            g.DrawString("SORSOGON STATE COLLEGE", new Font("Arial", 10, FontStyle.Bold), new SolidBrush(Color.Black), CenterPage, startY + offset);
            offset = offset + (int)fontHeight + 3;

            CenterPage = Convert.ToInt16(e.PageBounds.Width / 2 - e.Graphics.MeasureString("SORSOGON CITY CAMPUS", new Font("Arial", 10)).Width / 2);
            g.DrawString("SORSOGON CITY CAMPUS", new Font("Arial", 10), new SolidBrush(Color.Black), CenterPage, startY + offset);
            offset = offset + (int)fontHeight + 3;

            CenterPage = Convert.ToInt16(e.PageBounds.Width / 2 - e.Graphics.MeasureString("Sorsogon City", new Font("Arial", 10)).Width / 2);
            g.DrawString("Sorsogon City", new Font("Arial", 10), new SolidBrush(Color.Black), CenterPage, startY + offset);
            offset = offset + (int)fontHeight + 5;

            CenterPage = Convert.ToInt16(e.PageBounds.Width / 2 - e.Graphics.MeasureString("MASTERAL", new Font("Arial", 10, FontStyle.Italic)).Width / 2);
            g.DrawString(OPTypeText, new Font("Arial", 10), new SolidBrush(Color.Black), CenterPage, startY + offset);
            offset = offset + (int)fontHeight + 5;


            // Report No.
            g.DrawString("Report No. ______________", new Font("Arial", 10), new SolidBrush(Color.Black), (e.PageBounds.Width - 200) - "Report No. ______________".Length, startY + offset);
            g.DrawString("10001", new Font("Arial", 10), new SolidBrush(Color.Black), (e.PageBounds.Width - 150) + "Report No.".Length, startY + offset);
            offset = offset + (int)fontHeight + 3;

            // Date & Sheet No.
            g.DrawString("Sheet No. ______________", new Font("Arial", 10), new SolidBrush(Color.Black), (e.PageBounds.Width - 200) - "Report No. ______________".Length, startY + offset);
            g.DrawString(Convert.ToString(PageNo), new Font("Arial", 10), new SolidBrush(Color.Black), (e.PageBounds.Width - 150) + "Sheet No.".Length, startY + offset);


            // Date

            DateTime stringDate = DateTime.Parse(date);

            g.DrawString("Date: __________________________", new Font("Arial", 10), new SolidBrush(Color.Black), (65) - "Date: __________________________".Length, startY + offset);
            g.DrawString(stringDate.ToString("MMMM dd, yyyy"), new Font("Arial", 10), new SolidBrush(Color.Black), (85) + "Date".Length, startY + offset);
            offset = offset + (int)fontHeight + 3;

        }


        private void footerPrintLayout1(Graphics g, PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 10);
            float fontHeight = font.GetHeight();

        
            int startY = e.PageBounds.Height - 210;
            int offset = 40;
            int CenterPage = Convert.ToInt16(e.PageBounds.Width / 2 - e.Graphics.MeasureString("", new Font("Courier new", 8)).Width / 2);
            g.DrawString("\t I hereby certify that on my official oath that the above is true statement of all collections received by me during the period stated above for which Official Receipt were \n actually issued   by me in the amount shown thereon, I also certify that I have not received any money form whatsoever source without having issued the necessary \nOfficial Receipt in acknowledgement thereof. Collections received by sub-collectors are recorded in lump-sum opposite their respective collection report numbers. \nI certify further that the balance shown above agrees with the balance appearing in my Cash Receipt Record.", new Font("Arial", 8, FontStyle.Bold), new SolidBrush(Color.Black), (85), startY + offset);
            offset = offset + (int)fontHeight + 60;

            // Signature
            // Date & Sheet No.

            // Date
            DateTime nowTime = DateTime.Now;
            g.DrawString("MARILOU G. AGNOTE", new Font("Arial", 10), new SolidBrush(Color.Black),(CenterPage / 4) + 80, startY + offset);
            g.DrawString("__________________________", new Font("Arial", 10), new SolidBrush(Color.Black), CenterPage + ( CenterPage / 4) , startY + offset);
            g.DrawString(nowTime.ToString("MMMM dd,yyyy"), new Font("Arial", 10), new SolidBrush(Color.Black), CenterPage + (CenterPage / 4) + 20, startY + offset);

            offset = offset + (int)fontHeight + 3;
            g.DrawString("Cashier III", new Font("Arial", 10), new SolidBrush(Color.Black), (CenterPage / 4) + 80, startY + offset);
            g.DrawString("Date", new Font("Arial", 10), new SolidBrush(Color.Black), CenterPage + (CenterPage / 4) + 30, startY + offset);
        }

        private void columnHeaderPrinting(Graphics g, PrintPageEventArgs e, int lines, string[] rowPrintData = null, float[] dataPoints = null)
        {
            Pen myPen = new Pen(Brushes.Black, 1);
            float x = 0f + 40;
            float y = 0f + 200;

            float xSpace = e.PageBounds.Width / lines;
            float ySpace = e.PageBounds.Height / lines;


            // draw vertical lines
            for (int i = 0; i < lines + 1; i++)
            {

                g.DrawLine(myPen, x, y, x, e.PageBounds.Height / 4 + 12 );

                // center 
                int CenterPage = Convert.ToInt16(x);
                g.DrawString(rowPrintData[i], new Font("Arial", 10, FontStyle.Bold), new SolidBrush(Color.Black), CenterPage, y);
                x += (xSpace + dataPoints[i]) / 2;

                //x += xSpace - float.Parse("8.7");
            }

            x = 0f + 40;
            g.DrawLine(myPen, x, y, e.PageBounds.Width - 41, y);
            y += ySpace / 4 - float.Parse("1.5");
            g.DrawLine(myPen, x, y, e.PageBounds.Width - 41, y);
            

        }

        private void rowPrinting(Graphics g, PrintPageEventArgs e, int xInc = 0, string[] rowPrintData = null)
        {

            // adjustments for Table
            Pen myPen = new Pen(Brushes.Black, 1);
            int lines = Convert.ToInt32(8);

            float[] dataPoints = {  float.Parse("36.5"), float.Parse("37.5"), 284,float.Parse("437.25"), float.Parse("36.5"), float.Parse("36.5"), float.Parse("36.5"), float.Parse("36.5"), 0 };



            // print Header
            string[] headerData = {"OR Number","Center Code","Payor","Particulars","OR Amount","OP Date","OP Number","OP Amount",""};
            columnHeaderPrinting(g, e, lines,headerData, dataPoints);


            float x = 0f + 40;
            float y = 0f + 224 + xInc;

            float xSpace = e.PageBounds.Width / lines;
            float ySpace = e.PageBounds.Height / lines;

            // draw vertical lines
            for (int i = 0; i < lines + 1; i++)
            {

                g.DrawLine(myPen, x, y + ( xInc / 16 ) - 3 , x, e.PageBounds.Height /  4 );

                // center 
                int CenterPage = Convert.ToInt16(x);

                g.DrawString(rowPrintData[i], new Font("Arial", 10), new SolidBrush(Color.Black), CenterPage, y);
                x += (xSpace + dataPoints[i])/2;
                
                //x += xSpace - float.Parse("8.7");
            }

            // horizontal lines
            x = 0f + 40;
            g.DrawLine(myPen, x, y , e.PageBounds.Width - 41, y);
            y += ySpace / 4 - float.Parse("5.5") ;
            g.DrawLine(myPen, x, y, e.PageBounds.Width - 41, y);
            
           
        }

   

    }
}
