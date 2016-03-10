namespace Cashier
{
    partial class frmOPDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOPDetails));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mtOPNo = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mtTotal = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mtPayor = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.mtOPType = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.mtDateIssued = new MetroFramework.Controls.MetroLabel();
            this.mtPaid = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.Location = new System.Drawing.Point(1, 63);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(480, 181);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ItemNo";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Particular";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Amount";
            this.columnHeader3.Width = 154;
            // 
            // mtOPNo
            // 
            this.mtOPNo.AutoSize = true;
            this.mtOPNo.BackColor = System.Drawing.Color.Transparent;
            this.mtOPNo.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mtOPNo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.mtOPNo.Location = new System.Drawing.Point(348, 28);
            this.mtOPNo.Name = "mtOPNo";
            this.mtOPNo.Size = new System.Drawing.Size(71, 19);
            this.mtOPNo.TabIndex = 1;
            this.mtOPNo.Text = "[ OP No ]";
            this.mtOPNo.UseCustomBackColor = true;
            this.mtOPNo.UseCustomForeColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel1.Location = new System.Drawing.Point(33, 290);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(104, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Total Amount : ";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // mtTotal
            // 
            this.mtTotal.AutoSize = true;
            this.mtTotal.BackColor = System.Drawing.Color.Transparent;
            this.mtTotal.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mtTotal.ForeColor = System.Drawing.Color.Maroon;
            this.mtTotal.Location = new System.Drawing.Point(143, 290);
            this.mtTotal.Name = "mtTotal";
            this.mtTotal.Size = new System.Drawing.Size(80, 19);
            this.mtTotal.TabIndex = 3;
            this.mtTotal.Text = "[ Amount ]";
            this.mtTotal.UseCustomBackColor = true;
            this.mtTotal.UseCustomForeColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel2.Location = new System.Drawing.Point(34, 263);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(59, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Payor  : ";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // mtPayor
            // 
            this.mtPayor.AutoSize = true;
            this.mtPayor.BackColor = System.Drawing.Color.Transparent;
            this.mtPayor.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mtPayor.ForeColor = System.Drawing.Color.Maroon;
            this.mtPayor.Location = new System.Drawing.Point(143, 263);
            this.mtPayor.Name = "mtPayor";
            this.mtPayor.Size = new System.Drawing.Size(67, 19);
            this.mtPayor.TabIndex = 5;
            this.mtPayor.Text = "[ Payor ]";
            this.mtPayor.UseCustomBackColor = true;
            this.mtPayor.UseCustomForeColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel3.Location = new System.Drawing.Point(282, 290);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(72, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "OP Type : ";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // mtOPType
            // 
            this.mtOPType.AutoSize = true;
            this.mtOPType.BackColor = System.Drawing.Color.Transparent;
            this.mtOPType.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mtOPType.ForeColor = System.Drawing.Color.Maroon;
            this.mtOPType.Location = new System.Drawing.Point(393, 290);
            this.mtOPType.Name = "mtOPType";
            this.mtOPType.Size = new System.Drawing.Size(60, 19);
            this.mtOPType.TabIndex = 7;
            this.mtOPType.Text = "[ Type ]";
            this.mtOPType.UseCustomBackColor = true;
            this.mtOPType.UseCustomForeColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel4.Location = new System.Drawing.Point(34, 321);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(92, 19);
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "Date Issued : ";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // mtDateIssued
            // 
            this.mtDateIssued.AutoSize = true;
            this.mtDateIssued.BackColor = System.Drawing.Color.Transparent;
            this.mtDateIssued.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mtDateIssued.ForeColor = System.Drawing.Color.Maroon;
            this.mtDateIssued.Location = new System.Drawing.Point(143, 321);
            this.mtDateIssued.Name = "mtDateIssued";
            this.mtDateIssued.Size = new System.Drawing.Size(58, 19);
            this.mtDateIssued.TabIndex = 9;
            this.mtDateIssued.Text = "[ Date ]";
            this.mtDateIssued.UseCustomBackColor = true;
            this.mtDateIssued.UseCustomForeColor = true;
            // 
            // mtPaid
            // 
            this.mtPaid.AutoSize = true;
            this.mtPaid.BackColor = System.Drawing.Color.Transparent;
            this.mtPaid.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mtPaid.ForeColor = System.Drawing.Color.Maroon;
            this.mtPaid.Location = new System.Drawing.Point(393, 321);
            this.mtPaid.Name = "mtPaid";
            this.mtPaid.Size = new System.Drawing.Size(67, 19);
            this.mtPaid.TabIndex = 10;
            this.mtPaid.Text = "[ Status ]";
            this.mtPaid.UseCustomBackColor = true;
            this.mtPaid.UseCustomForeColor = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel5.Location = new System.Drawing.Point(282, 321);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(105, 19);
            this.metroLabel5.TabIndex = 11;
            this.metroLabel5.Text = "Payment Status";
            this.metroLabel5.UseCustomBackColor = true;
            this.metroLabel5.UseCustomForeColor = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(432, 9);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(49, 23);
            this.metroButton1.TabIndex = 12;
            this.metroButton1.Text = "Close";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // frmOPDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BackImage = ((System.Drawing.Image)(resources.GetObject("$this.BackImage")));
            this.BackLocation = MetroFramework.Forms.BackLocation.BottomLeft;
            this.BackMaxSize = 630;
            this.ClientSize = new System.Drawing.Size(482, 364);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.mtPaid);
            this.Controls.Add(this.mtDateIssued);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.mtOPType);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.mtPayor);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.mtTotal);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.mtOPNo);
            this.Controls.Add(this.listView1);
            this.Name = "frmOPDetails";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
            this.Text = "Order of Payment Details";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.frmOPDetails_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmOPDetails_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private MetroFramework.Controls.MetroLabel mtOPNo;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel mtTotal;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel mtPayor;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel mtOPType;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel mtDateIssued;
        private MetroFramework.Controls.MetroLabel mtPaid;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}