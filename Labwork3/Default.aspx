<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Labwork3.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="style.css" rel="stylesheet"/>
</head>
<body>
    <form id="form1" runat="server" >
        <nav class="two">
        <ul>
          <li><a href="LoginPage.aspx">Exit</a></li>
          <div><a href="Default.aspx">Labwork 3</a></div>            
        </ul>
        </nav>
        <nav>
        <table class="table">
            <tr>
                <td style="text-align: center">Factory</td>
                <td style="text-align: center">Premium</td>
            </tr>
            <tr>
                <td style="vertical-align: top">
                    <asp:GridView ID="FactoryGridView" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                    </asp:GridView>
                </td>
                <td style="vertical-align: top">
                    <asp:GridView ID="PremiumsGridView" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                    </asp:GridView>
                </td>
            </tr>
            <tr>
                <td style="text-align: center">
                    <asp:Button ID="Task1Button" runat="server" OnClick="Task1Button_Click" Text="Task 1" Width="95px" />
                </td>
                <td style="text-align: center">
                    <asp:Button ID="Task2Button" runat="server" OnClick="Task2Button_Click" Text="Task 2" Width="95px" />
                </td>
            </tr>
        </table>
        </nav>
        <div>
        </div>
    </form>
</body>
</html>

