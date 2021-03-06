﻿using System;
using RMIS.Binder.BackEnd;
using RMIS.Domain.Business;
using RMIS.Domain.DataTranserClass;
using System.Web.UI.WebControls;
using RMIS.Domain.RiceMill;
using RMIS.Domain.Constant;


public partial class AddPaddyType : BaseUserControl
{

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsControlPostBack)
        {
            Header = "Add Paddy Type";
            bindPaddyType();
        }
    }
    private void bindPaddyType()
    {
        int count = 0;
        IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();

        rptPaddyType.DataSource = imp.GetMPaddyTypeEntities(rptPaddyType.PageIndex, rptPaddyType.PageSize, out count, expression);
        rptPaddyType.VirtualItemCount = count;
        rptPaddyType.DataBind();
    }
    protected void rptPaddyType_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        rptPaddyType.PageIndex = gridPageIndex = e.NewPageIndex;
        bindPaddyType();
    }
    protected void rptPaddyType_Sorting(object sender, GridViewSortEventArgs e)
    {
        if (expression == SortExpression.Asc)
            expression = SortExpression.Desc;
        else if (expression == SortExpression.Desc)
            expression = SortExpression.Asc;
        bindPaddyType();
    }
    protected void rptPaddyType_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        GridViewRow row = (GridViewRow)rptPaddyType.Rows[e.RowIndex];
        IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
        imp.DeletePaddyType(rptPaddyType.DataKeys[e.RowIndex].Value.ToString());
        bindPaddyType();

    }
    protected void rptPaddyType_RowEditing(object sender, GridViewEditEventArgs e)
    {
        rptPaddyType.EditIndex = e.NewEditIndex;
        rptPaddyType.PageIndex = gridPageIndex;
        bindPaddyType();

    }
    protected void rptPaddyType_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        GridViewRow row = (GridViewRow)rptPaddyType.Rows[e.RowIndex];
        TextBox textName = (TextBox)row.Cells[0].Controls[0];
        rptPaddyType.EditIndex = -1;
        IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
        ResultDTO resultDto = new ResultDTO();
        if (!IsPaddyTypeExist(textName.Text.Trim()))
        {
            resultDto= imp.UpdatePaddyType(rptPaddyType.DataKeys[e.RowIndex].Value.ToString(), textName.Text);
            if (resultDto.IsSuccess)
            {
                rptPaddyType.PageIndex = gridPageIndex;
                bindPaddyType();
            }
            SetMessage(resultDto);
        }
        else
        {
            resultDto.Message = "Paddy Type already exist.";
            resultDto.IsSuccess = false;
            SetMessage(resultDto);
        }
        //GridView1.DataBind();

    }
    protected void rptPaddyType_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        rptPaddyType.EditIndex = -1;
        rptPaddyType.PageIndex = gridPageIndex;
        bindPaddyType();
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
        ResultDTO resultDto = BinderSingleton.Instance.GetInstance<IValidateMasterBusiness>().ValiadtePaddyType(txtPaddyType.Text);
        if (!IsPaddyTypeExist(txtPaddyType.Text.Trim()))
        {
            if (resultDto.IsSuccess)
            {
                resultDto = imp.SavePaddyType(txtPaddyType.Text.Trim());
                if (resultDto.IsSuccess)
                {
                    bindPaddyType();
                }
                SetMessage(resultDto);
            }
            else
                SetMessage(resultDto);
        }
        else
        {
            resultDto.Message = "Paddy Type already exist.";
            resultDto.IsSuccess = false;
            SetMessage(resultDto);
        }
    }

    private bool IsPaddyTypeExist(string PaddyType)
    {
        IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
        return imp.CheckPaddyTypeExist(PaddyType);
    }
}