using System;
using RMIS.Binder.BackEnd;
using RMIS.Domain.Business;
using RMIS.Domain.DataTranserClass;
using Microsoft.Reporting.WebForms;
using RMIS.Domain.Constant;
using System.Collections.Generic;
using AllInOne.Common.Library.Util;

public partial class RPT_BagPaymentInfo : BaseUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        base.Header = "Bag Payment Details";
        if (!IsControlPostBack)
        {

            List<BagPaymentDTO> listBagPaymentDTO = GetAllBagPayment();
            BindReport(listBagPaymentDTO);
        }
    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
        int count;
        List<BagPaymentDTO> listBagPaymentDTO = imp.GetBagPaymentDTO(txtsellername.SelectedValue, 0, 1000, out count, SortExpression.Desc);
        BindReport(listBagPaymentDTO);
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        txtsellername.Text = string.Empty;
        List<BagPaymentDTO> lstBagPaymentDTO = GetAllBagPayment();
        BindReport(lstBagPaymentDTO);
    }
    private List<BagPaymentDTO> GetAllBagPayment()
    {
        ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
        int count;
        List<BagPaymentDTO> listBagPaymentDTO = imp.GetBagPaymentDTO(0, 1000, out count, SortExpression.Desc);
        return listBagPaymentDTO;
    }
    private void BindReport(List<BagPaymentDTO> listBagPaymentDTO)
    {
        ReportViewer1.ProcessingMode = ProcessingMode.Local;
        if (listBagPaymentDTO != null && listBagPaymentDTO.Count > 0)
        {
            ReportViewer1.Visible = true;
            lblreportnodata.Visible = false;
            lblreportnodata.Text = string.Empty;
            ReportDataSource datasource = null;
            datasource = new ReportDataSource("BagPayment", CollectionHelper.ConvertTo<BagPaymentDTO>(listBagPaymentDTO));
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