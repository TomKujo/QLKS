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
using System.Drawing.Text;
using System.Collections;
using QLKS.Model;

namespace QLKS
{
    public partial class PhongPage : UserControl
    {
        private SqlConnection _conn;
        private DataTable phongTable;
        public PhongPage()
        {
            InitializeComponent();
            _conn = new SqlConnection("Data Source=DESKTOP-HDPCSE2\\SQLEXPRESS;Initial Catalog=QLKS;Integrated Security=True;TrustServerCertificate=True");
            timKiemLPCB.Items.Add("Tất cả");
            timKiemTinhTrangCB.Items.Add("Tất cả");
            timKiemTinhTrangCB.SelectedIndex = 0;
            timKiemLPCB.SelectedIndex = 0;
            CapNhatLoaiPhong();
            CapNhatTinhTrang();
            ShowPhong();
            showLoaiPhong();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                if (!loaiPhongCB.Visible)
                {
                    loaiPhongLB.Visible = true;
                    loaiPhongCB.Visible = true;
                    //loaiPhongCB.SelectedIndex = 0;
                }
            }
            else
            {
                loaiPhongLB.Visible = false;
                loaiPhongCB.Visible = false;
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
            {
                if (!maPhongCB.Visible)
                {
                    maPhongLB.Visible = true;
                    maPhongCB.Visible = true;
                    maPhongCB.Clear();
                }
            }
            else
            {
                maPhongLB.Visible = false;
                maPhongCB.Visible = false;
            }
        }

        private void CapNhatLoaiPhong()
        {
            loaiPhongCB.Items.Clear();
            string query = "SELECT * FROM LoaiPhong";
            SqlCommand cmd = new SqlCommand(query, _conn);
            _conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                loaiPhongCB.Items.Add(dr["TenLP"].ToString());
                timKiemLPCB.Items.Add(dr["TenLP"].ToString());
                themPhongLPCB.Items.Add(dr["TenLP"].ToString());
            }
            _conn.Close();
        }

