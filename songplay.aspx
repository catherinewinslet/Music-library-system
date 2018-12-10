<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="songplay.aspx.cs" Inherits="MusicWebApplication.songplay" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Musicafe</title>
    <link rel="shortcut icon" href="images/favicon.ico" type="image/x-icon"/>
    <link rel="icon" href="images/favicon.ico" type="image/x-icon"/>
    <link href="StyleSheetcommon.css" type="text/css" rel="stylesheet"/>
        <link href="StyleSheet1.css" type="text/css" rel="stylesheet"/>
    <style>
        #GridView1 { float:left; margin:0 40px 0 0; }
    </style>
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
        <asp:Button class="but" runat="server" Text="Music" OnClick="Button2_Click" /><br />
        <asp:Button class="but" runat="server" Text="Playlist" OnClick="Button3_Click" /><br /><br /><br />
        <%-- CLICK ON NAME TO GET OPTION 'LOG OUT' --%>
        <asp:Button class="but" runat="server" OnClick="Button1_Click" Text="Logout" />
        </div>   
        
        <br />

        <div class="dip">

   
        <asp:GridView ID="GridView1" CssClass="grid" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" AutoGenerateColumns="false">
            <Columns>
                <asp:TemplateField HeaderText="currently playing" HeaderStyle-BorderStyle="None" HeaderStyle-ForeColor="White" >
                    <ItemTemplate>
                        <asp:Image ID="img1" BorderStyle="None" runat="server" Width="300px" Height="300px" ImageUrl='<%#"data:Image/png;base64,"+Convert.ToBase64String((byte[])Eval("album_image")) %>' />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>

    
    <p>
        <asp:Label ID="Label1" class="message" runat="server" Text="Track name:  "></asp:Label>
        <asp:Label ID="trackname" class="message" runat="server" Text="trackname"></asp:Label></p>
    <p>
        <asp:Label ID="Label2" class="message" runat="server" Text="Artist:  "></asp:Label>
        <asp:Label ID="artistname" class="message" runat="server" Text="artistname"></asp:Label></p>
        <br />
            <asp:Image ID="Image1" runat="server" ImageUrl="~/images/preview-7.png"/><br /><br />

        <asp:Button ID="Button" class="button" runat="server" Text="add to playlist" OnClick="Button1_Click1" />
        </div>
    </form>

    </body>
</html>
