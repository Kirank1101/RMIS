using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.Security;

/// <summary>
/// Summary description for BasePage
/// </summary>
public class BasePage : Page
{
    protected override void OnInit(EventArgs e)
    {
        base.OnInit(e);
        if (!string.IsNullOrEmpty(ApplicationName))
        {
            Membership.ApplicationName = ApplicationName;
            Roles.ApplicationName = ApplicationName;
        }

    }

    string sessionApplicationName = "ApplicationName";
    protected string ApplicationName
    {

        get
        {
            if (HttpContext.Current.Session != null && HttpContext.Current.Session[sessionApplicationName] != null)
            {
                return Convert.ToString(HttpContext.Current.Session[sessionApplicationName]);
            }
            return null;
        }
        // throw new NotImplementedException();
    }

    string sessionCustomerId = "sessionCustomerId";
    protected string CustomerId
    {

        get
        {
            if (HttpContext.Current.Session != null && HttpContext.Current.Session[sessionCustomerId] != null)
            {
                return Convert.ToString(HttpContext.Current.Session[sessionCustomerId]);
            }
            return null;
        }
        // throw new NotImplementedException();
    }
}