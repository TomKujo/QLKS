namespace QLKS
{
    partial class KhachHangPage
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
            themKHPage = new TabPage();
            button1 = new Button();
            Email = new TextBox();
            label5 = new Label();
            label2 = new Label();
            diaChi = new TextBox();
            label7 = new Label();
            DOB = new DateTimePicker();
            SDT = new TextBox();
            label4 = new Label();
            tenKH = new TextBox();
            label3 = new Label();
            label1 = new Label();
            timKhachHangTab = new TabPage();
            timTheoSDT = new TextBox();
            label10 = new Label();
            timTheoEmail = new TextBox();
            label9 = new Label();
            timTheoTenKH = new TextBox();
            khachHangView = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            label8 = new Label();
            label6 = new Label();
            tabPage1 = new TabPage();
            xoaKHB = new RadioButton();
            capNhatKHB = new RadioButton();
            dobCB = new CheckBox();
            maKH = new TextBox();
            label17 = new Label();
            CapNhatKH = new Button();
            capNhatEmail = new TextBox();
            emailLB = new Label();
            dobLabel = new Label();
            capNhatDiaChi = new TextBox();
            diaChiLB = new Label();
            capNhatDOB = new DateTimePicker();
            capNhatSDT = new TextBox();
            sdtLB = new Label();
            capNhatTenKH = new TextBox();
            tenKHLB = new Label();
            label16 = new Label();
            tabControlPhong.SuspendLayout();
            themKHPage.SuspendLayout();
            timKhachHangTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)khachHangView).BeginInit();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlPhong
            // 
            tabControlPhong.Alignment = TabAlignment.Bottom;
            tabControlPhong.Anchor = AnchorStyles.None;
            tabControlPhong.Controls.Add(themKHPage);
            tabControlPhong.Controls.Add(timKhachHangTab);
            tabControlPhong.Controls.Add(tabPage1);
            tabControlPhong.Location = new Point(71, 38);
            tabControlPhong.Name = "tabControlPhong";
            tabControlPhong.SelectedIndex = 0;
            tabControlPhong.Size = new Size(562, 292);
            tabControlPhong.TabIndex = 1;
            // 
            // themKHPage
            // 
            themKHPage.BackColor = Color.White;
            themKHPage.Controls.Add(button1);
            themKHPage.Controls.Add(Email);
            themKHPage.Controls.Add(label5);
            themKHPage.Controls.Add(label2);
            themKHPage.Controls.Add(diaChi);
            themKHPage.Controls.Add(label7);
            themKHPage.Controls.Add(DOB);
            themKHPage.Controls.Add(SDT);
            themKHPage.Controls.Add(label4);
            themKHPage.Controls.Add(tenKH);
            themKHPage.Controls.Add(label3);
            themKHPage.Controls.Add(label1);
            themKHPage.Location = new Point(4, 4);
            themKHPage.Name = "themKHPage";
            themKHPage.Padding = new Padding(3);
            themKHPage.Size = new Size(554, 259);
            themKHPage.TabIndex = 0;
            themKHPage.Text = "Thêm khách hàng";
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(370, 189);
            button1.Name = "button1";
            button1.Size = new Size(162, 57);
            button1.TabIndex = 18;
            button1.Text = "Thêm Khách Hàng";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Email
            // 
            Email.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Email.Location = new Point(6, 157);
            Email.Name = "Email";
            Email.Size = new Size(146, 27);
            Email.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(6, 135);
            label5.Name = "label5";
            label5.Size = new Size(58, 19);
            label5.TabIndex = 16;
            label5.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(158, 28);
            label2.Name = "label2";
            label2.Size = new Size(96, 19);
            label2.TabIndex = 15;
            label2.Text = "Ngày sinh:";
            // 
            // diaChi
            // 
            diaChi.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            diaChi.Location = new Point(158, 104);
            diaChi.Multiline = true;
            diaChi.Name = "diaChi";
            diaChi.Size = new Size(374, 79);
            diaChi.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(158, 82);
            label7.Name = "label7";
            label7.Size = new Size(72, 19);
            label7.TabIndex = 12;
            label7.Text = "Địa chỉ:";
            // 
            // DOB
            // 
            DOB.CustomFormat = "yyyy-MM-dd";
            DOB.Format = DateTimePickerFormat.Custom;
            DOB.Location = new Point(158, 52);
            DOB.Name = "DOB";
            DOB.Size = new Size(162, 27);
            DOB.TabIndex = 14;
            // 
            // SDT
            // 
            SDT.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            SDT.Location = new Point(6, 105);
            SDT.Name = "SDT";
            SDT.Size = new Size(146, 27);
            SDT.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(6, 83);
            label4.Name = "label4";
            label4.Size = new Size(115, 19);
            label4.TabIndex = 6;
            label4.Text = "Số điện thoại:";
            // 
            // tenKH
            // 
            tenKH.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            tenKH.Location = new Point(6, 52);
            tenKH.Name = "tenKH";
            tenKH.Size = new Size(146, 27);
            tenKH.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(6, 30);
            label3.Name = "label3";
            label3.Size = new Size(146, 19);
            label3.TabIndex = 4;
            label3.Text = "Tên khách hàng:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(255, 128, 255);
            label1.Location = new Point(6, 6);
            label1.Name = "label1";
            label1.Size = new Size(162, 19);
            label1.TabIndex = 0;
            label1.Text = "Thêm khách hàng:";
            // 
            // timKhachHangTab
            // 
            timKhachHangTab.Controls.Add(timTheoSDT);
            timKhachHangTab.Controls.Add(label10);
            timKhachHangTab.Controls.Add(timTheoEmail);
            timKhachHangTab.Controls.Add(label9);
            timKhachHangTab.Controls.Add(timTheoTenKH);
            timKhachHangTab.Controls.Add(khachHangView);
            timKhachHangTab.Controls.Add(label8);
            timKhachHangTab.Controls.Add(label6);
            timKhachHangTab.Location = new Point(4, 4);
            timKhachHangTab.Name = "timKhachHangTab";
            timKhachHangTab.Padding = new Padding(3);
            timKhachHangTab.Size = new Size(554, 259);
            timKhachHangTab.TabIndex = 1;
            timKhachHangTab.Text = "Tìm khách hàng";
            timKhachHangTab.UseVisualStyleBackColor = true;
            // 
            // timTheoSDT
            // 
            timTheoSDT.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            timTheoSDT.Location = new Point(378, 61);
            timTheoSDT.Name = "timTheoSDT";
            timTheoSDT.Size = new Size(146, 27);
            timTheoSDT.TabIndex = 11;
            timTheoSDT.TextChanged += timTheoSDT_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(378, 39);
            label10.Name = "label10";
            label10.Size = new Size(115, 19);
            label10.TabIndex = 10;
            label10.Text = "Số điện thoại:";
            // 
            // timTheoEmail
            // 
            timTheoEmail.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            timTheoEmail.Location = new Point(202, 61);
            timTheoEmail.Name = "timTheoEmail";
            timTheoEmail.Size = new Size(146, 27);
            timTheoEmail.TabIndex = 9;
            timTheoEmail.TextChanged += timTheoEmail_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(202, 39);
            label9.Name = "label9";
            label9.Size = new Size(58, 19);
            label9.TabIndex = 8;
            label9.Text = "Email:";
            // 
            // timTheoTenKH
            // 
            timTheoTenKH.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            timTheoTenKH.Location = new Point(6, 61);
            timTheoTenKH.Name = "timTheoTenKH";
            timTheoTenKH.Size = new Size(146, 27);
            timTheoTenKH.TabIndex = 7;
            timTheoTenKH.TextChanged += timTheoTenKH_TextChanged;
            // 
            // khachHangView
            // 
            khachHangView.AllowUserToAddRows = false;
            khachHangView.AllowUserToDeleteRows = false;
            khachHangView.Anchor = AnchorStyles.None;
            khachHangView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            khachHangView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            khachHangView.BackgroundColor = Color.White;
            khachHangView.BorderStyle = BorderStyle.None;
            khachHangView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            khachHangView.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            khachHangView.Location = new Point(6, 94);
            khachHangView.Name = "khachHangView";
            khachHangView.ReadOnly = true;
            khachHangView.RowHeadersWidth = 51;
            khachHangView.RowTemplate.Height = 29;
            khachHangView.Size = new Size(531, 159);
            khachHangView.TabIndex = 1;
            khachHangView.CellClick += khachHangView_CellClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "MaKH";
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 53;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "TenKH";
            Column2.FillWeight = 100.748665F;
            Column2.HeaderText = "Tên khách hàng";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 140;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Email";
            Column3.FillWeight = 100.748665F;
            Column3.HeaderText = "Email";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 75;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "SDT";
            Column4.FillWeight = 100.748665F;
            Column4.HeaderText = "SDT";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 64;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "NgaySinh";
            Column5.FillWeight = 100.748665F;
            Column5.HeaderText = "Ngày sinh";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 103;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "DiaChi";
            Column6.FillWeight = 100.748665F;
            Column6.HeaderText = "Địa chỉ";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 84;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(6, 39);
            label8.Name = "label8";
            label8.Size = new Size(146, 19);
            label8.TabIndex = 6;
            label8.Text = "Tên khách hàng:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(255, 128, 255);
            label6.Location = new Point(6, 3);
            label6.Name = "label6";
            label6.Size = new Size(145, 19);
            label6.TabIndex = 0;
            label6.Text = "Tìm khách hàng:";
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(xoaKHB);
            tabPage1.Controls.Add(capNhatKHB);
            tabPage1.Controls.Add(dobCB);
            tabPage1.Controls.Add(maKH);
            tabPage1.Controls.Add(label17);
            tabPage1.Controls.Add(CapNhatKH);
            tabPage1.Controls.Add(capNhatEmail);
            tabPage1.Controls.Add(emailLB);
            tabPage1.Controls.Add(dobLabel);
            tabPage1.Controls.Add(capNhatDiaChi);
            tabPage1.Controls.Add(diaChiLB);
            tabPage1.Controls.Add(capNhatDOB);
            tabPage1.Controls.Add(capNhatSDT);
            tabPage1.Controls.Add(sdtLB);
            tabPage1.Controls.Add(capNhatTenKH);
            tabPage1.Controls.Add(tenKHLB);
            tabPage1.Controls.Add(label16);
            tabPage1.Location = new Point(4, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(554, 259);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Cập nhật, xoá khách hàng";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // xoaKHB
            // 
            xoaKHB.AutoSize = true;
            xoaKHB.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            xoaKHB.ForeColor = Color.Red;
            xoaKHB.Location = new Point(358, 9);
            xoaKHB.Name = "xoaKHB";
            xoaKHB.Size = new Size(64, 23);
            xoaKHB.TabIndex = 35;
            xoaKHB.Text = "Xoá";
            xoaKHB.UseVisualStyleBackColor = true;
            xoaKHB.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // capNhatKHB
            // 
            capNhatKHB.AutoSize = true;
            capNhatKHB.Checked = true;
            capNhatKHB.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            capNhatKHB.ForeColor = Color.Lime;
            capNhatKHB.Location = new Point(251, 7);
            capNhatKHB.Name = "capNhatKHB";
            capNhatKHB.Size = new Size(101, 23);
            capNhatKHB.TabIndex = 2;
            capNhatKHB.TabStop = true;
            capNhatKHB.Text = "Cập nhật";
            capNhatKHB.UseVisualStyleBackColor = true;
            capNhatKHB.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // dobCB
            // 
            dobCB.AutoSize = true;
            dobCB.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dobCB.Location = new Point(14, 210);
            dobCB.Name = "dobCB";
            dobCB.Size = new Size(186, 23);
            dobCB.TabIndex = 34;
            dobCB.Text = "Cập nhật ngày sinh";
            dobCB.UseVisualStyleBackColor = true;
            dobCB.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // maKH
            // 
            maKH.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            maKH.Location = new Point(404, 56);
            maKH.Name = "maKH";
            maKH.Size = new Size(146, 27);
            maKH.TabIndex = 33;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = Color.Red;
            label17.Location = new Point(404, 34);
            label17.Name = "label17";
            label17.Size = new Size(144, 19);
            label17.TabIndex = 32;
            label17.Text = "Mã khách hàng:";
            // 
            // CapNhatKH
            // 
            CapNhatKH.BackColor = Color.Lime;
            CapNhatKH.FlatAppearance.BorderSize = 0;
            CapNhatKH.FlatStyle = FlatStyle.Flat;
            CapNhatKH.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            CapNhatKH.ForeColor = Color.White;
            CapNhatKH.Location = new Point(386, 196);
            CapNhatKH.Name = "CapNhatKH";
            CapNhatKH.Size = new Size(162, 57);
            CapNhatKH.TabIndex = 30;
            CapNhatKH.Text = "Cập nhật";
            CapNhatKH.UseVisualStyleBackColor = false;
            CapNhatKH.Click += CapNhatKH_Click;
            // 
            // capNhatEmail
            // 
            capNhatEmail.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            capNhatEmail.Location = new Point(14, 165);
            capNhatEmail.Name = "capNhatEmail";
            capNhatEmail.Size = new Size(146, 27);
            capNhatEmail.TabIndex = 29;
            // 
            // emailLB
            // 
            emailLB.AutoSize = true;
            emailLB.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            emailLB.Location = new Point(14, 143);
            emailLB.Name = "emailLB";
            emailLB.Size = new Size(58, 19);
            emailLB.TabIndex = 28;
            emailLB.Text = "Email:";
            // 
            // dobLabel
            // 
            dobLabel.AutoSize = true;
            dobLabel.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dobLabel.Location = new Point(166, 34);
            dobLabel.Name = "dobLabel";
            dobLabel.Size = new Size(96, 19);
            dobLabel.TabIndex = 27;
            dobLabel.Text = "Ngày sinh:";
            dobLabel.Visible = false;
            // 
            // capNhatDiaChi
            // 
            capNhatDiaChi.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            capNhatDiaChi.Location = new Point(166, 113);
            capNhatDiaChi.Multiline = true;
            capNhatDiaChi.Name = "capNhatDiaChi";
            capNhatDiaChi.Size = new Size(382, 79);
            capNhatDiaChi.TabIndex = 25;
            // 
            // diaChiLB
            // 
            diaChiLB.AutoSize = true;
            diaChiLB.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            diaChiLB.Location = new Point(166, 91);
            diaChiLB.Name = "diaChiLB";
            diaChiLB.Size = new Size(72, 19);
            diaChiLB.TabIndex = 24;
            diaChiLB.Text = "Địa chỉ:";
            // 
            // capNhatDOB
            // 
            capNhatDOB.CustomFormat = "yyyy-MM-dd";
            capNhatDOB.Format = DateTimePickerFormat.Custom;
            capNhatDOB.Location = new Point(166, 58);
            capNhatDOB.Name = "capNhatDOB";
            capNhatDOB.Size = new Size(162, 27);
            capNhatDOB.TabIndex = 26;
            capNhatDOB.Visible = false;
            // 
            // capNhatSDT
            // 
            capNhatSDT.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            capNhatSDT.Location = new Point(14, 113);
            capNhatSDT.Name = "capNhatSDT";
            capNhatSDT.Size = new Size(146, 27);
            capNhatSDT.TabIndex = 23;
            // 
            // sdtLB
            // 
            sdtLB.AutoSize = true;
            sdtLB.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            sdtLB.Location = new Point(14, 91);
            sdtLB.Name = "sdtLB";
            sdtLB.Size = new Size(115, 19);
            sdtLB.TabIndex = 22;
            sdtLB.Text = "Số điện thoại:";
            // 
            // capNhatTenKH
            // 
            capNhatTenKH.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            capNhatTenKH.Location = new Point(14, 56);
            capNhatTenKH.Name = "capNhatTenKH";
            capNhatTenKH.Size = new Size(146, 27);
            capNhatTenKH.TabIndex = 21;
            // 
            // tenKHLB
            // 
            tenKHLB.AutoSize = true;
            tenKHLB.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            tenKHLB.Location = new Point(14, 34);
            tenKHLB.Name = "tenKHLB";
            tenKHLB.Size = new Size(146, 19);
            tenKHLB.TabIndex = 20;
            tenKHLB.Text = "Tên khách hàng:";
            tenKHLB.Click += label15_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.FromArgb(255, 128, 255);
            label16.Location = new Point(14, 9);
            label16.Name = "label16";
            label16.Size = new Size(231, 19);
            label16.TabIndex = 19;
            label16.Text = "Cập nhật, xoá khách hàng:";
            // 
            // KhachHangPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tabControlPhong);
            Name = "KhachHangPage";
            Size = new Size(702, 365);
            tabControlPhong.ResumeLayout(false);
            themKHPage.ResumeLayout(false);
            themKHPage.PerformLayout();
            timKhachHangTab.ResumeLayout(false);
            timKhachHangTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)khachHangView).EndInit();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlPhong;
        private TabPage themKHPage;
        private Label label1;
        private TabPage timKhachHangTab;
        private TextBox tenKH;
        private Label label3;
        private TextBox SDT;
        private Label label4;
        private TextBox diaChi;
        private Label label7;
        private Label label2;
        private DateTimePicker DOB;
        private TextBox Email;
        private Label label5;
        private Button button1;
        private Label label6;
        private TextBox timTheoTenKH;
        private DataGridView khachHangView;
        private Label label8;
        private TextBox timTheoSDT;
        private Label label10;
        private TextBox timTheoEmail;
        private Label label9;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private TabPage tabPage1;
        private Button CapNhatKH;
        private TextBox capNhatEmail;
        private Label emailLB;
        private Label dobLabel;
        private TextBox capNhatDiaChi;
        private Label diaChiLB;
        private DateTimePicker capNhatDOB;
        private TextBox capNhatSDT;
        private Label sdtLB;
        private TextBox capNhatTenKH;
        private Label tenKHLB;
        private Label label16;
        private TextBox maKH;
        private Label label17;
        private CheckBox dobCB;
        private RadioButton capNhatKHB;
        private RadioButton xoaKHB;
    }
}
