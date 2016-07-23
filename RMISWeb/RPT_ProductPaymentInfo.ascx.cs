using System;
using RMIS.Binder.BackEnd;
using RMIS.Domain.Business;
using RMIS.Domain.DataTranserClass;
using Microsoft.Reporting.WebForms;
using RMIS.Domain.Constant;
using System.Collections.Generic;
using AllInOne.Common.Library.Util;

public partial class RPT_ProductPaymentInfo : BaseUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        base.Header = "Product Payment Details";
        if (!IsControlPostBack)
        {

            List<ProductPaymentDTO> listProductPaymentDTO = GetAllProductPayment();
            BindReport(listProductPaymentDTO);
        }
    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
        int count;
        List<ProductPaymentDTO> listProductPaymentDTO = imp.GetProductPaymentDTO(txtMediatorName.SelectedValue, txtBuyerName.SelectedValue, 0, 1000, out count, SortExpression.Desc);
        BindReport(listProductPaymentDTO);
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        txtBuyerName.Text = string.Empty;
        List<ProductPaymentDTO> lstProductPaymentDTO = GetAllProductPayment();
        BindReport(lstProductPaymentDTO);
    }
    private List<ProductPaymentDTO> GetAllProductPayment()
    {
        ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
        int count;
        List<ProductPaymentDTO> listProductPaymentDTO = imp.GetProductPaymentDTO(0, 1000, out count, SortExpression.Desc);
        return listProductPaymentDTO;
    }
    private void BindReport(List<ProductPaymentDTO> listProductPaymentDTO)
    {
        ReportViewer1.ProcessingMode = ProcessingMode.Local;
        if (listProductPaymentDTO != null && listProductPaymentDTO.Count > 0)
        {
            ReportViewer1.Visible = true;
            lblreportnodata.Visible = false;
            lblreportnodata.Text = string.Empty;
            ReportDataSource datasource = null;
            datasource = new ReportDataSource("ProductPayment", CollectionHelper.ConvertTo<ProductPaymentDTO>(listProductPaymentDTO));

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