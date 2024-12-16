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
                bool check = account_Checking(txtTK.Text.ToString(), txtMK.Text.ToString());
                if (check)
                {
                    frmChucNang frmChucNang = new frmChucNang();
                    this.Hide();
                    frmChucNang.FormClosed += (s, args) => this.Close();
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
            }
            else
            {
                logoPicture.Image = Properties.Resources.Stamp0125;
            }
        }

        private void txtMK_TextChanged(object sender, EventArgs e)
        {
            btnHien.Visible = !string.IsNullOrEmpty(txtMK.Text);
        }

        private bool account_Checking(string name, string password)
        {
            try
            {
                if (_conn.State == ConnectionState.Closed)
                {
                    _conn.Open();
                }
                string query = "SELECT COUNT(*) from NhanVien WHERE TK = @name AND MK = @password";
                SqlCommand sqlCommand = new SqlCommand(query, _conn);
                sqlCommand.Parameters.AddWithValue("@name", name);
                sqlCommand.Parameters.AddWithValue("@password", password);
                int result = (int)sqlCommand.ExecuteScalar();
                return result > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
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
    }
}