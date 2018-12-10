using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace MusicWebApplication
{
    public partial class songplay : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Catherine\Desktop\Project\MusicWebApplication\MusicWebApplication\App_Data\MusicDatabase.mdf;Integrated Security = True");

        protected void Page_Load(object sender, EventArgs e)
        {
            usr.Text = Session["username"].ToString();
            trackname.Text = Session["trackname"].ToString();
            artistname.Text = Session["artistname"].ToString();

            con.Open();
            SqlCommand sq = new SqlCommand("select album_image from artist where artist_id=(select artist_id from artist where artist_name=@a)", con);
            sq.Parameters.AddWithValue("@a", artistname.Text);
            SqlDataReader dr = sq.ExecuteReader();
            GridView1.DataSource = dr;
            GridView1.DataBind();
            con.Close();
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

        protected void Menu2_MenuItemClick(object sender, MenuEventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            //messagebox
            string message = "Create new playlist?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message," ", buttons);
            if (result == DialogResult.Yes)
            {
                Response.Redirect("create.aspx");
            }
            else
            {
                Response.Redirect("add.aspx");
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

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