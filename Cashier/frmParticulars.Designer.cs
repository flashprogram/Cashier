namespace Cashier
{
    partial class frmParticulars
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
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.tbEdit = new System.Windows.Forms.Button();
            this.tbDelete = new System.Windows.Forms.Button();
            this.editPanel = new System.Windows.Forms.Panel();
            this.mtbClose = new MetroFramework.Controls.MetroButton();
            this.mtbSave = new MetroFramework.Controls.MetroButton();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbShortDesc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbParticularName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.editPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(386, 12);
            this.btnSave.Text = "Add to List";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(465, 12);
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.tbSearch.Location = new System.Drawing.Point(65, 366);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(185, 23);
            this.tbSearch.TabIndex = 4;
            this.tbSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(7, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Search :";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No";
            this.columnHeader1.Width = 45;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Particulars";
            this.columnHeader2.Width = 270;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Amount";
            this.columnHeader3.Width = 205;
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(10, 69);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(528, 285);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listView1_ItemChecked);
            // 
            // tbEdit
            // 
            this.tbEdit.Location = new System.Drawing.Point(314, 366);
            this.tbEdit.Name = "tbEdit";
            this.tbEdit.Size = new System.Drawing.Size(75, 23);
            this.tbEdit.TabIndex = 6;
            this.tbEdit.Text = "Edit";
            this.tbEdit.UseVisualStyleBackColor = true;
            this.tbEdit.Click += new System.EventHandler(this.tbEdit_Click);
            // 
            // tbDelete
            // 
            this.tbDelete.Location = new System.Drawing.Point(395, 366);
            this.tbDelete.Name = "tbDelete";
            this.tbDelete.Size = new System.Drawing.Size(75, 23);
            this.tbDelete.TabIndex = 7;
            this.tbDelete.Text = "Delete";
            this.tbDelete.UseVisualStyleBackColor = true;
            this.tbDelete.Click += new System.EventHandler(this.tbDelete_Click);
            // 
            // editPanel
            // 
            this.editPanel.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.editPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.editPanel.Controls.Add(this.mtbClose);
            this.editPanel.Controls.Add(this.mtbSave);
            this.editPanel.Controls.Add(this.tbAmount);
            this.editPanel.Controls.Add(this.label4);
            this.editPanel.Controls.Add(this.tbShortDesc);
            this.editPanel.Controls.Add(this.label3);
            this.editPanel.Controls.Add(this.tbParticularName);
            this.editPanel.Controls.Add(this.label1);
            this.editPanel.Location = new System.Drawing.Point(130, 209);
            this.editPanel.Name = "editPanel";
            this.editPanel.Size = new System.Drawing.Size(258, 158);
            this.editPanel.TabIndex = 8;
            this.editPanel.Visible = false;
            // 
            // mtbClose
            // 
            this.mtbClose.Location = new System.Drawing.Point(173, 122);
            this.mtbClose.Name = "mtbClose";
            this.mtbClose.Size = new System.Drawing.Size(75, 23);
            this.mtbClose.TabIndex = 7;
            this.mtbClose.Text = "Close";
            this.mtbClose.UseSelectable = true;
            this.mtbClose.Click += new System.EventHandler(this.mtbClose_Click);
            // 
            // mtbSave
            // 
            this.mtbSave.Location = new System.Drawing.Point(92, 122);
            this.mtbSave.Name = "mtbSave";
            this.mtbSave.Size = new System.Drawing.Size(75, 23);
            this.mtbSave.TabIndex = 6;
            this.mtbSave.Text = "Save";
            this.mtbSave.UseSelectable = true;
            this.mtbSave.Click += new System.EventHandler(this.mtbSave_Click);
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(139, 76);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(103, 22);
            this.tbAmount.TabIndex = 5;
            this.tbAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbAmount_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Amount";
            // 
            // tbShortDesc
            // 
            this.tbShortDesc.Location = new System.Drawing.Point(28, 76);
            this.tbShortDesc.Name = "tbShortDesc";
            this.tbShortDesc.Size = new System.Drawing.Size(85, 22);
            this.tbShortDesc.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Short Description";
            // 
            // tbParticularName
            // 
            this.tbParticularName.Location = new System.Drawing.Point(28, 26);
            this.tbParticularName.Name = "tbParticularName";
            this.tbParticularName.Size = new System.Drawing.Size(214, 22);
            this.tbParticularName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Particular Name";
            // 
            // frmParticulars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 401);
            this.Controls.Add(this.editPanel);
            this.Controls.Add(this.tbDelete);
            this.Controls.Add(this.tbEdit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.listView1);
            this.Name = "frmParticulars";
            this.Text = "Particular List";
            this.Load += new System.EventHandler(this.frmParticulars_Load);
            this.Controls.SetChildIndex(this.listView1, 0);
            this.Controls.SetChildIndex(this.tbSearch, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.tbEdit, 0);
            this.Controls.SetChildIndex(this.tbDelete, 0);
            this.Controls.SetChildIndex(this.editPanel, 0);
            this.editPanel.ResumeLayout(false);
            this.editPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button tbEdit;
        private System.Windows.Forms.Button tbDelete;
        private System.Windows.Forms.Panel editPanel;
        private MetroFramework.Controls.MetroButton mtbSave;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbShortDesc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbParticularName;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton mtbClose;
    }
}