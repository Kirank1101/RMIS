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
            Response.Redirect("LogOnNew.aspx");
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
