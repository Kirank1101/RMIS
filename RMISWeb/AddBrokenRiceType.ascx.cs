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

public partial class AddBrokenRiceType : BaseUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsControlPostBack)
        {
            Header = "Add Rice Type Information";
            bindBrokenRiceType();
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        ResultDTO resultDto = BinderSingleton.Instance.GetInstance<IValidateMasterBusiness>().ValidateBrokenRiceType(txtBrokenRiceType.Text);
        if (resultDto.IsSuccess)
        {
            IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
            resultDto = imp.SaveBrokenRiceType(txtBrokenRiceType.Text.Trim());
            if (resultDto.IsSuccess)
            {
                bindBrokenRiceType();
            }
            SetMessage(resultDto);
        }
        else
        {
            SetMessage(resultDto);
        }
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

        //TextBox txtname=(TextBox)gr.cell[].control[];

        TextBox textName = (TextBox)row.Cells[0].Controls[0];



        //TextBox textadd = (TextBox)row.FindControl("txtadd");

        //TextBox textc = (TextBox)row.FindControl("txtc");

        rptBrokenRiceType.EditIndex = -1;

        IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
        imp.UpdateBrokenRiceType(rptBrokenRiceType.DataKeys[e.RowIndex].Value.ToString(), textName.Text);
        rptBrokenRiceType.PageIndex = gridPageIndex;
        bindBrokenRiceType();

        //GridView1.DataBind();

    }
    protected void rptBrokenRiceType_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        rptBrokenRiceType.EditIndex = -1;
        rptBrokenRiceType.PageIndex = gridPageIndex;
        bindBrokenRiceType();
    }
}