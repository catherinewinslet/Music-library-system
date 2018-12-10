<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login1.aspx.cs" Inherits="MusicWebApplication.login1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Musicafe | Login</title>
    <link rel="shortcut icon" href="images/favicon.ico" type="image/x-icon"/>
    <link rel="icon" href="images/favicon.ico" type="image/x-icon"/>
    <link rel="stylesheet" href="StyleSheetlogin1.css" type="text/css" />

</head>
<body>
    <form id="formlogin" runat="server">
        <div class="login">
        <p>
        <%-- USERNAME --%>
        <asp:Label class="text"  runat="server" Text="USERNAME"></asp:Label><br />
        <asp:TextBox class="TextBox" ID="TextBoxusername" runat="server" MaxLength="20" BorderStyle="None"></asp:TextBox>
        </p>
        <p>
        <%-- PASSWORD --%>
        <asp:Label class="text" runat="server" Text="PASSWORD"></asp:Label><br />
        <asp:TextBox class="TextBox" ID="TextBoxpassword" runat="server" TextMode="Password" MaxLength="15" BorderStyle="None"></asp:TextBox>
        </p><br />
        <p>
        <%-- SIGN IN BUTTON --%>
        <asp:Button class="button" runat="server" OnClick="Buttonsignin_Click" Text="sign in" />
        </p><br /><br /><br />
        <%-- displays 'invalid' --%>
        <p>
        <asp:Label ID="Label1" CssClass="text1" runat="server"></asp:Label>
        </p>
        <br />
        <p>
        <%-- NEW ACCOUNT --%>
        <asp:Label class="text1" runat="server" Text="or Create a new Account"></asp:Label>
        </p>
        <%-- SIGN UP BUTTON --%>
        <p><asp:Button class="button" runat="server" OnClick="Buttonsignup_Click" Text="sign up" /></p>
        </div>
    </form>
</body>
</html>
