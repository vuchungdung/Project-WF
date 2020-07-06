using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUL
{
    public class TinhLuong_BUL
    {
        BangLuong_DAL bangLuong = new BangLuong_DAL();
        public List<BangLuong_DTO> LoadTinhLuong(int thang)
        {
            return bangLuong.LoadTinhLuong(thang);
        }
        public bool ThemBangLuong(BangLuong_DTO bl)
        {
            return bangLuong.InsertBangLuong(bl);
        }
    }
}