        private void CapNhatTinhTrang()
        {
            string query = "SELECT TinhTrang FROM Phong";
            SqlCommand cmd = new SqlCommand(query, _conn);
            _conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (!timKiemTinhTrangCB.Items.Contains(dr["TinhTrang"].ToString()))
                    timKiemTinhTrangCB.Items.Add(dr["TinhTrang"].ToString());
            }
            _conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (SDT.Text == "" || Email.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                return;
            }
            if (SDT.Text.Length != 10)
            {
                MessageBox.Show("Số điện thoại không hợp lệ");
                return;
            }
            if (!new EmailAddressAttribute().IsValid(Email.Text))
            {
                MessageBox.Show("Email không hợp lệ");
                return;
            }
            if (radioButton5.Checked)
            {
                if (loaiPhongCB.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn loại phòng");
                    return;
                }
                if (!checkLP())
                {
                    return;
                }
            }
            else
            {
                if (maPhongCB.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập mã phòng");
                    return;
                }
                if (!CheckPhong(maPhongCB.Text))
                {
                    return;
                }
            }
            string maKHexit = KhachHangExists(SDT.Text, Email.Text);
            int tongTien = GetGiaTien();
            string maPhong = maPhongCB.Text != string.Empty ? maPhongCB.Text : GetMaPhongByLoaiPhong(loaiPhongCB.SelectedItem.ToString());
            if (maKHexit != string.Empty)
            {
                string queryDatPhong = "INSERT INTO DatPhong(MaKH, MaPhong, TongTien, TinhTrang) VALUES(@maKH, @maPhong, @TongTien, @tinhTrang)";
                SqlCommand cmd = new SqlCommand(queryDatPhong, _conn);
                _conn.Open();
                cmd.Parameters.AddWithValue("@maKH", maKHexit);
                cmd.Parameters.AddWithValue("@maPhong", maPhong);
                cmd.Parameters.AddWithValue("@TongTien", tongTien);
                cmd.Parameters.AddWithValue("@tinhTrang", "chưa trả");
                cmd.ExecuteNonQuery();
                _conn.Close();
                string queryUpdatePhong = "UPDATE Phong SET TinhTrang = @tinhTrang WHERE MaPhong = @maPhong";
                SqlCommand cmdUpdatePhong = new SqlCommand(queryUpdatePhong, _conn);
                _conn.Open();
                cmdUpdatePhong.Parameters.AddWithValue("@tinhTrang", "không trống");
                cmdUpdatePhong.Parameters.AddWithValue("@maPhong", maPhong);
                cmdUpdatePhong.ExecuteNonQuery();
                _conn.Close();
                MessageBox.Show("Đặt phòng thành công");
                ShowPhong();
                return;
            }
            else
            {
                string error = @"Khách hàng chưa tồn tại!
Nếu muốn thêm khách mới hãy thêm ở mục Khách Hàng
Nếu khách hàng đã tồn tại hãy kiểm tra Email và SĐT";
                MessageBox.Show(error);
                return;
            }

        }

        private int GetGiaTien()
        {
            try
            {
                string query;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;

                if (radioButton5.Checked && loaiPhongCB.SelectedIndex != -1)
                {
                    query = @"
                SELECT lp.GiaTien 
                FROM LoaiPhong lp
                WHERE lp.TenLP = @tenLP";
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@tenLP", loaiPhongCB.SelectedItem.ToString());
                }
                else if (radioButton6.Checked && !string.IsNullOrEmpty(maPhongCB.Text))
                {
                    query = @"
                SELECT lp.GiaTien 
                FROM Phong p
                JOIN LoaiPhong lp ON p.MaLP = lp.MaLP
                WHERE p.MaPhong = @maPhong";
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@maPhong", maPhongCB.Text);
                }
                else
                {
                    throw new Exception("Vui lòng chọn loại phòng hoặc nhập mã phòng");
                }

                _conn.Open();
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    return Convert.ToInt32(result);
                }
                else
                {
                    throw new Exception("Không tìm thấy giá tiền cho phòng đã chọn");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return 0;
            }
            finally
            {
                _conn.Close();
            }
        }

        private string KhachHangExists(string sdt, string email)
        {
            string queryMaKH = "SELECT MaKH FROM KhachHang WHERE SDT = @sdt AND Email = @email";
            SqlCommand cmd = new SqlCommand(queryMaKH, _conn);
            _conn.Open();
            cmd.Parameters.AddWithValue("@sdt", SDT.Text);
            cmd.Parameters.AddWithValue("@email", Email.Text);
            int maKH = Convert.ToInt32(cmd.ExecuteScalar());
            _conn.Close();
            return maKH != 0 ? maKH.ToString() : string.Empty;
        }

        private bool CheckPhong(string maPhong)
        {
            try
            {
                string query = "SELECT TinhTrang FROM Phong WHERE MaPhong = @maPhong";
                SqlCommand cmd = new SqlCommand(query, _conn);
                cmd.Parameters.AddWithValue("@maPhong", maPhong);
                _conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string trangThai = reader["TinhTrang"].ToString();
                    if (trangThai == "không trống")
                    {
                        MessageBox.Show("Phòng đã có người ở");
                        return false;
                    }
                    return true;
                }
                else
                {
                    MessageBox.Show("Phòng không tồn tại");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
            finally
            {
                _conn.Close();
            }
        }

        private bool checkLP()
        {
            try
            {
                string query = @"
                SELECT COUNT(*) 
                FROM Phong p
                JOIN LoaiPhong lp ON p.MaLP = lp.MaLP
                WHERE lp.TenLP = @tenLP AND p.TinhTrang != @tinhTrang";

                SqlCommand cmd = new SqlCommand(query, _conn);
                string tinhTrang = "không trống";
                cmd.Parameters.AddWithValue("@tenLP", loaiPhongCB.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@tinhTrang", tinhTrang);
                _conn.Open();
                int availableRooms = (int)cmd.ExecuteScalar();

                if (availableRooms == 0)
                {
                    MessageBox.Show("Đã hết phòng loại này");
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
            finally
            {
                _conn.Close();
            }
        }

        private string GetMaPhongByLoaiPhong(string tenLP)
        {
            string query = @"
                SELECT TOP 1 p.MaPhong
                FROM Phong p
                JOIN LoaiPhong lp ON p.MaLP = lp.MaLP
                WHERE lp.TenLP = @tenLP AND p.TinhTrang = @tinhTrang";
            SqlCommand cmd = new SqlCommand(query, _conn);
            string tinhTrang = "trống";
            cmd.Parameters.AddWithValue("@tenLP", tenLP);
            cmd.Parameters.AddWithValue("@tinhTrang", tinhTrang);
            _conn.Open();
            int result = Convert.ToInt32(cmd.ExecuteScalar());
            _conn.Close();
            return result != null ? result.ToString() : string.Empty;
        }

        private void ShowPhong()
        {
            string query = @"
        SELECT 
            p.MaPhong, 
            p.TinhTrang, 
            lp.TenLP, 
            kh.TenKH, 
            kh.SDT, 
            kh.Email,
            dp.TongTien
        FROM 
            Phong p
        JOIN 
            LoaiPhong lp ON p.MaLP = lp.MaLP
        LEFT JOIN 
            DatPhong dp ON p.MaPhong = dp.MaPhong
        LEFT JOIN 
            KhachHang kh ON dp.MaKH = kh.MaKH";

            try
            {
                SqlCommand cmd = new SqlCommand(query, _conn);
                _conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                phongTable = new DataTable();
                phongTable.Load(dr);
                foreach (DataRow row in phongTable.Rows)
                {
                    if (row["TinhTrang"].ToString() == "trống")
                    {
                        row["TenKH"] = DBNull.Value;
                        row["SDT"] = DBNull.Value;
                        row["Email"] = DBNull.Value;
                        row["TongTien"] = DBNull.Value;
                    }
                }
                phongView.DataSource = phongTable;
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

        private void showLoaiPhong()
        {
            string query = "SELECT * FROM LoaiPhong";
            try
            {
                SqlCommand cmd = new SqlCommand(query, _conn);
                _conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                loaiPhongView.DataSource = dt;
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

        private void FilterPhong(string filterExpression)
        {
            if (phongTable != null)
            {
                DataView dv = new DataView(phongTable);
                dv.RowFilter = filterExpression;
                phongView.DataSource = dv;
            }
        }

        private void FilterPhongAll()
        {
            bool checkLPCB = timKiemLPCB.SelectedIndex != -1 && timKiemLPCB.SelectedIndex != 0;
            bool checkTinhTrangCB = timKiemTinhTrangCB.SelectedIndex != -1 && timKiemTinhTrangCB.SelectedIndex != 0;
            bool checkMaPhong = timKiemMaPhong.Text != "";

            if (!checkLPCB && !checkTinhTrangCB && !checkMaPhong)
            {
                phongView.DataSource = phongTable;
                return;
            }

            string filterExpression = "";
            if (timKiemLPCB.SelectedIndex != -1 && timKiemLPCB.SelectedIndex != 0)
            {
                filterExpression += $"TenLP = '{timKiemLPCB.SelectedItem.ToString()}'";
            }
            if (timKiemTinhTrangCB.SelectedIndex != -1 && timKiemTinhTrangCB.SelectedIndex != 0)
            {
                if (filterExpression != "")
                {
                    filterExpression += " AND ";
                }
                filterExpression += $"TinhTrang = '{timKiemTinhTrangCB.SelectedItem.ToString()}'";
            }
            if (timKiemMaPhong.Text != "")
            {
                if (filterExpression != "")
                {
                    filterExpression += " AND ";
                }
                filterExpression += $"MaPhong = '{timKiemMaPhong.Text}'";
            }
            FilterPhong(filterExpression);
        }


        private void timKiemLPCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterPhongAll();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterPhongAll();
        }

        private void timKiemMaPhong_TextChanged(object sender, EventArgs e)
        {
            FilterPhongAll();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (themPhongLPCB.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn loại phòng");
                return;
            }
            string query = "INSERT INTO Phong(MaLP, TinhTrang) VALUES(@maLP, @tinhTrang)";
            SqlCommand cmd = new SqlCommand(query, _conn);
            cmd.Parameters.AddWithValue("@maLP", themPhongLPCB.SelectedIndex + 1);
            cmd.Parameters.AddWithValue("@tinhTrang", "trống");
            _conn.Open();
            cmd.ExecuteNonQuery();
            _conn.Close();
            MessageBox.Show("Thêm phòng thành công");
            ShowPhong();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (themTenLP.Text == "" || themGiaTienLP.Text == "")
            {
                MessageBox.Show("Vui lòng điền tên và giá tiền");
                return;
            }
            string query = "SELECT COUNT(*) FROM LoaiPhong WHERE TenLP = @tenLP";
            SqlCommand cmd = new SqlCommand(query, _conn);
            cmd.Parameters.AddWithValue("@tenLP", themTenLP.Text);
            _conn.Open();
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            _conn.Close();
            if (count > 0)
            {
                MessageBox.Show("Loại phòng đã tồn tại");
                return;
            }
            query = "INSERT INTO LoaiPhong(TenLP, GiaTien, MoTa) VALUES(@tenLP, @giaTien, @moTa)";
            cmd = new SqlCommand(query, _conn);
            cmd.Parameters.AddWithValue("@tenLP", themTenLP.Text);
            cmd.Parameters.AddWithValue("@giaTien", themGiaTienLP.Text);
            string moTa = themMoTaLP.Text == "" ? "Không có mô tả" : themMoTaLP.Text;
            cmd.Parameters.AddWithValue("@moTa", moTa);
            _conn.Open();
            cmd.ExecuteNonQuery();
            _conn.Close();
            MessageBox.Show("Thêm loại phòng thành công");
            showLoaiPhong();
            CapNhatLoaiPhong();
        }

        private void capNhatPB_CheckedChanged(object sender, EventArgs e)
        {
            if (capNhatPB.Checked)
            {
                CapNhatPhongButton.BackColor = Color.Lime;
                CapNhatPhongButton.Text = "Check Out";
            }

        }

        private void xoaPB_CheckedChanged(object sender, EventArgs e)
        {
            if (xoaPB.Checked)
            {
                CapNhatPhongButton.BackColor = Color.Red;
                CapNhatPhongButton.Text = "Xóa";
            }
        }

        private void capNhatLPB_CheckedChanged(object sender, EventArgs e)
        {
            if (capNhatLPB.Checked)
            {
                capNhatGiaTienLPLB.Visible = true;
                capNhatGiaTienLPTB.Visible = true;
                capNhatMoTaLPLB.Visible = true;
                capNhatMoTaLPTB.Visible = true;
                CapNhatLoaiPhongButton.BackColor = Color.Lime;
                CapNhatLoaiPhongButton.Text = "Cập nhật";
            }
        }

        private void xoaLPB_CheckedChanged(object sender, EventArgs e)
        {
            if (xoaLPB.Checked)
            {
                capNhatGiaTienLPLB.Visible = false;
                capNhatGiaTienLPTB.Visible = false;
                capNhatMoTaLPLB.Visible = false;
                capNhatMoTaLPTB.Visible = false;
                CapNhatLoaiPhongButton.BackColor = Color.Red;
                CapNhatLoaiPhongButton.Text = "Xóa";
            }
        }

        private bool CheckPhongExit(string maPhong)
        {
            string query = "SELECT COUNT(*) FROM Phong WHERE MaPhong = @maPhong";
            SqlCommand cmd = new SqlCommand(query, _conn);
            cmd.Parameters.AddWithValue("@maPhong", maPhong);
            _conn.Open();
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            _conn.Close();
            if (count == 0)
            {
                MessageBox.Show("Phòng không tồn tại");
                return false;
            }
            return true;
        }

        private void CapNhatPhongButton_Click(object sender, EventArgs e)
        {
            if (capNhatMaPhongTB.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã phòng");
                return;
            }
            if (!CheckPhongExit(capNhatMaPhongTB.Text.ToString()))
            {
                return;
            }
            if (capNhatPB.Checked)
            {
                if (!checkIfPhongIsInUse(capNhatMaPhongTB.Text))
                {
                    MessageBox.Show("Phòng không được sử dụng");
                    return;
                }
                string query = "UPDATE Phong SET TinhTrang = @tinhTrang WHERE MaPhong = @maPhong";
                SqlCommand cmd = new SqlCommand(query, _conn);
                cmd.Parameters.AddWithValue("@tinhTrang", "trống");
                cmd.Parameters.AddWithValue("@maPhong", capNhatMaPhongTB.Text);
                _conn.Open();
                cmd.ExecuteNonQuery();
                _conn.Close();
                query = "UPDATE DatPhong SET TinhTrang = @tinhTrang WHERE MaPhong = @maPhong";
                cmd = new SqlCommand(query, _conn);
                cmd.Parameters.AddWithValue("@tinhTrang", "đã trả");
                cmd.Parameters.AddWithValue("@maPhong", capNhatMaPhongTB.Text);
                _conn.Open();
                cmd.ExecuteNonQuery();
                _conn.Close();
                MessageBox.Show("Check out thành công");
                ShowPhong();
            }
            else if (xoaPB.Checked)
            {
                if (checkIfPhongIsInUse(capNhatMaPhongTB.Text))
                {
                    return;
                }

                string query = "DELETE FROM Phong WHERE MaPhong = @maPhong";
                SqlCommand cmd = new SqlCommand(query, _conn);
                cmd.Parameters.AddWithValue("@maPhong", capNhatMaPhongTB.Text);
                _conn.Open();
                cmd.ExecuteNonQuery();
                _conn.Close();
                MessageBox.Show("Xóa thành công");
                ShowPhong();
            }
        }

        private bool checkIfPhongIsInUse(string maPhong)
        {
            string query = "SELECT COUNT(*) FROM Phong WHERE MaPhong = @maPhong AND TinhTrang = @tinhTrang";
            SqlCommand cmd = new SqlCommand(query, _conn);
            cmd.Parameters.AddWithValue("@maPhong", maPhong);
            cmd.Parameters.AddWithValue("@tinhTrang", "không trống");
            _conn.Open();
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            _conn.Close();
            if (count > 0)
            {
                MessageBox.Show("Phòng đang được sử dụng");
                return true;
            }
            return false;
        }

        private bool checkIfLoaiPhongIsInUse(string tenLP)
        {
            string query = "SELECT COUNT(*) FROM Phong p JOIN LoaiPhong lp ON p.MaLP = lp.MaLP WHERE lp.TenLP = @tenLP AND p.TinhTrang = @tinhTrang";
            SqlCommand cmd = new SqlCommand(query, _conn);
            cmd.Parameters.AddWithValue("@tenLP", tenLP);
            cmd.Parameters.AddWithValue("@tinhTrang", "không trống");
            _conn.Open();
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            _conn.Close();
            if (count > 0)
            {
                MessageBox.Show("Loại phòng đang được sử dụng");
                return true;
            }
            return false;
        }

        private void CapNhatLoaiPhongButton_Click(object sender, EventArgs e)
        {
            if (capNhatLPB.Checked)
            {
                if (capNhatTenLPTB.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập tên loại phòng");
                    return;
                }
                if (capNhatGiaTienLPTB.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập giá tiền");
                    return;
                }
                string query = "SELECT * FROM LoaiPhong WHERE TenLP = @tenLP";
                SqlCommand cmd = new SqlCommand(query, _conn);
                cmd.Parameters.AddWithValue("@tenLP", capNhatTenLPTB.Text);
                _conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (!dr.Read())
                {
                    MessageBox.Show("Loại phòng không tồn tại");
                    _conn.Close();
                    return;
                }
                else
                {
                    LoaiPhong lp = new LoaiPhong
                    {
                        MaLP = dr["MaLP"].ToString(),
                        TenLP = dr["TenLP"].ToString(),
                        MoTa = dr["MoTa"].ToString(),
                        GiaTien = Convert.ToInt32(dr["GiaTien"])
                    };
                    _conn.Close();
                    query = "UPDATE LoaiPhong SET GiaTien = @giaTien, MoTa = @moTa WHERE TenLP = @tenLP";
                    cmd = new SqlCommand(query, _conn);
                    _conn.Open();
                    string newGiaTien = capNhatGiaTienLPTB.Text == "" ? lp.GiaTien.ToString() : capNhatGiaTienLPTB.Text;
                    string newMoTa = capNhatMoTaLPTB.Text == "" ? lp.MoTa : capNhatMoTaLPTB.Text;
                    cmd.Parameters.AddWithValue("@giaTien", newGiaTien);
                    cmd.Parameters.AddWithValue("@moTa", newMoTa);
                    cmd.Parameters.AddWithValue("@tenLP", capNhatTenLPTB.Text);
                    cmd.ExecuteNonQuery();
                    _conn.Close();
                    MessageBox.Show("Cập nhật thành công");
                    showLoaiPhong();
                    CapNhatLoaiPhong();
                }
            }
            else if (xoaLPB.Checked)
            {
                if (checkIfLoaiPhongIsInUse(capNhatTenLPTB.Text))
                {
                    return;
                }
                string query = "DELETE FROM LoaiPhong WHERE TenLP = @tenLP";
                SqlCommand cmd = new SqlCommand(query, _conn);
                cmd.Parameters.AddWithValue("@tenLP", capNhatTenLPTB.Text);
                _conn.Open();
                cmd.ExecuteNonQuery();
                _conn.Close();
                MessageBox.Show("Xóa thành công");
                showLoaiPhong();
                CapNhatLoaiPhong();
            }
        }
    }
}
