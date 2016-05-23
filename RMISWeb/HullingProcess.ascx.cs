using System;
using RMIS.Binder.BackEnd;
using RMIS.Domain.Business;
using RMIS.Domain.DataTranserClass;

public partial class HullingProcess : BaseUserControl
{
    IMasterPaddyBusiness impb = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsControlPostBack)
        {
            base.Header = "Paddy Stock Information";
            ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
            
            ddlPaddyType.DataSource = impb.GetMPaddyTypeEntities();
            ddlPaddyType.DataTextField = "PaddyType";
            ddlPaddyType.DataValueField = "Id";
            ddlPaddyType.DataBind();

            ddlUnitsType.DataSource = impb.GetMUnitsTypeEntities();
            ddlUnitsType.DataTextField = "UnitsType";
            ddlUnitsType.DataValueField = "Id";
            ddlUnitsType.DataBind();
        }
    }    
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        ResultDTO resultDto = BinderSingleton.Instance.GetInstance<IValidateTransactionBusiness>().ValidateHullingProcess(ddlPaddyType.SelectedIndex, ddlUnitsType.SelectedIndex, txtTotalBags.Text, txtHullingProcessBy.Text, txtHullingProcessDate.Text);
        if (resultDto.IsSuccess)
        {
            ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
            resultDto = imp.SaveHullingProcessInfo(ddlPaddyType.SelectedValue, ddlUnitsType.SelectedValue, Convert.ToInt16(txtTotalBags.Text.Trim()), txtHullingProcessBy.Text.Trim(),Convert.ToDateTime(txtHullingProcessDate.Text.Trim()), 'P');            
            
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
        ddlPaddyType.SelectedIndex = 0;
        ddlUnitsType.SelectedIndex = 0;
        txtTotalBags.Text = string.Empty;
        txtHullingProcessDate.Text = string.Empty;
        txtHullingProcessBy.Text = string.Empty;
    }

}