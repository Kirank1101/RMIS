﻿using System;
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

public partial class AddGodownDetails : BaseUserControl
{
    
        
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsControlPostBack)
        {
            Header = "Add Godown Information";            
            bindGodownDetails();
        }
    }

    private void bindGodownDetails()
    {
        IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
        rptGodownDetails.DataSource = imp.GetMGodownTypeEntities();
        rptGodownDetails.DataBind();
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        bool IsGodownExist = false;
        ResultDTO resultDto = new ResultDTO();
        IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
        IsGodownExist = imp.CheckGodownNameExist(txtGodownName.Text.Trim());
        if (!IsGodownExist)
        {
            resultDto = BinderSingleton.Instance.GetInstance<IValidateMasterBusiness>().ValidateGodownDetails(txtGodownName.Text);
            if (resultDto.IsSuccess)
            {
                IMasterPaddyBusiness imp1 = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
                resultDto = imp1.SaveGodownType(txtGodownName.Text.Trim());
                if (resultDto.IsSuccess)
                {
                    bindGodownDetails();
                }
                SetMessage(resultDto);
            }
            else
            {
                SetMessage(resultDto);
            }
        }
        else
        {            
            resultDto.Message = "GodownName already Exist.";
            resultDto.IsSuccess = false;
            SetMessage(resultDto);
        }
    }
}