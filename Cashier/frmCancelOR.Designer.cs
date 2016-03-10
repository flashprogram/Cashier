namespace Cashier
{
    partial class frmCancelOR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCancelOR));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tbCancelOR = new MetroFramework.Controls.MetroTextBox();
            this.mtbCancelOR = new MetroFramework.Controls.MetroButton();
            this.btnExit = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(74, 88);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(88, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "OR Number :";
            // 
            // tbCancelOR
            // 
            // 
            // 
            // 
            this.tbCancelOR.CustomButton.Image = null;
            this.tbCancelOR.CustomButton.Location = new System.Drawing.Point(199, 1);
            this.tbCancelOR.CustomButton.Name = "";
            this.tbCancelOR.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbCancelOR.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbCancelOR.CustomButton.TabIndex = 1;
            this.tbCancelOR.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbCancelOR.CustomButton.UseSelectable = true;
            this.tbCancelOR.CustomButton.Visible = false;
            this.tbCancelOR.Lines = new string[0];
            this.tbCancelOR.Location = new System.Drawing.Point(180, 88);
            this.tbCancelOR.MaxLength = 32767;
            this.tbCancelOR.Name = "tbCancelOR";
            this.tbCancelOR.PasswordChar = '\0';
            this.tbCancelOR.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbCancelOR.SelectedText = "";
            this.tbCancelOR.SelectionLength = 0;
            this.tbCancelOR.SelectionStart = 0;
            this.tbCancelOR.ShortcutsEnabled = true;
            this.tbCancelOR.Size = new System.Drawing.Size(221, 23);
            this.tbCancelOR.TabIndex = 1;
            this.tbCancelOR.UseSelectable = true;
            this.tbCancelOR.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbCancelOR.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbCancelOR.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbCancelOR_KeyDown);
            // 
            // mtbCancelOR
            // 
            this.mtbCancelOR.BackColor = System.Drawing.Color.DarkCyan;
            this.mtbCancelOR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mtbCancelOR.BackgroundImage")));
            this.mtbCancelOR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mtbCancelOR.Location = new System.Drawing.Point(398, 88);
            this.mtbCancelOR.Name = "mtbCancelOR";
            this.mtbCancelOR.Size = new System.Drawing.Size(38, 23);
            this.mtbCancelOR.TabIndex = 2;
            this.mtbCancelOR.UseSelectable = true;
            this.mtbCancelOR.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(361, 150);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseSelectable = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmCancelOR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 196);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.mtbCancelOR);
            this.Controls.Add(this.tbCancelOR);
            this.Controls.Add(this.metroLabel1);
            this.Name = "frmCancelOR";
            this.Text = "Cancel Order of Payment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox tbCancelOR;
        private MetroFramework.Controls.MetroButton mtbCancelOR;
        private MetroFramework.Controls.MetroButton btnExit;
    }
}