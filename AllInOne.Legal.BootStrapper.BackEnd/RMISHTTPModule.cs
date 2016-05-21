using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace AllInOne.BootStrapper.BackEnd
{

    public abstract class ApplicationStartModuleBase : IHttpModule
    {
        #region Static privates

        private static volatile bool applicationStarted = false;
        private static object applicationStartLock = new object();

        #endregion

        #region IHttpModule implementation

        /// <summary>
        /// Disposes of the resources (other than memory) used by the module that implements <see cref="T:System.Web.IHttpModule"/>.
        /// </summary>
        public void Dispose()
        {
            // dispose any resources if needed
        }

        /// <summary>
        /// Initializes the specified module.
        /// </summary>
        /// <param name="context">The application context that instantiated and will be running this module.</param>
        public void Init(HttpApplication context)
        {
            if (!applicationStarted)
            {
                lock (applicationStartLock)
                {
                    if (!applicationStarted)
                    {
                        // this will run only once per application start
                        this.OnStart(context);
                        applicationStarted = true;
                    }
                }
            }
            // this will run on every HttpApplication initialization in the application pool
            this.OnInit(context);
        }

        #endregion

        /// <summary>Initializes any data/resources on application start.</summary>
        /// <param name="context">The application context that instantiated and will be running this module.</param>
        public virtual void OnStart(HttpApplication context)
        {
            // put your application start code here
        }

        /// <summary>Initializes any data/resources on HTTP module start.</summary>
        /// <param name="context">The application context that instantiated and will be running this module.</param>
        public virtual void OnInit(HttpApplication context)
        {            
            context.AuthenticateRequest += new EventHandler(context_AuthenticateRequest);
            //throw new NotImplementedException();
        }

        void context_AuthenticateRequest(object sender, EventArgs e)
        {
            //if (!string.IsNullOrEmpty(ApplicationName))
            //{
            //string appName = Membership.ApplicationName;// = ApplicationName;
            //string appName2 = Roles.ApplicationName;// = ApplicationName;
            //}
        }
    }

    /// <summary>
    /// Summary description for RMISHTTPModule
    /// </summary>
    public class RMISHTTPModule : ApplicationStartModuleBase
    {
        public RMISHTTPModule()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        public void Init(HttpApplication context)
        {
            base.Init(context);
            context.AuthenticateRequest += new EventHandler(context_AuthenticateRequest);
            //throw new NotImplementedException();
        }

        void context_AuthenticateRequest(object sender, EventArgs e)
        {
            //if (!string.IsNullOrEmpty(ApplicationName))
            //{
             string appName=   Membership.ApplicationName;// = ApplicationName;
             string appName2 = Roles.ApplicationName;// = ApplicationName;
            //}
        }

        public override void OnStart(HttpApplication context)
        {
            BootStrapper.ConfigLogger(string.Empty);
            BootStrapper.StartUp();
            // base.OnStart(context);
        }
    }
}