using System;
using RMIS.Binder.BackEnd;
using RMIS.Domain.Business;
using RMIS.Domain.DataTranserClass;

public partial class BagStockInfo : BaseUserControl
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

            ddlBagType.DataSource = impb.GetMBagTypeEntities();
            ddlBagType.DataTextField = "BagType";
            ddlBagType.DataValueField = "Id";
            ddlBagType.DataBind();

            
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(txtDriverName.Text.Trim()) && ddlBagType.SelectedIndex > 0 && ddlsellernames.SelectedIndex > 0 
            && !string.IsNullOrEmpty(txtVehicalNo.Text.Trim()) && !string.IsNullOrEmpty(txtTotalBags.Text.Trim()) 
            && !string.IsNullOrEmpty(txtpricePerBag.Text.Trim()) && !string.IsNullOrEmpty(txtPruchaseDate.Text.Trim()))
        {
            ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
            imp.SaveBagStockInfo(ddlsellernames.SelectedValue, ddlBagType.SelectedValue, txtVehicalNo.Text.Trim(), txtDriverName.Text.Trim(), Convert.ToInt16(txtTotalBags.Text.Trim()), Convert.ToDecimal(txtpricePerBag.Text.Trim()), Convert.ToDateTime(txtPruchaseDate.Text.Trim()));
            ClearAllInputFields();

        }
    }

    private void ClearAllInputFields()
    {
        ddlBagType.SelectedIndex = 0;
        ddlsellernames.SelectedIndex = 0;
        txtVehicalNo.Text = string.Empty;
        txtDriverName.Text = string.Empty;
        txtTotalBags.Text = string.Empty;
        txtpricePerBag.Text = string.Empty;
        txtPruchaseDate.Text = string.Empty;
    }

}