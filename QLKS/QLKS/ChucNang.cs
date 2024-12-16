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
        public frmChucNang()
        {
            InitializeComponent();
        }

        private void btnPhong_Click(object sender, EventArgs e)
        {
            frmPhong frmPhong = new frmPhong();
            frmPhong.Show();
            //this.Hide();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            frmKH frmKH = new frmKH();
            frmKH.Show();
            //this.Hide();
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = "DoanhThu.txt";
                double tongDoanhThu = 0;
                if (File.Exists(filePath))
                {
                    string doanhThuText = File.ReadAllText(filePath);
                    if (!string.IsNullOrEmpty(doanhThuText))
                    {
                        tongDoanhThu = Convert.ToDouble(doanhThuText);
                    }
                }
                MessageBox.Show($"Tổng doanh thu: {tongDoanhThu:C}", "Doanh Thu");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc tổng doanh thu: " + ex.Message);
            }
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            frmNV frmNV = new frmNV();
            frmNV.Show();
            //this.Hide();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            frmDangNhap frmDangNhap = new frmDangNhap();
            frmDangNhap.Show();
            //this.Hide();
        }
    }
}
