using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RMIS.Domain.DataTranserClass;
using RMIS.Domain.RiceMill;
using RMIS.Domain.Constant;

namespace RMIS.Domain.Business
{
    public interface ITransactionBusiness
    {
        ResultDTO SaveSellerInfo(string name,
           string street, string street1, string town, string city, string district, string state,
           string pincode, string contactNo, string mobileNo, string phoneNo);
        ResultDTO SavePaddyStockInfo(string sellerId, string paddyTypeId,
           string godownId, string lotId, string UnitsTypeID, string vehicleNo, string DriverName, decimal totalBags, decimal Price,
           DateTime purchaseDate, double AmountPaid, DateTime PaidDate, string HandOverTo, DateTime NextPaymentDate, string PaymentMode, string ChequeuNo, string BankName);
        ResultDTO SaveBagStockInfo(string sellerId, string BagTypeId,
                     string vehicleNo, string DriverName, int totalBags, decimal Price,
                     DateTime purchaseDate);
        ResultDTO SavePaddyPaymentDetails(string sellerId, double amountPaid,
           DateTime paidDate, string handOverTo, DateTime nextPaymentDate, string PaddyStockID, string PaymentMode, string ChequeuNo, string BankName);
        ResultDTO SaveRiceStockInfo(string MRiceProdTypeID, string MRiceBrandID, int totalBags, int QWeight, string UnitsTypeID);
        ResultDTO SaveBrokenRiceStockInfo(string BrokenRiceTypeId, int totalBags, int QWeight, string UnitsTypeID);
        ResultDTO SaveDustStockInfo(int totalBags, int QWeight, string UnitsTypeID);
        ResultDTO SaveRiceSellingInfo(string sellerId, string MRiceProdTypeID, string MRiceBrandId,
            string vehicleNo, string DriverName, int totalBags, int qWeight, string UnitsTypeID, int qPrice,
            DateTime SellingDate);
        ResultDTO SaveBrokenRiceSellingInfo(string sellerId, string BrokenRiceTypeId, string vehicleNo, string DriverName,
            int totalBags, int qWeight, string UnitsTypeID, int qPrice, DateTime SellingDate);
        ResultDTO SaveDustSellingInfo(string sellerId, string vehicleNo, string DriverName, int totalBags,
            int qWeight, string UnitsTypeID, int qPrice, DateTime SellingDate);
        bool SaveCustomerInformation(string customerName, string organizationName, string custId);
        bool SaveMenuConfiguration(string custId, string roleId, string menuId);
        ResultDTO SaveProductSellingInfo(string SellingProductType, string sellerId, string MRiceProdTypeID, string MRiceBrandId, string BrokenRiceTypeId,
                                         decimal totalBags, string UnitsTypeID, double Price, DateTime SellingDate, string OrderNo, string PaymnetMode,
                                         string ChequeNo, string DDno, string BankName, double ReceivedAmount, DateTime NextPaymentDate);
        ResultDTO SaveHullingProcessInfo(string PaddyTypeID, string UnitsTypeID, int TotalBags, string ProcessBy, DateTime ProcessDate, char Status);
        ResultDTO SaveHullingProcessTransInfo(string HullingProcessID, string ProductTypeID, string PaddyTypeID, string RiceType, string BrokenRiceType, char IsDust, string UnitsTypeID, int TotalBags, double Price);
        ResultDTO SaveÜserInfo(string userName, string passWord, string custId);
        ResultDTO SaveÜserRole(string userId, string roleId, string custId);
        ResultDTO SaveHullingProcessExpensesInfo(string HullingProcessID, double PowerExpenses, double LabourExpenses, double OtherExpenses);
        ResultDTO SaveBuyerSellerRating(string SellerID, Int16 Rating, string Remarks);
        ResultDTO SaveBuyerInfo(string name, string street, string street1, string town, string city, string district, string state,
                   string pincode, string contactNo, string mobileNo, string phoneNo);
        ResultDTO SaveEmployeeDetails(string name,
           string street, string street1, string town, string city, string district, string state,
           string pincode, string contactNo, string mobileNo, string phoneNo);
        ResultDTO SaveEmployeeSalary(string EmployeeID, string SalaryTypeID, string EmpDesigID, double Salary);
        ResultDTO SaveEmployeeSalaryPayment(string EmployeeID, string SalaryTypeID, string EmpDesigID, double Salary, double AmountSpent, double ExtraCharges);
        ResultDTO SaveOtherExpenses(string Description, string GivenTo, double PaidAmount);
        ResultDTO SaveProductPaymentInfo(double TotalAmount, char Status);

        List<SellerInfoEntity> GetPaddySellerInfo();
        List<RiceStockInfoEntity> GetAllRiceStockInfoEntities();
        List<BrokenRiceStockInfoEntity> GetAllBrokenRiceStockInfoEntities();
        List<DustStockInfoEntity> GetAllDustStockInfoEntities();
        List<RiceSellingInfoEntity> GetAllRiceSellingInfoEntities();
        List<BrokenRiceSellingInfoEntity> GetAllBrokenRiceSellingInfoEntities();
        List<DustSellingInfoEntity> GetAllDustSellingInfoEntities();
        List<CustomerInfoEntity> GetAllCustomerInfoEntities();
        List<ProductSellingInfoEntity> GetAllProductSellingInfoEntities();
        List<MenuConfigurationEntity> GetMenuConfigurationEntities();
        List<MenuConfigurationEntity> GetMenuConfigurationEntities(string custId);
        List<HullingProcessEntity> GetAllHullingProcessInfoEntities();
        List<HullingProcessTransactionEntity> GetAllHullingProcessTransInfoEntities();
        UsersEntity ValidateUsersEntity(string userName, string custId, string password);
        UsersEntity GetUsersEntity(string userName, string custId);
        List<RMUserRoleEntity> GetUserRoles(string userName, string custId);
        List<HullingProcessExpensesEntity> GetAllHullingProcessExpensesEntities();
        List<BuyerSellerRatingEntity> GetAllBuyerSellerRatingEntities();
        List<BuyerInfoEntity> GetBuyerInfo();
        List<PaddyStockDTO> GetPaddyStockDTO(int pageindex, int pageSize, out int count, SortExpression expression);
        List<EmployeeDetailsEntity> GetEmployeeDetails();
        List<EmployeeSalaryEntity> GetEmployeeSalary();
        List<SellerInfoEntity> GetPaddySellerInfo(int count, string prefixText, string contextKey);
        List<BuyerInfoEntity> GetBuyerInfo(int count, string prefixText, string context);
        List<EmployeeDetailsEntity> GetEmployeeDetails(string context, int count, string prefixText);
        EmployeeSalaryEntity GetEmployeeSalaryEntity(string EmployeeID);
        string GetEmployeeName(string EmployeeID);
        List<EmployeeSalaryPaymentEntity> GetEmployeeSalaryPayment();
        List<EmployeeSalaryPaymentEntity> GetSalaryPaymentOnEmployee(string EmployeeID);
        List<OtherExpensesEntity> GetAllOtherExpenses();
        List<ProductPaymentInfoEntity> GetAllProductPaymentInfo();
        List<WidgetDTO> GetTotlaPaddyStock();
        bool CheckEmployeeExist(string EmployeeName);
        bool CheckEmployeeSalaryExist(string EmployeeID);
        int GetPaddyStockTotalSum();
        int GetBrokenRiceStockInfoCount();
        int GetMRiceProductionTypeCount();
    }
}
