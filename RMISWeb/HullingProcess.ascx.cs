﻿using System;
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
            ClearAllInputFieldsOnSaveAndClose();
            Header = "Hulling Process";
            IMasterPaddyBusiness impb = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
            ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
            #region Bind DropDown Lists
            //Hulling Process Paddy Type
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

            //Rice Type
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

            //BrokenRice Type
            ddlBRType.DataSource = impb.GetMBrokenRiceTypeEntities();
            ddlBRType.DataTextField = "BrokenRiceType";
            ddlBRType.DataValueField = "Id";
            ddlBRType.DataBind();

            ddlBRUnitsType.DataSource = MUnitTypeDto;
            ddlBRUnitsType.DataTextField = "UnitsType";
            ddlBRUnitsType.DataValueField = "Id";
            ddlBRUnitsType.DataBind();

            //Dust
            ddlDustUnitsType.DataSource = MUnitTypeDto;
            ddlDustUnitsType.DataTextField = "UnitsType";
            ddlDustUnitsType.DataValueField = "Id";
            ddlDustUnitsType.DataBind();
            #endregion
            //List<HullingProcessDTO> lst
            #region Bind Hulling Process Details
            HullingProcessDTO Hullingprocessdto = new HullingProcessDTO();
            Hullingprocessdto = imp.GetAllHullingProcessInfoEntities();
            if (Hullingprocessdto != null)
            {
                ddlPaddyType.SelectedValue = Hullingprocessdto.PaddyTypeID;
                ddlUnitsType.SelectedValue = Hullingprocessdto.UnitsTypeID;
                ddlGodownName.SelectedValue = Hullingprocessdto.MGodownID;
                BindLotDetails(Hullingprocessdto.MGodownID);
                ddlLotDetails.SelectedValue = Hullingprocessdto.MLotID;
                txtTotalBags.Text = Convert.ToString(Hullingprocessdto.TotalBags);
                txtpaddyprice.Text = Convert.ToString(Hullingprocessdto.Price);
                txtHullingProcessBy.Text = Hullingprocessdto.ProcessedBy;
                txtHullingProcessDate.Text = Hullingprocessdto.ProcessDate.ToString("dd/MM/yyyy");
                VSHullingProcessID = Hullingprocessdto.HullingProcessID;
                btnSave.Enabled = false;
                ddlPaddyType.Enabled = ddlUnitsType.Enabled = ddlGodownName.Enabled =
                    ddlLotDetails.Enabled = txtTotalBags.Enabled =
                    txtTotalBags.Enabled = txtpaddyprice.Enabled =
                    txtHullingProcessBy.Enabled = txtHullingProcessDate.Enabled = false;

                
            }
            lblpaddystockhulling.Visible = false;
            lblpaddyStock.Text= string.Empty;
            #endregion
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
        ResultDTO resultDto = BinderSingleton.Instance.GetInstance<IValidateTransactionBusiness>().ValidateHullingProcess(ddlPaddyType.SelectedIndex, ddlUnitsType.SelectedIndex, txtTotalBags.Text, txtHullingProcessBy.Text, txtHullingProcessDate.Text);
        long totalpaddycount = imp.CheckHullingProcessPaddyCount(ddlPaddyType.SelectedValue, ddlUnitsType.SelectedValue, ddlGodownName.SelectedValue, ddlLotDetails.SelectedValue);
        if (resultDto.IsSuccess)
        {
            if (totalpaddycount > txtTotalBags.Text.ConvertToInt())
            {
                resultDto = imp.SaveHullingProcessInfo(ddlPaddyType.SelectedValue, ddlUnitsType.SelectedValue, ddlGodownName.SelectedValue, ddlLotDetails.SelectedValue,
                   txtTotalBags.Text.ConvertToInt(), txtpaddyprice.Text.ConvertToDouble(), Convert.ToDateTime(txtHullingProcessDate.Text), txtHullingProcessBy.Text.Trim(), "P");
                SetMessage(resultDto);
                if (resultDto.IsSuccess)
                {
                    // ClearAllInputFields();
                    VSHullingProcessID = resultDto.ID;
                }
            }
            else
            {
                ResultDTO resdto = new ResultDTO();
                resdto.IsSuccess = false;
                resdto.Message = "Insufficient Paddy Stock";
                SetMessage(resdto);
            }
        }
        else
        {
            SetMessage(resultDto);
        }
    }
    protected void btnAddRice_Click(object sender, EventArgs e)
    {
        ResultDTO resultDto = BinderSingleton.Instance.GetInstance<IValidateTransactionBusiness>().ValidateRiceStockDetails(ddlRiceType.SelectedIndex, ddlRiceBrand.SelectedIndex, ddlriceUnittype.SelectedIndex, txtricetotalbags.Text);
        if (resultDto.IsSuccess)
        {
            List<RiceStockDetailsDTO> lstRiceStockDetailsDTO = ViewStateRiceStockDetail;
            RiceStockDetailsDTO RiceStockDetailsDTO = new RiceStockDetailsDTO();
            RiceStockDetailsDTO.Id = lstRiceStockDetailsDTO.Count + 1;
            RiceStockDetailsDTO.MRiceProdTypeID = ddlRiceType.SelectedValue;
            RiceStockDetailsDTO.RiceType = Convert.ToString(ddlRiceType.SelectedItem);
            RiceStockDetailsDTO.MRiceBrandID = ddlRiceBrand.SelectedValue;
            RiceStockDetailsDTO.BrandName = Convert.ToString(ddlRiceBrand.SelectedItem);
            RiceStockDetailsDTO.UnitsTypeID = ddlriceUnittype.SelectedValue;
            RiceStockDetailsDTO.UnitsType = Convert.ToString(ddlriceUnittype.SelectedItem);
            RiceStockDetailsDTO.TotalBags = txtricetotalbags.Text.ConvertToInt();

            lstRiceStockDetailsDTO.Add(RiceStockDetailsDTO);
            ViewStateRiceStockDetail = lstRiceStockDetailsDTO;
            rptRiceDetails.DataSource = lstRiceStockDetailsDTO;
            rptRiceDetails.DataBind();
            ClearAllRiceFields();

        }
    }
    protected void btnaddBrokenRice_Click(object sender, EventArgs e)
    {
        ResultDTO resultDto = BinderSingleton.Instance.GetInstance<IValidateTransactionBusiness>().ValidateBrokenRiceStockDetails(ddlBRType.SelectedIndex, ddlBRUnitsType.SelectedIndex, txtBRTotalBags.Text);
        if (resultDto.IsSuccess)
        {
            List<BrokenRiceStockDetailsDTO> lstBrokenRiceStockDetail = VststateBrokenRiceStockDetail;
            BrokenRiceStockDetailsDTO BrokenRiceStockDetailEntity = new BrokenRiceStockDetailsDTO();
            BrokenRiceStockDetailEntity.Id = lstBrokenRiceStockDetail.Count + 1;
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
            ClearAllBrokenRiceFields();

        }
    }
    protected void btnSaveClose_Click(object sender, EventArgs e)
    {
        List<BrokenRiceStockDetailsDTO> lstBRSD = VststateBrokenRiceStockDetail;
        List<RiceStockDetailsDTO> lstRSD = ViewStateRiceStockDetail;
        ResultDTO resultDto = null;// BinderSingleton.Instance.GetInstance<IValidateTransactionBusiness>().ValidateHullingProcessTrans(
        //    lstRSD.Count,lstBRSD.Count, 
        //    ddlRiceType.SelectedIndex, 
        //    ddlBRType.SelectedIndex, 
        //    ddlriceUnittype.SelectedIndex, 
        //    ddlBRUnitsType.SelectedIndex, 
        //    ddlDustUnitsType.SelectedIndex, 
        //    txtricetotalbags.Text, 
        //    txtBRTotalBags.Text, 
        //    txtDustTotalBags.Text, 
        //    txtBRPriceperbag.Text, 
        //    txtDustPriceperbag.Text,ddlRiceBrand.SelectedIndex);
        //if (resultDto.IsSuccess)
        //{
        ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
        lstBRSD = GetBrokenRiceStockDetails();
        lstRSD = GetRiceStockDetails();
        resultDto = imp.SaveHullingProcessTransInfo(VSHullingProcessID, lstRSD, lstBRSD, ddlDustUnitsType.SelectedValue, txtDustTotalBags.Text.ConvertToInt(), txtDustPriceperbag.Text.ConvertToDouble(), txtPowerExpenses.Text.ConvertToDouble(), txtLabourExpenses.Text.ConvertToDouble(), txtOtherExpenses.Text.ConvertToDouble());
        SetMessage(resultDto);
        if (resultDto.IsSuccess)
            ClearAllInputFieldsOnSaveAndClose();
        //}
        //else
        //{
        //    SetMessage(resultDto);
        //}
    }
    protected void ddlPaddyType_SelectedIndexChanged(object sender, EventArgs e)
    {
        
        GetPaddyStockCount();
    }
    protected void ddlLotDetails_SelectedIndexChanged(object sender, EventArgs e)
    {
        GetPaddyStockCount();
    }
    protected void ddlUnitsType_SelectedIndexChanged(object sender, EventArgs e)
    {   
         GetPaddyStockCount();
    }
    protected void ddlGodownSelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlGodownName.SelectedIndex > -1)
        {
            BindLotDetails(ddlGodownName.SelectedValue);
            GetPaddyStockCount();
        }
    }
    private void GetPaddyStockCount()
    {
        int PaddyStockCount = 0;
        if (ddlPaddyType.SelectedIndex > 0)
        {
            ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
            PaddyStockCount = imp.GetPaddyStockOnPaddyType(ddlPaddyType.SelectedValue, ddlUnitsType.SelectedIndex > 0 ? ddlUnitsType.SelectedItem.Text : null, ddlGodownName.SelectedIndex > 0 ? ddlGodownName.SelectedItem.Text : null, ddlLotDetails.SelectedIndex > 0 ? ddlLotDetails.SelectedItem.Text : null);
        }
        lblpaddystockhulling.Visible = true;
        if (PaddyStockCount > 0)
        {
            lblpaddyStock.Text = PaddyStockCount.ToString();
            lblpaddyStock.ForeColor = System.Drawing.Color.Green;
        }
        else
        {
            lblpaddyStock.Text = "No Stock for the sellection";
            lblpaddyStock.ForeColor = System.Drawing.Color.Red;
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
    protected void rptRiceDetails_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        GridViewRow row = (GridViewRow)rptRiceDetails.Rows[e.RowIndex];
        List<RiceStockDetailsDTO> lstRiceStockDetail = ViewStateRiceStockDetail;
        int keyvalue = Convert.ToInt32(rptRiceDetails.DataKeys[e.RowIndex].Value);
        RiceStockDetailsDTO brdt = lstRiceStockDetail.Find(id => id.Id == keyvalue);
        lstRiceStockDetail.Remove(brdt);
        ViewStateRiceStockDetail = lstRiceStockDetail;
        rptRiceDetails.DataSource = lstRiceStockDetail;
        rptRiceDetails.DataBind();
    }
    private void BindLotDetails(string GodownID)
    {
        IMasterPaddyBusiness impb = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
        ddlLotDetails.Items.Clear();
        ddlLotDetails.Items.Insert(0, "[Select]");
        ddlLotDetails.DataSource = impb.GetLotDetailsEntities(GodownID);
        ddlLotDetails.DataTextField = "LotDetails";
        ddlLotDetails.DataValueField = "Id";
        ddlLotDetails.DataBind();
    }
    private List<BrokenRiceStockDetailsDTO> GetBrokenRiceStockDetails()
    {
        List<BrokenRiceStockDetailsDTO> lstBRSD = new List<BrokenRiceStockDetailsDTO>();
        lstBRSD = VststateBrokenRiceStockDetail;
        if (ddlBRType.SelectedIndex > 0 && ddlBRUnitsType.SelectedIndex > 0 && txtBRPriceperbag.Text.ConvertToDouble() > 0 && txtBRTotalBags.Text.ConvertToInt() > 0)
        {
            BrokenRiceStockDetailsDTO BRSD = new BrokenRiceStockDetailsDTO();
            BRSD.BrokenRiceTypeID = ddlBRType.SelectedValue;
            BRSD.UnitsTypeID = ddlBRUnitsType.SelectedValue;
            BRSD.TotalBags = txtBRTotalBags.Text.ConvertToInt();
            BRSD.PricePerBag = txtBRPriceperbag.Text.ConvertToDouble();
            lstBRSD.Add(BRSD);
        }
        return lstBRSD;
    }
    private List<RiceStockDetailsDTO> GetRiceStockDetails()
    {
        List<RiceStockDetailsDTO> lstRSD = new List<RiceStockDetailsDTO>();
        lstRSD = ViewStateRiceStockDetail;
        if (ddlRiceType.SelectedIndex > 0 && ddlRiceBrand.SelectedIndex > 0 && ddlriceUnittype.SelectedIndex > 0 && txtricetotalbags.Text.ConvertToInt() > 0)
        {
            RiceStockDetailsDTO RSD = new RiceStockDetailsDTO();
            RSD.MRiceProdTypeID = ddlRiceType.SelectedValue;
            RSD.RiceType = Convert.ToString(ddlRiceType.SelectedItem);
            RSD.MRiceBrandID = ddlRiceBrand.SelectedValue;
            RSD.BrandName = Convert.ToString(ddlRiceBrand.SelectedItem);
            RSD.UnitsTypeID = ddlriceUnittype.SelectedValue;
            RSD.UnitsType = Convert.ToString(ddlriceUnittype.SelectedItem);
            RSD.TotalBags = txtricetotalbags.Text.ConvertToInt();
            lstRSD.Add(RSD);
        }
        return lstRSD;
    }
    #region clear fields
    private void ClearAllInputFields()
    {
        ddlPaddyType.SelectedIndex = 0;
        ddlUnitsType.SelectedIndex = 0;
        txtTotalBags.Text = string.Empty;
        txtHullingProcessDate.Text = string.Empty;
        txtHullingProcessBy.Text = string.Empty;
    }
    private void ClearAllInputFieldsOnSaveAndClose()
    {
        ddlPaddyType.SelectedIndex = 0;
        ddlUnitsType.SelectedIndex = 0;
        ddlGodownName.SelectedIndex = 0;
        ddlLotDetails.SelectedIndex = 0;
        txtTotalBags.Text = string.Empty;
        txtpaddyprice.Text = string.Empty;
        txtHullingProcessDate.Text = string.Empty;
        txtHullingProcessBy.Text = string.Empty;

        ddlRiceType.SelectedIndex = 0;
        ddlRiceBrand.SelectedIndex = 0;
        ddlriceUnittype.SelectedIndex = 0;
        txtricetotalbags.Text = string.Empty;

        ddlBRType.SelectedIndex = 0;
        ddlBRUnitsType.SelectedIndex = 0;
        txtBRTotalBags.Text = string.Empty;
        txtBRPriceperbag.Text = string.Empty;

        ddlDustUnitsType.SelectedIndex = 0;
        txtDustPriceperbag.Text = string.Empty;
        txtDustTotalBags.Text = string.Empty;

        txtPowerExpenses.Text = string.Empty;
        txtOtherExpenses.Text = string.Empty;
        txtLabourExpenses.Text = string.Empty;

        VststateBrokenRiceStockDetail = null;
        ViewStateRiceStockDetail = null;
        VSHullingProcessID = null;

        lbltotpaddycost.Text = string.Empty;
        lbltotexp.Text = string.Empty;
        lbltotbrokenriceprice.Text = string.Empty;
        lbltotdustprice.Text = string.Empty;
        lbltotriceprice.Text = string.Empty;
        lblpriceperricebag.Text = string.Empty;

        rptBrokenRiceDetails.DataSource = null;
        rptBrokenRiceDetails.DataBind();

    }
    private void ClearAllRiceFields()
    {
        ddlriceUnittype.SelectedIndex = 0;
        ddlRiceType.SelectedIndex = 0;
        ddlRiceBrand.SelectedIndex = 0;
        txtricetotalbags.Text = string.Empty;
    }
    private void ClearAllBrokenRiceFields()
    {
        ddlBRUnitsType.SelectedIndex = 0;
        ddlBRType.SelectedIndex = 0;
        txtBRPriceperbag.Text = string.Empty;
        txtBRTotalBags.Text = string.Empty;
    }
    #endregion
    #region Calculations
    protected void btnCalculate_Click(object sender, EventArgs e)
    {
        double totalpaddyprice = getpaddyprice(txtTotalBags.Text.ConvertToInt(), txtpaddyprice.Text.ConvertToDouble());
        double totOtherExpences = GetOtherExpences(txtPowerExpenses.Text.ConvertToDouble(), txtLabourExpenses.Text.ConvertToDouble(), txtOtherExpenses.Text.ConvertToDouble());
        int totalRiceBags = gettotalRice();
        double totalbrprice = getbrprice();
        double totdustprice = getdustprice(txtDustTotalBags.Text.ConvertToInt(), txtDustPriceperbag.Text.ConvertToDouble());
        double totalbalance = (totalpaddyprice + totOtherExpences) - (totalbrprice + totdustprice);

        double Priceperricebag = getricebagprice(totalbalance, totalRiceBags);
        lbltotpaddycost.Text = Convert.ToString(totalpaddyprice);
        lbltotexp.Text = Convert.ToString(totOtherExpences);
        lbltotbrokenriceprice.Text = Convert.ToString(totalbrprice);
        lbltotdustprice.Text = Convert.ToString(totdustprice);
        lbltotriceprice.Text = Convert.ToString(totalbalance);
        lblpriceperricebag.Text = Convert.ToString(Priceperricebag);
    }
    private double GetOtherExpences(double PowerExpenses, double LabourExpenses, double OtherExpenses)
    {
        return (PowerExpenses + LabourExpenses + OtherExpenses);
    }
    private double getricebagprice(double totalbalance, int ricetotbag)
    {
        double PricePerRiceBag = (totalbalance / ricetotbag);
        return Math.Round(PricePerRiceBag, 2, MidpointRounding.ToEven);
    }
    private double getpaddyquintal(int paddytotbag, int paddyunit)
    {
        return (paddyunit * paddytotbag) / 100;
    }
    private double getdustprice(int DustTotBags, double DustPrice)
    {
        return DustTotBags * DustPrice;
    }
    private double getbrprice()
    {
        double totbrprice = 0;

        List<BrokenRiceStockDetailsDTO> lstBRSD = VststateBrokenRiceStockDetail;
        foreach (BrokenRiceStockDetailsDTO item in lstBRSD)
            totbrprice += (item.TotalBags * item.PricePerBag);

        if (ddlBRType.SelectedIndex > 0 && ddlBRUnitsType.SelectedIndex > 0 && txtBRPriceperbag.Text.ConvertToDouble() > 0 && txtBRTotalBags.Text.ConvertToInt() > 0)
            totbrprice += (txtBRTotalBags.Text.ConvertToInt() * txtBRPriceperbag.Text.ConvertToDouble());

        return totbrprice;
    }

    private int gettotalRice()
    {
        int totRicebags = 0;

        List<RiceStockDetailsDTO> lstRSD = ViewStateRiceStockDetail;
        foreach (RiceStockDetailsDTO item in lstRSD)
            totRicebags += item.TotalBags;

        if (ddlRiceType.SelectedIndex > 0 && ddlRiceBrand.SelectedIndex > 0 && ddlriceUnittype.SelectedIndex > 0 && txtricetotalbags.Text.ConvertToInt() > 0)
            totRicebags += txtricetotalbags.Text.ConvertToInt();

        return totRicebags;
    }
    private double getpaddyprice(int paddytotbag, double paddypriceperbag)
    {
        return paddytotbag * paddypriceperbag;
    }
    #endregion
    #region Viewstate
    string viewstateBrokenRiceStockDetail = "viewstateBrokenRiceStockDetail";
    string VSRiceStockDetail = "VSRiceStockDetail";
    string ViewStateHullingProcessID = "HullingProcessID";
    string viewstateCount = "GVRowID";
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
    public List<RiceStockDetailsDTO> ViewStateRiceStockDetail
    {
        get
        {
            if (ViewState[VSRiceStockDetail] == null)
                ViewState[VSRiceStockDetail] = new List<RiceStockDetailsDTO>();
            return (List<RiceStockDetailsDTO>)ViewState[VSRiceStockDetail];
        }
        set
        {
            ViewState[VSRiceStockDetail] = value;
        }
    }

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
    public string VSHullingProcessID
    {
        get
        {
            return Convert.ToString(ViewState[ViewStateHullingProcessID]);
        }
        set
        {
            ViewState[ViewStateHullingProcessID] = value;
        }
    }
    #endregion
}