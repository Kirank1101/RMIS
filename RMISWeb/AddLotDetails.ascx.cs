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
using System.Collections.Generic;

public partial class AddLotDetails : BaseUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsControlPostBack)
        {
            Header = "Add Lot Information";
            bindLotDetails();
            IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
            List<GodownTypeDTO> listGodownTypeDTO = imp.GetMGodownTypeEntities();
            ddlGodownName.DataSource = listGodownTypeDTO;
            ddlGodownName.DataTextField = GodownTypeDTO.dataColumnGodownType;
            ddlGodownName.DataValueField = GodownTypeDTO.dataColumnId;
            ddlGodownName.DataBind();
            ddlGodownName.Items.Insert(0, "[Select]");
        }
    }

    private void bindLotDetails()
    {
        IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
        rptLotDetails.DataSource = imp.GetLotDetailsEntities(ddlGodownName.SelectedValue);
        rptLotDetails.DataBind();
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        ResultDTO resultDto = BinderSingleton.Instance.GetInstance<IValidateMasterBusiness>().ValidateLotDetails(txtLotDetails.Text, ddlGodownName.SelectedValue);
        if (resultDto.IsSuccess)
        {
            IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
            resultDto = imp.SaveLotDetails(txtLotDetails.Text, ddlGodownName.SelectedValue);
            if (resultDto.IsSuccess)
            {
                bindLotDetails();
            }
            SetMessage(resultDto);
        }
        else
        {
            SetMessage(resultDto);
        }
    }
}