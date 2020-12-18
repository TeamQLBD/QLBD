using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QLBanDay
{
    class DAL
    {
        private SqlConnection GetConnect()
        {
            String connString = @"Data Source=DESKTOP-VOM8DSD\SQLEXPRESS;Initial Catalog=QLBanDay;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);
            return conn;
        }
        public DataTable GetTable(String sql)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = GetConnect()){
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(dt);
                con.Close();
            }
            return dt;
        }
        public void ExecuteNonQuery(String sql)
        {
            SqlConnection con = GetConnect();
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
        }
    }
}
