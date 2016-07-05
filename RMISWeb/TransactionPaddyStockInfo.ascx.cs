using System;
using RMIS.Binder.BackEnd;
using RMIS.Domain.Business;
using RMIS.Domain.DataTranserClass;
using System.Web.UI.WebControls;
using AllInOne.Common.Library.Util;
using RMIS.Domain.Constant;

public partial class TransactionPaddyStockInfo : BaseUserControl
{
    protected override void OnInit(EventArgs e)
    {
        base.OnInit(e);
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        IMasterPaddyBusiness impb = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
        Header = "Paddy Stock and Payment Information";

        if (!IsControlPostBack)
        {            
            ddlPaddyType.DataSource = impb.GetMPaddyTypeEntities();
            ddlPaddyType.DataTextField = "PaddyType";
            ddlPaddyType.DataValueField = "Id";
            ddlPaddyType.DataBind();

            ddlGodownname.DataSource = impb.GetMGodownTypeEntities();
            ddlGodownname.DataTextField = "GodownType";
            ddlGodownname.DataValueField = "Id";
            ddlGodownname.DataBind();

            ddlUnitsType.DataSource = impb.GetMUnitsTypeEntities();
            ddlUnitsType.DataTextField = "UnitsType";
            ddlUnitsType.DataValueField = "Id";
            ddlUnitsType.DataBind();

            //bindPaddyStockInfo();
            BindPaddyStockOverView();
        }
    }
    private void BindPaddyStockOverView()
    {
        int count = 0;
        ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
        gvPaddyStockOverview.DataSource = imp.GetPaddyStockOverViewDTO(gvPaddyStockOverview.PageIndex, gvPaddyStockOverview.PageSize, out count, expression);
        gvPaddyStockOverview.VirtualItemCount = count;
        gvPaddyStockOverview.DataBind();
    }
    protected void TabContainer1_ActiveTabChanged(object sender, EventArgs e)
    {

    }
    //private void bindPaddyStockInfo()
    //{
    //    int count = 0;
    //    ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
    //    rptPaddyStockInfo.DataSource = imp.GetPaddyStockDTO(rptPaddyStockInfo.PageIndex, rptPaddyStockInfo.PageSize, out count, expression);
    //    rptPaddyStockInfo.VirtualItemCount = count;
    //    rptPaddyStockInfo.DataBind();
    //}
    protected void ddlGodownSelectedIndexChanged(object sender, EventArgs e)
    {
        IMasterPaddyBusiness impb1 = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();

        if (ddlGodownname.SelectedIndex > -1)
        {
            ddlLotDetails.Items.Clear();
            ddlLotDetails.Items.Insert(0, "[Select]");
            ddlLotDetails.DataSource = impb1.GetLotDetailsEntities(ddlGodownname.SelectedValue);
            ddlLotDetails.DataTextField = "LotDetails";
            ddlLotDetails.DataValueField = "Id";
            ddlLotDetails.DataBind();
        }
        TabContainer1.ActiveViewIndex = 0;
    }
    protected void btnSellerDetails_Click(object sender, EventArgs e)
    {
        ITransactionBusiness impt = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
        //ResultDTO isvalidSeller = impt.CheckISValidSeller(txtsellernamePaddyPayment.SelectedValue,txtsellernamePaddyPayment.Text.Trim());
        //if (isvalidSeller.IsSuccess)
        //{
        txtTotalAmountDue.Text = Convert.ToString(impt.GetPaddyTotalAmountDueBySeller(txtsellernamePaddyPayment.SelectedValue));
            TabContainer1.ActiveViewIndex = 1;
        //}
        //else {
        //    SetMessage(isvalidSeller);
        //}
    }
    protected void btnClear_Click(object sender, EventArgs e)
    {
        ClearAllPaddyPaymentFields();
    }
    private void ClearAllPaddyPaymentFields()
    {
        txtsellernamePaddyPayment.Text = string.Empty;
        rbtPaymnetMode.SelectedIndex = -1;
        txtChequeNo.Text = string.Empty;
        txtBankName.Text = string.Empty;
        txtTotalAmountDue.Text = string.Empty;
        txtamountpaid.Text = string.Empty;
        txtbalanceamount.Text = string.Empty;
        txtHandoverto.Text = string.Empty;
        txtPruchaseDate.Text = string.Empty;
        txtNextpaymentdate.Text = string.Empty;
    }
    protected void btnPay_Click(object sender, EventArgs e)
    {
        ITransactionBusiness impp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
        ResultDTO resultDto = impp.SavePaddyPaymentDetails(txtsellernamePaddyPayment.SelectedValue, txtamountpaid.Text.ConvertToDouble(), txtPaidDate.Text.ConvertToDate(), txtHandoverto.Text, txtNextpaymentdate.Text.ConvertToDate(), null, rbtPaymnetMode.SelectedValue, txtChequeNo.Text, txtBankName.Text);
        if (resultDto.IsSuccess)
        {
            ClearAllPaddyPaymentFields();
            TabContainer1.ActiveViewIndex  = 1;
        }
        SetMessage(resultDto);
    }
    protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
    {
        TabContainer1.ActiveViewIndex = Int32.Parse(e.Item.Value);
        int i = 0;
        //Make the selected menu item reflect the correct imageurl
        for (i = 0; i <= MenuPaddyStock.Items.Count - 1; i++)
        {
            if (i == Int32.Parse(e.Item.Value))
            {
                MenuPaddyStock.Items[i].Selected = true;            

            }
            else
            {
                MenuPaddyStock.Items[i].Selected = false;
            }
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        double amtpaid = string.IsNullOrEmpty(txtamountpaid.Text.Trim()) ? 0 : txtamountpaid.Text.ConvertToDouble();
        ResultDTO resultDto = BinderSingleton.Instance.GetInstance<IValidateTransactionBusiness>().ValidatePaddyStockDetails(ddlGodownname.SelectedIndex, ddlLotDetails.SelectedIndex, ddlUnitsType.SelectedIndex, ddlPaddyType.SelectedIndex, txtSellerPaddyStock.Text.Trim(), txtVehicalNo.Text, txtTotalBags.Text, txtPricePerQuintal.Text, txtPruchaseDate.Text);
        ITransactionBusiness imps = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();


        //ResultDTO isvalidSeller = imps.CheckISValidSeller(txtSellerPaddyStock.SelectedValue,txtSellerPaddyStock.Text.Trim());
        //if (isvalidSeller.IsSuccess)
        //{
            if (resultDto.IsSuccess)
            {
                resultDto = imps.SavePaddyStockInfo(txtSellerPaddyStock.SelectedValue, ddlPaddyType.SelectedValue, ddlGodownname.SelectedValue, ddlLotDetails.SelectedValue, ddlUnitsType.SelectedValue, txtVehicalNo.Text.Trim(), txtDriverName.Text.Trim(), txtTotalBags.Text.ConvertToInt(), txtPricePerQuintal.Text.ConvertToDouble(), Convert.ToDateTime(txtPruchaseDate.Text.Trim()),ddlUnitsType.SelectedItem.Text.ConvertToInt());

                SetMessage(resultDto);
                if (resultDto.IsSuccess)
                {
                    ClearAllPaddyStockFields();
                    //bindPaddyStockInfo();
                }
            }
            else
            {
                SetMessage(resultDto);
            }
        //}
        //else
        //    SetMessage(resultDto);
    }
    //protected void rptPaddyStockInfo_PageIndexChanging(object sender, GridViewPageEventArgs e)
    //{
    //    rptPaddyStockInfo.PageIndex = gridPageIndex = e.NewPageIndex;
    //    bindPaddyStockInfo();
    //    TabContainer1.ActiveViewIndex = 2;
    //}
    //protected void rptPaddyStockInfo_Sorting(object sender, GridViewSortEventArgs e)
    //{
    //    if (expression == SortExpression.Asc)
    //        expression = SortExpression.Desc;
    //    else if (expression == SortExpression.Desc)
    //        expression = SortExpression.Asc;
    //    bindPaddyStockInfo();
    //    TabContainer1.ActiveViewIndex = 2;
    //}
    protected void gvPaddyStockOverview_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvPaddyStockOverview.PageIndex = gridPageIndex = e.NewPageIndex;
        BindPaddyStockOverView();
    }
    protected void gvPaddyStockOverview_Sorting(object sender, GridViewSortEventArgs e)
    {
        if (expression == SortExpression.Asc)
            expression = SortExpression.Desc;
        else if (expression == SortExpression.Desc)
            expression = SortExpression.Asc;
        BindPaddyStockOverView();
    }
    private void ClearAllPaddyStockFields()
    {
        txtSellerPaddyStock.Text = string.Empty;
        ddlPaddyType.SelectedIndex = 0;
        ddlGodownname.SelectedIndex = 0;
        ddlLotDetails.SelectedIndex = 0;
        ddlUnitsType.SelectedIndex = 0;
        txtVehicalNo.Text = string.Empty;
        txtDriverName.Text = string.Empty;
        txtTotalBags.Text = string.Empty;
        txtPricePerQuintal.Text = string.Empty;
        txtPruchaseDate.Text = string.Empty;
    }

}