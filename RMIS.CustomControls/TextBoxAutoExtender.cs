using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;
using AjaxControlToolkit;
using System.Web.UI;

namespace RMIS.CustomControls
{
   public  class TextBoxAutoExtender:CompositeControl
    {

       const string viewStateServerMethod = "viewStateServerMethod";
       public string ServiceMethod
       {
           get
           {
               if (ViewState[viewStateServerMethod] == null)
               {
                   ViewState[viewStateServerMethod] = string.Empty;
               }

               return (string)ViewState[viewStateServerMethod];
           }
           set
           {
               ViewState[viewStateServerMethod] = value;
           }
       }

       public string SelectedValue
       {
           get
           {
               return hiddenfield.Value;
           }
       }

       const string viewStateContextKey = "viewStateContextKey";
       public string ContextKey
       {
           get
           {
               if (ViewState[viewStateContextKey] == null)
               {
                   ViewState[viewStateContextKey] = string.Empty;
               }

               return (string)ViewState[viewStateContextKey];
           }
           set
           {
               ViewState[viewStateContextKey] = value;
           }
       }


       protected TextBox txtBox;
       protected AutoCompleteExtender autoExtender;
       protected HiddenField hiddenfield;
       protected override void CreateChildControls()
       {
           base.CreateChildControls();
           txtBox = new TextBox();
           txtBox.ID = "txtBox" + this.ID ;
           this.Controls.Add(txtBox);        

           hiddenfield = new HiddenField();
           hiddenfield.ID = "hiddenfield" + this.ID;
           this.Controls.Add(hiddenfield);

           autoExtender = new AutoCompleteExtender();
           autoExtender.ID = "autoExtender" + this.ID;
           autoExtender.ServiceMethod = ServiceMethod;
           autoExtender.ServicePath = "AutoCompleteService.asmx";
           autoExtender.MinimumPrefixLength = 1;
           autoExtender.CompletionInterval = 100;
           autoExtender.EnableCaching = false;
           autoExtender.CompletionSetCount = 20;
           autoExtender.TargetControlID = txtBox.ID;
           autoExtender.FirstRowSelected = false;
           autoExtender.OnClientItemSelected = "GetCode" + ServiceMethod;
           autoExtender.ContextKey = ContextKey;
           autoExtender.UseContextKey = true;
           this.Controls.Add(autoExtender);

           StringBuilder buildScript = new StringBuilder();
           buildScript.AppendFormat("function {0}(source, eventArgs)", "GetCode" + ServiceMethod);
           buildScript.Append("{");
           buildScript.Append("document.getElementById('" + hiddenfield.ClientID  + "').value = eventArgs.get_value();");
           buildScript.Append("}");
           ScriptManager.RegisterStartupScript(this, this.GetType(), "GetCode" + ServiceMethod, buildScript.ToString(), true);
           Page.ClientScript.RegisterStartupScript(Page.GetType(), "GetCode" + ServiceMethod, buildScript.ToString(), true);



       }

      
    }
}
