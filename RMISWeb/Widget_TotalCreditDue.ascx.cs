using System;
using RMIS.Binder.BackEnd;
using RMIS.Domain.Business;
using RMIS.Domain.DataTranserClass;
using System.Web.UI.WebControls;
using RMIS.Domain.RiceMill;
using RMIS.Domain.Constant;
using System.Collections.Generic;


public partial class Widget_TotalCreditDue : BaseUserControl
{          
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsControlPostBack)
        {
            Header = "";
            ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
            rptWidget.DataSource = imp.GetProductTotalAmountDueWidget();
            rptWidget.DataBind();  
        }
    }
   
}