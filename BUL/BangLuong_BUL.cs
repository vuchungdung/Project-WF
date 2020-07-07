using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUL
{
    public class BangLuong_BUL
    {
        BangLuong_DAL bangLuong = new BangLuong_DAL();

        public List<BangLuong_DTO> XemBangLuongTheoThang(int thang,int nam)
        {
            return bangLuong.XemBangLuongTheoThang(thang,nam);
        }
        public List<BangLuong_DTO> XemBangLuongTheoNam(int nam)
        {
            return bangLuong.XemBangLuongTheoNam(nam);
        }
        public List<BangLuong_DTO_View> ThongKeLuongToanCongTy(int nam)
        {
            return bangLuong.ThongKeLuongToanCongTy(nam);
        }
        public List<BangLuong_DTO_View2> ThongKeLuongCaNhan(string manv,int nam)
        {
            return bangLuong.ThongKeLuongCaNhan(manv,nam);
        }
    }
}
