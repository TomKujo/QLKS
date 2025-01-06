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
using QLKS.Database;

namespace QLKS
{
    public partial class DashboardPage : UserControl
    {
        public DashboardPage()
        {
            InitializeComponent();
        }

        private void getSoluongPhong()
        {
            DatabaseConnection.Connection.Open();
            string query = "SELECT COUNT(*) FROM PHONG";
            SqlCommand cmd = new SqlCommand(query, DatabaseConnection.Connection);
            int soluongPhong = (int)cmd.ExecuteScalar();
            DatabaseConnection.Connection.Close();
            soPhong.Text = soluongPhong.ToString();
        }

        private void getSoluongKhachHang()
        {
            DatabaseConnection.Connection.Open();
            string query = "SELECT COUNT(*) FROM KHACHHANG";
            SqlCommand cmd = new SqlCommand(query, DatabaseConnection.Connection);
            int soluongKhachHang = (int)cmd.ExecuteScalar();
            DatabaseConnection.Connection.Close();
            soKH.Text = soluongKhachHang.ToString();
        }

        private void getSoluongNhanVien()
        {
            DatabaseConnection.Connection.Open();
            string query = "SELECT COUNT(*) FROM NHANVIEN";
            SqlCommand cmd = new SqlCommand(query, DatabaseConnection.Connection);
            int soluongNhanVien = (int)cmd.ExecuteScalar();
            DatabaseConnection.Connection.Close();
            soNV.Text = soluongNhanVien.ToString();
        }

        private void getDoanhThu()
        {
            DatabaseConnection.Connection.Open();
            string query = "SELECT SUM(TongTien) FROM DatPhong";
            SqlCommand cmd = new SqlCommand(query, DatabaseConnection.Connection);
            int doanhThu = cmd.ExecuteScalar() == DBNull.Value ? 0 : (int)cmd.ExecuteScalar();
            DatabaseConnection.Connection.Close();
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
