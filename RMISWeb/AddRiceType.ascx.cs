using System;
using RMIS.Binder.BackEnd;
using RMIS.Domain.Business;
using RMIS.Domain.DataTranserClass;
using System.Web.UI.WebControls;
using RMIS.Domain.Constant;

public partial class AddRiceType : BaseUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsControlPostBack)
        {
            Header = "Add Rice Type Information";           
            bindRiceType();
        }
    }    
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
        ResultDTO resultDto = new ResultDTO();
        if (!IsRiceTypeExist(txtRiceType.Text.Trim()))
        {
            resultDto = BinderSingleton.Instance.GetInstance<IValidateMasterBusiness>().ValidateRiceProductType(txtRiceType.Text);
            if (resultDto.IsSuccess)
            {
                resultDto = imp.SaveRiceProductType(txtRiceType.Text.Trim());
                if (resultDto.IsSuccess)
                {
                    bindRiceType();
                }
                SetMessage(resultDto);
            }
            else
                SetMessage(resultDto);
        }
        else
        {
            resultDto.Message = "RiceType already Exist.";
            resultDto.IsSuccess = false;
            SetMessage(resultDto);
        }
    }

    private bool IsRiceTypeExist(string Ricetype)
    {
        IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
        return imp.CheckRiceTypeExist(Ricetype);
    }
    protected void rptRiceType_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        rptRiceType.PageIndex = gridPageIndex = e.NewPageIndex;
        bindRiceType();
    }

    protected void rptRiceType_Sorting(object sender, GridViewSortEventArgs e)
    {
        if (expression == SortExpression.Asc)
            expression = SortExpression.Desc;
        else if (expression == SortExpression.Desc)
            expression = SortExpression.Asc;
        bindRiceType();
    }

    protected void rptRiceType_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        GridViewRow row = (GridViewRow)rptRiceType.Rows[e.RowIndex];
        IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
        imp.DeleteRiceType(rptRiceType.DataKeys[e.RowIndex].Value.ToString());
        bindRiceType();

    }

    protected void rptRiceType_RowEditing(object sender, GridViewEditEventArgs e)
    {
        rptRiceType.EditIndex = e.NewEditIndex;
        rptRiceType.PageIndex = gridPageIndex;
        bindRiceType();

    }

    protected void rptRiceType_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        GridViewRow row = (GridViewRow)rptRiceType.Rows[e.RowIndex];
        TextBox textName = (TextBox)row.Cells[0].Controls[0];
        rptRiceType.EditIndex = -1;
        IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
        ResultDTO resultDto = new ResultDTO();
        if (!IsRiceTypeExist(textName.Text.Trim()))
        {
            resultDto= imp.UpdateRiceType(rptRiceType.DataKeys[e.RowIndex].Value.ToString(), textName.Text);
            if (resultDto.IsSuccess)
            {
                rptRiceType.PageIndex = gridPageIndex;
                bindRiceType();
            }
            SetMessage(resultDto);
        }
        else
        {
            resultDto.Message = "RiceType already Exist.";
            resultDto.IsSuccess = false;
            SetMessage(resultDto);
        }
    }
    private void bindRiceType()
    {
        int count = 0;
        IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();

        rptRiceType.DataSource = imp.GetMRiceTypeEntities(rptRiceType.PageIndex, rptRiceType.PageSize, out count, expression);
        rptRiceType.VirtualItemCount = count;
        rptRiceType.DataBind();
    }
    protected void rptRiceType_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        rptRiceType.EditIndex = -1;
        rptRiceType.PageIndex = gridPageIndex;
        bindRiceType();
    }
}