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
        public List<BangLuong_DTO> LoadTinhLuong()
        {
            string query = "select nv.MaNV,nv.HoTen,cv.NgayLuong,MONTH(cc.Ngay) as Thang, "+
                                "sum((case when cc.TinhTrang = N'Đi Làm' then 1 else 0 end)) as DiLam, "+
                                "sum((case when cc.TinhTrang = N'Nghỉ Có Phép' then 1 else 0 end)) as CoPhep, "+
                                "sum((case when cc.TinhTrang = N'Nghỉ Không Phép' then 1 else 0 end)) as KhongPhep "+
                            "from dbo.ChamCong cc,dbo.ChucVu cv, dbo.NhanVien nv where cc.MaNV = nv.MaNV and nv.MaChucVu = cv.MaChucVu"+
                            " group by nv.MaNV,nv.HoTen,cv.NgayLuong,MONTH(cc.Ngay)";
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
                    cc.Thang = Convert.ToInt32(dataTable.Rows[i]["Thang"]);
                    cc.DiLam = Convert.ToInt32(dataTable.Rows[i]["DiLam"]);
                    cc.CoPhep = Convert.ToInt32(dataTable.Rows[i]["CoPhep"]);
                    cc.KhongPhep = Convert.ToInt32(dataTable.Rows[i]["KhongPhep"]);
                    cc.Nam = DateTime.Now.Year;
                    ListNV.Add(cc);
                }
            }
            return ListNV;
        }
        public bool InsertBangLuong(BangLuong_DTO nv)
        {
            string query = string.Format("Insert into BangLuongNV(MaNV,TenNV,NgayLuong,SoNgayLam,Thang,CoPhep,KhongPhep,TongLuong) values(N'{0}',N'{1}','{2}','{3}',N'{4}','{5}','{6}','{7}')"
                , nv.MaNV, nv.TenNV, nv.NgayLuong, nv.DiLam, nv.Thang, nv.CoPhep, nv.KhongPhep,nv.TongLuong);
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
                    cc.TenNV = dataTable.Rows[i]["TenNV"].ToString();
                    cc.NgayLuong = Convert.ToInt32(dataTable.Rows[i]["NgayLuong"]);
                    cc.DiLam = Convert.ToInt32(dataTable.Rows[i]["SoNgayLam"]);
                    cc.CoPhep = Convert.ToInt32(dataTable.Rows[i]["CoPhep"]);
                    cc.KhongPhep = Convert.ToInt32(dataTable.Rows[i]["KhongPhep"]);
                    cc.Thang = Convert.ToInt32(dataTable.Rows[i]["Thang"]);
                    cc.TongLuong = Convert.ToInt32(dataTable.Rows[i]["TongLuong"]);
                    cc.Nam = Convert.ToInt32(dataTable.Rows[i]["Nam"]);
                    ListNV.Add(cc);
                }
            }
            return ListNV;
        }
        public List<BangLuong_DTO> XemBangLuongTheoNam(int nam)
        {
            string query = "Select * from BangLuongNV nv where nv.Nam=" + nam + "";
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
                    cc.TenNV = dataTable.Rows[i]["TenNV"].ToString();
                    cc.NgayLuong = Convert.ToInt32(dataTable.Rows[i]["NgayLuong"]);
                    cc.DiLam = Convert.ToInt32(dataTable.Rows[i]["SoNgayLam"]);
                    cc.CoPhep = Convert.ToInt32(dataTable.Rows[i]["CoPhep"]);
                    cc.KhongPhep = Convert.ToInt32(dataTable.Rows[i]["KhongPhep"]);
                    cc.Thang = Convert.ToInt32(dataTable.Rows[i]["Thang"]);
                    cc.TongLuong = Convert.ToInt32(dataTable.Rows[i]["TongLuong"]);
                    cc.Nam = Convert.ToInt32(dataTable.Rows[i]["Nam"]);
                    ListNV.Add(cc);
                }
            }
            return ListNV;
        }
    }
}
