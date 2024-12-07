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
            SuspendLayout();
            // 
            // lblDangNhap
            // 
            lblDangNhap.AutoSize = true;
            lblDangNhap.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblDangNhap.ForeColor = Color.Red;
            lblDangNhap.Location = new Point(12, 9);
            lblDangNhap.Name = "lblDangNhap";
            lblDangNhap.Size = new Size(142, 31);
            lblDangNhap.TabIndex = 0;
            lblDangNhap.Text = "Đăng nhập";
            // 
            // txtTK
            // 
            txtTK.Location = new Point(12, 43);
            txtTK.Name = "txtTK";
            txtTK.PlaceholderText = "Tài khoản";
            txtTK.Size = new Size(160, 22);
            txtTK.TabIndex = 1;
            // 
            // txtMK
            // 
            txtMK.Location = new Point(12, 71);
            txtMK.Name = "txtMK";
            txtMK.PlaceholderText = "Mật khẩu";
            txtMK.Size = new Size(160, 22);
            txtMK.TabIndex = 2;
            txtMK.UseSystemPasswordChar = true;
            // 
            // btnDangNhap
            // 
            btnDangNhap.Location = new Point(12, 111);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(160, 23);
            btnDangNhap.TabIndex = 3;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // lblSai
            // 
            lblSai.AutoSize = true;
            lblSai.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblSai.ForeColor = Color.Red;
            lblSai.Location = new Point(12, 137);
            lblSai.Name = "lblSai";
            lblSai.Size = new Size(25, 15);
            lblSai.TabIndex = 4;
            lblSai.Text = "Sai";
            lblSai.Visible = false;
            // 
            // frmDangNhap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(184, 161);
            Controls.Add(lblSai);
            Controls.Add(btnDangNhap);
            Controls.Add(txtMK);
            Controls.Add(txtTK);
            Controls.Add(lblDangNhap);
            Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmDangNhap";
            Text = "Đăng nhập";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDangNhap;
        private TextBox txtTK;
        private TextBox txtMK;
        private Button btnDangNhap;
        private Label lblSai;
    }
}
