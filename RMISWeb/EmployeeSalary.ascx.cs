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

public partial class EmployeeSalary : BaseUserControl
{
    IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
    ITransactionBusiness impt = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsControlPostBack)
        {
            Header = "Add Employee Salary";
            
            List<EmployeeDetailsEntity> listemployeedetails = impt.GetEmployeeDetails();
            ddlEmployeeName.DataSource = listemployeedetails;
            ddlEmployeeName.DataTextField = "Name";
            ddlEmployeeName.DataValueField = "EmployeeID";
            ddlEmployeeName.DataBind();
            ddlEmployeeName.Items.Insert(0, "[Select]");
            List<MSalartytypeDTO> listSalarytypedetails = imp.GetMSalaryTypeEntities();
            ddlSalaryType.DataSource = listSalarytypedetails;
            ddlSalaryType.DataTextField = "SalartyType";
            ddlSalaryType.DataValueField = "Id";
            ddlSalaryType.DataBind();
            ddlSalaryType.Items.Insert(0, "[Select]");
            List<MEmpDesigDTO> listMEmpDesigDTO = imp.GetMEmpDesigTypeEntities();
            ddlDesignation.DataSource = listMEmpDesigDTO;
            ddlDesignation.DataTextField = "DesignationType";
            ddlDesignation.DataValueField = "Id";
            ddlDesignation.DataBind();
            ddlDesignation.Items.Insert(0, "[Select]");


        }
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        ResultDTO resultDto = new ResultDTO();
        bool IsSalaryAlotedtoEmployee = false;
        //IsSalaryAlotedtoEmployee = imp.CheckLotNameExist(txtLotDetails.Text.Trim());
        //if (!IsLotNameExist)
        //{
        //    resultDto = BinderSingleton.Instance.GetInstance<IValidateMasterBusiness>().ValidateLotDetails(txtLotDetails.Text, ddlGodownName.SelectedValue);
        //    if (resultDto.IsSuccess)
        //    {
        //        resultDto = imp.SaveLotDetails(txtLotDetails.Text, ddlGodownName.SelectedValue);
        //        if (resultDto.IsSuccess)
        //        {
        //            bindLotDetails();
        //        }
        //        SetMessage(resultDto);
        //    }
        //    else
        //    {
        //        SetMessage(resultDto);
        //    }
        //}
        //else
        //{
        //    resultDto.Message = "LotName already Exist.";
        //    resultDto.IsSuccess = false;
        //    SetMessage(resultDto);
        //}
    }
    
}