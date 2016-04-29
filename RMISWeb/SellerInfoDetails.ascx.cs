using System;
using RMIS.Binder.BackEnd;
using RMIS.Domain.Business;

public partial class SellerInfoDetails : BaseUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsControlPostBack)
        {
            IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
            ddlSellerType.DataSource = imp.GetMasterSellerTypeEntities();
            ddlSellerType.DataTextField = "SellerType";
            ddlSellerType.DataValueField = "ID";
            ddlSellerType.DataBind();
        }
    }
}