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
            clsBtn = new Label();
            panel3 = new Panel();
            label3 = new Label();
            pictureBox4 = new PictureBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
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
            lblDangNhap.Font = new Font("Bauhaus 93", 24F, FontStyle.Bold, GraphicsUnit.Point);
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
            btnDangNhap.Font = new Font("Bahnschrift", 14F, FontStyle.Bold, GraphicsUnit.Point);
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
            lblSai.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
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
            btnHien.BackgroundImageLayout = ImageLayout.Zoom;
            btnHien.Location = new Point(719, 261);
            btnHien.Name = "btnHien";
            btnHien.Size = new Size(75, 25);
            btnHien.TabIndex = 5;
            btnHien.Text = "Hiện";
            btnHien.UseVisualStyleBackColor = true;
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
            // clsBtn
            // 
            clsBtn.AutoSize = true;
            clsBtn.BackColor = Color.White;
            clsBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            clsBtn.ForeColor = Color.FromArgb(255, 204, 234);
            clsBtn.Location = new Point(773, 9);
            clsBtn.Name = "clsBtn";
            clsBtn.Size = new Size(27, 25);
            clsBtn.TabIndex = 9;
            clsBtn.Text = "X";
            clsBtn.Click += label1_Click;
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
            label3.Font = new Font("Bauhaus 93", 15F, FontStyle.Bold, GraphicsUnit.Point);
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
            label2.Font = new Font("Bauhaus 93", 24F, FontStyle.Bold, GraphicsUnit.Point);
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
            // frmDangNhap
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(812, 439);
            Controls.Add(panel3);
            Controls.Add(clsBtn);
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
            Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
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
        private Label clsBtn;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Label label2;
        private PictureBox pictureBox4;
        private Label label3;
    }
}
