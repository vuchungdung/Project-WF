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
        public bool ChangePass(string tk, string mk)
        {
            return taiKhoan_DAL.ChangePass(tk, mk);
        }
        public TaiKhoan_DTO GetTaiKhoan(string tk,string mk)
        {
            return taiKhoan_DAL.GetTaiKhoan(tk, mk);
        }
    }
}
