namespace Cashier
{
    partial class frmDailyReportParticular
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dailyReportPerParticularBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SCIISDataSet2 = new Cashier.SCIISDataSet2();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dailyReportPerParticularTableAdapter = new Cashier.SCIISDataSet2TableAdapters.dailyReportPerParticularTableAdapter();
            this.mtDate = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dailyReportPerParticularBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SCIISDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // dailyReportPerParticularBindingSource
            // 
            this.dailyReportPerParticularBindingSource.DataMember = "dailyReportPerParticular";
            this.dailyReportPerParticularBindingSource.DataSource = this.SCIISDataSet2;
            // 
            // SCIISDataSet2
            // 
            this.SCIISDataSet2.DataSetName = "SCIISDataSet2";
            this.SCIISDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dailyReportPerParticularBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Cashier.Reports.DailyReportParticular.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(23, 63);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(901, 535);
            this.reportViewer1.TabIndex = 0;
            // 
            // dailyReportPerParticularTableAdapter
            // 
            this.dailyReportPerParticularTableAdapter.ClearBeforeFill = true;
            // 
            // mtDate
            // 
            this.mtDate.AutoSize = true;
            this.mtDate.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mtDate.Location = new System.Drawing.Point(748, 25);
            this.mtDate.Name = "mtDate";
            this.mtDate.Size = new System.Drawing.Size(67, 25);
            this.mtDate.TabIndex = 1;
            this.mtDate.Text = "[ Date ]";
            // 
            // frmDailyReportParticular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 640);
            this.Controls.Add(this.mtDate);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmDailyReportParticular";
            this.Text = "Daily Report Per Particular";
            this.Load += new System.EventHandler(this.frmDailyReportParticular_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dailyReportPerParticularBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SCIISDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dailyReportPerParticularBindingSource;
        private SCIISDataSet2 SCIISDataSet2;
        private SCIISDataSet2TableAdapters.dailyReportPerParticularTableAdapter dailyReportPerParticularTableAdapter;
        private MetroFramework.Controls.MetroLabel mtDate;

    }
}