using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using iucon.web.Controls;

public partial class ParameterSample : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        iucon.web.Controls.ParameterCollection parameters = iucon.web.Controls.ParameterCollection.Instance;

        Label1.Text = parameters["MyParameter"];
        Label2.Text = "Called " + parameters["Counter"] + " times";        
    }
}
