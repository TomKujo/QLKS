using System.Data;

namespace QLKS
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTK.Text == "NguyenVanC" && txtMK.Text == "NguyenVanC")
            {
                frmChucNang frmChucNang = new frmChucNang();
                frmChucNang.Show();
            }
            else
            {
                lblSai.Visible = true;
                lblSai.Text = "Sai tài khoản hoặc mật khẩu";
            }
        }

        private void btnHien_Click(object sender, EventArgs e)
        {
            txtMK.UseSystemPasswordChar = !txtMK.UseSystemPasswordChar;
        }

        private void txtMK_TextChanged(object sender, EventArgs e)
        {
            btnHien.Visible = !string.IsNullOrEmpty(txtMK.Text);
        }
    }
}