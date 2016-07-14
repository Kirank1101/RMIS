using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RMIS.Domain.Mediator
{
    using System.Collections.Generic;
    using RMIS.Domain.RiceMill;
    using RMIS.Domain.Constant;

    public interface IRMISMediator
    {
        #region Methods

        /// <summary>
        /// Opens a session within a transaction at the beginning.  Note that
        /// it ONLY begins transactions for those designated as being transactional i.e. isTransactional="true" in web.config.
        /// </summary>
        /// <param name="sender"></param>
        void BeginTransaction();
        /// <summary>
        /// Method to Close the session.
        /// </summary>
        void CloseSession();
        /// <summary>
        /// Method to Commit and Close the session.
        /// If exception occurs, rollback will be handled automatically.
        /// </summary>
        void CommitAndCloseSession();

        #region SaveOrUpdate
        /// <summary>
        /// Saves the or update audit entity.
        /// </summary>
        /// <param name="auditEntity">The audit entity.</param>
        /// <param name="isCopy">if set to <c>true</c> [is copy].</param>

        void SaveOrUpdateMBagTypeEntity(MBagTypeEntity mBagtypeEntity, bool isCopy);
        void SaveOrUpdateMUnitsTypeEntity(MUnitsTypeEntity mUnitstypeEntity, bool isCopy);
        void SaveOrUpdateSellerInfoEntity(SellerInfoEntity sellerInfoEntity, bool isCopy);
        void SaveOrUpdateCustomerInfoEntity(CustomerInfoEntity customerInfoEntity, bool isCopy);
        void SaveOrUpdateMUserTypeEntity(MUserTypeEntity mUserTypeEntity, bool isCopy);
        void SaveOrUpdateUsersEntity(UsersEntity usersEntity, bool isCopy);
        void SaveOrUpdateMPaddyTypeEntity(MPaddyTypeEntity mPaddyTypeEntity, bool isCopy);
        void SaveOrUpdateMBrokenRiceTypeEntity(MBrokenRiceTypeEntity mBrokenRiceTypeEntity, bool isCopy);
        void SaveOrUpdatePaddyStockInfoEntity(PaddyStockInfoEntity paddyStockInfoEntity, bool isCopy);
        void SaveOrUpdateRiceStockInfoEntity(RiceStockInfoEntity riceStockInfoEntity, bool isCopy);
        void SaveOrUpdateDustStockInfoEntity(DustStockInfoEntity dustStockInfoEntity, bool isCopy);
        void SaveOrUpdateBrokenRiceStockInfoEntity(BrokenRiceStockInfoEntity brokenRiceStockInfoEntity, bool isCopy);
        void SaveOrUpdateBagStockInfoEntity(BagStockInfoEntity bagStockInfoEntity, bool isCopy);
        void SaveOrUpdateMLotDetailsEntity(MLotDetailsEntity mLotDetailsEntity, bool isCopy);
        void SaveOrUpdateMGodownDetailsEntity(MGodownDetailsEntity mGodownDetailsEntity, bool isCopy);
        void SaveOrUpdatePaddyPaymentDetailsEntity(PaddyPaymentDetailsEntity paddyPaymentDetailsEntity, bool isCopy);
        void SaveOrUpdateCustomerAddressInfoEntity(CustomerAddressInfoEntity customerAddressInfoEntity, bool isCopy);
        void SaveOrUpdateCustomerActivationEntity(CustomerActivationEntity customerActivationEntity, bool isCopy);
        void SaveOrUpdateCustTrailUsageEntity(CustTrailUsageEntity custTrailUsageEntity, bool isCopy);
        void SaveOrUpdateCustomerPaymentEntity(CustomerPaymentEntity customerPaymentEntity, bool isCopy);
        void SaveOrUpdateCustomerPartPayDetailsEntity(CustomerPartPayDetailsEntity customerPartPayDetailsEntity, bool isCopy);
        void SaveOrUpdateMDrierTypeDetailsEntity(MDrierTypeDetailsEntity mDrierTypeDetailsEntity, bool isCopy);
        void SaveOrUpdateMRiceProductionTypeEntity(MRiceProductionTypeEntity mRiceProductionTypeEntity, bool isCopy);
        void SaveOrUpdateMRiceBrandDetailsEntity(MRiceBrandDetailsEntity mRiceBrandDetailsEntity, bool isCopy);
        void SaveOrUpdateMenuConfigEntity(MenuConfigurationEntity menuConfigEntity, bool isCopy);
        void SaveOrUpdateProductSellingInfoEntity(ProductSellingInfoEntity productSellingInfoEntity, bool isCopy);
        void SaveOrUpdateHullingProcessInfoEntity(HullingProcessEntity hullingProcessInfoEntity, bool isCopy);
        void SaveOrUpdateHullingProcessTransInfoEntity(HullingProcessTransactionEntity hullingProcessTransactionEntity, bool isCopy);
        void SaveOrUpdateRoleEntity(MRolesEntity mRoleEntity, bool isCopy);
        void SaveOrUpdateUserRoleEntity(RMUserRoleEntity muserRoleEntity, bool isCopy);
        void SaveOrUpdateHullingProcessExpensesInfoEntity(HullingProcessExpensesEntity hullingProcessExpensesEntity, bool isCopy);
        void SaveOrUpdateBuyyerSellerRatingEnity(BuyerSellerRatingEntity buyerSellerRatingEntity, bool isCopy);
        void SaveOrUpdateBuyerInfoEntity(BuyerInfoEntity BuyerInfoEntity, bool isCopy);
        void SaveOrUpdateMEmployeeDesignationEntity(MEmployeeDesignationEntity MEmployeeDesignationEntity, bool isCopy);
        void SaveOrUpdateMSalaryTypeEntity(MSalaryTypeEntity MSalaryTypeEntity, bool isCopy);
        void SaveOrUpdateEmployeeDetailsEntity(EmployeeDetailsEntity EmployeeDetailsEntity, bool isCopy);
        void SaveOrUpdateEmployeeSalaryEntity(EmployeeSalaryEntity EmployeeSalaryEntity, bool isCopy);
        void SaveOrUpdateEmployeeSalaryPaymentEntity(EmployeeSalaryPaymentEntity EmployeeSalaryPaymentEntity, bool isCopy);
        void SaveOrUpdateOtherExpensesEntity(OtherExpensesEntity OtherExpensesEntityEntity, bool isCopy);
        void SaveOrUpdateProductPaymentInfoEntity(ProductPaymentInfoEntity ProductPaymentInfoEntity, bool isCopy);
        void SaveOrUpdateProductPaymentTransEntity(ProductPaymentTransactionEntity ProductPaymentTranEntity, bool isCopy);
        void SaveOrUpdateBagPaymentEntity(BagPaymentInfoEntity bagPaymentDetailsEntity, bool isCopy);
        void SaveOrUpdateMediatorInfoEntity(MediatorInfoEntity MediatorInfoEntity, bool isCopy);
        void SaveOrUpdateMExpenseTypeEntity(MExpenseTypeEntity mExpensetypeEntity, bool isCopy);
        void SaveOrUpdateExpenseTransEntity(ExpenseTransactionEntity ExpenseTransactionEntity, bool isCopy);
        void SaveOrUpdateMJobWorkEntity(MJobWorkEntity mJobWorkEntity, bool isCopy);
        void SaveOrUpdateRentalHullingEntity(RentalHullingEntity RentalHullingEntity, bool isCopy);
        void SaveOrUpdateBankTransactionEntity(BankTransactionEntity BankTransactionEntity, bool isCopy);
        void SaveOrUpdateMailQueueEntity(MailQueueEntity mailQueueEntity, bool isCopy);
        #endregion
        #region Get
        /// <summary>
        /// Gets all audit module visit.
        /// </summary>
        /// <returns></returns>

        SellerInfoEntity GetSellerInfoEntity(string CustId, string SellerID, YesNo yesNo);
        CustomerInfoEntity GetCustomerInfoEntity(string CustID, YesNo yesNo);
        MUserTypeEntity GetMUserTypeEntity(string UserTypeID, YesNo yesNo);
        UsersEntity GetUsersEntity(string UserID, YesNo yesNo);
        UsersEntity GetUsersEntity(string userName, string custId, YesNo yesNo);
        MPaddyTypeEntity GetMPaddyTypeEntity(string PaddyTypeID, YesNo yesNo);
        MGodownDetailsEntity GetMGodownDetailsEntity(string MGodownID, YesNo yesNo);
        MLotDetailsEntity GetMLotDetailsEntity(string MLotID, YesNo yesNo);
        PaddyStockInfoEntity GetPaddyStockInfoEntity(string PaddyStockID, YesNo yesNo);
        BagStockInfoEntity GetBagStockInfoEntity(string BagStockID, YesNo yesNo);
        PaddyPaymentDetailsEntity GetPaddyPaymentDetailsEntity(string CustId, YesNo yesNo);
        CustomerAddressInfoEntity GetCustomerAddressInfoEntity(string CustAdrsID, YesNo yesNo);
        CustomerActivationEntity GetCustomerActivationEntity(string CustActiveID, YesNo yesNo);
        CustTrailUsageEntity GetCustTrailUsageEntity(string CustTrailID, YesNo yesNo);
        CustomerPaymentEntity GetCustomerPaymentEntity(string CustPaymentID, YesNo yesNo);
        CustomerPartPayDetailsEntity GetCustomerPartPayDetailsEntity(string CustPartPayID, YesNo yesNo);
        MDrierTypeDetailsEntity GetMDrierTypeDetailsEntity(string MDrierTypeID, YesNo yesNo);
        MRiceProductionTypeEntity GetMRiceProductionTypeEntity(string MRiceProdTypeID, YesNo yesNo);
        MRiceBrandDetailsEntity GetMRiceBrandDetailsEntity(string MRiceBrandID, YesNo yesNo);
        List<MPaddyTypeEntity> GetMPaddyTypeEntitiies(string CustId, YesNo yesNo);
        List<MPaddyTypeEntity> CheckPaddyTypeExist(string CustId, string PaddyType, YesNo yesNo);
        List<MBrokenRiceTypeEntity> GetMBrokenRiceTypeEntitiies(string CustId, YesNo yesNo);
        List<MUserTypeEntity> GetMUserTypeEntities(string CustId, YesNo yesNo);
        List<MBagTypeEntity> GetMBagTypeEntities(string CustId, YesNo yesNo);
        List<SellerInfoEntity> GetListSellerInfoEntities(string CustId, YesNo yesNo);
        List<PaddyStockInfoEntity> GetPaddyStockInfoEntities(string CustId, YesNo yesNo);
        List<RiceStockInfoEntity> GetAllRiceStockInfoEntities(string CustId, YesNo yesNo);
        List<DustStockInfoEntity> GetAllDustStockInfoEntities(string CustId, YesNo yesNo);
        List<BrokenRiceStockInfoEntity> GetAllBrokenRiceStockInfoEntities(string CustId, YesNo yesNo);
        List<BagStockInfoEntity> GetBagStockInfoEntities(string CustId, YesNo yesNo);
        List<MLotDetailsEntity> GetMLotDetailsEntities(string CustId, string MGodownID, YesNo yesNo);
        List<MLotDetailsEntity> GetMLotDetailsEntities(string CustId, YesNo yesNo);
        List<MGodownDetailsEntity> GetMGodownDetailsEntities(string CustId, YesNo yesNo);
        List<MUnitsTypeEntity> GetMUnitsTypeEntities(string CustId, YesNo yesNo);
        List<MRiceProductionTypeEntity> GetMRiceProductionTypeEntities(string CustId, YesNo yesNo);
        List<MRiceBrandDetailsEntity> GetMRiceBrandDetailsEntities(string CustId, YesNo yesNo);
        List<MenuInfoEntity> GetAllMenuInfoEntities(YesNo yesNo);
        List<CustomerInfoEntity> GetCustomerInfoEntities(YesNo yesNo);
        List<MenuConfigurationEntity> GetMenuConfigurationEntities(string CustId, YesNo yesNo);
        List<ProductSellingInfoEntity> GetAllproductSellingInfoEntities(string CustId, YesNo yesNo);
        List<HullingProcessEntity> GetAllHullingProcessInfoEntity(string CustId, YesNo yesNo);
        List<HullingProcessExpensesEntity> GetAllHullingProcessExpensesEntity(string CustId, YesNo yesNo);
        List<HullingProcessTransactionEntity> GetAllHullingProcessTransInfoEntity(string CustId, YesNo yesNo);
        List<MRolesEntity> GetAllRolesEntity(YesNo yesNo);
        List<RMUserRoleEntity> GetUserRoleEntities(string userId, YesNo yesNo);
        List<MPaddyTypeEntity> GetMPaddyTypeEntities(string CustId, int pageindex, int pageSize, out int count, SortExpression expression, YesNo yesNo);
        List<PaddyStockInfoEntity> GetPaddyStockInfoEntity(string CustId, int pageindex, int pageSize, out int count, SortExpression expression, YesNo yesNo);
        List<BuyerSellerRatingEntity> GetAllBuyerSellerRatingEntities(string CustId, YesNo yesNo);
        List<BuyerInfoEntity> GetListBuyerInfoEntities(string CustID, YesNo yesNo);
        List<MEmployeeDesignationEntity> GetListMEmployeeDesignationEntities(string CustId, YesNo yesNo);
        List<MSalaryTypeEntity> GetListMSalaryTypeEntities(string CustId, YesNo yesNo);
        List<EmployeeDetailsEntity> GetListEmployeeDetailsEntities(string CustId, YesNo yesNo);
        List<EmployeeSalaryEntity> GetAllEmployeeSalaryEntities(string CustId, YesNo yesNo);
        MUnitsTypeEntity GetMUnitsTypeEntity(string unitTypeId, YesNo yesNo);
        EmployeeDetailsEntity GetEmployeeDetailsEntity(string custId, string EmployeeID, YesNo yesNo);
        MEmployeeDesignationEntity GetMEmployeeDesignationEntity(string CustID, string DesignationID, YesNo yesNo);
        MSalaryTypeEntity GetListMSalaryTypeEntity(string CustId, string SalaryTypeId, YesNo yesNo);
        EmployeeSalaryEntity GetEmployeeSalaryEntity(string CustId, string EmployeeID, YesNo yesNo);
        List<EmployeeSalaryPaymentEntity> GetAllEmployeeSalaryPaymentEntities(string CustId, YesNo yesNo);
        List<EmployeeSalaryPaymentEntity> GetSalaryPaymentOnEmployee(string CustId, string EmployeeID, YesNo yesNo);
        List<SellerInfoEntity> GetSellerInfoEntities(string custId, YesNo yesNo, int count, string prefixText);
        List<EmployeeDetailsEntity> GetEmployeeDetailsEntities(string custId, YesNo yesNo, int count, string prefixText);
        List<BuyerInfoEntity> GetBuyerInfoEntities(string custId, YesNo yesNo, int count, string prefixText);
        List<BankTransactionEntity> GetBankTransactionEntities(string CustID, YesNo yesNo); 
        int GetMPaddyTypeEntitiesTotal(string CustId, YesNo yesNo);
        int GetBrokenRiceStockInfoCount(string CustId, YesNo yesNo);
        int GetMRiceProductionTypeCount(string CustId, YesNo yesNo);
        int GetPaddyStockUsedTotal(string CustId, YesNo yesNo);
        int GetPaddyStockEntityCount(string CustId, YesNo yesNo);
        int GetPaddyStockUsedCount(string CustId, YesNo yesNo);
        int GetBagStockTotal(string CustId, YesNo yesNo);
        int GetBagStockTotalUsed(string CustId, YesNo yesNo);
        int GetBagStockTotal(string CustId, string UnitsTypeID, string RiceBrandId, YesNo yesNo);
        int GetBagStockTotalUsed(string CustId, string UnitsTypeID, string RiceBrandId, YesNo yesNo);
        int GetRiceProductTotal(string CustId, YesNo yesNo);
        int GetRiceProductUsedTotal(string CustId, YesNo yesNo);
        int GetBrokenRiceProductTotal(string CustId, YesNo yesNo);
        int GetBrokenRiceProductUsedTotal(string CustId, YesNo yesNo);
        int GetRiceProductTotal(string CustId, string UnitsTypeID, string RiceProdTypeID, string RiceBrandId, YesNo yesNo);
        int GetRiceProductUsedTotal(string CustId, string UnitsTypeID, string RiceProdTypeID, string RiceBrandId, YesNo yesNo);
        int GetBrokenRiceProductTotal(string CustId, string UnitsTypeID, string BrokenRiceTypeID, YesNo yesNo);
        int GetBrokenRiceProductUsedTotal(string CustId, string UnitsTypeID, string BrokenRiceTypeID, YesNo yesNo);
        double GetPaddyTotalAmount(string CustId, YesNo yesNo);
        double GetPaddyTotalAmountPaid(string CustId, YesNo yesNo);
        double GetPaddyTotalAmount(string CustId, string SellerId, YesNo yesNo);
        double GetPaddyTotalAmountPaid(string CustId, string SellerId, YesNo yesNo);

        double GetProductTotalAmount(string CustId, YesNo yesNo);
        double GetProductTotalAmountPaid(string CustId, YesNo yesNo);
        double GetProductTotalAmount(string CustId, string BuyerID, YesNo yesNo);
        double GetProductTotalAmountPaid(string CustId, string BuyerID, YesNo yesNo);

        List<OtherExpensesEntity> GetAllOtherExpensesEntities(string CustId, YesNo yesNo);
        int GetMPaddyTypeEntitiesTotal(string CustId, string UnitsTypeID, string PaddyTypeId, YesNo yesNo);
        int GetPaddyStockUsedTotal(string CustId, string UnitsTypeID, string PaddyTypeId, YesNo yesNo);
        List<ProductPaymentInfoEntity> GetAllProductPaymentInfoEntities(string CustId, YesNo yesNo);
        List<ProductPaymentInfoEntity> GetAllProductPaymentInfoEntities(string CustId, string MediatorID, string BuyerID, YesNo yesNo);
        List<ProductPaymentTransactionEntity> GetAllProductPaymentTranEntities(string CustId, YesNo yesNo);
        List<PaddyStockInfoEntity> GetAllPaddyStockInfoEntities(string CustId, string PaddyTypeID, string UnitTypeID, string GodownID, string LotID, YesNo yesNo);
        List<HullingProcessEntity> GetAllHullingProcessPaddyStock(string CustId, string PaddyTypeID, string UnitTypeID, string GodownID, string LotID, YesNo yesNo);
        List<BuyerInfoEntity> GetBuyerInfoEntities(string custId, YesNo yesNo);
        HullingProcessEntity GetHullingProcessEnitity(string CustId, string HullingProcessID, YesNo yesNo);
        List<MUnitsTypeEntity> GetMUnitsTypeEntities(string CustID, int pageindex, int pageSize, out int count, SortExpression expression, YesNo yesNo);
        List<MGodownDetailsEntity> GetMGodownDetailsEntities(string CustID, int PageIndex, int PageSize, out int count, SortExpression expression, YesNo yesNo);
        List<MLotDetailsEntity> GetMLotDetailsEntities(string CustId, string GodownID, int PageIndex, int PageSize, out int count, SortExpression expression, YesNo yesNo);
        MBagTypeEntity GetMBagTypeEntity(string BagTypeID, YesNo yesNo);
        List<MBagTypeEntity> GetMBagTypeEntities(string CustId, int PageIndex, int PageSize, out int count, SortExpression expression, YesNo yesNo);
        List<MRiceProductionTypeEntity> GetMRiceProductionTypeEntities(string CustId, int PageIndex, int PageSize, out int count, SortExpression expression, YesNo yesNo);
        MBrokenRiceTypeEntity GetMBrokenRiceTypeEntity(string BrokenRiceTypeID, YesNo yesNo);
        List<MBrokenRiceTypeEntity> GetMBrokenRiceTypeEntitiies(string CustId, int PageIndex, int PageSize, out int count, SortExpression expression, YesNo yesNo);
        List<MRiceBrandDetailsEntity> GetMRiceBrandDetailsEntities(string CustId, int PageIndex, int PageSize, out int count, SortExpression expression, YesNo yesNo);
        MEmployeeDesignationEntity GetMEmployeeDesignationEntity(string EmpDesigID, YesNo yesNo);
        List<MEmployeeDesignationEntity> GetMEmployeeDesignationEntities(string CustId, int PageIndex, int PageSize, out int count, SortExpression expression, YesNo yesNo);
        MSalaryTypeEntity GetMSalaryTypeEntity(string SalaryTypeID, YesNo yesNo);
        List<MSalaryTypeEntity> GetListMSalaryTypeEntities(string CustId, int PageIndex, int PageSize, out int count, SortExpression expression, YesNo yesNo);
        MBagTypeEntity GetMBagTypeEntity(string CustId, string BagType, YesNo yesNo);
        MRiceProductionTypeEntity GetMRiceProductionTypeEntity(string CustId, string RiceType, YesNo yesNo);
        MBrokenRiceTypeEntity GetMBrokenRiceTypeEntity(string CustId, string BrokenRiceType, YesNo yesNo);
        MRiceBrandDetailsEntity GetMRiceBrandDetailsEntity(string CustId, string RiceBrand, YesNo yesNo);
        List<BagStockInfoEntity> GetBagStockInfoEntity(string CustId, int pageindex, int pageSize, out int count, SortExpression expression, YesNo yesNo);
        List<RiceStockInfoEntity> GetAllRiceStockInfoEntities(string CustId, string RiceType, string RiceBrand, string UnitType, YesNo yesNo);
        //Get Total Rice bags sold from ProductSellingInfo
        List<ProductSellingInfoEntity> GetAllproductSellingInfoEntities(string CustId, string RiceTypeID, string RiceBrandID, string UnitTypeID, YesNo yesNo);
        List<BrokenRiceStockInfoEntity> GetAllBrokenRiceStockInfoEntities(string CustId, string BrokenRiceTypeID, string UnitTypeID, YesNo yesNo);
        //Get Total Broken Rice bags sold from ProductSellingInfo
        List<ProductSellingInfoEntity> GetAllproductSellingInfoEntities(string CustId, string BrokenRiceTypeID, string UnitTypeID, YesNo yesNo);
        List<DustStockInfoEntity> GetAllDustStockInfoEntities(string CustId, string UnitTypeID, YesNo yesNo);
        List<ProductSellingInfoEntity> GetAllproductSellingInfoEntities(string CustId, string UnitTypeID, YesNo yesNo);
        List<ProductSellingInfoEntity> GetAllBuyerproductSellingInfoEntities(string CustId, string BuyerID, YesNo yesNo);
        BuyerInfoEntity GetBuyerInfoEntity(string CustId, string BuyerID, YesNo yesNo);
        ProductPaymentInfoEntity GetProductPaymentInfoEntity(string CustId, string ProductPaymentID, YesNo yesNo);
        List<ProductPaymentTransactionEntity> GetAllProductPaymentTranEntities(string CustId, string ProductPaymentID, YesNo yesNo);
        List<SellerInfoEntity> GetListSellerInfoEntities(string CustId, int PageIndex, int PageSize, out int count, SortExpression expression, YesNo yesNo);
        List<SellerInfoEntity> CheckSellerNameExist(string CustId, string SellerName, YesNo yesNo);
        List<BuyerInfoEntity> CheckBuyerNameExist(string CustId, string BuyerName, YesNo yesNo);
        List<BuyerInfoEntity> GetListBuyerInfoEntities(string CustId, int PageIndex, int PageSize, out int count, SortExpression expression, YesNo yesNo);
        SellerInfoEntity CheckISValidSeller(string CustId, string SellerID, string SellerName, YesNo yesNo);
        List<BagPaymentInfoEntity> GetAllBagPaymentDetailsEntity(string CustId, YesNo yesNo);
        double GetBagTotalAmount(string CustId, string SellerID, YesNo yesNo);
        double GetBagTotalAmountPaid(string CustId, string SellerID, YesNo yesNo);
        List<HullingProcessEntity> GetAllHullingProcessPaddySpent(string CustId, YesNo yesNo);
        List<PaddyStockInfoEntity> GetPaddyStockInfoEntity(string CustId, string SellerID, int pageindex, int pageSize, out int count, SortExpression sortExpression, YesNo yesNo, DateTime PurchaseDateFrom, DateTime PurchaseDateTo);
        List<PaddyPaymentDetailsEntity> GetPaddyPaymentDetailsEntity(string CustId, int pageindex, int pageSize, out int count, SortExpression sortExpression, YesNo yesNo);
        List<PaddyPaymentDetailsEntity> GetPaddyPaymentDetailsEntity(string CustId, string SellerID, int pageindex, int pageSize, out int count, SortExpression sortExpression, YesNo yesNo);
        List<SellerInfoEntity> GetSellerInfoEntity(string CustId, YesNo yesNo);
        List<BagStockInfoEntity> GetBagStockInfoEntity(string CustId, string SellerID, int pageindex, int pageSize, out int count, SortExpression sortExpression, YesNo yesNo);
        List<PaddyStockInfoEntity> GetPaddyStockInfoEntities(string CustId, string PaddyTypeID, YesNo yesNo);
        List<RiceStockInfoEntity> GetAllRiceStockInfoEntities(string CustId, string RiceTypeID, YesNo yesNo);
        List<BagPaymentInfoEntity> GetBagPaymentDetailsEntity(string CustId, int pageindex, int pageSize, out int count, SortExpression sortExpression, YesNo yesNo);
        List<BagPaymentInfoEntity> GetBagPaymentDetailsEntity(string CustId, string SellerID, int pageindex, int pageSize, out int count, SortExpression sortExpression, YesNo yesNo);
        List<ProductSellingInfoEntity> GetAllproductSellingInfoEntities(string CustId, int pageindex, int pageSize, out int count, SortExpression sortExpression, YesNo yesNo);
        List<ProductSellingInfoEntity> GetAllproductSellingInfoEntities(string CustId, string MediatorID, string BuyerId, int pageindex, int pageSize, out int count, SortExpression sortExpression, YesNo yesNo);
        List<ProductPaymentTransactionEntity> GetAllProductPaymentTranEntities(string CustId, int pageindex, int pageSize, out int count, SortExpression sortExpression, YesNo yesNo);
        List<ProductPaymentTransactionEntity> GetAllProductPaymentTranEntities(string CustId, string MediatorId, string BuyerId, int pageindex, int pageSize, out int count, SortExpression sortExpression, YesNo yesNo);
        List<MediatorInfoEntity> GetMediatorInfoEntities(string custId, YesNo yesNo);
        List<MediatorInfoEntity> GetListMediatorInfoEntities(string CustId, int PageIndex, int PageSize, out int count, SortExpression expression, YesNo yesNo);
        MediatorInfoEntity GetMediatorInfoEntity(string CustId, string MediatorID, YesNo yesNo);
        List<MExpenseTypeEntity> GetMExpenseTypeEntities(string CustId, YesNo yesNo);
        List<MJobWorkEntity> GetMJobWorkEntities(string CustId, YesNo yesNo);
        PaddyStockInfoEntity GetPaddyStockOnSellerid(string CustId, string SellerId, YesNo yesNo);
        List<MailQueueEntity> GetMailQueueEntities(YesNo yesNo);
        UsersEntity GetUsersEntityOnEmail(string emailId, YesNo yesNo);
        UsersEntity GetUsersEntityOnUserName(string userName, YesNo yesNo);
        #endregion
        #region Check
        /// <summary>
        /// Check Data Exist before Save
        /// </summary>
        /// <param name="CustId"></param>
        /// <param name="UnitType"></param>
        /// <returns></returns>
        MUnitsTypeEntity CheckUnitTypeExist(string CustId, string UnitType, YesNo yesNo);
        MGodownDetailsEntity CheckGodownNameExist(string CustId, string GodownName, YesNo yesNo);
        MLotDetailsEntity CheckLotNameExist(string CustId, string LotName, YesNo yesNo);
        MEmployeeDesignationEntity CheckEmpDesigExist(string CustId, string DesignationType, YesNo yesNo);
        MSalaryTypeEntity CheckSalaryTypeExist(string CustId, string SalaryType, YesNo yesNo);
        EmployeeDetailsEntity CheckEmployeeExist(string CustId, string EmployeeName, YesNo yesNo);
        EmployeeSalaryEntity CheckEmployeeSalaryExist(string CustId, string EmployeeID, YesNo yesNo);
        List<MediatorInfoEntity> GetListBrokerEntities(string CustId, string MediatorName, YesNo yesNo);
        MExpenseTypeEntity GetMExpenseTypeEntity(string CustId, string ExpenseType, YesNo yesNo);
        MJobWorkEntity GetMJobWorkEntity(string CustId, string JobWorkType, YesNo yesNo);
        #endregion
        #endregion


        List<MediatorInfoEntity> GetMediatorInfoEntities(string CustId, YesNo yesNo, int count, string prefixText);
        MediatorInfoEntity GetMediatorInfoEntityByName(string CustId, string MediatorName, YesNo yesNo);
        BuyerInfoEntity GetBuyerInfoEntityByName(string CustId, string BuyerName, YesNo yesNo);
        List<MExpenseTypeEntity> GetMExpenseTypeEntities(string CustId, int PageIndex, int PageSize, out int count, SortExpression expression, YesNo yesNo);
        MExpenseTypeEntity GetMExpenseTypeEntity(string ExpenseID, YesNo yesNo);
        List<MJobWorkEntity> GetMJobWorkEntities(string CustId, int PageIndex, int PageSize, out int count, SortExpression expression, YesNo yesNo);
        MJobWorkEntity GetMJobWorkEntity(string JobWorkID, YesNo yesNo);
        PaddyPaymentDetailsEntity GetPaddyPaymentOnSellerid(string CustID, string SellerID, YesNo yesNo);

        double GetBankTotalCredit(string CustID, YesNo yesNo);

        double GetBankTotalDebit(string CustID, YesNo yesNo);

        List<BankTransactionEntity> GetBankTransactionEntities(string CustID, int pageindex, int pageSize, out int count, SortExpression sortExpression, YesNo yesNo);

        List<BankTransactionEntity> GetBankTransactionEntity(string CustID, DateTime TranFromDate, DateTime TranToDate, int pageindex, int pageSize, out int count, SortExpression sortExpression, YesNo yesNo);
    }

}
