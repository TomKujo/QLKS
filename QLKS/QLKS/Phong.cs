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
    public partial class frmPhong : Form
    {
        private SqlConnection _conn;

        public frmPhong()
        {
            InitializeComponent();
            _conn = new SqlConnection("Data Source=MSI\\SQLEXPRESS;Initial Catalog=QLKS;Integrated Security=True;TrustServerCertificate=True");
        }

        private void updatePhong()
        {
            try
            {
                if (_conn.State == ConnectionState.Closed)
                {
                    _conn.Open();
                }
                string selectPhong = "SELECT * FROM Phong";
                SqlDataAdapter adapter = new SqlDataAdapter(selectPhong, _conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvPhong.DataSource = dt;
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

        private void loadHangComboBox()
        {
            string query = "SELECT * FROM Phong";
            SqlDataAdapter da = new SqlDataAdapter(query, _conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cboHang.DisplayMember = "Hang";
            cboHang.ValueMember = "Hang";
            cboHang.DataSource = dt;
        }

        private void loadDatTruocComboBox()
        {
            string query = "SELECT * FROM Phong";
            SqlDataAdapter da = new SqlDataAdapter(query, _conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cboDatTruoc.DisplayMember = "DatTruoc";
            cboDatTruoc.ValueMember = "DatTruoc";
            cboDatTruoc.DataSource = dt;
        }

        private void frmPhong_Load(object sender, EventArgs e)
        {
            updatePhong();
            loadHangComboBox();
            loadDatTruocComboBox();
            cboHang.SelectedIndex = -1;
            cboDatTruoc.SelectedIndex = -1;
        }

        private bool IsMaPhongExist(string maPhong)
        {
            try
            {
                string checkQuery = "SELECT COUNT(*) FROM Phong WHERE MaPhong = @MaPhong";
                SqlCommand checkCmd = new SqlCommand(checkQuery, _conn);
                checkCmd.Parameters.AddWithValue("@MaPhong", maPhong);
                if (_conn.State == ConnectionState.Closed)
                {
                    _conn.Open();
                }
                int count = (int)checkCmd.ExecuteScalar();
                return count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi kiểm tra Mã Phòng: " + ex.Message);
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
            if (string.IsNullOrEmpty(txtMaPhong.Text) || string.IsNullOrEmpty(cboHang.SelectedValue.ToString()) || string.IsNullOrEmpty(txtSoGiuong.Text) || string.IsNullOrEmpty(txtGia.Text) || string.IsNullOrEmpty(cboDatTruoc.SelectedValue.ToString()))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã Phòng, Hạng, Số Giường, Giá, Đặt Trước.");
                return;
            }
            if (IsMaPhongExist(txtMaPhong.Text))
            {
                MessageBox.Show("Mã Phòng đã tồn tại. Vui lòng chọn Mã Phòng khác.");
                return;
            }
            try
            {
                string insertString = "INSERT INTO Phong VALUES(@MaPhong, @Hang, @SoGiuong, @Gia, @DatTruoc)";
                SqlCommand cmd = new SqlCommand(insertString, _conn);
                cmd.Parameters.AddWithValue("@MaPhong", txtMaPhong.Text);
                cmd.Parameters.AddWithValue("@Hang", cboHang.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@SoGiuong", txtSoGiuong.Text);
                cmd.Parameters.AddWithValue("@Gia", txtGia.Text);
                cmd.Parameters.AddWithValue("@DatTruoc", cboDatTruoc.SelectedValue.ToString());
                if (_conn.State == ConnectionState.Closed)
                {
                    _conn.Open();
                }
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công");
                updatePhong();
                txtMaPhong.Clear();
                cboHang.SelectedIndex = -1;
                txtSoGiuong.Clear();
                txtGia.Clear();
                cboDatTruoc.SelectedIndex = -1;
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

        private void dgvPhong_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtMaPhong.Text = dgvPhong.Rows[e.RowIndex].Cells["MaPhong"].Value.ToString();
            cboHang.SelectedValue = dgvPhong.Rows[e.RowIndex].Cells["Hang"].Value.ToString();
            txtSoGiuong.Text = dgvPhong.Rows[e.RowIndex].Cells["SoGiuong"].Value.ToString();
            txtGia.Text = dgvPhong.Rows[e.RowIndex].Cells["Gia"].Value.ToString();
            cboDatTruoc.SelectedValue = dgvPhong.Rows[e.RowIndex].Cells["DatTruoc"].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaPhong.Text))
            {
                MessageBox.Show("Vui lòng chọn một Phòng để sửa và nhập Hạng, Số Giường, Giá, Đặt Trước mới.");
                return;
            }
            try
            {
                string query = "UPDATE Phong SET Hang = @HangMoi, SoGiuong = @SoGiuongMoi, Gia = @GiaMoi, DatTruoc = @DatTruocMoi WHERE MaPhong = @MaPhong";
                using (SqlCommand sqlCommand = new SqlCommand(query, _conn))
                {
                    sqlCommand.Parameters.AddWithValue("@MaPhong", txtMaPhong.Text);
                    sqlCommand.Parameters.AddWithValue("@HangMoi", cboHang.SelectedValue.ToString());
                    sqlCommand.Parameters.AddWithValue("@SoGiuongMoi", txtSoGiuong.Text);
                    sqlCommand.Parameters.AddWithValue("@GiaMoi", txtGia.Text);
                    sqlCommand.Parameters.AddWithValue("@DatTruocMoi", cboDatTruoc.SelectedValue.ToString());
                    if (_conn.State == ConnectionState.Closed)
                    {
                        _conn.Open();
                    }
                    int rowsAffected = sqlCommand.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Sửa thành công");
                        updatePhong();
                        txtMaPhong.Clear();
                        cboHang.SelectedIndex = -1;
                        txtSoGiuong.Clear();
                        txtGia.Clear();
                        cboDatTruoc.SelectedIndex = -1;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy Phòng để sửa");
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaPhong.Text))
            {
                MessageBox.Show("Vui lòng chọn một Phòng để xóa.");
                return;
            }
            try
            {
                string xoaPhong = "DELETE FROM Phong WHERE MaPhong = @MaPhong";
                SqlCommand sqlCommand = new SqlCommand(xoaPhong, _conn);
                sqlCommand.Parameters.AddWithValue("@MaPhong", txtMaPhong.Text);
                if (_conn.State == ConnectionState.Closed)
                {
                    _conn.Open();
                }
                DialogResult dr = MessageBox.Show("Bạn thật sự muốn xóa sao?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công");
                    updatePhong();
                    txtMaPhong.Clear();
                    cboHang.SelectedIndex = -1;
                    txtSoGiuong.Clear();
                    txtGia.Clear();
                    cboDatTruoc.SelectedIndex = -1;
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

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            frmChucNang frmChucNang = new frmChucNang();
            frmChucNang.Show();
            //this.Hide();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (dgvPhong.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một Phòng để thanh toán.");
                return;
            }
            try
            {
                DataGridViewRow selectedRow = dgvPhong.SelectedRows[0];
                if (selectedRow.Cells["Gia"].Value == null)
                {
                    MessageBox.Show("Không tìm thấy Giá.");
                    return;
                }
                double giaPhong = Convert.ToDouble(selectedRow.Cells["Gia"].Value);
                double tongDoanhThu = 0;
                string filePath = "DoanhThu.txt";
                if (File.Exists(filePath))
                {
                    string doanhThuText = File.ReadAllText(filePath);
                    if (!string.IsNullOrEmpty(doanhThuText))
                    {
                        tongDoanhThu = Convert.ToDouble(doanhThuText);
                    }
                }
                tongDoanhThu += giaPhong;
                File.WriteAllText(filePath, tongDoanhThu.ToString());
                MessageBox.Show("Thanh toán thành công. Tổng doanh thu đã được cập nhật.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thanh toán: " + ex.Message);
            }
            finally
            {
                if (_conn.State == ConnectionState.Open)
                {
                    _conn.Close();
                }
            }
        }
    }
}