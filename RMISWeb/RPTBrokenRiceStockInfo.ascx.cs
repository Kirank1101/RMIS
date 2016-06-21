using System;
using RMIS.Binder.BackEnd;
using RMIS.Domain.Business;
using RMIS.Domain.DataTranserClass;

public partial class RPTBrokenRiceStockInfo : BaseUserControl
{
    IMasterPaddyBusiness impb = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsControlPostBack)
        {
            Header = "Paddy Stock Information";
            ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
            ddlBrokenRiceType.DataSource = impb.GetMBrokenRiceTypeEntities();
            ddlBrokenRiceType.DataTextField = "BrokenRiceType";
            ddlBrokenRiceType.DataValueField = "Id";
            ddlBrokenRiceType.DataBind();

        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
    }

    private void ClearAllInputFields()
    {
        ddlBrokenRiceType.SelectedIndex = 0;
        
    }

}