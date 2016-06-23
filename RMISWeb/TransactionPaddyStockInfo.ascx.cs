using System;
using RMIS.Binder.BackEnd;
using RMIS.Domain.Business;
using RMIS.Domain.DataTranserClass;
using System.Web.UI.WebControls;
using AllInOne.Common.Library.Util;

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

            bindPaddyStockInfo();
        }
    }

    protected void TabContainer1_ActiveTabChanged(object sender, EventArgs e)
    {

    }


    private void bindPaddyStockInfo()
    {
        int count = 0;
        ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
        rptPaddyStockInfo.DataSource = imp.GetPaddyStockDTO(rptPaddyStockInfo.PageIndex, rptPaddyStockInfo.PageSize, out count, expression);
        rptPaddyStockInfo.VirtualItemCount = count;
        rptPaddyStockInfo.DataBind();
    }

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
        TabContainer1.ActiveTabIndex = 0;
    }

    protected void btnSellerDetails_Click(object sender, EventArgs e)
    {
        ITransactionBusiness impt = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
        //ResultDTO isvalidSeller = impt.CheckISValidSeller(TextBoxAutoExtender2.SelectedValue,TextBoxAutoExtender2.Text.Trim());
        //if (isvalidSeller.IsSuccess)
        //{
            txtTotalAmountDue.Text = Convert.ToString(impt.GetPaddyTotalAmountDueBySeller(TextBoxAutoExtender2.SelectedValue));
            TabContainer1.ActiveTabIndex = 1;
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
        ResultDTO resultDto = impp.SavePaddyPaymentDetails(TextBoxAutoExtender2.SelectedValue, txtamountpaid.Text.ConvertToDouble(), txtPaidDate.Text.ConvertToDate(), txtHandoverto.Text, txtNextpaymentdate.Text.ConvertToDate(), null, rbtPaymnetMode.SelectedValue, txtChequeNo.Text, txtBankName.Text);
        if (resultDto.IsSuccess)
        {
            ClearAllPaddyPaymentFields();
            TabContainer1.ActiveTabIndex = 1;
        }
        SetMessage(resultDto);
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        double amtpaid = string.IsNullOrEmpty(txtamountpaid.Text.Trim()) ? 0 : txtamountpaid.Text.ConvertToDouble();
        ResultDTO resultDto = BinderSingleton.Instance.GetInstance<IValidateTransactionBusiness>().ValidatePaddyStockDetails(ddlGodownname.SelectedIndex, ddlLotDetails.SelectedIndex, ddlUnitsType.SelectedIndex, ddlPaddyType.SelectedIndex, TextBoxAutoExtender1.Text.Trim(), txtVehicalNo.Text, txtTotalBags.Text, txtPrice.Text, txtPruchaseDate.Text);
        ITransactionBusiness imps = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();

        
        //ResultDTO isvalidSeller = imps.CheckISValidSeller(TextBoxAutoExtender1.SelectedValue,TextBoxAutoExtender1.Text.Trim());
        //if (isvalidSeller.IsSuccess)
        //{
            if (resultDto.IsSuccess)
            {
                resultDto = imps.SavePaddyStockInfo(TextBoxAutoExtender1.SelectedValue, ddlPaddyType.SelectedValue, ddlGodownname.SelectedValue, ddlLotDetails.SelectedValue, ddlUnitsType.SelectedValue, txtVehicalNo.Text.Trim(), txtDriverName.Text.Trim(), txtTotalBags.Text.ConvertToInt(), txtPrice.Text.ConvertToDouble(), Convert.ToDateTime(txtPruchaseDate.Text.Trim()));

                SetMessage(resultDto);
                if (resultDto.IsSuccess)
                {
                    ClearAllPaddyStockFields();
                    bindPaddyStockInfo();
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
    protected void rptPaddyStockInfo_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        rptPaddyStockInfo.PageIndex = gridPageIndex = e.NewPageIndex;
        bindPaddyStockInfo();
    }



    private void ClearAllPaddyStockFields()
    {
        ddlPaddyType.SelectedIndex = 0;
        ddlGodownname.SelectedIndex = 0;
        ddlLotDetails.SelectedIndex = 0;
        ddlUnitsType.SelectedIndex = 0;
        txtVehicalNo.Text = string.Empty;
        txtDriverName.Text = string.Empty;
        txtTotalBags.Text = string.Empty;
        txtPrice.Text = string.Empty;
        txtPruchaseDate.Text = string.Empty;
    }

}