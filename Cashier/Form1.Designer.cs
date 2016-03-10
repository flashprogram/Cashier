namespace Cashier
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reprintOPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderOfPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reissueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reprintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.developerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportProblemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.requestAdditionalFeaturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tspHome = new System.Windows.Forms.ToolStripButton();
            this.tspSettings = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tspAdd = new System.Windows.Forms.ToolStripButton();
            this.tspUpdate = new System.Windows.Forms.ToolStripButton();
            this.tspView = new System.Windows.Forms.ToolStripButton();
            this.tspDelete = new System.Windows.Forms.ToolStripButton();
            this.btnLogout = new MetroFramework.Controls.MetroLink();
            this.btnUser = new MetroFramework.Controls.MetroLink();
            this.lbDept = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.studentToolStripMenuItem,
            this.utilitiesToolStripMenuItem,
            this.developerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 70);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(150, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(843, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.Turquoise;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.BackColor = System.Drawing.Color.MediumAquamarine;
            this.studentToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(63, 21);
            this.studentToolStripMenuItem.Text = "Student";
            // 
            // utilitiesToolStripMenuItem
            // 
            this.utilitiesToolStripMenuItem.BackColor = System.Drawing.Color.MediumAquamarine;
            this.utilitiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reprintOPToolStripMenuItem,
            this.orderOfPaymentToolStripMenuItem});
            this.utilitiesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.utilitiesToolStripMenuItem.Name = "utilitiesToolStripMenuItem";
            this.utilitiesToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.utilitiesToolStripMenuItem.Text = "Utilities";
            // 
            // reprintOPToolStripMenuItem
            // 
            this.reprintOPToolStripMenuItem.Name = "reprintOPToolStripMenuItem";
            this.reprintOPToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.reprintOPToolStripMenuItem.Text = "Reprint OP";
            // 
            // orderOfPaymentToolStripMenuItem
            // 
            this.orderOfPaymentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reissueToolStripMenuItem,
            this.reprintToolStripMenuItem});
            this.orderOfPaymentToolStripMenuItem.Name = "orderOfPaymentToolStripMenuItem";
            this.orderOfPaymentToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.orderOfPaymentToolStripMenuItem.Text = "Order Of Payment";
            // 
            // reissueToolStripMenuItem
            // 
            this.reissueToolStripMenuItem.Name = "reissueToolStripMenuItem";
            this.reissueToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.reissueToolStripMenuItem.Text = "Re-issue";
            // 
            // reprintToolStripMenuItem
            // 
            this.reprintToolStripMenuItem.Name = "reprintToolStripMenuItem";
            this.reprintToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.reprintToolStripMenuItem.Text = "Reprint";
            // 
            // developerToolStripMenuItem
            // 
            this.developerToolStripMenuItem.BackColor = System.Drawing.Color.MediumAquamarine;
            this.developerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportProblemToolStripMenuItem,
            this.requestAdditionalFeaturesToolStripMenuItem});
            this.developerToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.developerToolStripMenuItem.Name = "developerToolStripMenuItem";
            this.developerToolStripMenuItem.Size = new System.Drawing.Size(77, 21);
            this.developerToolStripMenuItem.Text = "Developer";
            // 
            // reportProblemToolStripMenuItem
            // 
            this.reportProblemToolStripMenuItem.Name = "reportProblemToolStripMenuItem";
            this.reportProblemToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.reportProblemToolStripMenuItem.Text = "Report Problem or BUG";
            // 
            // requestAdditionalFeaturesToolStripMenuItem
            // 
            this.requestAdditionalFeaturesToolStripMenuItem.Name = "requestAdditionalFeaturesToolStripMenuItem";
            this.requestAdditionalFeaturesToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.requestAdditionalFeaturesToolStripMenuItem.Text = "Request Additional Features";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspHome,
            this.tspSettings,
            this.toolStripSeparator1,
            this.tspAdd,
            this.tspUpdate,
            this.tspView,
            this.tspDelete});
            this.toolStrip1.Location = new System.Drawing.Point(0, 95);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(150, 0, 1, 0);
            this.toolStrip1.Size = new System.Drawing.Size(843, 68);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tspHome
            // 
            this.tspHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tspHome.Image = ((System.Drawing.Image)(resources.GetObject("tspHome.Image")));
            this.tspHome.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tspHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspHome.Name = "tspHome";
            this.tspHome.Size = new System.Drawing.Size(52, 65);
            this.tspHome.Text = "Home";
            this.tspHome.Click += new System.EventHandler(this.tspHome_Click);
            // 
            // tspSettings
            // 
            this.tspSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tspSettings.Image = ((System.Drawing.Image)(resources.GetObject("tspSettings.Image")));
            this.tspSettings.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tspSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspSettings.Name = "tspSettings";
            this.tspSettings.Size = new System.Drawing.Size(52, 65);
            this.tspSettings.Text = "Settings";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 68);
            // 
            // tspAdd
            // 
            this.tspAdd.AutoSize = false;
            this.tspAdd.Image = ((System.Drawing.Image)(resources.GetObject("tspAdd.Image")));
            this.tspAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tspAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspAdd.Name = "tspAdd";
            this.tspAdd.Size = new System.Drawing.Size(80, 64);
            this.tspAdd.Click += new System.EventHandler(this.tspAdd_Click);
            // 
            // tspUpdate
            // 
            this.tspUpdate.AutoSize = false;
            this.tspUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tspUpdate.Image = ((System.Drawing.Image)(resources.GetObject("tspUpdate.Image")));
            this.tspUpdate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tspUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspUpdate.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.tspUpdate.Name = "tspUpdate";
            this.tspUpdate.Size = new System.Drawing.Size(68, 64);
            this.tspUpdate.Text = "Update";
            // 
            // tspView
            // 
            this.tspView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tspView.Image = ((System.Drawing.Image)(resources.GetObject("tspView.Image")));
            this.tspView.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tspView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspView.Margin = new System.Windows.Forms.Padding(5, 1, 5, 2);
            this.tspView.Name = "tspView";
            this.tspView.Size = new System.Drawing.Size(52, 65);
            this.tspView.Text = "View";
            // 
            // tspDelete
            // 
            this.tspDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tspDelete.Image = ((System.Drawing.Image)(resources.GetObject("tspDelete.Image")));
            this.tspDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tspDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspDelete.Margin = new System.Windows.Forms.Padding(5, 1, 5, 2);
            this.tspDelete.Name = "tspDelete";
            this.tspDelete.Size = new System.Drawing.Size(52, 65);
            this.tspDelete.Text = "Delete";
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.ImageSize = 32;
            this.btnLogout.Location = new System.Drawing.Point(751, 29);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(73, 38);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.UseCustomForeColor = true;
            this.btnLogout.UseSelectable = true;
            this.btnLogout.UseStyleColors = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnUser
            // 
            this.btnUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUser.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.btnUser.Image = ((System.Drawing.Image)(resources.GetObject("btnUser.Image")));
            this.btnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.ImageSize = 32;
            this.btnUser.Location = new System.Drawing.Point(584, 29);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(129, 38);
            this.btnUser.TabIndex = 4;
            this.btnUser.Text = "User";
            this.btnUser.UseCustomForeColor = true;
            this.btnUser.UseSelectable = true;
            this.btnUser.UseStyleColors = true;
            // 
            // lbDept
            // 
            this.lbDept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDept.Font = new System.Drawing.Font("Segoe UI Semilight", 8F);
            this.lbDept.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbDept.Location = new System.Drawing.Point(647, 55);
            this.lbDept.Name = "lbDept";
            this.lbDept.Size = new System.Drawing.Size(98, 17);
            this.lbDept.TabIndex = 6;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BackImage = ((System.Drawing.Image)(resources.GetObject("$this.BackImage")));
            this.BackMaxSize = 145;
            this.ClientSize = new System.Drawing.Size(843, 563);
            this.Controls.Add(this.lbDept);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(550, 526);
            this.Name = "frmHome";
            this.Padding = new System.Windows.Forms.Padding(0, 70, 0, 23);
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Text = "                   Cashier M-System";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHome_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tspHome;
        private System.Windows.Forms.ToolStripButton tspSettings;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tspAdd;
        private System.Windows.Forms.ToolStripButton tspUpdate;
        private System.Windows.Forms.ToolStripButton tspView;
        private System.Windows.Forms.ToolStripButton tspDelete;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        public MetroFramework.Controls.MetroLink btnUser;
        public MetroFramework.Controls.MetroLink btnLogout;
        public System.Windows.Forms.Label lbDept;
        private System.Windows.Forms.ToolStripMenuItem utilitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reprintOPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderOfPaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reissueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reprintToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem developerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportProblemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem requestAdditionalFeaturesToolStripMenuItem;
    }
}

