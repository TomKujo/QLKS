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
using System.ComponentModel.DataAnnotations;
using Microsoft.IdentityModel.Tokens;

namespace QLKS
{
    public partial class NhanVienPage : UserControl
    {
        private SqlConnection _conn;
        private DataTable _nhanVienTable;
        public NhanVienPage()
        {
            InitializeComponent();
            _conn = new SqlConnection("Data Source=DESKTOP-HDPCSE2\\SQLEXPRESS;Initial Catalog=QLKS;Integrated Security=True;TrustServerCertificate=True");
            loadViTri();
            loadNhanVien();
            loadLoaiViTri();
        }

        private void loadViTri()
        {
            string query = "SELECT TenVT FROM ViTri";
            SqlCommand cmd = new SqlCommand(query, _conn);
            _conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            viTriCB.Items.Clear();
            capNhatViTriCB.Items.Clear();
            capNhatViTriCB1.Items.Clear();
            timViTriCB.Items.Clear();
            timViTriCB.Items.Add("Tất cả");
            while (dr.Read())
            {
                viTriCB.Items.Add(dr["TenVT"].ToString());
                capNhatViTriCB.Items.Add(dr["TenVT"].ToString());
                capNhatViTriCB1.Items.Add(dr["TenVT"].ToString());
                timViTriCB.Items.Add(dr["TenVT"].ToString());
            }
            _conn.Close();
        }

        private void loadLoaiViTri()
        {
            string query = "SELECT * FROM ViTri";
            SqlCommand cmd = new SqlCommand(query, _conn);
            _conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(dr);
            loaiPhongView.DataSource = dataTable;
            _conn.Close();
        }

        private void loadNhanVien()
        {
            string query = @"
        SELECT 
            nv.MaNV, nv.TenNV, nv.SDT, nv.Email, nv.Luong, nv.NgayVaoLam,
            vt.TenVT, vt.LuongCoBan,
            tk.TenTK,
            tk.MatKhau
        FROM 
            NhanVien nv
        JOIN 
            ViTri vt ON nv.MaVT = vt.MaVT
        JOIN
            TaiKhoan tk ON nv.MaNV = tk.MaNV";

            try
            {
                SqlCommand cmd = new SqlCommand(query, _conn);
                _conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                _nhanVienTable = new DataTable();
                _nhanVienTable.Load(dr);

                foreach (DataRow row in _nhanVienTable.Rows)
                {
                    DateTime ngayVaoLam = Convert.ToDateTime(row["NgayVaoLam"]);
                    int soNamLam = CalculateYearsWorked(ngayVaoLam);
                    int luongCoBan = Convert.ToInt32(row["LuongCoBan"]);
                    int calculatedSalary = luongCoBan + soNamLam * 1000000;
                    row["Luong"] = calculatedSalary;
                }

                _nhanVienTable.Columns.Remove("LuongCoBan");

                nhanVienView.DataSource = _nhanVienTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                _conn.Close();
            }
        }

        private void findNhanVienFilter()
        {
            if (_nhanVienTable == null)
                return;

            string tenNVFilter = timTheoTenKH.Text.Trim();
            string viTriFilter = timViTriCB.SelectedIndex > 0 ? timViTriCB.SelectedItem.ToString() : "";

            if (string.IsNullOrEmpty(tenNVFilter) && string.IsNullOrEmpty(viTriFilter))
            {
                nhanVienView.DataSource = _nhanVienTable;
                return;
            }

            string filterExpression = "";

            if (!string.IsNullOrEmpty(tenNVFilter))
            {
                filterExpression += $"TenNV LIKE '%{tenNVFilter}%'";
            }

            if (!string.IsNullOrEmpty(viTriFilter))
            {
                if (!string.IsNullOrEmpty(filterExpression))
                {
                    filterExpression += " AND ";
                }
                filterExpression += $"TenVT = '{viTriFilter}'";
            }

            DataView dv = new DataView(_nhanVienTable);
            dv.RowFilter = filterExpression;
            nhanVienView.DataSource = dv;
        }

