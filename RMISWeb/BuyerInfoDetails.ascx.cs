using System;
using RMIS.Binder.BackEnd;
using RMIS.Domain.Business;
using RMIS.Domain.DataTranserClass;
using System.Web.UI.WebControls;
using RMIS.Domain.Constant;

public partial class BuyerInfoDetails : BaseUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsControlPostBack)
        {
            Header = "Buyer Information";
            IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
            bindBuyerInfo();
        }
    }
    private void bindBuyerInfo()
    {
        int count = 0;
        ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();

        rptBuyerInfo.DataSource = imp.GetAllBuyerInfoEntities(rptBuyerInfo.PageIndex, rptBuyerInfo.PageSize, out count, expression);
        rptBuyerInfo.VirtualItemCount = count;
        rptBuyerInfo.DataBind();
    }
    protected void rptBuyerInfo_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        rptBuyerInfo.PageIndex = gridPageIndex = e.NewPageIndex;
        bindBuyerInfo();
    }
    protected void rptBuyerInfo_Sorting(object sender, GridViewSortEventArgs e)
    {
        if (expression == SortExpression.Asc)
            expression = SortExpression.Desc;
        else if (expression == SortExpression.Desc)
            expression = SortExpression.Asc;
        bindBuyerInfo();
    }
    protected void rptBuyerInfo_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        GridViewRow row = (GridViewRow)rptBuyerInfo.Rows[e.RowIndex];
        ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
        ResultDTO resultDto = new ResultDTO();

        resultDto = imp.DeleteBuyerInfo(rptBuyerInfo.DataKeys[e.RowIndex].Value.ToString());
        if (resultDto.IsSuccess)
            bindBuyerInfo();
        SetMessage(resultDto);


    }
    protected void rptBuyerInfo_RowEditing(object sender, GridViewEditEventArgs e)
    {
        rptBuyerInfo.EditIndex = e.NewEditIndex;
        rptBuyerInfo.PageIndex = gridPageIndex;
        bindBuyerInfo();

    }
    protected void rptBuyerInfo_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        GridViewRow row = (GridViewRow)rptBuyerInfo.Rows[e.RowIndex];
        TextBox textBuyerName = (TextBox)row.Cells[0].Controls[0];
        TextBox textTown = (TextBox)row.Cells[1].Controls[0];
        TextBox textContactNo = (TextBox)row.Cells[2].Controls[0];
        TextBox textMobileNo = (TextBox)row.Cells[3].Controls[0];
        rptBuyerInfo.EditIndex = -1;
        ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
        ResultDTO resultDto = new ResultDTO();
        if (!IsBuyerNameExist(textBuyerName.Text.Trim()))
        {
            resultDto = imp.UpdateBuyerInfo(rptBuyerInfo.DataKeys[e.RowIndex].Value.ToString(), textBuyerName.Text, txtTown.Text, txtContactNo.Text, txtMobileNo.Text);
            if (resultDto.IsSuccess)
            {
                rptBuyerInfo.PageIndex = gridPageIndex;
                bindBuyerInfo();
            }
            SetMessage(resultDto);
        }
        else
        {
            resultDto.Message = "Buyer Name already exist.";
            resultDto.IsSuccess = false;
            SetMessage(resultDto);
        }
        //GridView1.DataBind();

    }
    protected void rptBuyerInfo_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        rptBuyerInfo.EditIndex = -1;
        rptBuyerInfo.PageIndex = gridPageIndex;
        bindBuyerInfo();
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
        ResultDTO resultDto = BinderSingleton.Instance.GetInstance<IValidateTransactionBusiness>().ValidateBuyerDetails(txtBuyerName.Text, txtCity.Text, txtDistrict.Text, txtState.Text, txtContactNo.Text);
        if (!IsBuyerNameExist(txtBuyerName.Text.Trim()))
        {
            if (resultDto.IsSuccess)
            {
                resultDto = imp.SaveBuyerInfo(txtBuyerName.Text.Trim(), txtStreet1.Text.Trim(), txtStreet2.Text.Trim(), txtTown.Text.Trim(), txtCity.Text.Trim(), txtDistrict.Text.Trim(), txtState.Text.Trim(), txtPincode.Text.Trim(), txtContactNo.Text.Trim(), txtMobileNo.Text.Trim(), txtPhoneNo.Text.Trim());
                if (resultDto.IsSuccess)
                {
                    bindBuyerInfo();
                    ClearAllInputFields();
                }
                SetMessage(resultDto);
            }
            else
                SetMessage(resultDto);
        }
        else
        {
            resultDto.Message = "Buyer Name already exist.";
            resultDto.IsSuccess = false;
            SetMessage(resultDto);
        }
    }
    private bool IsBuyerNameExist(string BuyerName)
    {
        ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
        return imp.CheckBuyerNameExist(BuyerName);
    }
    protected void btnClear_Click(object sender, EventArgs e)
    {
        ClearAllInputFields();
    }
    private void ClearAllInputFields()
    {
        txtBuyerName.Text = string.Empty;
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