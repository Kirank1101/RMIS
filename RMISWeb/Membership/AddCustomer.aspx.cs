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

public partial class Membership_AddCustomer : System.Web.UI.Page
{
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
            ISessionProvider imp = BinderSingleton.Instance.GetInstance<ISessionProvider>();
            imp.SetCurrentCustomerId(ddlCustomeList.SelectedValue);
        }
    }
}