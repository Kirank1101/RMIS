namespace iucon.web.Controls
{


    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Web;
    using System.Web.SessionState;
    using System.Collections;
    using System.Web.Script.Serialization;
    
    
   public  class PartialUpdatePanelHandler : IHttpHandler, System.Web.SessionState.IRequiresSessionState
    {
        #region IHttpHandler Members

        public bool IsReusable
        {
            get { return false ; }
        }

        public void ProcessRequest(HttpContext context)
        {
            if (context.Request.Form["__USERCONTROLPATH"] != null)
            {
                try
                {
                    bool isControlPathEncrypted = context.Request.Form["__ENCRYPTED"] != null;
                    string controlPath = isControlPathEncrypted ? Encryptor.DecryptFromString(context.Request.Form["__USERCONTROLPATH"]) : context.Request.Form["__USERCONTROLPATH"];
                    string controlClientID = context.Request.Form["__CONTROLCLIENTID"];
                    System.Collections.IDictionary scriptInfo = DeserializeScriptManagerInfo(context);

                    PanelHostPage page = new PanelHostPage(controlPath, controlClientID, scriptInfo);

                    ((IHttpHandler)page).ProcessRequest(context);

                    context.Response.Clear();
                    context.Response.Write(page.GetHtmlContent());

                }
                catch (Exception ex)
                {
                    // Prevent ScriptModule from reformatting the exception
                    if (HttpContext.Current.Items["System.Web.UI.PageRequestManager:AsyncPostBackError"] != null)
                        HttpContext.Current.Items["System.Web.UI.PageRequestManager:AsyncPostBackError"] = false;

                    if (ex.InnerException != null)
                    {
                        context.Response.Write(ex.InnerException.Message.Replace("\n", "<br />"));
                        context.Response.Write("<hr />");
                        context.Response.Write(ex.InnerException.StackTrace.Replace("\n", "<br />"));
                    }
                    else
                    {
                        context.Response.Write(ex.Message.Replace("\n", "<br />"));
                        context.Response.Write("<hr />");
                        context.Response.Write(ex.StackTrace.Replace("\n", "<br />"));
                    }
                }
            }
        }

        private static IDictionary DeserializeScriptManagerInfo(HttpContext context)
        {
            string scriptManagerInfo = context.Request.Form["__SCRIPTMANAGERINFO"];
            Hashtable info = new Hashtable();

            if (!string.IsNullOrEmpty(scriptManagerInfo))
            {
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                Parameter[] parameters = serializer.Deserialize<Parameter[]>(scriptManagerInfo);
                if (parameters != null && parameters.Length > 0)
                {
                    foreach (Parameter p in parameters)
                    {
                        info[p.Name] = p.Value;
                    }
                }
            }

            return info;
        }

        #endregion
    }
}