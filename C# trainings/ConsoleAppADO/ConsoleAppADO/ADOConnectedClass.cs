using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ConsoleAppADO
{
    internal class ADOConnectedClass
    {
        string connstr = "Server = 192.168.0.13\\sqlexpress,49753; Database = IVP3685; User ID = sa; Password = sa@12345678; TrustServerCertificate = True";

        string connstr1 = "Data Source=192.168.0.13\\sqlexpress,49753; Initial Catalog = IVP3685, User ID = sa; Password = sa@12345678; TrustServerCertificate = True";

        string query1 = "insert into Bank(CID,CName,AccType, Balance, Country) values(90, 'Avni', 'Saving', 932324223, 'USA');";
        
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader dr;

        public void FetchData()
        {
            string query4 = "select * from bank;";
            conn = new SqlConnection(connstr);
            conn.Open();
            cmd = new SqlCommand(query4, conn);

            dr = cmd.ExecuteReader();
            
            while(dr.Read())
            {
                Console.WriteLine($"{dr[0]} - {dr["CName"]} - {dr[2]} - {dr[3]} - {dr[4]}");
            }

            conn.Close();
            if(dr != null ) { dr.Close(); }
            cmd.Dispose();
        }

        public void FetchDataAccType(string accType)
        {
            string query4 = "select * from bank where accType = '" + accType + "'";
            conn = new SqlConnection(connstr);
            conn.Open();
            cmd = new SqlCommand(query4, conn);

            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Console.WriteLine($"{dr[0]} - {dr["CName"]} - {dr[2]} - {dr[3]} - {dr[4]}");
            }

            conn.Close();
            if (dr != null) { dr.Close(); }
            cmd.Dispose();
        }

        public void FetchMultipleData()
        {
            string query4 = "select * from bank; select * from student;";
            conn = new SqlConnection(connstr);
            conn.Open();
            cmd = new SqlCommand(query4, conn);

            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Console.WriteLine($"{dr[0]} - {dr["CName"]} - {dr[2]} - {dr[3]} - {dr[4]}");
            }

            while (dr.NextResult())
            {
                while (dr.Read())
                {
                    Console.WriteLine($"{dr[0]} - {dr["SName"]} - {dr[2]} - {dr["Marks"]}");
                }
            }

            conn.Close();
            if (dr != null) { dr.Close(); }
            cmd.Dispose();
        }

        public void InsertData()
        {
            try
            {
                conn = new SqlConnection(connstr);
                conn.Open();
                cmd = new SqlCommand(query1, conn);
                int a = cmd.ExecuteNonQuery();
                Console.WriteLine(a + " Records Inserted Successfully");

                conn.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if(cmd != null)
                {
                    cmd.Dispose();
                }
                conn.Dispose();
            }
        }

        public void DeleteData()
        {
            try
            {
                int id = int.Parse(Console.ReadLine());
                string query2 = "delete from bank where CID = "+id;
                conn = new SqlConnection(connstr);
                conn.Open();
                cmd = new SqlCommand(query2, conn);
                int a = cmd.ExecuteNonQuery();
                Console.WriteLine(a + " Records Deleted Successfully");

                conn.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (cmd != null)
                {
                    cmd.Dispose();
                }
                conn.Dispose();
            }
        }

        string query3 = "update bank set balance = 999999 where CID = 20";
        public void UpdateData()
        {
            try
            {
                conn = new SqlConnection(connstr);
                conn.Open();
                cmd = new SqlCommand(query3, conn);
                int a = cmd.ExecuteNonQuery();
                Console.WriteLine(a + " Records Updated Successfully");

                conn.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (cmd != null)
                {
                    cmd.Dispose();
                }
                conn.Dispose();
            }
        }
    }
}
