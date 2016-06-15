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
        void SaveOrUpdateBrokenRiceSellingInfoEntity(BrokenRiceSellingInfoEntity brokenRiceSellingInfoEntity, bool isCopy);
        void SaveOrUpdatePaddyStockInfoEntity(PaddyStockInfoEntity paddyStockInfoEntity, bool isCopy);
        void SaveOrUpdateRiceStockInfoEntity(RiceStockInfoEntity riceStockInfoEntity, bool isCopy);
        void SaveOrUpdateRiceSellingInfoEntity(RiceSellingInfoEntity riceSellingInfoEntity, bool isCopy);
        void SaveOrUpdateDustStockInfoEntity(DustStockInfoEntity dustStockInfoEntity, bool isCopy);
        void SaveOrUpdateBrokenRiceStockInfoEntity(BrokenRiceStockInfoEntity brokenRiceStockInfoEntity, bool isCopy);
        void SaveOrUpdateBagStockInfoEntity(BagStockInfoEntity bagStockInfoEntity, bool isCopy);
        void SaveOrUpdateMLotDetailsEntity(MLotDetailsEntity mLotDetailsEntity, bool isCopy);
        void SaveOrUpdateMGodownDetailsEntity(MGodownDetailsEntity mGodownDetailsEntity, bool isCopy);
        void SaveOrUpdatePaddyPaymentDetailsEntity(PaddyPaymentDetailsEntity paddyPaymentDetailsEntity, bool isCopy);
        void SaveOrUpdateMWeightDetailsEntity(MWeightDetailsEntity mWeightDetailsEntity, bool isCopy);
        void SaveOrUpdateCustomerAddressInfoEntity(CustomerAddressInfoEntity customerAddressInfoEntity, bool isCopy);
        void SaveOrUpdateCustomerActivationEntity(CustomerActivationEntity customerActivationEntity, bool isCopy);
        void SaveOrUpdateCustTrailUsageEntity(CustTrailUsageEntity custTrailUsageEntity, bool isCopy);
        void SaveOrUpdateCustomerPaymentEntity(CustomerPaymentEntity customerPaymentEntity, bool isCopy);
        void SaveOrUpdateCustomerPartPayDetailsEntity(CustomerPartPayDetailsEntity customerPartPayDetailsEntity, bool isCopy);
        void SaveOrUpdateMDrierTypeDetailsEntity(MDrierTypeDetailsEntity mDrierTypeDetailsEntity, bool isCopy);
        void SaveOrUpdateMRiceProductionTypeEntity(MRiceProductionTypeEntity mRiceProductionTypeEntity, bool isCopy);
        void SaveOrUpdateMRiceBrandDetailsEntity(MRiceBrandDetailsEntity mRiceBrandDetailsEntity, bool isCopy);
        void SaveOrUpdateDustSellingInfoEntity(DustSellingInfoEntity dustSellingInfoEntity, bool isCopy);
        void SaveOrUpdateMenuConfigEntity(MenuConfigurationEntity menuConfigEntity, bool isCopy);
        void SaveOrUpdateMProductSellingTypeEntity(MProductSellingTypeEntity mProductSellingTypeEntity, bool isCopy);
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
        #endregion
        #region Get
        /// <summary>
        /// Gets all audit module visit.
        /// </summary>
        /// <returns></returns>

        SellerInfoEntity GetSellerInfoEntity(string SellerID, YesNo yesNo);
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
        MWeightDetailsEntity GetMWeightDetailsEntity(string MWeightID, YesNo yesNo);
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
        List<RiceSellingInfoEntity> GetAllRiceSellingInfoEntities(string CustId, YesNo yesNo);
        List<BrokenRiceSellingInfoEntity> GetAllBrokenRiceSellingInfoEntities(string CustId, YesNo yesNo);
        List<DustStockInfoEntity> GetAllDustStockInfoEntities(string CustId, YesNo yesNo);
        List<BrokenRiceStockInfoEntity> GetAllBrokenRiceStockInfoEntities(string CustId, YesNo yesNo);
        List<BagStockInfoEntity> GetBagStockInfoEntities(string CustId, YesNo yesNo);
        List<MLotDetailsEntity> GetMLotDetailsEntities(string CustId, string MGodownID, YesNo yesNo);
        List<MLotDetailsEntity> GetMLotDetailsEntities(string CustId, YesNo yesNo);
        List<MGodownDetailsEntity> GetMGodownDetailsEntities(string CustId, YesNo yesNo);
        List<MWeightDetailsEntity> GetMWeightDetailsEntities(string CustId, YesNo yesNo);
        List<MUnitsTypeEntity> GetMUnitsTypeEntities(string CustId, YesNo yesNo);
        List<MRiceProductionTypeEntity> GetMRiceProductionTypeEntities(string CustId, YesNo yesNo);
        List<MRiceBrandDetailsEntity> GetMRiceBrandDetailsEntities(string CustId, YesNo yesNo);
        List<DustSellingInfoEntity> GetAllDustSellingInfoEntities(string CustId, YesNo yesNo);
        List<MenuInfoEntity> GetAllMenuInfoEntities(YesNo yesNo);
        List<CustomerInfoEntity> GetCustomerInfoEntities(YesNo yesNo);
        List<MenuConfigurationEntity> GetMenuConfigurationEntities(string CustId, YesNo yesNo);
        List<MProductSellingTypeEntity> GetMProductSellingTypeEnties(string CustId, YesNo yesNo);
        List<ProductSellingInfoEntity> GetAllproductSellingInfoEntities(string CustId, YesNo yesNo);
        List<HullingProcessEntity> GetAllHullingProcessInfoEntity(string CustId, YesNo yesNo);
        List<HullingProcessExpensesEntity> GetAllHullingProcessExpensesEntity(string CustId, YesNo yesNo);
        List<HullingProcessTransactionEntity> GetAllHullingProcessTransInfoEntity(string CustId, YesNo yesNo);
        List<MRolesEntity> GetAllRolesEntity(YesNo yesNo);
        List<RMUserRoleEntity> GetUserRoleEntities(string userId, YesNo yesNo);
        List<MPaddyTypeEntity> GetMPaddyTypeEntities(string CustId, int pageindex, int pageSize, out int count, SortExpression expression, YesNo yesNo);
        List<PaddyStockInfoEntity> GetPaddyStockInfoEntity(string CustId, int pageindex, int pageSize, out int count, SortExpression expression, YesNo yesNo);
        List<BuyerSellerRatingEntity> GetAllBuyerSellerRatingEntities(string CustId, YesNo yesNo);
        List<BuyerInfoEntity> GetListBuyerInfoEntities(string CustID,YesNo yesNo);
        List<MEmployeeDesignationEntity> GetListMEmployeeDesignationEntities(string CustId, YesNo yesNo);
        List<MSalaryTypeEntity> GetListMSalaryTypeEntities(string CustId, YesNo yesNo);
        List<EmployeeDetailsEntity> GetListEmployeeDetailsEntities(string CustId, YesNo yesNo);
        List<EmployeeSalaryEntity> GetAllEmployeeSalaryEntities(string CustId, YesNo yesNo);
        MUnitsTypeEntity GetMUnitsTypeEntity(string unitTypeId, YesNo yesNo);
        EmployeeDetailsEntity GetEmployeeDetailsEntity(string custId, string EmployeeID, YesNo yesNo);
        MEmployeeDesignationEntity GetMEmployeeDesignationEntity(string CustID, string DesignationID, YesNo yesNo);
        MSalaryTypeEntity GetListMSalaryTypeEntity(string p, string SalaryTypeId, YesNo yesNo);
        EmployeeSalaryEntity GetEmployeeSalaryEntity(string p, string EmployeeID, YesNo yesNo);
        List<EmployeeSalaryPaymentEntity> GetAllEmployeeSalaryPaymentEntities(string CustId, YesNo yesNo);
        List<EmployeeSalaryPaymentEntity> GetSalaryPaymentOnEmployee(string CustId, string EmployeeID, YesNo yesNo);
        List<SellerInfoEntity> GetSellerInfoEntities(string custId, YesNo yesNo, int count, string prefixText);
        List<EmployeeDetailsEntity> GetEmployeeDetailsEntities(string custId, YesNo yesNo, int count, string prefixText);
        List<BuyerInfoEntity> GetBuyerInfoEntities(string custId, YesNo yesNo, int count, string prefixText);
        int GetMPaddyTypeEntitiesTotal(string CustId, YesNo yesNo);
        int GetBrokenRiceStockInfoCount(string CustId, YesNo yesNo);
        int GetMRiceProductionTypeCount(string CustId, YesNo yesNo);
        int GetPaddyStockUsedTotal(string CustId, YesNo yesNo);
        int GetPaddyStockEntityCount(string CustId, YesNo yesNo);
        int GetPaddyStockUsedCount(string CustId, YesNo yesNo);

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

        List<OtherExpensesEntity> GetAllOtherExpensesEntities(string CustId, YesNo yesNo);
        int GetMPaddyTypeEntitiesTotal(string CustId, string UnitsTypeID, string PaddyTypeId, YesNo yesNo);
        int GetPaddyStockUsedTotal(string CustId, string UnitsTypeID, string PaddyTypeId, YesNo yesNo);
        List<ProductPaymentInfoEntity> GetAllProductPaymentInfoEntities(string CustId, YesNo yesNo);
        List<ProductPaymentTransactionEntity> GetAllProductPaymentTranEntities(string CustId, YesNo yesNo);
        List<PaddyStockInfoEntity> GetAllPaddyStockInfoEntities(string CustId, string PaddyTypeID, string UnitTypeID, string GodownID, string LotID, YesNo yesNo);
        List<HullingProcessEntity> GetAllHullingProcessPaddyStock(string CustId, string PaddyTypeID, string UnitTypeID, string GodownID, string LotID, YesNo yesNo);
        HullingProcessEntity GetHullingProcessEnitity(string CustId, string HullingProcessID, YesNo yesNo);
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
        #endregion
        #endregion



        
    }

}
