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
            if (threePizza.Checked)
            {
                pizzaThreeInfo.Visible = true;
               
            }
            if (twoPizza.Checked || threePizza.Checked)
            {
                pizzaTwoInfo.Visible = true;
            }
           pizzaOneInfo.Visible = true;
        }



    }

    
}