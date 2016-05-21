using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RMIS.Domain.Business;
using System.Web;

namespace RMIS.HttpSessionProvider
{
    public class HttpSessionProvider : ISessionProvider
    {
        string sessionCustomerId = "CustomerId";
        public string GetCurrentCustomerId()
        {
            if (HttpContext.Current.Session != null && HttpContext.Current.Session[sessionCustomerId] != null)
            {
                return Convert.ToString(HttpContext.Current.Session[sessionCustomerId]);
            }
            return "test1";
            // throw new NotImplementedException();
        }

        public void SetCurrentCustomerId(string customerId)
        {
            if (HttpContext.Current.Session != null)
            {
                HttpContext.Current.Session[sessionCustomerId] = customerId;
            }
            // throw new NotImplementedException();
        }


        string sessionUserId = "UserId";
        public string GetLoggedInUserId()
        {
            if (HttpContext.Current.Session != null && HttpContext.Current.Session[sessionUserId] != null)
            {
                return Convert.ToString(HttpContext.Current.Session[sessionUserId]);
            }
            return "System";
        }


        public void SetLoggedInUserId(string userId)
        {
            if (HttpContext.Current.Session != null)
            {
                HttpContext.Current.Session[sessionUserId] = userId;
            }
        }


        string sessionApplicationName = "ApplicationName";
        public string GetApplicationName()
        {
            if (HttpContext.Current.Session != null && HttpContext.Current.Session[sessionApplicationName] != null)
            {
                return Convert.ToString(HttpContext.Current.Session[sessionApplicationName]);
            }
            return "System";
        }

        public void SetApplicationName(string applicationName)
        {
            if (HttpContext.Current.Session != null)
            {
                HttpContext.Current.Session[sessionApplicationName] = applicationName;
            }
        }

    }
}
