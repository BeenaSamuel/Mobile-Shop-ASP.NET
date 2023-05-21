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
    public partial class add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data source = DESKTOP-5F28KRT\\SQLEXPRESS; initial catalog = mobileshop; persist security info = True; Integrated Security = SSPI");
            con.Open();
            string status = "Not Sold";
            String nullDateTime = null;
            SqlCommand cmd = new SqlCommand("insert into mobile1 values('"+TextBox1.Text+"','"+TextBox2.Text+"','"+DropDownList3.SelectedValue+"','"+DropDownList2.SelectedValue+"','"+DropDownList1.SelectedValue+"','"+TextBox4.Text+ "','" + TextBox3.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','"+ nullDateTime + "','"+status+"')", con);
            cmd.ExecuteNonQuery();
            Response.Write("<script language=javascript>alert('New mobile details added successfully');</script>");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("view.aspx");
        }
    }
}