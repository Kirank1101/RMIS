﻿using System;
using RMIS.Binder.BackEnd;
using RMIS.Domain.Business;
using RMIS.Domain.DataTranserClass;
using System.Web.UI.WebControls;
using RMIS.Domain.Constant;

public partial class PaddyStockInfo : BaseUserControl
{
    IMasterPaddyBusiness impb = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsControlPostBack)
        {
            //base.Header = "Paddy Stock Information";
            ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
            ddlsellernames.DataSource = imp.GetPaddySellerInfo();
            ddlsellernames.DataTextField = "Name";
            ddlsellernames.DataValueField = "SellerID";
            ddlsellernames.DataBind();

            ddlPaddyType.DataSource = impb.GetMPaddyTypeEntities();
            ddlPaddyType.DataTextField = "PaddyType";
            ddlPaddyType.DataValueField = "Id";
            ddlPaddyType.DataBind();

            ddlGodownname.DataSource = impb.GetMGodownTypeEntities();
            ddlGodownname.DataTextField = "GodownType";
            ddlGodownname.DataValueField = "Id";
            ddlGodownname.DataBind();

            ddlUnitsType.DataSource = impb.GetMUnitsTypeEntities();
            ddlUnitsType.DataTextField = "UnitsType";
            ddlUnitsType.DataValueField = "Id";
            ddlUnitsType.DataBind();

            bindPaddyStockInfo();
        }
    }



    private void bindPaddyStockInfo()
    {
        int count = 0;
        ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
        rptPaddyStockInfo.DataSource = imp.GetPaddyStockDTO(rptPaddyStockInfo.PageIndex, rptPaddyStockInfo.PageSize, out count, expression);
        rptPaddyStockInfo.VirtualItemCount = count;
        rptPaddyStockInfo.DataBind();
    }

    protected void ddlGodownSelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlGodownname.SelectedIndex > -1)
        {
            ddlLotDetails.Items.Clear();
            ddlLotDetails.Items.Insert(0, "[Select]");
            ddlLotDetails.DataSource = impb.GetLotDetailsEntities(ddlGodownname.SelectedValue);
            ddlLotDetails.DataTextField = "LotDetails";
            ddlLotDetails.DataValueField = "Id";
            ddlLotDetails.DataBind();
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        ResultDTO resultDto = BinderSingleton.Instance.GetInstance<IValidateTransactionBusiness>().ValidatePaddyStockDetails(ddlGodownname.SelectedIndex, ddlLotDetails.SelectedIndex, ddlUnitsType.SelectedIndex, ddlPaddyType.SelectedIndex, ddlsellernames.SelectedIndex, txtVehicalNo.Text, txtTotalBags.Text, txtPrice.Text, txtPruchaseDate.Text);
        if (resultDto.IsSuccess)
        {
            ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
            resultDto = imp.SavePaddyStockInfo(ddlsellernames.SelectedValue, ddlPaddyType.SelectedValue, ddlGodownname.SelectedValue, ddlLotDetails.SelectedValue, ddlUnitsType.SelectedValue, txtVehicalNo.Text.Trim(), txtDriverName.Text.Trim(), Convert.ToDecimal(txtTotalBags.Text.Trim()), Convert.ToDecimal(txtPrice.Text.Trim()), Convert.ToDateTime(txtPruchaseDate.Text.Trim()));
            SetMessage(resultDto);
            if (resultDto.IsSuccess)
                ClearAllInputFields();
            bindPaddyStockInfo();
        }
        else
        {
            SetMessage(resultDto);
        }

    }


    protected void rptPaddyStockInfo_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        rptPaddyStockInfo.PageIndex = gridPageIndex = e.NewPageIndex;
        bindPaddyStockInfo();
    }



    private void ClearAllInputFields()
    {
        ddlPaddyType.SelectedIndex = 0;
        ddlsellernames.SelectedIndex = 0;
        ddlGodownname.SelectedIndex = 0;
        ddlLotDetails.SelectedIndex = 0;
        txtVehicalNo.Text = string.Empty;
        txtTotalBags.Text = string.Empty;
        txtPrice.Text = string.Empty;
        txtPruchaseDate.Text = string.Empty;
    }

}