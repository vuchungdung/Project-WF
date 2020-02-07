using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TrinhDo_DAL
    {
        public List<TrinhDo_DTO> ReadTrinhDo()
        {
            string query = "Select * from TrinhDo";
            DataTable dataTable = new DataTable();
            dataTable = DataProvider.ReadData(query);
            List<TrinhDo_DTO> listTD = new List<TrinhDo_DTO>();
            if (dataTable != null && dataTable.Rows.Count > 0)
            {               
                for(int i = 0; i < dataTable.Rows.Count; i++)
                {
                    TrinhDo_DTO td = new TrinhDo_DTO();
                    td.MaTrinhDo = dataTable.Rows[i]["MaTrinhDo"].ToString();
                    td.TenTrinhDo = dataTable.Rows[i]["TenTrinhDo"].ToString();
                    td.GhiChu = dataTable.Rows[i]["GhiChu"].ToString();
                    listTD.Add(td);
                }
            }
            return listTD;
        }
    }
}
