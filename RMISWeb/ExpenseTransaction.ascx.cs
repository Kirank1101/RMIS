using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using RMIS.Mediator.BackEnd;
using RMIS.Domain.RiceMill;
using RMIS.Domain;
using RMIS.Binder.BackEnd;
using RMIS.Domain.Mediator;
using RMIS.Domain.Business;
using RMIS.Domain.DataTranserClass;
using System.Collections.Generic;

public partial class ExpenseTransaction : BaseUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsControlPostBack)
        {
            Header = "Expense Transaction";
            IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
            ITransactionBusiness impt = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
            List<MExpenseTypeDTO> listExpensetypedetails = imp.GetMExpenseTypeEntities();
            ddlExpenseType.DataSource = listExpensetypedetails;
            ddlExpenseType.DataTextField = "ExpenseType";
            ddlExpenseType.DataValueField = "Id";
            ddlExpenseType.DataBind();
            ddlExpenseType.Items.Insert(0, "[Select]");
        }
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {

        ResultDTO resultDto = new ResultDTO();
        ITransactionBusiness impt = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
        resultDto = BinderSingleton.Instance.GetInstance<IValidateTransactionBusiness>().ValidateExpenseTransaction(ddlExpenseType.SelectedIndex, txtName.Text.Trim(), txtReason.Text.Trim(), Convert.ToDouble(txtAmount.Text.Trim()));
        if (resultDto.IsSuccess)
        {
            resultDto = impt.SaveExpenseTrans(ddlExpenseType.SelectedValue, txtName.Text.Trim(), txtReason.Text.Trim(), Convert.ToDouble(txtAmount.Text.Trim()));
            if (resultDto.IsSuccess)
            {
                //BindEmployeeSalaryInfo();
            }
            SetMessage(resultDto);
        }
        else
        {
            SetMessage(resultDto);
        }

    }


}