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
using RMIS.Domain.Business;
using RMIS.Binder.BackEnd;

public partial class Roles_SetRolesOnMenu : BasePage
{

    ISessionProvider impSession = BinderSingleton.Instance.GetInstance<ISessionProvider>();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            // Bind the users and roles
            BindUsersToUserList();
            BindRolesToList();
            lblCustomer.Text = impSession.GetApplicationName();
        }
    }

    private void BindRolesToList()
    {
        // Get all of the roles
        string[] roles = Roles.GetAllRoles();

        RoleList.DataSource = roles;
        RoleList.DataBind();
    }

    #region 'By User' Interface-Specific Methods
    private void BindUsersToUserList()
    {
        IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
        UserList.DataSource = imp.GetMenuInfoEnity();
        UserList.DataBind();
    }


    #endregion
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
        imp.SaveMenuConfiguration(impSession.GetCurrentCustomerId(), RoleList.SelectedValue, UserList.SelectedValue);
        imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
        gdAll.DataSource = imp.GetMenuConfigurationEntities(impSession.GetCurrentCustomerId());
        gdAll.DataBind();
    }

}