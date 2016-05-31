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

public partial class BuyerSellerRating : BaseUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsControlPostBack)
        {
            Header = "Add Lot Information";
            
            ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
            ddlsellernames.DataSource = imp.GetPaddySellerInfo();
            ddlsellernames.DataTextField = "Name";
            ddlsellernames.DataValueField = "SellerID";
            ddlsellernames.DataBind();

        }
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        ResultDTO resultDto = BinderSingleton.Instance.GetInstance<IValidateTransactionBusiness>().ValidateBuyerSellerRating(ddlsellernames.SelectedIndex,Convert.ToInt16(rbtLstRating.SelectedValue),txtRemarks.Text.Trim());
        if (resultDto.IsSuccess)
        {
            ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
            resultDto = imp.SaveBuyerSellerRating(ddlsellernames.SelectedValue,Convert.ToInt16(rbtLstRating.SelectedValue),txtRemarks.Text.Trim());
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
        ddlsellernames.SelectedIndex = 0;
        rbtLstRating.ClearSelection();
        txtRemarks.Text = string.Empty;
    }
}
