using System;
using RMIS.Binder.BackEnd;
using RMIS.Domain.Business;
using RMIS.Domain.DataTranserClass;

public partial class RPTBagsAndDustStockInfo : BaseUserControl
{
    IMasterPaddyBusiness impb = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsControlPostBack)
        {
            ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();

            ddlBagType.DataSource = impb.GetMBagTypeEntities();
            ddlBagType.DataTextField = "BagType";
            ddlBagType.DataValueField = "Id";
            ddlBagType.DataBind();



        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
    }

    private void ClearAllInputFields()
    {
        ddlBagType.SelectedIndex = 0;
        
    }

}