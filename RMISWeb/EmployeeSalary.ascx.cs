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

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsControlPostBack)
        {
            Header = "Add Employee Salary";
            IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
            ITransactionBusiness impt = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();

            List<EmployeeDetailsEntity> listemployeedetails = impt.GetEmployeeDetails();
            ddlEmployeeName.DataSource = listemployeedetails;
            ddlEmployeeName.DataTextField = "Name";
            ddlEmployeeName.DataValueField = "EmployeeID";
            ddlEmployeeName.DataBind();
            ddlEmployeeName.Items.Insert(0, "[Select]");
            List<MSalarytypeDTO> listSalarytypedetails = imp.GetMSalaryTypeEntities();
            ddlSalaryType.DataSource = listSalarytypedetails;
            ddlSalaryType.DataTextField = "SalaryType";
            ddlSalaryType.DataValueField = "Id";
            ddlSalaryType.DataBind();
            ddlSalaryType.Items.Insert(0, "[Select]");
            List<MEmpDesigDTO> listMEmpDesigDTO = imp.GetMEmpDesigTypeEntities();
            ddlDesignation.DataSource = listMEmpDesigDTO;
            ddlDesignation.DataTextField = "DesignationType";
            ddlDesignation.DataValueField = "Id";
            ddlDesignation.DataBind();
            ddlDesignation.Items.Insert(0, "[Select]");

            BindEmployeeSalaryInfo();
        }
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {

        ResultDTO resultDto = new ResultDTO();
        ITransactionBusiness impt = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();

        bool IsSalaryAlotedtoEmployee = false;
        IsSalaryAlotedtoEmployee = impt.CheckEmployeeSalaryExist(txtSalary.Text.Trim());
        if (!IsSalaryAlotedtoEmployee)
        {
            resultDto = BinderSingleton.Instance.GetInstance<IValidateTransactionBusiness>().ValidateEmployeeSalary(ddlEmployeeName.SelectedIndex, ddlSalaryType.SelectedIndex, ddlDesignation.SelectedIndex, Convert.ToDouble(txtSalary.Text.Trim()));
            if (resultDto.IsSuccess)
            {
                resultDto = impt.SaveEmployeeSalary(ddlEmployeeName.SelectedValue, ddlSalaryType.SelectedValue, ddlDesignation.SelectedValue, Convert.ToDouble(txtSalary.Text.Trim()));
                if (resultDto.IsSuccess)
                {
                    BindEmployeeSalaryInfo();
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
            resultDto.Message = "Salary already aloted.";
            resultDto.IsSuccess = false;
            SetMessage(resultDto);
        }
    }

    private void BindEmployeeSalaryInfo()
    {
        ITransactionBusiness impt = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
        IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();

        List<EmployeeSalaryEntity> lstemployeesalary = impt.GetEmployeeSalary();
        if (lstemployeesalary != null && lstemployeesalary.Count > 0)
        {
            foreach (EmployeeSalaryEntity empsal in lstemployeesalary)
            {
                empsal.EmployeeID = impt.GetEmployeeName(empsal.EmployeeID);
                empsal.MEmpDsgID = imp.GetEmployeeDesignation(empsal.MEmpDsgID);
                empsal.MSalaryTypeID = imp.GetSalaryType(empsal.MSalaryTypeID);
            }
            rptSalaryDetails.DataSource = lstemployeesalary;
            rptSalaryDetails.DataBind();
        }
    }

}