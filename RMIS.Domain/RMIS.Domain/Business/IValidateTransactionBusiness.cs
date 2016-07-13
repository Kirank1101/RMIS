using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RMIS.Domain.DataTranserClass;

namespace RMIS.Domain.Business
{
    public interface IValidateTransactionBusiness
    {
        ResultDTO ValidateSellerDetails(string sellerName, string city, string district, string state, string contactNo);
        ResultDTO ValidatePaddyStockDetails(int godown, int lot, int Unitstype, int paddy, string SellerName, string vehicleNo, string totalbags, string price, string purchaseDate
           );
        ResultDTO ValidateRiceStockDetails(int RiceType, int RiceBrand, int UnitsType, string totalbags);
        ResultDTO ValidateBrokenRiceStockDetails(int BrokenRiceType, int UnitsType, string totalbags);

        ResultDTO ValidateDustStockDetails(int UnitsType, string totalbags);
        ResultDTO ValidateProductSellingDetails(int ProductSellingTypeId, string ProductSellingType, string ByerName, int RiceType, int RiceBrand, int BrokenRiceType, int UnitsType, string totalbags, string price, string SellingDate,string NextPayDate);
        ResultDTO ValidateHullingProcess(int paddyType, int UnitsType, string totalbags, string ProcessBy, string ProcessDate);
        ResultDTO ValidateHullingProcessTrans(int Ricestockadded, int BrokenRiceStockadded, int RiceType, int BrokenRiceType, int RiceUnitsType, int BrokenRiceUnitsType, int DustUnitsType, string Ricetotalbags, string BrokenRicetotalbags, string Dusttotalbags, string BrokenRicePrice, string DustPrice, int RiceBrand);
        ResultDTO ValidateBuyerSellerRating(int SellerID, Int16 Rating, string Remark);
        ResultDTO ValidateBuyerDetails(string BuyerName, string city, string district, string state, string contactNo);
        ResultDTO ValidateEmployeeDetails(string EmployeeName, string city, string district, string state, string contactNo);
        ResultDTO ValidateEmployeeSalary(int EmployeeName, int SalaryType, int Designation, double Salary);
        ResultDTO ValidateEmployeeSalaryPayment(int EmployeeName, int SalaryType, int Designation, double Salary, double SalaryPaid, double OTCharges);
        ResultDTO ValidateOtherExpenses(string p, string p_2, double p_3);
        ResultDTO ValidateProductPaymentDetails(int PaymentMode, string Buyername, double ReceivedAmount, double TotalDueAmount);
        ResultDTO ValidateMediatorDetails(string MediatorName, string city, string district, string state, string contactNo);
        ResultDTO ValidateExpenseTransaction(int ExpenseType, string Name, string Reason, double Amount,string PayDate);
        ResultDTO ValidateRentHullingTransaction(int JobWorkType, string Name, string PaddyType, int TotalBags, double Price, string ProcessDate);
        ResultDTO ValidatePaddyStockReport(string SellerName, string PurchaseDateFrom, string PurchaseDateTo);
        ResultDTO ValidateBankBalance(double BankBalance);
    }
}
