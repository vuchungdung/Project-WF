using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TaiKhoan_DAL
    {
        public bool Login(string user,string pass)
        {
            DataTable dataTable = new DataTable();
            string query = "Select * from TaiKhoan where TenDangNhap ='"+user+"' and MatKhau = '"+pass+"'";            
            dataTable = DataProvider.ReadData(query);
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
