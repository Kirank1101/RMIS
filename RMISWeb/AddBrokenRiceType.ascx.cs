using System;
using System.Web.UI.WebControls;
using RMIS.Binder.BackEnd;
using RMIS.Domain.Business;
using RMIS.Domain.DataTranserClass;
using RMIS.Domain.Constant;

public partial class AddBrokenRiceType : BaseUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsControlPostBack)
        {
            Header = "Add Broken Rice Type";
            bindBrokenRiceType();
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
        ResultDTO resultDto = new ResultDTO();
        if (!IsBrokenRiceTypeExist(txtBrokenRiceType.Text.Trim()))
        {
            resultDto = BinderSingleton.Instance.GetInstance<IValidateMasterBusiness>().ValidateBrokenRiceType(txtBrokenRiceType.Text);
            if (resultDto.IsSuccess)
            {
                resultDto = imp.SaveBrokenRiceType(txtBrokenRiceType.Text.Trim());
                if (resultDto.IsSuccess)
                {
                    bindBrokenRiceType();
                }
                SetMessage(resultDto);
            }
            else
                SetMessage(resultDto);
        }
        else
        {
            resultDto.Message = "BrokenRiceType already Exist.";
            resultDto.IsSuccess = false;
            SetMessage(resultDto);
        }
    }

    private bool IsBrokenRiceTypeExist(string BrokenRiceType)
    {
        IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();        
        return imp.CheckBrokenRiceTypeExist(BrokenRiceType); 
    }
    private void bindBrokenRiceType()
    {
        int count = 0;
        IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();

        rptBrokenRiceType.DataSource = imp.GetMBrokenRiceTypeEntities(rptBrokenRiceType.PageIndex, rptBrokenRiceType.PageSize, out count, expression);
        rptBrokenRiceType.VirtualItemCount = count;
        rptBrokenRiceType.DataBind();
    }
    protected void rptBrokenRiceType_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        rptBrokenRiceType.PageIndex = gridPageIndex = e.NewPageIndex;
        bindBrokenRiceType();
    }
    protected void rptBrokenRiceType_Sorting(object sender, GridViewSortEventArgs e)
    {
        if (expression == SortExpression.Asc)
            expression = SortExpression.Desc;
        else if (expression == SortExpression.Desc)
            expression = SortExpression.Asc;
        bindBrokenRiceType();
    }
    protected void rptBrokenRiceType_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        GridViewRow row = (GridViewRow)rptBrokenRiceType.Rows[e.RowIndex];
        IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
        imp.DeleteBrokenRiceType(rptBrokenRiceType.DataKeys[e.RowIndex].Value.ToString());
        bindBrokenRiceType();

    }
    protected void rptBrokenRiceType_RowEditing(object sender, GridViewEditEventArgs e)
    {
        rptBrokenRiceType.EditIndex = e.NewEditIndex;
        rptBrokenRiceType.PageIndex = gridPageIndex;
        bindBrokenRiceType();

    }
    protected void rptBrokenRiceType_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        GridViewRow row = (GridViewRow)rptBrokenRiceType.Rows[e.RowIndex];
        TextBox textName = (TextBox)row.Cells[0].Controls[0];
        rptBrokenRiceType.EditIndex = -1;
        IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
        ResultDTO resultDto = new ResultDTO();

        if (!IsBrokenRiceTypeExist(textName.Text.Trim()))
        {
            resultDto = imp.UpdateBrokenRiceType(rptBrokenRiceType.DataKeys[e.RowIndex].Value.ToString(), textName.Text);
            if (resultDto.IsSuccess)
            {
                rptBrokenRiceType.PageIndex = gridPageIndex;
                bindBrokenRiceType();
                SetMessage(resultDto);
            }
            else
                SetMessage(resultDto);
        }
        else
        {
            resultDto.Message = "BrokenRiceType already Exist.";
            resultDto.IsSuccess = false;
            SetMessage(resultDto);
        }
        //GridView1.DataBind();

    }
    protected void rptBrokenRiceType_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        rptBrokenRiceType.EditIndex = -1;
        rptBrokenRiceType.PageIndex = gridPageIndex;
        bindBrokenRiceType();
    }
}