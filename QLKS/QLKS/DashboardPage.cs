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
    public partial class DashboardPage : UserControl
    {
        private SqlConnection _conn;
        public DashboardPage()
        {
            InitializeComponent();
            _conn = new SqlConnection("Data Source=DESKTOP-HDPCSE2\\SQLEXPRESS;Initial Catalog=QLKS;Integrated Security=True;TrustServerCertificate=True");
        }

        private void getSoluongPhong()
        {
            _conn.Open();
            string query = "SELECT COUNT(*) FROM PHONG";
            SqlCommand cmd = new SqlCommand(query, _conn);
            int soluongPhong = (int)cmd.ExecuteScalar();
            _conn.Close();
            soPhong.Text = soluongPhong.ToString();
        }

        private void getSoluongKhachHang()
        {
            _conn.Open();
            string query = "SELECT COUNT(*) FROM KHACHHANG";
            SqlCommand cmd = new SqlCommand(query, _conn);
            int soluongKhachHang = (int)cmd.ExecuteScalar();
            _conn.Close();
            soKH.Text = soluongKhachHang.ToString();
        }

        private void getSoluongNhanVien()
        {
            _conn.Open();
            string query = "SELECT COUNT(*) FROM NHANVIEN";
            SqlCommand cmd = new SqlCommand(query, _conn);
            int soluongNhanVien = (int)cmd.ExecuteScalar();
            _conn.Close();
            soNV.Text = soluongNhanVien.ToString();
        }

        private void getDoanhThu()
        {
            _conn.Open();
            string query = "SELECT SUM(TongTien) FROM DatPhong";
            SqlCommand cmd = new SqlCommand(query, _conn);
            int doanhThu = Convert.ToInt32(cmd.ExecuteScalar());
            _conn.Close();
            soDoanhThu.Text = doanhThu.ToString();
        }

        private void DashboardPage_Load(object sender, EventArgs e)
        {
            getDoanhThu();
            getSoluongKhachHang();
            getSoluongNhanVien();
            getSoluongPhong();

        }
    }
}
