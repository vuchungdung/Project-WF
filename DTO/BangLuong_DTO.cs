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
        public string TenNV { set; get; }
        public int NgayLuong { set; get; }
        public int DiLam { set; get; }
        public int CoPhep { set; get; }
        public int KhongPhep { set; get; }
        public int Thang { set; get; }
        public int TongLuong { set; get; }
        public int Nam { set; get; }
    }
    public class BangLuong_DTO_View
    {
        public string MaNV { set; get; }
        public int Thang1 { set; get; }
        public int Thang2 { set; get; }
        public int Thang3 { set; get; }
        public int Thang4 { set; get; }
        public int Thang5 { set; get; }
        public int Thang6 { set; get; }
        public int Thang7 { set; get; }
        public int Thang8 { set; get; }
        public int Thang9 { set; get; }
        public int Thang10 { set; get; }
        public int Thang11 { set; get; }
        public int Thang12 { set; get; }

    }
    public class BangLuong_DTO_View2
    {
        public int DiLam { set; get; }
        public int CoPhep { set; get; }
        public int KhongPhep { set; get; }
        public int Thang { set; get; }
        public int TongLuong { set; get; }
    }
}
