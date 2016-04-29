using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RMIS.Domain.DataTranserClass;

public partial class MessageDisplay : System.Web.UI.UserControl
{   
    protected void Page_Load(object sender, EventArgs e)
    {
        pnlMessage.Visible = false;
    }

    public void SetMessage(ResultDTO result)
    {
        if (result != null && !string.IsNullOrEmpty(result.Message))
        {
            pnlMessage.Visible = true;
            if(result.IsSuccess)
                pnlMessage.CssClass = "alert alert-success";
            else
                pnlMessage.CssClass = "alert alert-danger";
            lblMessage.Text = result.Message;
        }
    }
}