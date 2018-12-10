using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace MusicWebApplication
{
    public partial class search1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Catherine\Desktop\Project\MusicWebApplication\MusicWebApplication\App_Data\MusicDatabase.mdf;Integrated Security = True");

        

        protected void Page_Load(object sender, EventArgs e)
        {
            

            try

            {


                con.Open();
                search.Text = Session["searchtext"].ToString();
               string cmdst = "select track_name from track where track_name=@a union select artist_name from artist where artist_name = @a union select album_name from album where album_name =@a union select playlist_name from playlist where playlist_name = @a union select track_name from track where genre=@a";

                SqlCommand cmd = new SqlCommand(cmdst, con);
                cmd.Parameters.AddWithValue("@a", search.Text);
                SqlDataReader dr = cmd.ExecuteReader();
              GridView2.DataSource = dr ;
                GridView2.DataBind();
                
            }

            catch (Exception pp)

            {

            }
        }

        protected void datatable_RowCommand(object sender, GridViewCommandEventArgs e)
        {
          
        }

       

        protected void Menu4_MenuItemClick(object sender, MenuEventArgs e)
        {

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            //create session for the search text and redirect page
            string st = search.Text;
            Session["searchtext"] = st;
            Response.Redirect("search1.aspx");
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

        protected void search_TextChanged(object sender, EventArgs e)
        {

        }

        protected void datatable_SelectedIndexChanged(object sender, EventArgs e)
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

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}