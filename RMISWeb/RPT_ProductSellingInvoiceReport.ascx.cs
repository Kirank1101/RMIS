using System;
using RMIS.Binder.BackEnd;
using RMIS.Domain.Business;
using RMIS.Domain.DataTranserClass;
using Microsoft.Reporting.WebForms;
using RMIS.Domain.Constant;

using System.Collections.Generic;
using AllInOne.Common.Library.Util;
using System.Web.UI.WebControls;

public partial class RPT_ProductSellingInvoiceReport : BaseUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        base.Header = "Paddy Payment Receipt Details";
        if (!IsControlPostBack)
        {
            ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
            List<ProductSellingInfoDTO> listProductSellingInfoDTO = GetAllProductSellingInfoInvoic();
            bindProductSellingInfoInvoice(listProductSellingInfoDTO);
            BindReport(null);
        }
    }

    private void bindProductSellingInfoInvoice(List<ProductSellingInfoDTO> listProductSellingInfoDTO)
    {
        //int count = 0;
        rptProductSellingInvoicInfo.DataSource = listProductSellingInfoDTO;
        //rptProductSellingInvoicInfo.VirtualItemCount = count;
        rptProductSellingInvoicInfo.DataBind();
    }
    private List<ProductSellingInfoDTO> GetAllProductSellingInfoInvoic()
    {
        ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
        int count;
        List<ProductSellingInfoDTO> listProductSellingInfoDTO = imp.GetProductSellingInfoDTOforInvoice(0, 1000, out count, SortExpression.Desc);
        return listProductSellingInfoDTO;
    }
    protected void rptProductSellingInvoicInfo_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        rptProductSellingInvoicInfo.PageIndex = gridPageIndex = e.NewPageIndex;
        ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
        List<ProductSellingInfoDTO> listProductSellingInfoDTO = GetAllProductSellingInfoInvoic();
        bindProductSellingInfoInvoice(listProductSellingInfoDTO);
    }
    protected void rptProductSellingInvoicInfo_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "PrintReceipt")
        {
            int rowindex = Convert.ToInt32(e.CommandArgument);
            GridViewRow row = rptProductSellingInvoicInfo.Rows[rowindex];
            string MediatorName = row.Cells[0].Text;
            string BuyerName = row.Cells[1].Text;
            
            string ProductID = rptProductSellingInvoicInfo.DataKeys[rowindex].Value.ToString();
            ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
            List<ProductSellingInvoiceDTO> lstPSIDTO = imp.GetProductSellingInvoiceDTO(ProductID);
            if (lstPSIDTO != null &&lstPSIDTO.Count>0)
                BindReport(lstPSIDTO);
            else
                BindReport(null);
        }
    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {

        ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
        int count;
        List<ProductSellingInfoDTO> listProductSellingInfoDTO = imp.GetProductSellingInfoDTOforInvoice(txtMediatorName.SelectedValue, txtBuyerNames.SelectedValue, 0, 1000, out count, SortExpression.Desc);
        bindProductSellingInfoInvoice(listProductSellingInfoDTO);
        BindReport(null);
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        txtBuyerNames.Text = string.Empty;
        txtMediatorName.Text = string.Empty;
        ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
        List<ProductSellingInfoDTO> listProductSellingInfoDTO = GetAllProductSellingInfoInvoic();

        bindProductSellingInfoInvoice(listProductSellingInfoDTO);
        BindReport(null);
    }
    private void BindReport(List<ProductSellingInvoiceDTO> listProductSellingInvoiceDTO)
    {
        ReportViewer1.ProcessingMode = ProcessingMode.Local;
        if (listProductSellingInvoiceDTO != null && listProductSellingInvoiceDTO.Count > 0)
        {
            ReportViewer1.Visible = true;
            lblreportnodata.Visible = false;
            lblreportnodata.Text = string.Empty;
            ReportDataSource datasource = new ReportDataSource("ProductSellingInvoiceDS", CollectionHelper.ConvertTo<ProductSellingInvoiceDTO>(listProductSellingInvoiceDTO));

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