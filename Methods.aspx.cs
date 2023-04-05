using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Methods : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Write(AddNumbers(10, 15));
        DoSomething();
    }

    public int AddNumbers(int n1, int n2)
    {
        return n1 + n2;
    }

    public void DoSomething()
    {
        Response.Write("Something Done!");
    }

}