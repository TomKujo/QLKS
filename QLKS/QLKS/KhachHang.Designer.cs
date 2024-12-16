namespace QLKS
{
    partial class frmKH
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
            dgvKH = new DataGridView();
            txtMaKH = new TextBox();
            txtTenKH = new TextBox();
            txtSDT = new TextBox();
            txtQuocTich = new TextBox();
            cboGioiTinh = new ComboBox();
            dateTimePickerNgaySinh = new DateTimePicker();
            lblNgaySinh = new Label();
            txtCCCD = new TextBox();
            txtDiaChi = new TextBox();
            dateTimePickerNhan = new DateTimePicker();
            lblNhan = new Label();
            dateTimePickerTra = new DateTimePicker();
            lblTra = new Label();
            cboMaPhong = new ComboBox();
            btnTroVe = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvKH).BeginInit();
            SuspendLayout();
            // 
            // dgvKH
            // 
            dgvKH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKH.Location = new Point(12, 12);
            dgvKH.Name = "dgvKH";
            dgvKH.RowHeadersWidth = 51;
            dgvKH.RowTemplate.Height = 25;
            dgvKH.Size = new Size(335, 150);
            dgvKH.TabIndex = 0;
            dgvKH.RowHeaderMouseClick += dgvKH_RowHeaderMouseClick;
            // 
            // txtMaKH
            // 
            txtMaKH.Location = new Point(144, 168);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.PlaceholderText = "Mã khách hàng";
            txtMaKH.Size = new Size(203, 26);
            txtMaKH.TabIndex = 1;
            // 
            // txtTenKH
            // 
            txtTenKH.Location = new Point(144, 196);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.PlaceholderText = "Tên khách hàng";
            txtTenKH.Size = new Size(203, 26);
            txtTenKH.TabIndex = 2;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(144, 224);
            txtSDT.Name = "txtSDT";
            txtSDT.PlaceholderText = "Số điện thoại";
            txtSDT.Size = new Size(203, 26);
            txtSDT.TabIndex = 3;
            // 
            // txtQuocTich
            // 
            txtQuocTich.Location = new Point(144, 252);
            txtQuocTich.Name = "txtQuocTich";
            txtQuocTich.PlaceholderText = "Quốc tịch";
            txtQuocTich.Size = new Size(203, 26);
            txtQuocTich.TabIndex = 4;
            // 
            // cboGioiTinh
            // 
            cboGioiTinh.FormattingEnabled = true;
            cboGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            cboGioiTinh.Location = new Point(144, 280);
            cboGioiTinh.Name = "cboGioiTinh";
            cboGioiTinh.Size = new Size(203, 27);
            cboGioiTinh.TabIndex = 5;
            // 
            // dateTimePickerNgaySinh
            // 
            dateTimePickerNgaySinh.CustomFormat = "yyyy-MM-dd";
            dateTimePickerNgaySinh.Format = DateTimePickerFormat.Custom;
            dateTimePickerNgaySinh.Location = new Point(144, 309);
            dateTimePickerNgaySinh.Name = "dateTimePickerNgaySinh";
            dateTimePickerNgaySinh.Size = new Size(203, 26);
            dateTimePickerNgaySinh.TabIndex = 7;
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Location = new Point(12, 315);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(76, 19);
            lblNgaySinh.TabIndex = 6;
            lblNgaySinh.Text = "Ngày sinh";
            // 
            // txtCCCD
            // 
            txtCCCD.Location = new Point(144, 337);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.PlaceholderText = "Căn cước công dân";
            txtCCCD.Size = new Size(203, 26);
            txtCCCD.TabIndex = 8;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(144, 365);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.PlaceholderText = "Địa chỉ";
            txtDiaChi.Size = new Size(203, 26);
            txtDiaChi.TabIndex = 9;
            // 
            // dateTimePickerNhan
            // 
            dateTimePickerNhan.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            dateTimePickerNhan.Format = DateTimePickerFormat.Custom;
            dateTimePickerNhan.Location = new Point(144, 393);
            dateTimePickerNhan.Name = "dateTimePickerNhan";
            dateTimePickerNhan.Size = new Size(203, 26);
            dateTimePickerNhan.TabIndex = 11;
            // 
            // lblNhan
            // 
            lblNhan.AutoSize = true;
            lblNhan.Location = new Point(12, 399);
            lblNhan.Name = "lblNhan";
            lblNhan.Size = new Size(152, 19);
            lblNhan.TabIndex = 10;
            lblNhan.Text = "Thời gian nhận phòng";
            // 
            // dateTimePickerTra
            // 
            dateTimePickerTra.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            dateTimePickerTra.Format = DateTimePickerFormat.Custom;
            dateTimePickerTra.Location = new Point(144, 421);
            dateTimePickerTra.Name = "dateTimePickerTra";
            dateTimePickerTra.Size = new Size(203, 26);
            dateTimePickerTra.TabIndex = 13;
            // 
            // lblTra
            // 
            lblTra.AutoSize = true;
            lblTra.Location = new Point(12, 427);
            lblTra.Name = "lblTra";
            lblTra.Size = new Size(139, 19);
            lblTra.TabIndex = 12;
            lblTra.Text = "Thời gian trả phòng";
            // 
            // cboMaPhong
            // 
            cboMaPhong.FormattingEnabled = true;
            cboMaPhong.Items.AddRange(new object[] { "Nam", "Nữ" });
            cboMaPhong.Location = new Point(144, 449);
            cboMaPhong.Name = "cboMaPhong";
            cboMaPhong.Size = new Size(203, 27);
            cboMaPhong.TabIndex = 14;
            // 
            // btnTroVe
            // 
            btnTroVe.Location = new Point(272, 478);
            btnTroVe.Name = "btnTroVe";
            btnTroVe.Size = new Size(75, 23);
            btnTroVe.TabIndex = 18;
            btnTroVe.Text = "Trở về";
            btnTroVe.UseVisualStyleBackColor = true;
            btnTroVe.Click += btnTroVe_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(174, 478);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 23);
            btnSua.TabIndex = 17;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(93, 478);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 16;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(12, 478);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 15;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // frmKH
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 511);
            Controls.Add(btnTroVe);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(cboMaPhong);
            Controls.Add(lblTra);
            Controls.Add(dateTimePickerTra);
            Controls.Add(lblNhan);
            Controls.Add(dateTimePickerNhan);
            Controls.Add(txtDiaChi);
            Controls.Add(txtCCCD);
            Controls.Add(lblNgaySinh);
            Controls.Add(dateTimePickerNgaySinh);
            Controls.Add(cboGioiTinh);
            Controls.Add(txtQuocTich);
            Controls.Add(txtSDT);
            Controls.Add(txtTenKH);
            Controls.Add(txtMaKH);
            Controls.Add(dgvKH);
            Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmKH";
            Text = "Khách hàng";
            Load += frmKH_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKH).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvKH;
        private TextBox txtMaKH;
        private TextBox txtTenKH;
        private TextBox txtSDT;
        private TextBox txtQuocTich;
        private ComboBox cboGioiTinh;
        private DateTimePicker dateTimePickerNgaySinh;
        private Label lblNgaySinh;
        private TextBox txtCCCD;
        private TextBox txtDiaChi;
        private DateTimePicker dateTimePickerNhan;
        private Label lblNhan;
        private DateTimePicker dateTimePickerTra;
        private Label lblTra;
        private ComboBox cboMaPhong;
        private Button btnTroVe;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
    }
}