using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PhongBan_DAL
    {
        public List<PhongBan_DTO_View> ReadPhongBan()
        {
            string query = string.Format("select pb.MaPB,pb.TenPB,count(nv.MaNV) SoLuong from NhanVien nv, PhongBan pb where pb.MaPB = nv.MaPB group by pb.MaPB,pb.TenPB");
            DataTable dataTable = new DataTable();
            dataTable = DataProvider.ReadData(query);
            List<PhongBan_DTO_View> listTD = new List<PhongBan_DTO_View>();
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    PhongBan_DTO_View td = new PhongBan_DTO_View();
                    td.MaPB = dataTable.Rows[i]["MaPB"].ToString();
                    td.TenPB = dataTable.Rows[i]["TenPB"].ToString();
                    td.SoNV = Convert.ToInt32(dataTable.Rows[i]["SoLuong"]);
                    listTD.Add(td);
                }
            }
            return listTD;
        }
        public bool ThemPhongBan(PhongBan_DTO cv)
        {
            string query = string.Format("Insert into PhongBan(MaPB,TenPB) values(N'{0}',N'{1}')", cv.MaPB, cv.TenPB);
            bool result = DataProvider.QueryData(query);
            return result;
        }
        public bool XoaPhongBan(string macv)
        {
            string query = string.Format("Delete from PhongBan where MaPB ='" + macv + "'");
            bool result = DataProvider.QueryData(query);
            return result;
        }
        public bool SuaPhongBan(PhongBan_DTO cv)
        {
            string query = string.Format("Update PhongBan set TenPB='{0}' where MaPB='{1}'", cv.TenPB,cv.MaPB);
            bool result = DataProvider.QueryData(query);
            return result;
        }
    }
}
