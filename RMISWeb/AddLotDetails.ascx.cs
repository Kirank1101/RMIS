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

public partial class AddLotDetails : BaseUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsControlPostBack)
        {
            Header = "Add Lot Information";
            IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
            BindLotDetails(imp);
           
        }
    }

    private void BindLotDetails(IMasterPaddyBusiness imp)
    {
        rptLotDetails.DataSource = imp.GetLotDetailsEntities(ddlGodownName.SelectedValue);
        rptLotDetails.DataBind();
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(txtLotDetails.Text.Trim()))
        {
            IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
            imp.SaveSellerType(txtLotDetails.Text.Trim());
            imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
            txtLotDetails.Text = string.Empty;
        }
    }
}