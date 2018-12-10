<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="account.aspx.cs" Inherits="MusicWebApplication.account" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Musicafe | My Account</title>
        <link href="StyleSheet1.css" type="text/css" rel="stylesheet"/>
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <link rel="shortcut icon" href="images/favicon.ico" type="image/x-icon"/>
    <link rel="icon" href="images/favicon.ico" type="image/x-icon"/>
        <link href="StyleSheetcommon.css" type="text/css" rel="stylesheet"/>
        <link href="StyleSheetgrid.css" type="text/css" rel="stylesheet"/>


</head>
<body>
    <form id="form1" runat="server">
            <p><asp:Label class="Logo" runat="server" Text="MUSICAFE" ></asp:Label></p>

        <%-- NAVIGATION BAR --%>


        <div class="sidenav">
        <%-- PROFILE PICTURE --%>
        <asp:ImageButton ID="profile" runat="server" OnClick="profile_click" ImageUrl="~/images/squidward.jpg"/><br />
        <asp:Label ID="usr" runat="server"></asp:Label>
        <br /><br /><br />
        <%-- SEARCH BUTTON(IMAGE:MAGNIFYING GLASS THINGY) --%>
        <asp:ImageButton ID="searchbutton" runat="server" OnClick="ImageButton1_Click" ImageUrl="~/images/search-solid.svg" />
        <%-- SEARCH BOX --%>
        <asp:TextBox ID="search" class="TextBox" runat="server" OnTextChanged="search_TextChanged" ></asp:TextBox>
        <br /><br /><br /><br />
        <asp:Button class="but" runat="server" Text="Home" OnClick="Button1_Click1" /><br />
        <asp:Button class="but" runat="server" Text="Music" OnClick="music_Click" /><br />
        <asp:Button class="but" runat="server" Text="Playlist" OnClick="Button3_Click" /><br /><br /><br />
        <%-- CLICK ON NAME TO GET OPTION 'LOG OUT' --%>
        <asp:Button class="but" runat="server" OnClick="Button1_Click" Text="Logout" />
        </div>   <br />

    <div class="dip">
        <p>
            <asp:Label ID="Label2" class="message" runat="server" Text="Your account, "></asp:Label>
            <asp:Label ID="Label1" class="message" runat="server"></asp:Label>
    <asp:Label ID="Label3" runat="server" class="message" Text="Label" Visible="False"></asp:Label>
        
            <asp:Button ID="Button1" class="button" runat="server" OnClick="Button1_Click2" Text="change password" />
        
        </p>
        <br />
            <%-- button to delete account --%>   
        <asp:Label ID="del"  runat="server" Text="Delete your account?    "></asp:Label>
    <asp:Button ID="Buttondelete" class="button" runat="server" OnClick="Button2_Click" Text="delete my account" />
<br /><br /><br />


        <asp:Label ID="Label5" runat="server" CssClass="message" Text="showing all your playlists"></asp:Label>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>

        <asp:GridView class="grid" ID="datatable" runat="server" HeaderStyle-CssClass="header"  AutoGenerateColumns="False" RowStyle-CssClass="rows" CellPadding="4" GridLines="None" OnSelectedIndexChanged="datatable_SelectedIndexChanged" OnRowCommand="datatable_RowCommand" >  
        <columns>  
             <%-- first column playlist name --%>
            <asp:TemplateField HeaderText="playlists">  
                <ItemTemplate>  
                     <asp:Label ID="playlistname" runat="server" Text='<%#Bind("playlist_name") %>'></asp:Label>  
                </ItemTemplate>  
            </asp:TemplateField>  

            <%-- second column count of tracks --%>
            <asp:TemplateField HeaderText="number of tracks">  
                 <ItemTemplate>  
                     <asp:Label ID="count" runat="server" Text='<%#Bind("no_of_tracks") %>'></asp:Label>  
                </ItemTemplate>  
            </asp:TemplateField>

            <%-- delete a playlist button --%>
            <asp:TemplateField >  
                <ItemTemplate>  
                    <asp:ImageButton ID="delete" ImageUrl="~/images/trash-solid.svg" runat="server" CommandName="Select" CommandArgument="<%# Container.DataItemIndex %>" Text="delete" ></asp:ImageButton> 
                </ItemTemplate>  
            </asp:TemplateField>
        </columns>  

    </asp:GridView></div>
        
        
    <p>
         <asp:Label ID="Label4" class="message" runat="server"></asp:Label>
    </p>
    </form>
</body>
</html>
