using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUL
{
    public class TrinhDo_BUL
    {
        TrinhDo_DAL trinhDo_DAL = new TrinhDo_DAL();
        public List<TrinhDo_DTO> LoadTrinhDo()
        {
            return trinhDo_DAL.ReadTrinhDo();
        }
    }
}
