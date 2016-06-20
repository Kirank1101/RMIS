using System;
using RMIS.Binder.BackEnd;
using RMIS.Domain.Business;
using RMIS.Domain.DataTranserClass;
using AllInOne.Common.Library.Util;
using System.Web.UI.WebControls;
public partial class BagStockInfo : BaseUserControl
{
            
    protected void Page_Load(object sender, EventArgs e)
    {
        IMasterPaddyBusiness impb = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
        if (!IsControlPostBack)
        {
            Header = "Add Bag Stock";
            ddlUnitsType.DataSource = impb.GetMUnitsTypeEntities();
            ddlUnitsType.DataTextField = "UnitsType";
            ddlUnitsType.DataValueField = "Id";
            ddlUnitsType.DataBind();

            ddlRiceBrand.DataSource = impb.GetRiceBrandEntities();
            ddlRiceBrand.DataTextField = "RiceBrand";
            ddlRiceBrand.DataValueField = "Id";
            ddlRiceBrand.DataBind();

            BindBagStockDetails();
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(txtDriverName.Text.Trim())  && !string.IsNullOrEmpty(txtsellerName.SelectedValue) 
            && !string.IsNullOrEmpty(txtVehicalNo.Text.Trim()) && !string.IsNullOrEmpty(txtTotalBags.Text.Trim()) 
            && !string.IsNullOrEmpty(txtpricePerBag.Text.Trim()) && !string.IsNullOrEmpty(txtPruchaseDate.Text.Trim()))
        {
            ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
            ResultDTO resultDto = new ResultDTO();
            resultDto =imp.SaveBagStockInfo(txtsellerName.SelectedValue, txtVehicalNo.Text.Trim(), txtDriverName.Text.Trim(), txtTotalBags.Text.ConvertToInt(), txtpricePerBag.Text.ConvertToDouble(), Convert.ToDateTime(txtPruchaseDate.Text.Trim()),string.IsNullOrEmpty(ddlRiceBrand.SelectedValue)?null:ddlRiceBrand.SelectedValue, ddlUnitsType.SelectedValue);
            if (resultDto.IsSuccess)
            {
                BindBagStockDetails();
                ClearAllInputFields();
            }
            SetMessage(resultDto);
            

        }
    }

    private void BindBagStockDetails()
    {
        int count = 0;
        ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
        rptBagStockInfo.DataSource = imp.GetBagStockDTO(rptBagStockInfo.PageIndex, rptBagStockInfo.PageSize, out count, expression);
        rptBagStockInfo.VirtualItemCount = count;
        rptBagStockInfo.DataBind();
    }

    protected void rptBagStockInfo_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        rptBagStockInfo.PageIndex = gridPageIndex = e.NewPageIndex;
        BindBagStockDetails();
    }
    private void ClearAllInputFields()
    {
        //ddlBagType.SelectedIndex = 0;
        txtVehicalNo.Text = string.Empty;
        txtDriverName.Text = string.Empty;
        txtTotalBags.Text = string.Empty;
        txtpricePerBag.Text = string.Empty;
        txtPruchaseDate.Text = string.Empty;
    }

}