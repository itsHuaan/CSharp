using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiem.DAO
{
    public class DataProvider
    {
       private string connectionSTR = @"Data Source=.\SQLEXPRESS;Initial Catalog=qlDiemSv;Integrated Security=True";
        public DataTable ExecuteQuery(string query)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                connection.Close();
            }
         return dt;
        }
    }
}
