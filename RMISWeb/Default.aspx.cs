using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using RMIS.Domain.Business;
using RMIS.Binder.BackEnd;
using RMIS.Domain.RiceMill;
using RMIS.Domain.DataTranserClass;
using System.Web.UI.HtmlControls;
using System.Web.Services;
using System.IO;

public partial class MasterDataSettings : ApplicationBasePage
{

    protected override void OnInit(EventArgs e)
    {
        base.OnInit(e);
        AddMenuItems();
    }

    [WebMethod]
    public static string Result(string controlName)
    {
        return RenderControl(controlName);
    }

    public static string RenderControl(string controlName)
    {
        Page page = new Page();
        UserControl userControl = (UserControl)page.LoadControl(controlName);
        userControl.EnableViewState = false;
        HtmlForm form = new HtmlForm();
        form.Controls.Add(userControl);
        page.Controls.Add(form);

        StringWriter textWriter = new StringWriter();
        HttpContext.Current.Server.Execute(page, textWriter, false);
        return textWriter.ToString();
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
            trig2.ControlID = lnkInfo.UniqueID;
            upMain.Triggers.Add(trig2);
            phMenuItems.Controls.Add(li);
        }
    }



    protected void lnkInfo_Click(object sender, EventArgs e)
    {
        LinkButton btnLinkButton = sender as LinkButton;
        LastLoadedControl = btnLinkButton.CommandArgument;
        LoadUserControl();
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        LoadUserControl();

    }

    public override void LoadUserControl()
    {
        string controlPath = LastLoadedControl;
        if (!string.IsNullOrEmpty(controlPath))
        {
            plHolderMain.Controls.Clear();
            UserControl uc = (UserControl)LoadControl(controlPath);
            uc.ID = controlPath.Replace(usercontrolExtension, string.Empty) + "1";
            plHolderMain.Controls.Add(uc);
        }
    }

    protected void LoginStatus1_LoggingOut(object sender, LoginCancelEventArgs e)
    {
        Session.Abandon();
        FormsAuthentication.SignOut();
        Response.Redirect("LogOn.aspx");
    }


    protected void lnkBtnsite_title_Click(object sender, EventArgs e)
    {

    }
}