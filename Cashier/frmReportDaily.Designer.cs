namespace Cashier
{
    partial class frmReportDaily
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.cashierDailyReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SCIISDataSet = new Cashier.SCIISDataSet();
            this.dtDailyReportDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cashierDailyReportTableAdapter = new Cashier.SCIISDataSetTableAdapters.cashierDailyReportTableAdapter();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.cmbOPType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mtDetailed = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.sciisDataSet11 = new Cashier.SCIISDataSet1();
            ((System.ComponentModel.ISupportInitialize)(this.cashierDailyReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SCIISDataSet)).BeginInit();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sciisDataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // cashierDailyReportBindingSource
            // 
            this.cashierDailyReportBindingSource.DataMember = "cashierDailyReport";
            this.cashierDailyReportBindingSource.DataSource = this.SCIISDataSet;
            // 
            // SCIISDataSet
            // 
            this.SCIISDataSet.DataSetName = "SCIISDataSet";
            this.SCIISDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtDailyReportDate
            // 
            this.dtDailyReportDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDailyReportDate.Location = new System.Drawing.Point(129, 63);
            this.dtDailyReportDate.Name = "dtDailyReportDate";
            this.dtDailyReportDate.Size = new System.Drawing.Size(221, 20);
            this.dtDailyReportDate.TabIndex = 1;
            this.dtDailyReportDate.ValueChanged += new System.EventHandler(this.dtDailyReportDate_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Date";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.reportViewer1.DocumentMapWidth = 44;
            reportDataSource4.Name = "DataSet2";
            reportDataSource4.Value = this.cashierDailyReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Cashier.Reports.DailyReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(43, 482);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(10, 10);
            this.reportViewer1.TabIndex = 3;
            // 
            // cashierDailyReportTableAdapter
            // 
            this.cashierDailyReportTableAdapter.ClearBeforeFill = true;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.mtDetailed);
            this.metroPanel1.Controls.Add(this.metroTile3);
            this.metroPanel1.Controls.Add(this.metroTile2);
            this.metroPanel1.Controls.Add(this.metroTile1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(1, 93);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(794, 328);
            this.metroPanel1.TabIndex = 4;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // cmbOPType
            // 
            this.cmbOPType.AutoCompleteCustomSource.AddRange(new string[] {
            "BTR",
            "UNDERGRAD",
            "MASTERAL",
            "FIDUCIARY",
            "IGP"});
            this.cmbOPType.FormattingEnabled = true;
            this.cmbOPType.Items.AddRange(new object[] {
            "BTR",
            "UNDERGRAD",
            "MASTERAL",
            "FIDUCIARY",
            "IGP"});
            this.cmbOPType.Location = new System.Drawing.Point(467, 63);
            this.cmbOPType.Name = "cmbOPType";
            this.cmbOPType.Size = new System.Drawing.Size(121, 21);
            this.cmbOPType.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(412, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "OP Type";
            // 
            // mtDetailed
            // 
            this.mtDetailed.ActiveControl = null;
            this.mtDetailed.Location = new System.Drawing.Point(466, 12);
            this.mtDetailed.Name = "mtDetailed";
            this.mtDetailed.Size = new System.Drawing.Size(236, 138);
            this.mtDetailed.TabIndex = 5;
            this.mtDetailed.Text = "Daily Report (Detailed)";
            this.mtDetailed.UseSelectable = true;
            this.mtDetailed.Click += new System.EventHandler(this.mtDetailed_Click);
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.Location = new System.Drawing.Point(466, 175);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(236, 138);
            this.metroTile3.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTile3.TabIndex = 4;
            this.metroTile3.Text = "Monthly Report";
            this.metroTile3.UseSelectable = true;
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(128, 175);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(236, 138);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroTile2.TabIndex = 3;
            this.metroTile2.Text = "Weekly Report";
            this.metroTile2.UseSelectable = true;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(128, 12);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(236, 138);
            this.metroTile1.TabIndex = 2;
            this.metroTile1.Text = "Daily Report";
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // sciisDataSet11
            // 
            this.sciisDataSet11.DataSetName = "SCIISDataSet1";
            this.sciisDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmReportDaily
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 484);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.cmbOPType);
            this.Controls.Add(this.dtDailyReportDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmReportDaily";
            this.Padding = new System.Windows.Forms.Padding(200, 60, 20, 20);
            this.Text = "Reports";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.Load += new System.EventHandler(this.frmReportDaily_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cashierDailyReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SCIISDataSet)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sciisDataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtDailyReportDate;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource cashierDailyReportBindingSource;
        private SCIISDataSet SCIISDataSet;
        private SCIISDataSetTableAdapters.cashierDailyReportTableAdapter cashierDailyReportTableAdapter;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile mtDetailed;
        private SCIISDataSet1 sciisDataSet11;
        private System.Windows.Forms.ComboBox cmbOPType;
        private System.Windows.Forms.Label label2;
    }
}