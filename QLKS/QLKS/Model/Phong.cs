using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS.Model
{
    public class Phong
    {
        public string MaPhong { get; set; }
        public string LoaiPhong { get; set; }
        public string TinhTrang { get; set; }
        public Phong(string maPhong, string tenPhong, string loaiPhong, string tinhTrang, string ghiChu)
        {
            MaPhong = maPhong;
            LoaiPhong = loaiPhong;
            TinhTrang = tinhTrang;
        }
    }
}
