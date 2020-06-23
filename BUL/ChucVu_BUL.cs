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
        ChucVu_DAL chucVu_DAL = new ChucVu_DAL();
        public List<ChucVu_DTO> LoadChucVu()
        {
            return chucVu_DAL.ReadChucVu();
        }
        public bool ThemChucVu(ChucVu_DTO cv)
        {
            return chucVu_DAL.ThemChucVu(cv);
        }
        public bool SuaChucVu(ChucVu_DTO cv)
        {
            return chucVu_DAL.SuaChucVu(cv);
        }
        public bool XoaChucVu(string macv)
        {
            return chucVu_DAL.XoaChucVu(macv);
        }
    }
}
