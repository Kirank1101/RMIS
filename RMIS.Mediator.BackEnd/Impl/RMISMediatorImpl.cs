
namespace RMIS.Mediator.BackEnd.Impl
{
    using System;
    using AllInOne.Common.DataAccess.NHibernate.NHibernateSessionManagement;
    using RMIS.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper;
    using RMIS.Entities.BackEnd;
    using RMIS.Mediator.BackEnd.Data;
    using log4net;
    using System.Collections.Generic;
    using RMIS.Domain.RiceMill;
    using RMIS.Domain.Mediator;

    public class RMISMediatorImpl : IRMISMediator
    {
        IRMISMapper mapper;
        GenericGateway genericGateway = null;
        RMISGateway rmisGateway = null;

        public RMISMediatorImpl(IRMISMapper mapper)
        {
            this.mapper = mapper;
            genericGateway = new GenericGateway();
            rmisGateway = new RMISGateway();
        }

        #region Fields

        private static readonly ILog Logger = LogManager.GetLogger(typeof(RMISMediatorImpl));

        /// </summary>
        private ApplicationSessionManager applicationSessionManager = new ApplicationSessionManager();

        #endregion Fields


        /// <summary>
        /// Opens a session within a transaction at the beginning.  Note that
        /// it ONLY begins transactions for those designated as being transactional i.e. isTransactional="true" in web.config.
        /// </summary>
        /// <param name="sender"></param>
        public void BeginTransaction()
        {
            Logger.Info("AuditMediatorImpl - BeginTransaction started at " + DateTime.Now.ToString());

            this.applicationSessionManager.BeginTransaction();

            Logger.Info("AuditMediatorImpl - BeginTransaction ended at " + DateTime.Now.ToString());
        }

        /// <summary>
        /// Method to Close the session.
        /// </summary>
        public void CloseSession()
        {
            Logger.Info("AuditMediatorImpl - CloseSession started at " + DateTime.Now.ToString());

            this.applicationSessionManager.CloseSession();

            Logger.Info("AuditMediatorImpl - CloseSession ended at " + DateTime.Now.ToString());
        }

        /// <summary>
        /// Method to Commit and Close the session.
        /// If exception occurs, rollback will be handled automatically.
        /// </summary>
        public void CommitAndCloseSession()
        {
            Logger.Info("AuditMediatorImpl - CommitAndCloseSession started at " + DateTime.Now.ToString());

            this.applicationSessionManager.CommitAndCloseSession();

            Logger.Info("AuditMediatorImpl - CommitAndCloseSession ended at " + DateTime.Now.ToString());
        }

        #region Methods

        /// <summary>
        /// Saves the or update audit entity.
        /// </summary>
        /// <param name="auditEntity">The audit entity.</param>
        /// <param name="isCopy">if set to <c>true</c> [is copy].</param>
        public void SaveOrUpdateSellerTypeEntity(SellerTypeEntity sellertypeEntity, bool isCopy)
        {
            try
            {

                genericGateway.SaveOrUpdateEntity<MSellerType>(mapper.GetSellerType(sellertypeEntity), isCopy);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at SaveOrUpdateSellerTypeEntity", ex);
                Logger.Error("Error in SaveOrUpdateSellerTypeEntity: Message - " + ex.Message + " StackTrace - " + ex.StackTrace);
                throw;
            }
        }

        public void SaveOrUpdateSellerInfoEntity(SellerInfoEntity sellerInfoEntity, bool isCopy)
        {
            try
            {

                genericGateway.SaveOrUpdateEntity<SellerInfo>(mapper.GetSellerInfo(sellerInfoEntity), isCopy);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at SaveOrUpdateSellerInfoEntity", ex);
                Logger.Error("Error in SaveOrUpdateSellerInfoEntity: Message - " + ex.Message + " StackTrace - " + ex.StackTrace);
                throw;
            }
        }


        /// <summary>
        /// Gets all audit module visit.
        /// </summary>
        /// <returns></returns>
        public SellerTypeEntity GetSellerTypeEntity(string SellerTypeID)
        {

            return rmisGateway.GetSellerTypeEntity(SellerTypeID);
        }
        public SellerInfoEntity GetSellerInfoEntity(string SellerID)
        {

            return rmisGateway.GetSellerInfoEntity(SellerID);
        }
        #endregion




        public void SaveOrUpdateCustomerInfoEntity(CustomerInfoEntity customerInfoEntity, bool isCopy)
        {
            try
            {
                genericGateway.SaveOrUpdateEntity<CustomerInfo>(mapper.GetCustomerInfo(customerInfoEntity), isCopy);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at SaveOrUpdateCustomerInfoEntity", ex);
                Logger.Error("Error in SaveOrUpdateCustomerInfoEntity: Message - " + ex.Message + " StackTrace - " + ex.StackTrace);
                throw;
            }
        }

