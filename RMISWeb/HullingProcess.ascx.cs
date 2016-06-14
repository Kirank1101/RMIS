using System;
using RMIS.Binder.BackEnd;
using RMIS.Domain.Business;
using RMIS.Domain.DataTranserClass;
using System.Collections.Generic;
using AllInOne.Common.Library.Util;
using System.Web.UI.WebControls;

public partial class HullingProcess : BaseUserControl
{   
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsControlPostBack)
        {
            base.Header = "Paddy Stock Information";
            ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
            IMasterPaddyBusiness impb = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();

            ddlPaddyType.DataSource = impb.GetMPaddyTypeEntities();
            ddlPaddyType.DataTextField = "PaddyType";
            ddlPaddyType.DataValueField = "Id";
            ddlPaddyType.DataBind();

            ddlGodownName.DataSource = impb.GetMGodownTypeEntities();
            ddlGodownName.DataTextField = "GodownType";
            ddlGodownName.DataValueField = "Id";
            ddlGodownName.DataBind();


            List<MUnitsTypeDTO> MUnitTypeDto = new List<MUnitsTypeDTO>();
            MUnitTypeDto = impb.GetMUnitsTypeEntities();

            ddlUnitsType.DataSource = MUnitTypeDto;
            ddlUnitsType.DataTextField = "UnitsType";
            ddlUnitsType.DataValueField = "Id";
            ddlUnitsType.DataBind();

            ddlRiceType.DataSource = impb.GetRiceProductEntities();
            ddlRiceType.DataTextField = "RiceType";
            ddlRiceType.DataValueField = "Id";
            ddlRiceType.DataBind();
            ddlRiceBrand.DataSource = impb.GetRiceBrandEntities();
            ddlRiceBrand.DataTextField = "RiceBrand";
            ddlRiceBrand.DataValueField = "Id";
            ddlRiceBrand.DataBind();
            ddlriceUnittype.DataSource = MUnitTypeDto;
            ddlriceUnittype.DataTextField = "UnitsType";
            ddlriceUnittype.DataValueField = "Id";
            ddlriceUnittype.DataBind();

            ddlBRType.DataSource = impb.GetMBrokenRiceTypeEntities();
            ddlBRType.DataTextField = "BrokenRiceType";
            ddlBRType.DataValueField = "Id";
            ddlBRType.DataBind();
            ddlBRUnitsType.DataSource = MUnitTypeDto;
            ddlBRUnitsType.DataTextField = "UnitsType";
            ddlBRUnitsType.DataValueField = "Id";
            ddlBRUnitsType.DataBind();

            ddlDustUnitsType.DataSource = MUnitTypeDto;
            ddlDustUnitsType.DataTextField = "UnitsType";
            ddlDustUnitsType.DataValueField = "Id";
            ddlDustUnitsType.DataBind();


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

            resultDto = imp.SaveHullingProcessInfo(ddlPaddyType.SelectedValue, ddlUnitsType.SelectedValue, ddlGodownName.SelectedValue, ddlLotDetails.SelectedValue,
                txtTotalBags.Text.ConvertToInt(), txtpaddyprice.Text.ConvertToDouble(), Convert.ToDateTime(txtHullingProcessDate.Text), txtHullingProcessBy.Text.Trim(),
                ddlRiceType.SelectedValue, ddlRiceBrand.SelectedValue, ddlriceUnittype.SelectedValue, txtricetotalbags.Text.ConvertToInt(), ddlBRType.SelectedValue, ddlBRUnitsType.SelectedValue,
                txtBRTotalBags.Text.ConvertToInt(), txtBRPriceperbag.Text.ConvertToDouble(), ddlDustUnitsType.SelectedValue, txtDustTotalBags.Text.ConvertToInt(), txtDustPriceperbag.Text.ConvertToDouble(), 'P');

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
    string viewstateCount = "GVRowID";
    public int RowID
    {
        get
        {
            if (ViewState[viewstateCount] == null)
                ViewState[viewstateCount] = "0";
            return Convert.ToInt32(ViewState[viewstateCount]);
        }
        set
        {
            ViewState[viewstateCount] = value;
        }
    }

    protected void btnaddBrokenRice_Click(object sender, EventArgs e)
    {
        ResultDTO resultDto = BinderSingleton.Instance.GetInstance<IValidateTransactionBusiness>().ValidateBrokenRiceStockDetails(ddlBRType.SelectedIndex, ddlBRUnitsType.SelectedIndex, txtBRTotalBags.Text, txtBRPriceperbag.Text);
        if (resultDto.IsSuccess)
        {
            List<BrokenRiceStockDetailsDTO> lstBrokenRiceStockDetail = VststateBrokenRiceStockDetail;
            BrokenRiceStockDetailsDTO BrokenRiceStockDetailEntity = new BrokenRiceStockDetailsDTO();
            RowID = RowID + 1;
            BrokenRiceStockDetailEntity.Id = RowID;

            BrokenRiceStockDetailEntity.BrokenRiceTypeID = ddlBRType.SelectedValue;
            BrokenRiceStockDetailEntity.BrokenRiceType = Convert.ToString(ddlBRType.SelectedItem);
            BrokenRiceStockDetailEntity.UnitsTypeID = ddlBRUnitsType.SelectedValue;
            BrokenRiceStockDetailEntity.UnitsType = Convert.ToString(ddlBRUnitsType.SelectedItem);
            BrokenRiceStockDetailEntity.TotalBags = txtBRTotalBags.Text.ConvertToInt();
            BrokenRiceStockDetailEntity.PricePerBag = txtBRPriceperbag.Text.ConvertToDouble();

            lstBrokenRiceStockDetail.Add(BrokenRiceStockDetailEntity);
            VststateBrokenRiceStockDetail = lstBrokenRiceStockDetail;
            rptBrokenRiceDetails.DataSource = lstBrokenRiceStockDetail;
            rptBrokenRiceDetails.DataBind();
            //clear data
            ddlBRType.SelectedIndex = 0;
            ddlBRUnitsType.SelectedIndex = 0;
            txtBRPriceperbag.Text = string.Empty;
            txtBRTotalBags.Text = string.Empty;
        }
    }

    protected void rptBrokenRiceDetails_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        GridViewRow row = (GridViewRow)rptBrokenRiceDetails.Rows[e.RowIndex];
        List<BrokenRiceStockDetailsDTO> lstBrokenRiceStockDetail = VststateBrokenRiceStockDetail;
        int keyvalue = Convert.ToInt32(rptBrokenRiceDetails.DataKeys[e.RowIndex].Value);
        BrokenRiceStockDetailsDTO brdt = lstBrokenRiceStockDetail.Find(id => id.Id == keyvalue);
        lstBrokenRiceStockDetail.Remove(brdt);
        VststateBrokenRiceStockDetail = lstBrokenRiceStockDetail;
        rptBrokenRiceDetails.DataSource = lstBrokenRiceStockDetail;
        rptBrokenRiceDetails.DataBind();
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