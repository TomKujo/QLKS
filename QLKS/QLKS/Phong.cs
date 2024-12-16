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
            _conn = new SqlConnection("Data Source=DESKTOP-HDPCSE2\\SQLEXPRESS;Initial Catalog=QLKS;Integrated Security=True;TrustServerCertificate=True");
        }

        public void updatePhong(string tinhTrang = "Tất cả")
        {
            try
            {
                if (_conn.State == ConnectionState.Closed)
                {
                    _conn.Open();
                }
                string selectPhong = "SELECT * FROM Phong";
                SqlCommand cmd = new SqlCommand(selectPhong, _conn);
                if (tinhTrang != "Tất cả")
                {
                    selectPhong += " WHERE TinhTrang = @TinhTrang";
                    cmd.CommandText = selectPhong;
                    cmd.Parameters.AddWithValue("@TinhTrang", tinhTrang);
                }
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
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

        private void loadTinhTrangComboBox()
        {
            cboHienThi.Items.Clear();
            cboHienThi.Items.Add("Trống");
            cboHienThi.Items.Add("Không trống");
        }

        private void loadHangComboBox()
        {
            cboHienThi.Items.Clear();
            cboHienThi.Items.Add("Phổ thông");
            cboHienThi.Items.Add("Thương gia");
        }

        private void loadDatTruocComboBox()
        {
            cboHienThi.Items.Clear();
            cboHienThi.Items.Add("Chưa đặt trước");
            cboHienThi.Items.Add("Đã đặt trước");
        }

        private void loadHienThiComboBox()
        {
            cboHienThi.Items.Clear();
            cboHienThi.Items.Add("Tất cả");
            cboHienThi.Items.Add("Trống");
            cboHienThi.Items.Add("Không trống");
        }

        private void frmPhong_Load(object sender, EventArgs e)
        {
            updatePhong();
            loadHangComboBox();
            loadDatTruocComboBox();
            loadTinhTrangComboBox();
            loadHienThiComboBox();
            cboHang.SelectedIndex = -1;
            cboDatTruoc.SelectedIndex = -1;
            cboTinhTrang.SelectedIndex = -1;
            cboHienThi.SelectedIndex = 0;
            cboHienThi.SelectedIndexChanged += cboHienThi_SelectedIndexChanged;
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
            if (string.IsNullOrWhiteSpace(txtMaPhong.Text) || cboTinhTrang.SelectedItem == null || cboHang.SelectedItem == null || string.IsNullOrWhiteSpace(txtSoGiuong.Text) || string.IsNullOrWhiteSpace(txtGia.Text) || cboDatTruoc.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã Phòng, Tình Trạng, Hạng, Số Giường, Giá, Đặt Trước.");
                return;
            }
            if (IsMaPhongExist(txtMaPhong.Text))
            {
                MessageBox.Show("Mã Phòng đã tồn tại. Vui lòng chọn Mã Phòng khác.");
                return;
            }
            try
            {
                string insertString = "INSERT INTO Phong VALUES(@MaPhong, @TinhTrang, @Hang, @SoGiuong, @Gia, @DatTruoc)";
                SqlCommand cmd = new SqlCommand(insertString, _conn);
                cmd.Parameters.AddWithValue("@MaPhong", txtMaPhong.Text);
                cmd.Parameters.AddWithValue("@TinhTrang", cboTinhTrang.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Hang", cboHang.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@SoGiuong", txtSoGiuong.Text);
                cmd.Parameters.AddWithValue("@Gia", txtGia.Text);
                cmd.Parameters.AddWithValue("@DatTruoc", cboDatTruoc.SelectedItem.ToString());
                if (_conn.State == ConnectionState.Closed)
                {
                    _conn.Open();
                }
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công");
                updatePhong();
                txtMaPhong.Clear();
                cboTinhTrang.SelectedIndex = -1;
                cboHang.SelectedIndex = -1;
                txtSoGiuong.Clear();
                txtGia.Clear();
                cboDatTruoc.SelectedIndex = -1;
                cboHienThi.SelectedIndex = 0;
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
            cboTinhTrang.SelectedValue = dgvPhong.Rows[e.RowIndex].Cells["TinhTrang"].Value.ToString();
            cboHang.SelectedValue = dgvPhong.Rows[e.RowIndex].Cells["Hang"].Value.ToString();
            txtSoGiuong.Text = dgvPhong.Rows[e.RowIndex].Cells["SoGiuong"].Value.ToString();
            txtGia.Text = dgvPhong.Rows[e.RowIndex].Cells["Gia"].Value.ToString();
            cboDatTruoc.SelectedValue = dgvPhong.Rows[e.RowIndex].Cells["DatTruoc"].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaPhong.Text))
            {
                MessageBox.Show("Vui lòng chọn một Phòng để sửa và nhập Tình Trạng, Hạng, Số Giường, Giá, Đặt Trước mới.");
                return;
            }
            if (!IsMaPhongExist(txtMaPhong.Text))
            {
                MessageBox.Show("Mã Phòng không hợp lệ");
                return;
            }
            try
            {
                string query = "UPDATE Phong SET TinhTrang = @TinhTrangMoi, Hang = @HangMoi, SoGiuong = @SoGiuongMoi, Gia = @GiaMoi, DatTruoc = @DatTruocMoi WHERE MaPhong = @MaPhong";
                using (SqlCommand sqlCommand = new SqlCommand(query, _conn))
                {
                    sqlCommand.Parameters.AddWithValue("@MaPhong", txtMaPhong.Text);
                    sqlCommand.Parameters.AddWithValue("@TinhTrangMoi", cboTinhTrang.SelectedItem?.ToString());
                    sqlCommand.Parameters.AddWithValue("@HangMoi", cboHang.SelectedItem?.ToString());
                    sqlCommand.Parameters.AddWithValue("@SoGiuongMoi", txtSoGiuong.Text);
                    sqlCommand.Parameters.AddWithValue("@GiaMoi", txtGia.Text);
                    sqlCommand.Parameters.AddWithValue("@DatTruocMoi", cboDatTruoc.SelectedItem?.ToString());
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
                        cboTinhTrang.SelectedIndex = -1;
                        cboHang.SelectedIndex = -1;
                        txtSoGiuong.Clear();
                        txtGia.Clear();
                        cboDatTruoc.SelectedIndex = -1;
                        cboHienThi.SelectedIndex = 0;
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
            if (string.IsNullOrWhiteSpace(txtMaPhong.Text))
            {
                MessageBox.Show("Vui lòng chọn một Phòng để xóa.");
                return;
            }
            if (!IsMaPhongExist(txtMaPhong.Text))
            {
                MessageBox.Show("Mã Phòng không hợp lệ");
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
                    cboTinhTrang.SelectedIndex = -1;
                    cboHang.SelectedIndex = -1;
                    txtSoGiuong.Clear();
                    txtGia.Clear();
                    cboDatTruoc.SelectedIndex = -1;
                    cboHienThi.SelectedIndex = 0;
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
                string maPhong = selectedRow.Cells["MaPhong"].Value.ToString();
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
                    if (!string.IsNullOrWhiteSpace(doanhThuText))
                    {
                        tongDoanhThu = Convert.ToDouble(doanhThuText);
                    }
                }
                tongDoanhThu += giaPhong;
                File.WriteAllText(filePath, tongDoanhThu.ToString());
                string updateQuery = "UPDATE Phong SET TinhTrang = N'Trống' WHERE MaPhong = @MaPhong";
                SqlCommand cmd = new SqlCommand(updateQuery, _conn);
                cmd.Parameters.AddWithValue("@MaPhong", txtMaPhong.Text);
                if (_conn.State == ConnectionState.Closed)
                {
                    _conn.Open();
                }
                cmd.ExecuteNonQuery();
                frmKH frmKhachHang = Application.OpenForms["frmKH"] as frmKH;
                if (frmKhachHang != null)
                {
                    frmKhachHang.xoaKHTheoPhong(maPhong);
                }
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

        private void cboHienThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboHienThi.SelectedIndex != -1)
            {
                string hienThi = cboHienThi.SelectedItem.ToString();
                if (hienThi == "Tất cả")
                {
                    updatePhong("Tất cả");
                }
                else if (hienThi == "Trống" || hienThi == "Không trống")
                {
                    updatePhong(hienThi);
                }
            }
        }
    }
}