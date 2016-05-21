using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.Security;
using RMIS.Domain.Business;
using RMIS.Binder.BackEnd;

/// <summary>
/// Summary description for BasePage
/// </summary>
public class BasePage : Page
{
    protected override void OnInit(EventArgs e)
    {
        base.OnInit(e);
        ISessionProvider imp = BinderSingleton.Instance.GetInstance<ISessionProvider>();
        if (!string.IsNullOrEmpty(imp.GetApplicationName()))
        {
            Membership.ApplicationName = imp.GetApplicationName();
            Roles.ApplicationName = imp.GetApplicationName();
        }
    }
}