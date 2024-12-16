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
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            btnPhong = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            btnKhachHang = new Button();
            btnDanhThu = new Button();
            btnNhanVien = new Button();
            btnDangXuat = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
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
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(247, 119);
            panel2.TabIndex = 13;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = Properties.Resources._14924536;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(247, 82);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Bottom;
            label2.Font = new Font("Bauhaus 93", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(0, 85);
            label2.Name = "label2";
            label2.Size = new Size(245, 34);
            label2.TabIndex = 12;
            label2.Text = "Hanazono Hotel";
            // 
            // btnPhong
            // 
            btnPhong.BackColor = Color.FromArgb(255, 204, 234);
            btnPhong.BackgroundImageLayout = ImageLayout.Zoom;
            btnPhong.Dock = DockStyle.Top;
            btnPhong.FlatAppearance.BorderSize = 0;
            btnPhong.FlatStyle = FlatStyle.Flat;
            btnPhong.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnPhong.ForeColor = Color.Black;
            btnPhong.Image = Properties.Resources._3498555_200;
            btnPhong.ImageAlign = ContentAlignment.MiddleLeft;
            btnPhong.Location = new Point(0, 0);
            btnPhong.Margin = new Padding(0);
            btnPhong.Name = "btnPhong";
            btnPhong.Padding = new Padding(30, 5, 0, 0);
            btnPhong.Size = new Size(250, 46);
            btnPhong.TabIndex = 0;
            btnPhong.Text = "        Phòng";
            btnPhong.TextAlign = ContentAlignment.MiddleLeft;
            btnPhong.UseVisualStyleBackColor = false;
            btnPhong.Click += btnPhong_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(255, 204, 234);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(btnKhachHang);
            flowLayoutPanel1.Controls.Add(btnDanhThu);
            flowLayoutPanel1.Controls.Add(btnNhanVien);
            flowLayoutPanel1.Controls.Add(btnDangXuat);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(250, 392);
            flowLayoutPanel1.TabIndex = 14;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 204, 234);
            panel1.Controls.Add(btnPhong);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 125);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 52);
            panel1.TabIndex = 15;
            // 
            // btnKhachHang
            // 
            btnKhachHang.AllowDrop = true;
            btnKhachHang.BackColor = Color.FromArgb(255, 204, 234);
            btnKhachHang.BackgroundImageLayout = ImageLayout.Zoom;
            btnKhachHang.Dock = DockStyle.Top;
            btnKhachHang.FlatAppearance.BorderSize = 0;
            btnKhachHang.FlatStyle = FlatStyle.Flat;
            btnKhachHang.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnKhachHang.ForeColor = Color.Black;
            btnKhachHang.Image = Properties.Resources.users_icon;
            btnKhachHang.ImageAlign = ContentAlignment.MiddleLeft;
            btnKhachHang.Location = new Point(0, 177);
            btnKhachHang.Margin = new Padding(0);
            btnKhachHang.Name = "btnKhachHang";
            btnKhachHang.Padding = new Padding(30, 0, 0, 0);
            btnKhachHang.Size = new Size(250, 46);
            btnKhachHang.TabIndex = 16;
            btnKhachHang.Text = "        Khách hàng";
            btnKhachHang.TextAlign = ContentAlignment.MiddleLeft;
            btnKhachHang.UseVisualStyleBackColor = false;
            btnKhachHang.Click += btnKhachHang_Click;
            // 
            // btnDanhThu
            // 
            btnDanhThu.BackColor = Color.FromArgb(255, 204, 234);
            btnDanhThu.BackgroundImageLayout = ImageLayout.Zoom;
            btnDanhThu.Dock = DockStyle.Top;
            btnDanhThu.FlatAppearance.BorderSize = 0;
            btnDanhThu.FlatStyle = FlatStyle.Flat;
            btnDanhThu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDanhThu.ForeColor = Color.Black;
            btnDanhThu.Image = Properties.Resources._218409;
            btnDanhThu.ImageAlign = ContentAlignment.MiddleLeft;
            btnDanhThu.Location = new Point(0, 223);
            btnDanhThu.Margin = new Padding(0);
            btnDanhThu.Name = "btnDanhThu";
            btnDanhThu.Padding = new Padding(30, 0, 0, 0);
            btnDanhThu.Size = new Size(250, 46);
            btnDanhThu.TabIndex = 17;
            btnDanhThu.Text = "        Doanh thu";
            btnDanhThu.TextAlign = ContentAlignment.MiddleLeft;
            btnDanhThu.UseVisualStyleBackColor = false;
            btnDanhThu.Click += btnDoanhThu_Click;
            // 
            // btnNhanVien
            // 
            btnNhanVien.BackColor = Color.FromArgb(255, 204, 234);
            btnNhanVien.BackgroundImageLayout = ImageLayout.Zoom;
            btnNhanVien.Dock = DockStyle.Top;
            btnNhanVien.FlatAppearance.BorderSize = 0;
            btnNhanVien.FlatStyle = FlatStyle.Flat;
            btnNhanVien.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNhanVien.ForeColor = Color.Black;
            btnNhanVien.Image = Properties.Resources._1534915;
            btnNhanVien.ImageAlign = ContentAlignment.MiddleLeft;
            btnNhanVien.Location = new Point(0, 269);
            btnNhanVien.Margin = new Padding(0);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Padding = new Padding(30, 0, 0, 0);
            btnNhanVien.Size = new Size(250, 46);
            btnNhanVien.TabIndex = 18;
            btnNhanVien.Text = "        Nhân viên";
            btnNhanVien.TextAlign = ContentAlignment.MiddleLeft;
            btnNhanVien.UseVisualStyleBackColor = false;
            btnNhanVien.Click += btnNhanVien_Click;
            // 
            // btnDangXuat
            // 
            btnDangXuat.BackColor = Color.FromArgb(255, 204, 234);
            btnDangXuat.BackgroundImageLayout = ImageLayout.Zoom;
            btnDangXuat.Dock = DockStyle.Top;
            btnDangXuat.FlatAppearance.BorderSize = 0;
            btnDangXuat.FlatStyle = FlatStyle.Flat;
            btnDangXuat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDangXuat.ForeColor = Color.Black;
            btnDangXuat.Image = Properties.Resources._7242587;
            btnDangXuat.ImageAlign = ContentAlignment.MiddleLeft;
            btnDangXuat.Location = new Point(0, 315);
            btnDangXuat.Margin = new Padding(0);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Padding = new Padding(30, 0, 0, 0);
            btnDangXuat.Size = new Size(250, 46);
            btnDangXuat.TabIndex = 19;
            btnDangXuat.Text = "        Đăng xuất";
            btnDangXuat.TextAlign = ContentAlignment.MiddleLeft;
            btnDangXuat.UseVisualStyleBackColor = false;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // frmChucNang
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(794, 392);
            Controls.Add(flowLayoutPanel1);
            Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmChucNang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chức năng";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ToolStripPanel BottomToolStripPanel;
        private ToolStripPanel TopToolStripPanel;
        private ToolStripPanel RightToolStripPanel;
        private ToolStripPanel LeftToolStripPanel;
        private ToolStripContentPanel ContentPanel;
        private Button btnKhachHang;
        private Button btnDanhThu;
        private Button btnNhanVien;
        private Button btnDangXuat;
        private PictureBox pictureBox1;
        private Label label2;
        private Panel panel2;
        private Button btnPhong;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;        
    }
}