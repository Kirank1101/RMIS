using System;
using RMIS.Binder.BackEnd;
using RMIS.Domain.Business;
using RMIS.Domain.DataTranserClass;
using Microsoft.Reporting.WebForms;
using RMIS.Domain.Constant;

using System.Collections.Generic;
using AllInOne.Common.Library.Util;

public partial class RPT_BagStockReport : BaseUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        base.Header = "Bag Stock Purchase Details";
        if (!IsControlPostBack)
        {

            List<BagStockDTO> listBagStockDTO = GetAllBagStock();
            BindReport(listBagStockDTO);
        }
    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
        int count;
        List<BagStockDTO> listBagStockDTO = imp.GetBagStockPurchaseDTO(txtsellername.SelectedValue, 0, 1000, out count, SortExpression.Desc);
        BindReport(listBagStockDTO);
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        txtsellername.Text = string.Empty;
        List<BagStockDTO> lstBagstockDTO = GetAllBagStock();
        BindReport(lstBagstockDTO);
    }
    private List<BagStockDTO> GetAllBagStock()
    {
        ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
        int count;
        List<BagStockDTO> listBagStockDTO = imp.GetBagStockDTO(0, 1000, out count, SortExpression.Desc);
        return listBagStockDTO;
    }
    private void BindReport(List<BagStockDTO> listBagStockDTO)
    {
        ReportViewer1.ProcessingMode = ProcessingMode.Local;
        if (listBagStockDTO != null && listBagStockDTO.Count > 0)
        {
            ReportViewer1.Visible = true;
            lblreportnodata.Visible = false;
            lblreportnodata.Text = string.Empty;
            ReportDataSource datasource = new ReportDataSource("BagStockTransaction", CollectionHelper.ConvertTo<BagStockDTO>(listBagStockDTO));

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