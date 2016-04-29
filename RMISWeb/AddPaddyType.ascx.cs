using System;
using RMIS.Binder.BackEnd;
using RMIS.Domain.Business;


public partial class AddPaddyType : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
            BindPaddyType(imp);
        }
    }

    private void BindPaddyType(IMasterPaddyBusiness imp)
    {
        rptPaddyType.DataSource = imp.GetMPaddyTypeEntities();
        rptPaddyType.DataBind();
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(txtPaddyType.Text.Trim()))
        {
            IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
            imp.SavePaddyType(txtPaddyType.Text.Trim());
            imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
            txtPaddyType.Text = string.Empty;
        }
    }
}