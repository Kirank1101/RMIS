using System;
using RMIS.Binder.BackEnd;
using RMIS.Domain.Business;
using RMIS.Domain.DataTranserClass;

public partial class DustSellingInfo : BaseUserControl
{
    IMasterPaddyBusiness impb = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsControlPostBack)
        {
            base.Header = "Paddy Stock Information";
            ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
            ddlsellernames.DataSource = imp.GetPaddySellerInfo();
            ddlsellernames.DataTextField = "Name";
            ddlsellernames.DataValueField = "SellerID";
            ddlsellernames.DataBind();

            ddlUnitsType.DataSource = impb.GetMUnitsTypeEntities();
            ddlUnitsType.DataTextField = "UnitsType";
            ddlUnitsType.DataValueField = "Id";
            ddlUnitsType.DataBind();
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        ResultDTO resultDto = BinderSingleton.Instance.GetInstance<IValidateTransactionBusiness>().ValidateDustSellingDetails(ddlsellernames.SelectedIndex, ddlUnitsType.SelectedIndex, txtVehicalNo.Text, txtTotalBags.Text, txtQweight.Text, txtQprice.Text, txtSellingDate.Text);
        if (resultDto.IsSuccess)
        {
            ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
            resultDto = imp.SaveDustSellingInfo(ddlsellernames.SelectedValue,txtVehicalNo.Text.Trim(), txtDriverName.Text.Trim(), Convert.ToInt16(txtTotalBags.Text.Trim()), Convert.ToInt16(txtQweight.Text.Trim()),ddlUnitsType.SelectedValue, Convert.ToInt16(txtQprice.Text.Trim()), Convert.ToDateTime(txtSellingDate.Text.Trim()));
            SetMessage(resultDto);
            if (resultDto.IsSuccess)
                ClearAllInputFields();
        }
        else
        {
            SetMessage(resultDto);
        }

    }

    private void ClearAllInputFields()
    {
        ddlsellernames.SelectedIndex = 0;
        ddlUnitsType.SelectedIndex = 0;
        txtVehicalNo.Text = string.Empty;
        txtTotalBags.Text = string.Empty;
        txtQweight.Text = string.Empty;
        txtQprice.Text = string.Empty;
        txtSellingDate.Text = string.Empty;
    }

}