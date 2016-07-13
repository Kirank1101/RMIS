<%@ WebHandler Language="C#" Class="SendMail" %>

using System;
using System.Web;

public class SendMail : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) 
    {
        RMIS.Domain.Business.IMailProvider imp = RMIS.Binder.BackEnd.BinderSingleton.Instance.GetInstance<RMIS.Domain.Business.IMailProvider>();
        imp.CallMailQueue();
    }
 
    public bool IsReusable {
        get {
            return true ;
        }
    }

}