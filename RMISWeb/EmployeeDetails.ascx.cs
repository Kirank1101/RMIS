using System;
using RMIS.Binder.BackEnd;
using RMIS.Domain.Business;
using RMIS.Domain.DataTranserClass;

public partial class EmployeeDetails : BaseUserControl
{
    ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsControlPostBack)
        {
            base.Header = "Add Employee";
            IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();

        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        ResultDTO resultDto = new ResultDTO();
        bool IsEmployeeExist = false;
        IsEmployeeExist = imp.CheckEmployeeExist(txtEmployeeName.Text.Trim());
        if (!IsEmployeeExist)
        {
            resultDto = BinderSingleton.Instance.GetInstance<IValidateTransactionBusiness>().ValidateEmployeeDetails(txtEmployeeName.Text, txtCity.Text, txtDistrict.Text, txtState.Text, txtContactNo.Text);
            if (resultDto.IsSuccess)
            {
                resultDto = imp.SaveEmployeeDetails(txtEmployeeName.Text.Trim(), txtStreet1.Text.Trim(), txtStreet2.Text.Trim(), txtTown.Text.Trim(), txtCity.Text.Trim(), txtDistrict.Text.Trim(), txtState.Text.Trim(), txtPincode.Text.Trim(), txtContactNo.Text.Trim(), txtMobileNo.Text.Trim(), txtPhoneNo.Text.Trim());
                SetMessage(resultDto);
                if (resultDto.IsSuccess)
                    ClearAllInputFields();
            }
            else
            {
                SetMessage(resultDto);
            }
        }
        else
        {
            resultDto.IsSuccess = false;
            resultDto.Message = "Emplyee already exist";
            SetMessage(resultDto);
        }
    }

    private void ClearAllInputFields()
    {
        txtEmployeeName.Text = string.Empty;
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