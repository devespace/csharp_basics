using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Variables : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string name;
        string email = "maher.a.bo8@gmail.com";

        name = "Maher";
        double balance = 4.4;

        if (name == "Ali")
        {
            Response.Write("this is Ali");
        }
        else {
            Response.Write("this is not Ali");
        }


    }
}