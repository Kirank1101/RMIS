using System;
using RMIS.Binder.BackEnd;
using RMIS.Domain.Business;
using RMIS.Domain.DataTranserClass;
using Microsoft.Reporting.WebForms;
using RMIS.Domain.Constant;

using System.Collections.Generic;
using AllInOne.Common.Library.Util;
using System.Web.UI.WebControls;

public partial class RPT_PaddyPaymentReceiptReport : BaseUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        base.Header = "Paddy Payment Receipt Details";
        if (!IsControlPostBack)
        {
            ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
            List<PaddyPaymentDTO> listPaddyPaymentDTO = GetAllPaddyPayment();

            bindPaddyPaymentInfo(listPaddyPaymentDTO);
            BindReport(null);
        }
    }

    private void bindPaddyPaymentInfo(List<PaddyPaymentDTO> listPaddyPaymentDTO)
    {
        //int count = 0;
        rptPaddyPaymentInfo.DataSource = listPaddyPaymentDTO;
        //rptPaddyPaymentInfo.VirtualItemCount = count;
        rptPaddyPaymentInfo.DataBind();
    }
    private List<PaddyPaymentDTO> GetAllPaddyPayment()
    {
        ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
        int count;
        List<PaddyPaymentDTO> listPaddyPaymentDTO = imp.GetPaddyPaymentDTO(0, 1000, out count, SortExpression.Desc);
        return listPaddyPaymentDTO;
    }
    protected void rptPaddyPaymentInfo_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        rptPaddyPaymentInfo.PageIndex = gridPageIndex = e.NewPageIndex;
        ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
        List<PaddyPaymentDTO> listPaddyPaymentDTO = GetAllPaddyPayment();
        bindPaddyPaymentInfo(listPaddyPaymentDTO);
    }
    protected void rptPaddyPaymentInfo_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "PrintReceipt")
        {
            int rowindex = Convert.ToInt32(e.CommandArgument);
            GridViewRow row = rptPaddyPaymentInfo.Rows[rowindex];
            string PaddyPaymentIDId = rptPaddyPaymentInfo.DataKeys[rowindex].Value.ToString();
            ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
            PaddyPaymentReceiptDTO PPRDTO = imp.GetPaddyPaymentReceiptDTO(PaddyPaymentIDId);
            if (PPRDTO != null)
            {
                List<PaddyPaymentReceiptDTO> lstPPRDTO = new List<PaddyPaymentReceiptDTO>();
                lstPPRDTO.Add(PPRDTO);
                BindReport(lstPPRDTO);
            }
            else
                BindReport(null);
        }
    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {

        ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
        int count;
        List<PaddyPaymentDTO> listPaddyPaymentDTO = imp.GetPaddyPaymentDTO(txtsellername.SelectedValue, 0, 1000, out count, SortExpression.Desc);
        bindPaddyPaymentInfo(listPaddyPaymentDTO);
        BindReport(null);
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        txtsellername.Text = string.Empty; 
        ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
        List<PaddyPaymentDTO> listPaddyPaymentDTO = GetAllPaddyPayment();

        bindPaddyPaymentInfo(listPaddyPaymentDTO);
        BindReport(null);
    }    
    private void BindReport(List<PaddyPaymentReceiptDTO> listPaddyPaymentReceiptDTO)
    {
        ReportViewer1.ProcessingMode = ProcessingMode.Local;
        if (listPaddyPaymentReceiptDTO != null && listPaddyPaymentReceiptDTO.Count > 0)
        {
            ReportViewer1.Visible = true;
            lblreportnodata.Visible = false;
            lblreportnodata.Text = string.Empty;
            ReportDataSource datasource = new ReportDataSource("PaddyPaymentBill", CollectionHelper.ConvertTo<PaddyPaymentReceiptDTO>(listPaddyPaymentReceiptDTO));

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