using System;
using RMIS.Binder.BackEnd;
using RMIS.Domain.Business;
using RMIS.Domain.DataTranserClass;
using Microsoft.Reporting.WebForms;
using RMIS.Domain.Constant;
using System.Collections.Generic;
using AllInOne.Common.Library.Util;

public partial class RPT_PaddyPaymentInfo : BaseUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        base.Header = "Paddy Payment Details";
        if (!IsControlPostBack)
        {

            List<PaddyPaymentDTO> listPaddyPaymentDTO = GetAllPaddyPayment();
            BindReport(listPaddyPaymentDTO);
        }
    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
        int count;
        List<PaddyPaymentDTO> listPaddyPaymentDTO = imp.GetPaddyPaymentDTO(txtsellername.SelectedValue, 0, 1000, out count, SortExpression.Desc);
        BindReport(listPaddyPaymentDTO);
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        txtsellername.Text = string.Empty;
        List<PaddyPaymentDTO> lstPaddyPaymentDTO = GetAllPaddyPayment();
        BindReport(lstPaddyPaymentDTO);
    }
    private List<PaddyPaymentDTO> GetAllPaddyPayment()
    {
        ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
        int count;
        List<PaddyPaymentDTO> listPaddyPaymentDTO = imp.GetPaddyPaymentDTO(0, 1000, out count, SortExpression.Desc);
        return listPaddyPaymentDTO;
    }
    private void BindReport(List<PaddyPaymentDTO> listPaddyPaymentDTO)
    {
        ReportViewer1.ProcessingMode = ProcessingMode.Local;
        if (listPaddyPaymentDTO != null && listPaddyPaymentDTO.Count > 0)
        {
            ReportDataSource datasource = new ReportDataSource("PaddyPayment", CollectionHelper.ConvertTo<PaddyPaymentDTO>(listPaddyPaymentDTO));

            ReportViewer1.AsyncRendering = false;
            ReportViewer1.LocalReport.DataSources.Clear();
            ReportViewer1.LocalReport.DataSources.Add(datasource);

            ReportViewer1.LocalReport.Refresh();


        }
    }
}