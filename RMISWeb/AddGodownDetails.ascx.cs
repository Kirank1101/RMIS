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

public partial class AddGodownDetails : BaseUserControl
{       
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsControlPostBack)
        {
            Header = "Add Godown Details";
            bindGodownType();
        }
    }
    
    protected void btnSubmit_Click(object sender, EventArgs e)
    {   
        ResultDTO resultDto = new ResultDTO();
        IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
        if (!IsGodownExist(txtGodownName.Text.Trim()))
        {
            resultDto = BinderSingleton.Instance.GetInstance<IValidateMasterBusiness>().ValidateGodownDetails(txtGodownName.Text);
            if (resultDto.IsSuccess)
            {
                IMasterPaddyBusiness imp1 = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
                resultDto = imp1.SaveGodownType(txtGodownName.Text.Trim());
                if (resultDto.IsSuccess)
                {
                    bindGodownType();
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
            resultDto.Message = "GodownName already Exist.";
            resultDto.IsSuccess = false;
            SetMessage(resultDto);
        }
    }

    private bool IsGodownExist(string GodownName)
    {
        IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
        return imp.CheckGodownNameExist(GodownName);
    }
    protected void rptGodownType_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        rptGodownType.PageIndex = gridPageIndex = e.NewPageIndex;
        bindGodownType();
    }

    protected void rptGodownType_Sorting(object sender, GridViewSortEventArgs e)
    {
        if (expression == SortExpression.Asc)
            expression = SortExpression.Desc;
        else if (expression == SortExpression.Desc)
            expression = SortExpression.Asc;
        bindGodownType();
    }

    protected void rptGodownType_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        GridViewRow row = (GridViewRow)rptGodownType.Rows[e.RowIndex];
        IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
        imp.DeleteGodownType(rptGodownType.DataKeys[e.RowIndex].Value.ToString());
        bindGodownType();

    }

    protected void rptGodownType_RowEditing(object sender, GridViewEditEventArgs e)
    {
        rptGodownType.EditIndex = e.NewEditIndex;
        rptGodownType.PageIndex = gridPageIndex;
        bindGodownType();

    }

    protected void rptGodownType_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        GridViewRow row = (GridViewRow)rptGodownType.Rows[e.RowIndex];
        TextBox textName = (TextBox)row.Cells[0].Controls[0];
        rptGodownType.EditIndex = -1;
        IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
        ResultDTO resultDto = new ResultDTO();
        if (!IsGodownExist(textName.Text.Trim()))
        {
            resultDto=imp.UpdateGodownType(rptGodownType.DataKeys[e.RowIndex].Value.ToString(), textName.Text);
            if (resultDto.IsSuccess)
            {
                rptGodownType.PageIndex = gridPageIndex;
                bindGodownType();
                SetMessage(resultDto);
            }
            else
                SetMessage(resultDto);
        }
        else
        {
            resultDto.Message = "GodownName already Exist.";
            resultDto.IsSuccess = false;
            SetMessage(resultDto);
        }
    }
    private void bindGodownType()
    {
        int count = 0;
        IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();

        rptGodownType.DataSource = imp.GetMGodownTypeEntities(rptGodownType.PageIndex, rptGodownType.PageSize, out count, expression);
        rptGodownType.VirtualItemCount = count;
        rptGodownType.DataBind();
    }
    protected void rptGodownType_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        rptGodownType.EditIndex = -1;
        rptGodownType.PageIndex = gridPageIndex;
        bindGodownType();
    }
}