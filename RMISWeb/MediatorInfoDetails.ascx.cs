using System;
using RMIS.Binder.BackEnd;
using RMIS.Domain.Business;
using RMIS.Domain.DataTranserClass;
using System.Web.UI.WebControls;
using RMIS.Domain.Constant;

public partial class MediatorInfoDetails : BaseUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsControlPostBack)
        {
            Header = "Mediator Information";
            IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
            bindMediatorInfo();
        }
    }
    private void bindMediatorInfo()
    {
        int count = 0;
        ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();

        rptMediatorInfo.DataSource = imp.GetAllMediatorInfoEntities(rptMediatorInfo.PageIndex, rptMediatorInfo.PageSize, out count, expression);
        rptMediatorInfo.VirtualItemCount = count;
        rptMediatorInfo.DataBind();
    }
    protected void rptMediatorInfo_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        rptMediatorInfo.PageIndex = gridPageIndex = e.NewPageIndex;
        bindMediatorInfo();
    }
    protected void rptMediatorInfo_Sorting(object sender, GridViewSortEventArgs e)
    {
        if (expression == SortExpression.Asc)
            expression = SortExpression.Desc;
        else if (expression == SortExpression.Desc)
            expression = SortExpression.Asc;
        bindMediatorInfo();
    }
    protected void rptMediatorInfo_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        GridViewRow row = (GridViewRow)rptMediatorInfo.Rows[e.RowIndex];
        ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
        ResultDTO resultDto = new ResultDTO();

        resultDto = imp.DeleteMediatorInfo(rptMediatorInfo.DataKeys[e.RowIndex].Value.ToString());
        if (resultDto.IsSuccess)
            bindMediatorInfo();
        SetMessage(resultDto);


    }
    protected void rptMediatorInfo_RowEditing(object sender, GridViewEditEventArgs e)
    {
        rptMediatorInfo.EditIndex = e.NewEditIndex;
        rptMediatorInfo.PageIndex = gridPageIndex;
        bindMediatorInfo();

    }
    protected void rptMediatorInfo_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        GridViewRow row = (GridViewRow)rptMediatorInfo.Rows[e.RowIndex];
        TextBox textMediatorName = (TextBox)row.Cells[0].Controls[0];
        TextBox textTown = (TextBox)row.Cells[1].Controls[0];
        TextBox textContactNo = (TextBox)row.Cells[2].Controls[0];
        TextBox textMobileNo = (TextBox)row.Cells[3].Controls[0];
        TextBox textMediatorID = (TextBox)row.Cells[4].Controls[0];
        
        rptMediatorInfo.EditIndex = -1;
        ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
        ResultDTO resultDto = new ResultDTO();
        if (!IsMediatorNameExist(textMediatorID.Text.Trim(), textMediatorName.Text.Trim()))
        {
            resultDto = imp.UpdateMediatorInfo(rptMediatorInfo.DataKeys[e.RowIndex].Value.ToString(), textMediatorName.Text, txtTown.Text, txtContactNo.Text, txtMobileNo.Text);
            if (resultDto.IsSuccess)
            {
                rptMediatorInfo.PageIndex = gridPageIndex;
                bindMediatorInfo();
            }
            SetMessage(resultDto);
        }
        else
        {
            resultDto.Message = "Mediator Name already exist.";
            resultDto.IsSuccess = false;
            SetMessage(resultDto);
        }
        //GridView1.DataBind();

    }
    protected void rptMediatorInfo_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        rptMediatorInfo.EditIndex = -1;
        rptMediatorInfo.PageIndex = gridPageIndex;
        bindMediatorInfo();
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
        ResultDTO resultDto = BinderSingleton.Instance.GetInstance<IValidateTransactionBusiness>().ValidateMediatorDetails(txtMediatorName.Text, txtCity.Text, txtDistrict.Text, txtState.Text, txtContactNo.Text);
        if (!IsMediatorNameExist(string.Empty,txtMediatorName.Text.Trim()))
        {
            if (resultDto.IsSuccess)
            {
                resultDto = imp.SaveMediatorInfo(txtMediatorName.Text.Trim(), txtStreet1.Text.Trim(), txtStreet2.Text.Trim(), txtTown.Text.Trim(), txtCity.Text.Trim(), txtDistrict.Text.Trim(), txtState.Text.Trim(), txtPincode.Text.Trim(), txtContactNo.Text.Trim(), txtMobileNo.Text.Trim(), txtPhoneNo.Text.Trim());
                if (resultDto.IsSuccess)
                {
                    bindMediatorInfo();
                    ClearAllInputFields();
                }
                SetMessage(resultDto);
            }
            else
                SetMessage(resultDto);
        }
        else
        {
            resultDto.Message = "Mediator Name already exist.";
            resultDto.IsSuccess = false;
            SetMessage(resultDto);
        }
    }
    private bool IsMediatorNameExist(string MediatorID,string MediatorName)
    {
        ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
        return imp.CheckMediatorNameExist(MediatorID,MediatorName);
    }
    protected void btnClear_Click(object sender, EventArgs e)
    {
        ClearAllInputFields();
    }
    private void ClearAllInputFields()
    {
        txtMediatorName.Text = string.Empty;
        txtStreet1.Text = string.Empty;
        txtStreet2.Text = string.Empty;
        txtTown.Text = string.Empty;
        txtCity.Text = string.Empty;
        txtDistrict.Text = string.Empty;
        txtState.Text = string.Empty;
        txtPincode.Text = string.Empty;
        txtContactNo.Text = string.Empty;
        txtMobileNo.Text = string.Empty;
        txtPhoneNo.Text = string.Empty;
    }
}