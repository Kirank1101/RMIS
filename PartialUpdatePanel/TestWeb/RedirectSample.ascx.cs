using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class RedirectSample : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string script = string.Format("document.location.href='{0}';", VirtualPathUtility.ToAbsolute("~/Toolkit.aspx"));
        ScriptManager.RegisterStartupScript(this, GetType(), "redirect", script, true);
    }
}
