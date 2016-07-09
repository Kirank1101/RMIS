using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using log4net;
using RMIS.Domain.Business;
using RMIS.Binder.BackEnd;



/// <summary>
/// Summary description for HMISBasePage
/// </summary>
public class ApplicationBasePage : BasePage
{
    public bool IsAutecticated
    {
        get
        {
            if (((System.Web.HttpContext.Current.User != null) && System.Web.HttpContext.Current.User.Identity.IsAuthenticated))
                return true;
            return false;
        }
    }

    protected override void OnInit(EventArgs e)
    {
        base.OnInit(e);
        if (!IsAutecticated)
        {
            Response.Redirect("LogOn.aspx");
        }

    }


    const string viewStateParam = "viewStateParam";
    public string Param
    {
        get
        {
            if (ViewState[viewStateParam] == null)
                ViewState[viewStateParam] = string.Empty;
            return ViewState[viewStateParam] as string;
        }
        set
        {
            ViewState[viewStateParam] = value;
        }
    }


    public virtual void LoadUserControl()
    {
        return;
    }

    public virtual void LoadUserControl(string param)
    {
        return;
    }

    public const string usercontrolExtension = ".ascx";
    public const string BASE_PATH = "";
    public string LastLoadedControl
    {
        get
        {
            if (ViewState["LastLoaded"] == null)
            {
                ViewState["LastLoaded"] = BASE_PATH + "DashBoard.ascx";
            }
            return ViewState["LastLoaded"] as string;
        }
        set
        {
            ViewState["LastLoaded"] = value;
        }
    }




    #region Logger Instance
    private static readonly ILog Logger = LogManager.GetLogger(typeof(ApplicationBasePage));
    #endregion

    protected override void OnError(EventArgs e)
    {
        base.OnError(e);
        // Get last error from the server
        Exception exc = Server.GetLastError();
        if (exc is Exception)
        {
            Logger.Error("Error at Page Level-->HMISBasePage", exc);
        }
    }

}
