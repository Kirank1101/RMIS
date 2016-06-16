using System;
using System.Web.UI.WebControls;
using RMIS.Binder.BackEnd;
using RMIS.Domain.Business;
using RMIS.Domain.DataTranserClass;
using RMIS.Domain.Constant;

public partial class AddRiceBrandType : BaseUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsControlPostBack)
        {
            Header = "Add Rice Type Information";
            bindRiceBrandType();
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        ResultDTO resultDto = BinderSingleton.Instance.GetInstance<IValidateMasterBusiness>().ValidateRiceBrandType(txtRiceBrandType.Text);
        if (resultDto.IsSuccess)
        {
            IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
            resultDto = imp.SaveRiceBrandType(txtRiceBrandType.Text.Trim());
            if (resultDto.IsSuccess)
            {
                bindRiceBrandType();
            }
            SetMessage(resultDto);
        }
        else
        {
            SetMessage(resultDto);
        }
    }
    private void bindRiceBrandType()
    {
        int count = 0;
        IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();

        rptRiceBrandType.DataSource = imp.GetMRiceBrandTypeEntities(rptRiceBrandType.PageIndex, rptRiceBrandType.PageSize, out count, expression);
        rptRiceBrandType.VirtualItemCount = count;
        rptRiceBrandType.DataBind();
    }
    protected void rptRiceBrandType_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        rptRiceBrandType.PageIndex = gridPageIndex = e.NewPageIndex;
        bindRiceBrandType();
    }
    protected void rptRiceBrandType_Sorting(object sender, GridViewSortEventArgs e)
    {
        if (expression == SortExpression.Asc)
            expression = SortExpression.Desc;
        else if (expression == SortExpression.Desc)
            expression = SortExpression.Asc;
        bindRiceBrandType();
    }
    protected void rptRiceBrandType_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        GridViewRow row = (GridViewRow)rptRiceBrandType.Rows[e.RowIndex];
        IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
        imp.DeleteRiceBrandType(rptRiceBrandType.DataKeys[e.RowIndex].Value.ToString());
        bindRiceBrandType();

    }
    protected void rptRiceBrandType_RowEditing(object sender, GridViewEditEventArgs e)
    {
        rptRiceBrandType.EditIndex = e.NewEditIndex;
        rptRiceBrandType.PageIndex = gridPageIndex;
        bindRiceBrandType();

    }
    protected void rptRiceBrandType_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {


        GridViewRow row = (GridViewRow)rptRiceBrandType.Rows[e.RowIndex];

        //TextBox txtname=(TextBox)gr.cell[].control[];

        TextBox textName = (TextBox)row.Cells[0].Controls[0];



        //TextBox textadd = (TextBox)row.FindControl("txtadd");

        //TextBox textc = (TextBox)row.FindControl("txtc");

        rptRiceBrandType.EditIndex = -1;

        IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
        imp.UpdateRiceBrandType(rptRiceBrandType.DataKeys[e.RowIndex].Value.ToString(), textName.Text);
        rptRiceBrandType.PageIndex = gridPageIndex;
        bindRiceBrandType();

        //GridView1.DataBind();

    }
    protected void rptRiceBrandType_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        rptRiceBrandType.EditIndex = -1;
        rptRiceBrandType.PageIndex = gridPageIndex;
        bindRiceBrandType();
    }
}