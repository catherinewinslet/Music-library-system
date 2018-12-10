<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="playlist1.aspx.cs" Inherits="MusicWebApplication.playlist1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Musicafe | My Playlist</title>
    <link rel="shortcut icon" href="images/favicon.ico" type="image/x-icon"/>
    <link rel="icon" href="images/favicon.ico" type="image/x-icon"/>
    <link href="StyleSheetcommon.css" type="text/css" rel="stylesheet"/>
    <link href="StyleSheetplaylist.css" type="text/css" rel="stylesheet"/>
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
        <asp:Button class="but" runat="server" Text="Home" OnClick="Button1_Click1" /><br />
        <asp:Button class="but" runat="server" Text="Music" OnClick="Button2_Click" /><br />
        <asp:Button class="but" runat="server" Text="Playlist" OnClick="Button3_Click" /><br /><br /><br />
        <%-- CLICK ON NAME TO GET OPTION 'LOG OUT' --%>
        <asp:Button class="but" runat="server" OnClick="Button1_Click" Text="Logout" />
        </div>   

        <div class="dip">
        <asp:GridView class="grid" ID="datatable" runat="server" AutoGenerateColumns="False" CellPadding="4"  GridLines="None" HeaderStyle-CssClass="header" RowStyle-CssClass="rows" OnSelectedIndexChanged="datatable_SelectedIndexChanged" OnRowCommand="datatable_RowCommand" >  
        <columns>  
         <%-- first column playlist name --%>
         <asp:TemplateField HeaderText="playlists" >  
             <ItemTemplate>  
                 <asp:Label ID="playlistname" runat="server" Text='<%#Bind("playlist_name") %>'></asp:Label>  
             </ItemTemplate>  
         </asp:TemplateField>  

         <%-- second column count of tracks --%>
         <asp:TemplateField HeaderText="number of tracks" >  
             <ItemTemplate>  
                 <asp:Label ID="count" runat="server" Text='<%#Bind("no_of_tracks") %>'></asp:Label>  
             </ItemTemplate>  
         </asp:TemplateField>

         <%-- third column button to go to playlist --%>
         <asp:TemplateField >  
             <ItemTemplate>  
                 <asp:ImageButton ID="gotobutton" runat="server" ImageUrl="~/images/angle-double-right-solid.svg" Width="30px" Height="30px" CommandName="Select" CommandArgument="<%# Container.DataItemIndex %>" Text="goto" ></asp:ImageButton>  
             </ItemTemplate>  
         </asp:TemplateField>
         <%-- GOTO BUTTON- WHEN CLICKED REDIRECTS TO A PAGE 
             WHICH DISPLAYS THE TRACKS OF THE CORRESPONDING PLAYLIST --%>
 
         </columns>  

     </asp:GridView>
            
     <%-- FOR SESSION PURPOSES --%>
     <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
     </div>
        
    </form>
</body>
</html>
