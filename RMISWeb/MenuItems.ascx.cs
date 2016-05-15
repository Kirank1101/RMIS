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
            IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
            List<MenuInfoEntity> listMenuInfoEntity = imp.GetMenuInfoEnity();
            if (listMenuInfoEntity.Count > 0)
            {
                List<MenuInfoEntity> listParentMenuInfoEntity = listMenuInfoEntity.FindAll(A => A.ParentMenuID == 0);
               
                if (listParentMenuInfoEntity != null)
                    foreach (MenuInfoEntity objMenuInfoEntity in listParentMenuInfoEntity)
                    {
                        LiteralControl control = new LiteralControl();
                        control.Text = string.Format(@"<ul class='nav side-menu'>
                 <li><a><i ></i>{0}<span class='fa fa-chevron-down'></span></a>
                    <ul class='nav child_menu'>", objMenuInfoEntity.Title);
                        phMenuItems.Controls.Add(control);
                        List<MenuInfoEntity> listChildMenuInfoEntity = listMenuInfoEntity.FindAll(A => A.ParentMenuID == objMenuInfoEntity.MenuID);
                        if (listChildMenuInfoEntity != null && listChildMenuInfoEntity.Count > 0)
                        {
                            List<MMenuItem> items = new List<MMenuItem>();
                            foreach (MenuInfoEntity objChildMenuInfoEntity in listChildMenuInfoEntity)
                            {
                                MMenuItem item = new MMenuItem();
                                item.Title = objChildMenuInfoEntity.Title;
                                item.MenuId = "AST";
                                item.Url = objChildMenuInfoEntity.URL;
                                items.Add(item);

                            }
                            CreateHTMLTable(items, objMenuInfoEntity.Title);
                        }

                        control = new LiteralControl();
                        control.Text = @" </ul>
                      </li>
                    </ul>";
                        phMenuItems.Controls.Add(control);

                    }

            }

            string script = @" function changeActiveClass(id) {    
                     
             document.getElementById(id).className = 'active';         }";
            ScriptManager.RegisterStartupScript(this, GetType(), "changeActiveClass", script, true);
        }
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