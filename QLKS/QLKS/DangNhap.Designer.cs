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
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)logoPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // lblDangNhap
            // 
            lblDangNhap.AutoSize = true;
            lblDangNhap.Font = new Font("Bauhaus 93", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblDangNhap.ForeColor = Color.LightPink;
            lblDangNhap.Location = new Point(92, 135);
            lblDangNhap.Name = "lblDangNhap";
            lblDangNhap.Size = new Size(141, 45);
            lblDangNhap.TabIndex = 0;
            lblDangNhap.Text = "LOG IN";
            // 
            // txtTK
            // 
            txtTK.BorderStyle = BorderStyle.None;
            txtTK.Location = new Point(50, 205);
            txtTK.Multiline = true;
            txtTK.Name = "txtTK";
            txtTK.PlaceholderText = "Tài khoản";
            txtTK.Size = new Size(198, 26);
            txtTK.TabIndex = 1;
            // 
            // txtMK
            // 
            txtMK.BorderStyle = BorderStyle.None;
            txtMK.Location = new Point(50, 260);
            txtMK.Name = "txtMK";
            txtMK.PlaceholderText = "Mật khẩu";
            txtMK.Size = new Size(198, 19);
            txtMK.TabIndex = 2;
            txtMK.UseSystemPasswordChar = true;
            txtMK.TextChanged += txtMK_TextChanged;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.FromArgb(255, 192, 192);
            btnDangNhap.FlatAppearance.BorderSize = 0;
            btnDangNhap.FlatStyle = FlatStyle.Flat;
            btnDangNhap.Font = new Font("Bahnschrift", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnDangNhap.ForeColor = Color.White;
            btnDangNhap.Location = new Point(11, 315);
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
            lblSai.Location = new Point(12, 381);
            lblSai.Name = "lblSai";
            lblSai.Size = new Size(317, 19);
            lblSai.TabIndex = 4;
            lblSai.Text = "Sai aaaaaaaaaaaaaaaaaa";
            lblSai.TextAlign = ContentAlignment.TopCenter;
            lblSai.Visible = false;
            // 
            // btnHien
            // 
            btnHien.Location = new Point(254, 261);
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
            logoPicture.Location = new Point(92, 12);
            logoPicture.Name = "logoPicture";
            logoPicture.Size = new Size(130, 102);
            logoPicture.SizeMode = PictureBoxSizeMode.Zoom;
            logoPicture.TabIndex = 6;
            logoPicture.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._6676110;
            pictureBox2.Location = new Point(11, 206);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 192);
            panel1.Location = new Point(12, 237);
            panel1.Name = "panel1";
            panel1.Size = new Size(236, 1);
            panel1.TabIndex = 8;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources._5901842;
            pictureBox3.Location = new Point(11, 261);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(25, 25);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 192, 192);
            panel2.Location = new Point(12, 292);
            panel2.Name = "panel2";
            panel2.Size = new Size(236, 1);
            panel2.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.LightPink;
            label1.Location = new Point(141, 410);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 9;
            label1.Text = "Thoát";
            label1.Click += label1_Click;
            // 
            // frmDangNhap
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(338, 439);
            Controls.Add(label1);
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
            Text = "Đăng nhập";
            Load += frmDangNhap_Load;
            ((System.ComponentModel.ISupportInitialize)logoPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
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
        private Label label1;
    }
}
