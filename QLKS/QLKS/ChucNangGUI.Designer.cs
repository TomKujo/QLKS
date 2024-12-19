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
            components = new System.ComponentModel.Container();
            BottomToolStripPanel = new ToolStripPanel();
            TopToolStripPanel = new ToolStripPanel();
            RightToolStripPanel = new ToolStripPanel();
            LeftToolStripPanel = new ToolStripPanel();
            ContentPanel = new ToolStripContentPanel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnDashBoard = new Button();
            btnPhong = new Button();
            btnKhachHang = new Button();
            btnNhanVien = new Button();
            btnDangXuat = new Button();
            mnzBtn = new Button();
            clsBtn = new Button();
            panel1 = new Panel();
            dateTimeLB = new Label();
            panel3 = new Panel();
            tenNVLB = new Label();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            khachHangPage1 = new KhachHangPage();
            phongPage1 = new PhongPage();
            nhanVienPage1 = new NhanVienPage();
            dashboardPage1 = new DashboardPage();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
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
            panel2.Size = new Size(247, 138);
            panel2.TabIndex = 13;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = Properties.Resources._14924536;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(247, 101);
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
            label2.Location = new Point(0, 104);
            label2.Name = "label2";
            label2.Size = new Size(245, 34);
            label2.TabIndex = 12;
            label2.Text = "Hanazono Hotel";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(255, 204, 234);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(btnDashBoard);
            flowLayoutPanel1.Controls.Add(btnPhong);
            flowLayoutPanel1.Controls.Add(btnKhachHang);
            flowLayoutPanel1.Controls.Add(btnNhanVien);
            flowLayoutPanel1.Controls.Add(btnDangXuat);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(250, 439);
            flowLayoutPanel1.TabIndex = 14;
            // 
            // btnDashBoard
            // 
            btnDashBoard.BackColor = Color.FromArgb(255, 204, 234);
            btnDashBoard.BackgroundImageLayout = ImageLayout.Zoom;
            btnDashBoard.Cursor = Cursors.Hand;
            btnDashBoard.Dock = DockStyle.Top;
            btnDashBoard.FlatAppearance.BorderSize = 0;
            btnDashBoard.FlatStyle = FlatStyle.Flat;
            btnDashBoard.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDashBoard.ForeColor = Color.Black;
            btnDashBoard.Image = Properties.Resources.dashboard_80;
            btnDashBoard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashBoard.Location = new Point(0, 144);
            btnDashBoard.Margin = new Padding(0);
            btnDashBoard.Name = "btnDashBoard";
            btnDashBoard.Padding = new Padding(30, 5, 0, 0);
            btnDashBoard.Size = new Size(250, 46);
            btnDashBoard.TabIndex = 20;
            btnDashBoard.Text = "        Dashboard";
            btnDashBoard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashBoard.UseVisualStyleBackColor = false;
            btnDashBoard.Click += btnDashBoard_Click;
            // 
            // btnPhong
            // 
            btnPhong.BackColor = Color.FromArgb(255, 204, 234);
            btnPhong.BackgroundImageLayout = ImageLayout.Zoom;
            btnPhong.Cursor = Cursors.Hand;
            btnPhong.Dock = DockStyle.Top;
            btnPhong.FlatAppearance.BorderSize = 0;
            btnPhong.FlatStyle = FlatStyle.Flat;
            btnPhong.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnPhong.ForeColor = Color.Black;
            btnPhong.Image = Properties.Resources._3498555_200;
            btnPhong.ImageAlign = ContentAlignment.MiddleLeft;
            btnPhong.Location = new Point(0, 190);
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
            // btnKhachHang
            // 
            btnKhachHang.AllowDrop = true;
            btnKhachHang.BackColor = Color.FromArgb(255, 204, 234);
            btnKhachHang.BackgroundImageLayout = ImageLayout.Zoom;
            btnKhachHang.Cursor = Cursors.Hand;
            btnKhachHang.Dock = DockStyle.Top;
            btnKhachHang.FlatAppearance.BorderSize = 0;
            btnKhachHang.FlatStyle = FlatStyle.Flat;
            btnKhachHang.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnKhachHang.ForeColor = Color.Black;
            btnKhachHang.Image = Properties.Resources.users_icon;
            btnKhachHang.ImageAlign = ContentAlignment.MiddleLeft;
            btnKhachHang.Location = new Point(0, 236);
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
            // btnNhanVien
            // 
            btnNhanVien.BackColor = Color.FromArgb(255, 204, 234);
            btnNhanVien.BackgroundImageLayout = ImageLayout.Zoom;
            btnNhanVien.Cursor = Cursors.Hand;
            btnNhanVien.Dock = DockStyle.Top;
            btnNhanVien.FlatAppearance.BorderSize = 0;
            btnNhanVien.FlatStyle = FlatStyle.Flat;
            btnNhanVien.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNhanVien.ForeColor = Color.Black;
            btnNhanVien.Image = Properties.Resources._1534915;
            btnNhanVien.ImageAlign = ContentAlignment.MiddleLeft;
            btnNhanVien.Location = new Point(0, 282);
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
            btnDangXuat.Cursor = Cursors.Hand;
            btnDangXuat.Dock = DockStyle.Top;
            btnDangXuat.FlatAppearance.BorderSize = 0;
            btnDangXuat.FlatStyle = FlatStyle.Flat;
            btnDangXuat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDangXuat.ForeColor = Color.Black;
            btnDangXuat.Image = Properties.Resources._7242587;
            btnDangXuat.ImageAlign = ContentAlignment.MiddleLeft;
            btnDangXuat.Location = new Point(0, 328);
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
            mnzBtn.Location = new Point(546, 12);
            mnzBtn.Name = "mnzBtn";
            mnzBtn.Size = new Size(25, 25);
            mnzBtn.TabIndex = 16;
            mnzBtn.UseVisualStyleBackColor = false;
            mnzBtn.Click += mnzBtn_Click;
            mnzBtn.MouseLeave += mnzBtn_MouseLeave;
            mnzBtn.MouseHover += mnzBtn_MouseHover;
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
            clsBtn.Location = new Point(577, 12);
            clsBtn.Name = "clsBtn";
            clsBtn.Size = new Size(25, 25);
            clsBtn.TabIndex = 15;
            clsBtn.UseVisualStyleBackColor = false;
            clsBtn.Click += clsBtn_Click;
            clsBtn.MouseLeave += clsBtn_MouseLeave;
            clsBtn.MouseHover += clsBtn_MouseHover;
            // 
            // panel1
            // 
            panel1.Controls.Add(dateTimeLB);
            panel1.Controls.Add(mnzBtn);
            panel1.Controls.Add(clsBtn);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(250, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(614, 53);
            panel1.TabIndex = 0;
            // 
            // dateTimeLB
            // 
            dateTimeLB.AutoSize = true;
            dateTimeLB.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimeLB.ForeColor = Color.FromArgb(255, 204, 234);
            dateTimeLB.Location = new Point(6, 27);
            dateTimeLB.Name = "dateTimeLB";
            dateTimeLB.Size = new Size(21, 23);
            dateTimeLB.TabIndex = 0;
            dateTimeLB.Text = "?";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 204, 234);
            panel3.Controls.Add(tenNVLB);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(250, 53);
            panel3.Name = "panel3";
            panel3.Size = new Size(614, 64);
            panel3.TabIndex = 15;
            // 
            // tenNVLB
            // 
            tenNVLB.AutoSize = true;
            tenNVLB.Font = new Font("Bauhaus 93", 16F, FontStyle.Bold, GraphicsUnit.Point);
            tenNVLB.ForeColor = Color.White;
            tenNVLB.Location = new Point(6, 21);
            tenNVLB.Name = "tenNVLB";
            tenNVLB.Size = new Size(143, 30);
            tenNVLB.TabIndex = 17;
            tenNVLB.Text = "Xin chào, ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(407, 412);
            label1.Name = "label1";
            label1.Size = new Size(297, 18);
            label1.TabIndex = 15;
            label1.Text = "@Copyright © 2024 All Right Reserved, TLH\r\n";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // khachHangPage1
            // 
            khachHangPage1.BackColor = Color.White;
            khachHangPage1.Location = new Point(183, 74);
            khachHangPage1.Name = "khachHangPage1";
            khachHangPage1.Size = new Size(677, 365);
            khachHangPage1.TabIndex = 0;
            khachHangPage1.Load += khachHangPage1_Load;
            // 
            // phongPage1
            // 
            phongPage1.BackColor = Color.White;
            phongPage1.Location = new Point(183, 90);
            phongPage1.Name = "phongPage1";
            phongPage1.Size = new Size(681, 349);
            phongPage1.TabIndex = 16;
            // 
            // nhanVienPage1
            // 
            nhanVienPage1.BackColor = Color.White;
            nhanVienPage1.Location = new Point(183, 90);
            nhanVienPage1.Name = "nhanVienPage1";
            nhanVienPage1.Size = new Size(681, 349);
            nhanVienPage1.TabIndex = 21;
            // 
            // dashboardPage1
            // 
            dashboardPage1.Location = new Point(123, 90);
            dashboardPage1.Name = "dashboardPage1";
            dashboardPage1.Size = new Size(797, 320);
            dashboardPage1.TabIndex = 22;
            // 
            // frmChucNang
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(864, 439);
            Controls.Add(label1);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(dashboardPage1);
            Controls.Add(nhanVienPage1);
            Controls.Add(phongPage1);
            Controls.Add(khachHangPage1);
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
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStripPanel BottomToolStripPanel;
        private ToolStripPanel TopToolStripPanel;
        private ToolStripPanel RightToolStripPanel;
        private ToolStripPanel LeftToolStripPanel;
        private ToolStripContentPanel ContentPanel;
        private Button btnKhachHang;
        private Button btnNhanVien;
        private Button btnDangXuat;
        private PictureBox pictureBox1;
        private Label label2;
        private Panel panel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnDashBoard;
        private Button btnPhong;
        private Button mnzBtn;
        private Button clsBtn;
        private Panel panel1;
        private Panel panel3;
        private Label dateTimeLB;
        private Label label1;
        private Label tenNVLB;
        private System.Windows.Forms.Timer timer1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private KhachHangPage khachHangPage1;
        private PhongPage phongPage1;
        private NhanVienPage nhanVienPage1;
        private DashboardPage dashboardPage1;
    }
}