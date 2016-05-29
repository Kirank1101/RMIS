using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RMIS.Domain.Business;
using RMIS.Binder.BackEnd;
using System.Configuration;
using System.Data.SqlClient;
using AllInOne.Common.Library.Util;
using System.Data;


using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class Membership_AddCustomer : System.Web.UI.Page
{

    ISessionProvider imp = BinderSingleton.Instance.GetInstance<ISessionProvider>();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            bindCustomers();
            // Bind the users and roles
            BindUsersToUserList();
            BindRolesToList();

            DisplayRolesInGrid();
        }

        CreateAccountResults.Text = ActionStatus.Text = string.Empty;
    }

    void bindCustomers()
    {
        ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
        ddlCustomeList.DataSource = imp.GetAllCustomerInfoEntities();
        ddlCustomeList.DataBind();
    }

    protected void btnCreateCustomer_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(txtUsername.Text))
        {
            //string custId = Guid.NewGuid().ToString();
            ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
            imp.SaveCustomerInformation(txtUsername.Text.Trim(), txtOrganization.Text, txtUsername.Text.Trim());
            ddlCustomeList.Items.Clear();
            bindCustomers();
        }
        else
        {
            CreateAccountResults.Text = "Please enter customer name";
        }
    }


    protected void btnSetCustomer_Click(object sender, EventArgs e)
    {
        if (ddlCustomeList.SelectedIndex > 0)
        {
            imp.SetCurrentCustomerId(ddlCustomeList.SelectedValue);
        }
    }

    protected void CreateAccountButton_Click(object sender, EventArgs e)
    {

        if (ddlCustomeList.SelectedIndex > 0)
        {

            MembershipCreateStatus createStatus;

            MembershipUser newUser =
                 Membership.CreateUser(ddlCustomeList.SelectedItem.Text + CommonUtil.splilChar + Username.Text, Password.Text,
                                       "k@k.com", "Yes, I am here ?",
                                       "Yes, I am here ?", true, null,
                                       out createStatus);

            Roles.AddUsersToRoles(new string[] { ddlCustomeList.SelectedItem.Text + CommonUtil.splilChar + Username.Text }, new string[] { ddlRoles.SelectedItem.Text });

            switch (createStatus)
            {
                case MembershipCreateStatus.Success:
                    CreateAccountResults.Text = "The user account was successfully created!";
                    break;

                case MembershipCreateStatus.DuplicateUserName:
                    CreateAccountResults.Text = "There already exists a user with this username.";
                    break;

                case MembershipCreateStatus.DuplicateEmail:
                    CreateAccountResults.Text = "There already exists a user with this email address.";
                    break;

                case MembershipCreateStatus.InvalidEmail:
                    CreateAccountResults.Text = "There email address you provided in invalid.";
                    break;

                case MembershipCreateStatus.InvalidAnswer:
                    CreateAccountResults.Text = "There security answer was invalid.";
                    break;

                case MembershipCreateStatus.InvalidPassword:
                    CreateAccountResults.Text = "The password you provided is invalid. It must be seven characters long and have at least one non-alphanumeric character.";
                    break;

                default:
                    CreateAccountResults.Text = "There was an unknown error; the user account was NOT created.";
                    break;
            }

            gdUsers.DataSource = Roles.GetRolesForUser(ddlCustomeList.SelectedItem.Text + CommonUtil.splilChar + Username.Text);
            gdUsers.DataBind();
        }
        else
        {
            CreateAccountResults.Text = "Please select customer.";
        }
    }

    private void BindRolesToList()
    {
        // Get all of the roles
        string[] roles = Roles.GetAllRoles();
        ddlRoles.DataSource = roles;
        RoleList.DataSource = roles;
        RoleList.DataBind();
        ddlRoles.DataBind();
    }

    #region 'By User' Interface-Specific Methods
    private void BindUsersToUserList()
    {
        IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
        UserList.DataSource = imp.GetMenuInfoEnity();
        UserList.DataBind();
    }

    void bindMenuConfiguration()
    {
        ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
        gdAll.DataSource = imp.GetMenuConfigurationEntities(ddlCustomeList.SelectedValue);
        gdAll.DataBind();
    }



    #endregion
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        if (ddlCustomeList.SelectedIndex > 0)
        {
            ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
            imp.SaveMenuConfiguration(ddlCustomeList.SelectedValue, RoleList.SelectedValue, UserList.SelectedValue);
            bindMenuConfiguration();
        }
        else
        {
            ActionStatus.Text = "Please select customer.";
        }
    }
    protected void ddlCustomeList_SelectedIndexChanged(object sender, EventArgs e)
    {
        lblCustomer.Text = ddlCustomeList.SelectedItem.Text;
        bindMenuConfiguration();
    }



    private void DisplayRolesInGrid()
    {
        gdRoleList.DataSource = Roles.GetAllRoles();
        gdRoleList.DataBind();
    }

    protected void CreateRoleButton_Click(object sender, EventArgs e)
    {
        string newRoleName = RoleName.Text.Trim();

        if (!Roles.RoleExists(newRoleName))
        {
            // Create the role
            Roles.CreateRole(newRoleName);

            // Refresh the RoleList Grid
            DisplayRolesInGrid();
            BindRolesToList();
        }

        RoleName.Text = string.Empty;
    }

    protected void RoleList_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        // Get the RoleNameLabel
        Label RoleNameLabel = gdRoleList.Rows[e.RowIndex].FindControl("RoleNameLabel") as Label;

        // Delete the role
        Roles.DeleteRole(RoleNameLabel.Text, false);

        // Rebind the data to the RoleList grid
        DisplayRolesInGrid();
    }


}