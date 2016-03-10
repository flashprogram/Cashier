namespace Cashier
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.lollipopCard1 = new LollipopCard();
            this.lollipopSmallCard3 = new LollipopSmallCard();
            this.lollipopSmallCard2 = new LollipopSmallCard();
            this.lollipopSmallCard1 = new LollipopSmallCard();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Maroon;
            this.imageList1.Images.SetKeyName(0, "Check Book-48.png");
            this.imageList1.Images.SetKeyName(1, "Paste-96.png");
            this.imageList1.Images.SetKeyName(2, "Check-48.png");
            this.imageList1.Images.SetKeyName(3, "Pencil Tip-96.png");
            this.imageList1.Images.SetKeyName(4, "Add List-48.png");
            this.imageList1.Images.SetKeyName(5, "Eraser-96.png");
            this.imageList1.Images.SetKeyName(6, "Data Configuration-48.png");
            this.imageList1.Images.SetKeyName(7, "Bill-48.png");
            // 
            // listView1
            // 
            this.listView1.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.listView1.BackColor = System.Drawing.SystemColors.Control;
            this.listView1.GridLines = true;
            this.listView1.LabelWrap = false;
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Margin = new System.Windows.Forms.Padding(0);
            this.listView1.Name = "listView1";
            this.listView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listView1.Scrollable = false;
            this.listView1.ShowItemToolTips = true;
            this.listView1.Size = new System.Drawing.Size(401, 391);
            this.listView1.StateImageList = this.imageList1;
            this.listView1.TabIndex = 0;
            this.listView1.TileSize = new System.Drawing.Size(180, 100);
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Tile;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // lollipopCard1
            // 
            this.lollipopCard1.ButtonColor = "#33b679";
            this.lollipopCard1.ContentColor = "#444444";
            this.lollipopCard1.ContentText = "Hello User !";
            this.lollipopCard1.Image = ((System.Drawing.Image)(resources.GetObject("lollipopCard1.Image")));
            this.lollipopCard1.Location = new System.Drawing.Point(412, 12);
            this.lollipopCard1.Name = "lollipopCard1";
            this.lollipopCard1.Size = new System.Drawing.Size(294, 299);
            this.lollipopCard1.TabIndex = 4;
            this.lollipopCard1.Text = "Mr. X";
            this.lollipopCard1.TitleColor = "#33b679";
            // 
            // lollipopSmallCard3
            // 
            this.lollipopSmallCard3.FontColor = "#33b679";
            this.lollipopSmallCard3.Image = ((System.Drawing.Image)(resources.GetObject("lollipopSmallCard3.Image")));
            this.lollipopSmallCard3.Info = "Total Balance";
            this.lollipopSmallCard3.Location = new System.Drawing.Point(469, 331);
            this.lollipopSmallCard3.Name = "lollipopSmallCard3";
            this.lollipopSmallCard3.Size = new System.Drawing.Size(249, 52);
            this.lollipopSmallCard3.TabIndex = 3;
            this.lollipopSmallCard3.Text = "164, 212.00";
            this.lollipopSmallCard3.ThumbnailColor = "#123456";
            // 
            // lollipopSmallCard2
            // 
            this.lollipopSmallCard2.FontColor = "#33b679";
            this.lollipopSmallCard2.Image = ((System.Drawing.Image)(resources.GetObject("lollipopSmallCard2.Image")));
            this.lollipopSmallCard2.Info = "Total Payment";
            this.lollipopSmallCard2.Location = new System.Drawing.Point(234, 331);
            this.lollipopSmallCard2.Name = "lollipopSmallCard2";
            this.lollipopSmallCard2.Size = new System.Drawing.Size(239, 52);
            this.lollipopSmallCard2.TabIndex = 2;
            this.lollipopSmallCard2.Text = "67, 234.00";
            this.lollipopSmallCard2.ThumbnailColor = "#123456";
            // 
            // lollipopSmallCard1
            // 
            this.lollipopSmallCard1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lollipopSmallCard1.FontColor = "#33b679";
            this.lollipopSmallCard1.Image = ((System.Drawing.Image)(resources.GetObject("lollipopSmallCard1.Image")));
            this.lollipopSmallCard1.Info = "Total Students";
            this.lollipopSmallCard1.Location = new System.Drawing.Point(0, 331);
            this.lollipopSmallCard1.Name = "lollipopSmallCard1";
            this.lollipopSmallCard1.Size = new System.Drawing.Size(237, 52);
            this.lollipopSmallCard1.TabIndex = 1;
            this.lollipopSmallCard1.Text = "Sample Data (5623)";
            this.lollipopSmallCard1.ThumbnailColor = "#123456";
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 383);
            this.Controls.Add(this.lollipopCard1);
            this.Controls.Add(this.lollipopSmallCard3);
            this.Controls.Add(this.lollipopSmallCard2);
            this.Controls.Add(this.lollipopSmallCard1);
            this.Controls.Add(this.listView1);
            this.Name = "frmMainMenu";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView listView1;
        private LollipopSmallCard lollipopSmallCard1;
        private LollipopSmallCard lollipopSmallCard2;
        private LollipopSmallCard lollipopSmallCard3;
        private LollipopCard lollipopCard1;
    }
}