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
       
       // private bool PizzaTwo = false;
       // private bool PizzaThree = false;
        protected void Page_Load(object sender, EventArgs e)
        {
            pizzaOneInfo.Visible = false;
            pizzaTwoInfo.Visible = false;
            pizzaThreeInfo.Visible = false;
        }

        protected void orderButton_Click(object sender, EventArgs e)
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
                pizzaOneInfo.Visible = false;
                pizzaTwoInfo.Visible = true;
            }
            if (threePizza.Checked)
            {
                pizzaThreeInfo.Visible = false;
                pizzaOneInfo.Visible = true;
                pizzaTwoInfo.Visible = false;
            }
           
        }

        protected void cliq2Order_Click(object sender, EventArgs e)
        {

        }
    }

    
}