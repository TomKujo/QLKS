using System.Data;
using System.Data.SqlClient;

namespace QLKS
{
    public partial class frmDangNhap : Form
    {
        private SqlConnection _conn;

        public frmDangNhap()
        {
            InitializeComponent();
            _conn = new SqlConnection("Data Source=DESKTOP-HDPCSE2\\SQLEXPRESS;Initial Catalog=QLKS;Integrated Security=True;TrustServerCertificate=True");
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {

            if (txtTK.Text.ToString() == "" || txtTK.Text.ToString() == "")
            {
                lblSai.Text = "Vui lòng điền đầy đủ thông tin!!!";
                lblSai.Visible = true;
                return;
            }
            else
            {
                NhanVien nv = account_Checking(txtTK.Text.ToString(), txtMK.Text.ToString());
                if (nv != null)
                {
                    frmChucNang frmChucNang = new frmChucNang();
                    this.Hide();
                    frmChucNang.FormClosed += (s, args) => this.Close();
                    frmChucNang.tenNV = nv.TenNV;
                    frmChucNang.Show();

                }
                else
                {
                    lblSai.Visible = true;
                    lblSai.Text = "Sai tài khoản hoặc mật khẩu";
                }
            }
        }

        private void btnHien_Click(object sender, EventArgs e)
        {
            txtMK.UseSystemPasswordChar = !txtMK.UseSystemPasswordChar;
            if (!txtMK.UseSystemPasswordChar)
            {
                logoPicture.Image = Properties.Resources.Stamp0393;
                btnHien.BackgroundImage = Properties.Resources.invisible;
                btnHien.BringToFront();
            }
            else
            {
                logoPicture.Image = Properties.Resources.Stamp0125;
                btnHien.BackgroundImage = Properties.Resources.visible;
                btnHien.BringToFront();
            }
        }

        private void txtMK_TextChanged(object sender, EventArgs e)
        {
            btnHien.Visible = !string.IsNullOrEmpty(txtMK.Text);
        }

        private NhanVien account_Checking(string name, string password)
        {
            try
            {
                if (_conn.State == ConnectionState.Closed)
                {
                    _conn.Open();
                }
                string query = @"SELECT nv.MaNV, nv.TenNV, nv.SDT
                                from TaiKhoan tk
                                JOIN NhanVien nv ON tk.MaNV = nv.MaNV
                                WHERE tk.TenTK = @name AND tk.MatKhau = @password";
                SqlCommand sqlCommand = new SqlCommand(query, _conn);
                sqlCommand.Parameters.AddWithValue("@name", name);
                sqlCommand.Parameters.AddWithValue("@password", password);

                SqlDataReader reader = sqlCommand.ExecuteReader();
                if (reader.Read())
                {
                    NhanVien nhanVien = new NhanVien
                    {
                        MaNV = reader["MaNV"].ToString(),
                        TenNV = reader["TenNV"].ToString(),
                        SDT = reader["SDT"].ToString()
                    };
                    reader.Close();
                    _conn.Close();
                    return nhanVien;
                }
                else
                {
                    reader.Close();
                    _conn.Close();
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                _conn.Close();
                return null;
            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblSai_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtTK_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblSai.Visible = false;
        }

        private void txtMK_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblSai.Visible = false;
        }

        private void OnMouseHoverEffect(object sender, EventArgs e, Image newImg)
        {
            Button button = (Button)sender;
            if (button != null)
            {
                if (button.Width == 25)
                {
                    button.Location = new Point(button.Location.X - 5, button.Location.Y - 2);
                    button.Size = new Size(28, 28);
                    button.BackgroundImage = newImg;
                    button.BringToFront();
                }
            }
            else
            {
                MessageBox.Show("Object not a button!");
            }
        }

        private void OnMouseLeaveEffect(object sender, EventArgs e, Image newImg)
        {
            Button button = (Button)sender;
            if (button != null)
            {
                if (button.Width == 28)
                {
                    button.Location = new Point(button.Location.X + 5, button.Location.Y + 2);
                    button.Size = new Size(25, 25);
                    button.BackgroundImage = newImg;
                    button.BringToFront();
                }
            }
            else
            {
                MessageBox.Show("Object not a button!");
            }
        }

        private void clsBtn_MouseHover(object sender, EventArgs e)
        {
            Image newImg = Properties.Resources.u42cu2eumyc71_2_;
            OnMouseHoverEffect(sender, e, newImg);
        }

        private void clsBtn_MouseLeave(object sender, EventArgs e)
        {
            Image oldImg = Properties.Resources.u42cu2eumyc71_1_;
            OnMouseLeaveEffect(sender, e, oldImg);
        }

        private void clsBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to close app?", "Close Application", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void mnzBtn_MouseHover(object sender, EventArgs e)
        {
            Image newImg = Properties.Resources.u42cu2eumyc71_4_;
            OnMouseHoverEffect(sender, e, newImg);
        }

        private void mnzBtn_MouseLeave(object sender, EventArgs e)
        {
            Image oldImg = Properties.Resources.u42cu2eumyc71_3_;
            OnMouseLeaveEffect(sender, e, oldImg);
        }

        private void mnzBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}