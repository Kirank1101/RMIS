using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using RMIS.Mediator.BackEnd;
using RMIS.Domain.RiceMill;
using RMIS.Domain;
using RMIS.Binder.BackEnd;
using RMIS.Domain.Mediator;
using RMIS.Domain.Business;

public partial class AddRiceType : BaseUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsControlPostBack)
        {
            Header = "Add Rice Type Information";
            IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
            BindRiceType(imp);
        }
    }

    private void BindRiceType(IMasterPaddyBusiness imp)
    {
        rptRiceType.DataSource = imp.GetRiceProductEntities();
        rptRiceType.DataBind();
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(txtRiceType.Text.Trim()))
        {
            IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
            imp.SaveSellerType(txtRiceType.Text.Trim());
            imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
            txtRiceType.Text = string.Empty;
        }
    }
}