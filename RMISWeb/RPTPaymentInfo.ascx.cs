using System;
using RMIS.Binder.BackEnd;
using RMIS.Domain.Business;
using RMIS.Domain.DataTranserClass;

public partial class RPTPaymentInfo : BaseUserControl
{
    IMasterPaddyBusiness impb = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsControlPostBack)
        {
            base.Header = "Paddy Stock Information";
            ddlSellerType.DataSource = impb.GetMasterSellerTypeEntities();
            ddlSellerType.DataTextField = "SellerType";
            ddlSellerType.DataValueField = "ID";
            ddlSellerType.DataBind();



        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {


    }

    private void ClearAllInputFields()
    {
        ddlSellerType.SelectedIndex = 0;
        ddlsellernames.SelectedIndex = 0;
    }

    protected void ddlSellerType_SelectedIndexChanged(object sender, EventArgs e)
    {
        ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();

        ddlsellernames.DataSource = imp.GetAllSellerInfo(ddlSellerType.SelectedValue);
        ddlsellernames.DataTextField = "Name";
        ddlsellernames.DataValueField = "SellerID";
        ddlsellernames.DataBind();

    }
}