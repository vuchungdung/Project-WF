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
                    nv.PhongBan = dataTable.Rows[i]["MaPB"].ToString();
                    ListNV.Add(nv);
                }
            }
            return ListNV;
        }
        public List<NhanVien_DTO> LoadNhanVienTheoPB(string keyword)
        {
            string query = "Select * from NhanVien where MaPB='"+keyword+"'";
            DataTable dataTable = new DataTable();
            dataTable = DataProvider.ReadData(query);
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
                    nv.PhongBan = dataTable.Rows[i]["MaPB"].ToString();
                    ListNV.Add(nv);
                }
            }
            return ListNV;
        }
        public bool InsertNhanVien(NhanVien_DTO nv)
        {
            string query = string.Format("Insert into NhanVien(MaNV,HoTen,GioiTinh,NgaySinh,DiaChi,SoDienThoai,MaChucVu,MaPB) values(N'{0}',N'{1}','{2}','{3}',N'{4}','{5}','{6}','{7}')",nv.MaNhanVien, nv.HoTen, nv.GioiTinh, nv.NgaySinh, nv.DiaChi, nv.SoDienThoai, nv.ChucVu, nv.PhongBan);
            bool result = DataProvider.QueryData(query);
            return result;
        }
        public bool DeleteNhanVien(string manv)
        {
            string query = string.Format("Delete from NhanVien where MaNV ='"+manv+"'");
            bool result = DataProvider.QueryData(query);
            return result;
        }
        public bool UpdateNhanVien(NhanVien_DTO nv)
        {
            string query = string.Format("Update NhanVien set HoTen=N'{0}',GioiTinh='{1}',NgaySinh='{2}',DiaChi=N'{3}',SoDienThoai='{4}',MaChucVu='{5}',MaPB ='{7}' where MaNV='{6}'",nv.HoTen, nv.GioiTinh, nv.NgaySinh, nv.DiaChi, nv.SoDienThoai, nv.ChucVu, nv.MaNhanVien,nv.PhongBan);
            bool result = DataProvider.QueryData(query);
            return result;
        }
        public string LayChucVu(string manv)
        {
            string query = "Select cv.TenChucVu from NhanVien nv, ChucVu cv where nv.MaChucVu=cv.MaChucVu and nv.MaNV='"+manv+"'";
            DataTable dataTable = new DataTable();
            dataTable = DataProvider.ReadData(query);
            int a = dataTable.Rows.Count;
            string result = dataTable.Rows[0]["TenChucVu"].ToString();
            return result;
        }
        public NhanVien_DTO GetNhanVien(string manv)
        {
            string query = "Select * from NhanVien where MaNV='" + manv + "'";
            DataTable dataTable = new DataTable();
            dataTable = DataProvider.ReadData(query);           
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                NhanVien_DTO nv = new NhanVien_DTO();
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {                   
                    nv.HoTen = dataTable.Rows[i]["HoTen"].ToString();
                    nv.GioiTinh = Convert.ToBoolean(dataTable.Rows[i]["GioiTinh"]);
                    nv.NgaySinh = Convert.ToDateTime(dataTable.Rows[i]["NgaySinh"]);
                    nv.DiaChi = dataTable.Rows[i]["DiaChi"].ToString();
                    nv.SoDienThoai = dataTable.Rows[i]["SoDienThoai"].ToString();
                }
                return nv;
            }
            return null;
        }
        public bool UpdateTTNhanVien(NhanVien_DTO nv)
        {
            string query = string.Format("Update NhanVien set HoTen=N'{0}',GioiTinh='{1}',NgaySinh='{2}',DiaChi=N'{3}',SoDienThoai='{4}' where MaNV='{5}'", nv.HoTen, nv.GioiTinh, nv.NgaySinh, nv.DiaChi, nv.SoDienThoai, nv.MaNhanVien);
            bool result = DataProvider.QueryData(query);
            return result;
        }
        public List<NhanVien_DTO> TimNhanVien(string manv)
        {
            string query = "Select * from NhanVien where MaNV='" + manv + "'";
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
                    nv.PhongBan = dataTable.Rows[i]["MaPB"].ToString();
                    ListNV.Add(nv);
                }
            }
            return ListNV;
        }
        public List<NhanVien_DTO> TimNhanVienTheoTen(string tennv)
        {
            string query = "Select * from NhanVien where HoTen like'% " + tennv + "'";
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
                    nv.PhongBan = dataTable.Rows[i]["MaPB"].ToString();
                    ListNV.Add(nv);
                }
            }
            return ListNV;
        }
    }
}
