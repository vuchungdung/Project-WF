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
        public List<BangLuong_DTO> LoadTinhLuong(int thang)
        {
            string query = "select nv.MaNV,nv.HoTen,cv.NgayLuong,MONTH(cc.Ngay) as Thang, "+
                                "sum((case when cc.TinhTrang = N'Đi Làm' then 1 else 0 end)) as DiLam, "+
                                "sum((case when cc.TinhTrang = N'Nghỉ Có Phép' then 1 else 0 end)) as CoPhep, "+
                                "sum((case when cc.TinhTrang = N'Nghỉ Không Phép' then 1 else 0 end)) as KhongPhep "+
                            "from dbo.ChamCong cc,dbo.ChucVu cv, dbo.NhanVien nv where cc.MaNV = nv.MaNV and nv.MaChucVu = cv.MaChucVu and MONTH(cc.Ngay) =" + thang+""+
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
            string query = string.Format("Insert into BangLuongNV(MaNV,TenNV,NgayLuong,SoNgayLam,Thang,CoPhep,KhongPhep,TongLuong,Nam) values(N'{0}',N'{1}','{2}','{3}',N'{4}','{5}','{6}','{7}','{8}')"
                , nv.MaNV, nv.TenNV, nv.NgayLuong, nv.DiLam, nv.Thang, nv.CoPhep, nv.KhongPhep,nv.TongLuong, nv.Nam);
            bool result = DataProvider.QueryData(query);
            return result;
        }
        public List<BangLuong_DTO> XemBangLuongTheoThang(int thang,int nam)
        {
            string query = "Select * from BangLuongNV nv where nv.Thang="+thang+" and nv.Nam = "+nam+"";
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
            string query = "Select * from BangLuongNV nv where nv.Nam=" + nam + " order by nv.Thang desc";
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
        public List<BangLuong_DTO_View> ThongKeLuongToanCongTy(int nam)
        {
            string query = "select bl.MaNV,"+
                "sum(case when bl.Thang = 1 then bl.TongLuong else 0 end) as Thang1,"+
	            "sum(case when bl.Thang = 2 then bl.TongLuong else 0 end) as Thang2,"+
	            "sum(case when bl.Thang = 3 then bl.TongLuong else 0 end) as Thang3,"+
	            "sum(case when bl.Thang = 4 then bl.TongLuong else 0 end) as Thang4,"+
	            "sum(case when bl.Thang = 5 then bl.TongLuong else 0 end) as Thang5,"+
	            "sum(case when bl.Thang = 6 then bl.TongLuong else 0 end) as Thang6,"+
	            "sum(case when bl.Thang = 7 then bl.TongLuong else 0 end) as Thang7,"+
	            "sum(case when bl.Thang = 8 then bl.TongLuong else 0 end) as Thang8,"+
	            "sum(case when bl.Thang = 9 then bl.TongLuong else 0 end) as Thang9,"+
	            "sum(case when bl.Thang = 10 then bl.TongLuong else 0 end) as Thang10,"+
	            "sum(case when bl.Thang = 11 then bl.TongLuong else 0 end) as Thang11,"+
	            "sum(case when bl.Thang = 12 then bl.TongLuong else 0 end) as Thang12 "+
                "from BangLuongNV bl where bl.Nam = "+nam+" group by bl.MaNV";
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
                    cc.Thang1 = Convert.ToInt32(dataTable.Rows[i]["Thang1"]);
                    cc.Thang2 = Convert.ToInt32(dataTable.Rows[i]["Thang2"]);
                    cc.Thang3 = Convert.ToInt32(dataTable.Rows[i]["Thang3"]);
                    cc.Thang4 = Convert.ToInt32(dataTable.Rows[i]["Thang4"]);
                    cc.Thang5 = Convert.ToInt32(dataTable.Rows[i]["Thang5"]);
                    cc.Thang6 = Convert.ToInt32(dataTable.Rows[i]["Thang6"]);
                    cc.Thang7 = Convert.ToInt32(dataTable.Rows[i]["Thang7"]);
                    cc.Thang8 = Convert.ToInt32(dataTable.Rows[i]["Thang8"]);
                    cc.Thang9 = Convert.ToInt32(dataTable.Rows[i]["Thang9"]);
                    cc.Thang10 = Convert.ToInt32(dataTable.Rows[i]["Thang10"]);
                    cc.Thang11 = Convert.ToInt32(dataTable.Rows[i]["Thang11"]);
                    cc.Thang12 = Convert.ToInt32(dataTable.Rows[i]["Thang12"]);
                    ListNV.Add(cc);
                }
            }
            return ListNV;
        }
        public List<BangLuong_DTO_View2> ThongKeLuongCaNhan(string manv,int nam)
        {
            string query = "select bl.Thang,bl.SoNgayLam,bl.CoPhep,bl.KhongPhep,bl.TongLuong from BangLuongNV bl where bl.MaNV = '"+manv+"'and bl.Nam = "+nam+" order by bl.Thang desc";
            DataTable dataTable = new DataTable();
            dataTable = DataProvider.LoadData(query);
            List<BangLuong_DTO_View2> ListNV = new List<BangLuong_DTO_View2>();
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                BangLuong_DTO_View2 cc;
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    cc = new BangLuong_DTO_View2();
                    cc.DiLam = Convert.ToInt32(dataTable.Rows[i]["SoNgayLam"]);
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
