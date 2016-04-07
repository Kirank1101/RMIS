
namespace RMIS.Mediator.BackEnd
{
    using System.Collections.Generic;
    
    
    
    using RMIS.Domain.RiceMill;

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
        void SaveOrUpdateSellerTypeEntity(SellerTypeEntity sellertypeEntity, bool isCopy);
        void SaveOrUpdateSellerInfoEntity(SellerInfoEntity sellerInfoEntity, bool isCopy);
        void SaveOrUpdateCustomerInfoEntity(CustomerInfoEntity customerInfoEntity, bool isCopy);
        void SaveOrUpdateMUserTypeEntity(MUserTypeEntity mUserTypeEntity, bool isCopy);
        void SaveOrUpdateUsersEntity(UsersEntity usersEntity, bool isCopy);
        void SaveOrUpdateMPaddyTypeEntity(MPaddyTypeEntity mPaddyTypeEntity, bool isCopy);
        void SaveOrUpdatePaddyStockInfoEntity(PaddyStockInfoEntity paddyStockInfoEntity, bool isCopy);
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
        void SaveOrUpdateMDrierTypeDetailsEntity(MRiceProductionTypeEntity mRiceProductionTypeEntity, bool isCopy);
        void SaveOrUpdateMRiceBrandDetailsEntity(MRiceBrandDetailsEntity mRiceBrandDetailsEntity, bool isCopy);
        /// <summary>
        /// Gets all audit module visit.
        /// </summary>
        /// <returns></returns>
        SellerTypeEntity GetSellerTypeEntity(string SellerTypeID);
        SellerInfoEntity GetSellerInfoEntity(string SellerID);
        CustomerInfoEntity GetCustomerInfoEntity(string CustID);
        MUserTypeEntity GetMUserTypeEntity(string UserTypeID);
        UsersEntity GetUsersEntity(string UserID);
        MPaddyTypeEntity GetMPaddyTypeEntity(string PaddyTypeID);
        PaddyStockInfoEntity GetPaddyStockInfoEntity(string PaddyStockID);
        MLotDetailsEntity GetMLotDetailsEntity(string MLotID);
        MGodownDetailsEntity GetMGodownDetailsEntity(string MGodownID);
        PaddyPaymentDetailsEntity GetPaddyPaymentDetailsEntity(string PaddyPaymentID);
        MWeightDetailsEntity GetMWeightDetailsEntity(string MWeightID);
        CustomerAddressInfoEntity GetCustomerAddressInfoEntity(string CustAdrsID);
        CustomerActivationEntity GetCustomerActivationEntity(string CustActiveID);
        CustTrailUsageEntity GetCustTrailUsageEntity(string CustTrailID);
        CustomerPaymentEntity GetCustomerPaymentEntity(string CustPaymentID);
        CustomerPartPayDetailsEntity GetCustomerPartPayDetailsEntity(string CustPartPayID);
        MDrierTypeDetailsEntity GetMDrierTypeDetailsEntity(string MDrierTypeID);
        MRiceProductionTypeEntity GetMRiceProductionTypeEntity(string MRiceProdTypeID);
        MRiceBrandDetailsEntity GetMRiceBrandDetailsEntity(string MRiceBrandID);

        #endregion
    }
}