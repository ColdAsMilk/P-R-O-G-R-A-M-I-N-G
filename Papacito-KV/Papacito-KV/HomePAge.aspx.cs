using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Papacito_KV
{
    public partial class HomePAge : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void mainPageButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("OrderingForm.aspx");
        }
    }
}