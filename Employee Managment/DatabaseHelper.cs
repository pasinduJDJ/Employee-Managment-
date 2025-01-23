using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient; 
using System.Data;

namespace Employee_Managment
{
    public class DatabaseHelper
    {
        private readonly string connectionString;
        public DatabaseHelper()
        {
            connectionString = @"Data Source=.;Initial Catalog=JDJHR;Integrated Security=True;TrustServerCertificate=True";
        }

        // Method to execute non-query commands (INSERT, UPDATE, DELETE)
        public int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }

                    con.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        // Method to fetch data (SELECT)
        public DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        return table;
                    }
                }
            }

        }

        public object ExecuteScalar(string query)
        {
            using (SqlConnection conn = new SqlConnection(connectionString)) 
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    return cmd.ExecuteScalar();
                }
            }
        }
    }
}
