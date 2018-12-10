<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="create.aspx.cs" Inherits="MusicWebApplication.create" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Musicafe</title>
        <link href="StyleSheet1.css" type="text/css" rel="stylesheet"/>
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
        </div>   




        <br />
        
        <div class="dip">
            
            <div>
                <asp:Label ID="Label2" class="message" runat="server" Text="Creating a new playlist"></asp:Label>
            </div><br /><br /><br />
            <asp:Label ID="Label1" class="message" runat="server" Text="Enter new playlist name"></asp:Label>
            <asp:TextBox ID="TextBox1" class="TextBox" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        
        <p>
            <asp:Label ID="success" class="message" runat="server"></asp:Label>
            <asp:Label ID="error" class="message" runat="server"></asp:Label>
            <asp:Label ID="Label3" class="message" runat="server" Text="Label" Visible="False"></asp:Label>
            <asp:Label ID="Label4" class="message" runat="server" Text="Label" Visible="False"></asp:Label>
        </p>
        <p>
            <asp:Button ID="Button1" CssClass="button" runat="server" OnClick="Button1_Click" Text="add" />
        </p></div>
    </form>
</body>
</html>
