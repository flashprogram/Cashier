﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Cashier.classes;

namespace Cashier
{
    public partial class frmParticularAmountDataEntry : frmDataEntry
    {
        public float amount;
        private int assessmentID;
        public bool hasAmount = false, isTuitionFee = false;


        public frmParticularAmountDataEntry()
        {
            InitializeComponent();
            tbAmount.Text = "" + getAssessmentAmount(assessmentID);

        }
        public frmParticularAmountDataEntry(int assessmentID)
        {
            this.assessmentID = assessmentID;
            InitializeComponent();
            tbAmount.Text = "" + getAssessmentAmount(assessmentID);
            
        }

        public double getAssessmentAmount(int assessmentID = -1)
        {
            if(assessmentID >= 0)
            {
                string[] data = new string[1];
                string query = "SELECT TOP 1 ISNULL(Amount,0) FROM Assessment WHERE AssessmentID = "+ assessmentID;
                
                new clsDB().Con().SelectData(query,data);

                this.amount = float.Parse(data[0]);
            }

            return this.amount;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string amount = tbAmount.Text;

            if (!Helper.strIsEmpty(amount, true) && Helper.IsNumeric(amount))
            {
                string query = "UPDATE Assessment SET Amount = " + float.Parse(amount) + " WHERE AssessmentID = " + assessmentID;

                if (new clsDB().Con().ExecuteSql(query))
                {
                    this.amount = float.Parse(amount);
                    hasAmount = true;
                   
                }
            }
            Close();
        }

        private void frmParticularAmountDataEntry_Load(object sender, EventArgs e)
        {
            if (isTuitionFee)
                InfoText.Text = " Please Input Amount ";
        }

        private void tbAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnSave_Click(null, null);
            }
        }

 
    }
}
