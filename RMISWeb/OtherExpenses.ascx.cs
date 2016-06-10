using System;
using RMIS.Domain.RiceMill;
using RMIS.Binder.BackEnd;
using RMIS.Domain.Business;
using RMIS.Domain.DataTranserClass;
using System.Collections.Generic;

public partial class OtherExpenses : BaseUserControl
{
    ITransactionBusiness impt = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsControlPostBack)
        {
            Header = "Other Expenses";
            txtAmountPaid.Text = "0";
            txtDescription.Text = string.Empty;
            txtGivenTo.Text = string.Empty;
            BindCurrentMonthExpenses();
        }
    }

    private void BindCurrentMonthExpenses()
    {
        List<OtherExpensesEntity> lstOtherExpensesEntity = new List<OtherExpensesEntity>();
        lstOtherExpensesEntity = impt.GetAllOtherExpenses();
        if (lstOtherExpensesEntity != null && lstOtherExpensesEntity.Count > 0)
        {
            rptamountspent.DataSource = lstOtherExpensesEntity;
            rptamountspent.DataBind();
        }
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        ResultDTO resultDto = new ResultDTO();
    
        resultDto = BinderSingleton.Instance.GetInstance<IValidateTransactionBusiness>().ValidateOtherExpenses(txtGivenTo.Text.Trim(), txtDescription.Text.Trim(),  Convert.ToDouble(txtAmountPaid.Text.Trim()));
        if (resultDto.IsSuccess)
        {
            resultDto = impt.SaveOtherExpenses(txtDescription.Text.Trim(), txtGivenTo.Text.Trim(),  Convert.ToDouble(txtAmountPaid.Text.Trim()));
            if (resultDto.IsSuccess)
            {
                BindCurrentMonthExpenses();
                ClearData();
            }
            SetMessage(resultDto);
        }
        else
        {
            SetMessage(resultDto);
        }

    }

    private void ClearData()
    {
        txtAmountPaid.Text = "0";
        txtDescription.Text = string.Empty;
        txtGivenTo.Text = string.Empty;
    }
}
