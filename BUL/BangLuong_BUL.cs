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
    }
}
