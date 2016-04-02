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

public partial class PostBackSample : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        LabelSource.Text = "Button1";
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        LabelSource.Text = "LinkButton";        
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        LabelSource.Text = "DropDownList1 (" + DropDownList1.SelectedValue + ")";
    }
}
