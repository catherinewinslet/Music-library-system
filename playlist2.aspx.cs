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
    public partial class playlist2 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Catherine\Desktop\Project\MusicWebApplication\MusicWebApplication\App_Data\MusicDatabase.mdf;Integrated Security = True");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DisplayRecord();
            }
            usr.Text = Session["username"].ToString();

        }

        protected void Menu4_MenuItemClick(object sender, MenuEventArgs e)
        {

        }

        protected void profile_click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("account.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //log out button
            Response.Redirect("login1.aspx");
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
        public DataTable DisplayRecord()
        {
            Label1.Text = Session["username"].ToString();
            playlistname.Text = Session["playlist_name"].ToString();
            SqlDataAdapter Adp4 = new SqlDataAdapter("select distinct(t.track_name),a.artist_name,t.genre from track t,artist a, playlist_tracks p where a.artist_id=t.artist_id and p.playlist_id=(select playlist_id from playlist where playlist_name=@b) and t.track_id=p.track_id;", con);
            //Adp4.SelectCommand.Parameters.AddWithValue("@a", Label1.Text);
            Adp4.SelectCommand.Parameters.Add(new SqlParameter
            {
                ParameterName = "@a",
                Value = Label1.Text,
                SqlDbType = SqlDbType.VarChar
            });
            Adp4.SelectCommand.Parameters.Add(new SqlParameter
            {
                ParameterName = "@b",
                Value = playlistname.Text,
                SqlDbType = SqlDbType.VarChar
            });
            DataTable Dt = new DataTable();
            Adp4.Fill(Dt);
            datatable.DataSource = Dt;
            datatable.DataBind();
            return Dt;
        }

        protected void datatable_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void datatable_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("mainpage1.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("music.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("playlist1.aspx");
        }

        protected void home_Click1(object sender, EventArgs e)
        {
            Response.Redirect("mainpage1.aspx");
        }
    }
}