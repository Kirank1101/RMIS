using System;
using RMIS.Binder.BackEnd;
using RMIS.Domain.Business;
using RMIS.Domain.DataTranserClass;
using System.Collections.Generic;
using AllInOne.Common.Library.Util;
using System.Web.UI.WebControls;
public partial class ProductSellingInfo : BaseUserControl
{
    private const string Rice = "Rice";
    private const string BrokenRice = "BrokenRice";
    private const string Dust = "Dust";
    IMasterPaddyBusiness impb = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
    protected override void OnInit(EventArgs e)
    {
        base.OnInit(e);
    }
    protected void TabContainer1_ActiveTabChanged(object sender, EventArgs e)
    {

    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsControlPostBack)
        {
            Header = "Product Selling and Payment Information";

            ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();

            ddlRiceType.DataSource = impb.GetRiceProductEntities();
            ddlRiceType.DataTextField = "RiceType";
            ddlRiceType.DataValueField = "Id";
            ddlRiceType.DataBind();

            ddlRiceBrand.DataSource = impb.GetRiceBrandEntities();
            ddlRiceBrand.DataTextField = "RiceBrand";
            ddlRiceBrand.DataValueField = "Id";
            ddlRiceBrand.DataBind();

            ddlBrokenRiceType.DataSource = impb.GetMBrokenRiceTypeEntities();
            ddlBrokenRiceType.DataTextField = "BrokenRiceType";
            ddlBrokenRiceType.DataValueField = "Id";
            ddlBrokenRiceType.DataBind();

            ddlUnitsType.DataSource = impb.GetMUnitsTypeEntities();
            ddlUnitsType.DataTextField = "UnitsType";
            ddlUnitsType.DataValueField = "Id";
            ddlUnitsType.DataBind();
        }
    }
    string viewstateProdSelInfoEnt = "viewstateProdSelInfoEnt";
    public List<ProductSellingInfoDTO> VstProdSelInfoEnt
    {
        get
        {
            if (ViewState[viewstateProdSelInfoEnt] == null)
                ViewState[viewstateProdSelInfoEnt] = new List<ProductSellingInfoDTO>();
            return (List<ProductSellingInfoDTO>)ViewState[viewstateProdSelInfoEnt];
        }
        set
        {
            ViewState[viewstateProdSelInfoEnt] = value;
        }
    }
    private List<ProductSellingInfoDTO> AddProductSellingInfoDetails()
    {
        ResultDTO resultDTO = new ResultDTO();
        ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
        List<ProductSellingInfoDTO> lstprodselinfoDTO = VstProdSelInfoEnt;

        switch (rbtProductSellingtype.SelectedValue)
        {
            case Rice:
                resultDTO = imp.CheckRiceStockAvailability(ddlRiceType.SelectedValue, ddlRiceBrand.SelectedValue, ddlUnitsType.SelectedValue, txtTotalBags.Text.ConvertToInt());
                break;
            case BrokenRice:
                resultDTO = imp.CheckBrokenriceStockAvailability(ddlBrokenRiceType.SelectedValue, ddlUnitsType.SelectedValue, txtTotalBags.Text.ConvertToInt());
                break;
            case Dust:
                resultDTO = imp.CheckDustStockAvailability(ddlUnitsType.SelectedValue, txtTotalBags.Text.ConvertToInt());
                break;
            default:
                resultDTO.IsSuccess = false;
                break;
        }
        #region Check Rice Stock Information

        #endregion
        if (resultDTO.IsSuccess)
        {
            #region ADD Stock
            ProductSellingInfoDTO prodselinfoDTO = new ProductSellingInfoDTO();
            prodselinfoDTO.ProductID = lstprodselinfoDTO.Count + 1;
            prodselinfoDTO.SellingProductType = rbtProductSellingtype.SelectedValue;
            prodselinfoDTO.BuyerID = txtBuyerName.SelectedValue;
            prodselinfoDTO.UnitsType = ddlUnitsType.SelectedItem.Text;
            prodselinfoDTO.UnitsTypeID = ddlUnitsType.SelectedValue;
            prodselinfoDTO.TotalBags = txtTotalBags.Text.ConvertToInt();
            prodselinfoDTO.Price = txtprice.Text.ConvertToDouble();
            prodselinfoDTO.BuyerName = txtBuyerName.Text;
            prodselinfoDTO.ProductName = rbtProductSellingtype.SelectedValue;
            prodselinfoDTO.MediatorID = txtMediatorName.SelectedValue;
            prodselinfoDTO.MediatorName = txtMediatorName.Text;
            if (rbtProductSellingtype.SelectedValue == Rice)
            {
                prodselinfoDTO.MRiceBrandID = ddlRiceBrand.SelectedValue;
                prodselinfoDTO.MRiceProdTypeID = ddlRiceType.SelectedValue;
                prodselinfoDTO.BrokenRiceTypeID = null;

                prodselinfoDTO.ProductType = ddlRiceType.SelectedIndex > 0 ? Convert.ToString(ddlRiceType.SelectedItem) : string.Empty;
                prodselinfoDTO.Brand = ddlRiceBrand.SelectedIndex > 0 ? Convert.ToString(ddlRiceBrand.SelectedItem) : string.Empty;
            }
            else if (rbtProductSellingtype.SelectedValue == BrokenRice)
            {
                prodselinfoDTO.MRiceBrandID = null;
                prodselinfoDTO.MRiceProdTypeID = null;
                prodselinfoDTO.BrokenRiceTypeID = ddlBrokenRiceType.SelectedValue;
                prodselinfoDTO.ProductType = ddlBrokenRiceType.SelectedIndex > 0 ? Convert.ToString(ddlBrokenRiceType.SelectedItem) : string.Empty;
                prodselinfoDTO.Brand = string.Empty;
            }
            else if (rbtProductSellingtype.SelectedValue == Dust)
            {
                prodselinfoDTO.MRiceBrandID = null;
                prodselinfoDTO.MRiceProdTypeID = null;
                prodselinfoDTO.BrokenRiceTypeID = null;
                prodselinfoDTO.ProductType = string.Empty;
                prodselinfoDTO.Brand = string.Empty;
            }
            prodselinfoDTO.ProductSellingDate = txtSellingDate.Text.ConvertToDate();
            prodselinfoDTO.TotalBags = txtTotalBags.Text.ConvertToInt();
            prodselinfoDTO.Price = txtprice.Text.ConvertToDouble();
            prodselinfoDTO.TotalPrice = prodselinfoDTO.TotalBags * prodselinfoDTO.Price;
            lstprodselinfoDTO.Add(prodselinfoDTO);
            VstProdSelInfoEnt = lstprodselinfoDTO;
            ClearAllInputFields();

            #endregion
        }
        else
        {
            SetMessage(resultDTO);
        }
        return lstprodselinfoDTO;
    }
    protected void btnBuyerDetails_Click(object sender, EventArgs e)
    {
        ResultDTO resultDTO = new ResultDTO();
        ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
        List<ProductBuyerPaymentDTO> lstProductBuyerPayment = new List<ProductBuyerPaymentDTO>();
        lstProductBuyerPayment = imp.GetProductPaymentDue(txtMediatorNamePayment.SelectedValue, txtBuyerNamePayment.SelectedValue);
        rptBuyerPaymentDue.DataSource = lstProductBuyerPayment;
        rptBuyerPaymentDue.DataBind();
        TabSellingInfo.ActiveViewIndex = 1;
    }
    protected void btnReset_Click(object sender, EventArgs e)
    {
        txtBuyerNamePayment.Enabled = true;
        txtMediatorNamePayment.Enabled = true;
        ClearAllPaymentInputFields();
    }
    protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
    {
        TabSellingInfo.ActiveViewIndex = Int32.Parse(e.Item.Value);
        int i = 0;
        //Make the selected menu item reflect the correct imageurl
        for (i = 0; i <= MenuProductSelling.Items.Count - 1; i++)
        {
            if (i == Int32.Parse(e.Item.Value))
            {
                MenuProductSelling.Items[i].Selected = true;

            }
            else
            {
                MenuProductSelling.Items[i].Selected = false;
            }
        }
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        ResultDTO resultDto = BinderSingleton.Instance.GetInstance<IValidateTransactionBusiness>().ValidateProductSellingDetails(rbtProductSellingtype.SelectedIndex, rbtProductSellingtype.SelectedValue, txtBuyerName.SelectedValue, ddlRiceType.SelectedIndex, ddlRiceBrand.SelectedIndex, ddlBrokenRiceType.SelectedIndex, ddlUnitsType.SelectedIndex, txtTotalBags.Text, txtprice.Text, txtSellingDate.Text, txtNextPayDate.Text);
        if (resultDto.IsSuccess)
        {
            List<ProductSellingInfoDTO> lstprodselinfoDTO = AddProductSellingInfoDetails();
            if (lstprodselinfoDTO != null && lstprodselinfoDTO.Count > 0)
            {
                rptProductSellingDetails.DataSource = lstprodselinfoDTO;
                rptProductSellingDetails.DataBind();
            }
            else
            {
                SetMessage(resultDto);
            }
        }
    }
    protected void btnclear_click(object sender, EventArgs e)
    {
        ClearAllInputFields();
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        List<ProductSellingInfoDTO> lstprodselinfoDTO = new List<ProductSellingInfoDTO>();
        lstprodselinfoDTO = AddProductSellingInfoDetails();
        ResultDTO resultDto = new ResultDTO();

        if (lstprodselinfoDTO.Count > 0)
        {
            ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
            string BrokenRiceType = rbtProductSellingtype.SelectedValue == BrokenRice ? ddlBrokenRiceType.SelectedValue : null;
            string RiceType = rbtProductSellingtype.SelectedValue == Rice ? ddlRiceType.SelectedValue : null;
            string RiceBrandType = rbtProductSellingtype.SelectedValue == Rice ? ddlRiceBrand.SelectedValue : null;

            if (lstprodselinfoDTO != null && lstprodselinfoDTO.Count > 0)
            {
                resultDto = imp.SaveProductSellingInfo(lstprodselinfoDTO, txtNextPayDate.Text.ConvertToDate(),txtDiscount.Text.ConvertToInt());
                if (resultDto.IsSuccess)
                {
                    ClearAllInputFields();                    
                    SetMessage(resultDto);
                    VstProdSelInfoEnt = null;
                    rptProductSellingDetails.DataSource = null;
                    rptProductSellingDetails.DataBind();       
                }
            }
            else
            {
                resultDto.Message += "Saved Unsuccessfully..";
            }
        }
        else
        {
            resultDto.IsSuccess = false;
            resultDto.Message = "Record Saved Unsuccessfully.. ";
            SetMessage(resultDto);
        }

    }
    protected void btnSavePayment_Click(object sender, EventArgs e)
    {
        ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();

        string MediatorID = !string.IsNullOrEmpty(txtMediatorNamePayment.Text.Trim()) ? imp.GetMediatorInfo(txtMediatorNamePayment.Text.Trim()) : string.Empty;
        string BuyerID = !string.IsNullOrEmpty(txtBuyerNamePayment.Text.Trim()) ? imp.GetBuyerInfo(txtBuyerNamePayment.Text.Trim()) : string.Empty;

        ResultDTO resultDto = BinderSingleton.Instance.GetInstance<IValidateTransactionBusiness>().ValidateProductPaymentDetails(rbtPaymnetMode.SelectedIndex, BuyerID, txtReceivedAmount.Text.ConvertToDouble(), txtTotalProductCost.Text.ConvertToDouble());
        if (resultDto.IsSuccess)
        {
            resultDto = imp.SaveProductPaymentTransaction(hfProdPaymentID.Value, MediatorID, BuyerID, rbtPaymnetMode.SelectedValue, txtChequeNo.Text.Trim(), txtDDno.Text.Trim(), txtBankName.Text.Trim(), txtReceivedAmount.Text.ConvertToDouble(), txtNextPaymentDate.Text.ConvertToDate(), txtTotalProductCost.Text.ConvertToDouble(),ChkSettlementPay.Checked);
            if (resultDto.IsSuccess)
            {
                ClearAllPaymentInputFields();
                txtMediatorNamePayment.Enabled = true;
                txtBuyerNamePayment.Enabled = true;
                SetMessage(resultDto);
            }
        }
        TabSellingInfo.ActiveViewIndex = 1;
    }
    protected void ddlRiceType_OnSelectedIndexChanged(object sender, EventArgs e)
    {
        GetStockCount();
    }
    protected void ddlRiceBrand_OnSelectedIndexChanged(object sender, EventArgs e) { GetStockCount(); }
    protected void ddlBrokenRiceType_OnSelectedIndexChanged(object sender, EventArgs e) { GetStockCount(); }
    protected void ddlUnitsType_OnSelectedIndexChanged(object sender, EventArgs e) { GetStockCount(); }
    private void GetStockCount()
    {
        int StockCount = 0;
        if (rbtProductSellingtype.SelectedValue == Rice)
        {

            if (ddlRiceType.SelectedIndex > 0 && ddlBrokenRiceType.SelectedIndex == 0)
            {
                ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
                StockCount = imp.GetRiceStockOnRiceType(ddlRiceType.SelectedValue, ddlRiceBrand.SelectedIndex > 0 ? ddlRiceBrand.SelectedValue : null, ddlUnitsType.SelectedIndex > 0 ? ddlUnitsType.SelectedValue : null);
            }
            lblProductStockInfo.Visible = true;
            lblProductStockInfo.Text = "Total Rice Stock Available for the selection : ";
        }
        else if (rbtProductSellingtype.SelectedValue == BrokenRice)
        {
            if (ddlBrokenRiceType.SelectedIndex > 0 && ddlRiceType.SelectedIndex == 0)
            {
                ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
                StockCount = imp.GetBrokenRiceStockOnBrokenRiceType(ddlBrokenRiceType.SelectedValue, ddlUnitsType.SelectedIndex > 0 ? ddlUnitsType.SelectedValue : null);
            }
            lblProductStockInfo.Visible = true;
            lblProductStockInfo.Text = "Total Broken Rice Stock Available for the selection : ";
        }
        if (rbtProductSellingtype.SelectedValue == Dust)
        {
            if (ddlBrokenRiceType.SelectedIndex == 0 && ddlRiceType.SelectedIndex == 0)
            {
                ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
                StockCount = imp.GetDustStock(ddlUnitsType.SelectedIndex > 0 ? ddlUnitsType.SelectedValue : null);
            }
            lblProductStockInfo.Visible = true;
            lblProductStockInfo.Text = "Total Dust Stock Available for the selection : ";
        }
        if (StockCount > 0)
        {

            lblProductStock.Text = StockCount.ToString();
            lblProductStock.ForeColor = System.Drawing.Color.Green;
        }
        else
        {

            lblProductStock.Text = "No Stock for the sellection";
            lblProductStock.ForeColor = System.Drawing.Color.Red;
        }

    }
    private void ClearAllPaymentInputFields()
    {
        txtBuyerNamePayment.Text = string.Empty;
        txtMediatorNamePayment.Text = string.Empty;
        rptBuyerPaymentDue.SelectedIndex = -1;
        txtChequeNo.Text = string.Empty;
        txtDDno.Text = string.Empty;
        txtBankName.Text = string.Empty;
        txtTotalProductCost.Text = string.Empty;
        txtBalanceAmount.Text = string.Empty;
        txtNextPaymentDate.Text = string.Empty;
        txtReceivedAmount.Text = string.Empty;
        rptBuyerPaymentDue.DataSource = null;
        rptBuyerPaymentDue.DataBind();
    }
    protected void btnCancel_click(object sender, EventArgs e)
    {
        ClearAllPaymentInputFields();
        TabSellingInfo.ActiveViewIndex = 1;
    }

    protected void rptBuyerPaymentDue_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "PayAmount")
        {
            int rowindex = Convert.ToInt32(e.CommandArgument);
            GridViewRow row = rptBuyerPaymentDue.Rows[rowindex];
            txtTotalProductCost.Text = row.Cells[3].Text;
            txtBuyerNamePayment.Text = row.Cells[2].Text;
            txtMediatorNamePayment.Text = row.Cells[1].Text;
            hfProdPaymentID.Value = rptBuyerPaymentDue.DataKeys[rowindex].Value.ToString();
            TabSellingInfo.ActiveViewIndex = 1;
            txtBuyerNamePayment.Enabled = false;
            txtMediatorNamePayment.Enabled = false;
        }
    }
    protected void rptProductSellingDetails_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        GridViewRow row = (GridViewRow)rptProductSellingDetails.Rows[e.RowIndex];
        List<ProductSellingInfoDTO> lstProductSellingInfoDTO = VstProdSelInfoEnt;
        int keyvalue = Convert.ToInt32(rptProductSellingDetails.DataKeys[e.RowIndex].Value);
        ProductSellingInfoDTO brdt = lstProductSellingInfoDTO.Find(id => id.ProductID == keyvalue);
        lstProductSellingInfoDTO.Remove(brdt);
        VstProdSelInfoEnt = lstProductSellingInfoDTO;
        rptProductSellingDetails.DataSource = lstProductSellingInfoDTO;
        rptProductSellingDetails.DataBind();
    }
    protected void rbtProductSellingtype_OnSelectChange(object sender, EventArgs e)
    {
        lblProductStockInfo.Text = string.Empty;
        lblProductStock.Text = string.Empty;
        lblRiceBrandName.Visible = true;
        lblRiceType.Visible = true;
        ddlRiceBrand.Visible = true;
        ddlRiceType.Visible = true;
        lblBrokenRiceType.Visible = true;
        ddlBrokenRiceType.Visible = true;
        spBrandName.Visible = true;
        spRiceType.Visible = true;
        spBrokenRiceType.Visible = true;
        txtTotalBags.Text = "0";
        txtprice.Text = "0";
        ddlUnitsType.SelectedIndex = 0;
        ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();

        if (rbtProductSellingtype.SelectedValue == Rice)
        {
            lblBrokenRiceType.Visible = false;
            ddlBrokenRiceType.Visible = false;
            spBrokenRiceType.Visible = false;
            ddlBrokenRiceType.SelectedIndex = 0;


        }
        else if (rbtProductSellingtype.SelectedValue == BrokenRice)
        {
            lblRiceBrandName.Visible = false;
            lblRiceType.Visible = false;
            spRiceType.Visible = false;
            spBrandName.Visible = false;
            ddlRiceBrand.Visible = false;
            ddlRiceType.Visible = false;
            ddlRiceBrand.SelectedIndex = 0;
            ddlRiceType.SelectedIndex = 0;
        }
        else if (rbtProductSellingtype.SelectedValue == Dust)
        {
            lblRiceBrandName.Visible = false;
            lblRiceType.Visible = false;
            lblBrokenRiceType.Visible = false;
            ddlBrokenRiceType.Visible = false;
            ddlRiceBrand.Visible = false;
            ddlRiceType.Visible = false;
            spBrandName.Visible = false;
            spRiceType.Visible = false;
            spBrokenRiceType.Visible = false;
            ddlBrokenRiceType.SelectedIndex = 0;
            ddlRiceBrand.SelectedIndex = 0;
            ddlRiceType.SelectedIndex = 0;
        }
    }
    private void ClearAllInputFields()
    {
        rbtProductSellingtype.SelectedIndex = -1;
        ddlRiceType.SelectedIndex = 0;
        ddlRiceBrand.SelectedIndex = 0;
        ddlBrokenRiceType.SelectedIndex = 0;
        ddlUnitsType.SelectedIndex = 0;
        txtTotalBags.Text = string.Empty;
        txtprice.Text = string.Empty; 
    }

}