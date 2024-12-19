using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS
{
    public partial class frmChucNang : Form
    {
        public string tenNV;
        public frmChucNang()
        {
            InitializeComponent();
            timer1.Start();
            HideEveryPage();
            dashboardPage1.Show();
            if(btnDashBoard != null)
            {
                onChoseBtnColorChanged(btnDashBoard);
            }
        }

        private void btnPhong_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button != null)
            {
                onChoseBtnColorChanged(button);
            }
            HideEveryPage();
            phongPage1.Show();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button != null)
            {
                onChoseBtnColorChanged(button);
            }
            HideEveryPage();
            khachHangPage1.Show();
            //this.Hide();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button != null)
            {
                onChoseBtnColorChanged(button);
            }
            HideEveryPage();
            nhanVienPage1.Show();
            //this.Hide();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to logout?", "Logout", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                timer1.Stop();
                frmDangNhap frmDangNhap = new frmDangNhap();
                frmDangNhap.Show();
                this.Hide();
            }
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
                timer1.Stop();
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            dateTimeLB.Text = DateTime.Now.ToString();
            tenNVLB.Text = "Xin chào, " + tenNV;
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            Button btnDashBoard = sender as Button;
            if (btnDashBoard != null)
            {
                onChoseBtnColorChanged(btnDashBoard);
            }
            HideEveryPage();
            dashboardPage1.Show();
        }

        private void refreshAllButton()
        {
            btnDashBoard.BackColor = Color.FromArgb(255, 204, 234);
            btnKhachHang.BackColor = Color.FromArgb(255, 204, 234);
            btnNhanVien.BackColor = Color.FromArgb(255, 204, 234);
            btnPhong.BackColor = Color.FromArgb(255, 204, 234);
        }

        private void onChoseBtnColorChanged(Button button)
        {
            refreshAllButton();
            button.BackColor = Color.FromArgb(255, 224, 192);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HideEveryPage()
        {
            khachHangPage1.Hide();
            phongPage1.Hide();
            nhanVienPage1.Hide();
            dashboardPage1.Hide();
        }

        private void khachHangPage1_Load(object sender, EventArgs e)
        {

        }
    }
}
