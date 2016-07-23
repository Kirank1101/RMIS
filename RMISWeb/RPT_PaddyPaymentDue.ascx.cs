using System;
using RMIS.Binder.BackEnd;
using RMIS.Domain.Business;
using RMIS.Domain.DataTranserClass;
using System.Collections.Generic;
using RMIS.Domain.Constant;
using Microsoft.Reporting.WebForms;
using AllInOne.Common.Library.Util;

public partial class RPT_PaddyPaymentDue : BaseUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        base.Header = "Paddy Payment Due Details";
        if (!IsControlPostBack)
        {

            List<PaddyPaymentDueDTO> listPaddyPaymentDueDTO = GetAllPaddyPaymentDue();
            BindReport(listPaddyPaymentDueDTO);
        }
    }
    private List<PaddyPaymentDueDTO> GetAllPaddyPaymentDue()
    {
        ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
        int count;
        List<PaddyPaymentDueDTO> listPaddyPaymentDueDTO = imp.GetPaddyPaymentDueDTO(0, 1000, out count, SortExpression.Desc);
        return listPaddyPaymentDueDTO;
    }
    private void BindReport(List<PaddyPaymentDueDTO> listPaddyPaymentDueDTO)
    {
        ReportViewer1.ProcessingMode = ProcessingMode.Local;
        if (listPaddyPaymentDueDTO != null && listPaddyPaymentDueDTO.Count > 0)
        {
            ReportViewer1.Visible = true;
            lblreportnodata.Visible = false;
            lblreportnodata.Text = string.Empty;
            ReportDataSource datasource = new ReportDataSource("PaddyPaymentDue", CollectionHelper.ConvertTo<PaddyPaymentDueDTO>(listPaddyPaymentDueDTO));

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