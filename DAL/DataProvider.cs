using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataProvider
    {
        public static SqlConnection ConnectDB()
        {
            SqlConnection Connect = new SqlConnection();
            string connectString = @"Data Source=DESKTOP-6HF17VS\SQLEXPRESS;Initial Catalog=QuanLyChamCong;Integrated Security=True";
            Connect.ConnectionString = connectString;
            Connect.Open();
            return Connect;
        }
        public static DataTable LoadData(string query)
        {
            try
            {
                DataTable dataTable = new DataTable();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, ConnectDB());
                sqlDataAdapter.Fill(dataTable);
                ConnectDB().Close();
                return dataTable;
            }catch(Exception ex)
            {
                ConnectDB().Close();
                return null;
            }
        }
        public static DataTable ReadData(string query)
        {
            try
            {
                DataTable dataTable = new DataTable();
                SqlCommand cmd = new SqlCommand(query, ConnectDB());
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                dataTable.Load(sqlDataReader);
                ConnectDB().Close();
                return dataTable;
            }catch(Exception ex)
            {
                ConnectDB().Close();
                return null;
            }
        }
    }
}
