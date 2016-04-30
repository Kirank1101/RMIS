using System;
using RMIS.Binder.BackEnd;
using RMIS.Domain.Business;
using RMIS.Domain.DataTranserClass;

public partial class PaddyPaymentDetails : BaseUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsControlPostBack)
        {
            ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
            ddlsellernames.DataSource = imp.GetPaddySellerInfo();
            ddlsellernames.DataTextField = "Name";
            ddlsellernames.DataValueField = "SellerID";
            ddlsellernames.DataBind();
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (ddlsellernames.SelectedIndex > 0 && !string.IsNullOrEmpty(txtamountpaid.Text.Trim()) && !string.IsNullOrEmpty(txtPaidDate.Text.Trim())
            && !string.IsNullOrEmpty(txtHandoverto.Text.Trim()) && !string.IsNullOrEmpty(txtNextpaymentdate.Text.Trim()))
        {
            ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
            imp.SavePaddyPaymentDetails(ddlsellernames.SelectedValue,Convert.ToDouble(txtamountpaid.Text.Trim()),Convert.ToDateTime(txtPaidDate.Text.Trim()),txtHandoverto.Text.Trim(),Convert.ToDateTime(txtNextpaymentdate.Text.Trim()));
            ClearAllInputFields();

        }
    }

    private void ClearAllInputFields()
    {
        ddlsellernames.SelectedIndex = 0;
        txtamountpaid.Text = string.Empty;
        txtPaidDate.Text = string.Empty;
        txtHandoverto.Text = string.Empty;
        txtNextpaymentdate.Text = string.Empty;
        throw new NotImplementedException();
    }
}