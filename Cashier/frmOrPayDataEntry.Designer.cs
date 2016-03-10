namespace Cashier
{
    partial class frmOrPayDataEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrPayDataEntry));
            this.dtOrDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tPaymentOrNo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pNewParticular = new System.Windows.Forms.Panel();
            this.btnNewParticularExit = new System.Windows.Forms.Button();
            this.btnNewParticular = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tbNewParticularShortDesc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbNewParticularAmount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lvDataEntryOP = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSeqNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSemNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmStudID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmParticulars = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.mtbCheckAmount = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.mtdCheckDate = new MetroFramework.Controls.MetroDateTime();
            this.mtbBankName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mtbCheckNo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnAddParticular = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbParticular = new System.Windows.Forms.ComboBox();
            this.lbStudID = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.PictureBox();
            this.btnPayor = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tbMiddlename = new System.Windows.Forms.TextBox();
            this.tbFirstname = new System.Windows.Forms.TextBox();
            this.tbLastname = new System.Windows.Forms.TextBox();
            this.btnSelectParticular = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbRemarks = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tAmount = new System.Windows.Forms.TextBox();
            this.lbTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.mrbBtr = new MetroFramework.Controls.MetroRadioButton();
            this.mrbIGD = new MetroFramework.Controls.MetroRadioButton();
            this.mrbFiduciary = new MetroFramework.Controls.MetroRadioButton();
            this.mrbMasteral = new MetroFramework.Controls.MetroRadioButton();
            this.mrbUndergrad = new MetroFramework.Controls.MetroRadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.mtrbCash = new MetroFramework.Controls.MetroRadioButton();
            this.mtrbCheck = new MetroFramework.Controls.MetroRadioButton();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.groupBox1.SuspendLayout();
            this.pNewParticular.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnReset)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(529, 12);
            this.btnSave.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnSave.Size = new System.Drawing.Size(115, 40);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "      Submit && Print";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(650, 12);
            this.btnCancel.TabIndex = 6;
            // 
            // dtOrDate
            // 
            this.dtOrDate.Location = new System.Drawing.Point(22, 83);
            this.dtOrDate.Name = "dtOrDate";
            this.dtOrDate.Size = new System.Drawing.Size(200, 22);
            this.dtOrDate.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(242, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Payment Order # :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Payor  :";
            // 
            // tPaymentOrNo
            // 
            this.tPaymentOrNo.Location = new System.Drawing.Point(246, 81);
            this.tPaymentOrNo.Name = "tPaymentOrNo";
            this.tPaymentOrNo.Size = new System.Drawing.Size(183, 22);
            this.tPaymentOrNo.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pNewParticular);
            this.groupBox1.Controls.Add(this.lvDataEntryOP);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.btnAddParticular);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cmbParticular);
            this.groupBox1.Controls.Add(this.lbStudID);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.btnPayor);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.tbMiddlename);
            this.groupBox1.Controls.Add(this.tbFirstname);
            this.groupBox1.Controls.Add(this.tbLastname);
            this.groupBox1.Controls.Add(this.btnSelectParticular);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.groupBox1.Size = new System.Drawing.Size(738, 390);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "...";
            // 
            // pNewParticular
            // 
            this.pNewParticular.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pNewParticular.Controls.Add(this.btnNewParticularExit);
            this.pNewParticular.Controls.Add(this.btnNewParticular);
            this.pNewParticular.Controls.Add(this.label9);
            this.pNewParticular.Controls.Add(this.tbNewParticularShortDesc);
            this.pNewParticular.Controls.Add(this.label8);
            this.pNewParticular.Controls.Add(this.tbNewParticularAmount);
            this.pNewParticular.Controls.Add(this.label7);
            this.pNewParticular.Location = new System.Drawing.Point(450, 37);
            this.pNewParticular.Name = "pNewParticular";
            this.pNewParticular.Size = new System.Drawing.Size(200, 123);
            this.pNewParticular.TabIndex = 29;
            this.pNewParticular.Visible = false;
            // 
            // btnNewParticularExit
            // 
            this.btnNewParticularExit.Location = new System.Drawing.Point(108, 95);
            this.btnNewParticularExit.Name = "btnNewParticularExit";
            this.btnNewParticularExit.Size = new System.Drawing.Size(56, 23);
            this.btnNewParticularExit.TabIndex = 7;
            this.btnNewParticularExit.Text = "Exit";
            this.btnNewParticularExit.UseVisualStyleBackColor = true;
            this.btnNewParticularExit.Click += new System.EventHandler(this.btnNewParticularExit_Click);
            // 
            // btnNewParticular
            // 
            this.btnNewParticular.Location = new System.Drawing.Point(46, 95);
            this.btnNewParticular.Name = "btnNewParticular";
            this.btnNewParticular.Size = new System.Drawing.Size(56, 23);
            this.btnNewParticular.TabIndex = 5;
            this.btnNewParticular.Text = "Save";
            this.btnNewParticular.UseVisualStyleBackColor = true;
            this.btnNewParticular.Click += new System.EventHandler(this.btnNewParticular_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(3, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 31);
            this.label9.TabIndex = 4;
            this.label9.Text = "Short Description";
            // 
            // tbNewParticularShortDesc
            // 
            this.tbNewParticularShortDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.tbNewParticularShortDesc.Location = new System.Drawing.Point(72, 52);
            this.tbNewParticularShortDesc.Name = "tbNewParticularShortDesc";
            this.tbNewParticularShortDesc.Size = new System.Drawing.Size(123, 31);
            this.tbNewParticularShortDesc.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Amount";
            // 
            // tbNewParticularAmount
            // 
            this.tbNewParticularAmount.Location = new System.Drawing.Point(72, 23);
            this.tbNewParticularAmount.Name = "tbNewParticularAmount";
            this.tbNewParticularAmount.Size = new System.Drawing.Size(123, 22);
            this.tbNewParticularAmount.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Particular Description";
            // 
            // lvDataEntryOP
            // 
            this.lvDataEntryOP.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.clmSeqNo,
            this.clmSemNo,
            this.clmStudID,
            this.clmParticulars,
            this.clmAmount});
            this.lvDataEntryOP.FullRowSelect = true;
            this.lvDataEntryOP.GridLines = true;
            this.lvDataEntryOP.Location = new System.Drawing.Point(17, 48);
            this.lvDataEntryOP.Name = "lvDataEntryOP";
            this.lvDataEntryOP.Size = new System.Drawing.Size(715, 215);
            this.lvDataEntryOP.TabIndex = 12;
            this.lvDataEntryOP.UseCompatibleStateImageBehavior = false;
            this.lvDataEntryOP.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.DisplayIndex = 5;
            this.columnHeader1.Width = 0;
            // 
            // clmSeqNo
            // 
            this.clmSeqNo.DisplayIndex = 0;
            this.clmSeqNo.Text = "No";
            // 
            // clmSemNo
            // 
            this.clmSemNo.DisplayIndex = 1;
            this.clmSemNo.Text = "SemNo";
            this.clmSemNo.Width = 0;
            // 
            // clmStudID
            // 
            this.clmStudID.DisplayIndex = 2;
            this.clmStudID.Text = "StudID";
            this.clmStudID.Width = 0;
            // 
            // clmParticulars
            // 
            this.clmParticulars.DisplayIndex = 3;
            this.clmParticulars.Text = "Particulars";
            this.clmParticulars.Width = 196;
            // 
            // clmAmount
            // 
            this.clmAmount.DisplayIndex = 4;
            this.clmAmount.Text = "Amount";
            this.clmAmount.Width = 160;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.mtbCheckAmount);
            this.groupBox5.Controls.Add(this.metroLabel4);
            this.groupBox5.Controls.Add(this.mtdCheckDate);
            this.groupBox5.Controls.Add(this.mtbBankName);
            this.groupBox5.Controls.Add(this.metroLabel1);
            this.groupBox5.Controls.Add(this.mtbCheckNo);
            this.groupBox5.Controls.Add(this.metroLabel3);
            this.groupBox5.Controls.Add(this.metroLabel2);
            this.groupBox5.ForeColor = System.Drawing.Color.SaddleBrown;
            this.groupBox5.Location = new System.Drawing.Point(18, 193);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(715, 70);
            this.groupBox5.TabIndex = 36;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Check Details";
            // 
            // mtbCheckAmount
            // 
            // 
            // 
            // 
            this.mtbCheckAmount.CustomButton.Image = null;
            this.mtbCheckAmount.CustomButton.Location = new System.Drawing.Point(177, 1);
            this.mtbCheckAmount.CustomButton.Name = "";
            this.mtbCheckAmount.CustomButton.Size = new System.Drawing.Size(21, 21);
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
            // mtbBankName
            // 
            // 
            // 
            // 
            this.mtbBankName.CustomButton.Image = null;
            this.mtbBankName.CustomButton.Location = new System.Drawing.Point(117, 1);
            this.mtbBankName.CustomButton.Name = "";
            this.mtbBankName.CustomButton.Size = new System.Drawing.Size(21, 21);
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
            // mtbCheckNo
            // 
            // 
            // 
            // 
            this.mtbCheckNo.CustomButton.Image = null;
            this.mtbCheckNo.CustomButton.Location = new System.Drawing.Point(117, 1);
            this.mtbCheckNo.CustomButton.Name = "";
            this.mtbCheckNo.CustomButton.Size = new System.Drawing.Size(21, 21);
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
            // btnAddParticular
            // 
            this.btnAddParticular.Image = ((System.Drawing.Image)(resources.GetObject("btnAddParticular.Image")));
            this.btnAddParticular.Location = new System.Drawing.Point(604, 11);
            this.btnAddParticular.Name = "btnAddParticular";
            this.btnAddParticular.Size = new System.Drawing.Size(32, 31);
            this.btnAddParticular.TabIndex = 3;
            this.btnAddParticular.UseVisualStyleBackColor = true;
            this.btnAddParticular.Click += new System.EventHandler(this.btnAddParticular_Click_1);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.SeaGreen;
            this.label12.Location = new System.Drawing.Point(253, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 32;
            this.label12.Text = "( Middlename )";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.SeaGreen;
            this.label11.Location = new System.Drawing.Point(177, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 12);
            this.label11.TabIndex = 31;
            this.label11.Text = "( Firstname )";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.SeaGreen;
            this.label10.Location = new System.Drawing.Point(96, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 12);
            this.label10.TabIndex = 30;
            this.label10.Text = "( Lastname )";
            // 
            // cmbParticular
            // 
            this.cmbParticular.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbParticular.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbParticular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbParticular.FormattingEnabled = true;
            this.cmbParticular.Location = new System.Drawing.Point(450, 14);
            this.cmbParticular.Name = "cmbParticular";
            this.cmbParticular.Size = new System.Drawing.Size(148, 24);
            this.cmbParticular.TabIndex = 2;
            this.cmbParticular.Enter += new System.EventHandler(this.cmbParticular_Enter);
            this.cmbParticular.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbParticular_KeyDown);
            this.cmbParticular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbParticular_KeyPress);
            this.cmbParticular.Leave += new System.EventHandler(this.cmbParticular_Leave);
            // 
            // lbStudID
            // 
            this.lbStudID.AutoSize = true;
            this.lbStudID.ForeColor = System.Drawing.Color.CadetBlue;
            this.lbStudID.Location = new System.Drawing.Point(360, 22);
            this.lbStudID.Name = "lbStudID";
            this.lbStudID.Size = new System.Drawing.Size(74, 13);
            this.lbStudID.TabIndex = 26;
            this.lbStudID.Text = "[ Student ID ]";
            this.lbStudID.Visible = false;
            // 
            // btnReset
            // 
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.Location = new System.Drawing.Point(337, 20);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(17, 19);
            this.btnReset.TabIndex = 25;
            this.btnReset.TabStop = false;
            this.btnReset.Visible = false;
            this.btnReset.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnPayor
            // 
            this.btnPayor.Image = ((System.Drawing.Image)(resources.GetObject("btnPayor.Image")));
            this.btnPayor.Location = new System.Drawing.Point(16, 17);
            this.btnPayor.Name = "btnPayor";
            this.btnPayor.Size = new System.Drawing.Size(26, 23);
            this.btnPayor.TabIndex = 1;
            this.btnPayor.Text = "...";
            this.metroToolTip1.SetToolTip(this.btnPayor, "Select Payor");
            this.btnPayor.UseVisualStyleBackColor = true;
            this.btnPayor.Click += new System.EventHandler(this.btnPayor_Click);
            this.btnPayor.Enter += new System.EventHandler(this.btnPayor_Enter);
            this.btnPayor.Leave += new System.EventHandler(this.btnPayor_Leave);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(639, 11);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(32, 31);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tbMiddlename
            // 
            this.tbMiddlename.Location = new System.Drawing.Point(256, 19);
            this.tbMiddlename.Name = "tbMiddlename";
            this.tbMiddlename.Size = new System.Drawing.Size(74, 22);
            this.tbMiddlename.TabIndex = 22;
            // 
            // tbFirstname
            // 
            this.tbFirstname.Location = new System.Drawing.Point(176, 19);
            this.tbFirstname.Name = "tbFirstname";
            this.tbFirstname.Size = new System.Drawing.Size(74, 22);
            this.tbFirstname.TabIndex = 21;
            // 
            // tbLastname
            // 
            this.tbLastname.Location = new System.Drawing.Point(97, 19);
            this.tbLastname.Name = "tbLastname";
            this.tbLastname.Size = new System.Drawing.Size(73, 22);
            this.tbLastname.TabIndex = 20;
            // 
            // btnSelectParticular
            // 
            this.btnSelectParticular.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectParticular.Image")));
            this.btnSelectParticular.Location = new System.Drawing.Point(673, 11);
            this.btnSelectParticular.Name = "btnSelectParticular";
            this.btnSelectParticular.Size = new System.Drawing.Size(32, 31);
            this.btnSelectParticular.TabIndex = 19;
            this.btnSelectParticular.UseVisualStyleBackColor = true;
            this.btnSelectParticular.Click += new System.EventHandler(this.btnAddParticular_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbRemarks);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tAmount);
            this.groupBox2.Controls.Add(this.lbTotal);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(18, 269);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(714, 112);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Payment";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F);
            this.label1.Location = new System.Drawing.Point(24, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Remarks :";
            // 
            // tbRemarks
            // 
            this.tbRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.tbRemarks.Location = new System.Drawing.Point(27, 34);
            this.tbRemarks.Multiline = true;
            this.tbRemarks.Name = "tbRemarks";
            this.tbRemarks.Size = new System.Drawing.Size(285, 64);
            this.tbRemarks.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(366, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Amount :";
            // 
            // tAmount
            // 
            this.tAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tAmount.Location = new System.Drawing.Point(460, 54);
            this.tAmount.Name = "tAmount";
            this.tAmount.Size = new System.Drawing.Size(254, 44);
            this.tAmount.TabIndex = 5;
            this.tAmount.Enter += new System.EventHandler(this.tAmount_Enter);
            this.tAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tAmount_KeyDown);
            this.tAmount.Leave += new System.EventHandler(this.tAmount_Leave);
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbTotal.Location = new System.Drawing.Point(439, 13);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(45, 24);
            this.lbTotal.TabIndex = 14;
            this.lbTotal.Text = "0.00";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(366, 9);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.label4.Size = new System.Drawing.Size(348, 33);
            this.label4.TabIndex = 13;
            this.label4.Text = "Total :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.mrbBtr);
            this.groupBox3.Controls.Add(this.mrbIGD);
            this.groupBox3.Controls.Add(this.mrbFiduciary);
            this.groupBox3.Controls.Add(this.mrbMasteral);
            this.groupBox3.Controls.Add(this.mrbUndergrad);
            this.groupBox3.Location = new System.Drawing.Point(540, 56);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(210, 58);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "OP Type";
            // 
            // mrbBtr
            // 
            this.mrbBtr.AutoSize = true;
            this.mrbBtr.Location = new System.Drawing.Point(88, 34);
            this.mrbBtr.Name = "mrbBtr";
            this.mrbBtr.Size = new System.Drawing.Size(44, 15);
            this.mrbBtr.TabIndex = 4;
            this.mrbBtr.Tag = "1";
            this.mrbBtr.Text = "BTR";
            this.mrbBtr.UseSelectable = true;
            // 
            // mrbIGD
            // 
            this.mrbIGD.AutoSize = true;
            this.mrbIGD.Location = new System.Drawing.Point(165, 17);
            this.mrbIGD.Name = "mrbIGD";
            this.mrbIGD.Size = new System.Drawing.Size(41, 15);
            this.mrbIGD.TabIndex = 3;
            this.mrbIGD.Tag = "5";
            this.mrbIGD.Text = "IGP";
            this.mrbIGD.UseSelectable = true;
            // 
            // mrbFiduciary
            // 
            this.mrbFiduciary.AutoSize = true;
            this.mrbFiduciary.Location = new System.Drawing.Point(88, 17);
            this.mrbFiduciary.Name = "mrbFiduciary";
            this.mrbFiduciary.Size = new System.Drawing.Size(71, 15);
            this.mrbFiduciary.TabIndex = 2;
            this.mrbFiduciary.Tag = "4";
            this.mrbFiduciary.Text = "Fiduciary";
            this.mrbFiduciary.UseSelectable = true;
            // 
            // mrbMasteral
            // 
            this.mrbMasteral.AutoSize = true;
            this.mrbMasteral.Location = new System.Drawing.Point(8, 34);
            this.mrbMasteral.Name = "mrbMasteral";
            this.mrbMasteral.Size = new System.Drawing.Size(68, 15);
            this.mrbMasteral.TabIndex = 1;
            this.mrbMasteral.Tag = "3";
            this.mrbMasteral.Text = "Masteral";
            this.mrbMasteral.UseSelectable = true;
            // 
            // mrbUndergrad
            // 
            this.mrbUndergrad.AutoSize = true;
            this.mrbUndergrad.Checked = true;
            this.mrbUndergrad.Location = new System.Drawing.Point(8, 17);
            this.mrbUndergrad.Name = "mrbUndergrad";
            this.mrbUndergrad.Size = new System.Drawing.Size(79, 15);
            this.mrbUndergrad.TabIndex = 0;
            this.mrbUndergrad.TabStop = true;
            this.mrbUndergrad.Tag = "2";
            this.mrbUndergrad.Text = "Undergrad";
            this.mrbUndergrad.UseSelectable = true;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.mtrbCash);
            this.groupBox4.Controls.Add(this.mtrbCheck);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(441, 56);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(93, 58);
            this.groupBox4.TabIndex = 37;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Payment Type";
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
            this.mtrbCash.Tag = "1";
            this.mtrbCash.Text = "Cash";
            this.mtrbCash.UseSelectable = true;
            this.mtrbCash.CheckedChanged += new System.EventHandler(this.mtrbCash_CheckedChanged_1);
            // 
            // mtrbCheck
            // 
            this.mtrbCheck.AutoSize = true;
            this.mtrbCheck.Location = new System.Drawing.Point(9, 35);
            this.mtrbCheck.Name = "mtrbCheck";
            this.mtrbCheck.Size = new System.Drawing.Size(56, 15);
            this.mtrbCheck.TabIndex = 28;
            this.mtrbCheck.Tag = "2";
            this.mtrbCheck.Text = "Check";
            this.mtrbCheck.UseSelectable = true;
            this.mtrbCheck.CheckedChanged += new System.EventHandler(this.mtrbCheck_CheckedChanged_1);
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.AutomaticDelay = 300;
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // frmOrPayDataEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 520);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tPaymentOrNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtOrDate);
            this.Controls.Add(this.label2);
            this.Name = "frmOrPayDataEntry";
            this.Text = "Other Payments";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmOrPayDataEntry_FormClosed);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.dtOrDate, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.tPaymentOrNo, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.Controls.SetChildIndex(this.groupBox4, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pNewParticular.ResumeLayout(false);
            this.pNewParticular.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnReset)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtOrDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tPaymentOrNo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvDataEntryOP;
        private System.Windows.Forms.ColumnHeader clmSeqNo;
        private System.Windows.Forms.ColumnHeader clmSemNo;
        private System.Windows.Forms.ColumnHeader clmStudID;
        private System.Windows.Forms.ColumnHeader clmParticulars;
        private System.Windows.Forms.ColumnHeader clmAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.TextBox tAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSelectParticular;
        private System.Windows.Forms.TextBox tbMiddlename;
        private System.Windows.Forms.TextBox tbFirstname;
        private System.Windows.Forms.TextBox tbLastname;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPayor;
        private System.Windows.Forms.PictureBox btnReset;
        private System.Windows.Forms.Label lbStudID;
        private System.Windows.Forms.ComboBox cmbParticular;
        private System.Windows.Forms.Button btnAddParticular;
        private System.Windows.Forms.Panel pNewParticular;
        private System.Windows.Forms.TextBox tbNewParticularAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbNewParticularShortDesc;
        private System.Windows.Forms.Button btnNewParticular;
        private System.Windows.Forms.Button btnNewParticularExit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroRadioButton mrbBtr;
        private MetroFramework.Controls.MetroRadioButton mrbIGD;
        private MetroFramework.Controls.MetroRadioButton mrbFiduciary;
        private MetroFramework.Controls.MetroRadioButton mrbMasteral;
        private MetroFramework.Controls.MetroRadioButton mrbUndergrad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbRemarks;
        private System.Windows.Forms.GroupBox groupBox4;
        private MetroFramework.Controls.MetroRadioButton mtrbCash;
        private MetroFramework.Controls.MetroRadioButton mtrbCheck;
        private System.Windows.Forms.GroupBox groupBox5;
        private MetroFramework.Controls.MetroTextBox mtbCheckAmount;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroDateTime mtdCheckDate;
        private MetroFramework.Controls.MetroTextBox mtbBankName;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox mtbCheckNo;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        public MetroFramework.Components.MetroToolTip metroToolTip1;
    }
}