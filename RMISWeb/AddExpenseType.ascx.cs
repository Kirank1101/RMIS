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
using RMIS.Domain.Constant;

public partial class AddExpenseType : BaseUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsControlPostBack)
        {
            Header = "Add Expense Type";
            bindExpenseType();
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        ResultDTO resultDto = new ResultDTO();
        IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
        if (!IsExpenseTypeExist(txtExpenseType.Text.Trim()))
        {
            resultDto = BinderSingleton.Instance.GetInstance<IValidateMasterBusiness>().ValidateExpenseType(txtExpenseType.Text);
            if (resultDto.IsSuccess)
            {
                resultDto = imp.SaveExpenseType(txtExpenseType.Text.Trim());
                if (resultDto.IsSuccess)
                {
                    bindExpenseType();
                }
                SetMessage(resultDto);
            }
            else
            {
                SetMessage(resultDto);
            }
        }
        else
        {
            resultDto.Message = "ExpenseType already Exist.";
            resultDto.IsSuccess = false;
            SetMessage(resultDto);
        }
    }

    private bool IsExpenseTypeExist(string ExpenseType)
    {
        IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
        return imp.CheckExpenseTypeExist(ExpenseType);
    }
    protected void rptExpenseType_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        rptExpenseType.PageIndex = gridPageIndex = e.NewPageIndex;
        bindExpenseType();
    }
    protected void rptExpenseType_Sorting(object sender, GridViewSortEventArgs e)
    {
        if (expression == SortExpression.Asc)
            expression = SortExpression.Desc;
        else if (expression == SortExpression.Desc)
            expression = SortExpression.Asc;
        bindExpenseType();
    }
    protected void rptExpenseType_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        GridViewRow row = (GridViewRow)rptExpenseType.Rows[e.RowIndex];
        IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
        imp.DeleteExpenseType(rptExpenseType.DataKeys[e.RowIndex].Value.ToString());
        bindExpenseType();

    }
    protected void rptExpenseType_RowEditing(object sender, GridViewEditEventArgs e)
    {
        rptExpenseType.EditIndex = e.NewEditIndex;
        rptExpenseType.PageIndex = gridPageIndex;
        bindExpenseType();

    }
    protected void rptExpenseType_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        GridViewRow row = (GridViewRow)rptExpenseType.Rows[e.RowIndex];
        TextBox textName = (TextBox)row.Cells[0].Controls[0];
        rptExpenseType.EditIndex = -1;
        IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
        ResultDTO resultDto = new ResultDTO();
        if (!IsExpenseTypeExist(textName.Text.Trim()))
        {
            resultDto = imp.UpdateExpenseType(rptExpenseType.DataKeys[e.RowIndex].Value.ToString(), textName.Text);
            if (resultDto.IsSuccess)
            {
                rptExpenseType.PageIndex = gridPageIndex;
                bindExpenseType();
                SetMessage(resultDto);
            }
            else
                SetMessage(resultDto);
        }
        else
        {
            resultDto.Message = "ExpenseType already Exist.";
            resultDto.IsSuccess = false;
            SetMessage(resultDto);
        }
    }
    private void bindExpenseType()
    {
        int count = 0;
        IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();

        rptExpenseType.DataSource = imp.GetMExpenseTypeEntities(rptExpenseType.PageIndex, rptExpenseType.PageSize, out count, expression);
        rptExpenseType.VirtualItemCount = count;
        rptExpenseType.DataBind();
    }
    protected void rptExpenseType_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        rptExpenseType.EditIndex = -1;
        rptExpenseType.PageIndex = gridPageIndex;
        bindExpenseType();
    }
}