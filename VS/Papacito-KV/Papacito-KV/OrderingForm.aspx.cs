using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Papacito_KV
{
    public partial class OrderingForm : System.Web.UI.Page
    {
        public void Page_Load(object sender, EventArgs e)
        {
            pizzaOneInfo.Visible = false;
            pizzaTwoInfo.Visible = false;
            pizzaThreeInfo.Visible = false;
        }

        public void orderButton_Click(object sender, EventArgs e)
        {
            if (onePizza.Checked)
            {
                pizzaThreeInfo.Visible = false;
                pizzaOneInfo.Visible = true;
                pizzaTwoInfo.Visible = false;
                Panel9.Visible = true;
            }
            if (twoPizza.Checked)
            {
                pizzaThreeInfo.Visible = false;
                pizzaOneInfo.Visible = true;
                pizzaTwoInfo.Visible = true;
                Panel9.Visible = true;
            }
            if (threePizza.Checked)
            {
                pizzaThreeInfo.Visible = true;
                pizzaOneInfo.Visible = true;
                pizzaTwoInfo.Visible = true;
                Panel9.Visible = true;
            }

        }

        public void cliq2Order_Click(object sender, EventArgs e)
        {
            double babysize, mamasize, papasize, deepdish, total2, total3, pepperoni, thincrust, Sasuge, total, greenpepper, bluepepper, anchovices;
            babysize = 10;
            mamasize = 13;
            papasize = 16;
            deepdish = 02;
            pepperoni = 01.25;
            thincrust = 0;
            Sasuge = 01;
            greenpepper = 00.50;
            bluepepper = 00.75;
            anchovices = 02;
            total = 0;
            total2 = 0;
            total3 = 0;

            //Pizza 1
            if (RadioButton1.Checked)
            {
                total = total + 10;
            }

            else if (RadioButton2.Checked)
            {
                total = total + 13;
            }
            else
            {
                total = total + 16;
            }
            if (RadioButtonThickone.Checked)
            {
                total += 2;
            }
            total = (CheckBox1.Checked) ? total + 1.25: total;
            total = (CheckBox2.Checked) ? total + 2: total;
            total = (CheckBox3.Checked) ? total + 0.50: total;
            total = (CheckBox4.Checked) ? total + 0.75: total;
            total = (CheckBox5.Checked) ? total + 1: total;

            //Pizza2
            if (RadioButton4.Checked)
            {
                total2 = total2 + 10;
            }

            else if (RadioButton5.Checked)
            {
                total2 = total2 + 13;
            }
            else
            {
                total2 = total2 + 16;
            }
            if (RadioButtonThickTwo.Checked)
            {
                total2 += 2;
            }
            total2 = (CheckBox6.Checked) ? total2 + 1.25 : total2;
            total2 = (CheckBox7.Checked) ? total2 + 2 : total2;
            total2 = (CheckBox8.Checked) ? total2 + 0.50 : total2;
            total2 = (CheckBox9.Checked) ? total2 + 0.75 : total2;
            total2 = (CheckBox10.Checked) ? total2 + 1 : total2;

            //Pizza 3
            if (RadioButton7.Checked)
            {
                total3 = total3 + 10;
            }

            else if (RadioButton8.Checked)
            {
                total3 = total3 + 13;
            }
            else
            {
                total3 = total3 + 16;
            }
            if (RadioButtonThickThree.Checked)
            {
                total3 += 2;
            }
            total3 = (CheckBox11.Checked) ? total3 + 1.25 : total3;
            total3 = (CheckBox12.Checked) ? total3 + 2 : total3;
            total3 = (CheckBox13.Checked) ? total3 + 0.50 : total3;
            total3 = (CheckBox14.Checked) ? total3 + 0.75 : total3;
            total3 = (CheckBox15.Checked) ? total3 + 1 : total3;
            //
            if (onePizza.Checked)
            {
                Label1.Text = "$" + total.ToString();
                Panel5.Visible = true;
                Panel6.Visible = false;
                Panel7.Visible = false;
                Panel8.Visible = false;
                Panel9.Visible = false;

            }
            else if (twoPizza.Checked)
            {
                Label1.Text = "$" + total.ToString();
                Label2.Text = "$" + total2.ToString();
                Panel5.Visible = true;
                Panel6.Visible = true;
                Panel7.Visible = false;
                Panel8.Visible = false;
                Panel9.Visible = false;
            }
            else if (threePizza.Checked)
            {
                Label3.Text = "$" + total3.ToString();
                Label2.Text = "$" + total2.ToString();
                Label1.Text = "$" + total.ToString();
                Panel5.Visible = true;
                Panel6.Visible = true;
                Panel7.Visible = true;
                Panel8.Visible = false;
                Panel9.Visible = false;
            }
            //PizzaOneDics
            if (RadioButton1.Checked)
            {
                resultLabelP1.Text = "Baby Bob";
            }
            else if (RadioButton2.Checked)
            {
                resultLabelP1.Text = "Mama Bob";
            }
            else if (RadioButton3.Checked)
            {
                resultLabelP1.Text = "Papa Bob";
            }
            if (RadioButtonThinOne.Checked)
            {
                Label4.Text = ", Thin Pizza";
            }
            else if (RadioButtonThickone.Checked)
            {
                Label4.Text = ", Thick Pizza";
            }
            if (CheckBox1.Checked)
            {
                Label5.Text = ", Peperoni";
            }
            if (CheckBox2.Checked)
            {
                Label6.Text = ", Anchovies";
            }
            if (CheckBox3.Checked)
            {
                Label7.Text = ", Green Pepers";
            }
            if (CheckBox4.Checked)
            {
                Label8.Text = ", Blue Pepers";
            }
            if (CheckBox5.Checked)
            {
                Label9.Text = ", Sasuge";
            }

            //PizzaTwoDics
            if (RadioButton4.Checked)
            {
                resultLabelP2.Text = "Baby Bob";
            }
            else if (RadioButton5.Checked)
            {
                resultLabelP2.Text = "Mama Bob";
            }
            else if (RadioButton6.Checked)
            {
                resultLabelP2.Text = "Papa Bob";
            }
            if (RadioButtonThinTwo.Checked)
            {
                Label10.Text = ", Thin Pizza";
            }
            else if (RadioButtonThickTwo.Checked)
            {
                Label10.Text = ", Thick Pizza";
            }
            if (CheckBox6.Checked)
            {
                Label11.Text = ", Peperoni";
            }
            if (CheckBox7.Checked)
            {
                Label12.Text = ", Anchovies";
            }
            if (CheckBox8.Checked)
            {
                Label13.Text = ", Green Pepers";
            }
            if (CheckBox9.Checked)
            {
                Label14.Text = ", Blue Pepers";
            }
            if (CheckBox10.Checked)
            {
                Label15.Text = ", Sasuge";
            }

            //PizzaThreeDics
            if (RadioButton7.Checked)
            {
                resultLabelP3.Text = "Baby Bob";
            }
            else if (RadioButton8.Checked)
            {
                resultLabelP3.Text = "Mama Bob";
            }
            else if (RadioButton9.Checked)
            {
                resultLabelP3.Text = "Papa Bob";
            }
            if (RadioButtonThinThree.Checked)
            {
                Label16.Text = ", Thin Pizza";
            }
            else if (RadioButtonThickThree.Checked)
            {
                Label16.Text = ", Thick Pizza";
            }
            if (CheckBox11.Checked)
            {
                Label17.Text = ", Peperoni";
            }
            if (CheckBox12.Checked)
            {
                Label18.Text = ", Anchovies";
            }
            if (CheckBox13.Checked)
            {
                Label19.Text = ", Green Pepers";
            }
            if (CheckBox14.Checked)
            {
                Label20.Text = ", Blue Pepers";
            }
            if (CheckBox15.Checked)
            {
                Label21.Text = ", Sasuge";
            }

        }
    }
}