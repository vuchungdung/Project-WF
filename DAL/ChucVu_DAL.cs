using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ChucVu_DAL
    {
        public List<ChucVu_DTO> ReadChucVu()
        {
            string query = "Select * from ChucVu";
            DataTable dataTable = new DataTable();
            dataTable = DataProvider.ReadData(query);
            List<ChucVu_DTO> listTD = new List<ChucVu_DTO>();
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    ChucVu_DTO td = new ChucVu_DTO();
                    td.MaChucVu = dataTable.Rows[i]["MaChucVu"].ToString();
                    td.NgayLuong = Convert.ToInt32(dataTable.Rows[i]["NgayLuong"]);
                    td.TenChucVu = dataTable.Rows[i]["TenChucVu"].ToString();
                    listTD.Add(td);
                }
            }
            return listTD;
        }
        public bool ThemChucVu(ChucVu_DTO cv)
        {
            string query = string.Format("Insert into ChucVu(MaChucVu,NgayLuong,TenChucVu) values(N'{0}',N'{1}','{2}')", cv.MaChucVu, cv.NgayLuong,cv.TenChucVu);
            bool result = DataProvider.QueryData(query);
            return result;
        }
        public bool XoaChucVu(string macv)
        {
            string query = string.Format("Delete from ChucVu where MaNV ='" + macv + "'");
            bool result = DataProvider.QueryData(query);
            return result;
        }
        public bool SuaChucVu(ChucVu_DTO cv)
        {
            string query = string.Format("Update ChucVu set NgayLuong='{0}',TenChucVu='{1} where MaChucVu='{2}'", cv.NgayLuong, cv.TenChucVu, cv.MaChucVu);
            bool result = DataProvider.QueryData(query);
            return result;
        }
    }
        
}
