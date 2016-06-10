using System;
using RMIS.Binder.BackEnd;
using RMIS.Domain.Business;
using RMIS.Domain.DataTranserClass;
using System.Web.UI.WebControls;
using RMIS.Domain.RiceMill;
using RMIS.Domain.Constant;


public partial class DashBoard : BaseUserControl
{
        
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsControlPostBack)
        {
            Header = "";
            ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
            //imp.GetPaddyStockDTO(
            lblPaddyStock.Text = Convert.ToString(imp.GetMPaddyTypeEntitiesCount());
            lblRiceStock.Text = Convert.ToString(imp.GetMRiceProductionTypeCount());
            lblBrokenRiceStock.Text = Convert.ToString(imp.GetBrokenRiceStockInfoCount ());   
            int count=0;
            
        }
    }
   
}