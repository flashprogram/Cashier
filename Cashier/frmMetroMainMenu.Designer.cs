namespace Cashier
{
    partial class frmMetroMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMetroMainMenu));
            this.mtCashier = new MetroFramework.Controls.MetroTile();
            this.mtOP = new MetroFramework.Controls.MetroTile();
            this.mtReports = new MetroFramework.Controls.MetroTile();
            this.mtOPSearch = new MetroFramework.Controls.MetroTile();
            this.mtbCancelOR = new MetroFramework.Controls.MetroTile();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.mtlUser = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.mtInfoOPIssued = new MetroFramework.Controls.MetroTile();
            this.mtOPIssuedCount = new MetroFramework.Controls.MetroLabel();
            this.mtInfoOPPaid = new MetroFramework.Controls.MetroTile();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.mtInfoOPIssued.SuspendLayout();
            this.SuspendLayout();
            // 
            // mtCashier
            // 
            this.mtCashier.ActiveControl = null;
            this.mtCashier.Location = new System.Drawing.Point(206, 105);
            this.mtCashier.Name = "mtCashier";
            this.mtCashier.Size = new System.Drawing.Size(149, 104);
            this.mtCashier.Style = MetroFramework.MetroColorStyle.Purple;
            this.mtCashier.TabIndex = 1;
            this.mtCashier.Text = "Cashier";
            this.mtCashier.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtCashier.TileImage = ((System.Drawing.Image)(resources.GetObject("mtCashier.TileImage")));
            this.mtCashier.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtCashier.UseSelectable = true;
            this.mtCashier.UseTileImage = true;
            this.mtCashier.Click += new System.EventHandler(this.mtCashier_Click);
            // 
            // mtOP
            // 
            this.mtOP.ActiveControl = null;
            this.mtOP.Location = new System.Drawing.Point(60, 105);
            this.mtOP.Name = "mtOP";
            this.mtOP.Size = new System.Drawing.Size(140, 104);
            this.mtOP.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtOP.TabIndex = 2;
            this.mtOP.Text = "Order Of Payment";
            this.mtOP.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtOP.TileImage = ((System.Drawing.Image)(resources.GetObject("mtOP.TileImage")));
            this.mtOP.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtOP.UseSelectable = true;
            this.mtOP.UseTileImage = true;
            this.mtOP.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // mtReports
            // 
            this.mtReports.ActiveControl = null;
            this.mtReports.Location = new System.Drawing.Point(60, 317);
            this.mtReports.Name = "mtReports";
            this.mtReports.Size = new System.Drawing.Size(295, 87);
            this.mtReports.Style = MetroFramework.MetroColorStyle.Silver;
            this.mtReports.TabIndex = 3;
            this.mtReports.Text = "        Reports";
            this.mtReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mtReports.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtReports.TileImage = ((System.Drawing.Image)(resources.GetObject("mtReports.TileImage")));
            this.mtReports.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtReports.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtReports.UseSelectable = true;
            this.mtReports.UseTileImage = true;
            this.mtReports.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // mtOPSearch
            // 
            this.mtOPSearch.ActiveControl = null;
            this.mtOPSearch.Location = new System.Drawing.Point(60, 215);
            this.mtOPSearch.Name = "mtOPSearch";
            this.mtOPSearch.Size = new System.Drawing.Size(140, 96);
            this.mtOPSearch.Style = MetroFramework.MetroColorStyle.Teal;
            this.mtOPSearch.TabIndex = 7;
            this.mtOPSearch.Text = "OP Search";
            this.mtOPSearch.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtOPSearch.TileImage = ((System.Drawing.Image)(resources.GetObject("mtOPSearch.TileImage")));
            this.mtOPSearch.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtOPSearch.UseSelectable = true;
            this.mtOPSearch.UseTileImage = true;
            this.mtOPSearch.Click += new System.EventHandler(this.mtOPSearch_Click);
            // 
            // mtbCancelOR
            // 
            this.mtbCancelOR.ActiveControl = null;
            this.mtbCancelOR.Enabled = false;
            this.mtbCancelOR.Location = new System.Drawing.Point(206, 215);
            this.mtbCancelOR.Name = "mtbCancelOR";
            this.mtbCancelOR.Size = new System.Drawing.Size(149, 96);
            this.mtbCancelOR.Style = MetroFramework.MetroColorStyle.Green;
            this.mtbCancelOR.TabIndex = 8;
            this.mtbCancelOR.Text = "Cancel OR";
            this.mtbCancelOR.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbCancelOR.TileImage = ((System.Drawing.Image)(resources.GetObject("mtbCancelOR.TileImage")));
            this.mtbCancelOR.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtbCancelOR.UseSelectable = true;
            this.mtbCancelOR.UseTileImage = true;
            this.mtbCancelOR.Click += new System.EventHandler(this.mtbCancelOR_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(22, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 30);
            this.label1.TabIndex = 9;
            this.label1.Text = "Management System ( Currently in development)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 12.75F);
            this.label2.ForeColor = System.Drawing.Color.SlateGray;
            this.label2.Location = new System.Drawing.Point(14, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Welcome user : ";
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(171)))), ((int)(((byte)(53)))));
            this.metroPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.metroPanel1.Controls.Add(this.mtlUser);
            this.metroPanel1.Controls.Add(this.pictureBox1);
            this.metroPanel1.Controls.Add(this.metroLink1);
            this.metroPanel1.Controls.Add(this.label2);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(374, 105);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(200, 204);
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroPanel1.TabIndex = 11;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.UseCustomForeColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // mtlUser
            // 
            this.mtlUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mtlUser.AutoSize = true;
            this.mtlUser.FontSize = MetroFramework.MetroLabelSize.Small;
            this.mtlUser.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mtlUser.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.mtlUser.Location = new System.Drawing.Point(57, 149);
            this.mtlUser.Name = "mtlUser";
            this.mtlUser.Size = new System.Drawing.Size(33, 15);
            this.mtlUser.TabIndex = 13;
            this.mtlUser.Text = "User";
            this.mtlUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtlUser.UseCustomBackColor = true;
            this.mtlUser.UseCustomForeColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(44, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 135);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // metroLink1
            // 
            this.metroLink1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(171)))), ((int)(((byte)(53)))));
            this.metroLink1.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.metroLink1.ForeColor = System.Drawing.Color.SkyBlue;
            this.metroLink1.Image = ((System.Drawing.Image)(resources.GetObject("metroLink1.Image")));
            this.metroLink1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroLink1.Location = new System.Drawing.Point(128, 166);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(61, 33);
            this.metroLink1.TabIndex = 11;
            this.metroLink1.Text = "Logout";
            this.metroLink1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLink1.UseCustomBackColor = true;
            this.metroLink1.UseCustomForeColor = true;
            this.metroLink1.UseSelectable = true;
            // 
            // mtInfoOPIssued
            // 
            this.mtInfoOPIssued.ActiveControl = null;
            this.mtInfoOPIssued.Controls.Add(this.mtOPIssuedCount);
            this.mtInfoOPIssued.Enabled = false;
            this.mtInfoOPIssued.Location = new System.Drawing.Point(681, 105);
            this.mtInfoOPIssued.Name = "mtInfoOPIssued";
            this.mtInfoOPIssued.Size = new System.Drawing.Size(202, 143);
            this.mtInfoOPIssued.Style = MetroFramework.MetroColorStyle.Silver;
            this.mtInfoOPIssued.TabIndex = 12;
            this.mtInfoOPIssued.Text = "Total OP issued as of :";
            this.mtInfoOPIssued.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtInfoOPIssued.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtInfoOPIssued.UseSelectable = true;
            this.mtInfoOPIssued.UseTileImage = true;
            this.mtInfoOPIssued.Visible = false;
            // 
            // mtOPIssuedCount
            // 
            this.mtOPIssuedCount.AutoSize = true;
            this.mtOPIssuedCount.BackColor = System.Drawing.Color.Transparent;
            this.mtOPIssuedCount.Location = new System.Drawing.Point(58, 56);
            this.mtOPIssuedCount.Name = "mtOPIssuedCount";
            this.mtOPIssuedCount.Size = new System.Drawing.Size(83, 19);
            this.mtOPIssuedCount.TabIndex = 14;
            this.mtOPIssuedCount.Text = "metroLabel1";
            this.mtOPIssuedCount.UseCustomBackColor = true;
            // 
            // mtInfoOPPaid
            // 
            this.mtInfoOPPaid.ActiveControl = null;
            this.mtInfoOPPaid.Enabled = false;
            this.mtInfoOPPaid.Location = new System.Drawing.Point(681, 254);
            this.mtInfoOPPaid.Name = "mtInfoOPPaid";
            this.mtInfoOPPaid.Size = new System.Drawing.Size(202, 124);
            this.mtInfoOPPaid.Style = MetroFramework.MetroColorStyle.Red;
            this.mtInfoOPPaid.TabIndex = 13;
            this.mtInfoOPPaid.Text = "Total OP paid as of :";
            this.mtInfoOPPaid.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtInfoOPPaid.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtInfoOPPaid.UseSelectable = true;
            this.mtInfoOPPaid.UseTileImage = true;
            this.mtInfoOPPaid.Visible = false;
            // 
            // frmMetroMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1039, 548);
            this.Controls.Add(this.mtInfoOPPaid);
            this.Controls.Add(this.mtInfoOPIssued);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtbCancelOR);
            this.Controls.Add(this.mtOPSearch);
            this.Controls.Add(this.mtReports);
            this.Controls.Add(this.mtOP);
            this.Controls.Add(this.mtCashier);
            this.Name = "frmMetroMainMenu";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = " ";
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.mtInfoOPIssued.ResumeLayout(false);
            this.mtInfoOPIssued.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile mtCashier;
        private MetroFramework.Controls.MetroTile mtOP;
        private MetroFramework.Controls.MetroTile mtReports;
        private MetroFramework.Controls.MetroTile mtOPSearch;
        private MetroFramework.Controls.MetroTile mtbCancelOR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLink metroLink1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public MetroFramework.Controls.MetroLabel mtlUser;
        private MetroFramework.Controls.MetroTile mtInfoOPIssued;
        private MetroFramework.Controls.MetroTile mtInfoOPPaid;
        private MetroFramework.Controls.MetroLabel mtOPIssuedCount;
    }
}