using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankProject.Models;
using Microsoft.Data.SqlClient;
using System.Data;

namespace BankProject.BankRepo
{
    internal class BankOperations : IBank
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;

        string connstr = "Server=192.168.0.13\\sqlexpress,49753; Database = IVP3685; User Id = sa; Password = sa@12345678; TrustServerCertificate = True;";
        public async Task GetAllCustomers()
        {
            conn = new SqlConnection(connstr);
            cmd = new SqlCommand("usp_FetchAll", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds);
            conn.Close();
            cmd.Dispose();
            conn.Dispose();

            foreach(DataRow row in ds.Tables[0].Rows)
            {
                Console.WriteLine($"{row[0]} - {row[1]} - {row[2]} - {row[3]} - {row[4]}");
            }
        }

        public async Task GetCustomerByAccType(string type)
        {
            conn = new SqlConnection(connstr);
            cmd = new SqlCommand("usp_FetchAccountType", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Type", type);

            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds);
            conn.Close();
            cmd.Dispose();
            conn.Dispose();

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                Console.WriteLine($"{row[0]} - {row[1]} - {row[2]} - {row[3]} - {row[4]}");
            }
        }

        public async Task<int> AddCustomer(Bank customer)
        {
            conn = new SqlConnection(connstr);
            await conn.OpenAsync();

            cmd = new SqlCommand("usp_Insert", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ID", customer.CID);
            cmd.Parameters.AddWithValue("@Name", customer.CName);
            cmd.Parameters.AddWithValue("@Type", customer.AccType);
            cmd.Parameters.AddWithValue("@Bal", customer.Balance);
            cmd.Parameters.AddWithValue("@Data", customer.Country);

            int a = await cmd.ExecuteNonQueryAsync();

            conn.Close();
            cmd.Dispose();
            conn.Dispose();

            if(a > 0)
            {
                Console.WriteLine("Procedure executed successfully. Customer Added Successfully.");
            }

            return a;
        }

        public async Task<int> UpdateCustomer(int id, float balance)
        {
            conn = new SqlConnection(connstr);
            await conn.OpenAsync();
            cmd = new SqlCommand("usp_Update", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ID", id);
            cmd.Parameters.AddWithValue("@Bal", balance);

            int a = await cmd.ExecuteNonQueryAsync();

            conn.Close();
            conn.Dispose();
            cmd.Dispose();

            if (a > 0)
            {
                Console.WriteLine("Procedure executed successfully. Update balance for CID = " + id);
            }

            return a;
        }

        public async Task<int> DeleteCustomer(int id)
        {
            conn = new SqlConnection(connstr);
            await conn.OpenAsync();
            cmd = new SqlCommand("usp_Delete", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ID", id);

            int a = await cmd.ExecuteNonQueryAsync();

            conn.Close();
            conn.Dispose();
            cmd.Dispose();

            if (a > 0)
            {
                Console.WriteLine("Procedure executed successfully. Deleted Customer ID = " + id);
            }

            return a;
        }
    }
}
