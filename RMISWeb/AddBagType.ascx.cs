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

public partial class AddBagType : BaseUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsControlPostBack)
        {
            Header = "Add Bag Type Information";
            bindBagType();
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        ResultDTO resultDto = new ResultDTO();
        IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
        if (!IsBagTypeExist(txtBagType.Text.Trim()))
        {
            resultDto = BinderSingleton.Instance.GetInstance<IValidateMasterBusiness>().ValidateBagType(txtBagType.Text);
            if (resultDto.IsSuccess)
            {
                resultDto = imp.SaveBagType(txtBagType.Text.Trim());
                if (resultDto.IsSuccess)
                {
                    bindBagType();
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
            resultDto.Message = "BagType already Exist.";
            resultDto.IsSuccess = false;
            SetMessage(resultDto);
        }
    }

    private bool IsBagTypeExist(string BagType)
    {
        IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
        return imp.CheckBagTypeExist(BagType);
    }
    protected void rptBagType_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        rptBagType.PageIndex = gridPageIndex = e.NewPageIndex;
        bindBagType();
    }
    protected void rptBagType_Sorting(object sender, GridViewSortEventArgs e)
    {
        if (expression == SortExpression.Asc)
            expression = SortExpression.Desc;
        else if (expression == SortExpression.Desc)
            expression = SortExpression.Asc;
        bindBagType();
    }
    protected void rptBagType_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        GridViewRow row = (GridViewRow)rptBagType.Rows[e.RowIndex];
        IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
        imp.DeleteBagType(rptBagType.DataKeys[e.RowIndex].Value.ToString());
        bindBagType();

    }
    protected void rptBagType_RowEditing(object sender, GridViewEditEventArgs e)
    {
        rptBagType.EditIndex = e.NewEditIndex;
        rptBagType.PageIndex = gridPageIndex;
        bindBagType();

    }
    protected void rptBagType_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        GridViewRow row = (GridViewRow)rptBagType.Rows[e.RowIndex];
        TextBox textName = (TextBox)row.Cells[0].Controls[0];
        rptBagType.EditIndex = -1;
        IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
        ResultDTO resultDto = new ResultDTO();
        if (!IsBagTypeExist(textName.Text.Trim()))
        {
            resultDto = imp.UpdateBagType(rptBagType.DataKeys[e.RowIndex].Value.ToString(), textName.Text);
            if (resultDto.IsSuccess)
            {
                rptBagType.PageIndex = gridPageIndex;
                bindBagType();
                SetMessage(resultDto);
            }
            else
                SetMessage(resultDto);
        }
        else
        {
            resultDto.Message = "BagType already Exist.";
            resultDto.IsSuccess = false;
            SetMessage(resultDto);
        }
    }
    private void bindBagType()
    {
        int count = 0;
        IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();

        rptBagType.DataSource = imp.GetMBagTypeEntities(rptBagType.PageIndex, rptBagType.PageSize, out count, expression);
        rptBagType.VirtualItemCount = count;
        rptBagType.DataBind();
    }
    protected void rptBagType_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        rptBagType.EditIndex = -1;
        rptBagType.PageIndex = gridPageIndex;
        bindBagType();
    }
}