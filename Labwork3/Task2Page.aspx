<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Task2Page.aspx.cs" Inherits="Labwork3.Task2Page" %>

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
          <li><a href="LoginPage.aspx">Exit</a></li>
          <div><a href="Default.aspx">Labwork 3</a></div>
        </ul>
            </nav>
            <nav>
            <table class="table">
                <tr>
                    <td>Result</td>
                </tr>
                <tr>
                    <td class="td">
                        <asp:GridView ID="ResultGridView" runat="server" GridLines="None">
                        </asp:GridView>
                    </td>
                </tr>
                <td style="text-align: center">
                    <button id="return" class="td"><a href="Default.aspx">Return</a></button>
                </td>
            </table>
            </nav>
    </form>
</body>
</html>

