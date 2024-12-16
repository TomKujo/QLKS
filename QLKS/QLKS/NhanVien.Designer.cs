namespace QLKS
{
    partial class frmNV
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
            txtSDT = new TextBox();
            txtTenNV = new TextBox();
            txtMaNV = new TextBox();
            dgvNV = new DataGridView();
            cboGioiTinh = new ComboBox();
            txtMK = new TextBox();
            txtTK = new TextBox();
            btnTroVe = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            txtXacNhan = new TextBox();
            btnHien2 = new Button();
            btnHien1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvNV).BeginInit();
            SuspendLayout();
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(144, 224);
            txtSDT.Name = "txtSDT";
            txtSDT.PlaceholderText = "Số điện thoại";
            txtSDT.Size = new Size(203, 26);
            txtSDT.TabIndex = 7;
            // 
            // txtTenNV
            // 
            txtTenNV.Location = new Point(144, 196);
            txtTenNV.Name = "txtTenNV";
            txtTenNV.PlaceholderText = "Tên nhân viên";
            txtTenNV.Size = new Size(203, 26);
            txtTenNV.TabIndex = 6;
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(144, 168);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.PlaceholderText = "Mã nhân viên";
            txtMaNV.Size = new Size(203, 26);
            txtMaNV.TabIndex = 5;
            // 
            // dgvNV
            // 
            dgvNV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNV.Location = new Point(12, 12);
            dgvNV.Name = "dgvNV";
            dgvNV.RowHeadersWidth = 51;
            dgvNV.RowTemplate.Height = 25;
            dgvNV.Size = new Size(335, 150);
            dgvNV.TabIndex = 4;
            dgvNV.RowHeaderMouseClick += dgvNV_RowHeaderMouseClick;
            // 
            // cboGioiTinh
            // 
            cboGioiTinh.FormattingEnabled = true;
            cboGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            cboGioiTinh.Location = new Point(144, 252);
            cboGioiTinh.Name = "cboGioiTinh";
            cboGioiTinh.Size = new Size(203, 27);
            cboGioiTinh.TabIndex = 8;
            // 
            // txtMK
            // 
            txtMK.Location = new Point(144, 309);
            txtMK.Name = "txtMK";
            txtMK.PlaceholderText = "Mật khẩu";
            txtMK.Size = new Size(203, 26);
            txtMK.TabIndex = 10;
            txtMK.UseSystemPasswordChar = true;
            txtMK.TextChanged += txtMK_TextChanged;
            // 
            // txtTK
            // 
            txtTK.Location = new Point(144, 281);
            txtTK.Name = "txtTK";
            txtTK.PlaceholderText = "Tài khoản";
            txtTK.Size = new Size(203, 26);
            txtTK.TabIndex = 9;
            // 
            // btnTroVe
            // 
            btnTroVe.Location = new Point(272, 337);
            btnTroVe.Name = "btnTroVe";
            btnTroVe.Size = new Size(75, 23);
            btnTroVe.TabIndex = 22;
            btnTroVe.Text = "Trở về";
            btnTroVe.UseVisualStyleBackColor = true;
            btnTroVe.Click += btnTroVe_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(174, 337);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 23);
            btnSua.TabIndex = 21;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(93, 337);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 20;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(12, 337);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 19;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtXacNhan
            // 
            txtXacNhan.Location = new Point(12, 309);
            txtXacNhan.Name = "txtXacNhan";
            txtXacNhan.PlaceholderText = "Xác nhận mật khẩu";
            txtXacNhan.Size = new Size(126, 26);
            txtXacNhan.TabIndex = 23;
            txtXacNhan.UseSystemPasswordChar = true;
            txtXacNhan.TextChanged += txtXacNhan_TextChanged;
            // 
            // btnHien2
            // 
            btnHien2.Location = new Point(12, 280);
            btnHien2.Name = "btnHien2";
            btnHien2.Size = new Size(75, 23);
            btnHien2.TabIndex = 24;
            btnHien2.Text = "Hiện";
            btnHien2.UseVisualStyleBackColor = true;
            btnHien2.Visible = false;
            btnHien2.Click += btnHien2_Click;
            // 
            // btnHien1
            // 
            btnHien1.Location = new Point(12, 251);
            btnHien1.Name = "btnHien1";
            btnHien1.Size = new Size(75, 23);
            btnHien1.TabIndex = 25;
            btnHien1.Text = "Hiện";
            btnHien1.UseVisualStyleBackColor = true;
            btnHien1.Visible = false;
            btnHien1.Click += btnHien1_Click;
            // 
            // frmNV
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 386);
            Controls.Add(btnHien1);
            Controls.Add(btnHien2);
            Controls.Add(txtXacNhan);
            Controls.Add(btnTroVe);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(txtMK);
            Controls.Add(txtTK);
            Controls.Add(cboGioiTinh);
            Controls.Add(txtSDT);
            Controls.Add(txtTenNV);
            Controls.Add(txtMaNV);
            Controls.Add(dgvNV);
            Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmNV";
            Text = "Nhân viên";
            Load += frmNV_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSDT;
        private TextBox txtTenNV;
        private TextBox txtMaNV;
        private DataGridView dgvNV;
        private ComboBox cboGioiTinh;
        private TextBox txtMK;
        private TextBox txtTK;
        private Button btnTroVe;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private TextBox txtXacNhan;
        private Button btnHien2;
        private Button btnHien1;
    }
}