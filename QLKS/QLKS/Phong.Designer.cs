namespace QLKS
{
    partial class frmPhong
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
            dgvPhong = new DataGridView();
            txtSoGiuong = new TextBox();
            cboHang = new ComboBox();
            txtGia = new TextBox();
            cboDatTruoc = new ComboBox();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnTroVe = new Button();
            txtMaPhong = new TextBox();
            btnThanhToan = new Button();
            cboHienThi = new ComboBox();
            cboTinhTrang = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvPhong).BeginInit();
            SuspendLayout();
            // 
            // dgvPhong
            // 
            dgvPhong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhong.Location = new Point(12, 12);
            dgvPhong.Name = "dgvPhong";
            dgvPhong.RowHeadersWidth = 51;
            dgvPhong.RowTemplate.Height = 25;
            dgvPhong.Size = new Size(335, 150);
            dgvPhong.TabIndex = 0;
            dgvPhong.RowHeaderMouseClick += dgvPhong_RowHeaderMouseClick;
            // 
            // txtSoGiuong
            // 
            txtSoGiuong.Location = new Point(12, 225);
            txtSoGiuong.Name = "txtSoGiuong";
            txtSoGiuong.PlaceholderText = "Số giường";
            txtSoGiuong.Size = new Size(121, 26);
            txtSoGiuong.TabIndex = 3;
            // 
            // cboHang
            // 
            cboHang.FormattingEnabled = true;
            cboHang.Items.AddRange(new object[] { "Phổ thông", "Thương gia" });
            cboHang.Location = new Point(12, 196);
            cboHang.Name = "cboHang";
            cboHang.Size = new Size(121, 27);
            cboHang.TabIndex = 2;
            // 
            // txtGia
            // 
            txtGia.Location = new Point(12, 253);
            txtGia.Name = "txtGia";
            txtGia.PlaceholderText = "Giá";
            txtGia.Size = new Size(121, 26);
            txtGia.TabIndex = 4;
            // 
            // cboDatTruoc
            // 
            cboDatTruoc.FormattingEnabled = true;
            cboDatTruoc.Items.AddRange(new object[] { "Chưa đặt trước", "Đã đặt trước" });
            cboDatTruoc.Location = new Point(12, 281);
            cboDatTruoc.Name = "cboDatTruoc";
            cboDatTruoc.Size = new Size(121, 27);
            cboDatTruoc.TabIndex = 5;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(12, 310);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 6;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(93, 310);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(174, 310);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 23);
            btnSua.TabIndex = 8;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnTroVe
            // 
            btnTroVe.Location = new Point(272, 310);
            btnTroVe.Name = "btnTroVe";
            btnTroVe.Size = new Size(75, 23);
            btnTroVe.TabIndex = 9;
            btnTroVe.Text = "Trở về";
            btnTroVe.UseVisualStyleBackColor = true;
            btnTroVe.Click += btnTroVe_Click;
            // 
            // txtMaPhong
            // 
            txtMaPhong.Location = new Point(12, 168);
            txtMaPhong.Name = "txtMaPhong";
            txtMaPhong.PlaceholderText = "Mã phòng";
            txtMaPhong.Size = new Size(121, 26);
            txtMaPhong.TabIndex = 1;
            // 
            // btnThanhToan
            // 
            btnThanhToan.Location = new Point(12, 339);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(121, 23);
            btnThanhToan.TabIndex = 10;
            btnThanhToan.Text = "Thanh toán";
            btnThanhToan.UseVisualStyleBackColor = true;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // cboHienThi
            // 
            cboHienThi.FormattingEnabled = true;
            cboHienThi.Items.AddRange(new object[] { "Tất cả", "Trống", "Không trống" });
            cboHienThi.Location = new Point(139, 340);
            cboHienThi.Name = "cboHienThi";
            cboHienThi.Size = new Size(208, 27);
            cboHienThi.TabIndex = 11;
            cboHienThi.SelectedIndexChanged += cboHienThi_SelectedIndexChanged;
            // 
            // cboTinhTrang
            // 
            cboTinhTrang.FormattingEnabled = true;
            cboTinhTrang.Items.AddRange(new object[] { "Trống", "Không trống" });
            cboTinhTrang.Location = new Point(139, 168);
            cboTinhTrang.Name = "cboTinhTrang";
            cboTinhTrang.Size = new Size(121, 27);
            cboTinhTrang.TabIndex = 12;
            // 
            // frmPhong
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 386);
            Controls.Add(cboTinhTrang);
            Controls.Add(cboHienThi);
            Controls.Add(btnThanhToan);
            Controls.Add(btnTroVe);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(cboDatTruoc);
            Controls.Add(txtGia);
            Controls.Add(cboHang);
            Controls.Add(txtSoGiuong);
            Controls.Add(txtMaPhong);
            Controls.Add(dgvPhong);
            Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmPhong";
            Text = "Phòng";
            Load += frmPhong_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPhong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPhong;
        private TextBox txtSoGiuong;
        private ComboBox cboHang;
        private TextBox txtGia;
        private ComboBox cboDatTruoc;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
        private Button btnTroVe;
        private TextBox txtMaPhong;
        private Button btnThanhToan;
        private ComboBox cboHienThi;
        private ComboBox cboTinhTrang;
    }
}