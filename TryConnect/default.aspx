<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="TryConnect._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>TryConnect</title>
    <style type="text/css">
        .auto-style3 {
            height: 38px;
        }
        .auto-style4 {
            height: 44px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table cellpadding="1">
                <tr><td class="auto-style3" style="text-align: center; font-size: 20px;" colspan=2>Try Connect</td></tr>
                <tr><td class="auto-style4">Enter your connection string</td><td class="auto-style4"><asp:TextBox ID="ConString" runat="server"  Width="1109px" ToolTip="Enter your connection string " Height="30px"></asp:TextBox></td></tr>
                <tr><td colspan=2><asp:Button ID="BtnTryConnect" runat="server" OnClick="BtnTryConnect_Click" Text="Connect"  Width="1304px" Height="40px"/></td></tr>
                <tr><td colspan=2><asp:TextBox ID="ExTxtbox" runat="server" TextMode="MultiLine" ReadOnly="True"  Width="1299px" Height="278px"></asp:TextBox></td></tr>
            </table>
        </div>
    </form>
</body>
</html>