        public CustomerInfoEntity GetCustomerInfoEntity(string CustID)
        {

            return rmisGateway.GetCustomerInfoEntity(CustID);
        }


        public void SaveOrUpdateMUserTypeEntity(MUserTypeEntity mUserTypeEntity, bool isCopy)
        {
            try
            {

                genericGateway.SaveOrUpdateEntity<MUserType>(mapper.GetMUserType(mUserTypeEntity), isCopy);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at SaveOrUpdateMUserTypeEntity", ex);
                Logger.Error("Error in SaveOrUpdateMUserTypeEntity: Message - " + ex.Message + " StackTrace - " + ex.StackTrace);
                throw;
            }
        }

        public MUserTypeEntity GetMUserTypeEntity(string UserTypeID)
        {

            return rmisGateway.GetMUserTypeEntity(UserTypeID);
        }


        public void SaveOrUpdateUsersEntity(UsersEntity usersEntity, bool isCopy)
        {
            try
            {

                genericGateway.SaveOrUpdateEntity<Users>(mapper.GetUsers(usersEntity), isCopy);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at SaveOrUpdateUsersEntity", ex);
                Logger.Error("Error in SaveOrUpdateUsersEntity: Message - " + ex.Message + " StackTrace - " + ex.StackTrace);
                throw;
            }
        }

        public UsersEntity GetUsersEntity(string UserID)
        {

            return rmisGateway.GetUsersEntity(UserID);
        }


        public void SaveOrUpdateMPaddyTypeEntity(MPaddyTypeEntity mPaddyTypeEntity, bool isCopy)
        {
            try
            {

                genericGateway.SaveOrUpdateEntity<MPaddyType>(mapper.GetMPaddyType(mPaddyTypeEntity), isCopy);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at SaveOrUpdateMPaddyTypeEntity", ex);
                Logger.Error("Error in SaveOrUpdateMPaddyTypeEntity: Message - " + ex.Message + " StackTrace - " + ex.StackTrace);
                throw;
            }
        }


        public MPaddyTypeEntity GetMPaddyTypeEntity(string PaddyTypeID)
        {

            return rmisGateway.GetMPaddyTypeEntity(PaddyTypeID);

        }


        public void SaveOrUpdatePaddyStockInfoEntity(PaddyStockInfoEntity paddyStockInfoEntity, bool isCopy)
        {
            try
            {

                genericGateway.SaveOrUpdateEntity<PaddyStockInfo>(mapper.GetPaddyStockInfo(paddyStockInfoEntity), isCopy);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at SaveOrUpdatePaddyStockInfoEntity", ex);
                Logger.Error("Error in SaveOrUpdatePaddyStockInfoEntity: Message - " + ex.Message + " StackTrace - " + ex.StackTrace);
                throw;
            }
        }

        public PaddyStockInfoEntity GetPaddyStockInfoEntity(string PaddyStockID)
        {

            return rmisGateway.GetPaddyStockInfoEntity(PaddyStockID);
        }


        public void SaveOrUpdateMLotDetailsEntity(MLotDetailsEntity mLotDetailsEntity, bool isCopy)
        {
            try
            {

                genericGateway.SaveOrUpdateEntity<MLotDetails>(mapper.GetMLotDetails(mLotDetailsEntity), isCopy);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at SaveOrUpdateMLotDetailsEntity", ex);
                Logger.Error("Error in SaveOrUpdateMLotDetailsEntity: Message - " + ex.Message + " StackTrace - " + ex.StackTrace);
                throw;
            }
        }

        public MLotDetailsEntity GetMLotDetailsEntity(string MLotID)
        {

            return rmisGateway.GetMLotDetailsEntity(MLotID);
        }


        public void SaveOrUpdateMGodownDetailsEntity(MGodownDetailsEntity mGodownDetailsEntity, bool isCopy)
        {
            try
            {

                genericGateway.SaveOrUpdateEntity<MGodownDetails>(mapper.GetMGodownDetails(mGodownDetailsEntity), isCopy);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at SaveOrUpdateMGodownDetailsEntity", ex);
                Logger.Error("Error in SaveOrUpdateMGodownDetailsEntity: Message - " + ex.Message + " StackTrace - " + ex.StackTrace);
                throw;
            }

        }

        public MGodownDetailsEntity GetMGodownDetailsEntity(string MGodownID)
        {

            return rmisGateway.GetMGodownDetailsEntity(MGodownID);
        }


