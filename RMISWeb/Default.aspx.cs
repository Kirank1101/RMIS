using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

public partial class MasterDataSettings : ApplicationBasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void LoginStatus1_LoggingOut(object sender, LoginCancelEventArgs e)
    {
        Session.Abandon();
        FormsAuthentication.SignOut();        
        Response.Redirect("LogOnNew.aspx");
        
    }

    
}