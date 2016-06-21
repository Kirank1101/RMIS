using System;
using RMIS.Binder.BackEnd;
using RMIS.Domain.Business;
using RMIS.Domain.DataTranserClass;

public partial class RPTPaddyStockInfo : BaseUserControl
{
    IMasterPaddyBusiness impb = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsControlPostBack)
        {
            Header = "Paddy Stock Information";
            ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
            ddlsellernames.DataSource = imp.GetPaddySellerInfo();
            ddlsellernames.DataTextField = "Name";
            ddlsellernames.DataValueField = "SellerID";
            ddlsellernames.DataBind();

            ddlPaddyType.DataSource = impb.GetMPaddyTypeEntities();
            ddlPaddyType.DataTextField = "PaddyType";
            ddlPaddyType.DataValueField = "Id";
            ddlPaddyType.DataBind();

            ddlGodownname.DataSource = impb.GetMGodownTypeEntities();
            ddlGodownname.DataTextField = "GodownType";
            ddlGodownname.DataValueField = "Id";
            ddlGodownname.DataBind();
        }
    }
    protected void ddlGodownSelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlGodownname.SelectedIndex > -1)
        {
            ddlLotDetails.DataSource = impb.GetLotDetailsEntities(ddlGodownname.SelectedValue);
            ddlLotDetails.DataTextField = "LotDetails";
            ddlLotDetails.DataValueField = "Id";
            ddlLotDetails.DataBind();
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        

    }

    private void ClearAllInputFields()
    {
        ddlPaddyType.SelectedIndex = 0;
        ddlsellernames.SelectedIndex = 0;
        ddlGodownname.SelectedIndex = 0;
        ddlLotDetails.SelectedIndex = 0;        
    }

}