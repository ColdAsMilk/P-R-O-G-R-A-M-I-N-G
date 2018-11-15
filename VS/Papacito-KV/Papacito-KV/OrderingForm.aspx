<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderingForm.aspx.cs" Inherits="Papacito_KV.OrderingForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: left;
        }
        .auto-style2 {
            text-align: left;
            font-weight: 700;
        }
    	.auto-style3 {
			color: #000000;
			background-color: #666666;
		}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <div class="auto-style1">
                <asp:Image ID="Image2" runat="server" Height="328px" ImageUrl="~/article-0-081CE324000005DC-88_224x423.jpg" Width="1466px" />
                <br />
                <br />
                Select your how many pizzas you want to order and then click the B U T T O N!<br />
                <br />
            </div>
            <asp:RadioButton ID="onePizza" runat="server" CssClass="auto-style3" GroupName="PizzaNumber" Text="One Pizza" />
			<br class="auto-style3" />
			<asp:RadioButton ID="twoPizza" runat="server" CssClass="auto-style3" GroupName="PizzaNumber" Text="Two Pizzas" />
			<br class="auto-style3" />
			<asp:RadioButton ID="threePizza" runat="server" CssClass="auto-style3" GroupName="PizzaNumber" Text="Three Pizzas" />
			<br />
			<br />
&nbsp;&nbsp;
            <asp:Button ID="orderButton" runat="server" OnClick="orderButton_Click" Text="B U T T O N" />
            <br />
            <asp:Panel ID="pizzaOneInfo" runat="server" Height="395px" style="background-color: #FF6666">
                <div class="auto-style2">
                    <h1>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Pizza One</h1>
                </div>
                <asp:RadioButtonList ID="p1Size" runat="server">
                    <asp:ListItem>Small Pizza 10$</asp:ListItem>
                    <asp:ListItem>Medium Pizza 13$</asp:ListItem>
                    <asp:ListItem>PIZZA GRANDE 16$</asp:ListItem>
                </asp:RadioButtonList>
                <br />
                <asp:RadioButtonList ID="p1Type" runat="server">
                    <asp:ListItem>Thin Pizza</asp:ListItem>
                    <asp:ListItem>Thicc Pizza(DeepDish) 2$</asp:ListItem>
                </asp:RadioButtonList>
                <br />
                <asp:CheckBoxList ID="p1Toppings" runat="server">
                    <asp:ListItem>Peperoni 1.25$</asp:ListItem>
                    <asp:ListItem>Anchovies 2$</asp:ListItem>
                    <asp:ListItem>Green Pepers .50$</asp:ListItem>
                    <asp:ListItem>Blue Pepers .75$</asp:ListItem>
                    <asp:ListItem>Sasuge 1$</asp:ListItem>
                </asp:CheckBoxList>
                <br />
            </asp:Panel>
            <asp:Panel ID="Panel2" runat="server">
            </asp:Panel>
            <asp:Panel ID="pizzaTwoInfo" runat="server" Height="356px" style="background-color: #FFFFCC">
                <div class="auto-style2">
                    <h1>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Pizza Two</h1>
                </div>
                <asp:RadioButtonList ID="p2Size" runat="server">
                    <asp:ListItem>Small Pizza 10$</asp:ListItem>
                    <asp:ListItem>Medium Pizza 13$</asp:ListItem>
                    <asp:ListItem>PIZZA GRANDE 16$</asp:ListItem>
                </asp:RadioButtonList>
                <br />
                <asp:RadioButtonList ID="p2Type" runat="server">
                    <asp:ListItem>Thin Pizza</asp:ListItem>
                    <asp:ListItem>Thicc Pizza(DeepDish) 2$</asp:ListItem>
                </asp:RadioButtonList>
                <br />
                <asp:CheckBoxList ID="p2Toppings" runat="server">
                    <asp:ListItem>Peperoni 1.25$</asp:ListItem>
                    <asp:ListItem>Anchovies 2$</asp:ListItem>
                    <asp:ListItem>Green Pepers .50$</asp:ListItem>
                    <asp:ListItem>Blue Pepers .75$</asp:ListItem>
                    <asp:ListItem>Sasuge 1$</asp:ListItem>
                </asp:CheckBoxList>
                <br />
                <br />
            </asp:Panel>
            <asp:Panel ID="pizzaThreeInfo" runat="server" Height="356px" style="background-color: #66CCFF">
                <div class="auto-style2">
                    <h1>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Pizza Three</h1>
                </div>
                <asp:RadioButtonList ID="p3Size" runat="server">
                    <asp:ListItem>Small Pizza 10$</asp:ListItem>
                    <asp:ListItem>Medium Pizza 13$</asp:ListItem>
                    <asp:ListItem>PIZZA GRANDE 16$</asp:ListItem>
                </asp:RadioButtonList>
                <br />
                <asp:RadioButtonList ID="p3Type" runat="server">
                    <asp:ListItem>Thin Pizza</asp:ListItem>
                    <asp:ListItem>Thicc Pizza(DeepDish) 2$</asp:ListItem>
                </asp:RadioButtonList>
                <br />
                <asp:CheckBoxList ID="p3Toppings" runat="server">
                    <asp:ListItem>Peperoni 1.25$</asp:ListItem>
                    <asp:ListItem>Anchovies 2$</asp:ListItem>
                    <asp:ListItem>Green Pepers .50$</asp:ListItem>
                    <asp:ListItem>Blue Pepers .75$</asp:ListItem>
                    <asp:ListItem>Sasuge 1$</asp:ListItem>
                </asp:CheckBoxList>
                <br />
                <br />
            </asp:Panel>
            <asp:Button ID="cliq2Order" runat="server" Text="Press Me!" OnClick="cliq2Order_Click" />
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
            <br />
        </div>
    </form>
</body>
</html>
