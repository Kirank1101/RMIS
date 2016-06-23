using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using RMIS.Domain.DataTranserClass;
using RMIS.Domain.Constant;
using RMIS.Domain.Business;
using RMIS.Binder.BackEnd;
using System.Text;
using System.Web.UI;

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
    protected bool IsControlPostBack
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

    const string viewStatePageIndex = "viewStatePageIndex";
    protected int gridPageIndex
    {
        get
        {
            if (ViewState[viewStatePageIndex] == null)
                ViewState[viewStatePageIndex] = 0;
            return (Int32)ViewState[viewStatePageIndex];
        }
        set
        {
            ViewState[viewStatePageIndex] = value;
        }
    }



    const string viewStateSortExpression = "viewStateSortExpression";
    protected SortExpression expression
    {
        get
        {
            if (ViewState[viewStateSortExpression] == null)
                ViewState[viewStateSortExpression] = SortExpression.Asc;
            return (SortExpression)ViewState[viewStateSortExpression];
        }
        set
        {
            ViewState[viewStateSortExpression] = value;
        }
    }


    string viewstateHeader = "viewstateHeader";
    protected string Header
    {
        get
        {
            if (ViewState[viewstateHeader] == null)
                ViewState[viewstateHeader] = string.Empty;
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
        ISessionProvider imp = BinderSingleton.Instance.GetInstance<ISessionProvider>();
        if (imp.GetCurrentCustomerId() == null)
        {
            Response.Redirect("LogOnNew.aspx");
        }
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        pnlMessage.Visible = false;
        StringBuilder buildScript = new StringBuilder();
        buildScript.Append("window.onerror = function() {};");        
        ScriptManager.RegisterStartupScript(this, this.GetType(), "ErrorHandler", buildScript.ToString(), true);
        Page.ClientScript.RegisterStartupScript(Page.GetType(), "ErrorHandler", buildScript.ToString(), true);
    }


    protected void SetMessage(ResultDTO result)
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
        if (!IsControlPostBack)
            IsControlPostBack = true;

        lblHeader.Text = "<div><h3>" + this.Header + "</h3></div>";
    }
}