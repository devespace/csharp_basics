using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Arrays : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        List<string> colors = new List<string>();
        colors.Add("red");
        colors.Add("yellow");
        colors.Add("blue");
        Response.Write(colors[1]);
    }
}