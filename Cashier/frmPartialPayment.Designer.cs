namespace Cashier
{
    partial class frmPartialPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPartialPayment));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.tbSemNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbStudentName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.tAmount = new System.Windows.Forms.TextBox();
            this.lbMscFee = new System.Windows.Forms.Label();
            this.lbTuitionFee = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rbtnFull = new System.Windows.Forms.CheckBox();
            this.tPaymentOrNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtOrDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbSem = new System.Windows.Forms.ComboBox();
            this.lbStudNo = new System.Windows.Forms.Label();
            this.mtrbCash = new MetroFramework.Controls.MetroRadioButton();
            this.mtrbCheck = new MetroFramework.Controls.MetroRadioButton();
            this.mtbBankName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mtbCheckNo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.mtdCheckDate = new MetroFramework.Controls.MetroDateTime();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mtbCheckAmount = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gbNSTPType = new System.Windows.Forms.GroupBox();
            this.mtrbCWTS = new MetroFramework.Controls.MetroRadioButton();
            this.mtrbROTC = new MetroFramework.Controls.MetroRadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbNSTPType.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(576, 10);
            this.btnSave.Size = new System.Drawing.Size(63, 40);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "       OK";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(646, 10);
            this.btnCancel.Size = new System.Drawing.Size(85, 40);
            this.btnCancel.Text = "       Cancel";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(14, 129);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(728, 243);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "SeqNo";
            this.columnHeader1.Width = 71;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "StudID";
            this.columnHeader2.Width = 0;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "SemNo";
            this.columnHeader3.Width = 0;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Particulars";
            this.columnHeader4.Width = 253;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Amount";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Payment";
            this.columnHeader6.Width = 114;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Balance";
            this.columnHeader7.Width = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select Semester :";
            // 
            // tbSemNo
            // 
            this.tbSemNo.Font = new System.Drawing.Font("Segoe UI", 5.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSemNo.Location = new System.Drawing.Point(171, 78);
            this.tbSemNo.Name = "tbSemNo";
            this.tbSemNo.Size = new System.Drawing.Size(37, 17);
            this.tbSemNo.TabIndex = 1;
            this.tbSemNo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.tbSemNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSemNo_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "For :";
            // 
            // lbStudentName
            // 
            this.lbStudentName.AutoSize = true;
            this.lbStudentName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStudentName.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbStudentName.Location = new System.Drawing.Point(50, 60);
            this.lbStudentName.Name = "lbStudentName";
            this.lbStudentName.Size = new System.Drawing.Size(92, 13);
            this.lbStudentName.TabIndex = 7;
            this.lbStudentName.Text = "[ Student Name ]";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lbTotal);
            this.groupBox1.Controls.Add(this.tAmount);
            this.groupBox1.Controls.Add(this.lbMscFee);
            this.groupBox1.Controls.Add(this.lbTuitionFee);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.groupBox1.Location = new System.Drawing.Point(15, 378);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(727, 102);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment Summary";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(406, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Amount :";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTotal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbTotal.Location = new System.Drawing.Point(486, 20);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(46, 25);
            this.lbTotal.TabIndex = 16;
            this.lbTotal.Text = "0.00";
            // 
            // tAmount
            // 
            this.tAmount.BackColor = System.Drawing.Color.Gainsboro;
            this.tAmount.Location = new System.Drawing.Point(479, 54);
            this.tAmount.Name = "tAmount";
            this.tAmount.Size = new System.Drawing.Size(226, 22);
            this.tAmount.TabIndex = 25;
            this.tAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tAmount_KeyPress);
            // 
            // lbMscFee
            // 
            this.lbMscFee.AutoSize = true;
            this.lbMscFee.Location = new System.Drawing.Point(286, 43);
            this.lbMscFee.Name = "lbMscFee";
            this.lbMscFee.Size = new System.Drawing.Size(13, 13);
            this.lbMscFee.TabIndex = 4;
            this.lbMscFee.Text = "0";
            // 
            // lbTuitionFee
            // 
            this.lbTuitionFee.AutoSize = true;
            this.lbTuitionFee.Location = new System.Drawing.Point(286, 22);
            this.lbTuitionFee.Name = "lbTuitionFee";
            this.lbTuitionFee.Size = new System.Drawing.Size(13, 13);
            this.lbTuitionFee.TabIndex = 3;
            this.lbTuitionFee.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DarkCyan;
            this.label6.Location = new System.Drawing.Point(35, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Miscellaneous Fee (REQUIRED) :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DarkCyan;
            this.label5.Location = new System.Drawing.Point(35, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tuition Fee (50% if Partial) :";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(409, 16);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.label4.Size = new System.Drawing.Size(296, 33);
            this.label4.TabIndex = 15;
            this.label4.Text = "Total :";
            // 
            // rbtnFull
            // 
            this.rbtnFull.AutoSize = true;
            this.rbtnFull.Location = new System.Drawing.Point(691, 106);
            this.rbtnFull.Name = "rbtnFull";
            this.rbtnFull.Size = new System.Drawing.Size(94, 17);
            this.rbtnFull.TabIndex = 2;
            this.rbtnFull.Text = "Full Payment";
            this.rbtnFull.UseVisualStyleBackColor = true;
            this.rbtnFull.CheckedChanged += new System.EventHandler(this.rbtnFull_CheckedChanged_2);
            // 
            // tPaymentOrNo
            // 
            this.tPaymentOrNo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tPaymentOrNo.Location = new System.Drawing.Point(138, 103);
            this.tPaymentOrNo.Name = "tPaymentOrNo";
            this.tPaymentOrNo.Size = new System.Drawing.Size(161, 22);
            this.tPaymentOrNo.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Payment Order # :";
            // 
            // dtOrDate
            // 
            this.dtOrDate.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtOrDate.Location = new System.Drawing.Point(348, 103);
            this.dtOrDate.Name = "dtOrDate";
            this.dtOrDate.Size = new System.Drawing.Size(233, 22);
            this.dtOrDate.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(305, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Date :";
            // 
            // cmbSem
            // 
            this.cmbSem.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSem.FormattingEnabled = true;
            this.cmbSem.Location = new System.Drawing.Point(138, 77);
            this.cmbSem.Name = "cmbSem";
            this.cmbSem.Size = new System.Drawing.Size(161, 21);
            this.cmbSem.TabIndex = 25;
            this.cmbSem.SelectedIndexChanged += new System.EventHandler(this.cmbSem_SelectedIndexChanged);
            // 
            // lbStudNo
            // 
            this.lbStudNo.AutoSize = true;
            this.lbStudNo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStudNo.ForeColor = System.Drawing.Color.DimGray;
            this.lbStudNo.Location = new System.Drawing.Point(215, 60);
            this.lbStudNo.Name = "lbStudNo";
            this.lbStudNo.Size = new System.Drawing.Size(108, 13);
            this.lbStudNo.TabIndex = 26;
            this.lbStudNo.Text = "[ Student Number ]";
            // 
            // mtrbCash
            // 
            this.mtrbCash.AutoSize = true;
            this.mtrbCash.Checked = true;
            this.mtrbCash.Location = new System.Drawing.Point(9, 17);
            this.mtrbCash.Name = "mtrbCash";
            this.mtrbCash.Size = new System.Drawing.Size(49, 15);
            this.mtrbCash.TabIndex = 27;
            this.mtrbCash.TabStop = true;
            this.mtrbCash.Text = "Cash";
            this.mtrbCash.UseSelectable = true;
            this.mtrbCash.CheckedChanged += new System.EventHandler(this.mtrbCash_CheckedChanged);
            // 
            // mtrbCheck
            // 
            this.mtrbCheck.AutoSize = true;
            this.mtrbCheck.Location = new System.Drawing.Point(64, 17);
            this.mtrbCheck.Name = "mtrbCheck";
            this.mtrbCheck.Size = new System.Drawing.Size(56, 15);
            this.mtrbCheck.TabIndex = 28;
            this.mtrbCheck.Text = "Check";
            this.mtrbCheck.UseSelectable = true;
            this.mtrbCheck.CheckedChanged += new System.EventHandler(this.mtrbCheck_CheckedChanged);
            // 
            // mtbBankName
            // 
            // 
            // 
            // 
            this.mtbBankName.CustomButton.Image = null;
            this.mtbBankName.CustomButton.Location = new System.Drawing.Point(100, 1);
            this.mtbBankName.CustomButton.Name = "";
            this.mtbBankName.CustomButton.Size = new System.Drawing.Size(18, 21);
            this.mtbBankName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbBankName.CustomButton.TabIndex = 1;
            this.mtbBankName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbBankName.CustomButton.UseSelectable = true;
            this.mtbBankName.CustomButton.Visible = false;
            this.mtbBankName.Lines = new string[0];
            this.mtbBankName.Location = new System.Drawing.Point(124, 15);
            this.mtbBankName.MaxLength = 32767;
            this.mtbBankName.Name = "mtbBankName";
            this.mtbBankName.PasswordChar = '\0';
            this.mtbBankName.PromptText = "Abbreviation of bank name";
            this.mtbBankName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbBankName.SelectedText = "";
            this.mtbBankName.SelectionLength = 0;
            this.mtbBankName.SelectionStart = 0;
            this.mtbBankName.ShortcutsEnabled = true;
            this.mtbBankName.Size = new System.Drawing.Size(139, 23);
            this.mtbBankName.TabIndex = 29;
            this.mtbBankName.UseSelectable = true;
            this.mtbBankName.WaterMark = "Abbreviation of bank name";
            this.mtbBankName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbBankName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(14, 18);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(74, 15);
            this.metroLabel1.TabIndex = 30;
            this.metroLabel1.Text = "Bank Name :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(14, 44);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(65, 15);
            this.metroLabel2.TabIndex = 32;
            this.metroLabel2.Text = "Check No :";
            // 
            // mtbCheckNo
            // 
            // 
            // 
            // 
            this.mtbCheckNo.CustomButton.Image = null;
            this.mtbCheckNo.CustomButton.Location = new System.Drawing.Point(100, 1);
            this.mtbCheckNo.CustomButton.Name = "";
            this.mtbCheckNo.CustomButton.Size = new System.Drawing.Size(18, 21);
            this.mtbCheckNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbCheckNo.CustomButton.TabIndex = 1;
            this.mtbCheckNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbCheckNo.CustomButton.UseSelectable = true;
            this.mtbCheckNo.CustomButton.Visible = false;
            this.mtbCheckNo.Lines = new string[0];
            this.mtbCheckNo.Location = new System.Drawing.Point(124, 41);
            this.mtbCheckNo.MaxLength = 32767;
            this.mtbCheckNo.Name = "mtbCheckNo";
            this.mtbCheckNo.PasswordChar = '\0';
            this.mtbCheckNo.PromptText = "x x x x x x x";
            this.mtbCheckNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbCheckNo.SelectedText = "";
            this.mtbCheckNo.SelectionLength = 0;
            this.mtbCheckNo.SelectionStart = 0;
            this.mtbCheckNo.ShortcutsEnabled = true;
            this.mtbCheckNo.Size = new System.Drawing.Size(139, 23);
            this.mtbCheckNo.TabIndex = 31;
            this.mtbCheckNo.UseSelectable = true;
            this.mtbCheckNo.WaterMark = "x x x x x x x";
            this.mtbCheckNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbCheckNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(316, 18);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(73, 15);
            this.metroLabel3.TabIndex = 33;
            this.metroLabel3.Text = "Check Date :";
            // 
            // mtdCheckDate
            // 
            this.mtdCheckDate.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.mtdCheckDate.FontWeight = MetroFramework.MetroDateTimeWeight.Light;
            this.mtdCheckDate.Location = new System.Drawing.Point(446, 13);
            this.mtdCheckDate.MinimumSize = new System.Drawing.Size(4, 25);
            this.mtdCheckDate.Name = "mtdCheckDate";
            this.mtdCheckDate.Size = new System.Drawing.Size(200, 25);
            this.mtdCheckDate.TabIndex = 34;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mtbCheckAmount);
            this.groupBox2.Controls.Add(this.metroLabel4);
            this.groupBox2.Controls.Add(this.mtdCheckDate);
            this.groupBox2.Controls.Add(this.mtbBankName);
            this.groupBox2.Controls.Add(this.metroLabel1);
            this.groupBox2.Controls.Add(this.mtbCheckNo);
            this.groupBox2.Controls.Add(this.metroLabel3);
            this.groupBox2.Controls.Add(this.metroLabel2);
            this.groupBox2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.groupBox2.Location = new System.Drawing.Point(14, 302);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(728, 70);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Check Details";
            // 
            // mtbCheckAmount
            // 
            // 
            // 
            // 
            this.mtbCheckAmount.CustomButton.Image = null;
            this.mtbCheckAmount.CustomButton.Location = new System.Drawing.Point(152, 1);
            this.mtbCheckAmount.CustomButton.Name = "";
            this.mtbCheckAmount.CustomButton.Size = new System.Drawing.Size(18, 21);
            this.mtbCheckAmount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbCheckAmount.CustomButton.TabIndex = 1;
            this.mtbCheckAmount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbCheckAmount.CustomButton.UseSelectable = true;
            this.mtbCheckAmount.CustomButton.Visible = false;
            this.mtbCheckAmount.Lines = new string[0];
            this.mtbCheckAmount.Location = new System.Drawing.Point(447, 41);
            this.mtbCheckAmount.MaxLength = 32767;
            this.mtbCheckAmount.Name = "mtbCheckAmount";
            this.mtbCheckAmount.PasswordChar = '\0';
            this.mtbCheckAmount.PromptText = "Input specified amount";
            this.mtbCheckAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbCheckAmount.SelectedText = "";
            this.mtbCheckAmount.SelectionLength = 0;
            this.mtbCheckAmount.SelectionStart = 0;
            this.mtbCheckAmount.ShortcutsEnabled = true;
            this.mtbCheckAmount.Size = new System.Drawing.Size(199, 23);
            this.mtbCheckAmount.TabIndex = 36;
            this.mtbCheckAmount.UseSelectable = true;
            this.mtbCheckAmount.WaterMark = "Input specified amount";
            this.mtbCheckAmount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbCheckAmount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.mtbCheckAmount.TextChanged += new System.EventHandler(this.mtbCheckAmount_TextChanged);
            this.mtbCheckAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbCheckAmount_KeyPress);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(316, 44);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(93, 15);
            this.metroLabel4.TabIndex = 35;
            this.metroLabel4.Text = "Check Amount :";
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.mtrbCash);
            this.groupBox3.Controls.Add(this.mtrbCheck);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(351, 57);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(124, 38);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Payment Type";
            // 
            // gbNSTPType
            // 
            this.gbNSTPType.BackColor = System.Drawing.Color.Transparent;
            this.gbNSTPType.Controls.Add(this.mtrbCWTS);
            this.gbNSTPType.Controls.Add(this.mtrbROTC);
            this.gbNSTPType.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNSTPType.Location = new System.Drawing.Point(484, 57);
            this.gbNSTPType.Name = "gbNSTPType";
            this.gbNSTPType.Size = new System.Drawing.Size(176, 38);
            this.gbNSTPType.TabIndex = 37;
            this.gbNSTPType.TabStop = false;
            this.gbNSTPType.Text = "NSTP Type";
            this.gbNSTPType.Visible = false;
            // 
            // mtrbCWTS
            // 
            this.mtrbCWTS.AutoSize = true;
            this.mtrbCWTS.Location = new System.Drawing.Point(20, 17);
            this.mtrbCWTS.Name = "mtrbCWTS";
            this.mtrbCWTS.Size = new System.Drawing.Size(55, 15);
            this.mtrbCWTS.TabIndex = 27;
            this.mtrbCWTS.Text = "CWTS";
            this.mtrbCWTS.UseSelectable = true;
            // 
            // mtrbROTC
            // 
            this.mtrbROTC.AutoSize = true;
            this.mtrbROTC.Location = new System.Drawing.Point(100, 17);
            this.mtrbROTC.Name = "mtrbROTC";
            this.mtrbROTC.Size = new System.Drawing.Size(54, 15);
            this.mtrbROTC.TabIndex = 28;
            this.mtrbROTC.Text = "ROTC";
            this.mtrbROTC.UseSelectable = true;
            // 
            // frmPartialPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackLocation = MetroFramework.Forms.BackLocation.TopLeft;
            this.ClientSize = new System.Drawing.Size(755, 493);
            this.Controls.Add(this.gbNSTPType);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbStudNo);
            this.Controls.Add(this.cmbSem);
            this.Controls.Add(this.tPaymentOrNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtOrDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rbtnFull);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbStudentName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSemNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox3);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmPartialPayment";
            this.Padding = new System.Windows.Forms.Padding(23, 60, 23, 20);
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "Tuition / Misc Payment";
            this.Load += new System.EventHandler(this.frmPartialPayment_Load);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.tbSemNo, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.lbStudentName, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.rbtnFull, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.dtOrDate, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.tPaymentOrNo, 0);
            this.Controls.SetChildIndex(this.cmbSem, 0);
            this.Controls.SetChildIndex(this.lbStudNo, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.listView1, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.gbNSTPType, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbNSTPType.ResumeLayout(false);
            this.gbNSTPType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSemNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbStudentName;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbMscFee;
        private System.Windows.Forms.Label lbTuitionFee;
        private System.Windows.Forms.CheckBox rbtnFull;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tPaymentOrNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtOrDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tAmount;
        private System.Windows.Forms.ComboBox cmbSem;
        private System.Windows.Forms.Label lbStudNo;
        private MetroFramework.Controls.MetroRadioButton mtrbCash;
        private MetroFramework.Controls.MetroRadioButton mtrbCheck;
        private MetroFramework.Controls.MetroTextBox mtbBankName;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox mtbCheckNo;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroDateTime mtdCheckDate;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox mtbCheckAmount;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox gbNSTPType;
        private MetroFramework.Controls.MetroRadioButton mtrbCWTS;
        private MetroFramework.Controls.MetroRadioButton mtrbROTC;
    }
}