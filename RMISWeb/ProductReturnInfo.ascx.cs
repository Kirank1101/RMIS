using System;
using RMIS.Binder.BackEnd;
using RMIS.Domain.Business;
using RMIS.Domain.DataTranserClass;

public partial class ProductReturnInfo : BaseUserControl
{
    IMasterPaddyBusiness impb = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsControlPostBack)
        {
            base.Header = "Paddy Stock Information";

            ddlProductTypeID.DataSource = impb.GetMProductSellingTypeEntities();
            ddlProductTypeID.DataTextField = "ProductSellingType";
            ddlProductTypeID.DataValueField = "SellerID";
            ddlProductTypeID.DataBind();

            ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
            ddlsellernames.DataSource = imp.GetPaddySellerInfo();
            ddlsellernames.DataTextField = "Name";
            ddlsellernames.DataValueField = "SellerID";
            ddlsellernames.DataBind();

        }
    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {

    }

    private void ClearAllInputFields()
    {
        ddlsellernames.SelectedIndex = 0;
        ddlProductTypeID.SelectedIndex = 0;
        txtorderno.Text = string.Empty;
    }

}