using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using RMIS.Mediator.BackEnd;
using RMIS.Domain.RiceMill;
using RMIS.Domain;
using RMIS.Binder.BackEnd;
using RMIS.Domain.Mediator;
using RMIS.Domain.Business;
using RMIS.Domain.DataTranserClass;
using System.Collections.Generic;

public partial class MenuItems : BaseUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsControlPostBack)
        {
            List<MMenuItem> items = new List<MMenuItem>();
            MMenuItem item = new MMenuItem();
            item.Title = "Add Seller Types";
            item.MenuId = "AST";
            item.Url = "AddSellerType.ascx";
            items.Add(item);

            item = new MMenuItem();
            item.Title = "Add Paddy Types";
            item.MenuId = "APT";
            item.Url = "AddPaddyType.ascx";
            items.Add(item);

            CreateHTMLTable(items, "Master Config");

        }
    }

    private void CreateHTMLTable(List<MMenuItem> menuItems, string innerMenuText)
    {
        var li = new HtmlGenericControl("li");
        li.ID = "ids";
        li.InnerHtml = innerMenuText;
        
        foreach (MMenuItem menuItem in menuItems)
        {           

            HtmlGenericControl anchor = new HtmlGenericControl("a");
            anchor.Attributes.Add("href", "#");
            anchor.Attributes.Add("onclick", string.Format("changeControlSample('{0}')", menuItem.Url));
            anchor.InnerText = menuItem.Title;
            li.Controls.Add(anchor);

            phMenuItems.Controls.Add(li);
        }
    }

}