﻿using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUL
{    
    public class NhanVien_BUL
    {
        NhanVien_DAL nhanVien_DAL = new NhanVien_DAL();
        public List<NhanVien_DTO> LoadNhanVien()
        {
            return nhanVien_DAL.LoadNhanVien();
        }
        public List<NhanVien_DTO> TimNhanVien(string ma)
        {
            return nhanVien_DAL.TimNhanVien(ma);
        }
        public List<NhanVien_DTO> TimNhanVienTheoten(string ten)
        {
            return nhanVien_DAL.TimNhanVienTheoTen(ten);
        }
        public List<NhanVien_DTO> LoadNhanVienTheoPB(string keyword)
        {
            return nhanVien_DAL.LoadNhanVienTheoPB(keyword);
        }
        public bool InsertNhanVien(NhanVien_DTO nv)
        {
            return nhanVien_DAL.InsertNhanVien(nv);
        }
        public bool DeleteNhanVien(string manv)
        {
            return nhanVien_DAL.DeleteNhanVien(manv);
        }
        public bool UpdateNhanVien(NhanVien_DTO nv)
        {
            return nhanVien_DAL.UpdateNhanVien(nv);
        }
        public string LayChucVu(string manv)
        {
            return nhanVien_DAL.LayChucVu(manv);
        }
        public NhanVien_DTO GetNhanVien(string manv)
        {
            return nhanVien_DAL.GetNhanVien(manv);
        }
        public bool UpdateTTNhanVien(NhanVien_DTO nv)
        {
            return nhanVien_DAL.UpdateTTNhanVien(nv);
        }
    }
}
