<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePAge.aspx.cs" Inherits="Papacito_KV.HomePAge" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <asp:Image ID="Image1" runat="server" Height="371px" ImageUrl="~/article-0-081CE324000005DC-88_224x423.jpg" style="text-align: center" Width="334px" />
            <br />
            <br />
            Welcome to Papa Gordans Pizzeria!<br />
            <br />
            <asp:Button ID="mainPageButton" runat="server" Text="Click Here To Continue" OnClick="mainPageButton_Click" />
        </div>
    </form>
</body>
</html>
