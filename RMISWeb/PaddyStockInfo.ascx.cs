using System;
using RMIS.Binder.BackEnd;
using RMIS.Domain.Business;
using RMIS.Domain.DataTranserClass;

public partial class PaddyStockInfo : BaseUserControl
{
    IMasterPaddyBusiness impb = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
            
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsControlPostBack)
        {
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
        if (ddlGodownname.SelectedIndex > 0)
        {
            ddlLotDetails.DataSource = impb.GetLotDetailsEntities(ddlGodownname.SelectedValue);
            ddlLotDetails.DataTextField = "LotDetails";
            ddlLotDetails.DataValueField = "Id";
            ddlLotDetails.DataBind();
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (ddlLotDetails.SelectedIndex > 0 && ddlGodownname.SelectedIndex > 0 && ddlPaddyType.SelectedIndex > 0 && ddlsellernames.SelectedIndex > 0 
            && !string.IsNullOrEmpty(txtVehicalNo.Text.Trim()) && !string.IsNullOrEmpty(txtTotalBags.Text.Trim()) 
            && !string.IsNullOrEmpty(txtQweight.Text.Trim()) && !string.IsNullOrEmpty(txtQprice.Text.Trim()) && !string.IsNullOrEmpty(txtPruchaseDate.Text.Trim()))
        {
            ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
            imp.SavePaddyStockInfo(ddlsellernames.SelectedValue, ddlPaddyType.SelectedValue, ddlGodownname.SelectedValue, ddlLotDetails.SelectedValue, txtVehicalNo.Text.Trim(),Convert.ToInt16( txtTotalBags.Text.Trim()),Convert.ToInt16( txtQweight.Text.Trim()),Convert.ToInt16( txtQprice.Text.Trim()),Convert.ToDateTime( txtPruchaseDate.Text.Trim()));
            ClearAllInputFields();

        }
    }

    private void ClearAllInputFields()
    {
        ddlPaddyType.SelectedIndex = 0;
        ddlsellernames.SelectedIndex = 0;
        ddlGodownname.SelectedIndex = 0;
        ddlLotDetails.SelectedIndex = 0;
        txtVehicalNo.Text = string.Empty;
        txtTotalBags.Text = string.Empty;
        txtQweight.Text = string.Empty;
        txtQprice.Text = string.Empty;
        txtPruchaseDate.Text = string.Empty;
    }

}