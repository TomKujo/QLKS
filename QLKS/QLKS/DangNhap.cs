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
    }
}