using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RMIS.Domain.Business;
using RMIS.Binder.BackEnd;

public partial class Membership_AddCustomer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnCreateCustomer_Click(object sender, EventArgs e)
    {
        ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
         imp.SaveCustomerInformation(txtUsername.Text.Trim(),txtOrganization.Text );
    }
}