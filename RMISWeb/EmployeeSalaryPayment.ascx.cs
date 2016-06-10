using System;
using RMIS.Domain.RiceMill;
using RMIS.Binder.BackEnd;
using RMIS.Domain.Business;
using RMIS.Domain.DataTranserClass;
using System.Collections.Generic;

public partial class EmployeeSalaryPayment : BaseUserControl
{
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

            ddlSalaryType.Items.Insert(0, "[Select]");

            ddlDesignation.Items.Insert(0, "[Select]");
            txtSalary.Text = "0";
            txtSalaryPaid.Text = "0";
            txtOTPay.Text = "0";
            

            //BindEmployeeSalaryInfo();
        }
    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
        EmployeeSalaryEntity EmpSalEnty = impt.GetEmployeeSalaryEntity(ddlEmployeeName.SelectedValue);
        if (EmpSalEnty != null)
        {
            List<MEmpDesigDTO> lstmempdesig = new List<MEmpDesigDTO>();
            MEmpDesigDTO objMEmpDesigDTO = new MEmpDesigDTO();
            objMEmpDesigDTO.Id = EmpSalEnty.MEmpDsgID;
            objMEmpDesigDTO.DesignationType = imp.GetEmployeeDesignation(EmpSalEnty.MEmpDsgID);
            lstmempdesig.Add(objMEmpDesigDTO);
            ddlDesignation.DataSource = lstmempdesig;
            ddlDesignation.DataTextField = MEmpDesigDTO.dataColumnText;
            ddlDesignation.DataValueField = MEmpDesigDTO.dataColumnId;
            ddlDesignation.DataBind();

            List<MSalarytypeDTO> lstMSalarytypeDTO = new List<MSalarytypeDTO>();
            MSalarytypeDTO msaltype = new MSalarytypeDTO();
            msaltype.Id = EmpSalEnty.MSalaryTypeID;
            msaltype.SalaryType = imp.GetSalaryType(EmpSalEnty.MSalaryTypeID);
            lstMSalarytypeDTO.Add(msaltype);
            ddlSalaryType.DataSource = lstMSalarytypeDTO;
            ddlSalaryType.DataTextField = MSalarytypeDTO.dataColumnText;
            ddlSalaryType.DataValueField = MSalarytypeDTO.dataColumnId;
            ddlSalaryType.DataBind();

            txtSalary.Text = Convert.ToString(EmpSalEnty.Salary);
            txtSalaryPaid.Text = "0";
            txtOTPay.Text = "0";
            BindEmployeePaymentDetails(ddlEmployeeName.SelectedValue);
        }
        else {
            ResultDTO resultDto = new ResultDTO();
            resultDto.IsSuccess = false;
            resultDto.Message = "Salary is not configured for this Employee. ";
            SetMessage(resultDto);
        }
    }

    private void BindEmployeePaymentDetails(string EmployeeID)
    {
        List<EmployeeSalaryPaymentEntity> lstEmpSalPaymentEnt = new List<EmployeeSalaryPaymentEntity>();
        lstEmpSalPaymentEnt = impt.GetSalaryPaymentOnEmployee(EmployeeID);
        rptSalaryDetails.DataSource = lstEmpSalPaymentEnt;
        rptSalaryDetails.DataBind();
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        ResultDTO resultDto = new ResultDTO();
    
        resultDto = BinderSingleton.Instance.GetInstance<IValidateTransactionBusiness>().ValidateEmployeeSalaryPayment(ddlEmployeeName.SelectedIndex, ddlSalaryType.SelectedIndex, ddlDesignation.SelectedIndex, Convert.ToDouble(txtSalary.Text.Trim()), Convert.ToDouble(txtSalaryPaid.Text.Trim()), Convert.ToDouble(txtOTPay.Text.Trim()));
        if (resultDto.IsSuccess)
        {
            resultDto = impt.SaveEmployeeSalaryPayment(ddlEmployeeName.SelectedValue, ddlSalaryType.SelectedValue, ddlDesignation.SelectedValue, Convert.ToDouble(txtSalary.Text.Trim()), Convert.ToDouble(txtSalaryPaid.Text.Trim()), Convert.ToDouble(txtOTPay.Text.Trim()));
            if (resultDto.IsSuccess)
            {
                ClearData();
            }
            SetMessage(resultDto);
        }
        else
        {
            SetMessage(resultDto);
        }

    }

    private void ClearData()
    {
        ddlEmployeeName.SelectedIndex = 0;
        ddlSalaryType.Items.Insert(0, "[Select]");
        ddlDesignation.Items.Insert(0, "[Select]");
        txtSalary.Text = "0";
        txtSalaryPaid.Text = "0";
        txtOTPay.Text = "0";
    }
}
