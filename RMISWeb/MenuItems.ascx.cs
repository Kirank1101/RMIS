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

            LiteralControl control = new LiteralControl();
            control.Text = @"<ul class='nav side-menu'>
    <li><a><i class='fa fa-sitemap'></i>Master Config<span class='fa fa-chevron-down'></span></a>
        <ul class='nav child_menu'>";
            phMenuItems.Controls.Add(control);

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

            item = new MMenuItem();
            item.Title = "Add Unit Types";
            item.MenuId = "AUT";
            item.Url = "AddUnitsType.ascx";
            items.Add(item);

            item = new MMenuItem();
            item.Title = "Add Bag Types";
            item.MenuId = "ABT";
            item.Url = "AddBagType.ascx";
            items.Add(item);

            item = new MMenuItem();
            item.Title = "Add Godown Types";
            item.MenuId = "AGT";
            item.Url = "AddGodownDetails.ascx";
            items.Add(item);

            item = new MMenuItem();
            item.Title = "Add Lot Types";
            item.MenuId = "ALT";
            item.Url = "AddLotDetails.ascx";
            items.Add(item);

            item = new MMenuItem();
            item.Title = "Add Rice Types";
            item.MenuId = "ART";
            item.Url = "AddRiceType.ascx";
            items.Add(item);

            CreateHTMLTable(items, "Master Config");

            control = new LiteralControl();
            control.Text = @" </ul>
    </li>
</ul>";
            phMenuItems.Controls.Add(control);


            control = new LiteralControl();
            control.Text = @"<ul class='nav side-menu'>
    <li><a><i class='fa fa-sitemap'></i>Paddy process<span class='fa fa-chevron-down'></span></a>
        <ul class='nav child_menu'>";
            phMenuItems.Controls.Add(control);

            items = new List<MMenuItem>();

            item = new MMenuItem();
            item.Title = "Add Seller details";
            item.MenuId = "SEID";
            item.Url = "SellerInfoDetails.ascx";
            items.Add(item);

            item = new MMenuItem();
            item.Title = "Add Paddy details";
            item.MenuId = "APSD";
            item.Url = "PaddyStockInfo.ascx";
            items.Add(item);

            CreateHTMLTable(items, "Transac Config");

            control = new LiteralControl();
            control.Text = @" </ul>
    </li>
 </ul>";
            phMenuItems.Controls.Add(control);

        }

        string script = @" function changeActiveClass(id) {    
                     
             document.getElementById(id).className = 'active';         }";
        ScriptManager.RegisterStartupScript(this, GetType(), "changeActiveClass", script, true);
    }

    private void CreateHTMLTable(List<MMenuItem> menuItems, string innerMenuText)
    {

        int count = 0;
        foreach (MMenuItem menuItem in menuItems)
        {
            var li = new HtmlGenericControl("li");
            li.ID = "Menuids" + count.ToString();
            //li.Attributes.Add("class", "active");
            HtmlGenericControl anchor = new HtmlGenericControl("a");
            anchor.Attributes.Add("href", "#");
            anchor.Attributes.Add("onclick", string.Format("changeControlSample('{0}'); changeActiveClass('{1}');", menuItem.Url, "MenuItems1_" + li.ClientID));
            anchor.InnerText = menuItem.Title;
            li.Controls.Add(anchor);
            count++;
            phMenuItems.Controls.Add(li);
        }
    }

}