using System;
using RMIS.Binder.BackEnd;
using RMIS.Domain.Business;
using RMIS.Domain.DataTranserClass;

public partial class RPTPaymentInfo : BaseUserControl
{
    IMasterPaddyBusiness impb = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsControlPostBack)
        {
            base.Header = "Paddy Stock Information";
            


        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {


    }

    private void ClearAllInputFields()
    {
        ddlsellernames.SelectedIndex = 0;
    }

    
}