using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPNETSAMPLE1
{
    public partial class WebControls1 : System.Web.UI.Page
    {
        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = "You Clicked the Button.";
        }
    }
}