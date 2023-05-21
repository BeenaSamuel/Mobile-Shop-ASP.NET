using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
namespace mobile_shop
{
    public partial class view : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data source = DESKTOP-5F28KRT\\SQLEXPRESS; initial catalog = mobileshop; persist security info = True; Integrated Security = SSPI");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from mobile1 ", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            DataSet ds = new DataSet();
            sda.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data source = DESKTOP-5F28KRT\\SQLEXPRESS; initial catalog = mobileshop; persist security info = True; Integrated Security = SSPI");
            con.Open();
            String not_sold = "Not Sold";
           
            SqlCommand cmd = new SqlCommand("select * from mobile1 where Status = '" +not_sold+"' ", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            DataSet ds = new DataSet();
            sda.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data source = DESKTOP-5F28KRT\\SQLEXPRESS; initial catalog = mobileshop; persist security info = True; Integrated Security = SSPI");
            con.Open();
            String sold = "Sold";
            SqlCommand cmd = new SqlCommand("select * from mobile1 where Status = '" + sold + "' ", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            DataSet ds = new DataSet();
            sda.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
    }
}