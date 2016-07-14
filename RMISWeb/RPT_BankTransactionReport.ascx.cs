using System;
using RMIS.Binder.BackEnd;
using RMIS.Domain.Business;
using RMIS.Domain.DataTranserClass;
using Microsoft.Reporting.WebForms;
using RMIS.Domain.Constant;

using System.Collections.Generic;
using AllInOne.Common.Library.Util;

public partial class RPT_BankTransactionReport : BaseUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        base.Header = "Bank Transaction Detail Report";
        if (!IsControlPostBack)
        {

            List<BankTransactionDTO> listBankTransactionDTO = GetBankTransaction();
            BindReport(listBankTransactionDTO);
        }
    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        ResultDTO resultDto = BinderSingleton.Instance.GetInstance<IValidateTransactionBusiness>().ValidateBankTransReport(txtTransFromDate.Text.Trim(), txtTransToDate.Text.Trim());
        if (resultDto.IsSuccess)
        {
            ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
            int count;
            List<BankTransactionDTO> listBankTransactionDTO = imp.GetBankTransactionDTO(txtTransFromDate.Text.ConvertToDate(), txtTransToDate.Text.ConvertToDate(), 0, 1000, out count, SortExpression.Desc);
            BindReport(listBankTransactionDTO);
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
        List<BankTransactionDTO> lstBankTransactionDTO = GetBankTransaction();
        BindReport(lstBankTransactionDTO);
    }

    private List<BankTransactionDTO> GetBankTransaction()
    {
        ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
        int count;
        List<BankTransactionDTO> listBankTransactionDTO = imp.GetBankTransactionDTO(0, 1000, out count, SortExpression.Desc);
        return listBankTransactionDTO;
    }
    private void BindReport(List<BankTransactionDTO> listBankTransactionDTO)
    {
        ReportViewer1.ProcessingMode = ProcessingMode.Local;
        if (listBankTransactionDTO != null && listBankTransactionDTO.Count > 0)
        {
            ReportDataSource datasource = new ReportDataSource("BankTransaction", CollectionHelper.ConvertTo<BankTransactionDTO>(listBankTransactionDTO));

            ReportViewer1.AsyncRendering = false;
            ReportViewer1.LocalReport.DataSources.Clear();
            ReportViewer1.LocalReport.DataSources.Add(datasource);

            ReportViewer1.LocalReport.Refresh();


        }
    }
}