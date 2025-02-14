using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.Data.SqlClient;

namespace BankWebApp
{
    public partial class Register : System.Web.UI.Page
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;

        string str = ConfigurationManager.ConnectionStrings["IVPBank"].ConnectionString.ToString();

        protected void Button1_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(str);
            conn.Open();

            cmd = new SqlCommand("usp_Insert", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ID", int.Parse(TextBox1.Text));
            cmd.Parameters.AddWithValue("@Name", TextBox2.Text);
            cmd.Parameters.AddWithValue("@Type", DropDownList1.SelectedItem.Text);
            cmd.Parameters.AddWithValue("@Bal", float.Parse(TextBox3.Text));
            cmd.Parameters.AddWithValue("@Data", TextBox4.Text);

            int a = cmd.ExecuteNonQuery();

            conn.Close();
            cmd.Dispose();
            conn.Dispose();

            if (a > 0)
            {
                Label6.Text = "Record Inserted Successfully.";
            }
        }
        
        protected void Button2_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(str);
            cmd = new SqlCommand("usp_FetchAll", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds);
            conn.Close();
            cmd.Dispose();
            conn.Dispose();

            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(str);
            conn.Open();

            cmd = new SqlCommand("usp_Update", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ID", int.Parse(TextBox1.Text));
            cmd.Parameters.AddWithValue("@Bal", int.Parse(TextBox3.Text));

            int a = cmd.ExecuteNonQuery();

            conn.Close();
            cmd.Dispose();
            conn.Dispose();

            if (a > 0)
            {
                Label6.Text = "Procedure executed successfully. Customer Updated Successfully.";
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        { 
            conn = new SqlConnection(str);
            cmd = new SqlCommand("usp_FetchAccountType", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Type", DropDownList1.SelectedItem.Text);

            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds);
            conn.Close();
            cmd.Dispose();
            conn.Dispose();

            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(str);
            conn.Open();
            cmd = new SqlCommand("usp_Delete", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ID", int.Parse(TextBox1.Text));

            int a = cmd.ExecuteNonQuery();

            conn.Close();
            conn.Dispose();
            cmd.Dispose();

            if (a > 0)
            {
                Label6.Text = "Procedure executed successfully. Deleted Customer ID = " + TextBox1.Text;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}