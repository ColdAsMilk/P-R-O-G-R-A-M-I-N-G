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
                pizzaThreeInfo.Visible = true;
                pizzaOneInfo.Visible = false;
                pizzaTwoInfo.Visible = false;
            }
            if (twoPizza.Checked)
            {
                pizzaThreeInfo.Visible = false;
                pizzaOneInfo.Visible = true;
                pizzaTwoInfo.Visible = true;
            }
            if (threePizza.Checked)
            {
                pizzaThreeInfo.Visible = true;
                pizzaOneInfo.Visible = true;
                pizzaTwoInfo.Visible = true;
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

            else if (RadioButton3.Checked)
            {
                total = total + 16;
            }

            else if (RadioButtonThinOne.Checked)
            {
                total = total + 0;
            }

            else
            {
                total = total + 2;
            }

            total = (CheckBox1.Checked) ? total + 1.25: total;
            total = (CheckBox2.Checked) ? total + 1: total;
            total = (.Ch ecked) ? total + 0.50: total;
            total = (.Checked) ? total + __: total;
            total = (.Checked) ? total + __: total;
            /*if (CheckBox1.Checked)
            {
                total = total + 1.25;
            }

            if (CheckBox2.Checked)
            {
                total = total + 1;
            }

            if (CheckBox3.Checked)
            {
                total = total + 0.50;
            }

            if (CheckBox4.Checked)
            {
                total = total + 0.75;

            }
            if (CheckBox5.Checked)
            {
                total = total + 2;
            }
            */

            //Pizza2
            if (RadioButton4.Checked)
            {
                total2 = total2 + babysize + 1;
            }

            else if (RadioButton5.Checked)
            {
                total2 = total2 + mamasize + 1;
            }

            else if (RadioButton6.Checked)
            {
                total2 = total2 + papasize + 1;
            }

            else if (RadioButtonThinTwo.Checked)
            {
                total2 = total2 + thincrust;
            }

            else if (RadioButtonThickTwo.Checked)
            {
                total2 = total2 + deepdish;
            }

            if (CheckBox6.Checked)
            {
                total2 = total2 + pepperoni + 1;
            }

            if (CheckBox7.Checked)
            {
                total2 = total2 + Sasuge + 1;
            }

            if (CheckBox8.Checked)
            {
                total2 = total2 + greenpepper + 1;
            }

            if (CheckBox9.Checked)
            {
                total2 = total2 + bluepepper + 1;

            }
            if (CheckBox10.Checked)
            {
                total2 = total2 + anchovices + 1;
            }




            //Pizza 3
            if (RadioButton7.Checked)
            {
                total3 = total3 + babysize + 1;
            }

            else if (RadioButton8.Checked)
            {
                total3 = total3 + mamasize + 1;
            }

            else if (RadioButton9.Checked)
            {
                total3 = total3 + papasize + 1;
            }

            else if (RadioButtonThinThree.Checked)
            {
                total3 = total3 + thincrust;
            }

            else if (RadioButtonThickThree.Checked)
            {
                total3 = total3 + deepdish;
            }

            if (CheckBox11.Checked)
            {
                total3 = total3 + pepperoni + 1;
            }

            if (CheckBox12.Checked)
            {
                total3 = total3 + Sasuge + 1;
            }

            if (CheckBox13.Checked)
            {
                total3 = total3 + greenpepper + 1;
            }

            if (CheckBox14.Checked)
            {
                total3 = total3 + bluepepper + 1;

            }
            if (CheckBox15.Checked)
            {
                total3 = total3 + anchovices + 1;
            }
            if (onePizza.Checked)
            {
                Label1.Text = "$" + total.ToString();
                Panel5.Visible = true;
                Panel6.Visible = false;
                Panel7.Visible = false;
                Panel8.Visible = false;
            }
            else if (twoPizza.Checked)
            {
                Label1.Text = "$" + total.ToString();
                Label2.Text = "$" + total2.ToString();
                Panel5.Visible = true;
                Panel6.Visible = true;
                Panel7.Visible = false;
                Panel8.Visible = false;
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
            }
        }
    }
}