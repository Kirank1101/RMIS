using System;
using RMIS.Binder.BackEnd;
using RMIS.Domain.Business;
using RMIS.Domain.DataTranserClass;
using Microsoft.Reporting.WebForms;
using RMIS.Domain.Constant;

using System.Collections.Generic;
using AllInOne.Common.Library.Util;

public partial class RPT_PaddyStockReport : BaseUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        base.Header = "Paddy Stock Purchase Details";
        if (!IsControlPostBack)
        {

            List<PaddyStockDTO> listPaddyStockDTO = GetAllPaddyStock();
            BindReport(listPaddyStockDTO);
        }
    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        ResultDTO resultDto = BinderSingleton.Instance.GetInstance<IValidateTransactionBusiness>().ValidatePaddyStockReport(txtsellername.Text.Trim(), txtPruchaseDatefrom.Text.Trim(), txtPruchaseDateTo.Text.Trim());
        if (resultDto.IsSuccess)
        {
            ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
            int count;
            List<PaddyStockDTO> listPaddyStockDTO = imp.GetPaddyStockPurchaseDTO(txtsellername.SelectedValue, 0, 1000, out count, SortExpression.Desc,txtPruchaseDatefrom.Text.ConvertToDate(),txtPruchaseDateTo.Text.ConvertToDate());
            BindReport(listPaddyStockDTO);
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
        BindReport(lstpaddystockDTO);
    }
    private List<PaddyStockDTO> GetAllPaddyStock()
    {
        ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
        int count;
        List<PaddyStockDTO> listPaddyStockDTO = imp.GetPaddyStockDTO(0, 1000, out count, SortExpression.Desc);
        return listPaddyStockDTO;
    }
    private void BindReport(List<PaddyStockDTO> listPaddyStockDTO)
    {
        ReportViewer1.ProcessingMode = ProcessingMode.Local;
        if (listPaddyStockDTO != null && listPaddyStockDTO.Count > 0)
        {
            ReportViewer1.Visible = true;
            lblreportnodata.Visible = false;
            lblreportnodata.Text = string.Empty;
            ReportDataSource datasource = new ReportDataSource("PaddyStock", CollectionHelper.ConvertTo<PaddyStockDTO>(listPaddyStockDTO));

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