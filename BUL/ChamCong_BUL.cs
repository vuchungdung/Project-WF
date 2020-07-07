using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUL
{
    public class ChamCong_BUL
    {
        ChamCong_DAL chamCong_DAL = new ChamCong_DAL();
        public List<ChamCong_DTO_View> LoadChamCong()
        {
            return chamCong_DAL.LoadChamCong();
        }
        public bool ThemChamCong(ChamCong_DTO cc)
        {
            return chamCong_DAL.ThemChamCong(cc);
        }
        public bool SuaChamCong(ChamCong_DTO cc)
        {
            return chamCong_DAL.SuaChamCong(cc);
        }
        public bool XoaChamCong(DateTime cc)
        {
            return chamCong_DAL.XoaChamCongTheoNgay(cc);
        }
        public List<ChamCong_DTO_View2> TheoDoiChamCong(string manv,int nam)
        {
            return chamCong_DAL.TheoDoiNgayCong(manv,nam);
        }
        public List<ChamCong_DTO_View2> TheoDoiChamCong2(string manv, int thang,int nam)
        {
            return chamCong_DAL.TheoDoiNgayCong2(manv, thang,nam);
        }
    }
}