        public void SaveOrUpdatePaddyPaymentDetailsEntity(PaddyPaymentDetailsEntity paddyPaymentDetailsEntity, bool isCopy)
        {
            try
            {

                genericGateway.SaveOrUpdateEntity<PaddyPaymentDetails>(mapper.GetPaddyPaymentDetails(paddyPaymentDetailsEntity), isCopy);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at SaveOrUpdatePaddyPaymentDetailsEntity", ex);
                Logger.Error("Error in SaveOrUpdatePaddyPaymentDetailsEntity: Message - " + ex.Message + " StackTrace - " + ex.StackTrace);
                throw;
            }
        }

        public PaddyPaymentDetailsEntity GetPaddyPaymentDetailsEntity(string PaddyPaymentID)
        {

            return rmisGateway.GetPaddyPaymentDetailsEntity(PaddyPaymentID);
        }


        public void SaveOrUpdateMWeightDetailsEntity(MWeightDetailsEntity mWeightDetailsEntity, bool isCopy)
        {
            try
            {

                genericGateway.SaveOrUpdateEntity<MWeightDetails>(mapper.GetMWeightDetails(mWeightDetailsEntity), isCopy);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at SaveOrUpdateMWeightDetailsEntity", ex);
                Logger.Error("Error in SaveOrUpdateMWeightDetailsEntity: Message - " + ex.Message + " StackTrace - " + ex.StackTrace);
                throw;
            }
        }

        public MWeightDetailsEntity GetMWeightDetailsEntity(string MWeightID)
        {

            return rmisGateway.GetMWeightDetailsEntity(MWeightID);
        }


        public void SaveOrUpdateCustomerAddressInfoEntity(CustomerAddressInfoEntity customerAddressInfoEntity, bool isCopy)
        {
            try
            {

                genericGateway.SaveOrUpdateEntity<CustomerAddressInfo>(mapper.GetCustomerAddressInfo(customerAddressInfoEntity), isCopy);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at SaveOrUpdateCustomerAddressInfoEntity", ex);
                Logger.Error("Error in SaveOrUpdateCustomerAddressInfoEntity: Message - " + ex.Message + " StackTrace - " + ex.StackTrace);
                throw;
            }
        }

        public CustomerAddressInfoEntity GetCustomerAddressInfoEntity(string CustAdrsID)
        {

            return rmisGateway.GetCustomerAddressInfoEntity(CustAdrsID);
        }


        public void SaveOrUpdateCustomerActivationEntity(CustomerActivationEntity customerActivationEntity, bool isCopy)
        {
            try
            {

                genericGateway.SaveOrUpdateEntity<CustomerActivation>(mapper.GetCustomerActivation(customerActivationEntity), isCopy);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at SaveOrUpdateCustomerActivationEntity", ex);
                Logger.Error("Error in SaveOrUpdateCustomerActivationEntity: Message - " + ex.Message + " StackTrace - " + ex.StackTrace);
                throw;
            }
        }

        public CustomerActivationEntity GetCustomerActivationEntity(string CustActiveID)
        {

            return rmisGateway.GetCustomerActivationEntity(CustActiveID);
        }


        public void SaveOrUpdateCustTrailUsageEntity(CustTrailUsageEntity custTrailUsageEntity, bool isCopy)
        {
            try
            {

                genericGateway.SaveOrUpdateEntity<CustTrailUsage>(mapper.GetCustTrailUsage(custTrailUsageEntity), isCopy);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at SaveOrUpdateCustTrailUsageEntity", ex);
                Logger.Error("Error in SaveOrUpdateCustTrailUsageEntity: Message - " + ex.Message + " StackTrace - " + ex.StackTrace);
                throw;
            }
        }

        public CustTrailUsageEntity GetCustTrailUsageEntity(string CustTrailID)
        {

            return rmisGateway.GetCustTrailUsageEntity(CustTrailID);
        }


        public void SaveOrUpdateCustomerPaymentEntity(CustomerPaymentEntity customerPaymentEntity, bool isCopy)
        {
            try
            {

                genericGateway.SaveOrUpdateEntity<CustomerPayment>(mapper.GetCustomerPayment(customerPaymentEntity), isCopy);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at SaveOrUpdateCustomerPaymentEntity", ex);
                Logger.Error("Error in SaveOrUpdateCustomerPaymentEntity: Message - " + ex.Message + " StackTrace - " + ex.StackTrace);
                throw;
            }
        }

        public CustomerPaymentEntity GetCustomerPaymentEntity(string CustPaymentID)
        {

            return rmisGateway.GetCustomerPaymentEntity(CustPaymentID);
        }


        public void SaveOrUpdateCustomerPartPayDetailsEntity(CustomerPartPayDetailsEntity customerPartPayDetailsEntity, bool isCopy)
        {
            try
            {

                genericGateway.SaveOrUpdateEntity<CustomerPartPayDetails>(mapper.GetCustomerPartPayDetails(customerPartPayDetailsEntity), isCopy);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at SaveOrUpdateCustomerPartPayDetailsEntity", ex);
                Logger.Error("Error in SaveOrUpdateCustomerPartPayDetailsEntity: Message - " + ex.Message + " StackTrace - " + ex.StackTrace);
                throw;
            }
        }

