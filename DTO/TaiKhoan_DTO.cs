using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoan_DTO
    {
        public string MaNV { set; get; }
        public string TenDangNhap { set; get; }
        public string MatKhau { set; get; }
        public string QuyenHan { set; get; }
    }
    public class TaiKhoan_DTO_NVCTK
    {
        public string MaNV { set; get; }
        public string TenNV { set; get; }
        public string TenCV { set; get; }
    }
    public class TaiKhoan_DTO_NVCoTK
    {
        public string MaNV { set; get; }
        public string TenNV { set; get; }
        public string TenCV { set; get; }
        public string TenDangNhap { set; get; }
        public string MatKhau { set; get; }
        public string QuyenHan { set; get; }
    }
}
