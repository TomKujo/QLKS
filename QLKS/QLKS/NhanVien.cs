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
    public partial class frmNV : Form
    {
        private SqlConnection _conn;

        public frmNV()
        {
            InitializeComponent();
            _conn = new SqlConnection("Data Source=MSI\\SQLEXPRESS;Initial Catalog=QLKS;Integrated Security=True;TrustServerCertificate=True");
        }

        private void updateNV()
        {
            try
            {
                if (_conn.State == ConnectionState.Closed)
                {
                    _conn.Open();
                }
                string selectNV = "SELECT * FROM NhanVien";
                SqlDataAdapter adapter = new SqlDataAdapter(selectNV, _conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvNV.DataSource = dt;
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
            string query = "SELECT * FROM NhanVien";
            SqlDataAdapter da = new SqlDataAdapter(query, _conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cboGioiTinh.DisplayMember = "GioiTinh";
            cboGioiTinh.ValueMember = "GioiTinh";
            cboGioiTinh.DataSource = dt;
        }

        private void frmNV_Load(object sender, EventArgs e)
        {
            updateNV();
            loadGioiTinhComboBox();
            cboGioiTinh.SelectedIndex = -1;
        }

        private void dgvNV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtMaNV.Text = dgvNV.Rows[e.RowIndex].Cells["MaNV"].Value.ToString();
            txtTenNV.Text = dgvNV.Rows[e.RowIndex].Cells["TenNV"].Value.ToString();
            txtSDT.Text = dgvNV.Rows[e.RowIndex].Cells["SDT"].Value.ToString();
            cboGioiTinh.SelectedValue = dgvNV.Rows[e.RowIndex].Cells["GioiTinh"].Value.ToString();
            txtTK.Text = dgvNV.Rows[e.RowIndex].Cells["TK"].Value.ToString();
            txtMK.Text = dgvNV.Rows[e.RowIndex].Cells["MK"].Value.ToString();
        }

        private bool IsMaNVExist(string maNV)
        {
            try
            {
                string checkQuery = "SELECT COUNT(*) FROM NhanVien WHERE MaNV = @MaNV";
                SqlCommand checkCmd = new SqlCommand(checkQuery, _conn);
                checkCmd.Parameters.AddWithValue("@MaNV", maNV);
                if (_conn.State == ConnectionState.Closed)
                {
                    _conn.Open();
                }
                int count = (int)checkCmd.ExecuteScalar();
                return count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi kiểm tra Mã Nhân Viên: " + ex.Message);
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
            if (string.IsNullOrEmpty(txtMaNV.Text) || string.IsNullOrEmpty(txtTenNV.Text) || string.IsNullOrEmpty(txtSDT.Text) || string.IsNullOrEmpty(cboGioiTinh.SelectedValue.ToString()) || string.IsNullOrEmpty(txtTK.Text) || string.IsNullOrEmpty(txtMK.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã Nhân Viên, Tên Nhân Viên, Số Điện Thoại, Giới Tính, Tài Khoản, Mật Khẩu.");
                return;
            }
            if (IsMaNVExist(txtMaNV.Text))
            {
                MessageBox.Show("Mã Nhân Viên đã tồn tại. Vui lòng chọn Mã Nhân Viên khác.");
                return;
            }
            try
            {
                string insertString = "INSERT INTO NhanVien VALUES(@MaNV, @TenNV, @SDT, @GioiTinh, @TK, @MK)";
                SqlCommand cmd = new SqlCommand(insertString, _conn);
                cmd.Parameters.AddWithValue("@MaNV", txtMaNV.Text);
                cmd.Parameters.AddWithValue("@TenNV", txtTenNV.Text);
                cmd.Parameters.AddWithValue("@SDT", txtSDT.Text);
                cmd.Parameters.AddWithValue("@GioiTinh", cboGioiTinh.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@TK", txtTK.Text);
                cmd.Parameters.AddWithValue("@MK", txtMK.Text);
                if (_conn.State == ConnectionState.Closed)
                {
                    _conn.Open();
                }
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công");
                updateNV();
                txtMaNV.Clear();
                txtTenNV.Clear();
                txtSDT.Clear();
                cboGioiTinh.SelectedIndex = -1;
                txtTK.Clear();
                txtMK.Clear();
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
            if (string.IsNullOrEmpty(txtMaNV.Text))
            {
                MessageBox.Show("Vui lòng chọn một Nhân Viên để xóa.");
                return;
            }
            try
            {
                string xoaNV = "DELETE FROM NhanVien WHERE MaNV = @MaNV";
                SqlCommand sqlCommand = new SqlCommand(xoaNV, _conn);
                sqlCommand.Parameters.AddWithValue("@MaNV", txtMaNV.Text);
                if (_conn.State == ConnectionState.Closed)
                {
                    _conn.Open();
                }
                DialogResult dr = MessageBox.Show("Bạn thật sự muốn xóa sao?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công");
                    updateNV();
                    txtMaNV.Clear();
                    txtTenNV.Clear();
                    txtSDT.Clear();
                    cboGioiTinh.SelectedIndex = -1;
                    txtTK.Clear();
                    txtMK.Clear();
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
            if (string.IsNullOrEmpty(txtMaNV.Text))
            {
                MessageBox.Show("Vui lòng chọn một Nhân Viên để sửa và nhập Tên Nhân Viên, Số Điện Thoại, Giới Tính, Tài Khoản, Mật Khẩu mới.");
                return;
            }
            try
            {
                string query = "UPDATE NhanVien SET TenNV = @TenNVMoi, SDT = @SDTMoi, GioiTinh = @GioiTinhMoi, TK = @TKMoi, MK = @MKMoi WHERE MaNV = @MaNV";
                using (SqlCommand sqlCommand = new SqlCommand(query, _conn))
                {
                    sqlCommand.Parameters.AddWithValue("@MaNV", txtMaNV.Text);
                    sqlCommand.Parameters.AddWithValue("@TenNVMoi", txtTenNV.Text);
                    sqlCommand.Parameters.AddWithValue("@SDTMoi", txtSDT.Text);
                    sqlCommand.Parameters.AddWithValue("@GioiTinhMoi", cboGioiTinh.SelectedValue.ToString());
                    sqlCommand.Parameters.AddWithValue("@TKMoi", txtTK.Text);
                    sqlCommand.Parameters.AddWithValue("@MKMoi", txtMK.Text);
                    if (_conn.State == ConnectionState.Closed)
                    {
                        _conn.Open();
                    }
                    int rowsAffected = sqlCommand.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Sửa thành công");
                        updateNV();
                        txtMaNV.Clear();
                        txtTenNV.Clear();
                        txtSDT.Clear();
                        cboGioiTinh.SelectedIndex = -1;
                        txtTK.Clear();
                        txtMK.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy Nhân Viên để sửa");
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