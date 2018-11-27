<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Invoice.aspx.cs" Inherits="Papacito_KV.Invoice" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 400px;
            height: 400px;
        }
        .auto-style2 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style2">
            <div class="auto-style2">
                <img alt="" class="auto-style1" src="file:///C:/Users/CS180/Pictures/PapaBobsPizza.jpg" /><br />
                Bob&#39;s Pizza and Software<br />
                Order Invoice<br />
            </div>
            <asp:Panel ID="Panel1" runat="server">
                Pizza One<br /> Price
                <asp:Label ID="Label3" runat="server"></asp:Label>
                <br />
                <asp:Label ID="resultLabelP1" runat="server"></asp:Label>
                <br />
                Pizza One<br /> Price
                <asp:Label ID="Label2" runat="server"></asp:Label>
                <br />
                <asp:Label ID="resultLabelP2" runat="server" style="text-align: center"></asp:Label>
                <br />
                Pizza One<br /> Price
                <asp:Label ID="Label1" runat="server"></asp:Label>
                <br />
                <asp:Label ID="resultLabelP3" runat="server"></asp:Label>
            </asp:Panel>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Show Order" />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
