using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPNETSAMPLE1
{
    public partial class WebControls3:System.Web.UI.Page
    {
        protected void Button1_Click(object sender,EventArgs e)
        {
            genderId.Text = "";
            if(RadioButton1.Checked)
            {
                genderId.Text = "Your gender is " + RadioButton1.Text; 
            }
            else
            {
                genderId.Text = "Your gender is " + RadioButton2.Text;
            }
        }
    }
}