using System;
using RMIS.Binder.BackEnd;
using RMIS.Domain.Business;
using RMIS.Domain.DataTranserClass;
using System.Web.UI.WebControls;


public partial class AddPaddyType : BaseUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsControlPostBack)
        {
            Header = "Add Paddy Information";            
            bindPaddyType();
        }
    }

    private void bindPaddyType()
    {
        int count = 0;
        IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
        rptPaddyType.DataSource = imp.GetMPaddyTypeEntities(rptPaddyType.PageIndex,rptPaddyType.PageSize,out count);
        rptPaddyType.VirtualItemCount = count;
        rptPaddyType.DataBind();
    }


    protected void rptPaddyType_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        rptPaddyType.PageIndex = e.NewPageIndex;
        bindPaddyType();
    }

    protected void rptPaddyType_Sorting(object sender, GridViewSortEventArgs e)
    {
        bindPaddyType();
    }


    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        ResultDTO resultDto = BinderSingleton.Instance.GetInstance<IValidateMasterBusiness>().ValiadtePaddyType(txtPaddyType.Text);
        if (resultDto.IsSuccess)
        {
            IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
            resultDto = imp.SavePaddyType(txtPaddyType.Text.Trim());
            if (resultDto.IsSuccess)
            {
                bindPaddyType();
            }
            SetMessage(resultDto);
        }
        else
        {
            SetMessage(resultDto);
        }
    }
}