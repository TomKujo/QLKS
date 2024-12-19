namespace QLKS
{
    partial class frmDangNhap
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblDangNhap = new Label();
            txtTK = new TextBox();
            txtMK = new TextBox();
            btnDangNhap = new Button();
            lblSai = new Label();
            btnHien = new Button();
            logoPicture = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            label3 = new Label();
            pictureBox4 = new PictureBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            clsBtn = new Button();
            mnzBtn = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)logoPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblDangNhap
            // 
            lblDangNhap.AutoSize = true;
            lblDangNhap.Font = new Font("Bauhaus 93", 24F, FontStyle.Bold);
            lblDangNhap.ForeColor = Color.FromArgb(255, 204, 234);
            lblDangNhap.Location = new Point(557, 135);
            lblDangNhap.Name = "lblDangNhap";
            lblDangNhap.Size = new Size(141, 45);
            lblDangNhap.TabIndex = 0;
            lblDangNhap.Text = "LOG IN";
            // 
            // txtTK
            // 
            txtTK.BorderStyle = BorderStyle.None;
            txtTK.Location = new Point(515, 205);
            txtTK.Multiline = true;
            txtTK.Name = "txtTK";
            txtTK.PlaceholderText = "Tài khoản";
            txtTK.Size = new Size(198, 26);
            txtTK.TabIndex = 1;
            txtTK.KeyPress += txtTK_KeyPress;
            // 
            // txtMK
            // 
            txtMK.BorderStyle = BorderStyle.None;
            txtMK.Location = new Point(515, 260);
            txtMK.Name = "txtMK";
            txtMK.PlaceholderText = "Mật khẩu";
            txtMK.Size = new Size(198, 19);
            txtMK.TabIndex = 2;
            txtMK.UseSystemPasswordChar = true;
            txtMK.TextChanged += txtMK_TextChanged;
            txtMK.KeyPress += txtMK_KeyPress;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.FromArgb(255, 204, 234);
            btnDangNhap.FlatAppearance.BorderSize = 0;
            btnDangNhap.FlatStyle = FlatStyle.Flat;
            btnDangNhap.Font = new Font("Bahnschrift", 14F, FontStyle.Bold);
            btnDangNhap.ForeColor = Color.White;
            btnDangNhap.Location = new Point(476, 315);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(315, 51);
            btnDangNhap.TabIndex = 3;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // lblSai
            // 
            lblSai.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            lblSai.ForeColor = Color.Red;
            lblSai.Location = new Point(477, 381);
            lblSai.Name = "lblSai";
            lblSai.Size = new Size(317, 19);
            lblSai.TabIndex = 4;
            lblSai.Text = "Sai aaaaaaaaaaaaaaaaaa";
            lblSai.TextAlign = ContentAlignment.TopCenter;
            lblSai.Visible = false;
            // 
            // btnHien
            // 
            btnHien.BackColor = Color.Transparent;
            btnHien.BackgroundImage = Properties.Resources.visible;
            btnHien.BackgroundImageLayout = ImageLayout.Zoom;
            btnHien.Cursor = Cursors.Hand;
            btnHien.FlatAppearance.BorderSize = 0;
            btnHien.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnHien.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnHien.FlatStyle = FlatStyle.Flat;
            btnHien.Location = new Point(739, 263);
            btnHien.Name = "btnHien";
            btnHien.Size = new Size(30, 30);
            btnHien.TabIndex = 5;
            btnHien.UseVisualStyleBackColor = false;
            btnHien.Visible = false;
            btnHien.Click += btnHien_Click;
            // 
            // logoPicture
            // 
            logoPicture.Image = Properties.Resources.Stamp0125;
            logoPicture.Location = new Point(557, 12);
            logoPicture.Name = "logoPicture";
            logoPicture.Size = new Size(130, 102);
            logoPicture.SizeMode = PictureBoxSizeMode.Zoom;
            logoPicture.TabIndex = 6;
            logoPicture.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._6676110;
            pictureBox2.Location = new Point(476, 206);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 192);
            panel1.Location = new Point(477, 237);
            panel1.Name = "panel1";
            panel1.Size = new Size(236, 1);
            panel1.TabIndex = 8;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources._5901842;
            pictureBox3.Location = new Point(476, 261);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(25, 25);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 192, 192);
            panel2.Location = new Point(477, 292);
            panel2.Name = "panel2";
            panel2.Size = new Size(236, 1);
            panel2.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 204, 234);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(pictureBox4);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(pictureBox1);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(445, 439);
            panel3.TabIndex = 10;
            panel3.Paint += panel3_Paint;
            // 
            // label3
            // 
            label3.Font = new Font("Bauhaus 93", 15F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(33, 180);
            label3.Name = "label3";
            label3.Size = new Size(382, 66);
            label3.TabIndex = 13;
            label3.Text = "The best hotel in the multiverse";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.a_city_with_buildings_and_icons_png;
            pictureBox4.Location = new Point(0, 249);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(442, 190);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bauhaus 93", 24F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(60, 135);
            label2.Name = "label2";
            label2.Size = new Size(319, 45);
            label2.TabIndex = 11;
            label2.Text = "Hanazono Hotel";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._14924536;
            pictureBox1.Location = new Point(120, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // clsBtn
            // 
            clsBtn.BackColor = Color.Transparent;
            clsBtn.BackgroundImage = Properties.Resources.u42cu2eumyc71_1_;
            clsBtn.BackgroundImageLayout = ImageLayout.Zoom;
            clsBtn.Cursor = Cursors.Hand;
            clsBtn.FlatAppearance.BorderSize = 0;
            clsBtn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            clsBtn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            clsBtn.FlatStyle = FlatStyle.Flat;
            clsBtn.Location = new Point(775, 12);
            clsBtn.Name = "clsBtn";
            clsBtn.Size = new Size(25, 25);
            clsBtn.TabIndex = 12;
            clsBtn.UseVisualStyleBackColor = false;
            clsBtn.Click += clsBtn_Click;
            clsBtn.MouseLeave += clsBtn_MouseLeave;
            clsBtn.MouseHover += clsBtn_MouseHover;
            // 
            // mnzBtn
            // 
            mnzBtn.BackColor = Color.Transparent;
            mnzBtn.BackgroundImage = Properties.Resources.u42cu2eumyc71_3_;
            mnzBtn.BackgroundImageLayout = ImageLayout.Zoom;
            mnzBtn.Cursor = Cursors.Hand;
            mnzBtn.FlatAppearance.BorderSize = 0;
            mnzBtn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            mnzBtn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            mnzBtn.FlatStyle = FlatStyle.Flat;
            mnzBtn.Location = new Point(744, 12);
            mnzBtn.Name = "mnzBtn";
            mnzBtn.Size = new Size(25, 25);
            mnzBtn.TabIndex = 13;
            mnzBtn.UseVisualStyleBackColor = false;
            mnzBtn.Click += mnzBtn_Click;
            mnzBtn.MouseLeave += mnzBtn_MouseLeave;
            mnzBtn.MouseHover += mnzBtn_MouseHover;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 9F);
            label1.Location = new Point(477, 412);
            label1.Name = "label1";
            label1.Size = new Size(297, 18);
            label1.TabIndex = 14;
            label1.Text = "@Copyright © 2024 All Right Reserved, TLH\r\n";
            // 
            // frmDangNhap
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(812, 439);
            Controls.Add(label1);
            Controls.Add(mnzBtn);
            Controls.Add(clsBtn);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(logoPicture);
            Controls.Add(btnHien);
            Controls.Add(lblSai);
            Controls.Add(btnDangNhap);
            Controls.Add(txtMK);
            Controls.Add(txtTK);
            Controls.Add(lblDangNhap);
            Font = new Font("Times New Roman", 9.75F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            Load += frmDangNhap_Load;
            ((System.ComponentModel.ISupportInitialize)logoPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDangNhap;
        private TextBox txtTK;
        private TextBox txtMK;
        private Button btnDangNhap;
        private Label lblSai;
        private Button btnHien;
        private PictureBox logoPicture;
        private PictureBox pictureBox2;
        private Panel panel1;
        private PictureBox pictureBox3;
        private Panel panel2;
        private Button clsBtn;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Label label2;
        private PictureBox pictureBox4;
        private Label label3;
        private Label minimizeBtn;
        private Button mnzBtn;
        private Label label1;
    }
}
