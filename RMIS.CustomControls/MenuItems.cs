using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;
using AjaxControlToolkit;
using System.Web.UI;
using RMIS.Domain.Business;
using RMIS.Binder.BackEnd;
using RMIS.Domain.RiceMill;
using RMIS.Domain.DataTranserClass;
using System.Web.UI.HtmlControls;

namespace RMIS.CustomControls
{
    public class MenuItems : CompositeControl
    {

        protected UpdatePanel _upMain;
        public UpdatePanel updMain
        {
            set
            {
                _upMain = value;
            }

        }

        protected PlaceHolder phMenuItems;
        protected override void CreateChildControls()
        {
            base.CreateChildControls();
            phMenuItems = new PlaceHolder();
            phMenuItems.ID = "phMenuItems" + this.ID;
            this.Controls.Add(phMenuItems);
            AddMenuItems();
        }


        void AddMenuItems()
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
                                item.MenuId = Convert.ToString(objChildMenuInfoEntity.MenuID);
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
        }

        private void CreateHTMLTable(List<MMenuItem> menuItems, string innerMenuText)
        {

            foreach (MMenuItem menuItem in menuItems)
            {
                var li = new HtmlGenericControl("li");
                li.ID = "Menuids" + menuItem.MenuId;
                LinkButton lnkInfo = new LinkButton();
                lnkInfo.ID = "lnkInfo" + menuItem.MenuId;
                lnkInfo.CommandArgument = menuItem.Url;
                lnkInfo.Text = menuItem.Title;
                lnkInfo.Click += new EventHandler(lnkInfo_Click);
                li.Controls.Add(lnkInfo);

                AsyncPostBackTrigger trig2 = new AsyncPostBackTrigger();
                trig2.ControlID =this.UniqueID +"$"+ lnkInfo.UniqueID;
                _upMain.Triggers.Add(trig2);
                phMenuItems.Controls.Add(li);
            }
        }

        public event EventHandler lnkEvent;
        void lnkInfo_Click(object sender, EventArgs e)
        {
            if (lnkEvent != null)
                lnkEvent(sender, e);

        }
    }
}
