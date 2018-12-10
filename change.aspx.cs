using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

namespace MusicWebApplication
{
    public partial class change : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Catherine\Desktop\Project\MusicWebApplication\MusicWebApplication\App_Data\MusicDatabase.mdf;Integrated Security = True");

        protected void Page_Load(object sender, EventArgs e)
        {
           
            usr.Text = Session["username"].ToString();

        }
            protected void profile_click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("account.aspx");
        }

        protected void search_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            //create session for the search text and redirect page
            string st = search.Text;
            Session["searchtext"] = st;
            Response.Redirect("search1.aspx");
        }

        protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //log out button
            Response.Redirect("login1.aspx");
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("mainpage1.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("playlist1.aspx");
        }

        protected void music_Click(object sender, EventArgs e)
        {
            Response.Redirect("music.aspx");
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click2(object sender, EventArgs e)
        {
            //retrieve old password
            SqlCommand sq1 = new SqlCommand("select password from [user] where username='"+ Session["username"] + "' and password='"+ oldpass.Text + "'", con);
            //sq1.Parameters.AddWithValue("@a", usr.Text);
            //sq1.Parameters.AddWithValue("@b", oldpass.Text);

            con.Open();
            //check password with the current password
            SqlDataReader rd = sq1.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Close();
                //insert new password using update
                SqlCommand sq2 = new SqlCommand("update [user] set password='"+newpass.Text+"' where username='"+Session["username"]+"'", con);
                //sq1.Parameters.AddWithValue("@a", usr.Text);
                //sq2.Parameters.AddWithValue("@b", newpass.Text);
                sq2.ExecuteNonQuery();
                Label7.Text = "password has been changed";
            }
            else
            {
                Label7.Text = "invalid password";
            }
            con.Close();
        }
    }
}