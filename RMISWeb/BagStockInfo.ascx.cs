using System;
using RMIS.Binder.BackEnd;
using RMIS.Domain.Business;
using RMIS.Domain.DataTranserClass;
using AllInOne.Common.Library.Util;
public partial class BagStockInfo : BaseUserControl
{
            
    protected void Page_Load(object sender, EventArgs e)
    {
        IMasterPaddyBusiness impb = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();

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

            IMasterPaddyBusiness impb2 = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
            ddlUnitsType.DataSource = impb2.GetMUnitsTypeEntities();
            ddlUnitsType.DataTextField = "UnitsType";
            ddlUnitsType.DataValueField = "Id";
            ddlUnitsType.DataBind();

            ddlRiceBrand.DataSource = impb.GetRiceBrandEntities();
            ddlRiceBrand.DataTextField = "RiceBrand";
            ddlRiceBrand.DataValueField = "Id";
            ddlRiceBrand.DataBind();

            
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(txtDriverName.Text.Trim()) && ddlBagType.SelectedIndex > 0 && ddlsellernames.SelectedIndex > 0 
            && !string.IsNullOrEmpty(txtVehicalNo.Text.Trim()) && !string.IsNullOrEmpty(txtTotalBags.Text.Trim()) 
            && !string.IsNullOrEmpty(txtpricePerBag.Text.Trim()) && !string.IsNullOrEmpty(txtPruchaseDate.Text.Trim()))
        {
            ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
            imp.SaveBagStockInfo(ddlsellernames.SelectedValue, ddlBagType.SelectedValue, txtVehicalNo.Text.Trim(), txtDriverName.Text.Trim(), txtTotalBags.Text.ConvertToInt(), txtpricePerBag.Text.ConvertToDouble(), Convert.ToDateTime(txtPruchaseDate.Text.Trim()), ddlRiceBrand.SelectedValue, ddlUnitsType.SelectedValue);
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