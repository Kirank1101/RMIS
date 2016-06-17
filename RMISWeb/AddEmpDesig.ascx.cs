using System;
using System.Web.UI.WebControls;
using RMIS.Binder.BackEnd;
using RMIS.Domain.Business;
using RMIS.Domain.DataTranserClass;
using RMIS.Domain.Constant;

public partial class AddEmpDesig : BaseUserControl
{       
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsControlPostBack)
        {
            Header = "Add Employee Designation";
            bindDesigType();
        }
    }    
    protected void btnSubmit_Click(object sender, EventArgs e)
    {   
        IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>(); 
        ResultDTO resultDto = new ResultDTO();
        if (!IsDesigExist(txtDesigType.Text.Trim()))
        {
            resultDto = BinderSingleton.Instance.GetInstance<IValidateMasterBusiness>().ValidateDesignationType(txtDesigType.Text);
            if (resultDto.IsSuccess)
            {
                IMasterPaddyBusiness imp1 = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>(); 
                resultDto = imp1.SaveEmpDesigType(txtDesigType.Text.Trim());
                if (resultDto.IsSuccess)
                {
                    bindDesigType();
                }
                SetMessage(resultDto);
            }
            else
            {
                SetMessage(resultDto);
            }
        }
        else {
            resultDto.IsSuccess = false;
            resultDto.Message = "Designation Type already Exist.";
            SetMessage(resultDto);
        }
    }

    private bool IsDesigExist(string DesigType)
    {
        IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
        return imp.CheckEmpDesigExist(DesigType);
    }
    private void bindDesigType()
    {
        int count = 0;
        IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();

        rptDesigType.DataSource = imp.GetMDesigTypeEntities(rptDesigType.PageIndex, rptDesigType.PageSize, out count, expression);
        rptDesigType.VirtualItemCount = count;
        rptDesigType.DataBind();
    }
    protected void rptDesigType_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        rptDesigType.PageIndex = gridPageIndex = e.NewPageIndex;
        bindDesigType();
    }
    protected void rptDesigType_Sorting(object sender, GridViewSortEventArgs e)
    {
        if (expression == SortExpression.Asc)
            expression = SortExpression.Desc;
        else if (expression == SortExpression.Desc)
            expression = SortExpression.Asc;
        bindDesigType();
    }
    protected void rptDesigType_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        GridViewRow row = (GridViewRow)rptDesigType.Rows[e.RowIndex];
        IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
        imp.DeleteDesigType(rptDesigType.DataKeys[e.RowIndex].Value.ToString());
        bindDesigType();

    }
    protected void rptDesigType_RowEditing(object sender, GridViewEditEventArgs e)
    {
        rptDesigType.EditIndex = e.NewEditIndex;
        rptDesigType.PageIndex = gridPageIndex;
        bindDesigType();

    }
    protected void rptDesigType_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        GridViewRow row = (GridViewRow)rptDesigType.Rows[e.RowIndex];
        TextBox textName = (TextBox)row.Cells[0].Controls[0];
        rptDesigType.EditIndex = -1;
        ResultDTO resultDto = new ResultDTO();
        IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
        if (!IsDesigExist(textName.Text.Trim()))
        {
            resultDto=imp.UpdateDesigType(rptDesigType.DataKeys[e.RowIndex].Value.ToString(), textName.Text);
            if (resultDto.IsSuccess)
            {
                rptDesigType.PageIndex = gridPageIndex;
                bindDesigType();
                SetMessage(resultDto);
            }
            else
                SetMessage(resultDto);
        }
        else {
            resultDto.IsSuccess = false;
            resultDto.Message = "Designation Type already Exist.";
            SetMessage(resultDto);
        }
        //GridView1.DataBind();

    }
    protected void rptDesigType_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        rptDesigType.EditIndex = -1;
        rptDesigType.PageIndex = gridPageIndex;
        bindDesigType();
    }
}