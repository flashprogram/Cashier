namespace Cashier
{
    partial class frmPaymentDataEntry
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.changeBox = new System.Windows.Forms.GroupBox();
            this.lbChange = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbORNo = new System.Windows.Forms.TextBox();
            this.dtORDate = new System.Windows.Forms.DateTimePicker();
            this.lblAmountToPay = new System.Windows.Forms.Label();
            this.checkDetails = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbCheckAmount = new System.Windows.Forms.Label();
            this.lbCheckDate = new System.Windows.Forms.Label();
            this.lbBankName = new System.Windows.Forms.Label();
            this.lbCheckNo = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbName = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.particularBox = new System.Windows.Forms.GroupBox();
            this.changeBox.SuspendLayout();
            this.checkDetails.SuspendLayout();
            this.particularBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(404, 12);
            this.btnSave.Size = new System.Drawing.Size(76, 40);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save && Print";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(486, 12);
            this.btnCancel.TabIndex = 6;
            // 
            // tbAmount
            // 
            this.tbAmount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAmount.Location = new System.Drawing.Point(164, 17);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(343, 33);
            this.tbAmount.TabIndex = 1;
            this.tbAmount.TextChanged += new System.EventHandler(this.tbAmount_TextChanged);
            this.tbAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAmount_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Amount  Tender :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Amount to Pay : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(20, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "Change  = ";
            // 
            // changeBox
            // 
            this.changeBox.Controls.Add(this.lbChange);
            this.changeBox.Controls.Add(this.label4);
            this.changeBox.Controls.Add(this.tbAmount);
            this.changeBox.Controls.Add(this.label2);
            this.changeBox.Location = new System.Drawing.Point(34, 302);
            this.changeBox.Name = "changeBox";
            this.changeBox.Size = new System.Drawing.Size(514, 100);
            this.changeBox.TabIndex = 7;
            this.changeBox.TabStop = false;
            this.changeBox.Text = "Payment ";
            // 
            // lbChange
            // 
            this.lbChange.AutoSize = true;
            this.lbChange.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChange.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbChange.Location = new System.Drawing.Point(158, 57);
            this.lbChange.Name = "lbChange";
            this.lbChange.Size = new System.Drawing.Size(36, 32);
            this.lbChange.TabIndex = 7;
            this.lbChange.Text = "...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(343, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "OR # :";
            // 
            // tbORNo
            // 
            this.tbORNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbORNo.Location = new System.Drawing.Point(401, 58);
            this.tbORNo.Name = "tbORNo";
            this.tbORNo.Size = new System.Drawing.Size(158, 23);
            this.tbORNo.TabIndex = 1;
            this.tbORNo.TextChanged += new System.EventHandler(this.tbORNo_TextChanged);
            this.tbORNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbORNo_KeyDown);
            // 
            // dtORDate
            // 
            this.dtORDate.Location = new System.Drawing.Point(28, 63);
            this.dtORDate.Name = "dtORDate";
            this.dtORDate.Size = new System.Drawing.Size(200, 22);
            this.dtORDate.TabIndex = 10;
            // 
            // lblAmountToPay
            // 
            this.lblAmountToPay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountToPay.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblAmountToPay.Location = new System.Drawing.Point(144, 118);
            this.lblAmountToPay.Name = "lblAmountToPay";
            this.lblAmountToPay.Size = new System.Drawing.Size(260, 21);
            this.lblAmountToPay.TabIndex = 11;
            // 
            // checkDetails
            // 
            this.checkDetails.Controls.Add(this.label8);
            this.checkDetails.Controls.Add(this.label7);
            this.checkDetails.Controls.Add(this.label6);
            this.checkDetails.Controls.Add(this.lbCheckAmount);
            this.checkDetails.Controls.Add(this.lbCheckDate);
            this.checkDetails.Controls.Add(this.lbBankName);
            this.checkDetails.Controls.Add(this.lbCheckNo);
            this.checkDetails.Location = new System.Drawing.Point(34, 142);
            this.checkDetails.Name = "checkDetails";
            this.checkDetails.Size = new System.Drawing.Size(513, 61);
            this.checkDetails.TabIndex = 12;
            this.checkDetails.TabStop = false;
            this.checkDetails.Text = "Check Details";
            this.checkDetails.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(259, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Check Amount : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Bank Name : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Check No : ";
            // 
            // lbCheckAmount
            // 
            this.lbCheckAmount.AutoSize = true;
            this.lbCheckAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCheckAmount.ForeColor = System.Drawing.Color.DarkRed;
            this.lbCheckAmount.Location = new System.Drawing.Point(362, 33);
            this.lbCheckAmount.Name = "lbCheckAmount";
            this.lbCheckAmount.Size = new System.Drawing.Size(135, 21);
            this.lbCheckAmount.TabIndex = 3;
            this.lbCheckAmount.Text = "[ Check Amount ]";
            // 
            // lbCheckDate
            // 
            this.lbCheckDate.AutoSize = true;
            this.lbCheckDate.ForeColor = System.Drawing.Color.DarkRed;
            this.lbCheckDate.Location = new System.Drawing.Point(420, 13);
            this.lbCheckDate.Name = "lbCheckDate";
            this.lbCheckDate.Size = new System.Drawing.Size(77, 13);
            this.lbCheckDate.TabIndex = 2;
            this.lbCheckDate.Text = "[ Check Date ]";
            // 
            // lbBankName
            // 
            this.lbBankName.AutoSize = true;
            this.lbBankName.ForeColor = System.Drawing.Color.DarkRed;
            this.lbBankName.Location = new System.Drawing.Point(111, 43);
            this.lbBankName.Name = "lbBankName";
            this.lbBankName.Size = new System.Drawing.Size(77, 13);
            this.lbBankName.TabIndex = 1;
            this.lbBankName.Text = "[ Bank Name ]";
            // 
            // lbCheckNo
            // 
            this.lbCheckNo.AutoSize = true;
            this.lbCheckNo.ForeColor = System.Drawing.Color.DarkRed;
            this.lbCheckNo.Location = new System.Drawing.Point(111, 24);
            this.lbCheckNo.Name = "lbCheckNo";
            this.lbCheckNo.Size = new System.Drawing.Size(65, 13);
            this.lbCheckNo.TabIndex = 0;
            this.lbCheckNo.Text = "[ CheckNo ]";
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listView1.Location = new System.Drawing.Point(6, 16);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(502, 67);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "No.";
            this.columnHeader3.Width = 165;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Particulars";
            this.columnHeader4.Width = 201;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Amount";
            this.columnHeader5.Width = 92;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.BackColor = System.Drawing.Color.Transparent;
            this.lbName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(25, 95);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(58, 17);
            this.lbName.TabIndex = 15;
            this.lbName.Text = "[ Name]";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.ForeColor = System.Drawing.Color.SeaGreen;
            this.lbDate.Location = new System.Drawing.Point(401, 95);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(50, 13);
            this.lbDate.TabIndex = 16;
            this.lbDate.Text = "[ Date ]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(344, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "OP Date : ";
            // 
            // particularBox
            // 
            this.particularBox.Controls.Add(this.listView1);
            this.particularBox.Location = new System.Drawing.Point(34, 203);
            this.particularBox.Name = "particularBox";
            this.particularBox.Size = new System.Drawing.Size(514, 99);
            this.particularBox.TabIndex = 17;
            this.particularBox.TabStop = false;
            this.particularBox.Text = "                                                                         Particul" +
    "ars                                                                           ";
            // 
            // frmPaymentDataEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 418);
            this.Controls.Add(this.particularBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.checkDetails);
            this.Controls.Add(this.lblAmountToPay);
            this.Controls.Add(this.dtORDate);
            this.Controls.Add(this.tbORNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.changeBox);
            this.Controls.Add(this.label3);
            this.Name = "frmPaymentDataEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Official Receipt";
            this.Load += new System.EventHandler(this.frmPaymentDataEntry_Load);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.changeBox, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.tbORNo, 0);
            this.Controls.SetChildIndex(this.dtORDate, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.lblAmountToPay, 0);
            this.Controls.SetChildIndex(this.checkDetails, 0);
            this.Controls.SetChildIndex(this.lbDate, 0);
            this.Controls.SetChildIndex(this.lbName, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.particularBox, 0);
            this.changeBox.ResumeLayout(false);
            this.changeBox.PerformLayout();
            this.checkDetails.ResumeLayout(false);
            this.checkDetails.PerformLayout();
            this.particularBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox changeBox;
        private System.Windows.Forms.Label lbChange;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbORNo;
        private System.Windows.Forms.DateTimePicker dtORDate;
        private System.Windows.Forms.Label lblAmountToPay;
        private System.Windows.Forms.GroupBox checkDetails;
        private System.Windows.Forms.Label lbCheckDate;
        private System.Windows.Forms.Label lbBankName;
        private System.Windows.Forms.Label lbCheckNo;
        private System.Windows.Forms.Label lbCheckAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox particularBox;
    }
}