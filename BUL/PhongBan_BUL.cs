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
        public List<PhongBan_DTO> LoadPBChuaNV()
        {
            return phongBan.ReadPhongBanChuaNV();
        }
        public List<PhongBan_DTO> LoadAllPB()
        {
            return phongBan.ReadAllPhongBan();
        }
        public bool ThemPhongBan(PhongBan_DTO cv)
        {
            return phongBan.ThemPhongBan(cv);
        }
        public bool SuaPhongBan(PhongBan_DTO cv)
        {
            return phongBan.SuaPhongBan(cv);
        }
        public bool XoaPhongBan(string macv)
        {
            return phongBan.XoaPhongBan(macv);
        }
    }
}
