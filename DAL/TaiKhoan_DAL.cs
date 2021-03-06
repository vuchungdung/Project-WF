﻿using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TaiKhoan_DAL
    {
        public bool Login(string user,string pass)
        {
            DataTable dataTable = new DataTable();
            string query = "Select * from TaiKhoan where TenDangNhap ='"+user+"' and MatKhau = '"+pass+"'";            
            dataTable = DataProvider.ReadData(query);
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public List<TaiKhoan_DTO_NVCTK> NvCTaiKhoan()
        {
            string query = "Select nv.MaNV,nv.HoTen,cv.TenChucVu from NhanVien nv, ChucVu cv where nv.MaChucVu=cv.MaChucVu and nv.MaNV not in (select tk.MaNV from TaiKhoan tk)";
            DataTable dataTable = new DataTable();
            dataTable = DataProvider.ReadData(query);
            List<TaiKhoan_DTO_NVCTK> ListNV = new List<TaiKhoan_DTO_NVCTK>();
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                TaiKhoan_DTO_NVCTK nv;
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    nv = new TaiKhoan_DTO_NVCTK();
                    nv.MaNV = dataTable.Rows[i]["MaNV"].ToString();
                    nv.TenNV = dataTable.Rows[i]["HoTen"].ToString();
                    nv.TenCV = dataTable.Rows[i]["TenChucVu"].ToString();
                    ListNV.Add(nv);
                }
            }
            return ListNV;
        }
        public List<TaiKhoan_DTO_NVCoTK> NvCoTaiKhoan()
        {
            string query = "Select nv.MaNV,nv.HoTen,cv.TenChucVu,tk.TenDangNhap,tk.MatKhau,tk.TenQuyenHan from NhanVien nv, ChucVu cv, TaiKhoan tk where nv.MaChucVu=cv.MaChucVu and nv.MaNV = tk.MaNV";
            DataTable dataTable = new DataTable();
            dataTable = DataProvider.ReadData(query);
            List<TaiKhoan_DTO_NVCoTK> ListNV = new List<TaiKhoan_DTO_NVCoTK>();
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                TaiKhoan_DTO_NVCoTK nv;
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    nv = new TaiKhoan_DTO_NVCoTK();
                    nv.MaNV = dataTable.Rows[i]["MaNV"].ToString();
                    nv.TenNV = dataTable.Rows[i]["HoTen"].ToString();
                    nv.TenCV = dataTable.Rows[i]["TenChucVu"].ToString();
                    nv.TenDangNhap = dataTable.Rows[i]["TenDangNhap"].ToString();
                    nv.MatKhau = dataTable.Rows[i]["MatKhau"].ToString();
                    nv.QuyenHan = dataTable.Rows[i]["TenQuyenHan"].ToString();
                    ListNV.Add(nv);
                }
            }
            return ListNV;
        }
        public bool InsertTaiKhoan(TaiKhoan_DTO nv)
        {
            string query = string.Format("Insert into TaiKhoan(MaNV,TenDangNhap,MatKhau,TenQuyenHan) values('{0}','{1}','{2}','{3}')", nv.MaNV, nv.TenDangNhap, nv.MatKhau, nv.QuyenHan);
            bool result = DataProvider.QueryData(query);
            return result;
        }
        public bool DeleteTaiKhoan(string tk)
        {
            string query = string.Format("Delete from TaiKhoan where TenDangNhap ='" + tk + "'");
            bool result = DataProvider.QueryData(query);
            return result;
        }
        public bool UpdateTaiKhoan(TaiKhoan_DTO nv)
        {
            string query = string.Format("Update TaiKhoan set MatKhau='{0}',TenQuyenHan='{1}' where TenDangNhap='{2}'", nv.MatKhau, nv.QuyenHan, nv.TenDangNhap);
            bool result = DataProvider.QueryData(query);
            return result;
        }
        public bool ChangePass(string tk,string mk)
        {
            string query = string.Format("Update TaiKhoan set MatKhau='{0}' where TenDangNhap='{1}'", mk, tk);
            bool result = DataProvider.QueryData(query);
            return result;
        }
        public TaiKhoan_DTO GetTaiKhoan(string tk,string mk) 
        {
            string query = "Select tk.TenDangNhap, tk.MatKhau, tk.TenQuyenHan, tk.MaNV from TaiKhoan tk where tk.TenDangNhap = '"+tk+"' and tk.MatKhau = '"+mk+"'";
            DataTable dataTable = new DataTable();
            dataTable = DataProvider.ReadData(query);
            TaiKhoan_DTO model;
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                model = new TaiKhoan_DTO();
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {                  
                    model.MaNV = dataTable.Rows[i]["MaNV"].ToString();                  
                    model.TenDangNhap = dataTable.Rows[i]["TenDangNhap"].ToString();
                    model.MatKhau = dataTable.Rows[i]["MatKhau"].ToString();
                    model.QuyenHan = dataTable.Rows[i]["TenQuyenHan"].ToString();                    
                }
                return model;
            }
            else
            {
                return null;
            }
        }
    }
}
