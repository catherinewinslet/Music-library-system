<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="playlist2.aspx.cs" Inherits="MusicWebApplication.playlist2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Musicafe</title>
    <link rel="shortcut icon" href="images/favicon.ico" type="image/x-icon"/>
    <link rel="icon" href="images/favicon.ico" type="image/x-icon"/>
    <link href="StyleSheetcommon.css" type="text/css" rel="stylesheet" />
    <link href="StyleSheetgrid.css" type="text/css" rel="stylesheet"/>
    <link href="StyleSheet1.css" type="text/css" rel="stylesheet"/>

</head>
<body>
    <form id="form1" runat="server">
          <p><asp:Label class="Logo" runat="server" Text="MUSICAFE" ></asp:Label></p>


           <%-- NAVIGATION BAR --%>


        <div class="sidenav">
        <%-- PROFILE PICTURE --%>
        <asp:ImageButton ID="profile" runat="server" OnClick="profile_click" ImageUrl="~/images/squidward.jpg"/><br />
        <asp:Label ID="usr" CssClass="message" runat="server"></asp:Label>
        <br /><br /><br />
        <%-- SEARCH BUTTON(IMAGE:MAGNIFYING GLASS THINGY) --%>
        <asp:ImageButton ID="searchbutton" runat="server" OnClick="ImageButton1_Click" ImageUrl="~/images/search-solid.svg" />
        <%-- SEARCH BOX --%>
        <asp:TextBox ID="search" class="TextBox" runat="server" OnTextChanged="search_TextChanged" ></asp:TextBox>
        <br /><br /><br /><br />
        <asp:Button class="but" runat="server" Text="Home" OnClick="home_Click1" /><br />
        <asp:Button class="but" runat="server" Text="Music" OnClick="Button2_Click" /><br />
        <asp:Button class="but" runat="server" Text="Playlist" OnClick="Button3_Click" /><br /><br /><br />
        <%-- CLICK ON NAME TO GET OPTION 'LOG OUT' --%>
        <asp:Button class="but" runat="server" OnClick="Button1_Click" Text="Logout" />
        </div>   <br />


<div class="dip">
    <p>
        <asp:Label ID="Label2" class="message" runat="server" Text="Playlist:      "></asp:Label>
        <asp:Label ID="playlistname" class="message" runat="server"></asp:Label>
        <asp:Label ID="Label1" runat="server" Visible="false" ></asp:Label>
    </p>
        
        
         <%-- LIST VIEW FOR ALL SONG TRACKS IN A PLAYLIST --%> 
        <asp:GridView class="grid" ID="datatable" runat="server" AutoGenerateColumns="False" CellPadding="4"  GridLines="None" HeaderStyle-CssClass="header" RowStyle-CssClass="rows" OnSelectedIndexChanged="datatable_SelectedIndexChanged" OnRowCommand="datatable_RowCommand" >  
        <columns>  
         <%-- first column track name --%>
         <asp:TemplateField HeaderText="tracks" >  
             <ItemTemplate>  
                 <asp:Label ID="trackname" runat="server" Text='<%#Bind("track_name") %>'></asp:Label>  
             </ItemTemplate>  
         </asp:TemplateField>  

         <%-- second column artist name --%>
         <asp:TemplateField HeaderText="artist" >  
             <ItemTemplate>  
                 <asp:Label ID="artistname" runat="server" Text='<%#Bind("artist_name") %>'></asp:Label>  
             </ItemTemplate>  
         </asp:TemplateField>
  
           
         <asp:TemplateField HeaderText="genre" >  
             <ItemTemplate>  
                 <asp:Label ID="genre" runat="server" Text='<%#Bind("genre") %>'></asp:Label>  
             </ItemTemplate>  
         </asp:TemplateField>
     </columns>  

     </asp:GridView> 
</div>
    </form>
</body>
</html>
