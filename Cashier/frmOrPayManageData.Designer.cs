namespace Cashier
{
    partial class frmOrPayManageData
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrPayManageData));
            this.clmSeqNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmStudID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmFName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmMName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmLName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnPartialPayment = new System.Windows.Forms.Button();
            this.clmAmountx = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lollipopLabel1 = new LollipopLabel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.lollipopLabel2 = new LollipopLabel();
            this.lvOP = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmStudNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mtOPDetails = new MetroFramework.Controls.MetroTile();
            this.mtPaymentHistory = new MetroFramework.Controls.MetroTile();
            this.mtcViewPaid = new MetroFramework.Controls.MetroCheckBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mtHistory = new MetroFramework.Controls.MetroTile();
            this.mtOPList = new MetroFramework.Controls.MetroTile();
            this.mtStudList = new MetroFramework.Controls.MetroTile();
            this.mtInfo = new MetroFramework.Controls.MetroTile();
            this.mtSearch = new MetroFramework.Controls.MetroTile();
            this.mtbOP = new MetroFramework.Controls.MetroButton();
            this.mtpStudInfo = new MetroFramework.Controls.MetroPanel();
            this.mtlName = new MetroFramework.Controls.MetroLabel();
            this.mtlStudID = new MetroFramework.Controls.MetroLabel();
            this.mtlBalance = new MetroFramework.Controls.MetroLabel();
            this.mtlCourse = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.studSearch = new System.Windows.Forms.TabPage();
            this.mtbStudent = new MetroFramework.Controls.MetroTextBox();
            this.metroLink5 = new MetroFramework.Controls.MetroLink();
            this.metroLink4 = new MetroFramework.Controls.MetroLink();
            this.metroLink3 = new MetroFramework.Controls.MetroLink();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLink2 = new MetroFramework.Controls.MetroLink();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.studInfo = new System.Windows.Forms.TabPage();
            this.opList = new System.Windows.Forms.TabPage();
            this.payHistory = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.studList = new System.Windows.Forms.TabPage();
            this.mtReissue = new MetroFramework.Controls.MetroTile();
            this.mtcbBalance = new MetroFramework.Controls.MetroCheckBox();
            this.groupBox1.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.mtpStudInfo.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.studSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lvManageRecord
            // 
            this.lvManageRecord.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvManageRecord.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lvManageRecord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvManageRecord.CheckBoxes = true;
            this.lvManageRecord.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmSeqNo,
            this.clmStudID,
            this.clmStudNo,
            this.clmAmountx,
            this.clmFName,
            this.clmMName,
            this.clmLName,
            this.columnHeader1});
            this.lvManageRecord.FullRowSelect = true;
            this.lvManageRecord.Location = new System.Drawing.Point(90, 36);
            this.lvManageRecord.MultiSelect = false;
            this.lvManageRecord.Size = new System.Drawing.Size(427, 350);
            this.lvManageRecord.SmallImageList = this.imageList1;
            this.lvManageRecord.Visible = false;
            this.lvManageRecord.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvManageRecord_ItemChecked);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(302, 76);
            this.btnSearch.Size = new System.Drawing.Size(39, 29);
            this.btnSearch.Text = "";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // tbSearch
            // 
            this.tbSearch.AcceptsTab = true;
            this.tbSearch.AllowDrop = true;
            this.tbSearch.Location = new System.Drawing.Point(74, 25);
            this.tbSearch.Size = new System.Drawing.Size(207, 20);
            this.metroToolTip1.SetToolTip(this.tbSearch, "Search using \r\n - Lastname or Firstname or both \r\n - StudID \r\n - Student Number (" +
        " not yet working)");
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mtcbBalance);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(90, 390);
            this.groupBox1.Size = new System.Drawing.Size(428, 62);
            this.groupBox1.Visible = false;
            this.groupBox1.Controls.SetChildIndex(this.label2, 0);
            this.groupBox1.Controls.SetChildIndex(this.mtcbBalance, 0);
            this.groupBox1.Controls.SetChildIndex(this.tbSearch, 0);
            this.groupBox1.Controls.SetChildIndex(this.btnSearch, 0);
            // 
            // clmSeqNo
            // 
            this.clmSeqNo.Text = "No";
            this.clmSeqNo.Width = 38;
            // 
            // clmStudID
            // 
            this.clmStudID.Text = "StudID";
            this.clmStudID.Width = 0;
            // 
            // clmFName
            // 
            this.clmFName.DisplayIndex = 3;
            this.clmFName.Text = "First Name";
            this.clmFName.Width = 65;
            // 
            // clmMName
            // 
            this.clmMName.DisplayIndex = 4;
            this.clmMName.Text = "Middle Name";
            this.clmMName.Width = 76;
            // 
            // clmLName
            // 
            this.clmLName.DisplayIndex = 5;
            this.clmLName.Text = "Last Name";
            this.clmLName.Width = 63;
            // 
            // btnPartialPayment
            // 
            this.btnPartialPayment.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnPartialPayment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPartialPayment.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPartialPayment.Location = new System.Drawing.Point(253, 590);
            this.btnPartialPayment.Name = "btnPartialPayment";
            this.btnPartialPayment.Size = new System.Drawing.Size(134, 36);
            this.btnPartialPayment.TabIndex = 4;
            this.btnPartialPayment.Text = "Partial/Full Payment";
            this.btnPartialPayment.UseVisualStyleBackColor = false;
            this.btnPartialPayment.Visible = false;
            this.btnPartialPayment.Click += new System.EventHandler(this.btnPartialPayment_Click);
            // 
            // clmAmountx
            // 
            this.clmAmountx.DisplayIndex = 6;
            this.clmAmountx.Text = "Amount";
            this.clmAmountx.Width = 59;
            // 
            // lollipopLabel1
            // 
            this.lollipopLabel1.BackColor = System.Drawing.Color.SteelBlue;
            this.lollipopLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lollipopLabel1.ForeColor = System.Drawing.Color.White;
            this.lollipopLabel1.Location = new System.Drawing.Point(0, -4);
            this.lollipopLabel1.Name = "lollipopLabel1";
            this.lollipopLabel1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lollipopLabel1.Size = new System.Drawing.Size(1200, 31);
            this.lollipopLabel1.TabIndex = 4;
            this.lollipopLabel1.Text = "Student Payment System";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Gender Neutral User-48.png");
            this.imageList1.Images.SetKeyName(1, "Bill-48.png");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Filter :";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ProgCode";
            this.columnHeader1.Width = 73;
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.AutomaticDelay = 100;
            this.metroToolTip1.AutoPopDelay = 5000;
            this.metroToolTip1.InitialDelay = 50;
            this.metroToolTip1.ReshowDelay = 20;
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Tag = "";
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // lollipopLabel2
            // 
            this.lollipopLabel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lollipopLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lollipopLabel2.ForeColor = System.Drawing.Color.White;
            this.lollipopLabel2.Location = new System.Drawing.Point(523, 30);
            this.lollipopLabel2.Name = "lollipopLabel2";
            this.lollipopLabel2.Padding = new System.Windows.Forms.Padding(5, 35, 0, 0);
            this.lollipopLabel2.Size = new System.Drawing.Size(507, 320);
            this.lollipopLabel2.TabIndex = 6;
            this.lollipopLabel2.Text = "Recent Order Of Payments";
            // 
            // lvOP
            // 
            this.lvOP.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lvOP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvOP.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5,
            this.columnHeader4});
            this.lvOP.ForeColor = System.Drawing.SystemColors.Info;
            this.lvOP.FullRowSelect = true;
            this.lvOP.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvOP.Location = new System.Drawing.Point(538, 97);
            this.lvOP.Name = "lvOP";
            this.lvOP.Size = new System.Drawing.Size(492, 253);
            this.lvOP.TabIndex = 7;
            this.lvOP.UseCompatibleStateImageBehavior = false;
            this.lvOP.View = System.Windows.Forms.View.Details;
            this.lvOP.SelectedIndexChanged += new System.EventHandler(this.lvOP_SelectedIndexChanged);
            this.lvOP.Leave += new System.EventHandler(this.lvOP_Leave);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "OPNo.";
            this.columnHeader2.Width = 77;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Amount";
            this.columnHeader3.Width = 134;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Payor";
            this.columnHeader5.Width = 212;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Paid";
            this.columnHeader4.Width = 65;
            // 
            // clmStudNo
            // 
            this.clmStudNo.Text = "StudNo";
            this.clmStudNo.Width = 51;
            // 
            // mtOPDetails
            // 
            this.mtOPDetails.ActiveControl = null;
            this.mtOPDetails.Enabled = false;
            this.mtOPDetails.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mtOPDetails.Location = new System.Drawing.Point(523, 353);
            this.mtOPDetails.Name = "mtOPDetails";
            this.mtOPDetails.Size = new System.Drawing.Size(162, 97);
            this.mtOPDetails.Style = MetroFramework.MetroColorStyle.Silver;
            this.mtOPDetails.TabIndex = 8;
            this.mtOPDetails.Text = "OP Details";
            this.mtOPDetails.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtOPDetails.TileImage = ((System.Drawing.Image)(resources.GetObject("mtOPDetails.TileImage")));
            this.mtOPDetails.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtOPDetails.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mtOPDetails.UseCustomForeColor = true;
            this.mtOPDetails.UseSelectable = true;
            this.mtOPDetails.UseTileImage = true;
            this.mtOPDetails.Click += new System.EventHandler(this.mtOPDetails_Click);
            // 
            // mtPaymentHistory
            // 
            this.mtPaymentHistory.ActiveControl = null;
            this.mtPaymentHistory.Enabled = false;
            this.mtPaymentHistory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mtPaymentHistory.Location = new System.Drawing.Point(699, 353);
            this.mtPaymentHistory.Name = "mtPaymentHistory";
            this.mtPaymentHistory.Size = new System.Drawing.Size(169, 97);
            this.mtPaymentHistory.Style = MetroFramework.MetroColorStyle.Silver;
            this.mtPaymentHistory.TabIndex = 10;
            this.mtPaymentHistory.Text = "Payment History";
            this.mtPaymentHistory.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mtPaymentHistory.TileImage = ((System.Drawing.Image)(resources.GetObject("mtPaymentHistory.TileImage")));
            this.mtPaymentHistory.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtPaymentHistory.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mtPaymentHistory.UseCustomForeColor = true;
            this.mtPaymentHistory.UseSelectable = true;
            this.mtPaymentHistory.UseTileImage = true;
            // 
            // mtcViewPaid
            // 
            this.mtcViewPaid.AutoSize = true;
            this.mtcViewPaid.BackColor = System.Drawing.Color.DarkSlateGray;
            this.mtcViewPaid.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.mtcViewPaid.Location = new System.Drawing.Point(888, 71);
            this.mtcViewPaid.Name = "mtcViewPaid";
            this.mtcViewPaid.Size = new System.Drawing.Size(93, 15);
            this.mtcViewPaid.TabIndex = 11;
            this.mtcViewPaid.Text = "View Paid OP";
            this.mtcViewPaid.UseCustomBackColor = true;
            this.mtcViewPaid.UseCustomForeColor = true;
            this.mtcViewPaid.UseSelectable = true;
            this.mtcViewPaid.CheckedChanged += new System.EventHandler(this.mtcViewPaid_CheckedChanged);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.metroPanel1.Controls.Add(this.lollipopLabel1);
            this.metroPanel1.Controls.Add(this.panel1);
            this.metroPanel1.Controls.Add(this.mtbOP);
            this.metroPanel1.Controls.Add(this.mtpStudInfo);
            this.metroPanel1.Controls.Add(this.metroTabControl1);
            this.metroPanel1.Controls.Add(this.mtcViewPaid);
            this.metroPanel1.Controls.Add(this.lvOP);
            this.metroPanel1.Controls.Add(this.mtOPDetails);
            this.metroPanel1.Controls.Add(this.mtReissue);
            this.metroPanel1.Controls.Add(this.lollipopLabel2);
            this.metroPanel1.Controls.Add(this.mtPaymentHistory);
            this.metroPanel1.Controls.Add(this.btnPartialPayment);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 4);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1055, 644);
            this.metroPanel1.TabIndex = 12;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.UseCustomForeColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.mtHistory);
            this.panel1.Controls.Add(this.mtOPList);
            this.panel1.Controls.Add(this.mtStudList);
            this.panel1.Controls.Add(this.mtInfo);
            this.panel1.Controls.Add(this.mtSearch);
            this.panel1.Location = new System.Drawing.Point(3, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(71, 405);
            this.panel1.TabIndex = 15;
            // 
            // mtHistory
            // 
            this.mtHistory.ActiveControl = null;
            this.mtHistory.ForeColor = System.Drawing.Color.SeaShell;
            this.mtHistory.Location = new System.Drawing.Point(3, 202);
            this.mtHistory.Name = "mtHistory";
            this.mtHistory.Size = new System.Drawing.Size(63, 58);
            this.mtHistory.TabIndex = 4;
            this.mtHistory.Text = "History";
            this.mtHistory.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtHistory.TileImage = ((System.Drawing.Image)(resources.GetObject("mtHistory.TileImage")));
            this.mtHistory.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtHistory.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.mtHistory.UseCustomForeColor = true;
            this.mtHistory.UseSelectable = true;
            this.mtHistory.UseTileImage = true;
            this.mtHistory.Click += new System.EventHandler(this.mtHistory_Click);
            // 
            // mtOPList
            // 
            this.mtOPList.ActiveControl = null;
            this.mtOPList.ForeColor = System.Drawing.Color.SeaShell;
            this.mtOPList.Location = new System.Drawing.Point(3, 138);
            this.mtOPList.Name = "mtOPList";
            this.mtOPList.Size = new System.Drawing.Size(63, 58);
            this.mtOPList.TabIndex = 3;
            this.mtOPList.Text = "OP List";
            this.mtOPList.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtOPList.TileImage = ((System.Drawing.Image)(resources.GetObject("mtOPList.TileImage")));
            this.mtOPList.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtOPList.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.mtOPList.UseCustomForeColor = true;
            this.mtOPList.UseSelectable = true;
            this.mtOPList.UseTileImage = true;
            this.mtOPList.Click += new System.EventHandler(this.mtOPList_Click);
            // 
            // mtStudList
            // 
            this.mtStudList.ActiveControl = null;
            this.mtStudList.ForeColor = System.Drawing.Color.SeaShell;
            this.mtStudList.Location = new System.Drawing.Point(3, 266);
            this.mtStudList.Name = "mtStudList";
            this.mtStudList.Size = new System.Drawing.Size(63, 59);
            this.mtStudList.TabIndex = 2;
            this.mtStudList.Text = "List";
            this.mtStudList.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtStudList.TileImage = ((System.Drawing.Image)(resources.GetObject("mtStudList.TileImage")));
            this.mtStudList.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtStudList.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.mtStudList.UseCustomForeColor = true;
            this.mtStudList.UseSelectable = true;
            this.mtStudList.UseTileImage = true;
            this.mtStudList.Click += new System.EventHandler(this.mtStudList_Click);
            // 
            // mtInfo
            // 
            this.mtInfo.ActiveControl = null;
            this.mtInfo.ForeColor = System.Drawing.Color.SeaShell;
            this.mtInfo.Location = new System.Drawing.Point(3, 72);
            this.mtInfo.Name = "mtInfo";
            this.mtInfo.Size = new System.Drawing.Size(63, 58);
            this.mtInfo.TabIndex = 1;
            this.mtInfo.Text = "Info";
            this.mtInfo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtInfo.TileImage = ((System.Drawing.Image)(resources.GetObject("mtInfo.TileImage")));
            this.mtInfo.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtInfo.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.mtInfo.UseCustomForeColor = true;
            this.mtInfo.UseSelectable = true;
            this.mtInfo.UseTileImage = true;
            this.mtInfo.Click += new System.EventHandler(this.mtInfo_Click);
            // 
            // mtSearch
            // 
            this.mtSearch.ActiveControl = null;
            this.mtSearch.ForeColor = System.Drawing.Color.SeaShell;
            this.mtSearch.Location = new System.Drawing.Point(3, 3);
            this.mtSearch.Name = "mtSearch";
            this.mtSearch.Size = new System.Drawing.Size(63, 63);
            this.mtSearch.TabIndex = 0;
            this.mtSearch.Text = "Search";
            this.mtSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtSearch.TileImage = ((System.Drawing.Image)(resources.GetObject("mtSearch.TileImage")));
            this.mtSearch.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtSearch.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.mtSearch.UseCustomForeColor = true;
            this.mtSearch.UseSelectable = true;
            this.mtSearch.UseTileImage = true;
            this.mtSearch.Click += new System.EventHandler(this.mtSearch_Click);
            // 
            // mtbOP
            // 
            this.mtbOP.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mtbOP.Location = new System.Drawing.Point(168, 405);
            this.mtbOP.Name = "mtbOP";
            this.mtbOP.Size = new System.Drawing.Size(288, 29);
            this.mtbOP.TabIndex = 14;
            this.mtbOP.Text = "Process Order of Payment";
            this.mtbOP.UseCustomBackColor = true;
            this.mtbOP.UseCustomForeColor = true;
            this.mtbOP.UseSelectable = true;
            this.mtbOP.Visible = false;
            this.mtbOP.Click += new System.EventHandler(this.mtbOP_Click);
            // 
            // mtpStudInfo
            // 
            this.mtpStudInfo.BackColor = System.Drawing.SystemColors.Control;
            this.mtpStudInfo.Controls.Add(this.mtlName);
            this.mtpStudInfo.Controls.Add(this.mtlStudID);
            this.mtpStudInfo.Controls.Add(this.mtlBalance);
            this.mtpStudInfo.Controls.Add(this.mtlCourse);
            this.mtpStudInfo.HorizontalScrollbarBarColor = true;
            this.mtpStudInfo.HorizontalScrollbarHighlightOnWheel = false;
            this.mtpStudInfo.HorizontalScrollbarSize = 10;
            this.mtpStudInfo.Location = new System.Drawing.Point(238, 47);
            this.mtpStudInfo.Name = "mtpStudInfo";
            this.mtpStudInfo.Size = new System.Drawing.Size(279, 124);
            this.mtpStudInfo.TabIndex = 13;
            this.mtpStudInfo.UseCustomBackColor = true;
            this.mtpStudInfo.UseCustomForeColor = true;
            this.mtpStudInfo.VerticalScrollbarBarColor = true;
            this.mtpStudInfo.VerticalScrollbarHighlightOnWheel = false;
            this.mtpStudInfo.VerticalScrollbarSize = 10;
            // 
            // mtlName
            // 
            this.mtlName.AutoSize = true;
            this.mtlName.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mtlName.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mtlName.ForeColor = System.Drawing.Color.DarkRed;
            this.mtlName.Location = new System.Drawing.Point(14, 9);
            this.mtlName.Name = "mtlName";
            this.mtlName.Size = new System.Drawing.Size(79, 25);
            this.mtlName.TabIndex = 2;
            this.mtlName.Text = "[ Name ]";
            this.mtlName.UseCustomBackColor = true;
            this.mtlName.UseCustomForeColor = true;
            // 
            // mtlStudID
            // 
            this.mtlStudID.AutoSize = true;
            this.mtlStudID.FontSize = MetroFramework.MetroLabelSize.Small;
            this.mtlStudID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mtlStudID.Location = new System.Drawing.Point(14, 100);
            this.mtlStudID.Name = "mtlStudID";
            this.mtlStudID.Size = new System.Drawing.Size(0, 0);
            this.mtlStudID.TabIndex = 5;
            this.mtlStudID.UseCustomBackColor = true;
            this.mtlStudID.UseCustomForeColor = true;
            this.mtlStudID.Visible = false;
            // 
            // mtlBalance
            // 
            this.mtlBalance.AutoSize = true;
            this.mtlBalance.BackColor = System.Drawing.SystemColors.Control;
            this.mtlBalance.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mtlBalance.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mtlBalance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.mtlBalance.Location = new System.Drawing.Point(156, 75);
            this.mtlBalance.Name = "mtlBalance";
            this.mtlBalance.Size = new System.Drawing.Size(91, 25);
            this.mtlBalance.TabIndex = 4;
            this.mtlBalance.Text = "[ Balance ]";
            this.mtlBalance.UseCustomBackColor = true;
            this.mtlBalance.UseCustomForeColor = true;
            // 
            // mtlCourse
            // 
            this.mtlCourse.AutoSize = true;
            this.mtlCourse.FontSize = MetroFramework.MetroLabelSize.Small;
            this.mtlCourse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mtlCourse.Location = new System.Drawing.Point(15, 40);
            this.mtlCourse.Name = "mtlCourse";
            this.mtlCourse.Size = new System.Drawing.Size(54, 15);
            this.mtlCourse.TabIndex = 3;
            this.mtlCourse.Text = "[ Course ]";
            this.mtlCourse.UseCustomBackColor = true;
            this.mtlCourse.UseCustomForeColor = true;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.metroTabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.metroTabControl1.Controls.Add(this.studSearch);
            this.metroTabControl1.Controls.Add(this.opList);
            this.metroTabControl1.Controls.Add(this.payHistory);
            this.metroTabControl1.Controls.Add(this.tabPage2);
            this.metroTabControl1.Controls.Add(this.studList);
            this.metroTabControl1.Controls.Add(this.studInfo);
            this.metroTabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.metroTabControl1.ItemSize = new System.Drawing.Size(11, 200);
            this.metroTabControl1.Location = new System.Drawing.Point(2, 26);
            this.metroTabControl1.Margin = new System.Windows.Forms.Padding(10);
            this.metroTabControl1.Multiline = true;
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(515, 422);
            this.metroTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroTabControl1.TabIndex = 12;
            this.metroTabControl1.UseSelectable = true;
            this.metroTabControl1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.metroTabControl1_DrawItem);
            this.metroTabControl1.SelectedIndexChanged += new System.EventHandler(this.metroTabControl1_SelectedIndexChanged);
            // 
            // studSearch
            // 
            this.studSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studSearch.Controls.Add(this.mtbStudent);
            this.studSearch.Controls.Add(this.metroLink5);
            this.studSearch.Controls.Add(this.metroLink4);
            this.studSearch.Controls.Add(this.metroLink3);
            this.studSearch.Controls.Add(this.metroLabel4);
            this.studSearch.Controls.Add(this.metroLink2);
            this.studSearch.Controls.Add(this.metroLabel3);
            this.studSearch.Controls.Add(this.metroLink1);
            this.studSearch.Controls.Add(this.metroLabel2);
            this.studSearch.Controls.Add(this.pictureBox1);
            this.studSearch.Cursor = System.Windows.Forms.Cursors.Default;
            this.studSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studSearch.Location = new System.Drawing.Point(85, 4);
            this.studSearch.Name = "studSearch";
            this.studSearch.Padding = new System.Windows.Forms.Padding(10);
            this.studSearch.Size = new System.Drawing.Size(426, 414);
            this.studSearch.TabIndex = 0;
            this.studSearch.Text = "StudentasldjasdkStudentasldjasdkStudentasldjasdkStudentasldjasdkStudentasldjasdkS" +
    "tudentasldjasdkStudentasldjasdk";
            // 
            // mtbStudent
            // 
            this.mtbStudent.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.mtbStudent.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            // 
            // 
            // 
            this.mtbStudent.CustomButton.Image = null;
            this.mtbStudent.CustomButton.Location = new System.Drawing.Point(320, 1);
            this.mtbStudent.CustomButton.Name = "";
            this.mtbStudent.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtbStudent.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbStudent.CustomButton.TabIndex = 1;
            this.mtbStudent.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbStudent.CustomButton.UseSelectable = true;
            this.mtbStudent.Lines = new string[0];
            this.mtbStudent.Location = new System.Drawing.Point(0, 166);
            this.mtbStudent.MaxLength = 32767;
            this.mtbStudent.Name = "mtbStudent";
            this.mtbStudent.PasswordChar = '\0';
            this.mtbStudent.PromptText = "Lastname, Firstname Middle (StudNo N/A)";
            this.mtbStudent.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbStudent.SelectedText = "";
            this.mtbStudent.SelectionLength = 0;
            this.mtbStudent.SelectionStart = 0;
            this.mtbStudent.ShortcutsEnabled = true;
            this.mtbStudent.ShowButton = true;
            this.mtbStudent.ShowClearButton = true;
            this.mtbStudent.Size = new System.Drawing.Size(342, 23);
            this.mtbStudent.TabIndex = 1;
            this.mtbStudent.UseSelectable = true;
            this.mtbStudent.WaterMark = "Lastname, Firstname Middle (StudNo N/A)";
            this.mtbStudent.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbStudent.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.mtbStudent.TextChanged += new System.EventHandler(this.mtbStudent_TextChanged);
            this.mtbStudent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtbStudent_KeyDown);
            // 
            // metroLink5
            // 
            this.metroLink5.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown;
            this.metroLink5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroLink5.ForeColor = System.Drawing.Color.SteelBlue;
            this.metroLink5.Image = ((System.Drawing.Image)(resources.GetObject("metroLink5.Image")));
            this.metroLink5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLink5.Location = new System.Drawing.Point(258, 229);
            this.metroLink5.Name = "metroLink5";
            this.metroLink5.Size = new System.Drawing.Size(139, 23);
            this.metroLink5.TabIndex = 22;
            this.metroLink5.Text = "Student OP List";
            this.metroLink5.UseCustomBackColor = true;
            this.metroLink5.UseCustomForeColor = true;
            this.metroLink5.UseSelectable = true;
            this.metroLink5.Click += new System.EventHandler(this.metroLink5_Click);
            // 
            // metroLink4
            // 
            this.metroLink4.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown;
            this.metroLink4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroLink4.ForeColor = System.Drawing.Color.SteelBlue;
            this.metroLink4.Image = ((System.Drawing.Image)(resources.GetObject("metroLink4.Image")));
            this.metroLink4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLink4.Location = new System.Drawing.Point(20, 258);
            this.metroLink4.Name = "metroLink4";
            this.metroLink4.Size = new System.Drawing.Size(183, 23);
            this.metroLink4.TabIndex = 21;
            this.metroLink4.Text = "Student Payment History";
            this.metroLink4.UseCustomBackColor = true;
            this.metroLink4.UseCustomForeColor = true;
            this.metroLink4.UseSelectable = true;
            this.metroLink4.Click += new System.EventHandler(this.metroLink4_Click);
            // 
            // metroLink3
            // 
            this.metroLink3.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown;
            this.metroLink3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroLink3.ForeColor = System.Drawing.Color.SteelBlue;
            this.metroLink3.Image = ((System.Drawing.Image)(resources.GetObject("metroLink3.Image")));
            this.metroLink3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLink3.Location = new System.Drawing.Point(20, 227);
            this.metroLink3.Name = "metroLink3";
            this.metroLink3.Size = new System.Drawing.Size(113, 23);
            this.metroLink3.TabIndex = 20;
            this.metroLink3.Text = "   Student Info";
            this.metroLink3.UseCustomBackColor = true;
            this.metroLink3.UseCustomForeColor = true;
            this.metroLink3.UseSelectable = true;
            this.metroLink3.Click += new System.EventHandler(this.metroLink3_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.Location = new System.Drawing.Point(0, 190);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(441, 30);
            this.metroLabel4.TabIndex = 19;
            this.metroLabel4.Text = "Selected student info : ";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroLabel4.WrapToLine = true;
            // 
            // metroLink2
            // 
            this.metroLink2.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown;
            this.metroLink2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroLink2.ForeColor = System.Drawing.Color.SteelBlue;
            this.metroLink2.Location = new System.Drawing.Point(336, 336);
            this.metroLink2.Name = "metroLink2";
            this.metroLink2.Size = new System.Drawing.Size(75, 23);
            this.metroLink2.TabIndex = 18;
            this.metroLink2.Text = "View Now";
            this.metroLink2.UseCustomBackColor = true;
            this.metroLink2.UseCustomForeColor = true;
            this.metroLink2.UseSelectable = true;
            this.metroLink2.Click += new System.EventHandler(this.metroLink2_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.Location = new System.Drawing.Point(0, 297);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(444, 30);
            this.metroLabel3.TabIndex = 17;
            this.metroLabel3.Text = "View all Student with Filter";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel3.WrapToLine = true;
            // 
            // metroLink1
            // 
            this.metroLink1.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown;
            this.metroLink1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroLink1.ForeColor = System.Drawing.Color.SteelBlue;
            this.metroLink1.Location = new System.Drawing.Point(348, 165);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(74, 23);
            this.metroLink1.TabIndex = 2;
            this.metroLink1.Text = "Search Now";
            this.metroLink1.UseCustomBackColor = true;
            this.metroLink1.UseCustomForeColor = true;
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(-1, 143);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(445, 22);
            this.metroLabel2.TabIndex = 15;
            this.metroLabel2.Text = "Quickly Search any student using  Student Name";
            this.metroLabel2.WrapToLine = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 137);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // studInfo
            // 
            this.studInfo.Location = new System.Drawing.Point(85, 4);
            this.studInfo.Name = "studInfo";
            this.studInfo.Size = new System.Drawing.Size(426, 414);
            this.studInfo.TabIndex = 5;
            this.studInfo.Text = "Student Info";
            // 
            // opList
            // 
            this.opList.Location = new System.Drawing.Point(85, 4);
            this.opList.Name = "opList";
            this.opList.Size = new System.Drawing.Size(426, 414);
            this.opList.TabIndex = 4;
            this.opList.Text = "Student OP List";
            // 
            // payHistory
            // 
            this.payHistory.Location = new System.Drawing.Point(85, 4);
            this.payHistory.Name = "payHistory";
            this.payHistory.Size = new System.Drawing.Size(426, 414);
            this.payHistory.TabIndex = 2;
            this.payHistory.Text = "Student P-History";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(85, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(426, 414);
            this.tabPage2.TabIndex = 6;
            // 
            // studList
            // 
            this.studList.Location = new System.Drawing.Point(85, 4);
            this.studList.Name = "studList";
            this.studList.Size = new System.Drawing.Size(426, 414);
            this.studList.TabIndex = 1;
            this.studList.Text = "Student List";
            // 
            // mtReissue
            // 
            this.mtReissue.ActiveControl = null;
            this.mtReissue.Enabled = false;
            this.mtReissue.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mtReissue.Location = new System.Drawing.Point(879, 353);
            this.mtReissue.Name = "mtReissue";
            this.mtReissue.Size = new System.Drawing.Size(151, 97);
            this.mtReissue.Style = MetroFramework.MetroColorStyle.Silver;
            this.mtReissue.TabIndex = 9;
            this.mtReissue.Text = "Re-issue OP";
            this.mtReissue.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtReissue.TileImage = ((System.Drawing.Image)(resources.GetObject("mtReissue.TileImage")));
            this.mtReissue.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtReissue.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mtReissue.UseCustomForeColor = true;
            this.mtReissue.UseSelectable = true;
            this.mtReissue.UseTileImage = true;
            // 
            // mtcbBalance
            // 
            this.mtcbBalance.AutoSize = true;
            this.mtcbBalance.BackColor = System.Drawing.Color.MintCream;
            this.mtcbBalance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mtcbBalance.Location = new System.Drawing.Point(302, 28);
            this.mtcbBalance.Name = "mtcbBalance";
            this.mtcbBalance.Size = new System.Drawing.Size(84, 15);
            this.mtcbBalance.TabIndex = 13;
            this.mtcbBalance.Text = "Balance > 0";
            this.mtcbBalance.UseCustomBackColor = true;
            this.mtcbBalance.UseCustomForeColor = true;
            this.mtcbBalance.UseSelectable = true;
            this.mtcbBalance.CheckedChanged += new System.EventHandler(this.mtcbBalance_CheckedChanged);
            // 
            // frmOrPayManageData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BackMaxSize = 1300;
            this.ClientSize = new System.Drawing.Size(1026, 630);
            this.Controls.Add(this.metroPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOrPayManageData";
            this.Resizable = false;
            this.Text = "Order Of Payment";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmOrPayManageData_FormClosed);
            this.Load += new System.EventHandler(this.frmOrPayManageData_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.lvManageRecord, 0);
            this.Controls.SetChildIndex(this.metroPanel1, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.mtpStudInfo.ResumeLayout(false);
            this.mtpStudInfo.PerformLayout();
            this.metroTabControl1.ResumeLayout(false);
            this.studSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColumnHeader clmSeqNo;
        private System.Windows.Forms.ColumnHeader clmStudID;
        private System.Windows.Forms.ColumnHeader clmFName;
        private System.Windows.Forms.ColumnHeader clmMName;
        private System.Windows.Forms.ColumnHeader clmLName;
        private System.Windows.Forms.Button btnPartialPayment;
        private System.Windows.Forms.ColumnHeader clmAmountx;
        private LollipopLabel lollipopLabel1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private LollipopLabel lollipopLabel2;
        private System.Windows.Forms.ListView lvOP;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader clmStudNo;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private MetroFramework.Controls.MetroTile mtOPDetails;
        private MetroFramework.Controls.MetroTile mtPaymentHistory;
        private MetroFramework.Controls.MetroCheckBox mtcViewPaid;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroCheckBox mtcbBalance;
        private MetroFramework.Controls.MetroTile mtReissue;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private System.Windows.Forms.TabPage studSearch;
        private System.Windows.Forms.TabPage studList;
        private System.Windows.Forms.TabPage payHistory;
        private System.Windows.Forms.TabPage opList;
        private System.Windows.Forms.TabPage studInfo;
        private System.Windows.Forms.TabPage tabPage2;
        private MetroFramework.Controls.MetroButton mtbOP;
        private MetroFramework.Controls.MetroPanel mtpStudInfo;
        private MetroFramework.Controls.MetroLabel mtlName;
        private MetroFramework.Controls.MetroLabel mtlStudID;
        private MetroFramework.Controls.MetroLabel mtlBalance;
        private MetroFramework.Controls.MetroLabel mtlCourse;
        private MetroFramework.Controls.MetroTextBox mtbStudent;
        private MetroFramework.Controls.MetroLink metroLink5;
        private MetroFramework.Controls.MetroLink metroLink4;
        private MetroFramework.Controls.MetroLink metroLink3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLink metroLink2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTile mtSearch;
        private MetroFramework.Controls.MetroTile mtStudList;
        private MetroFramework.Controls.MetroTile mtInfo;
        private MetroFramework.Controls.MetroTile mtHistory;
        private MetroFramework.Controls.MetroTile mtOPList;
    }
}