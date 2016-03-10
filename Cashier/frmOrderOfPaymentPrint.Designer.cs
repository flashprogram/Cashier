namespace Cashier
{
    partial class frmOrderOfPaymentPrint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrderOfPaymentPrint));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.getOrderOfPaymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cashierDataSet1 = new Cashier.cashierDataSet1();
            this.getOrderOfPaymentTableAdapter = new Cashier.cashierDataSet1TableAdapters.getOrderOfPaymentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.getOrderOfPaymentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashierDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.reportViewer1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("reportViewer1.BackgroundImage")));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.getOrderOfPaymentBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Cashier.classes.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 26);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(705, 480);
            this.reportViewer1.TabIndex = 0;
            // 
            // getOrderOfPaymentBindingSource
            // 
            this.getOrderOfPaymentBindingSource.DataMember = "getOrderOfPayment";
            this.getOrderOfPaymentBindingSource.DataSource = this.cashierDataSet1;
            // 
            // cashierDataSet1
            // 
            this.cashierDataSet1.DataSetName = "cashierDataSet1";
            this.cashierDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getOrderOfPaymentTableAdapter
            // 
            this.getOrderOfPaymentTableAdapter.ClearBeforeFill = true;
            // 
            // frmOrderOfPaymentPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 518);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmOrderOfPaymentPrint";
            this.Text = "frmOrderOfPaymentPrint";
            this.Load += new System.EventHandler(this.frmOrderOfPaymentPrint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.getOrderOfPaymentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashierDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource getOrderOfPaymentBindingSource;
        private cashierDataSet1 cashierDataSet1;
        private cashierDataSet1TableAdapters.getOrderOfPaymentTableAdapter getOrderOfPaymentTableAdapter;
    }
}