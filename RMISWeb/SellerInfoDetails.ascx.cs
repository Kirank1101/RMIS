using System;
using RMIS.Binder.BackEnd;
using RMIS.Domain.Business;
using RMIS.Domain.DataTranserClass;
using System.Web.UI.WebControls;
using RMIS.Domain.Constant;

public partial class SellerInfoDetails : BaseUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsControlPostBack)
        {
            Header = "Seller Information";
            bindSellerInfo();
        }
    }
    private void bindSellerInfo()
    {
        int count = 0;
        ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();

        rptSellerInfo.DataSource = imp.GetAllSellerInfoEntities(rptSellerInfo.PageIndex, rptSellerInfo.PageSize, out count, expression);
        rptSellerInfo.VirtualItemCount = count;
        rptSellerInfo.DataBind();
    }
    protected void rptSellerInfo_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        rptSellerInfo.PageIndex = gridPageIndex = e.NewPageIndex;
        bindSellerInfo();
    }
    protected void rptSellerInfo_Sorting(object sender, GridViewSortEventArgs e)
    {
        if (expression == SortExpression.Asc)
            expression = SortExpression.Desc;
        else if (expression == SortExpression.Desc)
            expression = SortExpression.Asc;
        bindSellerInfo();
    }
    protected void rptSellerInfo_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        GridViewRow row = (GridViewRow)rptSellerInfo.Rows[e.RowIndex];
        ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
        ResultDTO resultDto = new ResultDTO();

        resultDto = imp.DeleteSellerInfo(rptSellerInfo.DataKeys[e.RowIndex].Value.ToString());
        if (resultDto.IsSuccess)
            bindSellerInfo();
        SetMessage(resultDto);
        

    }
    protected void rptSellerInfo_RowEditing(object sender, GridViewEditEventArgs e)
    {
        rptSellerInfo.EditIndex = e.NewEditIndex;
        rptSellerInfo.PageIndex = gridPageIndex;
        bindSellerInfo();

    }
    protected void rptSellerInfo_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        GridViewRow row = (GridViewRow)rptSellerInfo.Rows[e.RowIndex];
        TextBox textSellerName = (TextBox)row.Cells[0].Controls[0];
        TextBox textTown = (TextBox)row.Cells[1].Controls[0];
        TextBox textContactNo = (TextBox)row.Cells[2].Controls[0];
        TextBox textMobileNo = (TextBox)row.Cells[3].Controls[0];
        TextBox textSellerID = (TextBox)row.Cells[4].Controls[0];
        rptSellerInfo.EditIndex = -1;
        ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
        ResultDTO resultDto = new ResultDTO();
        if (!IsSellerNameExist(textSellerID.Text.Trim(), textSellerName.Text.Trim()))
        {
            resultDto = imp.UpdateSellerInfo(rptSellerInfo.DataKeys[e.RowIndex].Value.ToString(), textSellerName.Text,textTown.Text,textContactNo.Text,textMobileNo.Text);
            if (resultDto.IsSuccess)
            {
                rptSellerInfo.PageIndex = gridPageIndex;
                bindSellerInfo();
            }
            SetMessage(resultDto);
        }
        else
        {
            resultDto.Message = "Seller Name already exist.";
            resultDto.IsSuccess = false;
            SetMessage(resultDto);
        }
        //GridView1.DataBind();

    }
    protected void rptSellerInfo_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        rptSellerInfo.EditIndex = -1;
        rptSellerInfo.PageIndex = gridPageIndex;
        bindSellerInfo();
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
        ResultDTO resultDto = BinderSingleton.Instance.GetInstance<IValidateTransactionBusiness>().ValidateSellerDetails(txtSellerName.Text, txtCity.Text, txtDistrict.Text, txtState.Text, txtContactNo.Text);
        if (!IsSellerNameExist(string.Empty,txtSellerName.Text.Trim()))
        {
            if (resultDto.IsSuccess)
            {
                resultDto = imp.SaveSellerInfo(txtSellerName.Text.Trim(), txtStreet1.Text.Trim(), txtStreet2.Text.Trim(), txtTown.Text.Trim(), txtCity.Text.Trim(), txtDistrict.Text.Trim(), txtState.Text.Trim(), txtPincode.Text.Trim(), txtContactNo.Text.Trim(), txtMobileNo.Text.Trim(), txtPhoneNo.Text.Trim());
                if (resultDto.IsSuccess)
                {
                    bindSellerInfo();
                    ClearAllInputFields();
                }
                SetMessage(resultDto);
            }
            else
                SetMessage(resultDto);
        }
        else
        {
            resultDto.Message = "Seller Name already exist.";
            resultDto.IsSuccess = false;
            SetMessage(resultDto);
        }
    }
    private bool IsSellerNameExist(string SellerID,string SellerName)
    {
        ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
        return imp.CheckSellerNameExist(SellerID,SellerName);
    }
    protected void btnClear_Click(object sender, EventArgs e)
    {
        ClearAllInputFields();
    }
    private void ClearAllInputFields()
    {

        txtSellerName.Text = string.Empty;
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