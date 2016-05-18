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

public partial class AddBrokenRiceType : BaseUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsControlPostBack)
        {
            Header = "Add Rice Type Information";
            bindBrokenRiceType();
        }
    }

    private void bindBrokenRiceType()
    {
        IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
        rptBrokenRiceType.DataSource = imp.GetMBrokenRiceTypeEntities();
        rptBrokenRiceType.DataBind();
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        ResultDTO resultDto = BinderSingleton.Instance.GetInstance<IValidateMasterBusiness>().ValidateBrokenRiceType(txtBrokenRiceType.Text);
        if (resultDto.IsSuccess)
        {
            IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
            resultDto = imp.SaveBrokenRiceType(txtBrokenRiceType.Text.Trim());
            if (resultDto.IsSuccess)
            {
                bindBrokenRiceType();
            }
            SetMessage(resultDto);
        }
        else
        {
            SetMessage(resultDto);
        }
    }
}