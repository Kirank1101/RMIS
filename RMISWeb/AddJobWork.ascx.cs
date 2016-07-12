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

public partial class AddJobWork : BaseUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsControlPostBack)
        {
            Header = "Add JobWork Type";
            bindJobWorkType();
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        ResultDTO resultDto = new ResultDTO();
        IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
        if (!IsJobWorkTypeExist(txtJobWorkType.Text.Trim()))
        {
            resultDto = BinderSingleton.Instance.GetInstance<IValidateMasterBusiness>().ValidateJobWork(txtJobWorkType.Text);
            if (resultDto.IsSuccess)
            {
                resultDto = imp.SaveJobWork(txtJobWorkType.Text.Trim());
                if (resultDto.IsSuccess)
                {
                    bindJobWorkType();
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
            resultDto.Message = "JobWorkType already Exist.";
            resultDto.IsSuccess = false;
            SetMessage(resultDto);
        }
    }

    private bool IsJobWorkTypeExist(string JobWorkType)
    {
        IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
        return imp.CheckJobWorkExist(JobWorkType);
    }
    protected void rptJobWorkType_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        rptJobWorkType.PageIndex = gridPageIndex = e.NewPageIndex;
        bindJobWorkType();
    }
    protected void rptJobWorkType_Sorting(object sender, GridViewSortEventArgs e)
    {
        if (expression == SortExpression.Asc)
            expression = SortExpression.Desc;
        else if (expression == SortExpression.Desc)
            expression = SortExpression.Asc;
        bindJobWorkType();
    }
    protected void rptJobWorkType_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        GridViewRow row = (GridViewRow)rptJobWorkType.Rows[e.RowIndex];
        IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
        imp.DeleteJobWork(rptJobWorkType.DataKeys[e.RowIndex].Value.ToString());
        bindJobWorkType();

    }
    protected void rptJobWorkType_RowEditing(object sender, GridViewEditEventArgs e)
    {
        rptJobWorkType.EditIndex = e.NewEditIndex;
        rptJobWorkType.PageIndex = gridPageIndex;
        bindJobWorkType();

    }
    protected void rptJobWorkType_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        GridViewRow row = (GridViewRow)rptJobWorkType.Rows[e.RowIndex];
        TextBox textName = (TextBox)row.Cells[0].Controls[0];
        rptJobWorkType.EditIndex = -1;
        IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
        ResultDTO resultDto = new ResultDTO();
        if (!IsJobWorkTypeExist(textName.Text.Trim()))
        {
            resultDto = imp.UpdateJobWork(rptJobWorkType.DataKeys[e.RowIndex].Value.ToString(), textName.Text);
            if (resultDto.IsSuccess)
            {
                rptJobWorkType.PageIndex = gridPageIndex;
                bindJobWorkType();
                SetMessage(resultDto);
            }
            else
                SetMessage(resultDto);
        }
        else
        {
            resultDto.Message = "JobWorkType already Exist.";
            resultDto.IsSuccess = false;
            SetMessage(resultDto);
        }
    }
    private void bindJobWorkType()
    {
        int count = 0;
        IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();

        rptJobWorkType.DataSource = imp.GetMJobWorkEntities(rptJobWorkType.PageIndex, rptJobWorkType.PageSize, out count, expression);
        rptJobWorkType.VirtualItemCount = count;
        rptJobWorkType.DataBind();
    }
    protected void rptJobWorkType_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        rptJobWorkType.EditIndex = -1;
        rptJobWorkType.PageIndex = gridPageIndex;
        bindJobWorkType();
    }
}