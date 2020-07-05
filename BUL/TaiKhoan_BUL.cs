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
        public bool CapNhatTaiKhoan(TaiKhoan_DTO tk)
        {
            return taiKhoan_DAL.UpdateTaiKhoan(tk);
        }
        public bool ThemTaiKhoan(TaiKhoan_DTO tk)
        {
            return taiKhoan_DAL.InsertTaiKhoan(tk);
        }
        public bool XoaTaiKhoan(string tk)
        {
            return taiKhoan_DAL.DeleteTaiKhoan(tk);
        }
        public List<TaiKhoan_DTO_NVCoTK> NhanVienCoTK()
        {
            return taiKhoan_DAL.NvCoTaiKhoan();
        }
        public List<TaiKhoan_DTO_NVCTK> NhanVienCTK()
        {
            return taiKhoan_DAL.NvCTaiKhoan();
        }
    }
}
