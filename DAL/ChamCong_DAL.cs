using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ChamCong_DAL
    {
        public List<ChamCong_DTO_View> LoadChamCong()
        {
            string query = "Select MaNV,HoTen from NhanVien";
            DataTable dataTable = new DataTable();
            dataTable = DataProvider.LoadData(query);
            List<ChamCong_DTO_View> ListNV = new List<ChamCong_DTO_View>();
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                ChamCong_DTO_View cc;
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    cc = new ChamCong_DTO_View();
                    cc.MaNV = dataTable.Rows[i]["MaNV"].ToString();
                    cc.HoTen = dataTable.Rows[i]["HoTen"].ToString();
                    ListNV.Add(cc);
                }
            }
            return ListNV;
        }
        public bool ThemChamCong(ChamCong_DTO cc)
        {
            string query = string.Format("Insert into ChamCong(MaNV,Ngay,TinhTrang) values('{0}','{1}',N'{2}')", cc.MaNV, cc.Ngay, cc.TinhTrang);
            bool result = DataProvider.QueryData(query);
            return result;
        }
        public bool SuaChamCong(ChamCong_DTO cc)
        {
            string query = string.Format("Update ChamCong set TinhTrang = N'"+cc.TinhTrang+"' where MaNV='"+cc.MaNV+"' and Ngay = '"+cc.Ngay+"'");
            bool result = DataProvider.QueryData(query);
            return result;
        }
        public bool XoaChamCongTheoNgay(DateTime ngay)
        {
            string query = string.Format("Delete ChamCong where Ngay='" + ngay + "'");
            bool result = DataProvider.QueryData(query);
            return result;
        }
        public List<ChamCong_DTO_View2> TheoDoiNgayCong(string manv,int nam)
        {
            string query = string.Format("select cc.Ngay as N'Ngay',"+
                "sum(case when cc.TinhTrang = N'Đi Làm' then 1 else 0 end) as DiLam,"+
	            "sum(case when cc.TinhTrang = N'Nghỉ Có Phép' then 1 else 0 end) as NghiCoPhep,"+
	            "sum(case when cc.TinhTrang = N'Nghỉ Không Phép' then 1 else 0 end) as NghiKhongPhep "+
                "from ChamCong cc where cc.MaNV = '"+manv+"' and YEAR(cc.Ngay) = "+nam+" group by cc.Ngay");
            DataTable dataTable = new DataTable();
            dataTable = DataProvider.LoadData(query);
            List<ChamCong_DTO_View2> ListNV = new List<ChamCong_DTO_View2>();
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                ChamCong_DTO_View2 cc;
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    cc = new ChamCong_DTO_View2();
                    cc.Ngay = Convert.ToDateTime(dataTable.Rows[i]["Ngay"]);
                    cc.DiLam = Convert.ToInt32(dataTable.Rows[i]["DiLam"]);
                    cc.NghiCoPhep = Convert.ToInt32(dataTable.Rows[i]["NghiCoPhep"]);
                    cc.NghiKhongPhep = Convert.ToInt32(dataTable.Rows[i]["NghiKhongPhep"]);
                    ListNV.Add(cc);
                }
            }
            return ListNV;
        }
        public List<ChamCong_DTO_View2> TheoDoiNgayCong2(string manv, int thang,int nam)
        {
            string query = string.Format("select cc.Ngay as N'Ngay'," +
                "sum(case when cc.TinhTrang = N'Đi Làm' then 1 else 0 end) as DiLam," +
                "sum(case when cc.TinhTrang = N'Nghỉ Có Phép' then 1 else 0 end) as NghiCoPhep," +
                "sum(case when cc.TinhTrang = N'Nghỉ Không Phép' then 1 else 0 end) as NghiKhongPhep " +
                "from ChamCong cc where cc.MaNV = '" + manv + "' and MONTH(cc.Ngay) = " + thang + " and YEAR(cc.Ngay) = "+nam+" group by cc.Ngay");
            DataTable dataTable = new DataTable();
            dataTable = DataProvider.LoadData(query);
            List<ChamCong_DTO_View2> ListNV = new List<ChamCong_DTO_View2>();
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                ChamCong_DTO_View2 cc;
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    cc = new ChamCong_DTO_View2();
                    cc.Ngay = Convert.ToDateTime(dataTable.Rows[i]["Ngay"]);
                    cc.DiLam = Convert.ToInt32(dataTable.Rows[i]["DiLam"]);
                    cc.NghiCoPhep = Convert.ToInt32(dataTable.Rows[i]["NghiCoPhep"]);
                    cc.NghiKhongPhep = Convert.ToInt32(dataTable.Rows[i]["NghiKhongPhep"]);
                    ListNV.Add(cc);
                }
            }
            return ListNV;
        }
    }
}
