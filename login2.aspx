<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login2.aspx.cs" Inherits="MusicWebApplication.login2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Musicafe | Sign up</title>
    <link rel="shortcut icon" href="images/favicon.ico" type="image/x-icon"/>
    <link rel="icon" href="images/favicon.ico" type="image/x-icon"/>
    <link rel="stylesheet" href="StyleSheetlogin2.css" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="signup">
            <%-- OTHER STUFF WHICH DOESNT MATTER--%>
            <p>
                <asp:Label class="text" runat="server" Text="first name"></asp:Label><br />
                <asp:TextBox class="TextBox" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Label class="text" runat="server" Text="last name"></asp:Label><br />
                <asp:TextBox class="TextBox" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Label class="text" runat="server" Text="email"></asp:Label><br />
                <asp:TextBox class="TextBox" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Label class="text" runat="server" Text="mobile"></asp:Label><br />
                <asp:TextBox class="TextBox" runat="server"></asp:TextBox>
            </p>

            <%-- STUFF THAT ACTUALLY MATTERS --%>

            <p>
                <asp:Label class="text" runat="server" Text="username"></asp:Label><br />
                <asp:TextBox class="TextBox" ID="username" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Label class="text" runat="server" Text="password"></asp:Label><br />
                <asp:TextBox class="TextBox" ID="password" runat="server" TextMode="Password"></asp:TextBox>
            </p>

            <%-- DON'T MATTER AGAIN --%>
            <p>
                <asp:Label class="text" runat="server" Text="confirm password"></asp:Label><br />
                <asp:TextBox class="TextBox" runat="server" TextMode="Password"></asp:TextBox>
            </p>

            <br />
            <%-- CREATE BUTTON --%>
            <p>
                <asp:Button class="button" runat="server" OnClick="Button1_Click" Text="Create My Account" />
            </p>

            <%-- DISPLAYS 'USERNAME ALREADY EXISTS' --%>
            <p>
                <asp:Label ID="message" runat="server" Text="Label" Visible="False"></asp:Label>
            </p>
            </div>
            <div class="dip">

            <%-- SUBSCRIPTION JUST FOR FUN --%>
            <p>
                <asp:CheckBox ID="CheckBox1" runat="server" Text="yes" />
                <asp:Label class="text1" runat="server" Text=", I would like to receive monthly newsletter"></asp:Label>
            </p>

        </div>
    </form>
</body>
</html>
