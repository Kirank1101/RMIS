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
        /// <summary>
        /// Gets all audit module visit.
        /// </summary>
        /// <returns></returns>
        
        SellerInfoEntity GetSellerInfoEntity(string SellerID);
        CustomerInfoEntity GetCustomerInfoEntity(string CustID);
        MUserTypeEntity GetMUserTypeEntity(string UserTypeID);
        UsersEntity GetUsersEntity(string UserID);
        UsersEntity GetUsersEntity(string userName,string custId);
        MPaddyTypeEntity GetMPaddyTypeEntity(string PaddyTypeID);
        MGodownDetailsEntity GetMGodownDetailsEntity(string MGodownID);
        MLotDetailsEntity GetMLotDetailsEntity(string MLotID);
        PaddyStockInfoEntity GetPaddyStockInfoEntity(string PaddyStockID);
        BagStockInfoEntity GetBagStockInfoEntity(string BagStockID);
        PaddyPaymentDetailsEntity GetPaddyPaymentDetailsEntity(string CustId);
        MWeightDetailsEntity GetMWeightDetailsEntity(string MWeightID);
        CustomerAddressInfoEntity GetCustomerAddressInfoEntity(string CustAdrsID);
        CustomerActivationEntity GetCustomerActivationEntity(string CustActiveID);
        CustTrailUsageEntity GetCustTrailUsageEntity(string CustTrailID);
        CustomerPaymentEntity GetCustomerPaymentEntity(string CustPaymentID);
        CustomerPartPayDetailsEntity GetCustomerPartPayDetailsEntity(string CustPartPayID);
        MDrierTypeDetailsEntity GetMDrierTypeDetailsEntity(string MDrierTypeID);
        MRiceProductionTypeEntity GetMRiceProductionTypeEntity(string MRiceProdTypeID);
        MRiceBrandDetailsEntity GetMRiceBrandDetailsEntity(string MRiceBrandID);
        List<MPaddyTypeEntity> GetMPaddyTypeEntitiies(string CustId);
        List<MBrokenRiceTypeEntity> GetMBrokenRiceTypeEntitiies(string CustId);
        List<MUserTypeEntity> GetMUserTypeEntities(string CustId);        
        List<MBagTypeEntity> GetMBagTypeEntities(string CustId);
        List<SellerInfoEntity> GetListSellerInfoEntities(string CustId);
        List<PaddyStockInfoEntity> GetPaddyStockInfoEntities(string CustId);
        List<RiceStockInfoEntity> GetAllRiceStockInfoEntities(string CustId);
        List<RiceSellingInfoEntity> GetAllRiceSellingInfoEntities(string CustId);
        List<BrokenRiceSellingInfoEntity> GetAllBrokenRiceSellingInfoEntities(string CustId);
        List<DustStockInfoEntity> GetAllDustStockInfoEntities(string CustId);
        List<BrokenRiceStockInfoEntity> GetAllBrokenRiceStockInfoEntities(string CustId);
        List<BagStockInfoEntity> GetBagStockInfoEntities(string CustId);
        List<MLotDetailsEntity> GetMLotDetailsEntities(string CustId, string MGodownID);
        List<MLotDetailsEntity> GetMLotDetailsEntities(string CustId);
        List<MGodownDetailsEntity> GetMGodownDetailsEntities(string CustId);
        List<MWeightDetailsEntity> GetMWeightDetailsEntities(string CustId);
        List<MUnitsTypeEntity> GetMUnitsTypeEntities(string CustId);
        List<MRiceProductionTypeEntity> GetMRiceProductionTypeEntities(string CustId);
        List<MRiceBrandDetailsEntity> GetMRiceBrandDetailsEntities(string CustId);
        List<DustSellingInfoEntity> GetAllDustSellingInfoEntities(string CustId);
        List<MenuInfoEntity> GetAllMenuInfoEntities();
        List<CustomerInfoEntity> GetCustomerInfoEntities();
        List<MenuConfigurationEntity> GetMenuConfigurationEntities(string CustId);
        List<MProductSellingTypeEntity> GetMProductSellingTypeEnties(string CustId);
        List<ProductSellingInfoEntity> GetAllproductSellingInfoEntities(string CustId);
        List<HullingProcessEntity> GetAllHullingProcessInfoEntity(string CustId);
        List<HullingProcessExpensesEntity> GetAllHullingProcessExpensesEntity(string CustId); 
        List<HullingProcessTransactionEntity> GetAllHullingProcessTransInfoEntity(string CustId);
        List<MRolesEntity> GetAllRolesEntity();
        List<RMUserRoleEntity> GetUserRoleEntities(string userId);
        List<MPaddyTypeEntity> GetMPaddyTypeEntities(string CustId, int pageindex, int pageSize, out int count, SortExpression expression);
        List<PaddyStockInfoEntity> GetPaddyStockInfoEntity(string CustId, int pageindex, int pageSize, out int count, SortExpression expression);
        List<BuyerSellerRatingEntity> GetAllBuyerSellerRatingEntities(string CustId);
        List<BuyerInfoEntity> GetListBuyerInfoEntities();
        MUnitsTypeEntity GetMUnitsTypeEntity(string unitTypeId);
        #endregion
    }

}
