namespace Project_Gym
{
    partial class dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
            this.dropdown_menu_1 = new System.Windows.Forms.MenuStrip();
            this.mEMBERSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.new_member = new System.Windows.Forms.ToolStripMenuItem();
            this.rEMOVEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sTAFFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eQUITMENTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dropdown_menu_2 = new System.Windows.Forms.MenuStrip();
            this.lOGOUTToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nEWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dropdown_menu_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.dropdown_menu_2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dropdown_menu_1
            // 
            this.dropdown_menu_1.BackColor = System.Drawing.Color.Transparent;
            this.dropdown_menu_1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dropdown_menu_1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropdown_menu_1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mEMBERSToolStripMenuItem,
            this.sTAFFToolStripMenuItem,
            this.eQUITMENTToolStripMenuItem});
            this.dropdown_menu_1.Location = new System.Drawing.Point(0, 528);
            this.dropdown_menu_1.Name = "dropdown_menu_1";
            this.dropdown_menu_1.Size = new System.Drawing.Size(1192, 103);
            this.dropdown_menu_1.TabIndex = 0;
            this.dropdown_menu_1.Text = "menuStrip1";
            // 
            // mEMBERSToolStripMenuItem
            // 
            this.mEMBERSToolStripMenuItem.CheckOnClick = true;
            this.mEMBERSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.new_member,
            this.rEMOVEToolStripMenuItem});
            this.mEMBERSToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mEMBERSToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mEMBERSToolStripMenuItem.Image")));
            this.mEMBERSToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mEMBERSToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.mEMBERSToolStripMenuItem.Name = "mEMBERSToolStripMenuItem";
            this.mEMBERSToolStripMenuItem.Size = new System.Drawing.Size(188, 99);
            this.mEMBERSToolStripMenuItem.Text = "MEMBERS";
            this.mEMBERSToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // new_member
            // 
            this.new_member.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_member.Image = ((System.Drawing.Image)(resources.GetObject("new_member.Image")));
            this.new_member.Name = "new_member";
            this.new_member.Size = new System.Drawing.Size(180, 34);
            this.new_member.Text = "New";
            this.new_member.Click += new System.EventHandler(this.new_member_Click);
            // 
            // rEMOVEToolStripMenuItem
            // 
            this.rEMOVEToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.rEMOVEToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("rEMOVEToolStripMenuItem.Image")));
            this.rEMOVEToolStripMenuItem.Name = "rEMOVEToolStripMenuItem";
            this.rEMOVEToolStripMenuItem.Size = new System.Drawing.Size(180, 34);
            this.rEMOVEToolStripMenuItem.Text = "Delete";
            this.rEMOVEToolStripMenuItem.Click += new System.EventHandler(this.rEMOVEToolStripMenuItem_Click);
            // 
            // sTAFFToolStripMenuItem
            // 
            this.sTAFFToolStripMenuItem.CheckOnClick = true;
            this.sTAFFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem1});
            this.sTAFFToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sTAFFToolStripMenuItem.Image")));
            this.sTAFFToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.sTAFFToolStripMenuItem.Name = "sTAFFToolStripMenuItem";
            this.sTAFFToolStripMenuItem.Size = new System.Drawing.Size(124, 99);
            this.sTAFFToolStripMenuItem.Text = "STAFF";
            this.sTAFFToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // newToolStripMenuItem1
            // 
            this.newToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.newToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem1.Image")));
            this.newToolStripMenuItem1.Name = "newToolStripMenuItem1";
            this.newToolStripMenuItem1.Size = new System.Drawing.Size(180, 34);
            this.newToolStripMenuItem1.Text = "NEW";
            this.newToolStripMenuItem1.Click += new System.EventHandler(this.newToolStripMenuItem1_Click);
            // 
            // eQUITMENTToolStripMenuItem
            // 
            this.eQUITMENTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem1,
            this.nEWToolStripMenuItem});
            this.eQUITMENTToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("eQUITMENTToolStripMenuItem.Image")));
            this.eQUITMENTToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.eQUITMENTToolStripMenuItem.Name = "eQUITMENTToolStripMenuItem";
            this.eQUITMENTToolStripMenuItem.Size = new System.Drawing.Size(236, 99);
            this.eQUITMENTToolStripMenuItem.Text = "EQUIPMENTS";
            this.eQUITMENTToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.eQUITMENTToolStripMenuItem.Click += new System.EventHandler(this.eQUITMENTToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(329, -65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(560, 512);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // dropdown_menu_2
            // 
            this.dropdown_menu_2.BackColor = System.Drawing.Color.Transparent;
            this.dropdown_menu_2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lOGOUTToolStripMenuItem1});
            this.dropdown_menu_2.Location = new System.Drawing.Point(0, 0);
            this.dropdown_menu_2.Name = "dropdown_menu_2";
            this.dropdown_menu_2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dropdown_menu_2.Size = new System.Drawing.Size(1192, 103);
            this.dropdown_menu_2.TabIndex = 2;
            this.dropdown_menu_2.Text = "menuStrip1";
            // 
            // lOGOUTToolStripMenuItem1
            // 
            this.lOGOUTToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lOGOUTToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("lOGOUTToolStripMenuItem1.Image")));
            this.lOGOUTToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.lOGOUTToolStripMenuItem1.Name = "lOGOUTToolStripMenuItem1";
            this.lOGOUTToolStripMenuItem1.Size = new System.Drawing.Size(160, 99);
            this.lOGOUTToolStripMenuItem1.Text = "LOGOUT";
            this.lOGOUTToolStripMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.lOGOUTToolStripMenuItem1.Click += new System.EventHandler(this.lOGOUTToolStripMenuItem1_Click);
            // 
            // nEWToolStripMenuItem
            // 
            this.nEWToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.nEWToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nEWToolStripMenuItem.Image")));
            this.nEWToolStripMenuItem.Name = "nEWToolStripMenuItem";
            this.nEWToolStripMenuItem.Size = new System.Drawing.Size(180, 34);
            this.nEWToolStripMenuItem.Text = "New";
            this.nEWToolStripMenuItem.Click += new System.EventHandler(this.nEWToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem1
            // 
            this.searchToolStripMenuItem1.BackColor = System.Drawing.SystemColors.Control;
            this.searchToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.searchToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("searchToolStripMenuItem1.Image")));
            this.searchToolStripMenuItem1.Name = "searchToolStripMenuItem1";
            this.searchToolStripMenuItem1.Size = new System.Drawing.Size(180, 34);
            this.searchToolStripMenuItem1.Text = "Search";
            this.searchToolStripMenuItem1.Click += new System.EventHandler(this.searchToolStripMenuItem1_Click);
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1192, 631);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dropdown_menu_1);
            this.Controls.Add(this.dropdown_menu_2);
            this.KeyPreview = true;
            this.MainMenuStrip = this.dropdown_menu_1;
            this.Name = "dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GYM FITNESS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.dropdown_menu_1.ResumeLayout(false);
            this.dropdown_menu_1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.dropdown_menu_2.ResumeLayout(false);
            this.dropdown_menu_2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip dropdown_menu_1;
        private System.Windows.Forms.ToolStripMenuItem mEMBERSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sTAFFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eQUITMENTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem new_member;
        private System.Windows.Forms.ToolStripMenuItem rEMOVEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip dropdown_menu_2;
        private System.Windows.Forms.ToolStripMenuItem lOGOUTToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nEWToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem1;
    }
}

