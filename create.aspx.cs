using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


namespace MusicWebApplication
{
    public partial class create : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Catherine\Desktop\Project\MusicWebApplication\MusicWebApplication\App_Data\MusicDatabase.mdf;Integrated Security = True");

        protected void Page_Load(object sender, EventArgs e)
        {
            usr.Text = Session["username"].ToString();
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //log out button
            Response.Redirect("login1.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //add button
            string name = TextBox1.Text;
            Label3.Text = Session["username"].ToString();
            Label4.Text = Session["trackname"].ToString();

            //get user_id using username
            SqlCommand cmd = new SqlCommand("select user_id from [user] where username=@a", con);
            cmd.Parameters.AddWithValue("@a", Label3.Text);
            con.Open();
            string id=cmd.ExecuteScalar().ToString();        //executes first
            con.Close();

            //inserting new playlist
            SqlCommand sq = new SqlCommand("insert into playlist values(@a,@b)", con);
            sq.Parameters.AddWithValue("@a", name);
            sq.Parameters.AddWithValue("@b", id);          //executes third


            /*update playlist_id in track table
            SqlCommand sq1 = new SqlCommand("update track set playlist_id=(select playlist_id from playlist where playlist_name=@b and user_id=@a) where track_id=(select track_id from track where track_name=@c) ", con);
            sq1.Parameters.AddWithValue("@a", id);
            sq1.Parameters.AddWithValue("@b", name);
            sq1.Parameters.AddWithValue("@c", Label4.Text); */     //executes fourth

            //check if playlist exists
            SqlCommand sq2 = new SqlCommand("select playlist_name from playlist p where p.user_id=@b and p.playlist_name=@a",con);
            sq2.Parameters.AddWithValue("@a", name);
            sq2.Parameters.AddWithValue("@b", id);
            con.Open();
            SqlDataReader rd = sq2.ExecuteReader();             //executes second
            if (rd.HasRows)
            {
                error.Text = "playlist name already exists";
            }
            else
            {
                rd.Close();
                sq.ExecuteNonQuery();

                SqlCommand cm = new SqlCommand("select track_id from track where track_name=@c", con);
                cm.Parameters.AddWithValue("@c", Label4.Text);
               
                string track_id = cm.ExecuteScalar().ToString();

                SqlCommand cm1 = new SqlCommand("select playlist_id from playlist where playlist_name=@c", con);
                cm1.Parameters.AddWithValue("@c", name);
                string play_id = cm1.ExecuteScalar().ToString();
                

                SqlCommand sq1 = new SqlCommand("insert into playlist_tracks values(@a,@b)", con);
                sq1.Parameters.AddWithValue("@a", track_id);
                sq1.Parameters.AddWithValue("@b", play_id);

                sq1.ExecuteNonQuery();
                success.Text = "playlist created";
            }
            
            con.Close();
        }

        protected void Menu2_MenuItemClick(object sender, MenuEventArgs e)
        {

        }

        protected void search_TextChanged(object sender, EventArgs e)
        {

        }

        protected void profile_click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("account.aspx");
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            //create session for the search text and redirect page
            string st = search.Text;
            Session["searchtext"] = st;
            Response.Redirect("search1.aspx");
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("mainpage1.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("playlist.aspx");
        }

        protected void music_Click(object sender, EventArgs e)
        {
            Response.Redirect("music.aspx");
        }
    }
}