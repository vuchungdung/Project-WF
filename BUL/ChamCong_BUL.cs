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
    }
}
