using System;
using System.Web.UI.WebControls;
using RMIS.Binder.BackEnd;
using RMIS.Domain.Business;
using RMIS.Domain.DataTranserClass;
using RMIS.Domain.Constant;

public partial class AddSalaryType : BaseUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsControlPostBack)
        {
            Header = "Add Salary Type";
            bindSalaryType();
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
        ResultDTO resultDto = new ResultDTO();
        if (!IsSalaryTypeExist(txtSalaryType.Text.Trim()))
        {
            resultDto = BinderSingleton.Instance.GetInstance<IValidateMasterBusiness>().ValidateSalaryType(txtSalaryType.Text);
            if (resultDto.IsSuccess)
            {
                IMasterPaddyBusiness imp1 = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
                resultDto = imp1.SaveSalaryType(txtSalaryType.Text.Trim());
                if (resultDto.IsSuccess)
                {
                    bindSalaryType();
                }
                SetMessage(resultDto);
            }
            else
                SetMessage(resultDto);
        }
        else
        {
            resultDto.IsSuccess = false;
            resultDto.Message = "Salary Type already Exist.";
            SetMessage(resultDto);
        }
    }

    private bool IsSalaryTypeExist(string SalaryType)
    {
        IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
        return imp.CheckSalaryTypeExist(SalaryType);
    }
    private void bindSalaryType()
    {
        int count = 0;
        IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();

        rptSalaryType.DataSource = imp.GetMSalaryTypeEntities(rptSalaryType.PageIndex, rptSalaryType.PageSize, out count, expression);
        rptSalaryType.VirtualItemCount = count;
        rptSalaryType.DataBind();
    }
    protected void rptSalaryType_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        rptSalaryType.PageIndex = gridPageIndex = e.NewPageIndex;
        bindSalaryType();
    }
    protected void rptSalaryType_Sorting(object sender, GridViewSortEventArgs e)
    {
        if (expression == SortExpression.Asc)
            expression = SortExpression.Desc;
        else if (expression == SortExpression.Desc)
            expression = SortExpression.Asc;
        bindSalaryType();
    }
    protected void rptSalaryType_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        GridViewRow row = (GridViewRow)rptSalaryType.Rows[e.RowIndex];
        IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
        imp.DeleteSalaryType(rptSalaryType.DataKeys[e.RowIndex].Value.ToString());
        bindSalaryType();

    }
    protected void rptSalaryType_RowEditing(object sender, GridViewEditEventArgs e)
    {
        rptSalaryType.EditIndex = e.NewEditIndex;
        rptSalaryType.PageIndex = gridPageIndex;
        bindSalaryType();

    }
    protected void rptSalaryType_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        GridViewRow row = (GridViewRow)rptSalaryType.Rows[e.RowIndex];
        TextBox textName = (TextBox)row.Cells[0].Controls[0];
        rptSalaryType.EditIndex = -1;
        IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
        ResultDTO resultDto = new ResultDTO();
        if (!IsSalaryTypeExist(textName.Text.Trim()))
        {
            resultDto = imp.UpdateSalaryType(rptSalaryType.DataKeys[e.RowIndex].Value.ToString(), textName.Text);
            if (resultDto.IsSuccess)
            {
                rptSalaryType.PageIndex = gridPageIndex;
                bindSalaryType();
            }
            SetMessage(resultDto);
        }
        else
        {
            resultDto.IsSuccess = false;
            resultDto.Message = "Salary Type already Exist.";
            SetMessage(resultDto);
        }
    }
    protected void rptSalaryType_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        rptSalaryType.EditIndex = -1;
        rptSalaryType.PageIndex = gridPageIndex;
        bindSalaryType();
    }
}