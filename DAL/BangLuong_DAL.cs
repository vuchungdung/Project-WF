using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BangLuong_DAL
    {
        public List<BangLuong_DTO_View> LoadBangLuong()
        {
            string query = "Select nv.MaNV,nv.HoTen,cv.NgayLuong from NhanVien nv,ChucVu cv where nv.MaChucVu = cv.MaChucVu";
            DataTable dataTable = new DataTable();
            dataTable = DataProvider.LoadData(query);
            List<BangLuong_DTO_View> ListNV = new List<BangLuong_DTO_View>();
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                BangLuong_DTO_View cc;
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    cc = new BangLuong_DTO_View();
                    cc.MaNV = dataTable.Rows[i]["MaNV"].ToString();
                    cc.TenNV = dataTable.Rows[i]["HoTen"].ToString();
                    cc.NgayLuong = Convert.ToInt32(dataTable.Rows[i]["NgayLuong"]);
                    ListNV.Add(cc);
                }
            }
            return ListNV;
        }
        public int NgayLam(string manv,int thang)
        {
            string query = "Select count(cc.Ngay) from ChamCong cc where cc.MaNV = '"+manv+"' and MONTH(cc.Ngay) = "+thang+ " and cc.TinhTrang = N'Đi làm'";
            DataTable dataTable = new DataTable();
            dataTable = DataProvider.LoadData(query);
            int result = Convert.ToInt32(dataTable);
            return result;
        }
        public int NghiCoPhep(string manv, int thang)
        {
            string query = "Select count(cc.Ngay) from ChamCong cc where cc.MaNV = '" + manv + "' and MONTH(cc.Ngay) = " + thang + " and cc.TinhTrang = N'Nghỉ có phép'";
            DataTable dataTable = new DataTable();
            dataTable = DataProvider.LoadData(query);
            int result = Convert.ToInt32(dataTable);
            return result;
        }
        public int NghiKhongPhep(string manv, int thang)
        {
            string query = "Select count(cc.Ngay) from ChamCong cc where cc.MaNV = '" + manv + "' and MONTH(cc.Ngay) = " + thang + " and cc.TinhTrang = N'Nghỉ không phép'";
            DataTable dataTable = new DataTable();
            dataTable = DataProvider.LoadData(query);
            int result = Convert.ToInt32(dataTable);
            return result;
        }
        public bool InsertBangLuong(BangLuong_DTO nv)
        {
            string query = string.Format("Insert into BangLuongNV(MaNV,TenNV,NgayLuong,SoNgayLam,Thang,CoPhep,KhongPhep,TongLuong) values(N'{0}',N'{1}','{2}','{3}',N'{4}','{5}','{6}','{7}')"
                , nv.MaNV, nv.TenNV, nv.NgayLuong, nv.SoNgayLam, nv.Thang, nv.CoPhep, nv.KhongPhep,nv.TongLuong);
            bool result = DataProvider.QueryData(query);
            return result;
        }
        public List<BangLuong_DTO> XemBangLuongTheoThang(int thang)
        {
            string query = "Select * from BangLuongNV nv where nv.Thang="+thang+"";
            DataTable dataTable = new DataTable();
            dataTable = DataProvider.LoadData(query);
            List<BangLuong_DTO> ListNV = new List<BangLuong_DTO>();
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                BangLuong_DTO cc;
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    cc = new BangLuong_DTO();
                    cc.MaNV = dataTable.Rows[i]["MaNV"].ToString();
                    cc.TenNV = dataTable.Rows[i]["HoTen"].ToString();
                    cc.NgayLuong = Convert.ToInt32(dataTable.Rows[i]["NgayLuong"]);
                    cc.SoNgayLam = Convert.ToInt32(dataTable.Rows[i]["SoNgayLam"]);
                    cc.CoPhep = Convert.ToInt32(dataTable.Rows[i]["CoPhep"]);
                    cc.KhongPhep = Convert.ToInt32(dataTable.Rows[i]["KhongPhep"]);
                    cc.Thang = Convert.ToInt32(dataTable.Rows[i]["Thang"]);
                    cc.TongLuong = Convert.ToInt32(dataTable.Rows[i]["TongLuong"]);
                    ListNV.Add(cc);
                }
            }
            return ListNV;
        }
    }
}
