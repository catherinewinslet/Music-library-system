<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="search1.aspx.cs" Inherits="MusicWebApplication.search1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Musicafe</title>
    <link rel="shortcut icon" href="images/favicon.ico" type="image/x-icon"/>
    <link rel="icon" href="images/favicon.ico" type="image/x-icon"/>
    <link href="StyleSheetcommon.css" type="text/css" rel="stylesheet"/>
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
        <%-- SEARCH BOX --%>
        <br /><br /><br /><br />
        <asp:Button class="but" runat="server" Text="Home" OnClick="Button1_Click1" /><br />
        <asp:Button class="but" runat="server" Text="Music" OnClick="Button2_Click" /><br />
        <asp:Button class="but" runat="server" Text="Playlist" OnClick="Button3_Click" /><br /><br /><br />
        <%-- CLICK ON NAME TO GET OPTION 'LOG OUT' --%>
        <asp:Button class="but" runat="server" OnClick="Button1_Click" Text="Logout" />
        </div>   

        <br />
        <div class="dip">
            <asp:Label ID="Label4" class="message" runat="server" Text="showing results for ' "></asp:Label>
            <asp:Label ID="search" class="message" runat="server" Text="Label"></asp:Label>
            <asp:Label ID="Label5" class="message" runat="server" Text=" '"></asp:Label>
            <br />

            <asp:GridView ID="GridView2" CssClass="grid" style="clear:both" runat="server" RowStyle-CssClass="rows" HeaderStyle-CssClass="header" OnSelectedIndexChanged="GridView2_SelectedIndexChanged" >
            </asp:GridView>

     </div>

    </form>
</body>
</html>
