
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
    
    public class RMISMediatorImpl : IRMISMediator
    {
        public IRMISMapper mapper;
        public RMISMediatorImpl(IRMISMapper mapper)
        {
            this.mapper = mapper;
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
                GenericGateway genericGateway = new GenericGateway();
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
                GenericGateway genericGateway = new GenericGateway();
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
            RMISGateway auditGateway = new RMISGateway();
            return auditGateway.GetSellerTypeEntity(SellerTypeID);
        }
        public SellerInfoEntity GetSellerInfoEntity(string SellerID)
        {
            RMISGateway auditGateway = new RMISGateway();
            return auditGateway.GetSellerInfoEntity(SellerID);
        }
        #endregion




        public void SaveOrUpdateCustomerInfoEntity(CustomerInfoEntity customerInfoEntity, bool isCopy)
        {
            try
            {
                GenericGateway genericGateway = new GenericGateway();
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
            RMISGateway auditGateway = new RMISGateway();
            return auditGateway.GetCustomerInfoEntity(CustID);
        }


        public void SaveOrUpdateMUserTypeEntity(MUserTypeEntity mUserTypeEntity, bool isCopy)
        {
            try
            {
                GenericGateway genericGateway = new GenericGateway();
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
            RMISGateway auditGateway = new RMISGateway();
            return auditGateway.GetMUserTypeEntity(UserTypeID);
        }


        public void SaveOrUpdateUsersEntity(UsersEntity usersEntity, bool isCopy)
        {
            try
            {
                GenericGateway genericGateway = new GenericGateway();
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
            RMISGateway auditGateway = new RMISGateway();
            return auditGateway.GetUsersEntity(UserID);
        }


        public void SaveOrUpdateMPaddyTypeEntity(MPaddyTypeEntity mPaddyTypeEntity, bool isCopy)
        {
            try
            {
                GenericGateway genericGateway = new GenericGateway();
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
            RMISGateway auditGateway = new RMISGateway();
            return auditGateway.GetMPaddyTypeEntity(PaddyTypeID);
        
        }


        public void SaveOrUpdatePaddyStockInfoEntity(PaddyStockInfoEntity paddyStockInfoEntity, bool isCopy)
        {
            try
            {
                GenericGateway genericGateway = new GenericGateway();
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
            RMISGateway auditGateway = new RMISGateway();
            return auditGateway.GetPaddyStockInfoEntity(PaddyStockID);
        }


        public void SaveOrUpdateMLotDetailsEntity(MLotDetailsEntity mLotDetailsEntity, bool isCopy)
        {
            try
            {
                GenericGateway genericGateway = new GenericGateway();
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
            RMISGateway auditGateway = new RMISGateway();
            return auditGateway.GetMLotDetailsEntity(MLotID);
        }


        public void SaveOrUpdateMGodownDetailsEntity(MGodownDetailsEntity mGodownDetailsEntity, bool isCopy)
        {
            try
            {
                GenericGateway genericGateway = new GenericGateway();
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
            RMISGateway auditGateway = new RMISGateway();
            return auditGateway.GetMGodownDetailsEntity(MGodownID);
        }


        public void SaveOrUpdatePaddyPaymentDetailsEntity(PaddyPaymentDetailsEntity paddyPaymentDetailsEntity, bool isCopy)
        {
            try
            {
                GenericGateway genericGateway = new GenericGateway();
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
            RMISGateway auditGateway = new RMISGateway();
            return auditGateway.GetPaddyPaymentDetailsEntity(PaddyPaymentID);
        }


        public void SaveOrUpdateMWeightDetailsEntity(MWeightDetailsEntity mWeightDetailsEntity, bool isCopy)
        {
            try
            {
                GenericGateway genericGateway = new GenericGateway();
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
            RMISGateway auditGateway = new RMISGateway();
            return auditGateway.GetMWeightDetailsEntity(MWeightID);
        }


        public void SaveOrUpdateCustomerAddressInfoEntity(CustomerAddressInfoEntity customerAddressInfoEntity, bool isCopy)
        {
            try
            {
                GenericGateway genericGateway = new GenericGateway();
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
            RMISGateway auditGateway = new RMISGateway();
            return auditGateway.GetCustomerAddressInfoEntity(CustAdrsID);
        }


        public void SaveOrUpdateCustomerActivationEntity(CustomerActivationEntity customerActivationEntity, bool isCopy)
        {
            try
            {
                GenericGateway genericGateway = new GenericGateway();
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
            RMISGateway auditGateway = new RMISGateway();
            return auditGateway.GetCustomerActivationEntity(CustActiveID);
        }


        public void SaveOrUpdateCustTrailUsageEntity(CustTrailUsageEntity custTrailUsageEntity, bool isCopy)
        {
            try
            {
                GenericGateway genericGateway = new GenericGateway();
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
            RMISGateway auditGateway = new RMISGateway();
            return auditGateway.GetCustTrailUsageEntity(CustTrailID);
        }


        public void SaveOrUpdateCustomerPaymentEntity(CustomerPaymentEntity customerPaymentEntity, bool isCopy)
        {
            try
            {
                GenericGateway genericGateway = new GenericGateway();
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
            RMISGateway auditGateway = new RMISGateway();
            return auditGateway.GetCustomerPaymentEntity(CustPaymentID);
        }


        public void SaveOrUpdateCustomerPartPayDetailsEntity(CustomerPartPayDetailsEntity customerPartPayDetailsEntity, bool isCopy)
        {
            try
            {
                GenericGateway genericGateway = new GenericGateway();
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
            RMISGateway auditGateway = new RMISGateway();
            return auditGateway.GetCustomerPartPayDetailsEntity(CustPartPayID);
        }


        public void SaveOrUpdateMDrierTypeDetailsEntity(MDrierTypeDetailsEntity mDrierTypeDetailsEntity, bool isCopy)
        {
            try
            {
                GenericGateway genericGateway = new GenericGateway();
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
            RMISGateway auditGateway = new RMISGateway();
            return auditGateway.GetMDrierTypeDetailsEntity(MDrierTypeID);
        }


        public void SaveOrUpdateMDrierTypeDetailsEntity(MRiceProductionTypeEntity mRiceProductionTypeEntity, bool isCopy)
        {
            try
            {
                GenericGateway genericGateway = new GenericGateway();
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
            RMISGateway auditGateway = new RMISGateway();
            return auditGateway.GetMRiceProductionTypeEntity(MRiceProdTypeID);
        }


        public void SaveOrUpdateMRiceBrandDetailsEntity(MRiceBrandDetailsEntity mRiceBrandDetailsEntity, bool isCopy)
        {
            try
            {
                GenericGateway genericGateway = new GenericGateway();
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
            RMISGateway auditGateway = new RMISGateway();
            return auditGateway.GetMRiceBrandDetailsEntity(MRiceBrandID);
        }
    }
}
