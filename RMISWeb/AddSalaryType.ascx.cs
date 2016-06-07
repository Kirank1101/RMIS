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

public partial class AddSalaryType : BaseUserControl
{
    IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
        
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsControlPostBack)
        {
            Header = "Add Salary Type";
            bindSalaryType();
        }
    }

    private void bindSalaryType()
    {
        rptSalaryType.DataSource = imp.GetMSalaryTypeEntities();
        rptSalaryType.DataBind();
    }


    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        bool IsSalaryTypeExist = false;
        IsSalaryTypeExist = imp.CheckSalaryTypeExist(txtSalaryType.Text.Trim());
        ResultDTO resultDto = new ResultDTO();
        if (!IsSalaryTypeExist)
        {
            resultDto = BinderSingleton.Instance.GetInstance<IValidateMasterBusiness>().ValidateSalaryType(txtSalaryType.Text);
            if (resultDto.IsSuccess)
            {
                resultDto = imp.SaveSalartyType(txtSalaryType.Text.Trim());
                if (resultDto.IsSuccess)
                {
                    bindSalaryType();
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
            resultDto.Message = "Salary Type already Exist.";
            SetMessage(resultDto);
        }
    }
}