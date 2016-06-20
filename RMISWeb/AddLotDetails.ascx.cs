using System;
using System.Web.UI.WebControls;
using RMIS.Binder.BackEnd;
using RMIS.Domain.Business;
using RMIS.Domain.DataTranserClass;
using System.Collections.Generic;
using RMIS.Domain.Constant;

public partial class AddLotDetails : BaseUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsControlPostBack)
        {
            Header = "Add Lot Details";
            bindLotDetails();
            IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
            List<GodownTypeDTO> listGodownTypeDTO = imp.GetMGodownTypeEntities();
            ddlGodownName.DataSource = listGodownTypeDTO;
            ddlGodownName.DataTextField = GodownTypeDTO.dataColumnGodownType;
            ddlGodownName.DataValueField = GodownTypeDTO.dataColumnId;
            ddlGodownName.DataBind();
            ddlGodownName.Items.Insert(0, "[Select]");
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        ResultDTO resultDto = new ResultDTO();
        IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
        if (!IsLotNameExist(txtLotDetails.Text.Trim()))
        {
            resultDto = BinderSingleton.Instance.GetInstance<IValidateMasterBusiness>().ValidateLotDetails(txtLotDetails.Text, ddlGodownName.SelectedValue);
            if (resultDto.IsSuccess)
            {
                IMasterPaddyBusiness imp1 = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
        
                resultDto = imp1.SaveLotDetails(txtLotDetails.Text, ddlGodownName.SelectedValue);
                if (resultDto.IsSuccess)
                {
                    bindLotDetails();
                }
                SetMessage(resultDto);
            }
            else
                SetMessage(resultDto);
        }
        else
        {
            resultDto.Message = "LotName already Exist.";
            resultDto.IsSuccess = false;
            SetMessage(resultDto);
        }
    }

    private bool IsLotNameExist(string LotName)
    {
        IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
        return imp.CheckLotNameExist(LotName);
    }
    protected void ddlGodownName_SelectedIndexChanged(object sender, EventArgs e)
    {
        bindLotDetails();
    }
    protected void rptLotDetails_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        rptLotDetails.PageIndex = gridPageIndex = e.NewPageIndex;
        bindLotDetails();
    }
    protected void rptLotDetails_Sorting(object sender, GridViewSortEventArgs e)
    {
        if (expression == SortExpression.Asc)
            expression = SortExpression.Desc;
        else if (expression == SortExpression.Desc)
            expression = SortExpression.Asc;
        bindLotDetails();
    }
    protected void rptLotDetails_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        GridViewRow row = (GridViewRow)rptLotDetails.Rows[e.RowIndex];
        IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
        imp.DeleteLotDetails(rptLotDetails.DataKeys[e.RowIndex].Value.ToString());
        bindLotDetails();

    }
    protected void rptLotDetails_RowEditing(object sender, GridViewEditEventArgs e)
    {
        rptLotDetails.EditIndex = e.NewEditIndex;
        rptLotDetails.PageIndex = gridPageIndex;
        bindLotDetails();

    }
    protected void rptLotDetails_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        GridViewRow row = (GridViewRow)rptLotDetails.Rows[e.RowIndex];
        TextBox textName = (TextBox)row.Cells[0].Controls[0];
        rptLotDetails.EditIndex = -1;
        IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
        ResultDTO resultDto = new ResultDTO();
        if (!IsLotNameExist(textName.Text.Trim()))
        {
            resultDto = imp.UpdateLotDetails(rptLotDetails.DataKeys[e.RowIndex].Value.ToString(), textName.Text);
            if (resultDto.IsSuccess)
            {
                rptLotDetails.PageIndex = gridPageIndex;
                bindLotDetails();
            }
            SetMessage(resultDto);
        }
        else
        {
            resultDto.Message = "LotName already Exist.";
            resultDto.IsSuccess = false;
            SetMessage(resultDto);
        }
    }
    private void bindLotDetails()
    {
        int count = 0;
        IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();

        rptLotDetails.DataSource = imp.GetMLotDetailsEntities(ddlGodownName.SelectedValue, rptLotDetails.PageIndex, rptLotDetails.PageSize, out count, expression);
        rptLotDetails.VirtualItemCount = count;
        rptLotDetails.DataBind();
    }
    protected void rptLotDetails_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        rptLotDetails.EditIndex = -1;
        rptLotDetails.PageIndex = gridPageIndex;
        bindLotDetails();
    }
}