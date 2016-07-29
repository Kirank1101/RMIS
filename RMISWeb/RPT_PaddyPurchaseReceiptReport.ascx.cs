using System;
using RMIS.Binder.BackEnd;
using RMIS.Domain.Business;
using RMIS.Domain.DataTranserClass;
using Microsoft.Reporting.WebForms;
using RMIS.Domain.Constant;

using System.Collections.Generic;
using AllInOne.Common.Library.Util;
using System.Web.UI.WebControls;

public partial class RPT_PaddyPurchaseReceiptReport : BaseUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        base.Header = "Paddy Purchase Receipt Details";
        if (!IsControlPostBack)
        {
            bindPaddyStockInfo();
        }
    }
    private void bindPaddyStockInfo()
    {
        int count = 0;
        ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
        rptPaddyStockInfo.DataSource = imp.GetPaddyPurchaseDTO(rptPaddyStockInfo.PageIndex, rptPaddyStockInfo.PageSize, out count, expression);
        rptPaddyStockInfo.VirtualItemCount = count;
        rptPaddyStockInfo.DataBind();
    }
    protected void rptPaddyStockInfo_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        rptPaddyStockInfo.PageIndex = gridPageIndex = e.NewPageIndex;
        bindPaddyStockInfo();
    }

    protected void rptPrintReceipt_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "PayAmount")
        {
            int rowindex = Convert.ToInt32(e.CommandArgument);
            GridViewRow row = rptPaddyStockInfo.Rows[rowindex];
            string PaddyStockId = rptPaddyStockInfo.DataKeys[rowindex].Value.ToString();
            ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
            PaddyPurchaseReceiptDTO PPRDTO = imp.GetPaddyPurchaseReceiptDTO(PaddyStockId);
            if (PPRDTO != null)
            {
                List<PaddyPurchaseReceiptDTO> lstPPRDTO = new List<PaddyPurchaseReceiptDTO>();
                lstPPRDTO.Add(PPRDTO);
                BindReport(lstPPRDTO);
            }
            else
                BindReport(null);
        }
    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        ResultDTO resultDto = BinderSingleton.Instance.GetInstance<IValidateTransactionBusiness>().ValidatePaddyStockReport(txtsellername.Text.Trim(), txtPruchaseDatefrom.Text.Trim(), txtPruchaseDateTo.Text.Trim());
        if (resultDto.IsSuccess)
        {
            ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
            int count;
            List<PaddyStockDTO> listPaddyStockDTO = imp.GetPaddyStockPurchaseDTO(txtsellername.SelectedValue, 0, 1000, out count, SortExpression.Desc, txtPruchaseDatefrom.Text.ConvertToDate(), txtPruchaseDateTo.Text.ConvertToDate());
            //BindReport(listPaddyStockDTO);
        }
        else
        {
            SetMessage(resultDto);
        }
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        txtsellername.Text = string.Empty;
        List<PaddyStockDTO> lstpaddystockDTO = GetAllPaddyStock();
        //BindReport(lstpaddystockDTO);
    }
    private List<PaddyStockDTO> GetAllPaddyStock()
    {
        ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
        int count;
        List<PaddyStockDTO> listPaddyStockDTO = imp.GetPaddyStockDTO(0, 1000, out count, SortExpression.Desc);
        return listPaddyStockDTO;
    }
    private void BindReport(List<PaddyPurchaseReceiptDTO> listPaddyPurchaseReceiptDTO)
    {
        ReportViewer1.ProcessingMode = ProcessingMode.Local;
        if (listPaddyPurchaseReceiptDTO != null && listPaddyPurchaseReceiptDTO.Count > 0)
        {
            ReportViewer1.Visible = true;
            lblreportnodata.Visible = false;
            lblreportnodata.Text = string.Empty;
            ReportDataSource datasource = new ReportDataSource("PaddyPurchaseBillDS", CollectionHelper.ConvertTo<PaddyPurchaseReceiptDTO>(listPaddyPurchaseReceiptDTO));

            ReportViewer1.AsyncRendering = false;
            ReportViewer1.LocalReport.DataSources.Clear();
            ReportViewer1.LocalReport.DataSources.Add(datasource);
            ReportViewer1.LocalReport.Refresh();
        }
        else
        {
            ReportViewer1.Visible = false;
            lblreportnodata.Visible = true;
            lblreportnodata.Text = "No Data Available";
            lblreportnodata.ForeColor = System.Drawing.Color.LightBlue;
            lblreportnodata.Font.Size = 22;
        }
    }
}