using System;
using RMIS.Binder.BackEnd;
using RMIS.Domain.Business;
using RMIS.Domain.DataTranserClass;
using System.Web.UI.WebControls;
using RMIS.Domain.Constant;
using AllInOne.Common.Library.Util;

public partial class TransactionPaddyStockInfo : BaseUserControl
{
    protected override void OnInit(EventArgs e)
    {
        base.OnInit(e);        
    }
    protected void Page_Load(object sender, EventArgs e)
    {       
        
        if (!IsControlPostBack)
        {
            base.Header = "";

            IMasterPaddyBusiness impb = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
            ddlPaddyType.DataSource = impb.GetMPaddyTypeEntities();
            ddlPaddyType.DataTextField = "PaddyType";
            ddlPaddyType.DataValueField = "Id";
            ddlPaddyType.DataBind();

            IMasterPaddyBusiness impb1 = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
            ddlGodownname.DataSource = impb1.GetMGodownTypeEntities();
            ddlGodownname.DataTextField = "GodownType";
            ddlGodownname.DataValueField = "Id";
            ddlGodownname.DataBind();

            IMasterPaddyBusiness impb2 = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
            ddlUnitsType.DataSource = impb2.GetMUnitsTypeEntities();
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
        IMasterPaddyBusiness impb = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();

        if (ddlGodownname.SelectedIndex > -1)
        {
            ddlLotDetails.Items.Clear();
            ddlLotDetails.Items.Insert(0, "[Select]");
            ddlLotDetails.DataSource = impb.GetLotDetailsEntities(ddlGodownname.SelectedValue);
            ddlLotDetails.DataTextField = "LotDetails";
            ddlLotDetails.DataValueField = "Id";
            ddlLotDetails.DataBind();
        }
        TabContainer1.ActiveTabIndex = 0;
    }

    protected void btnSellerDetails_Click(object sender, EventArgs e)
    {
        ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
        txtbalanceamount.Text=Convert.ToString( imp.GetPaddyTotalAmountDueBySeller(TextBoxAutoExtender2.SelectedValue));
        TabContainer1.ActiveTabIndex = 1;

    }


    protected void btnPay_Click(object sender, EventArgs e)
    {
         ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
         ResultDTO resultDto = imp.SavePaddyPaymentDetails(TextBoxAutoExtender2.SelectedValue, txtamountpaid.Text.ConvertToDouble(), txtPaidDate.Text.ConvertToDate(), txtHandoverto.Text, txtNextpaymentdate.Text.ConvertToDate(), null, rbtPaymnetMode.SelectedValue, txtChequeNo.Text, txtBankName.Text);
         TabContainer1.ActiveTabIndex = 1;
         SetMessage(resultDto);
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        double amtpaid = string.IsNullOrEmpty(txtamountpaid.Text.Trim()) ? 0 : txtamountpaid.Text.ConvertToDouble();
        ResultDTO resultDto = BinderSingleton.Instance.GetInstance<IValidateTransactionBusiness>().ValidatePaddyStockDetails(ddlGodownname.SelectedIndex, ddlLotDetails.SelectedIndex, ddlUnitsType.SelectedIndex, ddlPaddyType.SelectedIndex, 1, txtVehicalNo.Text, txtTotalBags.Text, txtPrice.Text, txtPruchaseDate.Text);
            //rbtPaymnetMode.SelectedValue, txtChequeNo.Text.Trim(), txtBankName.Text.Trim(), amtpaid, txtPaidDate.Text.Trim(), txtHandoverto.Text.Trim(), txtNextpaymentdate.Text.Trim());

        if (resultDto.IsSuccess)
        {
            ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
            resultDto = imp.SavePaddyStockInfo(TextBoxAutoExtender1.SelectedValue, ddlPaddyType.SelectedValue, ddlGodownname.SelectedValue, ddlLotDetails.SelectedValue, ddlUnitsType.SelectedValue, txtVehicalNo.Text.Trim(), txtDriverName.Text.Trim(), txtTotalBags.Text.ConvertToInt(), txtPrice.Text.ConvertToDouble(), Convert.ToDateTime(txtPruchaseDate.Text.Trim()));
               // , Convert.ToDouble(txtamountpaid.Text.Trim()), Convert.ToDateTime(txtPaidDate.Text.Trim()), txtHandoverto.Text.Trim(),
               // Convert.ToDateTime(txtNextpaymentdate.Text.Trim()), rbtPaymnetMode.SelectedValue, txtChequeNo.Text.Trim(), txtBankName.Text.Trim());

            SetMessage(resultDto);
            if (resultDto.IsSuccess)
                ClearAllInputFields();
            bindPaddyStockInfo();
        }
        else
        {
            SetMessage(resultDto);
        }

    }
    protected void rptPaddyStockInfo_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        rptPaddyStockInfo.PageIndex = gridPageIndex = e.NewPageIndex;
        bindPaddyStockInfo();
    }



    private void ClearAllInputFields()
    {
        ddlPaddyType.SelectedIndex = 0;      
        ddlGodownname.SelectedIndex = 0;
        ddlLotDetails.SelectedIndex = 0;
        txtVehicalNo.Text = string.Empty;
        txtTotalBags.Text = string.Empty;
        txtPrice.Text = string.Empty;
        txtPruchaseDate.Text = string.Empty;
    }

}