        private int CalculateYearsWorked(DateTime startDate)
        {
            DateTime currentDate = DateTime.Now;
            int yearsWorked = currentDate.Year - startDate.Year;
            if (currentDate < startDate.AddYears(yearsWorked))
            {
                yearsWorked--;
            }
            return yearsWorked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tenNV.Text) || string.IsNullOrEmpty(SDT.Text) || string.IsNullOrEmpty(Email.Text) || string.IsNullOrEmpty(viTriCB.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            if (SDT.Text.Length != 10)
            {
                MessageBox.Show("Số điện thoại không hợp lệ");
                return;
            }
            if (new EmailAddressAttribute().IsValid(Email.Text) == false)
            {
                MessageBox.Show("Email không hợp lệ");
                return;
            }
            else
            {
                if (checkExistNhanVien(tenNV.Text))
                {
                    MessageBox.Show("Nhân viên đã tồn tại");
                    return;
                }
                else
                {
                    string query = @"
                    INSERT INTO NhanVien(TenNV, SDT, Email, Luong, NgayVaoLam, MaVT)
                    VALUES(@tenNV, @SDT, @Email, @Luong, @NgayVaoLam, @MaVT)";
                    SqlCommand cmd = new SqlCommand(query, _conn);
                    int maVT = Convert.ToInt32(getMaViTri(viTriCB.SelectedItem.ToString()));
                    string luong = getLuongCoBan(maVT);
                    cmd.Parameters.AddWithValue("@tenNV", tenNV.Text);
                    cmd.Parameters.AddWithValue("@SDT", SDT.Text);
                    cmd.Parameters.AddWithValue("@Email", Email.Text);
                    cmd.Parameters.AddWithValue("@Luong", luong);
                    cmd.Parameters.AddWithValue("@NgayVaoLam", DateTime.Now);
                    cmd.Parameters.AddWithValue("@MaVT", maVT);
                    _conn.Open();
                    cmd.ExecuteNonQuery();
                    _conn.Close();
                    string maNV = getMaNV(tenNV.Text);
                    taoTaiKhoanNV(maNV);
                    loadNhanVien();
                    string message = @"Thêm nhân viên thành công
Tên tài khoản: " + tenNV.Text + @" 
Mật khẩu: " + "123456";
                    MessageBox.Show(message);
                }
            }
        }

        private string getMaNV(string tenNV)
        {
            string query = "SELECT MaNV FROM NhanVien WHERE TenNV = @tenNV";
            SqlCommand cmd = new SqlCommand(query, _conn);
            cmd.Parameters.AddWithValue("@tenNV", tenNV);
            _conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            string maNV = dr["MaNV"].ToString();
            _conn.Close();
            return maNV;
        }

        private void taoTaiKhoanNV(string maNV)
        {
            string query = @"
            INSERT INTO TaiKhoan(MaNV, TenTK, MatKhau)
            VALUES(@maNV, @tenTK, @matKhau)";
            SqlCommand cmd = new SqlCommand(query, _conn);
            cmd.Parameters.AddWithValue("@maNV", maNV);
            cmd.Parameters.AddWithValue("@tenTK", tenNV.Text);
            cmd.Parameters.AddWithValue("@matKhau", "123456");
            _conn.Open();
            cmd.ExecuteNonQuery();
            _conn.Close();
        }

        private string getLuongCoBan(int maVT)
        {
            string query = "SELECT LuongCoBan FROM ViTri WHERE MaVT = @maVT";
            SqlCommand cmd = new SqlCommand(query, _conn);
            cmd.Parameters.AddWithValue("@maVT", viTriCB.SelectedIndex);
            _conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            string luongCoBan = dr["LuongCoBan"].ToString();
            _conn.Close();
            return luongCoBan;
        }

        private bool checkExistNhanVien(string tenNV)
        {
            string query = "SELECT * FROM NhanVien WHERE TenNV = @tenNV";
            SqlCommand cmd = new SqlCommand(query, _conn);
            cmd.Parameters.AddWithValue("@tenNV", tenNV);
            _conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            bool exist = dr.HasRows;
            _conn.Close();
            return exist;
        }

        private void timTheoTenKH_TextChanged(object sender, EventArgs e)
        {
            findNhanVienFilter();
        }

        private void timViTriCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            findNhanVienFilter();
        }

        private bool checkExistLoaiViTri(string tenVT)
        {
            string query = "SELECT * FROM ViTri WHERE TenVT = @tenVT";
            SqlCommand cmd = new SqlCommand(query, _conn);
            cmd.Parameters.AddWithValue("@tenVT", tenVT);
            _conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            bool exist = dr.HasRows;
            _conn.Close();
            return exist;
        }

