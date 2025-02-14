using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace ConsoleAppADO
{
    internal class SPClass
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter adapter;
        DataSet ds;

        string connstr = "Server = 192.168.0.13\\sqlexpress,49753; Database = IVP3685; User ID = sa; Password = sa@12345678; TrustServerCertificate = True";
        public void SPInsert()
        {
            conn = new SqlConnection(connstr);
            conn.Open();

            cmd = new SqlCommand("usp_Insert", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ID", 200);
            cmd.Parameters.AddWithValue("@Name", "Vicky");
            cmd.Parameters.AddWithValue("@Type", "Joint");
            cmd.Parameters.AddWithValue("@Bal", 32322);
            cmd.Parameters.AddWithValue("@Data", "India");

            int a = cmd.ExecuteNonQuery();
            Console.WriteLine("Procedure Executed Successfully");
            conn.Close();
            cmd.Dispose();
            conn.Dispose();
        }

        public void SPDelete()
        {
            conn = new SqlConnection(connstr);
            conn.Open();

            cmd = new SqlCommand("usp_Delete", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", 200);

            int a = cmd.ExecuteNonQuery();
            Console.WriteLine("Procedure Executed Successfully");
            conn.Close();
            cmd.Dispose();
            conn.Dispose();
        }

        public void SPUpdate()
        {
            conn = new SqlConnection(connstr);
            conn.Open();

            cmd = conn.CreateCommand();
            cmd.CommandText = "usp_Update";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", 200);
            cmd.Parameters.AddWithValue("@Bal", 32322);

            int a = cmd.ExecuteNonQuery();
            Console.WriteLine("Procedure Executed Successfully");
            conn.Close();
            cmd.Dispose();
            conn.Dispose();
        }

        public void SPFetch()
        {
            conn = new SqlConnection(connstr);
            conn.Open();
            cmd = new SqlCommand("usp_FetchAll", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            adapter = new SqlDataAdapter(cmd);

            ds = new DataSet();
            adapter.Fill(ds);

            conn.Close();
            cmd.Dispose();
            conn.Dispose();

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                Console.WriteLine($"{row[0]} \t {row[1]} \t {row[2]} \t {row[3]} \t {row[4]}");
            }
        }

        public void SPFetchAccountType()
        {
            conn = new SqlConnection(connstr);
            conn.Open();
            cmd = new SqlCommand("usp_FetchAccountType", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@type", "saving");
            adapter = new SqlDataAdapter(cmd);

            SqlDataReader dr = cmd.ExecuteReader();
            ds = new DataSet();
            DataTable dt = new DataTable();
            dt.Load(dr);
            ds.Tables.Add(dt);

            conn.Close();
            cmd.Dispose();
            conn.Dispose();

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                Console.WriteLine($"{row[0]} \t {row[1]} \t {row[2]} \t {row[3]} \t {row[4]}");
            }
        }
    }

}
