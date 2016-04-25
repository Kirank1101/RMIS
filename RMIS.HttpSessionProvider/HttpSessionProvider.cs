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
            if (HttpContext.Current.Session != null && HttpContext.Current.Session[sessionCustomerId]!=null)
            {
               return  Convert.ToString(HttpContext.Current.Session[sessionCustomerId]);
            }
            return "w32423";
          // throw new NotImplementedException();
        }
    }
}
