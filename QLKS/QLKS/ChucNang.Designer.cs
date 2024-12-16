namespace QLKS
{
    partial class frmChucNang
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
            BottomToolStripPanel = new ToolStripPanel();
            TopToolStripPanel = new ToolStripPanel();
            RightToolStripPanel = new ToolStripPanel();
            LeftToolStripPanel = new ToolStripPanel();
            ContentPanel = new ToolStripContentPanel();
            btnPhong = new Button();
            btnKhachHang = new Button();
            btnNhanVien = new Button();
            btnDoanhThu = new Button();
            btnDangXuat = new Button();
            SuspendLayout();
            // 
            // BottomToolStripPanel
            // 
            BottomToolStripPanel.Location = new Point(0, 0);
            BottomToolStripPanel.Name = "BottomToolStripPanel";
            BottomToolStripPanel.Orientation = Orientation.Horizontal;
            BottomToolStripPanel.RowMargin = new Padding(3, 0, 0, 0);
            BottomToolStripPanel.Size = new Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            TopToolStripPanel.Location = new Point(0, 0);
            TopToolStripPanel.Name = "TopToolStripPanel";
            TopToolStripPanel.Orientation = Orientation.Horizontal;
            TopToolStripPanel.RowMargin = new Padding(3, 0, 0, 0);
            TopToolStripPanel.Size = new Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            RightToolStripPanel.Location = new Point(0, 0);
            RightToolStripPanel.Name = "RightToolStripPanel";
            RightToolStripPanel.Orientation = Orientation.Horizontal;
            RightToolStripPanel.RowMargin = new Padding(3, 0, 0, 0);
            RightToolStripPanel.Size = new Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            LeftToolStripPanel.Location = new Point(0, 0);
            LeftToolStripPanel.Name = "LeftToolStripPanel";
            LeftToolStripPanel.Orientation = Orientation.Horizontal;
            LeftToolStripPanel.RowMargin = new Padding(3, 0, 0, 0);
            LeftToolStripPanel.Size = new Size(0, 0);
            // 
            // ContentPanel
            // 
            ContentPanel.Size = new Size(150, 150);
            // 
            // btnPhong
            // 
            btnPhong.Location = new Point(12, 12);
            btnPhong.Name = "btnPhong";
            btnPhong.Size = new Size(110, 23);
            btnPhong.TabIndex = 0;
            btnPhong.Text = "Phòng";
            btnPhong.UseVisualStyleBackColor = true;
            btnPhong.Click += btnPhong_Click;
            // 
            // btnKhachHang
            // 
            btnKhachHang.Location = new Point(12, 41);
            btnKhachHang.Name = "btnKhachHang";
            btnKhachHang.Size = new Size(110, 23);
            btnKhachHang.TabIndex = 1;
            btnKhachHang.Text = "Khách hàng";
            btnKhachHang.UseVisualStyleBackColor = true;
            btnKhachHang.Click += btnKhachHang_Click;
            // 
            // btnNhanVien
            // 
            btnNhanVien.Location = new Point(12, 99);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Size = new Size(110, 23);
            btnNhanVien.TabIndex = 3;
            btnNhanVien.Text = "Nhân viên";
            btnNhanVien.UseVisualStyleBackColor = true;
            btnNhanVien.Click += btnNhanVien_Click;
            // 
            // btnDoanhThu
            // 
            btnDoanhThu.Location = new Point(12, 70);
            btnDoanhThu.Name = "btnDoanhThu";
            btnDoanhThu.Size = new Size(110, 23);
            btnDoanhThu.TabIndex = 2;
            btnDoanhThu.Text = "Doanh thu";
            btnDoanhThu.UseVisualStyleBackColor = true;
            btnDoanhThu.Click += btnDoanhThu_Click;
            // 
            // btnDangXuat
            // 
            btnDangXuat.Location = new Point(12, 128);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(110, 23);
            btnDangXuat.TabIndex = 4;
            btnDangXuat.Text = "Đăng xuất";
            btnDangXuat.UseVisualStyleBackColor = true;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // frmChucNang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(134, 161);
            Controls.Add(btnDangXuat);
            Controls.Add(btnNhanVien);
            Controls.Add(btnDoanhThu);
            Controls.Add(btnKhachHang);
            Controls.Add(btnPhong);
            Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmChucNang";
            Text = "Chức năng";
            ResumeLayout(false);
        }

        #endregion

        private ToolStripPanel BottomToolStripPanel;
        private ToolStripPanel TopToolStripPanel;
        private ToolStripPanel RightToolStripPanel;
        private ToolStripPanel LeftToolStripPanel;
        private ToolStripContentPanel ContentPanel;
        private Button btnPhong;
        private Button btnKhachHang;
        private Button btnNhanVien;
        private Button btnDoanhThu;
        private Button btnDangXuat;
    }
}