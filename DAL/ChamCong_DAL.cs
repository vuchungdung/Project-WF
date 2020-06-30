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
            string query = string.Format("Insert into ChamCong(MaNV,Ngay,TinhTrang) values('{0}''{1}','{2}')", cc.MaNV, cc.Ngay, cc.TinhTrang);
            bool result = DataProvider.QueryData(query);
            return result;
        }
        public bool XoaChamCong(string ma)
        {
            string query = string.Format("Delete ChamCong where MaNV='"+ma+"'");
            bool result = DataProvider.QueryData(query);
            return result;
        }
        public bool XoaChamCongTheoNgay(DateTime ngay)
        {
            string query = string.Format("Delete ChamCong where MaNV='" + ngay + "'");
            bool result = DataProvider.QueryData(query);
            return result;
        }
    }
}
