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
using RMIS.Domain.DataTranserClass;

public partial class AddEmpDesig : BaseUserControl
{
    
        
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsControlPostBack)
        {
            Header = "Add Employee Designation";
            bindDesigType();
        }
    }

    private void bindDesigType()
    {
        IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>(); 
        rptDesigType.DataSource = imp.GetMEmpDesigTypeEntities();
        rptDesigType.DataBind();
    }


    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        bool IsDesigExist = false;
        IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>(); 
        IsDesigExist = imp.CheckEmpDesigExist(txtDesigType.Text.Trim());
        ResultDTO resultDto = new ResultDTO();
        if (!IsDesigExist)
        {
            resultDto = BinderSingleton.Instance.GetInstance<IValidateMasterBusiness>().ValidateDesignationType(txtDesigType.Text);
            if (resultDto.IsSuccess)
            {
                IMasterPaddyBusiness imp1 = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>(); 
                resultDto = imp1.SaveEmpDesigType(txtDesigType.Text.Trim());
                if (resultDto.IsSuccess)
                {
                    bindDesigType();
                }
                SetMessage(resultDto);
            }
            else
            {
                SetMessage(resultDto);
            }
        }
        else {
            resultDto.IsSuccess = false;
            resultDto.Message = "Designation Type already Exist.";
            SetMessage(resultDto);
        }
    }
}