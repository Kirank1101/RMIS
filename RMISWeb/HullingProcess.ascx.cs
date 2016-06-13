using System;
using RMIS.Binder.BackEnd;
using RMIS.Domain.Business;
using RMIS.Domain.DataTranserClass;
using System.Collections.Generic;
using AllInOne.Common.Library.Util;

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

            IMasterPaddyBusiness impb1 = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
            ddlGodownName.DataSource = impb1.GetMGodownTypeEntities();
            ddlGodownName.DataTextField = "GodownType";
            ddlGodownName.DataValueField = "Id";
            ddlGodownName.DataBind();

        }
    }
    protected void ddlGodownSelectedIndexChanged(object sender, EventArgs e)
    {
        IMasterPaddyBusiness impb = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();

        if (ddlGodownName.SelectedIndex > -1)
        {
            ddlLotDetails.Items.Clear();
            ddlLotDetails.Items.Insert(0, "[Select]");
            ddlLotDetails.DataSource = impb.GetLotDetailsEntities(ddlGodownName.SelectedValue);
            ddlLotDetails.DataTextField = "LotDetails";
            ddlLotDetails.DataValueField = "Id";
            ddlLotDetails.DataBind();
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        ResultDTO resultDto = BinderSingleton.Instance.GetInstance<IValidateTransactionBusiness>().ValidateHullingProcess(ddlPaddyType.SelectedIndex, ddlUnitsType.SelectedIndex, txtTotalBags.Text, txtHullingProcessBy.Text, txtHullingProcessDate.Text);
        if (resultDto.IsSuccess)
        {
            ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
            resultDto = imp.SaveHullingProcessInfo(ddlPaddyType.SelectedValue, ddlUnitsType.SelectedValue, Convert.ToInt16(txtTotalBags.Text.Trim()), txtHullingProcessBy.Text.Trim(), Convert.ToDateTime(txtHullingProcessDate.Text.Trim()), 'P', ddlGodownName.SelectedValue, Convert.ToDouble(txtpaddyprice.Text.Trim()), ddlLotDetails.SelectedValue);

            SetMessage(resultDto);
            if (resultDto.IsSuccess)
                ClearAllInputFields();
        }
        else
        {
            SetMessage(resultDto);
        }
    }
    string viewstateBrokenRiceStockDetail = "viewstateBrokenRiceStockDetail";
    public List<BrokenRiceStockDetailsDTO> VststateBrokenRiceStockDetail
    {
        get
        {
            if (ViewState[viewstateBrokenRiceStockDetail] == null)
                ViewState[viewstateBrokenRiceStockDetail] = new List<BrokenRiceStockDetailsDTO>();
            return (List<BrokenRiceStockDetailsDTO>)ViewState[viewstateBrokenRiceStockDetail];
        }
        set
        {
            ViewState[viewstateBrokenRiceStockDetail] = value;
        }
    }
    protected void btnaddBrokenRice_Click(object sender, EventArgs e)
    {
        List<BrokenRiceStockDetailsDTO> lstBrokenRiceStockDetail = VststateBrokenRiceStockDetail;
        BrokenRiceStockDetailsDTO BrokenRiceStockDetailEntity = new BrokenRiceStockDetailsDTO();
        BrokenRiceStockDetailEntity.BrokenRiceTypeID = ddlBRType.SelectedValue;
        BrokenRiceStockDetailEntity.UnitsTypeID = ddlBRUnitsType.SelectedValue;
        BrokenRiceStockDetailEntity.BrokenRiceType = Convert.ToString(ddlBRType.SelectedItem);
        BrokenRiceStockDetailEntity.UnitsType = Convert.ToString(ddlBRUnitsType.SelectedItem);
        BrokenRiceStockDetailEntity.TotalBags = txtBRTotalBags.Text.ConvertToInt();
        BrokenRiceStockDetailEntity.PricePerBag = txtBRPriceperbag.Text.ConvertToDouble();

        lstBrokenRiceStockDetail.Add(BrokenRiceStockDetailEntity);
        VststateBrokenRiceStockDetail = lstBrokenRiceStockDetail;
        rptBrokenRiceDetails.DataSource = lstBrokenRiceStockDetail;
        rptBrokenRiceDetails.DataBind();
        ddlBRType.SelectedIndex = 0;
        ddlBRUnitsType.SelectedIndex = 0;
        txtBRPriceperbag.Text = string.Empty;
        txtBRTotalBags.Text = string.Empty;
    }
    protected void btnHullingProcess_Click(object sender, EventArgs e)
    { }
    protected void btnCalculate_Click(object sender, EventArgs e)
    { }
    protected void btnSaveClose_Click(object sender, EventArgs e)
    {
        ResultDTO resultDto = BinderSingleton.Instance.GetInstance<IValidateTransactionBusiness>().ValidateHullingProcessTrans(ddlRiceType.SelectedIndex, ddlBRType.SelectedIndex, ddlriceUnittype.SelectedIndex, ddlBRUnitsType.SelectedIndex, ddlDustUnitsType.SelectedIndex, txtricetotalbags.Text, txtBRTotalBags.Text, txtDustTotalBags.Text, txtBRPriceperbag.Text, txtDustPriceperbag.Text);
        if (resultDto.IsSuccess)
        {

            ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
            //Save Rice details
            resultDto = imp.SaveHullingProcessTransInfo("", "Rice", ddlRiceBrand.SelectedValue, ddlRiceType.SelectedValue, null, ddlriceUnittype.SelectedValue, Convert.ToInt16(txtricetotalbags.Text.Trim()), 0);
            //Save BrokenRiceDetails
            resultDto = imp.SaveHullingProcessTransInfo("", "BrokenRice", null, null, ddlBRType.SelectedValue, ddlBRUnitsType.SelectedValue, Convert.ToInt16(txtBRTotalBags.Text.Trim()), Convert.ToDouble(txtBRPriceperbag.Text.Trim()));
            //Save Dust Details
            resultDto = imp.SaveHullingProcessTransInfo("", "Dust", null, null, null, ddlDustUnitsType.SelectedValue, Convert.ToInt16(txtDustTotalBags.Text.Trim()), Convert.ToDouble(txtDustPriceperbag.Text.Trim()));
            //Hulling Process Expenses
            resultDto = imp.SaveHullingProcessExpensesInfo("", Convert.ToDouble(txtPowerExpenses.Text.Trim()), Convert.ToDouble(txtLabourExpenses.Text.Trim()), Convert.ToDouble(txtOtherExpenses.Text.Trim()));
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