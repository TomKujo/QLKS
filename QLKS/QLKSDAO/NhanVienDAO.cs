using System.Data;
using Microsoft.Data.SqlClient;
using QLKSDTO;

namespace QLKSDAO
{
    public class NhanVienDAO
    {
        public static List<NhanVien> layDSNhanVien()
        {
            List<NhanVien> dsNV = new List<NhanVien>();
            DataTable dtNV = DataProvider.TruyVan_LayDuLieu("SELECT * FROM NhanVien");
            foreach (DataRow r in dtNV.Rows)
            {
                NhanVien hs = new NhanVien
                {
                    MaNV = r["MaNV"].ToString(),
                    TenNV = r["TenNV"].ToString(),
                    SDT = r["SDT"].ToString(),
                    GioiTinh = r["GioiTinh"].ToString()
                };
                dsNV.Add(hs);
            }
            return dsNV;
        }

        public static void themNhanVien(NhanVien nv)
        {
            string sql = "INSERT INTO NhanVien(MaNV, TenNV, SDT, GioiTinh) " +
                "VALUES(@MaNV, @TenNV, @SDT, @GioiTinh)";
            SqlParameter[] pa = new SqlParameter[4];
            pa[0] = new SqlParameter("MaNV", nv.MaNV);
            pa[1] = new SqlParameter("TenNV", nv.TenNV);
            pa[2] = new SqlParameter("SDT", nv.SDT);
            pa[3] = new SqlParameter("GioiTinh", nv.GioiTinh);
            DataProvider.ExcuteNonQuery(sql, CommandType.Text, pa);
        }

        public static void xoaNhanVien(string MaNV)
        {
            string sql = "DELETE FROM NhanVien WHERE MaNV = @MaNV";
            SqlParameter[] pa = new SqlParameter[1];
            pa[0] = new SqlParameter("MaNV", MaNV);
            DataProvider.ExcuteNonQuery(sql, CommandType.Text, pa);
        }

        public static void suaNhanVien(NhanVien nv)
        {
            string sql = "UPDATE NhanVien SET TenNV=@TenNV, SDT = @SDT, GioiTinh = @GioiTinh WHERE MaNV = @MaNV";
            SqlParameter[] pa = new SqlParameter[4];
            pa[0] = new SqlParameter("MaNV", nv.MaNV);
            pa[1] = new SqlParameter("TenNV", nv.TenNV);
            pa[2] = new SqlParameter("SDT", nv.SDT);
            pa[3] = new SqlParameter("GioiTinh", nv.GioiTinh);
            DataProvider.ExcuteNonQuery(sql, CommandType.Text, pa);
        }

        public static List<NhanVien> timTheoTenNV(string ten)
        {
            List<NhanVien> dsNV = new List<NhanVien>();
            SqlParameter[] pa = new SqlParameter[1];
            pa[0] = new SqlParameter("Ten", ten);
            DataTable dtNV = DataProvider.SelectData("SELECT * FROM NhanVien WHERE TenNV LIKE N'%' + @Ten + '%'", CommandType.Text, pa);
            foreach (DataRow r in dtNV.Rows)
            {
                NhanVien nv = new NhanVien
                {
                    MaNV = r["MaNV"].ToString(),
                    TenNV = r["TenNV"].ToString(),
                    SDT = r["SDT"].ToString(),
                    GioiTinh = r["GioiTinh"].ToString()
                };
                dsNV.Add(nv);
            }
            return dsNV;
        }
    }
}
