using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AjaxControlToolkit;

namespace RMIS.CustomControls
{
   public  class CustomTabContainer:TabContainer
    {
       protected override void LoadClientState(string clientState)
       {
           base.LoadClientState(clientState);

           // If post back was caused by control on a tab, make that tab the active one
           if (!string.IsNullOrEmpty(this.Page.Request.Params["__EVENTTARGET"]))
           {
               foreach (string ctlName in this.Page.Request.Params["__EVENTTARGET"].Split('$'))
               {
                   if (this.FindControl(ctlName) is TabPanel && this.Tabs.Contains(this.FindControl(ctlName) as TabPanel))
                   {
                       this.ActiveTab = (this.FindControl(ctlName) as TabPanel);
                       break;
                   }
               }
           }
       }
    }
}
