using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using RMIS.Domain.DataTranserClass;

/// <summary>
/// Summary description for BaseUserControl
/// </summary>
public class BaseUserControl : System.Web.UI.UserControl
{
	public BaseUserControl()
	{

        lblHeader = new Label();
        lblHeader.ID = "lblHeader";
        this.Controls.Add(lblHeader);

        pnlMessage = new Panel();
        pnlMessage.ID = "pnlMessage";
        this.Controls.Add(pnlMessage);

        lblMessage = new Label();
        lblMessage.ID = "lblMessage";
        pnlMessage.Controls.Add(lblMessage);
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


    string viewstateHeader = "viewstateHeader";
    protected string  Header
    {
        get
        {
            if (ViewState[viewstateHeader] == null)
                ViewState[viewstateHeader] = string.Empty ;
            return ViewState[viewstateHeader] as string;
        }
        set
        {
            ViewState[viewstateHeader] = value;
        }
    }

    protected Panel pnlMessage;
    protected Label lblMessage;
    Label lblHeader;

    protected override void OnInit(EventArgs e)
    {
       

        base.OnInit(e);

    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        pnlMessage.Visible = false;        
    }

    protected  void SetMessage(ResultDTO result)
    {
        if (result != null && !string.IsNullOrEmpty(result.Message))
        {
            pnlMessage.Visible = true;
            if (result.IsSuccess)
                pnlMessage.CssClass = "alert alert-success";
            else
                pnlMessage.CssClass = "alert alert-danger";
            lblMessage.Text = result.Message;
        }
    }

    protected override void OnPreRender(EventArgs e)
        {
        base.OnPreRender(e);
        if(!IsControlPostBack)
        IsControlPostBack = true;

        lblHeader.Text = "<div><h3>" + this.Header + "</h3></div>";
    }
}