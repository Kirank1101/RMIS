using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RMIS.Domain.DataTranserClass;

namespace RMIS.Domain.Business
{
    public interface IValidateMasterBusiness
    {
        ResultDTO ValidateGodownDetails(string GodownName);
        ResultDTO ValidateBagType(string BagType);
        ResultDTO ValidateBrokenRiceType(string BrkenRiceType);
        ResultDTO ValidateUnitsType(string UnitsType);
        ResultDTO ValiadtePaddyType(string paddyType);
        ResultDTO ValidateGodownType(string godownType);
        ResultDTO ValidateRiceBrandType(string riceBrand);
        ResultDTO ValidateRiceProductType(string riceProduct);
        ResultDTO ValidateLotDetails(string lotName, string godownId);
        ResultDTO ValidateDesignationType(string DesignationType);
        ResultDTO ValidateSalaryType(string SalaryType);
        ResultDTO ValidateExpenseType(string ExpenseType);
    }
}
