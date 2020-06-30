using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BangLuong_DTO
    {
        public string MaNV { set; get; }
        public int TongLuong { set; get; }
        public string TenNV { set; get; }
        public int NgayLuong { set; get; }
        public int SoNgayLam { set; get; }
        public int CoPhep { set; get; }
        public int KhongPhep { set; get; }
        public int Thang { set; get; }
    }
    public class BangLuong_DTO_View
    {
        public string MaNV { set; get; }
        public string TenNV { set; get; }
        public int NgayLuong { set; get; }
    }
}
