using System;
using RMIS.Binder.BackEnd;
using RMIS.Domain.Business;
using RMIS.Domain.DataTranserClass;

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
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (ddlSellerType.SelectedIndex > 0 && !string.IsNullOrEmpty(txtSellerName.Text.Trim()) && !string.IsNullOrEmpty(txtCity.Text.Trim()) && !string.IsNullOrEmpty(txtDistrict.Text.Trim()) && !string.IsNullOrEmpty(txtState.Text.Trim()) && !string.IsNullOrEmpty(txtContactNo.Text.Trim()))
        {
            ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
            imp.SaveSellerInfo(ddlSellerType.SelectedValue,txtSellerName.Text.Trim(),txtStreet1.Text.Trim(),txtStreet2.Text.Trim(),txtTown.Text.Trim(),txtCity.Text.Trim(),txtDistrict.Text.Trim(),txtState.Text.Trim(),txtPincode.Text.Trim(),txtContactNo.Text.Trim(),txtMobileNo.Text.Trim(),txtPhoneNo.Text.Trim());
            ClearAllInputFields();

        }
    }

    private void ClearAllInputFields()
    {
        ddlSellerType.SelectedIndex = 0;
        txtSellerName.Text=string.Empty;
        txtStreet1.Text=string.Empty;
        txtStreet2.Text=string.Empty;
        txtTown.Text=string.Empty;
        txtCity.Text=string.Empty;
        txtDistrict.Text=string.Empty;
        txtState.Text=string.Empty;
        txtPincode.Text=string.Empty;
        txtContactNo.Text=string.Empty;
        txtMobileNo.Text=string.Empty;
        txtPhoneNo.Text = string.Empty;
    }
}