<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="mainpage1.aspx.cs" Inherits="MusicWebApplication.mainpage1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="StyleSheetcommon.css" type="text/css" rel="stylesheet"/>
    <link href="StyleSheetmain.css" type="text/css" rel="stylesheet"/>
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <link rel="shortcut icon" href="images/favicon.ico" type="image/x-icon"/>
    <link rel="icon" href="images/favicon.ico" type="image/x-icon"/>
    <link href="StyleSheetgrid.css" type="text/css" rel="stylesheet"/>
    <link href="StyleSheet1.css" type="text/css" rel="stylesheet"/>

    <title>Musicafe</title>
</head>




<body >
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




    



<br /><div class="dip">
    
    
    <asp:Panel ID="Panel2" runat="server" HorizontalAlign="Center" BackColor="transparent" 
    BorderStyle="None"  >
        <asp:Image class="Image1" runat="server" ImageUrl="~/images/m2.jpg" />
    </asp:Panel>


    <%-- LIST VIEW FOR ALL SONG TRACKS OF EACH ARTIST --%> 
    <asp:GridView class="grid" ID="datatable" runat="server" HeaderStyle-CssClass="header"  AutoGenerateColumns="False" RowStyle-CssClass="rows" CellPadding="4"  GridLines="None"  OnSelectedIndexChanged="datatable_SelectedIndexChanged" >  
    <columns>  
         <%-- first column track name --%>
         <asp:TemplateField HeaderText="album">  
             <ItemTemplate>  
                 <asp:Label ID="trackname" runat="server" Text='<%#Bind("album_name") %>'></asp:Label>  
             </ItemTemplate>  
         </asp:TemplateField>  

         

         <%-- third column genre --%>
         <asp:TemplateField HeaderText="number of tracks">  
             <ItemTemplate>  
                 <asp:Label ID="genre" runat="server" Text='<%#Bind("num") %>'></asp:Label>  
             </ItemTemplate>  
         </asp:TemplateField>  
     </columns>  

     </asp:GridView>  


    <asp:Panel ID="Panel1" runat="server" HorizontalAlign="Center" BackColor="transparent" 
    BorderStyle="None"  >

        <asp:Image class="Image" runat="server" Height="181px" ImageUrl="~/images/miley.png" />
        </asp:Panel>
        
     <asp:GridView class="grid" ID="GridView1" runat="server" HeaderStyle-CssClass="header" RowStyle-CssClass="rows" AutoGenerateColumns="False" CellPadding="4" GridLines="None" OnSelectedIndexChanged="datatable_SelectedIndexChanged" >  
     <columns>  
         <%-- first column track name --%>
         <asp:TemplateField HeaderText="album">  
             <ItemTemplate>  
                 <asp:Label ID="trackname" runat="server" Text='<%#Bind("album_name") %>'></asp:Label>  
             </ItemTemplate>  
         </asp:TemplateField> 
        
         <%-- second column genre --%>
         <asp:TemplateField HeaderText="number of tracks">  
             <ItemTemplate>  
                 <asp:Label ID="genre" runat="server" Text='<%#Bind("num") %>'></asp:Label>  
             </ItemTemplate>  
         </asp:TemplateField>  
     </columns>  
     </asp:GridView>  

        <asp:Panel ID="Panel3" runat="server" HorizontalAlign="Center" BackColor="transparent" 
    BorderStyle="None"  >

        <asp:Image class="Image" runat="server" ImageUrl="~/images/charlie.png" />
            </asp:Panel>


     <asp:GridView class="grid" ID="GridView2" runat="server" HeaderStyle-CssClass="header" RowStyle-CssClass="rows" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None"  OnSelectedIndexChanged="datatable_SelectedIndexChanged" >  
     <columns>  
         <%-- first column track name --%>
         <asp:TemplateField HeaderText="album" >  
             <ItemTemplate>  
                 <asp:Label ID="trackname" runat="server" Text='<%#Bind("album_name") %>'></asp:Label>  
             </ItemTemplate>  
         </asp:TemplateField> 
        
         <%-- second column genre --%>
         <asp:TemplateField HeaderText="number of tracks">  
             <ItemTemplate>  
                 <asp:Label ID="genre" runat="server" Text='<%#Bind("num") %>'></asp:Label>  
             </ItemTemplate>  
         </asp:TemplateField>  
     </columns>  

     </asp:GridView>  
</div>


    </form>
</body>
</html>
