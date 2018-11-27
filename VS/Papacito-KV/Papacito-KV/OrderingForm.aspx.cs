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
            total = 01;
            total2 = 01;
            total3 = 01;

            //Pizza 1
            if (RadioButton1.Checked)
            {
                total = total + babysize;
            }

            else if (RadioButton2.Checked)
            {
                total = total + mamasize;
            }

            else if (RadioButton3.Checked)
            {
                total = total + papasize;
            }

            else if (RadioButtonThinOne.Checked)
            {
                total = total + thincrust;
            }

            else if (RadioButtonThickone.Checked)
            {
                total = total + deepdish;
            }

            if (CheckBox1.Checked)
            {
                total = total + pepperoni;
            }

            if (CheckBox2.Checked)
            {
                total = total + Sasuge;
            }

            if (CheckBox3.Checked)
            {
                total = total + greenpepper;
            }

            if (CheckBox4.Checked)
            {
                total = total + bluepepper;

            }
            if (CheckBox5.Checked)
            {
                total = total + anchovices;
            }


            //Pizza2
            if (RadioButton4.Checked)
            {
                total2 = total2 + babysize;
            }

            else if (RadioButton5.Checked)
            {
                total2 = total2 + mamasize;
            }

            else if (RadioButton6.Checked)
            {
                total2 = total2 + papasize;
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
                total2 = total2 + pepperoni;
            }

            if (CheckBox7.Checked)
            {
                total2 = total2 + Sasuge;
            }

            if (CheckBox8.Checked)
            {
                total2 = total2 + greenpepper;
            }

            if (CheckBox9.Checked)
            {
                total2 = total2 + bluepepper;

            }
            if (CheckBox10.Checked)
            {
                total2 = total2 + anchovices;
            }




            //Pizza 3
            if (RadioButton7.Checked)
            {
                total3 = total3 + babysize;
            }

            else if (RadioButton8.Checked)
            {
                total3 = total3 + mamasize;
            }

            else if (RadioButton9.Checked)
            {
                total3 = total3 + papasize;
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
                total3 = total3 + pepperoni;
            }

            if (CheckBox12.Checked)
            {
                total3 = total3 + Sasuge;
            }

            if (CheckBox13.Checked)
            {
                total3 = total3 + greenpepper;
            }

            if (CheckBox14.Checked)
            {
                total3 = total3 + bluepepper;

            }
            if (CheckBox15.Checked)
            {
                total3 = total3 + anchovices;
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