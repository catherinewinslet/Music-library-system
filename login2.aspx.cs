using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace MusicWebApplication
{
    public partial class login2 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Catherine\Desktop\Project\MusicWebApplication\MusicWebApplication\App_Data\MusicDatabase.mdf;Integrated Security = True");

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //create button
            SqlCommand cmd2 = new SqlCommand("insert into [dbo].[user] values (@a,@password)", con);
            con.Open();
            cmd2.Parameters.AddWithValue("@a", username.Text);
            cmd2.Parameters.AddWithValue("@password", password.Text);

            //check if username exists in user table
            SqlCommand cmd3 = new SqlCommand("select  username from [user] where username=@a", con);
            cmd3.Parameters.AddWithValue("@a", username.Text);
            SqlDataReader rd = cmd3.ExecuteReader();

            //if username exists, display label
            if (rd.HasRows)
            {    
                message.Text = "Username already exists.";
                message.Visible = true;   
            }
            //if username doesn't exist, insert the username and password into database
            else
            {
                rd.Close();
                cmd2.ExecuteNonQuery();
                Response.Redirect("login1.aspx");
            }
            con.Close();
        }
    }
}