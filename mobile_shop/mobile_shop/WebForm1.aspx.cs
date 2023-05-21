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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data source = DESKTOP-5F28KRT\\SQLEXPRESS; initial catalog = mobileshop; persist security info = True; Integrated Security = SSPI");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from mobile1 where Brand = '" + DropDownList1.SelectedValue + "' and ModelNo = '" + DropDownList2.Text + "' and RAM = '" + DropDownList5.Text + "' and Processor = '" + DropDownList3.SelectedValue + "' and Battery = '" + DropDownList4.SelectedValue + "'and Storage = '" + DropDownList6.SelectedValue + "' ", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            DataSet ds = new DataSet();
            sda.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data source = DESKTOP-5F28KRT\\SQLEXPRESS; initial catalog = mobileshop; persist security info = True; Integrated Security = SSPI");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from mobile1 where Brand = '" + DropDownList1.SelectedValue + "' and ModelNo = '" + DropDownList2.Text + "' and RAM = '" + DropDownList5.Text + "' and Processor = '" + DropDownList3.SelectedValue + "' and Battery = '" + DropDownList4.SelectedValue + "'and Storage = '" + DropDownList6.SelectedValue + "' ", con);
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                dr.Close();
                string status = "Sold";
                SqlCommand cmd2 = new SqlCommand("update mobile1 set Status = '"+status+"' where Brand = '"+DropDownList1.SelectedValue+"' and ModelNo = '"+DropDownList2.SelectedValue+"' and ram = '"+DropDownList5.SelectedValue+"' and Processor = '"+DropDownList3.SelectedValue+"' and Battery = '"+DropDownList4.SelectedValue+"' and Storage = '"+DropDownList6.SelectedValue+"'", con);
                cmd2.ExecuteNonQuery();
                Response.Write("<script language=javascript>alert('Updated mobile status as sold');</script>");
                
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("add.aspx");
        }
    }
}