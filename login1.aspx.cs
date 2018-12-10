using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.Sql;

namespace MusicWebApplication
{
    public partial class login1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Catherine\Desktop\Project\MusicWebApplication\MusicWebApplication\App_Data\MusicDatabase.mdf;Integrated Security = True");
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        //sign in button
        protected void Buttonsignin_Click(object sender, EventArgs e)
        {
            //open session to share among other pages
            string s1 = TextBoxusername.Text;
            Session["username"] = s1;

            con.Open();
            
            //to check if the username exists in the database
            SqlCommand cmd1 = new SqlCommand("select  [username],[password] from [user] where [username]=@a and [password]=@b", con);
            cmd1.Parameters.AddWithValue("@a", TextBoxusername.Text);
            cmd1.Parameters.AddWithValue("@b", TextBoxpassword.Text);

            SqlDataReader rd = cmd1.ExecuteReader();
            //if username exists, redirect to mainpage
            if (rd.HasRows)
            {
                rd.Read();
                //cmd.ExecuteNonQuery();
                Response.Redirect("mainpage1.aspx");
            }
            //if username doesn't exist, display the label
            else
            {
                Label1.Text = "Invalid username or password";
            }
            
            con.Close();
        }

        protected void Buttonsignup_Click(object sender, EventArgs e)
        {
            //sign up button
            Response.Redirect("login2.aspx");
        }

        
    }
}