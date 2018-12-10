using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;




namespace MusicWebApplication
{
    public partial class mainpage1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Catherine\Desktop\Project\MusicWebApplication\MusicWebApplication\App_Data\MusicDatabase.mdf;Integrated Security = True");
    
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DisplayRecord();
                DisplayRecord2();
                DisplayRecord3();
            }
            usr.Text = Session["username"].ToString();

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

        protected void search_TextChanged(object sender, EventArgs e)
        {
            //search box.
        }

        //display all the songs on the home page
        public DataTable DisplayRecord()
        {
            SqlDataAdapter Adp1 = new SqlDataAdapter("select a.album_name,count(at.track_id) as num from album_tracks at,album a where a.album_id=at.album_id and a.artist_id=202 group by album_name ", con);
            DataTable Dt = new DataTable();
            Adp1.Fill(Dt);
            datatable.DataSource = Dt;
            datatable.DataBind();
            return Dt;
        }
        
     
        public DataTable DisplayRecord2()
        {
            SqlDataAdapter Adp2 = new SqlDataAdapter("select a.album_name,count(at.track_id) as num from album_tracks at,album a where a.album_id=at.album_id and a.artist_id=201 group by album_name ", con);
            DataTable Dt = new DataTable();
            Adp2.Fill(Dt);
            GridView1.DataSource = Dt;
            GridView1.DataBind();
            return Dt;
        }

        public DataTable DisplayRecord3()
        {
            SqlDataAdapter Adp2 = new SqlDataAdapter("select a.album_name,count(at.track_id) as num from album_tracks at,album a where a.album_id=at.album_id and a.artist_id=203 group by album_name ", con);
            DataTable Dt = new DataTable();
            Adp2.Fill(Dt);
            GridView2.DataSource = Dt;
            GridView2.DataBind();
            return Dt;
        }

        protected void datatable_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this is for the gridview that was created. also dont have to anything
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