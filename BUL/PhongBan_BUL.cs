using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUL
{
    public class PhongBan_BUL
    {
        PhongBan_DAL phongBan = new PhongBan_DAL();
        public List<PhongBan_DTO_View> LoadPB()
        {
            return phongBan.ReadPhongBan();
        }
        public bool ThemChucVu(PhongBan_DTO cv)
        {
            return phongBan.ThemPhongBan(cv);
        }
        public bool SuaChucVu(PhongBan_DTO cv)
        {
            return phongBan.SuaPhongBan(cv);
        }
        public bool XoaChucVu(string macv)
        {
            return phongBan.XoaPhongBan(macv);
        }
    }
}
