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
    public partial class add : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Catherine\Desktop\Project\MusicWebApplication\MusicWebApplication\App_Data\MusicDatabase.mdf;Integrated Security = True");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DisplayRecord();
            }
            Label3.Text = Session["username"].ToString();

        }

        public DataTable DisplayRecord()
        {
            if (Session["username"] != null)
            {
                Label1.Text = Session["username"].ToString();
                SqlDataAdapter Adp4 = new SqlDataAdapter("select p.playlist_name from playlist p, [user] u where u.user_id=( select a.user_id from [user] a where a.username=@a) and u.user_id=p.user_id group by playlist_name", con);
                //Adp4.SelectCommand.Parameters.AddWithValue("@a", Label1.Text);
                Adp4.SelectCommand.Parameters.Add(new SqlParameter
                {
                    ParameterName = "@a",
                    Value = Label1.Text,
                    SqlDbType = SqlDbType.VarChar
                });
                DataTable Dt = new DataTable();
                Adp4.Fill(Dt);
                datatable.DataSource = Dt;
                datatable.DataBind();
                return Dt;
            }
            return null;
        }

        protected void datatable_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Select")
            {
                //Determine the RowIndex of the Row whose Button was clicked.
                int rowIndex = Convert.ToInt32(e.CommandArgument);

                //Reference the GridView Row.
                GridViewRow row = datatable.Rows[rowIndex];

                //Fetch value of playlist Name.
                string playlist_name = (row.FindControl("playlistname") as Label).Text;

                Label2.Text = Session["trackname"].ToString();

                /*/get user_id using username
                SqlCommand cmd = new SqlCommand("select user_id from [user] where username=@a", con);
                cmd.Parameters.AddWithValue("@a", Label3.Text);
                con.Open();
                string id = cmd.ExecuteScalar().ToString();

                //update playlist id of track
                SqlCommand sq = new SqlCommand("update track set playlist_id=(select playlist_id from playlist where playlist_name=@c and user_id=@a) where track_id=(select track_id from track where track_name=@b)", con);
                sq.Parameters.AddWithValue("@a", id);
                sq.Parameters.AddWithValue("@b",Label2.Text);
                sq.Parameters.AddWithValue("@c",playlist_name);
                sq.ExecuteNonQuery();
                con.Close();*/

                SqlCommand cm = new SqlCommand("select track_id from track where track_name=@c", con);
                cm.Parameters.AddWithValue("@c", Label2.Text);
                con.Open();
                string track_id = cm.ExecuteScalar().ToString();
                

                SqlCommand cm1 = new SqlCommand("select playlist_id from playlist where playlist_name=@c", con);
                cm1.Parameters.AddWithValue("@c", playlist_name);
                
                string play_id = cm1.ExecuteScalar().ToString();
                

                SqlCommand sq1 = new SqlCommand("insert into playlist_tracks values(@a,@b)", con);
                sq1.Parameters.AddWithValue("@a", track_id);
                sq1.Parameters.AddWithValue("@b", play_id);
                sq1.ExecuteNonQuery();

                con.Close();
                success.Text = "added to playlist";
            }
        }

        protected void datatable_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Menu2_MenuItemClick(object sender, MenuEventArgs e)
        {

        }

        protected void search_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //log out button
            Response.Redirect("login1.aspx");
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

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("music.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("playlist.aspx");
        }
    }
}