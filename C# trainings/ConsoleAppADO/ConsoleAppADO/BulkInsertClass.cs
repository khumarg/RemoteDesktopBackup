using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace ConsoleAppADO
{
    internal class BulkInsertClass
    {
        string connstr = "Server = 192.168.0.13\\sqlexpress,49753; Database = IVP3685; User ID = sa; Password = sa@12345678; TrustServerCertificate = True";

        public void BulkOperation()
        {
            using (SqlConnection source = new SqlConnection(connstr))
            {
                source.Open();

                SqlCommand cmd = new SqlCommand("Select * from Bank;", source);

                using(SqlDataReader dr = cmd.ExecuteReader())
                {
                    using (SqlConnection destination = new SqlConnection(connstr))
                    {
                        destination.Open();

                        using (SqlBulkCopy bcp = new SqlBulkCopy(destination))
                        {
                            bcp.BatchSize = 5;
                            bcp.DestinationTableName = "NewBank";
                            bcp.WriteToServer(dr);
                        }
                    }
                }
            }
        }
    }
}
