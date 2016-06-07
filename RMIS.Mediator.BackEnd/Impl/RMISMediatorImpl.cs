
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
    using RMIS.Domain.Constant;

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



        /// <summary>
        /// Saves the or update audit entity.
        /// </summary>
        /// <param name="auditEntity">The audit entity.</param>
        /// <param name="isCopy">if set to <c>true</c> [is copy].</param>
        public void SaveOrUpdateMenuConfigEntity(MenuConfigurationEntity menuConfigEntity, bool isCopy)
        {
            try
            {
                genericGateway.SaveOrUpdateEntity<MenuConfiguration>(mapper.GetMenuConfig(menuConfigEntity), isCopy);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at SaveOrUpdateMenuConfigEntity", ex);
                Logger.Error("Error in SaveOrUpdateMenuConfigEntity: Message - " + ex.Message + " StackTrace - " + ex.StackTrace);
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
        public List<MUserTypeEntity> GetMUserTypeEntities(string CustId)
        {
            return rmisGateway.GetMUserTypeEntities(CustId);
        }



        public List<MPaddyTypeEntity> GetMPaddyTypeEntitiies(string CustId)
        {
            return rmisGateway.GetMPaddyTypeEntities(CustId);
        }

        public List<MPaddyTypeEntity> GetMPaddyTypeEntities(string CustId, int pageindex, int pageSize, out int count, SortExpression expression)
        {
            return rmisGateway.GetMPaddyTypeEntities(CustId, pageindex, pageSize, out count, expression);
        }

        public List<PaddyStockInfoEntity> GetPaddyStockInfoEntities(string CustId)
        {
            return rmisGateway.GetPaddyStockInfoEntities(CustId);
        }

        public List<MLotDetailsEntity> GetMLotDetailsEntities(string CustId, string MGodownID)
        {
            return rmisGateway.GetMLotDetailsEntities(CustId, MGodownID);
        }

        public List<MGodownDetailsEntity> GetMGodownDetailsEntities(string CustId)
        {
            return rmisGateway.GetAllMGodownDetailsEntity(CustId);
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


        public List<SellerInfoEntity> GetSellerInfoEntities(string CustId)
        {
            return rmisGateway.GetSellerInfoEntities(CustId);
        }


        public List<SellerInfoEntity> GetListSellerInfoEntities(string CustId)
        {
            return rmisGateway.GetSellerInfoEntities(CustId);
        }


        public void SaveOrUpdateMBagTypeEntity(MBagTypeEntity mBagtypeEntity, bool isCopy)
        {
            try
            {

                genericGateway.SaveOrUpdateEntity<MBagType>(mapper.GetBagType(mBagtypeEntity), isCopy);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at SaveOrUpdateBagTypeEntity", ex);
                Logger.Error("Error in SaveOrUpdateBagTypeEntity: Message - " + ex.Message + " StackTrace - " + ex.StackTrace);
                throw;
            }
        }

        public List<MBagTypeEntity> GetMBagTypeEntities(string CustId)
        {
            return rmisGateway.GetMBagTypeEntities(CustId);
        }


        public void SaveOrUpdateBagStockInfoEntity(BagStockInfoEntity bagStockInfoEntity, bool isCopy)
        {
            try
            {

                genericGateway.SaveOrUpdateEntity<BagStockInfo>(mapper.GetBagStockInfo(bagStockInfoEntity), isCopy);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at SaveOrUpdateBagStockInfoEntity", ex);
                Logger.Error("Error in SaveOrUpdateBagStockInfoEntity: Message - " + ex.Message + " StackTrace - " + ex.StackTrace);
                throw;
            }
        }

        public BagStockInfoEntity GetBagStockInfoEntity(string BagStockID)
        {
            return rmisGateway.GetBagStockInfoEntity(BagStockID);
        }


        public List<BagStockInfoEntity> GetBagStockInfoEntities(string CustId)
        {
            return rmisGateway.GetBagStockInfoEntities(CustId);
        }


        public List<MUnitsTypeEntity> GetMUnitsTypeEntities(string CustId)
        {
            return rmisGateway.GetMUnitsTypeEntities(CustId);
        }


        public void SaveOrUpdateMUnitsTypeEntity(MUnitsTypeEntity mUnitstypeEntity, bool isCopy)
        {
            try
            {

                genericGateway.SaveOrUpdateEntity<MUnitsType>(mapper.GetUnitsType(mUnitstypeEntity), isCopy);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at SaveOrUpdateUnitsTypeEntity", ex);
                Logger.Error("Error in SaveOrUpdateUnitsTypeEntity: Message - " + ex.Message + " StackTrace - " + ex.StackTrace);
                throw;
            }
        }


        public void SaveOrUpdateMBrokenRiceTypeEntity(MBrokenRiceTypeEntity mBrokenRiceTypeEntity, bool isCopy)
        {
            try
            {

                genericGateway.SaveOrUpdateEntity<MBrokenRiceType>(mapper.GetMBrokenRiceType(mBrokenRiceTypeEntity), isCopy);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at SaveOrUpdateUnitsTypeEntity", ex);
                Logger.Error("Error in SaveOrUpdateUnitsTypeEntity: Message - " + ex.Message + " StackTrace - " + ex.StackTrace);
                throw;
            }
        }

        public List<MBrokenRiceTypeEntity> GetMBrokenRiceTypeEntitiies(string CustId)
        {
            return rmisGateway.GetMBrokenRiceTypeEntities(CustId);

        }


        public List<RiceStockInfoEntity> GetAllRiceStockInfoEntities(string CustId)
        {
            return rmisGateway.GetAllRiceStockInfoEntities(CustId);
        }


        public void SaveOrUpdateRiceStockInfoEntity(RiceStockInfoEntity riceStockInfoEntity, bool isCopy)
        {
            try
            {

                genericGateway.SaveOrUpdateEntity<RiceStockInfo>(mapper.GetRiceStockInfo(riceStockInfoEntity), isCopy);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at SaveOrUpdateRiceStockInfoEntity", ex);
                Logger.Error("Error in SaveOrUpdateRiceStockInfoEntity: Message - " + ex.Message + " StackTrace - " + ex.StackTrace);
                throw;
            }
        }


        public void SaveOrUpdateBrokenRiceStockInfoEntity(BrokenRiceStockInfoEntity brokenRiceStockInfoEntity, bool isCopy)
        {
            try
            {
                genericGateway.SaveOrUpdateEntity<BrokenRiceStockInfo>(mapper.GetBrokenRiceStockInfo(brokenRiceStockInfoEntity), isCopy);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at SaveOrUpdateBrokenRiceStockInfoEntity", ex);
                Logger.Error("Error in SaveOrUpdateBrokenRiceStockInfoEntity: Message - " + ex.Message + " StackTrace - " + ex.StackTrace);
                throw;
            }
        }

        public List<BrokenRiceStockInfoEntity> GetAllBrokenRiceStockInfoEntities(string CustId)
        {
            return rmisGateway.GetAllBrokenRiceStockInfoEntities(CustId);
        }


        public void SaveOrUpdateDustStockInfoEntity(DustStockInfoEntity dustStockInfoEntity, bool isCopy)
        {
            try
            {

                genericGateway.SaveOrUpdateEntity<DustStockInfo>(mapper.GetDustStockInfo(dustStockInfoEntity), isCopy);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at SaveOrUpdateDustStockInfoEntity", ex);
                Logger.Error("Error in SaveOrUpdateDustStockInfoEntity: Message - " + ex.Message + " StackTrace - " + ex.StackTrace);
                throw;
            }
        }

        public List<DustStockInfoEntity> GetAllDustStockInfoEntities(string CustId)
        {
            return rmisGateway.GetAllDustStockInfoEntities(CustId);
        }


        public void SaveOrUpdateRiceSellingInfoEntity(RiceSellingInfoEntity riceSellingInfoEntity, bool isCopy)
        {
            try
            {

                genericGateway.SaveOrUpdateEntity<RiceSellingInfo>(mapper.GetRiceSellingInfo(riceSellingInfoEntity), isCopy);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at SaveOrUpdateRiceSellingInfoEntity", ex);
                Logger.Error("Error in SaveOrUpdateRiceSellingInfoEntity: Message - " + ex.Message + " StackTrace - " + ex.StackTrace);
                throw;
            }
        }

        public List<RiceSellingInfoEntity> GetAllRiceSellingInfoEntities(string CustId)
        {
            return rmisGateway.GetAllRiceSellingInfoEntities(CustId);
        }
        public void SaveOrUpdateBrokenRiceSellingInfoEntity(BrokenRiceSellingInfoEntity brokenRiceSellingInfoEntity, bool isCopy)
        {
            try
            {

                genericGateway.SaveOrUpdateEntity<BrokenRiceSellingInfo>(mapper.GetBrokenRiceSellingInfo(brokenRiceSellingInfoEntity), isCopy);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at SaveOrUpdateBrokenRiceSellingInfoEntity", ex);
                Logger.Error("Error in SaveOrUpdateBrokenRiceSellingInfoEntity: Message - " + ex.Message + " StackTrace - " + ex.StackTrace);
                throw;
            }
        }

        public List<BrokenRiceSellingInfoEntity> GetAllBrokenRiceSellingInfoEntities(string CustId)
        {
            return rmisGateway.GetAllBrokenRiceSellingInfoEntities(CustId);
        }


        public void SaveOrUpdateDustSellingInfoEntity(DustSellingInfoEntity dustSellingInfoEntity, bool isCopy)
        {
            try
            {
                genericGateway.SaveOrUpdateEntity<DustSellingInfo>(mapper.GetDustSellingInfo(dustSellingInfoEntity), isCopy);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at SaveOrUpdateDustSellingInfoEntity", ex);
                Logger.Error("Error in SaveOrUpdateDustSellingInfoEntity: Message - " + ex.Message + " StackTrace - " + ex.StackTrace);
                throw;
            }
        }

        public List<DustSellingInfoEntity> GetAllDustSellingInfoEntities(string CustId)
        {
            return rmisGateway.GetAllDustSellingInfoEntities(CustId);
        }

        public List<MenuInfoEntity> GetAllMenuInfoEntities()
        {
            return rmisGateway.GetMenuInfoEntities();
        }


        public List<CustomerInfoEntity> GetCustomerInfoEntities()
        {
            return rmisGateway.GetCustomerInfoEntities();
        }


        public List<MenuConfigurationEntity> GetMenuConfigurationEntities(string CustId)
        {
            return rmisGateway.GetMenuConfigurationEntities(CustId);
        }


        public List<MProductSellingTypeEntity> GetMProductSellingTypeEnties(string CustId)
        {
            return rmisGateway.GetMProductSellingTypeEnties(CustId);
        }


        public void SaveOrUpdateMProductSellingTypeEntity(MProductSellingTypeEntity mProductSellingTypeEntity, bool isCopy)
        {

            try
            {
                genericGateway.SaveOrUpdateEntity<MProductSellingType>(mapper.GetMProductSellingType(mProductSellingTypeEntity), isCopy);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at SaveOrUpdateMProductSellingTypeEntity", ex);
                Logger.Error("Error in SaveOrUpdateMProductSellingTypeEntity: Message - " + ex.Message + " StackTrace - " + ex.StackTrace);
                throw;
            }
        }


        public void SaveOrUpdateProductSellingInfoEntity(ProductSellingInfoEntity productSellingInfoEntity, bool isCopy)
        {
            try
            {
                genericGateway.SaveOrUpdateEntity<ProductSellingInfo>(mapper.GetProductSellingInfo(productSellingInfoEntity), isCopy);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at SaveOrUpdateProductSellingInfoEntity", ex);
                Logger.Error("Error in SaveOrUpdateProductSellingInfoEntity: Message - " + ex.Message + " StackTrace - " + ex.StackTrace);
                throw;
            }
        }

        public List<ProductSellingInfoEntity> GetAllproductSellingInfoEntities(string CustId)
        {
            return rmisGateway.GetAllProductSellingInfoEntities(CustId);
        }


        public void SaveOrUpdateHullingProcessInfoEntity(HullingProcessEntity hullingProcessInfoEntity, bool isCopy)
        {
            try
            {
                genericGateway.SaveOrUpdateEntity<HullingProcess>(mapper.GetHullingProcessInfo(hullingProcessInfoEntity), isCopy);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at SaveOrUpdateHullingProcessInfoEntity", ex);
                Logger.Error("Error in SaveOrUpdateHullingProcessInfoEntity: Message - " + ex.Message + " StackTrace - " + ex.StackTrace);
                throw;
            }
        }
        public List<HullingProcessEntity> GetAllHullingProcessInfoEntity(string CustId)
        {
            return rmisGateway.GetHullingProcessInfoEntities(CustId);
        }


        public void SaveOrUpdateHullingProcessTransInfoEntity(HullingProcessTransactionEntity hullingProcessTransactionEntity, bool isCopy)
        {
            try
            {
                genericGateway.SaveOrUpdateEntity<HullingTransaction>(mapper.GetHullingProcessTransaction(hullingProcessTransactionEntity), isCopy);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at SaveOrUpdateHullingProcessTransInfoEntity", ex);
                Logger.Error("Error in SaveOrUpdateHullingProcessTransInfoEntity: Message - " + ex.Message + " StackTrace - " + ex.StackTrace);
                throw;
            }
        }

        public List<HullingProcessTransactionEntity> GetAllHullingProcessTransInfoEntity(string CustId)
        {
            return rmisGateway.GetHullingProcessTransInfoEntities(CustId);
        }


        public void SaveOrUpdateRoleEntity(MRolesEntity mRoleEntity, bool isCopy)
        {
            try
            {
                genericGateway.SaveOrUpdateEntity<MRoles>(mapper.GetRoles(mRoleEntity), isCopy);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at SaveOrUpdateRoleEntity", ex);
                Logger.Error("Error in SaveOrUpdateRoleEntity: Message - " + ex.Message + " StackTrace - " + ex.StackTrace);
                throw;
            }
        }

        public List<MRolesEntity> GetAllRolesEntity()
        {
            return rmisGateway.GetRoleEntities();
        }


        public UsersEntity GetUsersEntity(string userName, string custId)
        {
            return rmisGateway.GetUsersEntity(userName, custId);
        }

        public List<RMUserRoleEntity> GetUserRoleEntities(string userId)
        {
            return rmisGateway.GetUserRoles(userId);
        }

        public void SaveOrUpdateUserRoleEntity(RMUserRoleEntity muserRoleEntity, bool isCopy)
        {
            try
            {
                genericGateway.SaveOrUpdateEntity<RMUserRole>(mapper.GetUserRole(muserRoleEntity), isCopy);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at SaveOrUpdateUserRoleEntity", ex);
                Logger.Error("Error in SaveOrUpdateUserRoleEntity: Message - " + ex.Message + " StackTrace - " + ex.StackTrace);
                throw;
            }
        }
        public List<HullingProcessExpensesEntity> GetAllHullingProcessExpensesEntity(string CustId)
        {
            return rmisGateway.GetHullingProcessExpensesEntities(CustId);
        }
        public void SaveOrUpdateHullingProcessExpensesInfoEntity(HullingProcessExpensesEntity hullingProcessExpensesEntity, bool isCopy)
        {
            try
            {
                genericGateway.SaveOrUpdateEntity<HullingProcessExpenses>(mapper.GetHullingProcessExpensesinfo(hullingProcessExpensesEntity), isCopy);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at SaveOrUpdateHullingProcessTransInfoEntity", ex);
                Logger.Error("Error in SaveOrUpdateHullingProcessTransInfoEntity: Message - " + ex.Message + " StackTrace - " + ex.StackTrace);
                throw;
            }
        }



        public void SaveOrUpdateBuyyerSellerRatingEnity(BuyerSellerRatingEntity buyerSellerRatingEntity, bool isCopy)
        {
            try
            {
                genericGateway.SaveOrUpdateEntity<BuyerSellerRating>(mapper.GetBuyerSellerRating(buyerSellerRatingEntity), isCopy);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at SaveOrUpdateBuyyerSellerRatingEnity", ex);
                Logger.Error("Error in SaveOrUpdateBuyyerSellerRatingEnity: Message - " + ex.Message + " StackTrace - " + ex.StackTrace);
                throw;
            }
        }

        public List<BuyerSellerRatingEntity> GetAllBuyerSellerRatingEntities(string CustId)
        {
            return rmisGateway.GetAllBuyerSellerRatingEntities(CustId);
        }
        public void SaveOrUpdateBuyerInfoEntity(BuyerInfoEntity BuyerInfoEntity, bool isCopy)
        {
            try
            {
                genericGateway.SaveOrUpdateEntity<BuyerInfo>(mapper.GetBuyerInfo(BuyerInfoEntity), isCopy);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at SaveOrUpdateBuyerInfoEntity", ex);
                Logger.Error("Error in SaveOrUpdateBuyerInfoEntity: Message - " + ex.Message + " StackTrace - " + ex.StackTrace);
                throw;
            }
        }
        public void SaveOrUpdateMEmployeeDesignationEntity(MEmployeeDesignationEntity MEmployeeDesignationEntity, bool isCopy)
        {
            try
            {
                genericGateway.SaveOrUpdateEntity<MEmployeeDesignation>(mapper.GetMEmployeeDesignation(MEmployeeDesignationEntity), isCopy);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at SaveOrUpdateMEmployeeDesignationEntity", ex);
                Logger.Error("Error in SaveOrUpdateMEmployeeDesignationEntity: Message - " + ex.Message + " StackTrace - " + ex.StackTrace);
                throw;
            }
        }
        public void SaveOrUpdateMSalaryTypeEntity(MSalaryTypeEntity MSalaryTypeEntity, bool isCopy)
        {
            try
            {
                genericGateway.SaveOrUpdateEntity<MSalaryType>(mapper.GetMSalaryType(MSalaryTypeEntity), isCopy);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at SaveOrUpdateMSalaryTypeEntity", ex);
                Logger.Error("Error in SaveOrUpdateMSalaryTypeEntity: Message - " + ex.Message + " StackTrace - " + ex.StackTrace);
                throw;
            }
        }


        public List<BuyerInfoEntity> GetListBuyerInfoEntities()
        {
            throw new NotImplementedException();
        }
        public MUnitsTypeEntity GetMUnitsTypeEntity(string unitTypeId)
        {
            return rmisGateway.GetMUnitsTypeEntity(unitTypeId);
        }
        public List<PaddyStockInfoEntity> GetPaddyStockInfoEntity(string CustId, int pageindex, int pageSize, out int count, SortExpression expression)
        {
            return rmisGateway.GetPaddyStockInfoEntity(CustId, pageindex, pageSize, out  count, expression);
        }
        public List<MEmployeeDesignationEntity> GetListMEmployeeDesignationEntities(string CustId)
        {
            return rmisGateway.GetMEmployeeDesignationEntities(CustId);
        }
        public List<MSalaryTypeEntity> GetListMSalaryTypeEntities(string CustId)
        {
            return rmisGateway.GetMSalaryTypeEntities(CustId);
        }

        public List<MPaddyTypeEntity> CheckPaddyTypeExist(string CustId, string PaddyType)
        {
            return rmisGateway.CheckPaddyTypeExist(CustId, PaddyType);
        }
        public MUnitsTypeEntity CheckUnitTypeExist(string CustId, string UnitType)
        {
            return rmisGateway.CheckUnitTypeExist(CustId, UnitType);
        }
        public MGodownDetailsEntity CheckGodownNameExist(string CustId, string GodownName)
        {
            return rmisGateway.CheckGodownNameExist(CustId, GodownName);
        }
        public MLotDetailsEntity CheckLotNameExist(string CustId, string LotName)
        {
            return rmisGateway.CheckLotNameExist(CustId, LotName);
        }
        public MEmployeeDesignationEntity CheckEmpDesigExist(string CustId, string DesignationType)
        {
            return rmisGateway.CheckEmpDesigExist(CustId, DesignationType);
        }
        public MSalaryTypeEntity CheckSalaryTypeExist(string CustId, string SalartyType)
        {
            return rmisGateway.CheckSalaryTypeExist(CustId, SalartyType);
        }
    }
}
