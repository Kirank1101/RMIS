using System;
using RMIS.Binder.BackEnd;
using RMIS.Domain.Business;
using RMIS.Domain.DataTranserClass;
using Microsoft.Reporting.WebForms;
using RMIS.Domain.Constant;

using System.Collections.Generic;
using AllInOne.Common.Library.Util;

public partial class RPT_ProductSellingReport : BaseUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        base.Header = "Product Selling Details";
        if (!IsControlPostBack)
        {

            List<ProductSellingInfoDTO> listProductSellingInfoDTO = GetAllProductSellingInfo();
            BindReport(listProductSellingInfoDTO);
        }
    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
        int count;
        List<ProductSellingInfoDTO> listProductSellingInfoDTO = imp.GetProductSellingInfoDTO(txtBuyerNames.SelectedValue, 0, 1000, out count, SortExpression.Desc);
        BindReport(listProductSellingInfoDTO);
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        txtBuyerNames.Text = string.Empty;
        List<ProductSellingInfoDTO> lstProductSellingInfoDTO = GetAllProductSellingInfo();
        BindReport(lstProductSellingInfoDTO);
    }
    private List<ProductSellingInfoDTO> GetAllProductSellingInfo()
    {
        ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
        int count;
        List<ProductSellingInfoDTO> listProductSellingInfoDTO = imp.GetProductSellingInfoDTO(0, 1000, out count, SortExpression.Desc);
        return listProductSellingInfoDTO;
    }
    private void BindReport(List<ProductSellingInfoDTO> listProductSellingInfoDTO)
    {
        ReportViewer1.ProcessingMode = ProcessingMode.Local;
        if (listProductSellingInfoDTO != null && listProductSellingInfoDTO.Count > 0)
        {
            ReportDataSource datasource = new ReportDataSource("ProductSelling", CollectionHelper.ConvertTo<ProductSellingInfoDTO>(listProductSellingInfoDTO));

            ReportViewer1.AsyncRendering = false;
            ReportViewer1.LocalReport.DataSources.Clear();
            ReportViewer1.LocalReport.DataSources.Add(datasource);

            ReportViewer1.LocalReport.Refresh();


        }
    }
}