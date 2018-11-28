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
        .auto-style4 {
            font-size: xx-large;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <div class="auto-style1">
                <asp:Panel ID="Panel8" runat="server">
                    <div class="auto-style1">
                        <span class="auto-style4">Select your how many pizzas you want to order and then click the B U T T O N!</span><br />
                        <br />
                    </div>
                    <asp:RadioButton ID="onePizza" runat="server" CssClass="auto-style3" GroupName="PizzaNumber" Text="One Pizza" />
                    <br class="auto-style3" />
                    <asp:RadioButton ID="twoPizza" runat="server" CssClass="auto-style3" GroupName="PizzaNumber" Text="Two Pizzas" />
                    <br class="auto-style3" />
                    <asp:RadioButton ID="threePizza" runat="server" CssClass="auto-style3" GroupName="PizzaNumber" Text="Three Pizzas" />
                    <br />
                    <asp:Button ID="orderButton" runat="server" OnClick="orderButton_Click" Text="B U T T O N" />
                </asp:Panel>
            </div>
            <br />
            <asp:Panel ID="pizzaOneInfo" runat="server" Height="337px" style="background-color: #FF6666">
                <div class="auto-style2">
                    <h1>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Pizza One</h1>
                </div>
                <br />
                <asp:RadioButton ID="RadioButton1" runat="server" Text="Baby Bob $10.00" GroupName="1" />
                <br />
                <asp:RadioButton ID="RadioButton2" runat="server" Text="Mama Bob $13.00" GroupName="1" />
                <br />
                <asp:RadioButton ID="RadioButton3" runat="server" Text="Papa Bob $16.00" GroupName="1" />
                <br />
                <br />
                <asp:RadioButton ID="RadioButtonThinOne" runat="server" Text="Thin Pizza" GroupName="2" />
                <br />
                <asp:RadioButton ID="RadioButtonThickone" runat="server" Text="Thick Pizza(Deep Dish) $2" GroupName="2" />
                <br />
                <br />
                <asp:CheckBox ID="CheckBox1" runat="server" Text="Peperoni $1.25" />
                <br />
                <asp:CheckBox ID="CheckBox2" runat="server" Text="Anchovies $2" />
                <br />
                <asp:CheckBox ID="CheckBox3" runat="server" Text="Green Pepers $0.50" />
                <br />
                <asp:CheckBox ID="CheckBox4" runat="server" Text="Blue Pepers $0.75" />
                <br />
                <asp:CheckBox ID="CheckBox5" runat="server" Text="Sasuge $1" />
            </asp:Panel>
            <asp:Panel ID="Panel2" runat="server">
            </asp:Panel>
            <asp:Panel ID="pizzaTwoInfo" runat="server" Height="327px" style="background-color: #FFFFCC">
                <div class="auto-style2">
                    <h1>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Pizza Two</h1>
                </div>
                <br />
                <asp:RadioButton ID="RadioButton4" runat="server" Text="Baby Bob $10.00" GroupName="3" />
                <br />
                <asp:RadioButton ID="RadioButton5" runat="server" Text="Mama Bob $13.00" GroupName="3" />
                <br />
                <asp:RadioButton ID="RadioButton6" runat="server" Text="Papa Bob $16.00" GroupName="3" />
                <br />
                <br />
                <asp:RadioButton ID="RadioButtonThinTwo" runat="server" Text="Thin Pizza" GroupName="4" />
                <br />
                <asp:RadioButton ID="RadioButtonThickTwo" runat="server" Text="Thick Pizza(Deep Dish) $2" GroupName="4" />
                <br />
                <br />
                <asp:CheckBox ID="CheckBox6" runat="server" Text="Peperoni $1.25" />
                <br />
                <asp:CheckBox ID="CheckBox7" runat="server" Text="Anchovies $2" />
                <br />
                <asp:CheckBox ID="CheckBox8" runat="server" Text="Green Pepers $0.50" />
                <br />
                <asp:CheckBox ID="CheckBox9" runat="server" Text="Blue Pepers $0.75" />
                <br />
                <asp:CheckBox ID="CheckBox10" runat="server" Text="Sasuge $1" />
                <br />
            </asp:Panel>
            <asp:Panel ID="pizzaThreeInfo" runat="server" Height="311px" style="background-color: #66CCFF">
                <div class="auto-style2">
                    <h1>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Pizza Three</h1>
                </div>
                <asp:RadioButton ID="RadioButton7" runat="server" Text="Baby Bob $10.00" GroupName="5" />
                <br />
                <asp:RadioButton ID="RadioButton8" runat="server" Text="Mama Bob $13.00" GroupName="5" />
                <br />
                <asp:RadioButton ID="RadioButton9" runat="server" Text="Papa Bob $16.00" GroupName="5" />
                <br />
                <br />
                <asp:RadioButton ID="RadioButtonThinThree" runat="server" Text="Thin Pizza" GroupName="6" />
                <br />
                <asp:RadioButton ID="RadioButtonThickThree" runat="server" Text="Thick Pizza(Deep Dish) $2" GroupName="6" />
                <br />
                <br />
                <asp:CheckBox ID="CheckBox11" runat="server" Text="Peperoni $1.25" />
                <br />
                <asp:CheckBox ID="CheckBox12" runat="server" Text="Anchovies $2" />
                <br />
                <asp:CheckBox ID="CheckBox13" runat="server" Text="Green Pepers $0.50" />
                <br />
                <asp:CheckBox ID="CheckBox14" runat="server" Text="Blue Pepers $0.75" />
                <br />
                <asp:CheckBox ID="CheckBox15" runat="server" Text="Sasuge $1" />
                <br />
                <br />
            </asp:Panel>
            <asp:Panel ID="Panel9" runat="server">
                <asp:Button ID="cliq2Order" runat="server" Text="Press Me!" OnClick="cliq2Order_Click" />
            </asp:Panel>
            <br />
            <asp:Panel ID="Panel5" runat="server" style="text-align: center; background-color: #FF3300;" Visible="False">
                <span class="auto-style4">Pizza 1</span><br /> Price
                <asp:Label ID="Label1" runat="server"></asp:Label>
                <br />
                <asp:Label ID="resultLabelP1" runat="server"></asp:Label>
                <asp:Label ID="Label4" runat="server"></asp:Label>
                <asp:Label ID="Label5" runat="server"></asp:Label>
                <asp:Label ID="Label6" runat="server"></asp:Label>
                <asp:Label ID="Label7" runat="server"></asp:Label>
                <asp:Label ID="Label8" runat="server"></asp:Label>
                <asp:Label ID="Label9" runat="server"></asp:Label>
            </asp:Panel>
            <asp:Panel ID="Panel6" runat="server" style="text-align: center; background-color: #FF9966;" Visible="False">
                <span class="auto-style4">Pizza 2</span><br /> Price
                <asp:Label ID="Label2" runat="server"></asp:Label>
                <br />
                <asp:Label ID="resultLabelP2" runat="server" style="text-align: center"></asp:Label>
                <asp:Label ID="Label10" runat="server"></asp:Label>
                <asp:Label ID="Label11" runat="server"></asp:Label>
                <asp:Label ID="Label12" runat="server"></asp:Label>
                <asp:Label ID="Label13" runat="server"></asp:Label>
                <asp:Label ID="Label14" runat="server"></asp:Label>
                <asp:Label ID="Label15" runat="server"></asp:Label>
            </asp:Panel>
            <asp:Panel ID="Panel7" runat="server" style="text-align: center; background-color: #6699FF;" Visible="False">
                <span class="auto-style4">Pizza 3</span><br /> Price
                <asp:Label ID="Label3" runat="server"></asp:Label>
                <br />
                <asp:Label ID="resultLabelP3" runat="server"></asp:Label>
                <asp:Label ID="Label16" runat="server"></asp:Label>
                <asp:Label ID="Label17" runat="server"></asp:Label>
                <asp:Label ID="Label18" runat="server"></asp:Label>
                <asp:Label ID="Label19" runat="server"></asp:Label>
                <asp:Label ID="Label20" runat="server"></asp:Label>
                <asp:Label ID="Label21" runat="server"></asp:Label>
            </asp:Panel>
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
