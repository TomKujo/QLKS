namespace QLKS
{
    partial class PhongPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControlPhong = new TabControl();
            timPhongPage = new TabControl();
            datPhongTab = new TabPage();
            radioButton6 = new RadioButton();
            radioButton5 = new RadioButton();
            maPhongCB = new TextBox();
            maPhongLB = new Label();
            loaiPhongCB = new ComboBox();
            loaiPhongLB = new Label();
            button1 = new Button();
            Email = new TextBox();
            label5 = new Label();
            SDT = new TextBox();
            label4 = new Label();
            label1 = new Label();
            timPhongTab = new TabPage();
            timKiemMaPhong = new TextBox();
            label15 = new Label();
            timKiemTinhTrangCB = new ComboBox();
            timKiemLPCB = new ComboBox();
            label9 = new Label();
            phongView = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            label8 = new Label();
            label6 = new Label();
            timLPTab = new TabPage();
            loaiPhongView = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            label28 = new Label();
            themPhongTab = new TabPage();
            button3 = new Button();
            themMoTaLP = new TextBox();
            label26 = new Label();
            themGiaTienLP = new TextBox();
            label25 = new Label();
            themTenLP = new TextBox();
            label24 = new Label();
            label11 = new Label();
            button2 = new Button();
            themPhongLPCB = new ComboBox();
            label10 = new Label();
            label20 = new Label();
            capNhatTab = new TabPage();
            xoaPB = new RadioButton();
            capNhatPB = new RadioButton();
            capNhatMaPhongTB = new TextBox();
            label17 = new Label();
            CapNhatPhongButton = new Button();
            label16 = new Label();
            tabPage1 = new TabPage();
            CapNhatLoaiPhongButton = new Button();
            xoaLPB = new RadioButton();
            capNhatMoTaLPTB = new TextBox();
            capNhatLPB = new RadioButton();
            label27 = new Label();
            capNhatMoTaLPLB = new Label();
            capNhatTenLPLB = new Label();
            capNhatGiaTienLPTB = new TextBox();
            capNhatTenLPTB = new TextBox();
            capNhatGiaTienLPLB = new Label();
            timPhongPage.SuspendLayout();
            datPhongTab.SuspendLayout();
            timPhongTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)phongView).BeginInit();
            timLPTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)loaiPhongView).BeginInit();
            themPhongTab.SuspendLayout();
            capNhatTab.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlPhong
            // 
            tabControlPhong.Alignment = TabAlignment.Bottom;
            tabControlPhong.Anchor = AnchorStyles.None;
            tabControlPhong.Location = new Point(87, 51);
            tabControlPhong.Name = "tabControlPhong";
            tabControlPhong.SelectedIndex = 0;
            tabControlPhong.Size = new Size(514, 247);
            tabControlPhong.TabIndex = 0;
            // 
            // timPhongPage
            // 
            timPhongPage.Alignment = TabAlignment.Bottom;
            timPhongPage.Anchor = AnchorStyles.None;
            timPhongPage.Controls.Add(datPhongTab);
            timPhongPage.Controls.Add(timPhongTab);
            timPhongPage.Controls.Add(timLPTab);
            timPhongPage.Controls.Add(themPhongTab);
            timPhongPage.Controls.Add(capNhatTab);
            timPhongPage.Controls.Add(tabPage1);
            timPhongPage.Location = new Point(70, 36);
            timPhongPage.Name = "timPhongPage";
            timPhongPage.SelectedIndex = 0;
            timPhongPage.Size = new Size(544, 292);
            timPhongPage.TabIndex = 2;
            // 
            // datPhongTab
            // 
            datPhongTab.BackColor = Color.White;
            datPhongTab.Controls.Add(radioButton6);
            datPhongTab.Controls.Add(radioButton5);
            datPhongTab.Controls.Add(maPhongCB);
            datPhongTab.Controls.Add(maPhongLB);
            datPhongTab.Controls.Add(loaiPhongCB);
            datPhongTab.Controls.Add(loaiPhongLB);
            datPhongTab.Controls.Add(button1);
            datPhongTab.Controls.Add(Email);
            datPhongTab.Controls.Add(label5);
            datPhongTab.Controls.Add(SDT);
            datPhongTab.Controls.Add(label4);
            datPhongTab.Controls.Add(label1);
            datPhongTab.Location = new Point(4, 4);
            datPhongTab.Name = "datPhongTab";
            datPhongTab.Padding = new Padding(3);
            datPhongTab.Size = new Size(536, 259);
            datPhongTab.TabIndex = 0;
            datPhongTab.Text = "Đặt phòng";
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton6.Location = new Point(207, 160);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(187, 23);
            radioButton6.TabIndex = 27;
            radioButton6.Text = "Đặt theo mã phòng";
            radioButton6.UseVisualStyleBackColor = true;
            radioButton6.CheckedChanged += radioButton6_CheckedChanged;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Checked = true;
            radioButton5.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton5.Location = new Point(13, 160);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(188, 23);
            radioButton5.TabIndex = 26;
            radioButton5.TabStop = true;
            radioButton5.Text = "Đặt theo loại phòng";
            radioButton5.UseVisualStyleBackColor = true;
            radioButton5.CheckedChanged += radioButton5_CheckedChanged;
            // 
            // maPhongCB
            // 
            maPhongCB.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            maPhongCB.Location = new Point(189, 113);
            maPhongCB.Name = "maPhongCB";
            maPhongCB.Size = new Size(161, 27);
            maPhongCB.TabIndex = 25;
            maPhongCB.Visible = false;
            // 
            // maPhongLB
            // 
            maPhongLB.AutoSize = true;
            maPhongLB.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            maPhongLB.Location = new Point(192, 94);
            maPhongLB.Name = "maPhongLB";
            maPhongLB.Size = new Size(98, 19);
            maPhongLB.TabIndex = 24;
            maPhongLB.Text = "Mã phòng:";
            maPhongLB.Visible = false;
            // 
            // loaiPhongCB
            // 
            loaiPhongCB.FormattingEnabled = true;
            loaiPhongCB.Location = new Point(9, 112);
            loaiPhongCB.Name = "loaiPhongCB";
            loaiPhongCB.Size = new Size(143, 28);
            loaiPhongCB.TabIndex = 22;
            // 
            // loaiPhongLB
            // 
            loaiPhongLB.AutoSize = true;
            loaiPhongLB.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            loaiPhongLB.Location = new Point(13, 88);
            loaiPhongLB.Name = "loaiPhongLB";
            loaiPhongLB.Size = new Size(102, 19);
            loaiPhongLB.TabIndex = 21;
            loaiPhongLB.Text = "Loại Phòng:";
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(369, 189);
            button1.Name = "button1";
            button1.Size = new Size(162, 57);
            button1.TabIndex = 18;
            button1.Text = "Đặt Phòng";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Email
            // 
            Email.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Email.Location = new Point(189, 52);
            Email.Name = "Email";
            Email.Size = new Size(161, 27);
            Email.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(192, 30);
            label5.Name = "label5";
            label5.Size = new Size(58, 19);
            label5.TabIndex = 16;
            label5.Text = "Email:";
            // 
            // SDT
            // 
            SDT.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            SDT.Location = new Point(8, 52);
            SDT.Name = "SDT";
            SDT.Size = new Size(146, 27);
            SDT.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(11, 33);
            label4.Name = "label4";
            label4.Size = new Size(115, 19);
            label4.TabIndex = 6;
            label4.Text = "Số điện thoại:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(255, 128, 255);
            label1.Location = new Point(9, 9);
            label1.Name = "label1";
            label1.Size = new Size(98, 19);
            label1.TabIndex = 0;
            label1.Text = "Đặt phòng:";
            // 
            // timPhongTab
            // 
            timPhongTab.Controls.Add(timKiemMaPhong);
            timPhongTab.Controls.Add(label15);
            timPhongTab.Controls.Add(timKiemTinhTrangCB);
            timPhongTab.Controls.Add(timKiemLPCB);
            timPhongTab.Controls.Add(label9);
            timPhongTab.Controls.Add(phongView);
            timPhongTab.Controls.Add(label8);
            timPhongTab.Controls.Add(label6);
            timPhongTab.Location = new Point(4, 4);
            timPhongTab.Name = "timPhongTab";
            timPhongTab.Padding = new Padding(3);
            timPhongTab.Size = new Size(536, 259);
            timPhongTab.TabIndex = 1;
            timPhongTab.Text = "Tìm phòng";
            timPhongTab.UseVisualStyleBackColor = true;
            // 
            // timKiemMaPhong
            // 
            timKiemMaPhong.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            timKiemMaPhong.Location = new Point(379, 64);
            timKiemMaPhong.Name = "timKiemMaPhong";
            timKiemMaPhong.Size = new Size(148, 27);
            timKiemMaPhong.TabIndex = 27;
            timKiemMaPhong.TextChanged += timKiemMaPhong_TextChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(379, 42);
            label15.Name = "label15";
            label15.Size = new Size(98, 19);
            label15.TabIndex = 26;
            label15.Text = "Mã phòng:";
            // 
            // timKiemTinhTrangCB
            // 
            timKiemTinhTrangCB.FormattingEnabled = true;
            timKiemTinhTrangCB.Location = new Point(205, 64);
            timKiemTinhTrangCB.Name = "timKiemTinhTrangCB";
            timKiemTinhTrangCB.Size = new Size(127, 28);
            timKiemTinhTrangCB.TabIndex = 9;
            timKiemTinhTrangCB.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // timKiemLPCB
            // 
            timKiemLPCB.FormattingEnabled = true;
            timKiemLPCB.Location = new Point(13, 64);
            timKiemLPCB.Name = "timKiemLPCB";
            timKiemLPCB.Size = new Size(127, 28);
            timKiemLPCB.TabIndex = 3;
            timKiemLPCB.SelectedIndexChanged += timKiemLPCB_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(205, 42);
            label9.Name = "label9";
            label9.Size = new Size(89, 19);
            label9.TabIndex = 8;
            label9.Text = "Tình trạng:";
            // 
            // phongView
            // 
            phongView.AllowUserToAddRows = false;
            phongView.AllowUserToDeleteRows = false;
            phongView.Anchor = AnchorStyles.None;
            phongView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            phongView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            phongView.BackgroundColor = Color.White;
            phongView.BorderStyle = BorderStyle.None;
            phongView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            phongView.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column5, Column7, Column8, Column6 });
            phongView.Location = new Point(13, 94);
            phongView.Name = "phongView";
            phongView.ReadOnly = true;
            phongView.RowHeadersWidth = 51;
            phongView.RowTemplate.Height = 29;
            phongView.Size = new Size(514, 157);
            phongView.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "MaPhong";
            Column1.HeaderText = "Mã phòng";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 106;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "TenLP";
            Column2.HeaderText = "Loại phòng";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 113;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "TinhTrang";
            Column3.HeaderText = "Tình trạng";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 105;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "TenKH";
            Column5.HeaderText = "Tên khách hàng";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 140;
            // 
            // Column7
            // 
            Column7.DataPropertyName = "Email";
            Column7.HeaderText = "Email";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Width = 75;
            // 
            // Column8
            // 
            Column8.DataPropertyName = "SDT";
            Column8.HeaderText = "SDT";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Width = 64;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "TongTien";
            Column6.HeaderText = "Tổng tiền";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 101;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(9, 42);
            label8.Name = "label8";
            label8.Size = new Size(103, 19);
            label8.TabIndex = 6;
            label8.Text = "Loại phòng:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(255, 128, 255);
            label6.Location = new Point(9, 6);
            label6.Name = "label6";
            label6.Size = new Size(99, 19);
            label6.TabIndex = 0;
            label6.Text = "Tìm phòng:";
            // 
            // timLPTab
            // 
            timLPTab.Controls.Add(loaiPhongView);
            timLPTab.Controls.Add(label28);
            timLPTab.Location = new Point(4, 4);
            timLPTab.Name = "timLPTab";
            timLPTab.Padding = new Padding(3);
            timLPTab.Size = new Size(536, 259);
            timLPTab.TabIndex = 5;
            timLPTab.Text = "Xem loại phòng";
            timLPTab.UseVisualStyleBackColor = true;
            // 
            // loaiPhongView
            // 
            loaiPhongView.AllowUserToAddRows = false;
            loaiPhongView.AllowUserToDeleteRows = false;
            loaiPhongView.Anchor = AnchorStyles.None;
            loaiPhongView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            loaiPhongView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            loaiPhongView.BackgroundColor = Color.White;
            loaiPhongView.BorderStyle = BorderStyle.None;
            loaiPhongView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            loaiPhongView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, Column4 });
            loaiPhongView.Location = new Point(6, 25);
            loaiPhongView.Name = "loaiPhongView";
            loaiPhongView.ReadOnly = true;
            loaiPhongView.RowHeadersWidth = 51;
            loaiPhongView.RowTemplate.Height = 29;
            loaiPhongView.Size = new Size(524, 226);
            loaiPhongView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "MaLP";
            dataGridViewTextBoxColumn1.HeaderText = "Mã loại phòng";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 135;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "TenLP";
            dataGridViewTextBoxColumn2.HeaderText = "Loại phòng";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 113;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "MoTa";
            dataGridViewTextBoxColumn3.HeaderText = "Mô tả";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 77;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "GiaTien";
            Column4.HeaderText = "Giá tiền";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 89;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label28.ForeColor = Color.FromArgb(255, 128, 255);
            label28.Location = new Point(6, 3);
            label28.Name = "label28";
            label28.Size = new Size(144, 19);
            label28.TabIndex = 3;
            label28.Text = "Xem loại phòng:";
            // 
            // themPhongTab
            // 
            themPhongTab.Controls.Add(button3);
            themPhongTab.Controls.Add(themMoTaLP);
            themPhongTab.Controls.Add(label26);
            themPhongTab.Controls.Add(themGiaTienLP);
            themPhongTab.Controls.Add(label25);
            themPhongTab.Controls.Add(themTenLP);
            themPhongTab.Controls.Add(label24);
            themPhongTab.Controls.Add(label11);
            themPhongTab.Controls.Add(button2);
            themPhongTab.Controls.Add(themPhongLPCB);
            themPhongTab.Controls.Add(label10);
            themPhongTab.Controls.Add(label20);
            themPhongTab.Location = new Point(4, 4);
            themPhongTab.Name = "themPhongTab";
            themPhongTab.Padding = new Padding(3);
            themPhongTab.Size = new Size(536, 259);
            themPhongTab.TabIndex = 3;
            themPhongTab.Text = "Thêm phòng";
            themPhongTab.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackColor = Color.Lime;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(365, 156);
            button3.Name = "button3";
            button3.Size = new Size(162, 57);
            button3.TabIndex = 27;
            button3.Text = "Thêm loại phòng";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // themMoTaLP
            // 
            themMoTaLP.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            themMoTaLP.Location = new Point(17, 197);
            themMoTaLP.Multiline = true;
            themMoTaLP.Name = "themMoTaLP";
            themMoTaLP.Size = new Size(335, 54);
            themMoTaLP.TabIndex = 26;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label26.Location = new Point(20, 175);
            label26.Name = "label26";
            label26.Size = new Size(58, 19);
            label26.TabIndex = 25;
            label26.Text = "Mô tả:";
            // 
            // themGiaTienLP
            // 
            themGiaTienLP.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            themGiaTienLP.Location = new Point(198, 145);
            themGiaTienLP.Name = "themGiaTienLP";
            themGiaTienLP.Size = new Size(146, 27);
            themGiaTienLP.TabIndex = 24;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label25.Location = new Point(201, 126);
            label25.Name = "label25";
            label25.Size = new Size(75, 19);
            label25.TabIndex = 23;
            label25.Text = "Giá tiền:";
            // 
            // themTenLP
            // 
            themTenLP.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            themTenLP.Location = new Point(17, 145);
            themTenLP.Name = "themTenLP";
            themTenLP.Size = new Size(146, 27);
            themTenLP.TabIndex = 22;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label24.Location = new Point(20, 126);
            label24.Name = "label24";
            label24.Size = new Size(133, 19);
            label24.TabIndex = 21;
            label24.Text = "Tên loại phòng:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(255, 128, 255);
            label11.Location = new Point(13, 96);
            label11.Name = "label11";
            label11.Size = new Size(149, 19);
            label11.TabIndex = 20;
            label11.Text = "Thêm loại phòng:";
            // 
            // button2
            // 
            button2.BackColor = Color.Lime;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(365, 40);
            button2.Name = "button2";
            button2.Size = new Size(162, 57);
            button2.TabIndex = 19;
            button2.Text = "Thêm Phòng";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // themPhongLPCB
            // 
            themPhongLPCB.FormattingEnabled = true;
            themPhongLPCB.Location = new Point(13, 56);
            themPhongLPCB.Name = "themPhongLPCB";
            themPhongLPCB.Size = new Size(151, 28);
            themPhongLPCB.TabIndex = 8;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(13, 34);
            label10.Name = "label10";
            label10.Size = new Size(103, 19);
            label10.TabIndex = 7;
            label10.Text = "Loại phòng:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label20.ForeColor = Color.FromArgb(255, 128, 255);
            label20.Location = new Point(13, 10);
            label20.Name = "label20";
            label20.Size = new Size(116, 19);
            label20.TabIndex = 6;
            label20.Text = "Thêm phòng:";
            // 
            // capNhatTab
            // 
            capNhatTab.Controls.Add(xoaPB);
            capNhatTab.Controls.Add(capNhatPB);
            capNhatTab.Controls.Add(capNhatMaPhongTB);
            capNhatTab.Controls.Add(label17);
            capNhatTab.Controls.Add(CapNhatPhongButton);
            capNhatTab.Controls.Add(label16);
            capNhatTab.Location = new Point(4, 4);
            capNhatTab.Name = "capNhatTab";
            capNhatTab.Padding = new Padding(3);
            capNhatTab.Size = new Size(536, 259);
            capNhatTab.TabIndex = 2;
            capNhatTab.Text = "Check out, xoá phòng";
            capNhatTab.UseVisualStyleBackColor = true;
            // 
            // xoaPB
            // 
            xoaPB.AutoSize = true;
            xoaPB.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            xoaPB.ForeColor = Color.Red;
            xoaPB.Location = new Point(365, 10);
            xoaPB.Name = "xoaPB";
            xoaPB.Size = new Size(64, 23);
            xoaPB.TabIndex = 43;
            xoaPB.Text = "Xoá";
            xoaPB.UseVisualStyleBackColor = true;
            xoaPB.CheckedChanged += xoaPB_CheckedChanged;
            // 
            // capNhatPB
            // 
            capNhatPB.AutoSize = true;
            capNhatPB.Checked = true;
            capNhatPB.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            capNhatPB.ForeColor = Color.Lime;
            capNhatPB.Location = new Point(211, 11);
            capNhatPB.Name = "capNhatPB";
            capNhatPB.Size = new Size(115, 23);
            capNhatPB.TabIndex = 42;
            capNhatPB.TabStop = true;
            capNhatPB.Text = "Check out";
            capNhatPB.UseVisualStyleBackColor = true;
            capNhatPB.CheckedChanged += capNhatPB_CheckedChanged;
            // 
            // capNhatMaPhongTB
            // 
            capNhatMaPhongTB.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            capNhatMaPhongTB.Location = new Point(365, 72);
            capNhatMaPhongTB.Name = "capNhatMaPhongTB";
            capNhatMaPhongTB.Size = new Size(162, 27);
            capNhatMaPhongTB.TabIndex = 33;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = Color.Red;
            label17.Location = new Point(365, 52);
            label17.Name = "label17";
            label17.Size = new Size(98, 19);
            label17.TabIndex = 32;
            label17.Text = "Mã phòng:";
            // 
            // CapNhatPhongButton
            // 
            CapNhatPhongButton.BackColor = Color.Lime;
            CapNhatPhongButton.FlatAppearance.BorderSize = 0;
            CapNhatPhongButton.FlatStyle = FlatStyle.Flat;
            CapNhatPhongButton.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            CapNhatPhongButton.ForeColor = Color.White;
            CapNhatPhongButton.Location = new Point(365, 196);
            CapNhatPhongButton.Name = "CapNhatPhongButton";
            CapNhatPhongButton.Size = new Size(162, 57);
            CapNhatPhongButton.TabIndex = 30;
            CapNhatPhongButton.Text = "Check Out";
            CapNhatPhongButton.UseVisualStyleBackColor = false;
            CapNhatPhongButton.Click += CapNhatPhongButton_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.FromArgb(255, 128, 255);
            label16.Location = new Point(6, 10);
            label16.Name = "label16";
            label16.Size = new Size(199, 19);
            label16.TabIndex = 19;
            label16.Text = "Check out, xoá phòng:";
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(CapNhatLoaiPhongButton);
            tabPage1.Controls.Add(xoaLPB);
            tabPage1.Controls.Add(capNhatMoTaLPTB);
            tabPage1.Controls.Add(capNhatLPB);
            tabPage1.Controls.Add(label27);
            tabPage1.Controls.Add(capNhatMoTaLPLB);
            tabPage1.Controls.Add(capNhatTenLPLB);
            tabPage1.Controls.Add(capNhatGiaTienLPTB);
            tabPage1.Controls.Add(capNhatTenLPTB);
            tabPage1.Controls.Add(capNhatGiaTienLPLB);
            tabPage1.Location = new Point(4, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(536, 259);
            tabPage1.TabIndex = 4;
            tabPage1.Text = "Cập nhật,xoá loại phòng";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // CapNhatLoaiPhongButton
            // 
            CapNhatLoaiPhongButton.BackColor = Color.Lime;
            CapNhatLoaiPhongButton.FlatAppearance.BorderSize = 0;
            CapNhatLoaiPhongButton.FlatStyle = FlatStyle.Flat;
            CapNhatLoaiPhongButton.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            CapNhatLoaiPhongButton.ForeColor = Color.White;
            CapNhatLoaiPhongButton.Location = new Point(368, 194);
            CapNhatLoaiPhongButton.Name = "CapNhatLoaiPhongButton";
            CapNhatLoaiPhongButton.Size = new Size(162, 57);
            CapNhatLoaiPhongButton.TabIndex = 31;
            CapNhatLoaiPhongButton.Text = "Cập nhật";
            CapNhatLoaiPhongButton.UseVisualStyleBackColor = false;
            CapNhatLoaiPhongButton.Click += CapNhatLoaiPhongButton_Click;
            // 
            // xoaLPB
            // 
            xoaLPB.AutoSize = true;
            xoaLPB.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            xoaLPB.ForeColor = Color.Red;
            xoaLPB.Location = new Point(320, 12);
            xoaLPB.Name = "xoaLPB";
            xoaLPB.Size = new Size(69, 23);
            xoaLPB.TabIndex = 46;
            xoaLPB.TabStop = true;
            xoaLPB.Text = "Xoá ";
            xoaLPB.UseVisualStyleBackColor = true;
            xoaLPB.CheckedChanged += xoaLPB_CheckedChanged;
            // 
            // capNhatMoTaLPTB
            // 
            capNhatMoTaLPTB.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            capNhatMoTaLPTB.Location = new Point(13, 114);
            capNhatMoTaLPTB.Multiline = true;
            capNhatMoTaLPTB.Name = "capNhatMoTaLPTB";
            capNhatMoTaLPTB.Size = new Size(517, 74);
            capNhatMoTaLPTB.TabIndex = 32;
            // 
            // capNhatLPB
            // 
            capNhatLPB.AutoSize = true;
            capNhatLPB.Checked = true;
            capNhatLPB.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            capNhatLPB.ForeColor = Color.Lime;
            capNhatLPB.Location = new Point(197, 11);
            capNhatLPB.Name = "capNhatLPB";
            capNhatLPB.Size = new Size(101, 23);
            capNhatLPB.TabIndex = 45;
            capNhatLPB.TabStop = true;
            capNhatLPB.Text = "Cập nhật";
            capNhatLPB.UseVisualStyleBackColor = true;
            capNhatLPB.CheckedChanged += capNhatLPB_CheckedChanged;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label27.ForeColor = Color.FromArgb(255, 128, 255);
            label27.Location = new Point(9, 11);
            label27.Name = "label27";
            label27.Size = new Size(185, 19);
            label27.TabIndex = 44;
            label27.Text = "Cập nhật, xoá phòng:";
            // 
            // capNhatMoTaLPLB
            // 
            capNhatMoTaLPLB.AutoSize = true;
            capNhatMoTaLPLB.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            capNhatMoTaLPLB.Location = new Point(16, 92);
            capNhatMoTaLPLB.Name = "capNhatMoTaLPLB";
            capNhatMoTaLPLB.Size = new Size(58, 19);
            capNhatMoTaLPLB.TabIndex = 31;
            capNhatMoTaLPLB.Text = "Mô tả:";
            // 
            // capNhatTenLPLB
            // 
            capNhatTenLPLB.AutoSize = true;
            capNhatTenLPLB.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            capNhatTenLPLB.ForeColor = Color.Red;
            capNhatTenLPLB.Location = new Point(381, 43);
            capNhatTenLPLB.Name = "capNhatTenLPLB";
            capNhatTenLPLB.Size = new Size(133, 19);
            capNhatTenLPLB.TabIndex = 27;
            capNhatTenLPLB.Text = "Tên loại phòng:";
            // 
            // capNhatGiaTienLPTB
            // 
            capNhatGiaTienLPTB.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            capNhatGiaTienLPTB.Location = new Point(13, 62);
            capNhatGiaTienLPTB.Name = "capNhatGiaTienLPTB";
            capNhatGiaTienLPTB.Size = new Size(146, 27);
            capNhatGiaTienLPTB.TabIndex = 30;
            // 
            // capNhatTenLPTB
            // 
            capNhatTenLPTB.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            capNhatTenLPTB.Location = new Point(381, 62);
            capNhatTenLPTB.Name = "capNhatTenLPTB";
            capNhatTenLPTB.Size = new Size(146, 27);
            capNhatTenLPTB.TabIndex = 28;
            // 
            // capNhatGiaTienLPLB
            // 
            capNhatGiaTienLPLB.AutoSize = true;
            capNhatGiaTienLPLB.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            capNhatGiaTienLPLB.Location = new Point(16, 43);
            capNhatGiaTienLPLB.Name = "capNhatGiaTienLPLB";
            capNhatGiaTienLPLB.Size = new Size(75, 19);
            capNhatGiaTienLPLB.TabIndex = 29;
            capNhatGiaTienLPLB.Text = "Giá tiền:";
            // 
            // PhongPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(timPhongPage);
            Controls.Add(tabControlPhong);
            Name = "PhongPage";
            Size = new Size(702, 365);
            timPhongPage.ResumeLayout(false);
            datPhongTab.ResumeLayout(false);
            datPhongTab.PerformLayout();
            timPhongTab.ResumeLayout(false);
            timPhongTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)phongView).EndInit();
            timLPTab.ResumeLayout(false);
            timLPTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)loaiPhongView).EndInit();
            themPhongTab.ResumeLayout(false);
            themPhongTab.PerformLayout();
            capNhatTab.ResumeLayout(false);
            capNhatTab.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cboTinhTrang;
        private ComboBox cboHienThi;
        private Button btnThanhToan;
        private Button btnTroVe;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private ComboBox cboDatTruoc;
        private TextBox txtGia;
        private ComboBox cboHang;
        private TextBox txtSoGiuong;
        private DataGridView tempStuff;
        private TabControl tabControlPhong;
        private TabControl timPhongPage;
        private TabPage datPhongTab;
        private Button button1;
        private TextBox Email;
        private Label label5;
        private TextBox SDT;
        private Label label4;
        private Label label1;
        private TabPage timPhongTab;
        private Label label9;
        private DataGridView phongView;
        private Label label8;
        private Label label6;
        private TabPage capNhatTab;
        private TextBox capNhatMaPhongTB;
        private Label label17;
        private Button CapNhatPhongButton;
        private Label label16;
        private ComboBox loaiPhongCB;
        private Label loaiPhongLB;
        private ComboBox timKiemTinhTrangCB;
        private TabPage themPhongTab;
        private Label label10;
        private Label label20;
        private ComboBox themPhongLPCB;
        private Button button2;
        private TextBox themGiaTienLP;
        private Label label25;
        private TextBox themTenLP;
        private Label label24;
        private Label label11;
        private Button button3;
        private TextBox themMoTaLP;
        private Label label26;
        private TextBox maPhongCB;
        private Label maPhongLB;
        private TextBox timKiemMaPhong;
        private Label label15;
        private RadioButton xoaPB;
        private RadioButton capNhatPB;
        private TabPage tabPage1;
        private RadioButton xoaLPB;
        private TextBox capNhatMoTaLPTB;
        private RadioButton capNhatLPB;
        private Label label27;
        private Label capNhatMoTaLPLB;
        private Label capNhatTenLPLB;
        private TextBox capNhatGiaTienLPTB;
        private TextBox capNhatTenLPTB;
        private Label capNhatGiaTienLPLB;
        private Button CapNhatLoaiPhongButton;
        private TabPage timLPTab;
        private DataGridView loaiPhongView;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn Column4;
        private Label label28;
        private RadioButton radioButton6;
        private RadioButton radioButton5;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column6;
        private ComboBox timKiemLPCB;
    }
}
