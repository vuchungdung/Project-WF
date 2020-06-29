using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUL
{
    public class ChucVu_BUL
    {
        ChucVu_DAL chucvu = new ChucVu_DAL();
        public List<ChucVu_DTO> LoadChucVu()
        {
            return chucvu.ReadChucVu();
        }
        public bool ThemChucVu(ChucVu_DTO cv)
        {
            return chucvu.ThemChucVu(cv);
        }
        public bool SuaChucVu(ChucVu_DTO cv)
        {
            return chucvu.SuaChucVu(cv);
        }
        public bool XoaChucVu(string macv)
        {
            return chucvu.XoaChucVu(macv);
        }
    }
}
