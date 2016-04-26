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

public partial class AddSellerType : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            IPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IPaddyBusiness>();
            rptSellerType.DataSource = imp.GetMasterSellerTypeEntities();
            rptSellerType.DataBind();
        }   
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if(!string.IsNullOrEmpty(txtSellerType.Text.Trim()))
        {
            IPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IPaddyBusiness>();
            imp.SaveSellerType(txtSellerType.Text.Trim());
            imp = BinderSingleton.Instance.GetInstance<IPaddyBusiness>();
            rptSellerType.DataSource = imp.GetMasterSellerTypeEntities();
            rptSellerType.DataBind();

        }
    }
}
