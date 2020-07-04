using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien_DTO
    {
        public string MaNhanVien { set; get; }
        public string HoTen { set; get; }
        public bool GioiTinh { set; get; }
        public DateTime NgaySinh { set; get; }
        public string DiaChi { set; get; }
        public string SoDienThoai { set; get; }
        public string ChucVu { set; get; }
        public string PhongBan { set; get; }
    }
}
