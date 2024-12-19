using QLKSDTO;
using QLKSDAO;

namespace QLKSBUS
{
    public class NhanVienBUS
    {
        public static bool themNhanVien(NhanVien nv)
        {
            if (nv.TenNV == "") { return false; }
            try
            {
                NhanVienDAO.themNhanVien(nv);
                return true;
            }
            catch { return false; }
        }

        public static bool xoaNhanVien(string manv)
        {
            try
            {
                NhanVienDAO.xoaNhanVien(manv);
                return true;
            }
            catch { return false; }
        }

        public static bool suaNhanVien(NhanVien nv)
        {
            if (nv.TenNV == "") { return false; }
            try
            {
                NhanVienDAO.suaNhanVien(nv);
                return true;
            }
            catch { return false; }
        }

        public static List<NhanVien> layDSNhanVien()
        {
            return NhanVienDAO.layDSNhanVien();
        }

        public static List<NhanVien> timTheoTenNV(string ten)
        {
            return NhanVienDAO.timTheoTenNV(ten);
        }
    }
}
