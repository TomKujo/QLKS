using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLKS
{
    public partial class frmKH : Form
    {
        private SqlConnection _conn;

        public frmKH()
        {
            InitializeComponent();
            _conn = new SqlConnection("Data Source=MSI\\SQLEXPRESS;Initial Catalog=QLKS;Integrated Security=True;TrustServerCertificate=True");
        }

        private void updateKH()
        {
            try
            {
                if (_conn.State == ConnectionState.Closed)
                {
                    _conn.Open();
                }
                string selectKH = "SELECT * FROM KhachHang";
                SqlDataAdapter adapter = new SqlDataAdapter(selectKH, _conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvKH.DataSource = dt;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.ToString());
            }
            finally
            {
                if (_conn.State == ConnectionState.Open)
                {
                    _conn.Close();
                }
            }
        }

        private void loadGioiTinhComboBox()
        {
            string query = "SELECT * FROM KhachHang";
            SqlDataAdapter da = new SqlDataAdapter(query, _conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cboGioiTinh.DisplayMember = "GioiTinh";
            cboGioiTinh.ValueMember = "GioiTinh";
            cboGioiTinh.DataSource = dt;
        }

        private void loadMaPhongComboBox()
        {
            string query = "SELECT * FROM Phong";
            SqlDataAdapter da = new SqlDataAdapter(query, _conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cboMaPhong.DisplayMember = "MaPhong";
            cboMaPhong.ValueMember = "MaPhong";
            cboMaPhong.DataSource = dt;
        }

        private void frmKH_Load(object sender, EventArgs e)
        {
            updateKH();
            loadGioiTinhComboBox();
            loadMaPhongComboBox();
            cboGioiTinh.SelectedIndex = -1;
            cboMaPhong.SelectedIndex = -1;
        }

        private void dgvKH_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtMaKH.Text = dgvKH.Rows[e.RowIndex].Cells["MaKH"].Value.ToString();
            txtTenKH.Text = dgvKH.Rows[e.RowIndex].Cells["TenKH"].Value.ToString();
            txtSDT.Text = dgvKH.Rows[e.RowIndex].Cells["SDT"].Value.ToString();
            txtQuocTich.Text = dgvKH.Rows[e.RowIndex].Cells["QuocTich"].Value.ToString();
            cboGioiTinh.SelectedValue = dgvKH.Rows[e.RowIndex].Cells["GioiTinh"].Value.ToString();
            dateTimePickerNgaySinh.Value = Convert.ToDateTime(dgvKH.Rows[e.RowIndex].Cells["NgaySinh"].Value);
            txtCCCD.Text = dgvKH.Rows[e.RowIndex].Cells["CCCD"].Value.ToString();
            txtDiaChi.Text = dgvKH.Rows[e.RowIndex].Cells["DiaChi"].Value.ToString();
            dateTimePickerNhan.Value = Convert.ToDateTime(dgvKH.Rows[e.RowIndex].Cells["ThoiGianNhanPhong"].Value);
            dateTimePickerTra.Value = Convert.ToDateTime(dgvKH.Rows[e.RowIndex].Cells["ThoiGianTraPhong"].Value);
            cboMaPhong.SelectedValue = dgvKH.Rows[e.RowIndex].Cells["MaPhong"].Value.ToString();
        }

        private bool IsMaKHExist(string maKH)
        {
            try
            {
                string checkQuery = "SELECT COUNT(*) FROM KhachHang WHERE MaKH = @MaKH";
                SqlCommand checkCmd = new SqlCommand(checkQuery, _conn);
                checkCmd.Parameters.AddWithValue("@MaKH", maKH);
                if (_conn.State == ConnectionState.Closed)
                {
                    _conn.Open();
                }
                int count = (int)checkCmd.ExecuteScalar();
                return count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi kiểm tra Mã Khách Hàng: " + ex.Message);
                return false;
            }
            finally
            {
                if (_conn.State == ConnectionState.Open)
                {
                    _conn.Close();
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaKH.Text) || string.IsNullOrEmpty(txtTenKH.Text) || string.IsNullOrEmpty(txtSDT.Text) || string.IsNullOrEmpty(txtQuocTich.Text) || string.IsNullOrEmpty(cboGioiTinh.SelectedValue.ToString()) || string.IsNullOrEmpty(dateTimePickerNgaySinh.Value.ToString()) || string.IsNullOrEmpty(txtCCCD.Text) || string.IsNullOrEmpty(txtDiaChi.Text) || string.IsNullOrEmpty(dateTimePickerNhan.Value.ToString()) || string.IsNullOrEmpty(dateTimePickerTra.Value.ToString()) || string.IsNullOrEmpty(cboMaPhong.SelectedValue.ToString()))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã Khách Hàng, Tên Khách Hàng, Số Điện Thoại, Quốc Tịch, Giới Tính, Ngày Sinh, Căn Cước Công Dân, Địa Chỉ, Thời Gian Nhận Phòng, Thời Gian Trả Phòng, Mã Phòng.");
                return;
            }
            if (IsMaKHExist(txtMaKH.Text))
            {
                MessageBox.Show("Mã Khách Hàng đã tồn tại. Vui lòng chọn Mã Khách Hàng khác.");
                return;
            }
            try
            {
                string insertString = "INSERT INTO KhachHang VALUES(@MaKH, @TenKH, @SDT, @QuocTich, @GioiTinh, @NgaySinh, @CCCD, @DiaChi, @ThoiGianNhanPhong, @ThoiGianTraPhong, @MaPhong)";
                SqlCommand cmd = new SqlCommand(insertString, _conn);
                cmd.Parameters.AddWithValue("@MaKH", txtMaKH.Text);
                cmd.Parameters.AddWithValue("@TenKH", txtTenKH.Text);
                cmd.Parameters.AddWithValue("@SDT", txtSDT.Text);
                cmd.Parameters.AddWithValue("@QuocTich", txtQuocTich.Text);
                cmd.Parameters.AddWithValue("@GioiTinh", cboGioiTinh.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@NgaySinh", dateTimePickerNgaySinh.Value.ToString());
                cmd.Parameters.AddWithValue("@CCCD", txtCCCD.Text);
                cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
                cmd.Parameters.AddWithValue("@ThoiGianNhanPhong", dateTimePickerNhan.Value.ToString());
                cmd.Parameters.AddWithValue("@ThoiGianTraPhong", dateTimePickerTra.Value.ToString());
                cmd.Parameters.AddWithValue("@MaPhong", cboMaPhong.SelectedValue.ToString());
                if (_conn.State == ConnectionState.Closed)
                {
                    _conn.Open();
                }
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công");
                updateKH();
                txtMaKH.Clear();
                txtTenKH.Clear();
                txtSDT.Clear();
                txtQuocTich.Clear();
                cboGioiTinh.SelectedIndex = -1;
                dateTimePickerNgaySinh.Value = DateTime.Now;
                txtCCCD.Clear();
                txtDiaChi.Clear();
                dateTimePickerNhan.Value = DateTime.Now;
                dateTimePickerTra.Value = DateTime.Now;
                cboMaPhong.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại: " + ex.Message);
            }
            finally
            {
                if (_conn.State == ConnectionState.Open)
                {
                    _conn.Close();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaKH.Text))
            {
                MessageBox.Show("Vui lòng chọn một Khách Hàng để xóa.");
                return;
            }
            try
            {
                string xoaKH = "DELETE FROM KhachHang WHERE MaKH = @MaKH";
                SqlCommand sqlCommand = new SqlCommand(xoaKH, _conn);
                sqlCommand.Parameters.AddWithValue("@MaKH", txtMaKH.Text);
                if (_conn.State == ConnectionState.Closed)
                {
                    _conn.Open();
                }
                DialogResult dr = MessageBox.Show("Bạn thật sự muốn xóa sao?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công");
                    updateKH();
                    txtMaKH.Clear();
                    txtTenKH.Clear();
                    txtSDT.Clear();
                    txtQuocTich.Clear();
                    cboGioiTinh.SelectedIndex = -1;
                    dateTimePickerNgaySinh.Value = DateTime.Now;
                    txtCCCD.Clear();
                    txtDiaChi.Clear();
                    dateTimePickerNhan.Value = DateTime.Now;
                    dateTimePickerTra.Value = DateTime.Now;
                    cboMaPhong.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa thất bại: " + ex.Message);
            }
            finally
            {
                if (_conn.State == ConnectionState.Open)
                {
                    _conn.Close();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaKH.Text))
            {
                MessageBox.Show("Vui lòng chọn một Khách Hàng để sửa và nhập Tên Khách Hàng, Số Điện Thoại, Quốc Tịch, Giới Tính, Ngày Sinh, Căn Cước Công Dân, Địa Chỉ, Thời Gian Nhận Phòng, Thời Gian Trả Phòng, Mã Phòng mới.");
                return;
            }
            try
            {
                string query = "UPDATE KhachHang SET TenKH = @TenKHMoi, SDT = @SDTMoi, QuocTich = @QuocTichMoi, GioiTinh = @GioiTinhMoi, NgaySinh = @NgaySinhMoi, CCCD = @CCCDMoi, DiaChi = @DiaChiMoi, ThoiGianNhanPhong = @ThoiGianNhanPhongMoi, ThoiGianTraPhong = @ThoiGianTraPhongMoi, MaPhong = @MaPhongMoi WHERE MaKH = @MaKH";
                using (SqlCommand sqlCommand = new SqlCommand(query, _conn))
                {
                    sqlCommand.Parameters.AddWithValue("@MaKH", txtMaKH.Text);
                    sqlCommand.Parameters.AddWithValue("@TenKHMoi", txtTenKH.Text);
                    sqlCommand.Parameters.AddWithValue("@SDTMoi", txtSDT.Text);
                    sqlCommand.Parameters.AddWithValue("@QuocTichMoi", txtQuocTich.Text);
                    sqlCommand.Parameters.AddWithValue("@GioiTinhMoi", cboGioiTinh.SelectedValue.ToString());
                    sqlCommand.Parameters.AddWithValue("@NgaySinhMoi", dateTimePickerNgaySinh.Value.ToString());
                    sqlCommand.Parameters.AddWithValue("@CCCDMoi", txtCCCD.Text);
                    sqlCommand.Parameters.AddWithValue("@DiaChiMoi", txtDiaChi.Text);
                    sqlCommand.Parameters.AddWithValue("@ThoiGianNhanPhongMoi", dateTimePickerNhan.Value.ToString());
                    sqlCommand.Parameters.AddWithValue("@ThoiGianTraPhongMoi", dateTimePickerTra.Value.ToString());
                    sqlCommand.Parameters.AddWithValue("@MaPhongMoi", cboMaPhong.SelectedValue.ToString());
                    if (_conn.State == ConnectionState.Closed)
                    {
                        _conn.Open();
                    }
                    int rowsAffected = sqlCommand.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Sửa thành công");
                        updateKH();
                        txtMaKH.Clear();
                        txtTenKH.Clear();
                        txtSDT.Clear();
                        txtQuocTich.Clear();
                        cboGioiTinh.SelectedIndex = -1;
                        dateTimePickerNgaySinh.Value = DateTime.Now;
                        txtCCCD.Clear();
                        txtDiaChi.Clear();
                        dateTimePickerNhan.Value = DateTime.Now;
                        dateTimePickerTra.Value = DateTime.Now;
                        cboMaPhong.SelectedIndex = -1;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy Khách Hàng để sửa");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa thất bại: " + ex.Message);
            }
            finally
            {
                if (_conn.State == ConnectionState.Open)
                {
                    _conn.Close();
                }
            }
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            frmChucNang frmChucNang = new frmChucNang();
            frmChucNang.Show();
            //this.Hide();
        }
    }
}