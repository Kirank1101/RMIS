using System;
using RMIS.Domain.RiceMill;
using RMIS.Binder.BackEnd;
using RMIS.Domain.Business;
using RMIS.Domain.DataTranserClass;
using System.Collections.Generic;

public partial class ProductSellingInfo : BaseUserControl
{
    IMasterPaddyBusiness impb = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
    int count = 0;
    int count1 = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsControlPostBack)
        {
            base.Header = "Product Stock Information";

            //ddlProductTypeID.DataSource = impb.GetMProductSellingTypeEntities();
            //ddlProductTypeID.DataTextField = "ProductSellingType";
            //ddlProductTypeID.DataValueField = "SellerID";
            //ddlProductTypeID.DataBind();

            ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
            ddlsellernames.DataSource = imp.GetPaddySellerInfo();
            ddlsellernames.DataTextField = "Name";
            ddlsellernames.DataValueField = "SellerID";
            ddlsellernames.DataBind();

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
        prodselinfoent.SellerID = ddlsellernames.SelectedValue;
        prodselinfoent.MRiceBrandID = ddlRiceBrand.SelectedValue;
        prodselinfoent.MRiceProdTypeID = ddlRiceType.SelectedValue;
        prodselinfoent.UnitsTypeID = ddlUnitsType.SelectedValue;
        prodselinfoent.TotalBags = Convert.ToDecimal(txtTotalBags.Text.Trim());
        prodselinfoent.Price = Convert.ToDouble(txtprice.Text.Trim());
        lstprodselinfoent.Add(prodselinfoent);
        VstProdSelInfoEnt = lstprodselinfoent;

        List<ProductSellingInfoDisplay> lstprodselinfodisplay = VststateProdSelInfoEntDisplay;
        ProductSellingInfoDisplay ProdSelInfoDisplay = new ProductSellingInfoDisplay();
        ProdSelInfoDisplay.ProductID = Convert.ToString(count1 + 1);
        ProdSelInfoDisplay.SellerName = Convert.ToString(ddlsellernames.SelectedItem);
        ProdSelInfoDisplay.ProductType = rbtProductSellingtype.SelectedValue;
        ProdSelInfoDisplay.ProductName = ddlRiceType.SelectedIndex > 0 ? Convert.ToString(ddlRiceType.SelectedItem) : string.Empty;
        ProdSelInfoDisplay.Brand = ddlRiceBrand.SelectedIndex > 0 ? Convert.ToString(ddlRiceBrand.SelectedItem) : string.Empty;
        ProdSelInfoDisplay.TotalBags = Convert.ToDecimal(txtTotalBags.Text.Trim());
        ProdSelInfoDisplay.Price = Convert.ToDouble(txtprice.Text.Trim());
        ProdSelInfoDisplay.TotalPrice = Convert.ToDouble(prodselinfoent.TotalBags) * prodselinfoent.Price;
        lstprodselinfodisplay.Add(ProdSelInfoDisplay);
        VststateProdSelInfoEntDisplay = lstprodselinfodisplay;
        rptProductSellingDetails.DataSource = lstprodselinfodisplay;
        rptProductSellingDetails.DataBind();
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        ResultDTO resultDto = BinderSingleton.Instance.GetInstance<IValidateTransactionBusiness>().ValidateProductSellingDetails(rbtProductSellingtype.SelectedIndex, ddlsellernames.SelectedIndex, ddlRiceType.SelectedIndex, ddlRiceBrand.SelectedIndex, ddlBrokenRiceType.SelectedIndex, ddlUnitsType.SelectedIndex, txtTotalBags.Text, txtprice.Text, txtSellingDate.Text);
        if (resultDto.IsSuccess)
        {
            ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
            resultDto = imp.SaveProductSellingInfo(rbtProductSellingtype.SelectedValue, ddlsellernames.SelectedValue, ddlRiceType.SelectedValue, ddlRiceBrand.SelectedValue, ddlBrokenRiceType.SelectedValue, Convert.ToDecimal(txtTotalBags.Text.Trim()), ddlUnitsType.SelectedValue, Convert.ToDouble(txtprice.Text.Trim()), Convert.ToDateTime(txtSellingDate.Text.Trim()));
            //char status = Convert.ToDouble(txtBalanceAmount.Text.Trim()) == 0 ? Convert.ToChar("C") : Convert.ToChar("P");
            //resultDto = imp.SaveProductPaymentInfo(Convert.ToDouble(lbltotalamount.Text), status);
            //SetMessage(resultDto);
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
        ddlRiceType.SelectedIndex = 0;
        ddlsellernames.SelectedIndex = 0;
        ddlRiceBrand.SelectedIndex = 0;
        ddlBrokenRiceType.SelectedIndex = 0;
        ddlUnitsType.SelectedIndex = 0;
        txtTotalBags.Text = string.Empty;
        txtprice.Text = string.Empty;
        txtSellingDate.Text = string.Empty;
    }

}