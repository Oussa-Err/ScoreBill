using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scoreBill.Models
{
    public class DbConnection
    {
        public SqlConnection conn = new("Data Source=MAGIQUE;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;");
        public SqlConnection GetConn()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            return conn;
        }

        //function ExecNonQuery to perform CRUD ops 
        public int ExecNonQuery(SqlCommand command)
        {
            command.Connection = GetConn();
            int rowsAffected = -1;
            rowsAffected = command.ExecuteNonQuery();
            conn.Close();
            return rowsAffected;
        }

        //function ExecScalar to retrieve single value from db or query
        public object ExecScalar(SqlCommand command)
        {
            command.Connection = GetConn();
            object obj = -1;
            obj = command.ExecuteScalar();
            conn.Close();
            return obj;
        }

        //function ExecReader to perform Select query
        public DataTable ExecReader(SqlCommand command)
        {
            command.Connection = GetConn();
            SqlDataReader reader = command.ExecuteReader();
            DataTable dt = new();
            dt.Load(reader);
            conn.Close();
            return dt;
        }
    }
}
