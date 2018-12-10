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
    public partial class playlist1 : System.Web.UI.Page
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


        public DataTable DisplayRecord()
        {
            if (Session["username"] != null)
            {
                Label1.Text = Session["username"].ToString();
                SqlDataAdapter Adp4 = new SqlDataAdapter("select p.playlist_name, count(pt.track_id) as no_of_tracks from playlist p, [user] u, playlist_tracks pt where u.user_id=( select a.user_id from [user] a where a.username=@a) and u.user_id=p.user_id and p.playlist_id=pt.playlist_id group by playlist_name", con);
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

                Session["playlist_name"] = playlist_name;

                //ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Name: " + trackname + "\\nby: " + artistname + "');", true);
                Response.Redirect("playlist2.aspx");
            }
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

        protected void Menu3_MenuItemClick(object sender, MenuEventArgs e)
        {

        }

        protected void datatable_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void profile_click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("account.aspx");
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
    }
}