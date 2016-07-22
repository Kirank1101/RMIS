using System;
using RMIS.Binder.BackEnd;
using RMIS.Domain.Business;
using RMIS.Domain.DataTranserClass;
using System.Collections.Generic;
using AllInOne.Common.Library.Util;
using System.Web.UI.WebControls;
using System.Linq;

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
            btnGetPaddyPrice.Enabled = false;
            if (Hullingprocessdto != null)
            {
                ddlPaddyType.SelectedValue = Hullingprocessdto.PaddyTypeID;
                ddlUnitsType.SelectedValue = Hullingprocessdto.UnitsTypeID;
                ddlGodownName.SelectedValue = Hullingprocessdto.MGodownID;
                BindLotDetails(Hullingprocessdto.MGodownID);
                ddlLotDetails.SelectedValue = Hullingprocessdto.MLotID;
                txtTotalBags.Text = Convert.ToString(Hullingprocessdto.TotalBags);
                txtpaddyprice.Text = Convert.ToString(Hullingprocessdto.Price);
                VSHullingProcessID = Hullingprocessdto.HullingProcessID;
                btnSave.Enabled = btnGetPaddyPrice.Enabled = false;
                ddlPaddyType.Enabled = ddlUnitsType.Enabled = ddlGodownName.Enabled =
                    ddlLotDetails.Enabled = txtTotalBags.Enabled =
                    txtTotalBags.Enabled = txtpaddyprice.Enabled = false;

                HullingProcessExpenseDTO objHPE = new HullingProcessExpenseDTO();
                objHPE = imp.GetAllHullingProcessExpensesEntity(Hullingprocessdto.HullingProcessID);
                txtHullingExpenses.Text = Convert.ToString(objHPE.HullingExpenses / txtTotalBags.Text.ConvertToInt());
            }

            lblpaddystockhulling.Visible = false;
            lblpaddyStock.Text = string.Empty;
            #endregion
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
        ResultDTO resultDto = BinderSingleton.Instance.GetInstance<IValidateTransactionBusiness>().ValidateHullingProcess(ddlPaddyType.SelectedIndex, ddlUnitsType.SelectedIndex, txtTotalBags.Text,txtpaddyprice.Text,txtHullingExpenses.Text);
        long totalpaddycount = imp.CheckHullingProcessPaddyCount(ddlPaddyType.SelectedValue, ddlUnitsType.SelectedValue, ddlGodownName.SelectedValue, ddlLotDetails.SelectedValue);
        if (resultDto.IsSuccess)
        {
            if (totalpaddycount >= txtTotalBags.Text.ConvertToInt())
            {
                resultDto = imp.SaveHullingProcessInfo(ddlPaddyType.SelectedValue, ddlUnitsType.SelectedValue, ddlGodownName.SelectedValue, ddlLotDetails.SelectedValue,
                   txtTotalBags.Text.ConvertToInt(), txtpaddyprice.Text.ConvertToDouble(), "P", (txtHullingExpenses.Text.ConvertToDouble() * txtTotalBags.Text.ConvertToInt()));
                SetMessage(resultDto);
                if (resultDto.IsSuccess)
                {
                    btnSave.Enabled = btnGetPaddyPrice.Enabled = false;
                    ddlPaddyType.Enabled = ddlUnitsType.Enabled = ddlGodownName.Enabled =
                    ddlLotDetails.Enabled = txtTotalBags.Enabled =
                    txtTotalBags.Enabled = txtpaddyprice.Enabled = false;

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
    protected void GetPrice()
    {
        txtpaddyprice.Text = "1000";
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
            BrokenRiceStockDetailEntity.PriceperQuintal = txtBRPriceperQuintal.Text.ConvertToDouble();

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
        //    txtBRPriceperQuintal.Text, 
        //    txtDustPriceperQuintal.Text,ddlRiceBrand.SelectedIndex);
        //if (resultDto.IsSuccess)
        //{
        ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
        lstBRSD = GetBrokenRiceStockDetails();
        lstRSD = GetRiceStockDetails();
        if (lstRSD.Count > 0 && lstBRSD.Count > 0 && ddlDustUnitsType.SelectedIndex > 0 && txtDustPriceperQuintal.Text.ConvertToDouble() > 0 && txtDustTotalBags.Text.ConvertToInt() > 0)
        {
            resultDto = imp.SaveHullingProcessTransInfo(VSHullingProcessID, lstRSD, lstBRSD, ddlDustUnitsType.SelectedValue, ddlDustUnitsType.SelectedItem.Text.ConvertToInt(), txtDustTotalBags.Text.ConvertToInt(), txtDustPriceperQuintal.Text.ConvertToDouble());
            SetMessage(resultDto);
            if (resultDto.IsSuccess)
                ClearAllInputFieldsOnSaveAndClose();
        }
        //}
        //else
        //{
        //    SetMessage(resultDto);
        //}
    }
    protected void btnGetPaddyPrice_Click(object sender, EventArgs e)
    {
        ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
        ResultDTO resultDto = BinderSingleton.Instance.GetInstance<IValidateTransactionBusiness>().ValidateGetPaddyPrice(ddlPaddyType.SelectedIndex, ddlUnitsType.SelectedIndex, ddlGodownName.SelectedIndex, ddlLotDetails.SelectedIndex, txtTotalBags.Text);
        if (resultDto.IsSuccess)
        {
            List<PaddyStockDTO> lstPSDTO = imp.GetAvgPaddyPrice(ddlPaddyType.SelectedValue, ddlUnitsType.SelectedValue, ddlGodownName.SelectedValue, ddlLotDetails.SelectedValue, txtTotalBags.Text.ConvertToInt());
            double GetPaddyPrice = lstPSDTO.Sum(x => x.Price) / lstPSDTO.Count;
            txtpaddyprice.Text = Convert.ToString(GetPaddyPrice);
        }
        else
        {
            resultDto.Message = "Please enter Total Bags";
            SetMessage(resultDto);
        }
    }
    protected void ddlPaddyType_SelectedIndexChanged(object sender, EventArgs e)
    {

        GetPaddyStockCount();
    }
    protected void ddlLotDetails_SelectedIndexChanged(object sender, EventArgs e)
    {
        GetPaddyStockCount();
        btnGetPaddyPrice.Enabled = true;
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
        if (ddlBRType.SelectedIndex > 0 && ddlBRUnitsType.SelectedIndex > 0 && txtBRPriceperQuintal.Text.ConvertToDouble() > 0 && txtBRTotalBags.Text.ConvertToInt() > 0)
        {
            BrokenRiceStockDetailsDTO BRSD = new BrokenRiceStockDetailsDTO();
            BRSD.BrokenRiceTypeID = ddlBRType.SelectedValue;
            BRSD.UnitsTypeID = ddlBRUnitsType.SelectedValue;
            BRSD.UnitsType = ddlBRUnitsType.SelectedItem.Text;
            BRSD.TotalBags = txtBRTotalBags.Text.ConvertToInt();
            BRSD.PriceperQuintal = txtBRPriceperQuintal.Text.ConvertToDouble();
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
            RSD.RiceType = ddlRiceType.SelectedItem.Text;
            RSD.MRiceBrandID = ddlRiceBrand.SelectedValue;
            RSD.BrandName = ddlRiceBrand.SelectedItem.Text;
            RSD.UnitsTypeID = ddlriceUnittype.SelectedValue;
            RSD.UnitsType = ddlriceUnittype.SelectedItem.Text;
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
    }
    private void ClearAllInputFieldsOnSaveAndClose()
    {
        ddlPaddyType.SelectedIndex = 0;
        ddlUnitsType.SelectedIndex = 0;
        ddlGodownName.SelectedIndex = 0;
        ddlLotDetails.SelectedIndex = 0;
        txtTotalBags.Text = string.Empty;
        txtpaddyprice.Text = string.Empty;
        ddlRiceType.SelectedIndex = 0;
        ddlRiceBrand.SelectedIndex = 0;
        ddlriceUnittype.SelectedIndex = 0;
        txtricetotalbags.Text = string.Empty;
        ddlBRType.SelectedIndex = 0;
        ddlBRUnitsType.SelectedIndex = 0;
        txtBRTotalBags.Text = string.Empty;
        txtBRPriceperQuintal.Text = string.Empty;

        ddlDustUnitsType.SelectedIndex = 0;
        txtDustPriceperQuintal.Text = string.Empty;
        txtDustTotalBags.Text = string.Empty;

        txtHullingExpenses.Text = string.Empty;

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
        txtBRPriceperQuintal.Text = string.Empty;
        txtBRTotalBags.Text = string.Empty;
    }
    #endregion
    #region Calculations
    protected void btnCalculate_Click(object sender, EventArgs e)
    {
        double totalpaddyprice = getpaddyprice();
        double totOtherExpences = txtHullingExpenses.Text.ConvertToDouble() * txtTotalBags.Text.ConvertToInt();
        double totalRiceQuital = gettotalRiceWeight();
        double totalbrprice = getbrprice();
        double totdustprice = getdustprice();
        double totalbalance = totalpaddyprice - (totalbrprice + totdustprice);
        ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
            
        double Priceperricebag = GetRicePricePerQuintal(totalbalance, totalRiceQuital);
        lbltotpaddycost.Text = imp.ConverDoubleMoneyToStringMoney(Convert.ToString(totalpaddyprice));
        lbltotexp.Text = imp.ConverDoubleMoneyToStringMoney(Convert.ToString(totOtherExpences));
        lbltotbrokenriceprice.Text = imp.ConverDoubleMoneyToStringMoney(Convert.ToString(totalbrprice));
        lbltotdustprice.Text = imp.ConverDoubleMoneyToStringMoney(Convert.ToString(totdustprice));
        lbltotriceprice.Text = imp.ConverDoubleMoneyToStringMoney(Convert.ToString(totalbalance));
        lblpriceperricebag.Text = imp.ConverDoubleMoneyToStringMoney(Convert.ToString(Priceperricebag));
    }
    private double GetRicePricePerQuintal(double totalbalance, double TotalRicequintal)
    {
        double PricePerRiceBag = (totalbalance / TotalRicequintal);
        return Math.Round(PricePerRiceBag, 2, MidpointRounding.ToEven);
    }
    private double getdustprice()
    {
        double totalquital = ConverToQuintal(txtDustTotalBags.Text.ConvertToInt(), ddlDustUnitsType.SelectedItem.Text.ConvertToInt());
        return (totalquital * txtDustPriceperQuintal.Text.ConvertToDouble());

    }

    private double ConverToQuintal(int TotalBags, int UnitType)
    {
        return (TotalBags * UnitType) / 100;
    }
    private double getbrprice()
    {
        double totbrprice = 0;

        List<BrokenRiceStockDetailsDTO> lstBRSD = VststateBrokenRiceStockDetail;
        foreach (BrokenRiceStockDetailsDTO item in lstBRSD)
            totbrprice += (ConverToQuintal(item.TotalBags, item.UnitsType.ConvertToInt()) * item.PriceperQuintal);

        if (ddlBRType.SelectedIndex > 0 && ddlBRUnitsType.SelectedIndex > 0 && txtBRPriceperQuintal.Text.ConvertToDouble() > 0 && txtBRTotalBags.Text.ConvertToInt() > 0)
            totbrprice += (ConverToQuintal(txtBRTotalBags.Text.ConvertToInt(), ddlBRUnitsType.SelectedItem.Text.ConvertToInt()) * txtBRPriceperQuintal.Text.ConvertToDouble());

        return totbrprice;
    }

    private double gettotalRiceWeight()
    {
        double totRiceQuintal = 0;

        List<RiceStockDetailsDTO> lstRSD = ViewStateRiceStockDetail;
        foreach (RiceStockDetailsDTO item in lstRSD)
            totRiceQuintal += ConverToQuintal(item.TotalBags, item.UnitsType.ConvertToInt());

        if (ddlRiceType.SelectedIndex > 0 && ddlRiceBrand.SelectedIndex > 0 && ddlriceUnittype.SelectedIndex > 0 && txtricetotalbags.Text.ConvertToInt() > 0)
            totRiceQuintal += ConverToQuintal(txtricetotalbags.Text.ConvertToInt(), ddlriceUnittype.SelectedItem.Text.ConvertToInt());


        return totRiceQuintal;
    }
    private double getpaddyprice()
    {
        ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();

        double getpriceperbag = imp.ConverToPriceperBag(Convert.ToInt32(ddlUnitsType.SelectedItem.Text), txtpaddyprice.Text.ConvertToDouble());
        return txtTotalBags.Text.ConvertToInt() * getpriceperbag;
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