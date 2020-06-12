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
    }
}
