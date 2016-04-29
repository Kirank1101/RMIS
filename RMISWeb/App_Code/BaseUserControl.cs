using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BaseUserControl
/// </summary>
public class BaseUserControl : System.Web.UI.UserControl
{
	public BaseUserControl()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    string viewstateIsControlPostBack = "IsControlPostBack";
    protected  bool IsControlPostBack
    {
        get
        {
            if (ViewState[viewstateIsControlPostBack] == null)
                ViewState[viewstateIsControlPostBack] = false;
            return (bool)ViewState[viewstateIsControlPostBack];
        }
        set
        {
            ViewState[viewstateIsControlPostBack] = value;
        }
    }

    protected override void OnPreRender(EventArgs e)
    {
        base.OnPreRender(e);
        if(!IsControlPostBack)
        IsControlPostBack = true;
    }
}