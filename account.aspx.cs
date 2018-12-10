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
    public partial class account : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Catherine\Desktop\Project\MusicWebApplication\MusicWebApplication\App_Data\MusicDatabase.mdf;Integrated Security = True");

        protected void Page_Load(object sender, EventArgs e)
        {
           if (!IsPostBack)
           {
                 DisplayRecord();
            }
            usr.Text = Session["username"].ToString();
            Label1.Text = Session["username"].ToString();
            /*string cmdst = "select p.playlist_name,count(pt.track_id) as no_of_tracks from playlist p, [user] u, playlist_tracks pt where u.user_id=( select a.user_id from [user] a where a.username='"+Session["username"]+"') and u.user_id=p.user_id and p.playlist_id=pt.playlist_id group by playlist_name";
            con.Open();
            SqlCommand cmd = new SqlCommand(cmdst, con);
            SqlDataReader dr = cmd.ExecuteReader();
            GridView1.DataSource = dr;
            GridView1.DataBind();
            con.Close();*/
        }

        //button to delete the currently logged in account
        protected void Button2_Click(object sender, EventArgs e)
        {
            if (Session["username"] != null)
            {
                Label1.Text = Session["username"].ToString();
                SqlCommand cmd = new SqlCommand("delete from [user] where username=@b", con);
                cmd.Parameters.AddWithValue("@b", Label1.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Redirect("login1.aspx");
            }
        }

       //gridview to display the playlists of the user
        public DataTable DisplayRecord()
        {
        
                SqlDataAdapter Adp5 = new SqlDataAdapter("select p.playlist_name,count(pt.track_id) as no_of_tracks from playlist p, [user] u, playlist_tracks pt where u.user_id=( select a.user_id from [user] a where a.username='"+Session["username"]+"') and u.user_id=p.user_id and p.playlist_id=pt.playlist_id group by playlist_name", con);
                /*Adp5.SelectCommand.Parameters.Add(new SqlParameter
                {
                    ParameterName = "@c",
                    Value = Label1.Text,
                    SqlDbType = SqlDbType.VarChar
                });*/
                DataTable Dt = new DataTable();
                Adp5.Fill(Dt);
                datatable.DataSource = Dt;
                datatable.DataBind();
                return Dt;
           
        }

        protected void datatable_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Select")
            {
                //Determine the RowIndex of the Row whose Button was clicked.
                int rowIndex = Convert.ToInt32(e.CommandArgument);

                //Reference the GridView Row.
                GridViewRow row = datatable.Rows[rowIndex];

                //Fetch value of Name.
                string playlistname = (row.FindControl("playlistname") as Label).Text;

                Label1.Text = Session["username"].ToString();
                SqlCommand cmd = new SqlCommand("delete from playlist where user_id=(select user_id from [user] where username=@b)", con);
                cmd.Parameters.AddWithValue("@b", Label1.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                //delete playlist.
            }
        }

        protected void datatable_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        protected void Button1_Click2(object sender, EventArgs e)
        {
            Response.Redirect("change.aspx");
        }
    }
}