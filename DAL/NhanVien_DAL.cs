using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NhanVien_DAL
    {
        public List<NhanVien_DTO> LoadNhanVien()
        {
            string query = "Select * from NhanVien";
            DataTable dataTable = new DataTable();
            dataTable = DataProvider.LoadData(query);
            List<NhanVien_DTO> ListNV = new List<NhanVien_DTO>();
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                NhanVien_DTO nv;
                for(int i = 0; i < dataTable.Rows.Count; i++)
                {
                    nv = new NhanVien_DTO();
                    nv.MaNhanVien = dataTable.Rows[i]["MaNV"].ToString();
                    nv.HoTen = dataTable.Rows[i]["HoTen"].ToString();
                    nv.GioiTinh = Convert.ToBoolean(dataTable.Rows[i]["GioiTinh"]);
                    nv.NgaySinh = Convert.ToDateTime(dataTable.Rows[i]["NgaySinh"]);
                    nv.DiaChi = dataTable.Rows[i]["DiaChi"].ToString();
                    nv.SoDienThoai = dataTable.Rows[i]["SoDienThoai"].ToString();
                    nv.ChucVu = dataTable.Rows[i]["MaChucVu"].ToString();
                    ListNV.Add(nv);
                }
            }
            return ListNV;
        }
        public List<NhanVien_DTO> LoadNhanVienTheoCV(string keyword)
        {
            string query = "Select * from NhanVien where MaChucVu='"+keyword+"'";
            DataTable dataTable = new DataTable();
            dataTable = DataProvider.LoadData(query);
            List<NhanVien_DTO> ListNV = new List<NhanVien_DTO>();
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                NhanVien_DTO nv;
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    nv = new NhanVien_DTO();
                    nv.MaNhanVien = dataTable.Rows[i]["MaNV"].ToString();
                    nv.HoTen = dataTable.Rows[i]["HoTen"].ToString();
                    nv.GioiTinh = Convert.ToBoolean(dataTable.Rows[i]["GioiTinh"]);
                    nv.NgaySinh = Convert.ToDateTime(dataTable.Rows[i]["NgaySinh"]);
                    nv.DiaChi = dataTable.Rows[i]["DiaChi"].ToString();
                    nv.SoDienThoai = dataTable.Rows[i]["SoDienThoai"].ToString();
                    nv.ChucVu = dataTable.Rows[i]["MaChucVu"].ToString();
                    ListNV.Add(nv);
                }
            }
            return ListNV;
        }
        public bool InsertNhanVien(NhanVien_DTO nv)
        {
            string query = string.Format("Insert into NhanVien(MaNV,HoTen,GioiTinh,NgaySinh,DiaChi,SoDienThoai,MaChucVu) values(N'{0}','{1}','{2}',N'{3}','{4}','{5}',{6})",nv.MaNhanVien, nv.HoTen, nv.GioiTinh, nv.NgaySinh, nv.DiaChi, nv.SoDienThoai, nv.ChucVu);
            bool result = DataProvider.QueryData(query);
            return result;
        }
        public bool DeleteNhanVien(string manv)
        {
            string query = string.Format("Delete from NhanVien where MaNV ="+manv);
            bool result = DataProvider.QueryData(query);
            return result;
        }
        public bool UpdateNhanVien(NhanVien_DTO nv)
        {
            string query = string.Format("Update NhanVien set MaNV='{0}',HoTen=N'{1}',GioiTinh='{2}',NgaySinh='{3}',DiaChi=N'{4}',SoDienThoai='{5}',MaChucVu='{6}'",nv.MaNhanVien ,nv.HoTen, nv.GioiTinh, nv.NgaySinh, nv.DiaChi, nv.SoDienThoai, nv.ChucVu);
            bool result = DataProvider.QueryData(query);
            return result;
        }
    }
}