        private void ThemLoaiViTriButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(themTenVTTB.Text) || string.IsNullOrEmpty(themLCBTB.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên và lương cơ bản");
                return;
            }
            if (checkExistLoaiViTri(themTenVTTB.Text))
            {
                MessageBox.Show("Loại vị trí đã tồn tại");
                return;
            }
            else
            {
                string query = @"
                INSERT INTO ViTri(TenVT, LuongCoBan, MoTaVT)
                VALUES(@tenVT, @luongCoBan, @moTaVT)";
                SqlCommand cmd = new SqlCommand(query, _conn);
                cmd.Parameters.AddWithValue("@tenVT", themTenVTTB.Text);
                cmd.Parameters.AddWithValue("@luongCoBan", themLCBTB.Text);
                string moTa = string.IsNullOrEmpty(themMoTaVTTB.Text) ? "Không có" : themMoTaVTTB.Text;
                cmd.Parameters.AddWithValue("@moTaVT", moTa);
                _conn.Open();
                cmd.ExecuteNonQuery();
                _conn.Close();
                loadLoaiViTri();
                MessageBox.Show("Thêm loại vị trí thành công");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label15.Visible = true;
                capNhatTenKH.Visible = true;
                label14.Visible = true;
                capNhatSDT.Visible = true;
                label11.Visible = true;
                capNhatEmail.Visible = true;
                label7.Visible = true;
                capNhatViTriCB.Visible = true;
                CapNhatKH.BackColor = Color.Lime;
                CapNhatKH.Text = "Cập nhật";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                label15.Visible = false;
                capNhatTenKH.Visible = false;
                label14.Visible = false;
                capNhatSDT.Visible = false;
                label11.Visible = false;
                capNhatEmail.Visible = false;
                label7.Visible = false;
                capNhatViTriCB.Visible = false;
                CapNhatKH.BackColor = Color.Red;
                CapNhatKH.Text = "Xóa";
            }
        }

        private bool checkExitsNhanVienByMaNV(string maNV)
        {
            string query = "SELECT * FROM NhanVien WHERE MaNV = @maNV";
            SqlCommand cmd = new SqlCommand(query, _conn);
            cmd.Parameters.AddWithValue("@maNV", maNV);
            _conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            bool exist = dr.HasRows;
            _conn.Close();
            return exist;
        }

        private void CapNhatKH_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if(maNV.Text == "")
                {
                    MessageBox.Show("Vui lòng chọn nhân viên cần cập nhật");
                    return;
                }
                if (capNhatSDT.Text != "")
                {
                    if (capNhatSDT.Text.Length != 10)
                    {
                        MessageBox.Show("Số điện thoại không hợp lệ");
                        return;
                    }
                }
                if(capNhatEmail.Text != "")
                {
                    if (new EmailAddressAttribute().IsValid(capNhatEmail.Text) == false)
                    {
                        MessageBox.Show("Email không hợp lệ");
                        return;
                    }
                }
                else
                {
                    if (!checkExitsNhanVienByMaNV(maNV.Text))
                    {
                        MessageBox.Show("Nhân viên không tồn tại");
                        return;
                    }
                    else
                    {
                        string query = "SELECT * FROM NhanVien WHERE MaNV = @maNV";
                        SqlCommand cmd = new SqlCommand(query, _conn);
                        cmd.Parameters.AddWithValue("@maNV", maNV.Text);
                        _conn.Open();
                        SqlDataReader dr = cmd.ExecuteReader();
                        dr.Read();
                        NhanVien nhanVien = new NhanVien
                        {
                            MaNV = dr["MaNV"].ToString(),
                            TenNV = dr["TenNV"].ToString(),
                            SDT = dr["SDT"].ToString(),
                            Email = dr["Email"].ToString(),
                            MaVT = Convert.ToInt32(dr["MaVT"].ToString()),
                            Luong = Convert.ToInt32(dr["Luong"].ToString())
                        };
                        _conn.Close();

                        query = @"
                        UPDATE NhanVien
                        SET TenNV = @tenNV, SDT = @SDT, Email = @Email, MaVT = @MaVT
                        WHERE MaNV = @maNV";
                        cmd = new SqlCommand(query, _conn);
                        cmd.Parameters.AddWithValue("@tenNV", capNhatTenKH.Text != "" ? capNhatTenKH.Text : nhanVien.TenNV);
                        cmd.Parameters.AddWithValue("@SDT", capNhatSDT.Text != "" ? capNhatSDT.Text : nhanVien.SDT);
                        cmd.Parameters.AddWithValue("@Email", capNhatEmail.Text != "" ? capNhatEmail.Text : nhanVien.Email);
                        cmd.Parameters.AddWithValue("@MaVT", getMaViTri(capNhatViTriCB.SelectedItem.ToString()));
                        cmd.Parameters.AddWithValue("@maNV", maNV.Text);
                        _conn.Open();
                        cmd.ExecuteNonQuery();
                        _conn.Close();
                        loadNhanVien();
                        MessageBox.Show("Cập nhật nhân viên thành công");
                    }
                }
            }
            else if (radioButton2.Checked)
            {
                if (string.IsNullOrEmpty(maNV.Text))
                {
                    MessageBox.Show("Vui lòng chọn nhân viên cần xóa");
                    return;
                }
                else
                {
                    if (!checkExitsNhanVienByMaNV(maNV.Text))
                    {
                        MessageBox.Show("Nhân viên không tồn tại");
                        return;
                    }
                    else
                    {
                        string query = "DELETE FROM NhanVien WHERE MaNV = @maNV";
                        SqlCommand cmd = new SqlCommand(query, _conn);
                        cmd.Parameters.AddWithValue("@maNV", maNV.Text);
                        _conn.Open();
                        cmd.ExecuteNonQuery();
                        _conn.Close();
                        loadNhanVien();
                        MessageBox.Show("Xóa nhân viên thành công");
                    }
                }
            }
        }

        private string getMaViTri(string tenVT)
        {
            string query = "SELECT MaVT FROM ViTri WHERE TenVT = @tenVT";
            SqlCommand cmd = new SqlCommand(query, _conn);
            cmd.Parameters.AddWithValue("@tenVT", tenVT);
            _conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            string maVT;
            dr.Read();
            maVT = dr["MaVT"].ToString();
            _conn.Close();
            return maVT;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                label19.Visible = true;
                capNhatLCBTB.Visible = true;
                label18.Visible = true;
                capNhatMoTaTB.Visible = true;
                CapNhatLoaiViTriButton.BackColor = Color.Lime;
                CapNhatLoaiViTriButton.Text = "Cập nhật";
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                label19.Visible = false;
                capNhatLCBTB.Visible = false;
                label18.Visible = false;
                capNhatMoTaTB.Visible = false;
                CapNhatLoaiViTriButton.BackColor = Color.Red;
                CapNhatLoaiViTriButton.Text = "Xóa";
            }
        }

        private void CapNhatLoaiViTriButton_Click(object sender, EventArgs e)
        {
            if (capNhatViTriCB1.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn loại vị trí cần cập nhật");
                return;
            }
            else
            {
                if (radioButton4.Checked)
                {
                    if(string.IsNullOrEmpty(capNhatLCBTB.Text))
                    {
                        MessageBox.Show("Vui lòng nhập lương cơ bản");
                        return;
                    }
                    else
                    {
                        string query = @"
                        UPDATE ViTri
                        SET LuongCoBan = @luongCoBan, MoTaVT = @moTaVT
                        WHERE MaVT = @maVT";
                        SqlCommand cmd = new SqlCommand(query, _conn);
                        cmd.Parameters.AddWithValue("@luongCoBan", capNhatLCBTB.Text);
                        string moTa = string.IsNullOrEmpty(capNhatMoTaTB.Text) ? "Không có" : capNhatMoTaTB.Text;
                        cmd.Parameters.AddWithValue("@moTaVT", moTa);
                        cmd.Parameters.AddWithValue("@maVT", getMaViTri(capNhatViTriCB1.SelectedItem.ToString()));
                        _conn.Open();
                        cmd.ExecuteNonQuery();
                        _conn.Close();
                        loadLoaiViTri();
                        loadViTri();
                        MessageBox.Show("Cập nhật loại vị trí thành công");
                    }
                }
                else if (radioButton3.Checked)
                {
                    string query = "DELETE FROM ViTri WHERE MaVT = @maVT";
                    SqlCommand cmd = new SqlCommand(query, _conn);
                    cmd.Parameters.AddWithValue("@maVT", getMaViTri(capNhatViTriCB1.SelectedItem.ToString()));
                    _conn.Open();
                    cmd.ExecuteNonQuery();
                    _conn.Close();
                    loadLoaiViTri();
                    loadViTri();
                    MessageBox.Show("Xóa loại vị trí thành công");
                }
            }
        }             
    }
}
