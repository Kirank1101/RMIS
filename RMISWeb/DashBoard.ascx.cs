﻿using System;
using RMIS.Binder.BackEnd;
using RMIS.Domain.Business;
using RMIS.Domain.DataTranserClass;
using System.Web.UI.WebControls;
using RMIS.Domain.RiceMill;
using RMIS.Domain.Constant;
using System.Collections.Generic;


public partial class DashBoard : BaseUserControl
{
        
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsControlPostBack)
        {
            Header = "";        
        }
    }
   
}