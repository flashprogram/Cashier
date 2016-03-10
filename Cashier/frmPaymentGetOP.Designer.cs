namespace Cashier
{
    partial class frmPaymentGetOP
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
            this.mtbSearch = new MetroFramework.Controls.MetroButton();
            this.tOPNo = new MetroFramework.Controls.MetroTextBox();
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.lbFName = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tORNo = new MetroFramework.Controls.MetroTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mtbSubmit = new MetroFramework.Controls.MetroButton();
            this.lbMsc = new System.Windows.Forms.Label();
            this.lbTuition = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.gbDetails.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mtbSearch
            // 
            this.mtbSearch.Location = new System.Drawing.Point(271, 72);
            this.mtbSearch.Name = "mtbSearch";
            this.mtbSearch.Size = new System.Drawing.Size(75, 23);
            this.mtbSearch.TabIndex = 2;
            this.mtbSearch.Text = "Search";
            this.mtbSearch.UseSelectable = true;
            this.mtbSearch.Click += new System.EventHandler(this.mtbSearch_Click);
            // 
            // tOPNo
            // 
            // 
            // 
            // 
            this.tOPNo.CustomButton.Image = null;
            this.tOPNo.CustomButton.Location = new System.Drawing.Point(142, 1);
            this.tOPNo.CustomButton.Name = "";
            this.tOPNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tOPNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tOPNo.CustomButton.TabIndex = 1;
            this.tOPNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tOPNo.CustomButton.UseSelectable = true;
            this.tOPNo.CustomButton.Visible = false;
            this.tOPNo.Lines = new string[0];
            this.tOPNo.Location = new System.Drawing.Point(92, 72);
            this.tOPNo.MaxLength = 32767;
            this.tOPNo.Name = "tOPNo";
            this.tOPNo.PasswordChar = '\0';
            this.tOPNo.PromptText = "Order of Payment No";
            this.tOPNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tOPNo.SelectedText = "";
            this.tOPNo.SelectionLength = 0;
            this.tOPNo.SelectionStart = 0;
            this.tOPNo.ShortcutsEnabled = true;
            this.tOPNo.Size = new System.Drawing.Size(164, 23);
            this.tOPNo.TabIndex = 1;
            this.tOPNo.UseSelectable = true;
            this.tOPNo.WaterMark = "Order of Payment No";
            this.tOPNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tOPNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tOPNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tOPNo_KeyDown);
            // 
            // gbDetails
            // 
            this.gbDetails.Controls.Add(this.metroLabel3);
            this.gbDetails.Controls.Add(this.metroLabel2);
            this.gbDetails.Controls.Add(this.lbFName);
            this.gbDetails.Controls.Add(this.lbDate);
            this.gbDetails.Controls.Add(this.listView1);
            this.gbDetails.Controls.Add(this.metroLabel1);
            this.gbDetails.Controls.Add(this.tORNo);
            this.gbDetails.Location = new System.Drawing.Point(23, 130);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Size = new System.Drawing.Size(355, 287);
            this.gbDetails.TabIndex = 2;
            this.gbDetails.TabStop = false;
            this.gbDetails.Text = "OP Details";
            this.gbDetails.Visible = false;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(88, 93);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(67, 15);
            this.metroLabel3.TabIndex = 18;
            this.metroLabel3.Text = "[ OP TYPE ]";
            this.metroLabel3.Visible = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(15, 89);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(67, 19);
            this.metroLabel2.TabIndex = 17;
            this.metroLabel2.Text = "OP Type :";
            this.metroLabel2.Visible = false;
            // 
            // lbFName
            // 
            this.lbFName.AutoSize = true;
            this.lbFName.BackColor = System.Drawing.Color.Transparent;
            this.lbFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFName.Location = new System.Drawing.Point(12, 73);
            this.lbFName.Name = "lbFName";
            this.lbFName.Size = new System.Drawing.Size(63, 16);
            this.lbFName.TabIndex = 15;
            this.lbFName.Text = "[ Name]";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.ForeColor = System.Drawing.Color.SeaGreen;
            this.lbDate.Location = new System.Drawing.Point(22, 27);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(50, 13);
            this.lbDate.TabIndex = 16;
            this.lbDate.Text = "[ Date ]";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(6, 111);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(343, 93);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "No.";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Particulars";
            this.columnHeader4.Width = 154;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Amount";
            this.columnHeader5.Width = 82;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(158, 21);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(60, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "OR No. :";
            // 
            // tORNo
            // 
            // 
            // 
            // 
            this.tORNo.CustomButton.Image = null;
            this.tORNo.CustomButton.Location = new System.Drawing.Point(108, 1);
            this.tORNo.CustomButton.Name = "";
            this.tORNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tORNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tORNo.CustomButton.TabIndex = 1;
            this.tORNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tORNo.CustomButton.UseSelectable = true;
            this.tORNo.CustomButton.Visible = false;
            this.tORNo.Lines = new string[0];
            this.tORNo.Location = new System.Drawing.Point(219, 20);
            this.tORNo.MaxLength = 32767;
            this.tORNo.Name = "tORNo";
            this.tORNo.PasswordChar = '\0';
            this.tORNo.PromptText = "OR Number";
            this.tORNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tORNo.SelectedText = "";
            this.tORNo.SelectionLength = 0;
            this.tORNo.SelectionStart = 0;
            this.tORNo.ShortcutsEnabled = true;
            this.tORNo.Size = new System.Drawing.Size(130, 23);
            this.tORNo.TabIndex = 2;
            this.tORNo.UseSelectable = true;
            this.tORNo.WaterMark = "OR Number";
            this.tORNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tORNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.mtbSubmit);
            this.groupBox2.Controls.Add(this.lbMsc);
            this.groupBox2.Controls.Add(this.lbTuition);
            this.groupBox2.Controls.Add(this.lbTotal);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBox2.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox2.Location = new System.Drawing.Point(23, 336);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(355, 81);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Summary";
            // 
            // mtbSubmit
            // 
            this.mtbSubmit.Location = new System.Drawing.Point(266, 48);
            this.mtbSubmit.Name = "mtbSubmit";
            this.mtbSubmit.Size = new System.Drawing.Size(83, 23);
            this.mtbSubmit.TabIndex = 11;
            this.mtbSubmit.Text = "Save && Print";
            this.mtbSubmit.UseSelectable = true;
            // 
            // lbMsc
            // 
            this.lbMsc.Location = new System.Drawing.Point(122, 22);
            this.lbMsc.Name = "lbMsc";
            this.lbMsc.Size = new System.Drawing.Size(78, 23);
            this.lbMsc.TabIndex = 2;
            // 
            // lbTuition
            // 
            this.lbTuition.Location = new System.Drawing.Point(12, 22);
            this.lbTuition.Name = "lbTuition";
            this.lbTuition.Size = new System.Drawing.Size(87, 23);
            this.lbTuition.TabIndex = 1;
            // 
            // lbTotal
            // 
            this.lbTotal.Location = new System.Drawing.Point(280, 22);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(67, 23);
            this.lbTotal.TabIndex = 0;
            // 
            // frmPaymentGetOP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 127);
            this.Controls.Add(this.tOPNo);
            this.Controls.Add(this.mtbSearch);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbDetails);
            this.Location = new System.Drawing.Point(600, 300);
            this.Name = "frmPaymentGetOP";
            this.Text = "Get Order Of Payment";
            this.Load += new System.EventHandler(this.frmPaymentGetOP_Load);
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton mtbSearch;
        private MetroFramework.Controls.MetroTextBox tOPNo;
        private System.Windows.Forms.GroupBox gbDetails;
        private MetroFramework.Controls.MetroTextBox tORNo;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbMsc;
        private System.Windows.Forms.Label lbTuition;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbFName;
        private System.Windows.Forms.Label lbDate;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton mtbSubmit;
    }
}