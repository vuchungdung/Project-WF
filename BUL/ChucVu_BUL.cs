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
    }
}
