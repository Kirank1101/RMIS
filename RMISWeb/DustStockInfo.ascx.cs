using System;
using RMIS.Binder.BackEnd;
using RMIS.Domain.Business;
using RMIS.Domain.DataTranserClass;
using AllInOne.Common.Library.Util;
public partial class DustStockInfo : BaseUserControl
{
    IMasterPaddyBusiness impb = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsControlPostBack)
        {
            base.Header = "Dust Stock Information";
            ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
            
            ddlUnitsType.DataSource = impb.GetMUnitsTypeEntities();
            ddlUnitsType.DataTextField = "UnitsType";
            ddlUnitsType.DataValueField = "Id";
            ddlUnitsType.DataBind();
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        ResultDTO resultDto = BinderSingleton.Instance.GetInstance<IValidateTransactionBusiness>().ValidateDustStockDetails(ddlUnitsType.SelectedIndex, txtTotalBags.Text);
        if (resultDto.IsSuccess)
        {
            ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
            resultDto = imp.SaveDustStockInfo(txtTotalBags.Text.ConvertToInt(), ddlUnitsType.SelectedValue);
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
        ddlUnitsType.SelectedIndex = 0;
        txtTotalBags.Text = string.Empty;
    }

}