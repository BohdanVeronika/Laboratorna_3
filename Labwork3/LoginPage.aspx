<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="Labwork3.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="style.css" rel="stylesheet"/>
</head>
<body>
    <form id="form1" runat="server">
        <nav class="two">
        <ul>
          <div><a>Labwork 3</a></div>
        </ul>
            </nav>
        <nav>
             <table class="table">
            <tr>
                <td>User</td>
                <td>
                    <asp:TextBox ID="UserTextBox" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Password</td>
                <td>
                    <asp:TextBox ID="PasswordTextBox" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
                 <tr>
                <td>
                    <asp:Button ID="LoginButton" runat="server" OnClick="LoginButton_Click" Text="Login" Width="122px" />
                </td> 
            </tr>
        </table>
        </nav>
    </form>
</body>
</html>
