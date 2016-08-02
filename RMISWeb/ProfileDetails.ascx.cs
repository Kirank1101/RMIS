using System;
using RMIS.Binder.BackEnd;
using RMIS.Domain.Business;
using RMIS.Domain.DataTranserClass;

public partial class ProfileDetails : BaseUserControl
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsControlPostBack)
        {
            Header = "Profile Details";
            ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
            ProfileDTO profile = imp.GetMyProfile();
            if (profile != null)
            {
                txtMillName.Text = profile.MillName;
                txtTINNumber.Text = profile.TINNumber;
                txtStreet1.Text = profile.Street1;
                txtStreet2.Text = profile.Street2;
                txtTown.Text = profile.Town;
                txtCity.Text = profile.City;
                txtDistrict.Text = profile.District;
                txtState.Text = profile.State;
                txtPincode.Text = Convert.ToString(profile.PinCode);
                txtContactNo.Text = profile.ContactNo;
                txtMobileNo.Text = profile.MobileNo;
                txtPhoneNo.Text = profile.PhoneNo;

            }

        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
        ResultDTO resultDto = new ResultDTO();
            resultDto = BinderSingleton.Instance.GetInstance<IValidateTransactionBusiness>().ValidateProfileDetails(txtMillName.Text,txtTINNumber.Text, txtCity.Text, txtDistrict.Text, txtState.Text,txtPincode.Text, txtContactNo.Text);
            if (resultDto.IsSuccess)
            {
                resultDto = imp.SaveProfileDetails(txtMillName.Text.Trim(), txtTINNumber.Text, txtStreet1.Text.Trim(), txtStreet2.Text.Trim(), txtTown.Text.Trim(), txtCity.Text.Trim(), txtDistrict.Text.Trim(), txtState.Text.Trim(), txtPincode.Text.Trim(), txtContactNo.Text.Trim(), txtMobileNo.Text.Trim(), txtPhoneNo.Text.Trim());
                SetMessage(resultDto);
                if (resultDto.IsSuccess)
                    ClearAllInputFields();
            }
            else
            {
                SetMessage(resultDto);
            }

    }

    private void ClearAllInputFields()
    {
        txtMillName.Text = string.Empty;
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