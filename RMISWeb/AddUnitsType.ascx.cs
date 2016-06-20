using System;
using RMIS.Binder.BackEnd;
using RMIS.Domain.Business;
using RMIS.Domain.DataTranserClass;
using System.Web.UI.WebControls;
using RMIS.Domain.RiceMill;
using RMIS.Domain.Constant;


public partial class AddUnitsType : BaseUserControl
{           
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsControlPostBack)
        {
            Header = "Add Unit type";
            bindUnitsType();
        }
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        ResultDTO resultDto = BinderSingleton.Instance.GetInstance<IValidateMasterBusiness>().ValidateUnitsType(txtUnitsType.Text);
        IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
        if (!IsUnitTypeExist(txtUnitsType.Text.Trim()))
        {
            if (resultDto.IsSuccess)
            {
                resultDto = imp.SaveUnitsType(txtUnitsType.Text.Trim());
                if (resultDto.IsSuccess)
                {
                    bindUnitsType();
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
            resultDto.Message = "Already UnitType exist.";
            SetMessage(resultDto);
        }
    }

    private bool IsUnitTypeExist(string UnitType)
    {
        IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
        return imp.CheckUnitTypeExist(UnitType);
    }
    private void bindUnitsType()
    {
        int count = 0;
        IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();

        rptUnitsType.DataSource = imp.GetMUnitsTypeEntities(rptUnitsType.PageIndex, rptUnitsType.PageSize, out count, expression);
        rptUnitsType.VirtualItemCount = count;
        rptUnitsType.DataBind();
    }
    protected void rptUnitsType_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        rptUnitsType.PageIndex = gridPageIndex = e.NewPageIndex;
        bindUnitsType();
    }
    protected void rptUnitsType_Sorting(object sender, GridViewSortEventArgs e)
    {
        if (expression == SortExpression.Asc)
            expression = SortExpression.Desc;
        else if (expression == SortExpression.Desc)
            expression = SortExpression.Asc;
        bindUnitsType();
    }
    protected void rptUnitsType_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        GridViewRow row = (GridViewRow)rptUnitsType.Rows[e.RowIndex];
        IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
        imp.DeleteUnitsType(rptUnitsType.DataKeys[e.RowIndex].Value.ToString());
        bindUnitsType();

    }
    protected void rptUnitsType_RowEditing(object sender, GridViewEditEventArgs e)
    {
        rptUnitsType.EditIndex = e.NewEditIndex;
        rptUnitsType.PageIndex = gridPageIndex;
        bindUnitsType();

    }
    protected void rptUnitsType_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        GridViewRow row = (GridViewRow)rptUnitsType.Rows[e.RowIndex];
        TextBox textName = (TextBox)row.Cells[0].Controls[0];
        rptUnitsType.EditIndex = -1;
        IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
        ResultDTO resultDto = new ResultDTO();
        if (!IsUnitTypeExist(textName.Text.Trim()))
        {
            resultDto=imp.UpdateUnitsType(rptUnitsType.DataKeys[e.RowIndex].Value.ToString(), textName.Text);
            if (resultDto.IsSuccess)
            {
                rptUnitsType.PageIndex = gridPageIndex;
                bindUnitsType();
            }
            SetMessage(resultDto);
        }
        else
        {
            resultDto.IsSuccess = false;
            resultDto.Message = "Already UnitType exist.";
            SetMessage(resultDto);
        }

    }
    protected void rptUnitsType_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        rptUnitsType.EditIndex = -1;
        rptUnitsType.PageIndex = gridPageIndex;
        bindUnitsType();
    }
}