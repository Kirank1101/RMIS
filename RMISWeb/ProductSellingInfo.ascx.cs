using System;
using RMIS.Domain.RiceMill;
using RMIS.Binder.BackEnd;
using RMIS.Domain.Business;
using RMIS.Domain.DataTranserClass;
using System.Collections.Generic;
using AllInOne.Common.Library.Util;
public partial class ProductSellingInfo : BaseUserControl
{
    private const string Rice = "Rice";
    private const string BrokenRice = "BrokenRice";
    private const string Dust = "Dust";
    IMasterPaddyBusiness impb = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
    int count = 0;
    int count1 = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsControlPostBack)
        {
            base.Header = "Product Stock Information";

            ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
            ddlBuyernames.DataSource = imp.GetBuyerInfo();
            ddlBuyernames.DataTextField = "Name";
            ddlBuyernames.DataValueField = "BuyerID";
            ddlBuyernames.DataBind();

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
    public List<ProductSellingInfoEntity> VstProdSelInfoEnt
    {
        get
        {
            if (ViewState[viewstateProdSelInfoEnt] == null)
                ViewState[viewstateProdSelInfoEnt] = new List<ProductSellingInfoEntity>();
            return (List<ProductSellingInfoEntity>)ViewState[viewstateProdSelInfoEnt];
        }
        set
        {
            ViewState[viewstateProdSelInfoEnt] = value;
        }
    }

    string viewstateProdSelInfoEntDisplay = "viewstateProdSelInfoEntDisplay";
    public List<ProductSellingInfoDisplay> VststateProdSelInfoEntDisplay
    {
        get
        {
            if (ViewState[viewstateProdSelInfoEntDisplay] == null)
                ViewState[viewstateProdSelInfoEntDisplay] = new List<ProductSellingInfoDisplay>();
            return (List<ProductSellingInfoDisplay>)ViewState[viewstateProdSelInfoEntDisplay];
        }
        set
        {
            ViewState[viewstateProdSelInfoEntDisplay] = value;
        }
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {

        List<ProductSellingInfoEntity> lstprodselinfoent = VstProdSelInfoEnt;
        ProductSellingInfoEntity prodselinfoent = new ProductSellingInfoEntity();
        prodselinfoent.ProductID = Convert.ToString(count + 1);
        prodselinfoent.SellingProductType = rbtProductSellingtype.SelectedValue;
        prodselinfoent.BuyerID = ddlBuyernames.SelectedValue;
        prodselinfoent.MRiceBrandID = ddlRiceBrand.SelectedValue;
        prodselinfoent.MRiceProdTypeID = ddlRiceType.SelectedValue;
        prodselinfoent.UnitsTypeID = ddlUnitsType.SelectedValue;
        prodselinfoent.TotalBags = txtTotalBags.Text.ConvertToInt();
        prodselinfoent.Price = txtprice.Text.ConvertToDouble();
        lstprodselinfoent.Add(prodselinfoent);
        VstProdSelInfoEnt = lstprodselinfoent;

        List<ProductSellingInfoDisplay> lstprodselinfodisplay = VststateProdSelInfoEntDisplay;
        ProductSellingInfoDisplay ProdSelInfoDisplay = new ProductSellingInfoDisplay();
        ProdSelInfoDisplay.ProductID = Convert.ToString(count1 + 1);
        ProdSelInfoDisplay.BuyerName = Convert.ToString(ddlBuyernames.SelectedItem);
        ProdSelInfoDisplay.ProductType = rbtProductSellingtype.SelectedValue;
        ProdSelInfoDisplay.ProductName = ddlRiceType.SelectedIndex > 0 ? Convert.ToString(ddlRiceType.SelectedItem) : string.Empty;
        ProdSelInfoDisplay.Brand = ddlRiceBrand.SelectedIndex > 0 ? Convert.ToString(ddlRiceBrand.SelectedItem) : string.Empty;
        ProdSelInfoDisplay.TotalBags = txtTotalBags.Text.ConvertToInt();
        ProdSelInfoDisplay.Price = txtprice.Text.ConvertToDouble();
        ProdSelInfoDisplay.TotalPrice = prodselinfoent.TotalBags * prodselinfoent.Price;
        lstprodselinfodisplay.Add(ProdSelInfoDisplay);
        VststateProdSelInfoEntDisplay = lstprodselinfodisplay;
        rptProductSellingDetails.DataSource = lstprodselinfodisplay;
        rptProductSellingDetails.DataBind();
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        ResultDTO resultDto = BinderSingleton.Instance.GetInstance<IValidateTransactionBusiness>().ValidateProductSellingDetails(rbtProductSellingtype.SelectedIndex, ddlBuyernames.SelectedIndex, ddlRiceType.SelectedIndex, ddlRiceBrand.SelectedIndex, ddlBrokenRiceType.SelectedIndex, ddlUnitsType.SelectedIndex, txtTotalBags.Text, txtprice.Text, txtSellingDate.Text);
        if (resultDto.IsSuccess)
        {
            ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
            resultDto = imp.SaveProductSellingInfo(rbtProductSellingtype.SelectedValue, ddlBuyernames.SelectedValue, ddlRiceType.SelectedValue, ddlRiceBrand.SelectedValue, ddlBrokenRiceType.SelectedValue, txtTotalBags.Text.ConvertToInt(), ddlUnitsType.SelectedValue, txtprice.Text.ConvertToDouble(), Convert.ToDateTime(txtSellingDate.Text.Trim()),
                lblOrderNo.Text,rbtPaymnetMode.SelectedValue,txtChequeNo.Text.Trim(),txtDDno.Text.Trim(),txtBankName.Text.Trim(),txtReceivedAmount.Text.ConvertToDouble(),Convert.ToDateTime(txtNextPaymentDate.Text.Trim()));
            //char status = txtBalanceAmount.Text == 0 ? Convert.ToChar("C") : Convert.ToChar("P");
            //resultDto = imp.SaveProductPaymentInfo(lbltotalamount, status);
            //SetMessage(resultDto);
            if (resultDto.IsSuccess)
                ClearAllInputFields();
        }
        else
        {
            SetMessage(resultDto);
        }

    }
    protected void rbtProductSellingtype_OnSelectChange(object sender, EventArgs e)
    {
        //lblRiceBrandName.Visible = true;
        //lblRiceType.Visible = true;
        //ddlRiceBrand.Visible = true;
        //ddlRiceType.Visible = true;
        //lblBrokenRiceType.Visible = true;
        //ddlBrokenRiceType.Visible = true;
        //if (rbtProductSellingtype.SelectedValue == Rice)
        //{
        //    lblBrokenRiceType.Visible = false;
        //    ddlBrokenRiceType.Visible = false;
        //    ddlBrokenRiceType.SelectedIndex = 0;
        //}
        //else if (rbtProductSellingtype.SelectedValue == BrokenRice)
        //{
        //    lblRiceBrandName.Visible = false;
        //    lblRiceType.Visible = false;
        //    ddlRiceBrand.Visible = false;
        //    ddlRiceType.Visible = false;
        //    ddlRiceBrand.SelectedIndex = 0;
        //    ddlRiceType.SelectedIndex = 0;
        //}
        //else if (rbtProductSellingtype.SelectedValue == Dust)
        //{
        //    lblRiceBrandName.Visible = false;
        //    lblRiceType.Visible = false;
        //    lblBrokenRiceType.Visible = false;
        //    ddlBrokenRiceType.Visible = false;
        //    ddlRiceBrand.Visible = false;
        //    ddlRiceType.Visible = false;
        //    ddlBrokenRiceType.SelectedIndex = 0;
        //    ddlRiceBrand.SelectedIndex = 0;
        //    ddlRiceType.SelectedIndex = 0;
        //}
    }
    private void ClearAllInputFields()
    {
        ddlRiceType.SelectedIndex = 0;
        ddlBuyernames.SelectedIndex = 0;
        ddlRiceBrand.SelectedIndex = 0;
        ddlBrokenRiceType.SelectedIndex = 0;
        ddlUnitsType.SelectedIndex = 0;
        txtTotalBags.Text = string.Empty;
        txtprice.Text = string.Empty;
        txtSellingDate.Text = string.Empty;
    }

}