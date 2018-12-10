<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="add.aspx.cs" Inherits="MusicWebApplication.add" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Musicafe</title>
        <link href="StyleSheet1.css" type="text/css" rel="stylesheet"/>
    <link href="StyleSheetmusic.css" type="text/css" rel="stylesheet"/>
    <link href="StyleSheetgrid.css" type="text/css" rel="stylesheet"/>
        <link href="StyleSheetcommon.css" type="text/css" rel="stylesheet"/>

</head>
<body>
    <form id="form1" runat="server">
                    <p><asp:Label class="Logo" runat="server" Text="MUSICAFE" ></asp:Label></p>


            <%-- NAVIGATION BAR --%>


        <div class="sidenav">
        <%-- PROFILE PICTURE --%>
        <asp:ImageButton ID="profile" runat="server" OnClick="profile_click" ImageUrl="~/images/squidward.jpg"/><br />
        <asp:Label ID="usr" class="usr" runat="server"></asp:Label>
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
            

            <asp:GridView ID="datatable" CssClass="grid" HeaderStyle-CssClass="header" RowStyle-CssClass="rows" runat="server" AutoGenerateColumns="False" CellPadding="4" GridLines="None" OnSelectedIndexChanged="datatable_SelectedIndexChanged" OnRowCommand="datatable_RowCommand" >  
        <columns>  
         <%-- first column playlist name --%>
         <asp:TemplateField HeaderText="playlists">  
             <ItemTemplate>  
                 <asp:Label ID="playlistname" runat="server" Text='<%#Bind("playlist_name") %>'></asp:Label>  
             </ItemTemplate>  
         </asp:TemplateField>  

         <%-- third column button to add to playlist --%>
         <asp:TemplateField >  
             <ItemTemplate>  
                 <asp:ImageButton ID="addbutton" runat="server" ImageUrl="~/images/plus-square-regular.svg" Width="30px" Height="30px" CommandName="Select" CommandArgument="<%# Container.DataItemIndex %>" Text="add" ></asp:ImageButton>  
             </ItemTemplate>  
         </asp:TemplateField>
         <%-- ADD BUTTON ADDS THAT TRACK TO THE PLAYLIST OKAY? --%>
 
         </columns>  

     </asp:GridView>
        
        <asp:Label ID="success" CssClass="message" runat="server"></asp:Label>
        <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
        <asp:Label ID="Label2" runat="server" Text="Label" Visible="False"></asp:Label>
        <asp:Label ID="Label3" runat="server" Text="Label" Visible="False" ></asp:Label></div>
    </form>
</body>
</html>