        public CustomerPartPayDetailsEntity GetCustomerPartPayDetailsEntity(string CustPartPayID)
        {

            return rmisGateway.GetCustomerPartPayDetailsEntity(CustPartPayID);
        }


        public void SaveOrUpdateMDrierTypeDetailsEntity(MDrierTypeDetailsEntity mDrierTypeDetailsEntity, bool isCopy)
        {
            try
            {

                genericGateway.SaveOrUpdateEntity<MDrierTypeDetails>(mapper.GetMDrierTypeDetails(mDrierTypeDetailsEntity), isCopy);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at SaveOrUpdateMDrierTypeDetailsEntity", ex);
                Logger.Error("Error in SaveOrUpdateMDrierTypeDetailsEntity: Message - " + ex.Message + " StackTrace - " + ex.StackTrace);
                throw;
            }
        }

        public MDrierTypeDetailsEntity GetMDrierTypeDetailsEntity(string MDrierTypeID)
        {

            return rmisGateway.GetMDrierTypeDetailsEntity(MDrierTypeID);
        }


        public void SaveOrUpdateMRiceProductionTypeEntity(MRiceProductionTypeEntity mRiceProductionTypeEntity, bool isCopy)
        {
            try
            {

                genericGateway.SaveOrUpdateEntity<MRiceProductionType>(mapper.GetMRiceProductionType(mRiceProductionTypeEntity), isCopy);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at SaveOrUpdateMDrierTypeDetailsEntity", ex);
                Logger.Error("Error in SaveOrUpdateMDrierTypeDetailsEntity: Message - " + ex.Message + " StackTrace - " + ex.StackTrace);
                throw;
            }
        }

        public MRiceProductionTypeEntity GetMRiceProductionTypeEntity(string MRiceProdTypeID)
        {

            return rmisGateway.GetMRiceProductionTypeEntity(MRiceProdTypeID);
        }


        public void SaveOrUpdateMRiceBrandDetailsEntity(MRiceBrandDetailsEntity mRiceBrandDetailsEntity, bool isCopy)
        {
            try
            {

                genericGateway.SaveOrUpdateEntity<MRiceBrandDetails>(mapper.GetMRiceBrandDetails(mRiceBrandDetailsEntity), isCopy);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at SaveOrUpdateMRiceBrandDetailsEntity", ex);
                Logger.Error("Error in SaveOrUpdateMRiceBrandDetailsEntity: Message - " + ex.Message + " StackTrace - " + ex.StackTrace);
                throw;
            }
        }

        public MRiceBrandDetailsEntity GetMRiceBrandDetailsEntity(string MRiceBrandID)
        {

            return rmisGateway.GetMRiceBrandDetailsEntity(MRiceBrandID);
        }


        public List<SellerTypeEntity> GetSellerTypeEntities(string CustId)
        {
            return rmisGateway.GetSellerTypeEntities(CustId);
        }


        public List<MUserTypeEntity> GetMUserTypeEntities(string CustId)
        {
            return rmisGateway.GetMUserTypeEntities(CustId);
        }

        public List<MPaddyTypeEntity> GetMPaddyTypeEntitiies(string CustId)
        {
            return rmisGateway.GetMPaddyTypeEntities(CustId);
        }

        public List<PaddyStockInfoEntity> GetPaddyStockInfoEntities(string CustId)
        {
            return rmisGateway.GetPaddyStockInfoEntities(CustId);
        }

        public List<MLotDetailsEntity> GetMLotDetailsEntities(string CustId, string MGodownID)
        {
            return rmisGateway.GetMLotDetailsEntities(CustId, MGodownID);
        }

        public List<MGodownDetailsEntity> GetMGodownDetailsEntities(string MGodownID)
        {
            throw new NotImplementedException();
        }

        public List<MWeightDetailsEntity> GetMWeightDetailsEntities(string CustId)
        {
            return rmisGateway.GetMWeightDetailsEntities(CustId);
        }
        public List<MRiceProductionTypeEntity> GetMRiceProductionTypeEntities(string CustId)
        {
            return rmisGateway.GetMRiceProductionTypeEntities(CustId);
        }

        public List<MRiceBrandDetailsEntity> GetMRiceBrandDetailsEntities(string CustId)
        {
            return rmisGateway.GetMRiceBrandDetailsEntities(CustId);
        }


        public List<MLotDetailsEntity> GetMLotDetailsEntities(string CustId)
        {
            return rmisGateway.GetMLotDetailsEntities(CustId);
        }
    }
}
