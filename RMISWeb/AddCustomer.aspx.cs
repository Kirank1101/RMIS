﻿using System;
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
            bindCustomers();
    }

    void bindCustomers()
    {
        ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
        ddlCustomeList.DataSource = imp.GetAllCustomerInfoEntities();
        ddlCustomeList.DataBind();
    }

    protected void btnCreateCustomer_Click(object sender, EventArgs e)
    {
        string custId = Guid.NewGuid().ToString();
        ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
        imp.SaveCustomerInformation(txtUsername.Text.Trim(), txtOrganization.Text, custId);        
        ddlCustomeList.Items.Clear();
        bindCustomers();
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

        

        MembershipCreateStatus createStatus;

        MembershipUser newUser =
             Membership.CreateUser( imp.GetCurrentCustomerId() + @"/" + Username.Text, Password.Text,
                                   "test@test.com", "What is your name",
                                   "Really Dont know", true,null,
                                   out createStatus);

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
    }
}