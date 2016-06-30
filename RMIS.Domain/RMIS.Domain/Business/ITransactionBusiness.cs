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
        ResultDTO SavePaddyStockInfo(string sellerId, string paddyTypeId, string godownId, string lotId, string UnitsTypeID, string vehicleNo, string DriverName, int totalBags, double Price, DateTime purchaseDate);
        ResultDTO SaveBagStockInfo(string sellerId,
                     string vehicleNo, string DriverName, int totalBags, double Price,
                     DateTime purchaseDate, string RiceBrandID, string UnitTypeID);
        ResultDTO SavePaddyPaymentDetails(string sellerId, double amountPaid,
           DateTime paidDate, string handOverTo, DateTime nextPaymentDate, string PaddyStockID, string PaymentMode, string ChequeuNo, string BankName);
        ResultDTO SaveRiceStockInfo(string MRiceProdTypeID, string MRiceBrandID, int totalBags, string UnitsTypeID);
        ResultDTO SaveBrokenRiceStockInfo(string BrokenRiceTypeId, int totalBags, string UnitsTypeID);
        ResultDTO SaveDustStockInfo(int totalBags, string UnitsTypeID);
        bool SaveCustomerInformation(string customerName, string organizationName, string custId);
        bool SaveMenuConfiguration(string custId, string roleId, string menuId);
        ResultDTO SaveProductSellingInfo(string SellingProductType, string BuyerId, string MRiceProdTypeID, string MRiceBrandId, string BrokenRiceTypeId,
                                         int totalBags, string UnitsTypeID, double Price, DateTime SellingDate, string OrderNo, string PaymnetMode,
                                         string ChequeNo, string DDno, string BankName, double ReceivedAmount, DateTime NextPaymentDate);
        ResultDTO SaveProductSellingInfo(List<ProductSellingInfoDTO> list);
        ResultDTO SaveHullingProcessInfo(string PaddyTypeID, string UnitsTypeID, string GodownID, string LotID, int TotalPaddyBags, double paddyprice, DateTime HullingProcessDate, string HullingProcessBy, string Status);
        ResultDTO SaveHullingProcessTransInfo(string HullingProcessID, List<RiceStockDetailsDTO> listRiceDetails,
            List<BrokenRiceStockDetailsDTO> listBrokenRiceDetails, string DustUnitsTypeID, int DustTotalBags, double DustPriceperbag, double PowerExpenses, double LabourExpenses, double OtherExpenses);
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
        ResultDTO SaveBagPaymentDetails(string sellerId, double amountPaid,DateTime paidDate, string handOverTo, DateTime nextPaymentDate, string PaymentMode, string ChequeuNo, string BankName);

        List<SellerInfoEntity> GetPaddySellerInfo();
        List<RiceStockInfoEntity> GetAllRiceStockInfoEntities();
        List<BrokenRiceStockInfoEntity> GetAllBrokenRiceStockInfoEntities();
        List<DustStockInfoEntity> GetAllDustStockInfoEntities();
        List<CustomerInfoEntity> GetAllCustomerInfoEntities();
        List<ProductSellingInfoEntity> GetAllProductSellingInfoEntities();
        List<MenuConfigurationEntity> GetMenuConfigurationEntities();
        List<MenuConfigurationEntity> GetMenuConfigurationEntities(string custId);
        HullingProcessDTO GetAllHullingProcessInfoEntities();
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
        List<BagPaymentInfoEntity> GetAllBagPaymentDetailsEntities();
        List<WidgetDTO> GetTotalPaddyStockWidget();
        List<WidgetDTO> GetTotalRiceStockWidget();
        List<WidgetDTO> GetTotalBrokenRiceStockWidget();
        List<WidgetDTO> GetPaddyTotalAmountDueWidget();
        List<WidgetDTO> GetProductTotalAmountDueWidget();
        List<WidgetDTO> GetTotalBagStockWidget();
        bool CheckEmployeeExist(string EmployeeName);
        bool CheckEmployeeSalaryExist(string EmployeeID);
        int GetPaddyStockTotalSum();
        int GetBrokenRiceStockInfoCount();
        int GetMRiceProductionTypeCount();
        int GetRiceStockTotalSum();
        int GetBrockenRiceStockTotalSum();
        int GetBagStockTotalSum();
        double GetPaddyTotalAmountDue();
        double GetProductTotalAmountDue();
        double GetPaddyTotalAmountDueBySeller(string sellerId);
        long CheckHullingProcessPaddyCount(string PaddyTypeID, string UnitTypeID, string GodownID, string LotID);

        //ResultDTO SaveHullingProcessInfo(string PaddyType,int UnitsType,string GodownName,string Lotname,int TotalPaddyBags,double paddyprice,DateTime HullingProcessDate,string HullingProcessBy,
        //        string RiceType,string RiceBrand,int riceUnittype,int ricetotalbags,string BRType,int BRUnitsType,
        //        int BRTotalBags, double BRPriceperbag, int DustUnitsType, int DustTotalBags, double DustPriceperbag);


        List<BagStockDTO> GetBagStockDTO(int pageindex, int pageSize, out int count, SortExpression expression);
        ResultDTO CheckRiceStockAvailability(string RiceTypeID, string RiceBrandID, string UnitTypeID, int TotalBags);
        ResultDTO CheckBrokenriceStockAvailability(string BrokenRiceTypeID, string UnitTypeID, int TotalBags);

        ResultDTO CheckDustStockAvailability(string UnitTypeID, int TotalBags);

        List<ProductBuyerPaymentDTO> GetProductPaymentDue(string BuyerID);

        ResultDTO SaveProductPaymentTransaction(string ProductPaymentID, string BuyerID, string PaymentMode, string ChequeueNo, string DDNo, string BankName, double ReceivedAmount, DateTime NextPaymentDueDate, double TotalAmountDue);

        List<SellerInfoDTO> GetAllSellerInfoEntities(int PageIndex, int PageSize, out int count, SortExpression expression);
        ResultDTO DeleteSellerInfo(string ID);
        ResultDTO UpdateSellerInfo(string ID, string SellerName,string Town,string Contactno, string mobileno);
        bool CheckSellerNameExist(string SellerName);
        List<BuyerInfoDTO> GetAllBuyerInfoEntities(int PageIndex, int PageSize, out int count, SortExpression expression);
        ResultDTO DeleteBuyerInfo(string ID);
        ResultDTO UpdateBuyerInfo(string ID, string BuyerName, string Town, string Contactno, string mobileno);
        bool CheckBuyerNameExist(string BuyerName);

        ResultDTO CheckISValidSeller(string SellerID, string SellerNae);

        double GetBagTotalAmountDueBySeller(string SellerID);

        List<PaddyStockOverViewDTO> GetPaddyStockOverViewDTO(int PageIndex, int PageSize, out int count, SortExpression expression);

        List<PaddyStockDTO> GetPaddyStockPurchaseDTO(string SellerID, int pageindex, int pageSize, out int count, SortExpression sortExpression);

        List<PaddyPaymentDTO> GetPaddyPaymentDTO(int pageindex, int pageSize, out int count, SortExpression sortExpression);

        List<PaddyPaymentDTO> GetPaddyPaymentDTO(string SellerID, int pageindex, int pageSize, out int count, SortExpression sortExpression);

        List<PaddyPaymentDueDTO> GetPaddyPaymentDueDTO(int pageindex, int pageSize, out int count, SortExpression sortExpression);

        List<BagStockDTO> GetBagStockPurchaseDTO(string SellerID, int pageindex, int pageSize, out int count, SortExpression sortExpression);

        int GetPaddyStockOnPaddyType(string PaddyTypeID, string UnitTypeName, string GodownName, string LotName);

        int GetRiceStockOnRiceType(string RiceTypeID, string Brand, string UnitType);

        int GetBrokenRiceStockOnBrokenRiceType(string BrokenRiceTypeID, string UnitType);

        int GetDustStock(string UnitType);

        List<BagPaymentDTO> GetBagPaymentDTO(string SellerID, int pageindex, int pageSize, out int count, SortExpression sortExpression);

        List<BagPaymentDTO> GetBagPaymentDTO(int pageindex, int pageSize, out int count, SortExpression sortExpression);

        List<BagPaymentDueDTO> GetBagPaymentDueDTO(int pageindex, int pageSize, out int count, SortExpression sortExpression);
    }
}
