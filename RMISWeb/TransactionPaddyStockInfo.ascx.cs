using System;
using RMIS.Binder.BackEnd;
using RMIS.Domain.Business;
using RMIS.Domain.DataTranserClass;
using System.Web.UI.WebControls;
using RMIS.Domain.Constant;

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
            //base.Header = "Paddy Stock Information";
         
            

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
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        double amtpaid = string.IsNullOrEmpty(txtamountpaid.Text.Trim()) ? 0 : Convert.ToDouble(txtamountpaid.Text.Trim());
        ResultDTO resultDto = BinderSingleton.Instance.GetInstance<IValidateTransactionBusiness>().ValidatePaddyStockDetails(ddlGodownname.SelectedIndex, ddlLotDetails.SelectedIndex, ddlUnitsType.SelectedIndex, ddlPaddyType.SelectedIndex, 1, txtVehicalNo.Text, txtTotalBags.Text, txtPrice.Text, txtPruchaseDate.Text, rbtPaymnetMode.SelectedValue, txtChequeNo.Text.Trim(), txtBankName.Text.Trim(), Convert.ToDouble(amtpaid), txtPaidDate.Text.Trim(), txtHandoverto.Text.Trim(), txtNextpaymentdate.Text.Trim());

        if (resultDto.IsSuccess)
        {
            ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
            resultDto = imp.SavePaddyStockInfo(TextBoxAutoExtender1.SelectedValue, ddlPaddyType.SelectedValue, ddlGodownname.SelectedValue, ddlLotDetails.SelectedValue, ddlUnitsType.SelectedValue, txtVehicalNo.Text.Trim(), txtDriverName.Text.Trim(), Convert.ToDecimal(txtTotalBags.Text.Trim()), Convert.ToDecimal(txtPrice.Text.Trim()), Convert.ToDateTime(txtPruchaseDate.Text.Trim())
                , Convert.ToDouble(txtamountpaid.Text.Trim()), Convert.ToDateTime(txtPaidDate.Text.Trim()), txtHandoverto.Text.Trim(),
                Convert.ToDateTime(txtNextpaymentdate.Text.Trim()), rbtPaymnetMode.SelectedValue, txtChequeNo.Text.Trim(), txtBankName.Text.Trim());

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