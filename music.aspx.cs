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
    public partial class music : System.Web.UI.Page
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

        public DataTable DisplayRecord()
        {

            SqlDataAdapter Adp3 = new SqlDataAdapter("select t.track_name,a.artist_name,t.genre from track t,artist a where a.artist_id=t.artist_id", con);
            DataTable Dt = new DataTable();
            Adp3.Fill(Dt);
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
                string trackname = (row.FindControl("trackname") as Label).Text;

                //Fetch value of Country
                //string country = row.Cells[1].Text; fetching by column number og gridview(second column,in this case)
                string artistname = (row.FindControl("artistname") as Label).Text;

                Session["trackname"] = trackname;
                Session["artistname"] = artistname;

                //ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Name: " + trackname + "\\nby: " + artistname + "');", true);
                Response.Redirect("songplay.aspx");
            }
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