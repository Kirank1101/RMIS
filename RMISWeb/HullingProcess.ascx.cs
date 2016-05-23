using System;
using RMIS.Binder.BackEnd;
using RMIS.Domain.Business;
using RMIS.Domain.DataTranserClass;

public partial class HullingProcess : BaseUserControl
{
    IMasterPaddyBusiness impb = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsControlPostBack)
        {
            base.Header = "Paddy Stock Information";
            ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
            
            ddlPaddyType.DataSource = impb.GetMPaddyTypeEntities();
            ddlPaddyType.DataTextField = "PaddyType";
            ddlPaddyType.DataValueField = "Id";
            ddlPaddyType.DataBind();

            ddlUnitsType.DataSource = impb.GetMUnitsTypeEntities();
            ddlUnitsType.DataTextField = "UnitsType";
            ddlUnitsType.DataValueField = "Id";
            ddlUnitsType.DataBind();
        }
    }    
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        ResultDTO resultDto = BinderSingleton.Instance.GetInstance<IValidateTransactionBusiness>().ValidateHullingProcess(ddlPaddyType.SelectedIndex, ddlUnitsType.SelectedIndex, txtTotalBags.Text, txtHullingProcessBy.Text, txtHullingProcessDate.Text);
        if (resultDto.IsSuccess)
        {
            ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
            resultDto = imp.SaveHullingProcessInfo(ddlPaddyType.SelectedValue, ddlUnitsType.SelectedValue, Convert.ToInt16(txtTotalBags.Text.Trim()), txtHullingProcessBy.Text.Trim(),Convert.ToDateTime(txtHullingProcessDate.Text.Trim()), 'P');            
            
            SetMessage(resultDto);
            if (resultDto.IsSuccess)
                ClearAllInputFields();
        }
        else
        {
            SetMessage(resultDto);
        }

    }
    protected void btnHullingProcess_Click(object sender, EventArgs e)
    { }
    protected void btnCalculate_Click(object sender, EventArgs e)
    { }
    protected void btnSaveClose_Click(object sender, EventArgs e)
    {
        ResultDTO resultDto = BinderSingleton.Instance.GetInstance<IValidateTransactionBusiness>().ValidateHullingProcessTrans(ddlpaddypaddytype.SelectedIndex, ddlRiceType.SelectedIndex,ddlBRType.SelectedIndex, ddlpaddyunittype.SelectedIndex,ddlriceUnittype.SelectedIndex,ddlBRUnitsType.SelectedIndex,ddlDustUnitsType.SelectedIndex, txtpadyTotalBags.Text,txtricetotalbags.Text,txtBRTotalBags.Text,txtDustTotalBags.Text,txtPaddyPriceperbag.Text,txtricepriceperbag.Text,txtBRPriceperbag.Text,txtDustPriceperbag.Text);
        if (resultDto.IsSuccess)
        {
            
            ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
            //Save Paddy details
            resultDto = imp.SaveHullingProcessTransInfo("","Paddy", ddlpaddypaddytype.SelectedValue,null,null,'N',ddlpaddyunittype.SelectedValue, Convert.ToInt16(txtpadyTotalBags.Text.Trim()), Convert.ToDouble(txtPaddyPriceperbag.Text.Trim()));
            //Save Rice details
            resultDto = imp.SaveHullingProcessTransInfo("", "Rice", null,ddlRiceType.SelectedValue, null, 'N', ddlriceUnittype.SelectedValue, Convert.ToInt16(txtricetotalbags.Text.Trim()), Convert.ToDouble(txtricepriceperbag.Text.Trim()));
            //Save BrokenRiceDetails
            resultDto = imp.SaveHullingProcessTransInfo("", "BrokenRice", null, null, ddlBRType.SelectedValue, 'N', ddlBRUnitsType.SelectedValue, Convert.ToInt16(txtBRTotalBags.Text.Trim()), Convert.ToDouble(txtBRPriceperbag.Text.Trim()));
            //Save Dust Details
            resultDto = imp.SaveHullingProcessTransInfo("", "Dust", null, null, null, 'Y', ddlDustUnitsType.SelectedValue, Convert.ToInt16(txtDustTotalBags.Text.Trim()), Convert.ToDouble(txtDustPriceperbag.Text.Trim()));
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
        ddlPaddyType.SelectedIndex = 0;
        ddlUnitsType.SelectedIndex = 0;
        txtTotalBags.Text = string.Empty;
        txtHullingProcessDate.Text = string.Empty;
        txtHullingProcessBy.Text = string.Empty;
    }

}