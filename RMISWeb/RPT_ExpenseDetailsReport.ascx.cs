using System;
using RMIS.Binder.BackEnd;
using RMIS.Domain.Business;
using RMIS.Domain.DataTranserClass;
using Microsoft.Reporting.WebForms;
using RMIS.Domain.Constant;

using System.Collections.Generic;
using AllInOne.Common.Library.Util;

public partial class RPT_ExpenseDetailsReport : BaseUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        base.Header = "Expense Details";
        if (!IsControlPostBack)
        {

            List<ExpenseDetailsDTO> listExpenseDetailsDTO = GetExpenseDetails();
            BindReport(listExpenseDetailsDTO);
        }
    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        ResultDTO resultDto = BinderSingleton.Instance.GetInstance<IValidateTransactionBusiness>().ValidateBankTransReport(txtTransFromDate.Text.Trim(), txtTransToDate.Text.Trim());
        if (resultDto.IsSuccess)
        {
            ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
            int count;
            List<ExpenseDetailsDTO> listExpenseDetailsDTO = imp.GetExpenseDetailsDTO(txtTransFromDate.Text.ConvertToDate(), txtTransToDate.Text.ConvertToDate(), 0, 1000, out count, SortExpression.Desc);
            BindReport(listExpenseDetailsDTO);
        }
        else
        {
            SetMessage(resultDto);
        }
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        txtTransFromDate.Text = string.Empty;
        txtTransToDate.Text=string.Empty;
        List<ExpenseDetailsDTO> lstExpenseDetailsDTO = GetExpenseDetails();
        BindReport(lstExpenseDetailsDTO);
    }

    private List<ExpenseDetailsDTO> GetExpenseDetails()
    {
        ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
        int count;
        List<ExpenseDetailsDTO> listExpenseDetailsDTO = imp.GetExpenseDetailsDTO(0, 1000, out count, SortExpression.Desc);
        return listExpenseDetailsDTO;
    }
    private void BindReport(List<ExpenseDetailsDTO> listExpenseDetailsDTO)
    {
        ReportViewer1.ProcessingMode = ProcessingMode.Local;
        if (listExpenseDetailsDTO != null && listExpenseDetailsDTO.Count > 0)
        {
            ReportViewer1.Visible = true;
            lblreportnodata.Visible = false;
            lblreportnodata.Text = string.Empty;
            ReportDataSource datasource = new ReportDataSource("ExpenseDetail", CollectionHelper.ConvertTo<ExpenseDetailsDTO>(listExpenseDetailsDTO));
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