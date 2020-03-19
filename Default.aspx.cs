using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication8
{
    public partial class Default : System.Web.UI.Page
    {
        protected void btnOk_Click(object sender, EventArgs e)
        {
            Car x = new Car();
            x.brand = "BMW";

            //Label1.Text = x.model;
            Label1.Text = Convert.ToString(x.year) + " " + x.brand;
        }
    }
}