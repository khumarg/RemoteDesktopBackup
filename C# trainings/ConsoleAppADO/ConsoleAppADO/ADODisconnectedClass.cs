using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sql;
using Microsoft.Data.SqlClient;

namespace ConsoleAppADO
{
    internal class ADODisconnectedClass
    {
        string conn = "Server = 192.168.0.13\\sqlexpress,49753; Database = IVP3685; User ID = sa; Password = sa@12345678; TrustServerCertificate = True";
        string query1 = "select * from bank;";
        string query2 = "select * from student;";

        SqlDataAdapter da;
        DataSet ds;
        public void FetchData()
        {
            da = new SqlDataAdapter(query1, conn);
            ds = new DataSet();
            da.Fill(ds, "Bank");

            foreach(DataRow row in ds.Tables["Bank"].Rows)
            {
                Console.WriteLine($"{row[0]} - {row[1]} - {row[2]} - {row["Balance"]} - {row["Country"]}");
            }

            SqlDataAdapter da1 = new SqlDataAdapter(query2, conn);
            da1.Fill(ds, "Student");

            foreach (DataRow row in ds.Tables["Student"].Rows)
            {
                Console.WriteLine($"{row[0]} - {row[1]} - {row[2]} - {row["Marks"]}");
            }
        }
    }
}
