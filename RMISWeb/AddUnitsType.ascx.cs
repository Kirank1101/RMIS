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

public partial class AddUnitsType : BaseUserControl
{
    IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
            
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsControlPostBack)
        {
            Header = "Add Unit type Information";
            bindUnitType();
        }
    }


    private void bindUnitType()
    {
        rptUnitsType.DataSource = imp.GetMUnitsTypeEntities();
        rptUnitsType.DataBind();
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        ResultDTO resultDto = BinderSingleton.Instance.GetInstance<IValidateMasterBusiness>().ValidateUnitsType(txtUnitsType.Text);
        bool IsUnitTypeExist = imp.CheckUnitTypeExist(txtUnitsType.Text.Trim());
        if (!IsUnitTypeExist)
        {
            if (resultDto.IsSuccess)
            {
                resultDto = imp.SaveUnitsType(txtUnitsType.Text.Trim());
                if (resultDto.IsSuccess)
                {
                    bindUnitType();
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
            resultDto.Message = "Already UnitType exist.";
            SetMessage(resultDto);
        }
    }
}