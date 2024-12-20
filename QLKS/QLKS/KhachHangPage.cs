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
using System.Drawing.Text;
using System.ComponentModel.DataAnnotations;
using QLKS.Model;

namespace QLKS
{
    public partial class KhachHangPage : UserControl
    {
        #region Properties
        private SqlConnection _conn;
        #endregion

        #region Constructors
        public KhachHangPage()
        {
            InitializeComponent();
            _conn = new SqlConnection("Data Source=DESKTOP-HDPCSE2\\SQLEXPRESS;Initial Catalog=QLKS;Integrated Security=True;TrustServerCertificate=True");
            ConnectKhachHangDB();
        }
        #endregion

        #region ThemKhachHang
        private void button1_Click(object sender, EventArgs e)
        {
            if (tenKH.Text == string.Empty || SDT.Text == string.Empty || Email.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng điền đầy đủ Tên, SĐT, Email");
                return;
            }
            else if (SDT.Text.ToString().Length != 10)
            {
                MessageBox.Show("Số điện thoại không hợp lệ");
                return;
            }
            else if (!new EmailAddressAttribute().IsValid(Email.Text))
            {
                MessageBox.Show("Email không hợp lệ");
                return;
            }
            else
            {
                try
                {
                    _conn.Open();

                    string checkQuery = "SELECT COUNT(*) FROM KhachHang WHERE SDT = @SDT AND Email = @Email";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, _conn);
                    checkCmd.Parameters.AddWithValue("@SDT", SDT.Text);
                    checkCmd.Parameters.AddWithValue("@Email", Email.Text);

                    int exists = (int)checkCmd.ExecuteScalar();
                    if (exists > 0)
                    {
                        MessageBox.Show("Khách hàng đã tồn tại");
                        _conn.Close();
                        return;
                    }

                    string insertQuery = "INSERT INTO KhachHang(TenKH, NgaySinh, DiaChi, SDT, Email) VALUES(@tenKH, @NgaySinh, @DiaChi, @SDT, @Email)";
                    SqlCommand insertCmd = new SqlCommand(insertQuery, _conn);
                    insertCmd.Parameters.AddWithValue("@tenKH", tenKH.Text);
                    insertCmd.Parameters.AddWithValue("@SDT", SDT.Text);
                    insertCmd.Parameters.AddWithValue("@Email", Email.Text);

                    if (!string.IsNullOrEmpty(DOB.Text))
                    {
                        insertCmd.Parameters.AddWithValue("@NgaySinh", DOB.Text);
                    }
                    else
                    {
                        insertCmd.Parameters.AddWithValue("@NgaySinh", DBNull.Value);
                    }

                    if (!string.IsNullOrEmpty(diaChi.Text))
                    {
                        insertCmd.Parameters.AddWithValue("@DiaChi", diaChi.Text);
                    }
                    else
                    {
                        insertCmd.Parameters.AddWithValue("@DiaChi", DBNull.Value);
                    }

                    insertCmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm khách hàng thành công");
                    tenKH.Text = string.Empty;
                    SDT.Text = string.Empty;
                    Email.Text = string.Empty;
                    DOB.Value = DateTime.Now;
                    diaChi.Text = string.Empty;

                    _conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ConnectKhachHangDB()
        {
            try
            {
                _conn.Open();
                string query = "SELECT * FROM KhachHang";
                SqlDataAdapter adapter = new SqlDataAdapter(query, _conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                khachHangView.DataSource = dt;
                _conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region TimKiemKhachHang
        private void timKiemKhachHangFromDB()
        {
            if(timTheoTenKH.Text == string.Empty && timTheoSDT.Text == string.Empty && timTheoEmail.Text == string.Empty)
            {
                ConnectKhachHangDB();
                return;
            }

            try
            {
                _conn.Open();
                string query = "SELECT * FROM KhachHang WHERE";
                if (timTheoTenKH.Text != string.Empty)
                {
                    query += " TenKH LIKE @tenKH";
                }
                if (timTheoSDT.Text != string.Empty)
                {
                    if (query.Contains("LIKE"))
                    {
                        query += " AND SDT LIKE @SDT";
                    }
                    else
                    {
                        query += " SDT LIKE @SDT";
                    }
                }
                if (timTheoEmail.Text != string.Empty)
                {
                    if (query.Contains("LIKE"))
                    {
                        query += " AND Email LIKE @Email";
                    }
                    else
                    {
                        query += " Email LIKE @Email";
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(query, _conn);
                if (timTheoTenKH.Text != string.Empty)
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@tenKH", "%" + timTheoTenKH.Text + "%");
                }
                if (timTheoSDT.Text != string.Empty)
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@SDT", "%" + timTheoSDT.Text + "%");
                }
                if (timTheoEmail.Text != string.Empty)
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@Email", "%" + timTheoEmail.Text + "%");
                }
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                khachHangView.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                _conn.Close();
            }
        }

        private void timTheoTenKH_TextChanged(object sender, EventArgs e)
        {
            timKiemKhachHangFromDB();
        }

        private void timTheoEmail_TextChanged(object sender, EventArgs e)
        {
            timKiemKhachHangFromDB();
        }

        private void timTheoSDT_TextChanged(object sender, EventArgs e)
        {
            timKiemKhachHangFromDB();
        }
        #endregion

        #region CapNhat-XoaKhachHang
        private void CapNhatKH_Click(object sender, EventArgs e)
        {
            if(capNhatKHB.Checked)
            {
                CapNhatKH_();
                
            }
            else if (xoaKHB.Checked)
            {
                XoaKH_();
            }
            ConnectKhachHangDB();
        }

        private void CapNhatKH_()
        {
            try
            {
                if (maKH.Text == string.Empty)
                {
                    MessageBox.Show("Vui lòng nhập mã khách hàng cần thay đổi thông tin!");
                    return;
                }
                if (capNhatSDT.Text.ToString().Length != 10)
                {
                    MessageBox.Show("Số điện thoại không hợp lệ");
                    return;
                }
                if (Email.Text.ToString() != string.Empty)
                {
                    if (!new EmailAddressAttribute().IsValid(Email.Text))
                    {
                        MessageBox.Show("Email không hợp lệ");
                        return;
                    }
                }
                _conn.Open();
                string searchQuery = "SELECT * FROM KhachHang WHERE MaKH = @MaKH";
                SqlDataAdapter adapter = new SqlDataAdapter(searchQuery, _conn);
                adapter.SelectCommand.Parameters.AddWithValue("@MaKH", maKH.Text);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy khách hàng");
                    _conn.Close();
                    return;
                }
                else
                {
                    KhachHang kh = new KhachHang
                    {
                        maKH = dt.Rows[0]["MaKH"].ToString(),
                        tenKH = dt.Rows[0]["TenKH"].ToString(),
                        ngaySinh = dt.Rows[0]["NgaySinh"].ToString(),
                        diaChi = dt.Rows[0]["DiaChi"].ToString(),
                        sdt = dt.Rows[0]["SDT"].ToString(),
                        email = dt.Rows[0]["Email"].ToString()
                    };

                    string updateQuery = "UPDATE KhachHang SET TenKH = @tenKH, NgaySinh = @NgaySinh, DiaChi = @DiaChi, SDT = @SDT, Email = @Email WHERE MaKH = @MaKH";
                    SqlDataAdapter updateDataAdapter = new SqlDataAdapter(updateQuery, _conn);
                    if (capNhatTenKH.Text != string.Empty)
                    {
                        updateDataAdapter.SelectCommand.Parameters.AddWithValue("@tenKH", capNhatTenKH.Text);
                    }
                    else
                    {
                        updateDataAdapter.SelectCommand.Parameters.AddWithValue("@tenKH", kh.tenKH);
                    }
                    if (capNhatDOB.Text != string.Empty && capNhatDOB.Visible)
                    {
                        updateDataAdapter.SelectCommand.Parameters.AddWithValue("@NgaySinh", capNhatDOB.Text);
                    }
                    else
                    {
                        updateDataAdapter.SelectCommand.Parameters.AddWithValue("@NgaySinh", kh.ngaySinh);
                    }
                    if (capNhatDiaChi.Text != string.Empty)
                    {
                        updateDataAdapter.SelectCommand.Parameters.AddWithValue("@DiaChi", capNhatDiaChi.Text);
                    }
                    else
                    {
                        updateDataAdapter.SelectCommand.Parameters.AddWithValue("@DiaChi", kh.diaChi);
                    }
                    if (capNhatSDT.Text != string.Empty)
                    {
                        updateDataAdapter.SelectCommand.Parameters.AddWithValue("@SDT", capNhatSDT.Text);
                    }
                    else
                    {
                        updateDataAdapter.SelectCommand.Parameters.AddWithValue("@SDT", kh.sdt);
                    }
                    if (capNhatEmail.Text != string.Empty)
                    {
                        updateDataAdapter.SelectCommand.Parameters.AddWithValue("@Email", capNhatEmail.Text);
                    }
                    else
                    {
                        updateDataAdapter.SelectCommand.Parameters.AddWithValue("@Email", kh.email);
                    }
                    updateDataAdapter.SelectCommand.Parameters.AddWithValue("@MaKH", maKH.Text);
                    updateDataAdapter.SelectCommand.ExecuteNonQuery();
                    _conn.Close();
                    MessageBox.Show("Cập nhật thông tin khách hàng thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void XoaKH_()
        {
            if (maKH.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập mã khách hàng cần xóa!");
                return;
            }
            try
            {
                _conn.Open();
                string searchQuery = "SELECT * FROM KhachHang WHERE MaKH = @MaKH";
                SqlDataAdapter adapter = new SqlDataAdapter(searchQuery, _conn);
                adapter.SelectCommand.Parameters.AddWithValue("@MaKH", maKH.Text);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy khách hàng");
                    _conn.Close();
                    return;
                }
                else
                {
                    string deleteQuery = "DELETE FROM KhachHang WHERE MaKH = @MaKH";
                    SqlDataAdapter deleteDataAdapter = new SqlDataAdapter(deleteQuery, _conn);
                    deleteDataAdapter.SelectCommand.Parameters.AddWithValue("@MaKH", maKH.Text);
                    deleteDataAdapter.SelectCommand.ExecuteNonQuery();
                    _conn.Close();
                    MessageBox.Show("Xóa khách hàng thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void khachHangView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = khachHangView.Rows[e.RowIndex];
                maKH.Text = row.Cells[0].Value.ToString();
                capNhatTenKH.Text = row.Cells[1].Value.ToString();
                capNhatEmail.Text = row.Cells[3].Value.ToString();
                capNhatSDT.Text = row.Cells[2].Value.ToString();
                capNhatDOB.Text = row.Cells[4].Value.ToString();
                capNhatDiaChi.Text = row.Cells[5].Value.ToString();
            }
        }

        #endregion


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!dobCB.Checked)
            {
                capNhatDOB.Visible = false;
                dobLabel.Visible = false;
            }
            else
            {
                capNhatDOB.Visible = true;
                dobLabel.Visible = true;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (capNhatKHB.Checked)
            {
                tenKHLB.Visible = true;               
                capNhatTenKH.Visible = true;
                sdtLB.Visible = true;
                capNhatSDT.Visible = true;
                emailLB.Visible = true;
                capNhatEmail.Visible = true;
                dobCB.Visible = true;
                if(dobCB.Checked)
                {
                    dobLabel.Visible = true;
                    capNhatDOB.Visible = true;
                }
                else
                {
                    dobLabel.Visible = false;
                    capNhatDOB.Visible = false;
                }    
                diaChiLB.Visible = true;
                capNhatDiaChi.Visible = true;
                CapNhatKH.Text = "Cập nhật";
                CapNhatKH.BackColor = Color.Lime;
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (xoaKHB.Checked)
            {
                tenKHLB.Visible = false;
                capNhatTenKH.Visible = false;
                sdtLB.Visible = false;
                capNhatSDT.Visible = false;
                emailLB.Visible = false;
                capNhatEmail.Visible = false;
                dobCB.Visible = false;
                dobLabel.Visible = false;
                capNhatDOB.Visible = false;
                diaChiLB.Visible = false;
                capNhatDiaChi.Visible = false;
                CapNhatKH.Text = "Xóa";
                CapNhatKH.BackColor = Color.Red;
            }
        }
    }
}
