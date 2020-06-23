using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUL
{
    public class TaiKhoan_BUL
    {
        TaiKhoan_DAL taiKhoan_DAL = new TaiKhoan_DAL();
        public bool DangNhap(string user,string pass)
        {
            return taiKhoan_DAL.Login(user,pass);
        }
    }
}
