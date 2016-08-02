using System;
using RMIS.Binder.BackEnd;
using RMIS.Domain.Business;
using RMIS.Domain.DataTranserClass;
using System.Collections.Generic;
using RMIS.Domain.Constant;
using Microsoft.Reporting.WebForms;
using AllInOne.Common.Library.Util;

public partial class RPT_ProductPaymentDue : BaseUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        base.Header = "Product Payment Due Details";
        if (!IsControlPostBack)
        {

            List<ProductPaymentDueDTO> listProductPaymentDueDTO = GetAllProductPaymentDue();
            BindReport(listProductPaymentDueDTO);
        }
    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
        int count;
        List<ProductPaymentDueDTO> listProductPaymentDueDTO = imp.GetProductPaymentDueDTO(txtMediatorName.SelectedValue, txtBuyerName.SelectedValue, 0, 1000, out count, SortExpression.Desc);
        BindReport(listProductPaymentDueDTO);
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        txtBuyerName.Text = string.Empty;
        List<ProductPaymentDueDTO> lstProductPaymentDueDTO = GetAllProductPaymentDue();
        BindReport(lstProductPaymentDueDTO);
    }
    private List<ProductPaymentDueDTO> GetAllProductPaymentDue()
    {
        ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
        int count;
        List<ProductPaymentDueDTO> listProductPaymentDueDTO = imp.GetProductPaymentDueDTO(0, 1000, out count, SortExpression.Desc);
        return listProductPaymentDueDTO;
    }
    private void BindReport(List<ProductPaymentDueDTO> listProductPaymentDueDTO)
    {
        ReportViewer1.ProcessingMode = ProcessingMode.Local;
        if (listProductPaymentDueDTO != null && listProductPaymentDueDTO.Count > 0)
        {
            ReportViewer1.Visible = true;
            lblreportnodata.Visible = false;
            lblreportnodata.Text = string.Empty;
            ReportDataSource datasource = null;
            datasource = new ReportDataSource("ProductPaymentDue", CollectionHelper.ConvertTo<ProductPaymentDueDTO>(listProductPaymentDueDTO));

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