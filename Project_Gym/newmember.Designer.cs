namespace Project_Gym
{
    partial class newmember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(newmember));
            this.txt_fname = new System.Windows.Forms.TextBox();
            this.btn_male = new System.Windows.Forms.RadioButton();
            this.btn_female = new System.Windows.Forms.RadioButton();
            this.birth_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.join_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.txt_num = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.m_comboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_height = new System.Windows.Forms.TextBox();
            this.txt_weight = new System.Windows.Forms.TextBox();
            this.txt_lname = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.close_stip_2 = new System.Windows.Forms.MenuStrip();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_address = new System.Windows.Forms.RichTextBox();
            this.txt_nic = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.close_stip_2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_fname
            // 
            this.txt_fname.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_fname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_fname.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.txt_fname.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_fname.Location = new System.Drawing.Point(160, 94);
            this.txt_fname.Name = "txt_fname";
            this.txt_fname.Size = new System.Drawing.Size(281, 33);
            this.txt_fname.TabIndex = 0;
            // 
            // btn_male
            // 
            this.btn_male.AutoSize = true;
            this.btn_male.BackColor = System.Drawing.Color.Transparent;
            this.btn_male.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_male.ForeColor = System.Drawing.Color.White;
            this.btn_male.Location = new System.Drawing.Point(168, 282);
            this.btn_male.Name = "btn_male";
            this.btn_male.Size = new System.Drawing.Size(73, 29);
            this.btn_male.TabIndex = 2;
            this.btn_male.TabStop = true;
            this.btn_male.Text = "Male";
            this.btn_male.UseVisualStyleBackColor = false;
            // 
            // btn_female
            // 
            this.btn_female.AutoSize = true;
            this.btn_female.BackColor = System.Drawing.Color.Transparent;
            this.btn_female.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_female.ForeColor = System.Drawing.Color.White;
            this.btn_female.Location = new System.Drawing.Point(260, 282);
            this.btn_female.Name = "btn_female";
            this.btn_female.Size = new System.Drawing.Size(92, 29);
            this.btn_female.TabIndex = 3;
            this.btn_female.TabStop = true;
            this.btn_female.Text = "Female";
            this.btn_female.UseVisualStyleBackColor = false;
            this.btn_female.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // birth_dateTimePicker
            // 
            this.birth_dateTimePicker.CalendarMonthBackground = System.Drawing.SystemColors.ActiveCaption;
            this.birth_dateTimePicker.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.birth_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birth_dateTimePicker.Location = new System.Drawing.Point(160, 217);
            this.birth_dateTimePicker.Name = "birth_dateTimePicker";
            this.birth_dateTimePicker.Size = new System.Drawing.Size(281, 33);
            this.birth_dateTimePicker.TabIndex = 4;
            this.birth_dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // join_dateTimePicker
            // 
            this.join_dateTimePicker.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.join_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.join_dateTimePicker.Location = new System.Drawing.Point(762, 161);
            this.join_dateTimePicker.Name = "join_dateTimePicker";
            this.join_dateTimePicker.Size = new System.Drawing.Size(223, 33);
            this.join_dateTimePicker.TabIndex = 5;
            this.join_dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // txt_num
            // 
            this.txt_num.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_num.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.txt_num.Location = new System.Drawing.Point(762, 214);
            this.txt_num.Name = "txt_num";
            this.txt_num.Size = new System.Drawing.Size(223, 33);
            this.txt_num.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(24, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "First Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(24, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Dath of Birth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(24, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(24, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Height";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(558, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Last Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(558, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Join Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(558, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "Mobile Number";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(558, 281);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 25);
            this.label9.TabIndex = 18;
            this.label9.Text = "Membership";
            // 
            // m_comboBox
            // 
            this.m_comboBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.m_comboBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.m_comboBox.FormattingEnabled = true;
            this.m_comboBox.Items.AddRange(new object[] {
            "Platinum\t - 12 Months",
            "Gold \t -  6 Months",
            "Silver\t -  3 Months",
            "Bronze\t -  1 Months"});
            this.m_comboBox.Location = new System.Drawing.Point(762, 281);
            this.m_comboBox.Name = "m_comboBox";
            this.m_comboBox.Size = new System.Drawing.Size(223, 33);
            this.m_comboBox.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(558, 352);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 25);
            this.label10.TabIndex = 20;
            this.label10.Text = "Address";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(291, 410);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(402, 253);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(24, 382);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 25);
            this.label11.TabIndex = 22;
            this.label11.Text = "Weight";
            // 
            // txt_email
            // 
            this.txt_email.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_email.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.txt_email.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_email.Location = new System.Drawing.Point(160, 159);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(281, 33);
            this.txt_email.TabIndex = 23;
            // 
            // txt_height
            // 
            this.txt_height.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_height.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_height.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.txt_height.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_height.Location = new System.Drawing.Point(160, 328);
            this.txt_height.Name = "txt_height";
            this.txt_height.Size = new System.Drawing.Size(100, 33);
            this.txt_height.TabIndex = 24;
            // 
            // txt_weight
            // 
            this.txt_weight.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_weight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_weight.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.txt_weight.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_weight.Location = new System.Drawing.Point(160, 382);
            this.txt_weight.Name = "txt_weight";
            this.txt_weight.Size = new System.Drawing.Size(100, 33);
            this.txt_weight.TabIndex = 25;
            // 
            // txt_lname
            // 
            this.txt_lname.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_lname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_lname.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.txt_lname.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_lname.Location = new System.Drawing.Point(762, 88);
            this.txt_lname.Name = "txt_lname";
            this.txt_lname.Size = new System.Drawing.Size(223, 33);
            this.txt_lname.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(889, 620);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 43);
            this.button1.TabIndex = 28;
            this.button1.Text = "SUBMIT";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Transparent;
            this.btn_cancel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_cancel.Image = ((System.Drawing.Image)(resources.GetObject("btn_cancel.Image")));
            this.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancel.Location = new System.Drawing.Point(12, 618);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(119, 43);
            this.btn_cancel.TabIndex = 29;
            this.btn_cancel.Text = "CLEAR";
            this.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // close_stip_2
            // 
            this.close_stip_2.BackColor = System.Drawing.Color.Transparent;
            this.close_stip_2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.close_stip_2.Location = new System.Drawing.Point(0, 0);
            this.close_stip_2.Name = "close_stip_2";
            this.close_stip_2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.close_stip_2.Size = new System.Drawing.Size(1020, 56);
            this.close_stip_2.TabIndex = 30;
            this.close_stip_2.Text = "close_strip_2";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.closeToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.closeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("closeToolStripMenuItem.Image")));
            this.closeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(60, 52);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // txt_address
            // 
            this.txt_address.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_address.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.txt_address.Location = new System.Drawing.Point(762, 352);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(223, 138);
            this.txt_address.TabIndex = 31;
            this.txt_address.Text = "";
            // 
            // txt_nic
            // 
            this.txt_nic.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_nic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nic.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.txt_nic.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_nic.Location = new System.Drawing.Point(160, 438);
            this.txt_nic.Name = "txt_nic";
            this.txt_nic.Size = new System.Drawing.Size(148, 33);
            this.txt_nic.TabIndex = 32;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(24, 446);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 25);
            this.label12.TabIndex = 33;
            this.label12.Text = "NIC No";
            // 
            // newmember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1020, 673);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_nic);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_lname);
            this.Controls.Add(this.txt_weight);
            this.Controls.Add(this.txt_height);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.m_comboBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_num);
            this.Controls.Add(this.join_dateTimePicker);
            this.Controls.Add(this.birth_dateTimePicker);
            this.Controls.Add(this.btn_female);
            this.Controls.Add(this.btn_male);
            this.Controls.Add(this.txt_fname);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.close_stip_2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.close_stip_2;
            this.MaximumSize = new System.Drawing.Size(1020, 673);
            this.MinimumSize = new System.Drawing.Size(1020, 673);
            this.Name = "newmember";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Member";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.close_stip_2.ResumeLayout(false);
            this.close_stip_2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton btn_male;
        private System.Windows.Forms.RadioButton btn_female;
        private System.Windows.Forms.DateTimePicker birth_dateTimePicker;
        private System.Windows.Forms.DateTimePicker join_dateTimePicker;
        private System.Windows.Forms.TextBox txt_num;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox m_comboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_fname;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_height;
        private System.Windows.Forms.TextBox txt_weight;
        private System.Windows.Forms.TextBox txt_lname;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.MenuStrip close_stip_2;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.RichTextBox txt_address;
        private System.Windows.Forms.TextBox txt_nic;
        private System.Windows.Forms.Label label12;
    }
}