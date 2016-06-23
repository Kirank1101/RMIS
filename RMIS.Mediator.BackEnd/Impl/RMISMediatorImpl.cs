
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
    using RMIS.Domain;

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



        /// <summary>
        /// Saves the or update audit entity.
        /// </summary>
        /// <param name="auditEntity">The audit entity.</param>
        /// <param name="isCopy">if set to <c>true</c> [is copy].</param>


        #region Save or Update Entity
        /// <summary>
        /// Saves the or update audit entity.
        /// </summary>
        /// <param name="auditEntity">The audit entity.</param>
        /// <param name="isCopy">if set to <c>true</c> [is copy].</param>


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
        public void SaveOrUpdateEmployeeDetailsEntity(EmployeeDetailsEntity EmployeeDetailsEntity, bool isCopy)
        {
            try
            {
                genericGateway.SaveOrUpdateEntity<EmployeeDetails>(mapper.GetEmployeeDetails(EmployeeDetailsEntity), isCopy);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at SaveOrUpdateEmployeeDetailsEntity", ex);
                Logger.Error("Error in SaveOrUpdateEmployeeDetailsEntity: Message - " + ex.Message + " StackTrace - " + ex.StackTrace);
                throw;
            }
        }
        public void SaveOrUpdateEmployeeSalaryEntity(EmployeeSalaryEntity EmployeeSalaryEntity, bool isCopy)
        {
            try
            {
                genericGateway.SaveOrUpdateEntity<EmployeeSalary>(mapper.GetEmployeeSalary(EmployeeSalaryEntity), isCopy);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at SaveOrUpdateEmployeeSalaryEntity", ex);
                Logger.Error("Error in SaveOrUpdateEmployeeSalaryEntity: Message - " + ex.Message + " StackTrace - " + ex.StackTrace);
                throw;
            }
        }
        public void SaveOrUpdateEmployeeSalaryPaymentEntity(EmployeeSalaryPaymentEntity EmployeeSalaryPaymentEntity, bool isCopy)
        {
            try
            {
                genericGateway.SaveOrUpdateEntity<MoneyTransaction>(mapper.GetEmployeeSalaryPayment(EmployeeSalaryPaymentEntity), isCopy);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at SaveOrUpdateEmployeeSalaryPaymentEntity", ex);
                Logger.Error("Error in SaveOrUpdateEmployeeSalaryPaymentEntity: Message - " + ex.Message + " StackTrace - " + ex.StackTrace);
                throw;
            }
        }
        public void SaveOrUpdateOtherExpensesEntity(OtherExpensesEntity OtherExpensesEntityEntity, bool isCopy)
        {
            try
            {
                genericGateway.SaveOrUpdateEntity<MoneyTransaction>(mapper.GetOtherExpenses(OtherExpensesEntityEntity), isCopy);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at SaveOrUpdateOtherExpensesEntity", ex);
                Logger.Error("Error in SaveOrUpdateOtherExpensesEntity: Message - " + ex.Message + " StackTrace - " + ex.StackTrace);
                throw;
            }
        }
        public void SaveOrUpdateProductPaymentInfoEntity(ProductPaymentInfoEntity ProductPaymentInfoEntity, bool isCopy)
        {
            try
            {
                genericGateway.SaveOrUpdateEntity<ProductPaymentInfo>(mapper.GetProductPaymentInfo(ProductPaymentInfoEntity), isCopy);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at SaveOrUpdateProductPaymentInfoEntity", ex);
                Logger.Error("Error in SaveOrUpdateProductPaymentInfoEntity: Message - " + ex.Message + " StackTrace - " + ex.StackTrace);
                throw;
            }
        }

        public void SaveOrUpdateProductPaymentTransEntity(ProductPaymentTransactionEntity ProductPaymentTranEntity, bool isCopy)
        {
            try
            {
                genericGateway.SaveOrUpdateEntity<ProductPaymentTransaction>(mapper.GetProductPaymentTransaction(ProductPaymentTranEntity), isCopy);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at SaveOrUpdateProductPaymentTransEntity", ex);
                Logger.Error("Error in SaveOrUpdateProductPaymentTransEntity: Message - " + ex.Message + " StackTrace - " + ex.StackTrace);
                throw;
            }
        }
        #endregion
        #region Get Enitity
        public MDrierTypeDetailsEntity GetMDrierTypeDetailsEntity(string MDrierTypeID, YesNo yesNo)
        {

            return rmisGateway.GetMDrierTypeDetailsEntity(MDrierTypeID, yesNo);
        }
        public MRiceProductionTypeEntity GetMRiceProductionTypeEntity(string MRiceProdTypeID, YesNo yesNo)
        {

            return rmisGateway.GetMRiceProductionTypeEntity(MRiceProdTypeID, yesNo);
        }
        public MGodownDetailsEntity GetMGodownDetailsEntity(string MGodownID, YesNo yesNo)
        {

            return rmisGateway.GetMGodownDetailsEntity(MGodownID, yesNo);
        }
        public PaddyPaymentDetailsEntity GetPaddyPaymentDetailsEntity(string PaddyPaymentID, YesNo yesNo)
        {

            return rmisGateway.GetPaddyPaymentDetailsEntity(PaddyPaymentID, yesNo);
        }
        public CustomerAddressInfoEntity GetCustomerAddressInfoEntity(string CustAdrsID, YesNo yesNo)
        {

            return rmisGateway.GetCustomerAddressInfoEntity(CustAdrsID, yesNo);
        }
        public CustomerActivationEntity GetCustomerActivationEntity(string CustActiveID, YesNo yesNo)
        {

            return rmisGateway.GetCustomerActivationEntity(CustActiveID, yesNo);
        }
        public CustTrailUsageEntity GetCustTrailUsageEntity(string CustTrailID, YesNo yesNo)
        {

            return rmisGateway.GetCustTrailUsageEntity(CustTrailID, yesNo);
        }
        public CustomerPaymentEntity GetCustomerPaymentEntity(string CustPaymentID, YesNo yesNo)
        {

            return rmisGateway.GetCustomerPaymentEntity(CustPaymentID, yesNo);
        }
        public CustomerPartPayDetailsEntity GetCustomerPartPayDetailsEntity(string CustPartPayID, YesNo yesNo)
        {

            return rmisGateway.GetCustomerPartPayDetailsEntity(CustPartPayID, yesNo);
        }
        public SellerInfoEntity GetSellerInfoEntity(string CustId, string SellerID, YesNo yesNo)
        {

            return rmisGateway.GetSellerInfoEntity(CustId, SellerID, yesNo);
        }
        public CustomerInfoEntity GetCustomerInfoEntity(string CustID, YesNo yesNo)
        {

            return rmisGateway.GetCustomerInfoEntity(CustID, yesNo);
        }
        public MUserTypeEntity GetMUserTypeEntity(string UserTypeID, YesNo yesNo)
        {

            return rmisGateway.GetMUserTypeEntity(UserTypeID, yesNo);
        }
        public UsersEntity GetUsersEntity(string UserID, YesNo yesNo)
        {

            return rmisGateway.GetUsersEntity(UserID, yesNo);
        }
        public MPaddyTypeEntity GetMPaddyTypeEntity(string PaddyTypeID, YesNo yesNo)
        {

            return rmisGateway.GetMPaddyTypeEntity(PaddyTypeID, yesNo);

        }
        public PaddyStockInfoEntity GetPaddyStockInfoEntity(string PaddyStockID, YesNo yesNo)
        {

            return rmisGateway.GetPaddyStockInfoEntity(PaddyStockID, yesNo);
        }
        public MLotDetailsEntity GetMLotDetailsEntity(string MLotID, YesNo yesNo)
        {

            return rmisGateway.GetMLotDetailsEntity(MLotID, yesNo);
        }
        public MRiceBrandDetailsEntity GetMRiceBrandDetailsEntity(string MRiceBrandID, YesNo yesNo)
        {
            return rmisGateway.GetMRiceBrandDetailsEntity(MRiceBrandID, yesNo);
        }
        public List<MUserTypeEntity> GetMUserTypeEntities(string CustId, YesNo yesNo)
        {
            return rmisGateway.GetMUserTypeEntities(CustId, yesNo);
        }
        public List<MPaddyTypeEntity> GetMPaddyTypeEntitiies(string CustId, YesNo yesNo)
        {
            return rmisGateway.GetMPaddyTypeEntities(CustId, yesNo);
        }
        public List<MPaddyTypeEntity> GetMPaddyTypeEntities(string CustId, int pageindex, int pageSize, out int count, SortExpression expression, YesNo yesNo)
        {
            return rmisGateway.GetMPaddyTypeEntities(CustId, pageindex, pageSize, out count, expression, yesNo);
        }
        public List<PaddyStockInfoEntity> GetPaddyStockInfoEntities(string CustId, YesNo yesNo)
        {
            return rmisGateway.GetPaddyStockInfoEntities(CustId, yesNo);
        }
        public List<MLotDetailsEntity> GetMLotDetailsEntities(string CustId, string MGodownID, YesNo yesNo)
        {
            return rmisGateway.GetMLotDetailsEntities(CustId, MGodownID, yesNo);
        }
        public List<MGodownDetailsEntity> GetMGodownDetailsEntities(string CustId, YesNo yesNo)
        {
            return rmisGateway.GetAllMGodownDetailsEntity(CustId, yesNo);
        }
        public List<MRiceProductionTypeEntity> GetMRiceProductionTypeEntities(string CustId, YesNo yesNo)
        {
            return rmisGateway.GetMRiceProductionTypeEntities(CustId, yesNo);
        }
        public List<MRiceBrandDetailsEntity> GetMRiceBrandDetailsEntities(string CustId, YesNo yesNo)
        {
            return rmisGateway.GetMRiceBrandDetailsEntities(CustId, yesNo);
        }
        public List<MLotDetailsEntity> GetMLotDetailsEntities(string CustId, YesNo yesNo)
        {
            return rmisGateway.GetMLotDetailsEntities(CustId, yesNo);
        }
        public List<SellerInfoEntity> GetSellerInfoEntities(string CustId, YesNo yesNo)
        {
            return rmisGateway.GetSellerInfoEntities(CustId, yesNo);
        }
        public List<SellerInfoEntity> GetListSellerInfoEntities(string CustId, YesNo yesNo)
        {
            return rmisGateway.GetSellerInfoEntities(CustId, yesNo);
        }
        public List<MBagTypeEntity> GetMBagTypeEntities(string CustId, YesNo yesNo)
        {
            return rmisGateway.GetMBagTypeEntities(CustId, yesNo);
        }
        public BagStockInfoEntity GetBagStockInfoEntity(string BagStockID, YesNo yesNo)
        {
            return rmisGateway.GetBagStockInfoEntity(BagStockID, yesNo);
        }
        public List<BagStockInfoEntity> GetBagStockInfoEntities(string CustId, YesNo yesNo)
        {
            return rmisGateway.GetBagStockInfoEntities(CustId, yesNo);
        }
        public List<MUnitsTypeEntity> GetMUnitsTypeEntities(string CustId, YesNo yesNo)
        {
            return rmisGateway.GetMUnitsTypeEntities(CustId, yesNo);
        }
        public List<MBrokenRiceTypeEntity> GetMBrokenRiceTypeEntitiies(string CustId, YesNo yesNo)
        {
            return rmisGateway.GetMBrokenRiceTypeEntities(CustId, yesNo);

        }
        public List<RiceStockInfoEntity> GetAllRiceStockInfoEntities(string CustId, YesNo yesNo)
        {
            return rmisGateway.GetAllRiceStockInfoEntities(CustId, yesNo);
        }
        public List<BrokenRiceStockInfoEntity> GetAllBrokenRiceStockInfoEntities(string CustId, YesNo yesNo)
        {
            return rmisGateway.GetAllBrokenRiceStockInfoEntities(CustId, yesNo);
        }
        public List<DustStockInfoEntity> GetAllDustStockInfoEntities(string CustId, YesNo yesNo)
        {
            return rmisGateway.GetAllDustStockInfoEntities(CustId, yesNo);
        }

        public List<MenuInfoEntity> GetAllMenuInfoEntities(YesNo yesNo)
        {
            return rmisGateway.GetMenuInfoEntities(yesNo);
        }
        public List<CustomerInfoEntity> GetCustomerInfoEntities(YesNo yesNo)
        {
            return rmisGateway.GetCustomerInfoEntities(yesNo);
        }
        public List<MenuConfigurationEntity> GetMenuConfigurationEntities(string CustId, YesNo yesNo)
        {
            return rmisGateway.GetMenuConfigurationEntities(CustId, yesNo);
        }
        public List<ProductSellingInfoEntity> GetAllproductSellingInfoEntities(string CustId, YesNo yesNo)
        {
            return rmisGateway.GetAllProductSellingInfoEntities(CustId, yesNo);
        }
        public List<HullingProcessEntity> GetAllHullingProcessInfoEntity(string CustId, YesNo yesNo)
        {
            return rmisGateway.GetHullingProcessInfoEntities(CustId, yesNo);
        }
        public List<HullingProcessTransactionEntity> GetAllHullingProcessTransInfoEntity(string CustId, YesNo yesNo)
        {
            return rmisGateway.GetHullingProcessTransInfoEntities(CustId, yesNo);
        }
        public List<MRolesEntity> GetAllRolesEntity(YesNo yesNo)
        {
            return rmisGateway.GetRoleEntities(yesNo);
        }
        public UsersEntity GetUsersEntity(string userName, string custId, YesNo yesNo)
        {
            return rmisGateway.GetUsersEntity(userName, custId, yesNo);
        }
        public List<RMUserRoleEntity> GetUserRoleEntities(string userId, YesNo yesNo)
        {
            return rmisGateway.GetUserRoles(userId, yesNo);
        }
        public List<HullingProcessExpensesEntity> GetAllHullingProcessExpensesEntity(string CustId, YesNo yesNo)
        {
            return rmisGateway.GetHullingProcessExpensesEntities(CustId, yesNo);
        }
        public List<BuyerSellerRatingEntity> GetAllBuyerSellerRatingEntities(string CustId, YesNo yesNo)
        {
            return rmisGateway.GetAllBuyerSellerRatingEntities(CustId, yesNo);
        }
        public List<BuyerInfoEntity> GetListBuyerInfoEntities(String CustId, YesNo yesNo)
        {
            return rmisGateway.GetListBuyerInfoEntities(CustId, yesNo);
        }

        public List<PaddyStockInfoEntity> GetPaddyStockInfoEntity(string CustId, int pageindex, int pageSize, out int count, SortExpression expression, YesNo yesNo)
        {
            return rmisGateway.GetPaddyStockInfoEntity(CustId, pageindex, pageSize, out  count, expression, yesNo);
        }
        public List<MEmployeeDesignationEntity> GetListMEmployeeDesignationEntities(string CustId, YesNo yesNo)
        {
            return rmisGateway.GetMEmployeeDesignationEntities(CustId, yesNo);
        }
        public List<MSalaryTypeEntity> GetListMSalaryTypeEntities(string CustId, YesNo yesNo)
        {
            return rmisGateway.GetMSalaryTypeEntities(CustId, yesNo);
        }
        public List<EmployeeDetailsEntity> GetListEmployeeDetailsEntities(string CustId, YesNo yesNo)
        {
            return rmisGateway.GetEmployeeDetailsEntities(CustId, yesNo);
        }
        public List<EmployeeSalaryEntity> GetAllEmployeeSalaryEntities(string CustId, YesNo yesNo)
        {
            return rmisGateway.GetEmployeeSalaryEntities(CustId, yesNo);
        }
        public EmployeeDetailsEntity GetEmployeeDetailsEntity(String CustId, string EmployeeID, YesNo yesNo)
        {
            return rmisGateway.GetEmployeeDetailsEntity(CustId, EmployeeID, yesNo);
        }
        public MEmployeeDesignationEntity GetMEmployeeDesignationEntity(string CustID, string DesignationID, YesNo yesNo)
        {
            return rmisGateway.GetMEmployeeDesignationEntity(CustID, DesignationID, yesNo);
        }
        public MSalaryTypeEntity GetListMSalaryTypeEntity(string custId, string SalaryTypeId, YesNo yesNo)
        {
            return rmisGateway.GetListMSalaryTypeEntity(custId, SalaryTypeId, yesNo);
        }

        public EmployeeSalaryEntity GetEmployeeSalaryEntity(string CustID, string EmployeeID, YesNo yesNo)
        {
            return rmisGateway.GetEmployeeSalaryEntity(CustID, EmployeeID, yesNo);
        }
        public List<EmployeeSalaryPaymentEntity> GetAllEmployeeSalaryPaymentEntities(string CustId, YesNo yesNo)
        {
            return rmisGateway.GetEmployeeSalaryPaymentEntities(CustId, yesNo);
        }
        public List<EmployeeSalaryPaymentEntity> GetSalaryPaymentOnEmployee(string CustId, string EmployeeID, YesNo yesNo)
        {
            return rmisGateway.GetSalaryPaymentOnEmployee(CustId, EmployeeID, yesNo);
        }
        public List<OtherExpensesEntity> GetAllOtherExpensesEntities(string CustId, YesNo yesNo)
        {
            return rmisGateway.GetOtherExpensesEntities(CustId, yesNo);
        }
        #endregion
        #region Check Enitity
        public List<MPaddyTypeEntity> CheckPaddyTypeExist(string CustId, string PaddyType, YesNo yesNo)
        {
            return rmisGateway.CheckPaddyTypeExist(CustId, PaddyType, yesNo);
        }
        public MUnitsTypeEntity CheckUnitTypeExist(string CustId, string UnitType, YesNo yesNo)
        {
            return rmisGateway.CheckUnitTypeExist(CustId, UnitType, yesNo);
        }
        public MGodownDetailsEntity CheckGodownNameExist(string CustId, string GodownName, YesNo yesNo)
        {
            return rmisGateway.CheckGodownNameExist(CustId, GodownName, yesNo);
        }
        public MLotDetailsEntity CheckLotNameExist(string CustId, string LotName, YesNo yesNo)
        {
            return rmisGateway.CheckLotNameExist(CustId, LotName, yesNo);
        }
        public MEmployeeDesignationEntity CheckEmpDesigExist(string CustId, string DesignationType, YesNo yesNo)
        {
            return rmisGateway.CheckEmpDesigExist(CustId, DesignationType, yesNo);
        }
        public MSalaryTypeEntity CheckSalaryTypeExist(string CustId, string SalaryType, YesNo yesNo)
        {
            return rmisGateway.CheckSalaryTypeExist(CustId, SalaryType, yesNo);
        }
        public EmployeeDetailsEntity CheckEmployeeExist(string CustId, string EmployeeName, YesNo yesNo)
        {
            return rmisGateway.CheckEmployeeExist(CustId, EmployeeName, yesNo);
        }
        public EmployeeSalaryEntity CheckEmployeeSalaryExist(string CustId, string EmployeeID, YesNo yesNo)
        {
            return rmisGateway.CheckEmployeeSalaryExist(CustId, EmployeeID, yesNo);
        }
        #endregion

        public List<BuyerInfoEntity> GetListBuyerInfoEntities(YesNo yesNo)
        {
            throw new NotImplementedException();
        }
        public MUnitsTypeEntity GetMUnitsTypeEntity(string unitTypeId, YesNo yesNo)
        {
            return rmisGateway.GetMUnitsTypeEntity(unitTypeId);
        }
        public MUnitsTypeEntity GetMUnitsTypeEntity(string unitTypeId)
        {
            return rmisGateway.GetMUnitsTypeEntity(unitTypeId);
        }
        public List<SellerInfoEntity> GetSellerInfoEntities(string custId, YesNo yesNo, int count, string prefixText)
        {
            return rmisGateway.GetSellerInfoEntities(custId, yesNo, count, prefixText);
        }
        public List<EmployeeDetailsEntity> GetEmployeeDetailsEntities(string custId, YesNo yesNo, int count, string prefixText)
        {
            return rmisGateway.GetEmployeeDetailsEntities(custId, yesNo, count, prefixText);
        }
        public List<BuyerInfoEntity> GetBuyerInfoEntities(string custId, YesNo yesNo, int count, string prefixText)
        {
            return rmisGateway.GetBuyerInfoEntities(custId, yesNo, count, prefixText);
        }
        public int GetMPaddyTypeEntitiesTotal(string CustId, YesNo yesNo)
        {
            return rmisGateway.GetPaddyStockEntityTotal(CustId, yesNo);
        }
        public int GetBrokenRiceStockInfoCount(string CustId, YesNo yesNo)
        {
            //return rmisGateway.GetBrokenRiceStockInfoCount(CustId, yesNo);
            return 0;
        }
        public int GetMRiceProductionTypeCount(string CustId, YesNo yesNo)
        {
            return rmisGateway.GetMRiceProductionTypeCount(CustId, yesNo);
        }
        public int GetPaddyStockUsedTotal(string CustId, YesNo yesNo)
        {
            return rmisGateway.GetPaddyStockUsedTotal(CustId, yesNo);
        }
        public List<ProductPaymentInfoEntity> GetAllProductPaymentInfoEntities(string CustId, YesNo yesNo)
        {
            return rmisGateway.GetAllProductPaymentInfoEntities(CustId, yesNo);
        }
        public List<ProductPaymentTransactionEntity> GetAllProductPaymentTranEntities(string CustId, YesNo yesNo)
        {
            return rmisGateway.GetAllProductPaymentTranEntities(CustId, yesNo);
        }
        public int GetMPaddyTypeEntitiesTotal(string CustId, string UnitsTypeID, string PaddyTypeId, YesNo yesNo)
        {
            return rmisGateway.GetPaddyStockEntityTotal(CustId, UnitsTypeID, PaddyTypeId, yesNo);
        }

        public int GetPaddyStockUsedTotal(string CustId, string UnitsTypeID, string PaddyTypeId, YesNo yesNo)
        {
            return rmisGateway.GetPaddyStockUsedTotal(CustId, UnitsTypeID, PaddyTypeId, yesNo);
        }


        public int GetPaddyStockEntityCount(string CustId, YesNo yesNo)
        {
            return rmisGateway.GetPaddyStockEntityCount(CustId, yesNo);
        }

        public int GetPaddyStockUsedCount(string CustId, YesNo yesNo)
        {
            return rmisGateway.GetPaddyStockUsedCount(CustId, yesNo);
        }


        public int GetRiceProductTotal(string CustId, YesNo yesNo)
        {
            return rmisGateway.GetRiceProductTotal(CustId, yesNo);
        }

        public int GetRiceProductUsedTotal(string CustId, YesNo yesNo)
        {
            return rmisGateway.GetRiceProductUsedTotal(CustId, yesNo);
        }

        public int GetBrokenRiceProductTotal(string CustId, YesNo yesNo)
        {
            return rmisGateway.GetBrokenRiceProductTotal(CustId, yesNo);
        }

        public int GetBrokenRiceProductUsedTotal(string CustId, YesNo yesNo)
        {
            return rmisGateway.GetBrokenRiceProductUsedTotal(CustId, yesNo);
        }


        public int GetRiceProductTotal(string CustId, string UnitsTypeID, string RiceProdTypeID, string RiceBrandId, YesNo yesNo)
        {
            return rmisGateway.GetRiceProductTotal(CustId, UnitsTypeID, RiceProdTypeID, RiceBrandId, yesNo);
        }

        public int GetRiceProductUsedTotal(string CustId, string UnitsTypeID, string RiceProdTypeID, string RiceBrandId, YesNo yesNo)
        {
            return rmisGateway.GetRiceProductUsedTotal(CustId, UnitsTypeID, RiceProdTypeID, RiceBrandId, yesNo);
        }


        public int GetBrokenRiceProductTotal(string CustId, string UnitsTypeID, string BrokenRiceTypeID, YesNo yesNo)
        {
            return rmisGateway.GetBrokenRiceProductTotal(CustId, UnitsTypeID, BrokenRiceTypeID, yesNo);
        }

        public int GetBrokenRiceProductUsedTotal(string CustId, string UnitsTypeID, string BrokenRiceTypeID, YesNo yesNo)
        {
            return rmisGateway.GetBrokenRiceProductUsedTotal(CustId, UnitsTypeID, BrokenRiceTypeID, yesNo);
        }

        public double GetPaddyTotalAmount(string CustId, YesNo yesNo)
        {
            return rmisGateway.GetPaddyTotalAmount(CustId, yesNo);
        }

        public double GetPaddyTotalAmountPaid(string CustId, YesNo yesNo)
        {
            return rmisGateway.GetPaddyTotalAmountPaid(CustId, yesNo);
        }

        public double GetPaddyTotalAmount(string CustId, string SellerId, YesNo yesNo)
        {
            return rmisGateway.GetPaddyTotalAmount(CustId, SellerId, yesNo);
        }

        public double GetPaddyTotalAmountPaid(string CustId, string SellerId, YesNo yesNo)
        {
            return rmisGateway.GetPaddyTotalAmountPaid(CustId, SellerId, yesNo);
        }


        public List<PaddyStockInfoEntity> GetAllPaddyStockInfoEntities(string CustId, string PaddyTypeID, string UnitTypeID, string GodownID, string LotID, YesNo yesNo)
        {
            return rmisGateway.GetAllPaddyStockInfoEntities(CustId, PaddyTypeID, UnitTypeID, GodownID, LotID, yesNo);
        }


        public List<HullingProcessEntity> GetAllHullingProcessPaddyStock(string CustId, string PaddyTypeID, string UnitTypeID, string GodownID, string LotID, YesNo yesNo)
        {
            return rmisGateway.GetAllHullingProcessPaddyStock(CustId, PaddyTypeID, UnitTypeID, GodownID, LotID, yesNo);
        }


        public HullingProcessEntity GetHullingProcessEnitity(string CustId, string HullingProcessID, YesNo yesNo)
        {
            return rmisGateway.GetHullingProcessEntity(CustId, HullingProcessID, yesNo);
        }


        public List<MUnitsTypeEntity> GetMUnitsTypeEntities(string CustId, int pageindex, int pageSize, out int count, SortExpression expression, YesNo yesNo)
        {
            return rmisGateway.GetMUnitsTypeEntities(CustId, pageindex, pageSize, out count, expression, yesNo);
        }


        public List<MGodownDetailsEntity> GetMGodownDetailsEntities(string CustId, int PageIndex, int PageSize, out int count, SortExpression expression, YesNo yesNo)
        {
            return rmisGateway.GetMGodownDetailsEntities(CustId, PageIndex, PageSize, out count, expression, yesNo);
        }


        public List<MLotDetailsEntity> GetMLotDetailsEntities(string CustId, string GodownID, int PageIndex, int PageSize, out int count, SortExpression expression, YesNo yesNo)
        {
            return rmisGateway.GetMLotDetailsEntities(CustId, GodownID, PageIndex, PageSize, out count, expression, yesNo);
        }


        public MBagTypeEntity GetMBagTypeEntity(string BagTypeID, YesNo yesNo)
        {
            return rmisGateway.GetMBagTypeEntity(BagTypeID, yesNo);
        }
        public List<MBagTypeEntity> GetMBagTypeEntities(string CustId, int PageIndex, int PageSize, out int count, SortExpression expression, YesNo yesNo)
        {
            return rmisGateway.GetMBagTypeEntities(CustId, PageIndex, PageSize, out count, expression, yesNo);
        }
        public List<MRiceProductionTypeEntity> GetMRiceProductionTypeEntities(string CustId, int PageIndex, int PageSize, out int count, SortExpression expression, YesNo yesNo)
        {
            return rmisGateway.GetMRiceProductionTypeEntities(CustId, PageIndex, PageSize, out count, expression, yesNo);
        }
        public MBrokenRiceTypeEntity GetMBrokenRiceTypeEntity(string BrokenRiceTypeID, YesNo yesNo)
        {
            return rmisGateway.GetMBrokenRiceTypeEntity(BrokenRiceTypeID, yesNo);
        }
        public List<MBrokenRiceTypeEntity> GetMBrokenRiceTypeEntitiies(string CustId, int PageIndex, int PageSize, out int count, SortExpression expression, YesNo yesNo)
        {
            return rmisGateway.GetMBrokenRiceTypeEntities(CustId, PageIndex, PageSize, out count, expression, yesNo);
        }
        public List<MRiceBrandDetailsEntity> GetMRiceBrandDetailsEntities(string CustId, int PageIndex, int PageSize, out int count, SortExpression expression, YesNo yesNo)
        {
            return rmisGateway.GetMRiceBrandDetailsEntities(CustId, PageIndex, PageSize, out count, expression, yesNo);
        }


        public MEmployeeDesignationEntity GetMEmployeeDesignationEntity(string EmpDesigID, YesNo yesNo)
        {
            return rmisGateway.GetMEmployeeDesignationEntity(EmpDesigID, yesNo);
        }

        public List<MEmployeeDesignationEntity> GetMEmployeeDesignationEntities(string CustId, int PageIndex, int PageSize, out int count, SortExpression expression, YesNo yesNo)
        {
            return rmisGateway.GetMEmployeeDesignationEntities(CustId, PageIndex, PageSize, out count, expression, yesNo);
        }


        public MSalaryTypeEntity GetMSalaryTypeEntity(string SalaryTypeID, YesNo yesNo)
        {
            return rmisGateway.GetMSalaryTypeEntity(SalaryTypeID, yesNo);
        }

        public List<MSalaryTypeEntity> GetListMSalaryTypeEntities(string CustId, int PageIndex, int PageSize, out int count, SortExpression expression, YesNo yesNo)
        {
            return rmisGateway.GetListMSalaryTypeEntities(CustId, PageIndex, PageSize, out count, expression, yesNo);
        }
        public MBagTypeEntity GetMBagTypeEntity(string CustId, string BagType, YesNo yesNo)
        {
            return rmisGateway.GetMBagTypeEntity(CustId, BagType, yesNo);
        }
        public MRiceProductionTypeEntity GetMRiceProductionTypeEntity(string CustId, string RiceType, YesNo yesNo)
        {
            return rmisGateway.GetMRiceProductionTypeEntity(CustId, RiceType, yesNo);
        }
        public MBrokenRiceTypeEntity GetMBrokenRiceTypeEntity(string CustId, string BrokenRiceType, YesNo yesNo)
        {
            return rmisGateway.GetMBrokenRiceTypeEntity(CustId, BrokenRiceType, yesNo);
        }
        public MRiceBrandDetailsEntity GetMRiceBrandDetailsEntity(string CustId, string RiceBrand, YesNo yesNo)
        {
            return rmisGateway.GetMRiceBrandDetailsEntity(CustId, RiceBrand, yesNo);
        }


        public List<BagStockInfoEntity> GetBagStockInfoEntity(string CustId, int pageindex, int pageSize, out int count, SortExpression expression, YesNo yesNo)
        {
            return rmisGateway.GetBagStockInfoEntity(CustId, pageindex, pageSize, out  count, expression, yesNo);
        }


        public int GetBagStockTotal(string CustId, YesNo yesNo)
        {
            return rmisGateway.GetBagStockTotal(CustId, yesNo);
        }

        public int GetBagStockTotalUsed(string CustId, YesNo yesNo)
        {
            return rmisGateway.GetBagStockTotalUsed(CustId, yesNo);
        }

        public int GetBagStockTotal(string CustId, string UnitsTypeID, string RiceBrandId, YesNo yesNo)
        {
            return rmisGateway.GetBagStockTotal(CustId, UnitsTypeID, RiceBrandId, yesNo);
        }

        public int GetBagStockTotalUsed(string CustId, string UnitsTypeID, string RiceBrandId, YesNo yesNo)
        {
            return rmisGateway.GetBagStockTotalUsed(CustId, UnitsTypeID, RiceBrandId, yesNo);
        }


        public double GetProductTotalAmount(string CustId, YesNo yesNo)
        {
            return rmisGateway.GetProductTotalAmount(CustId, yesNo);
        }

        public double GetProductTotalAmountPaid(string CustId, YesNo yesNo)
        {
            return rmisGateway.GetProductTotalAmountPaid(CustId, yesNo);
        }

        public double GetProductTotalAmount(string CustId, string BuyerID, YesNo yesNo)
        {
            return rmisGateway.GetProductTotalAmount(CustId, BuyerID, yesNo);
        }

        public double GetProductTotalAmountPaid(string CustId, string BuyerID, YesNo yesNo)
        {
            return rmisGateway.GetProductTotalAmountPaid(CustId, BuyerID, yesNo);
        }

        public List<BuyerInfoEntity> GetBuyerInfoEntities(string custId, YesNo yesNo)
        {
            return rmisGateway.GetBuyerInfoEntities(custId, yesNo);
        }


        public List<RiceStockInfoEntity> GetAllRiceStockInfoEntities(string CustId, string RiceTypeID, string RiceBrandID, string UnitTypeID, YesNo yesNo)
        {
            return rmisGateway.GetAllRiceStockInfoEntities(CustId, RiceTypeID, RiceBrandID, UnitTypeID, yesNo);
        }


        public List<ProductSellingInfoEntity> GetAllproductSellingInfoEntities(string CustId, string RiceTypeID, string RiceBrandID, string UnitTypeID, YesNo yesNo)
        {
            return rmisGateway.GetAllProductSellingInfoEntities(CustId, RiceTypeID, RiceBrandID, UnitTypeID, yesNo);
        }


        public List<BrokenRiceStockInfoEntity> GetAllBrokenRiceStockInfoEntities(string CustId, string BrokenRiceTypeID, string UnitTypeID, YesNo yesNo)
        {
            return rmisGateway.GetAllBrokenRiceStockInfoEntities(CustId, BrokenRiceTypeID, UnitTypeID, yesNo);
        }

        public List<ProductSellingInfoEntity> GetAllproductSellingInfoEntities(string CustId, string BrokenRiceTypeID, string UnitTypeID, YesNo yesNo)
        {
            return rmisGateway.GetAllProductSellingInfoEntities(CustId, BrokenRiceTypeID, UnitTypeID, yesNo);
        }


        public List<DustStockInfoEntity> GetAllDustStockInfoEntities(string CustId, string UnitTypeID, YesNo yesNo)
        {
            return rmisGateway.GetAllDustStockInfoEntities(CustId, UnitTypeID, yesNo);
        }

        public List<ProductSellingInfoEntity> GetAllproductSellingInfoEntities(string CustId, string UnitTypeID, YesNo yesNo)
        {
            return rmisGateway.GetAllProductSellingInfoEntities(CustId, UnitTypeID, yesNo);
        }


        public List<ProductSellingInfoEntity> GetAllBuyerproductSellingInfoEntities(string CustId, string BuyerID, YesNo yesNo)
        {
            return rmisGateway.GetAllBuyerproductSellingInfoEntities(CustId, BuyerID, yesNo);
        }


        public List<ProductPaymentInfoEntity> GetAllProductPaymentInfoEntities(string CustId, string BuyerID, YesNo yesNo)
        {
            return rmisGateway.GetAllProductPaymentInfoEntities(CustId, BuyerID, yesNo);
        }


        public BuyerInfoEntity GetBuyerInfoEntity(string CustId, string BuyerID, YesNo yesNo)
        {
            return rmisGateway.GetBuyerInfoEntity(CustId, BuyerID, yesNo);
        }


        public ProductPaymentInfoEntity GetProductPaymentInfoEntity(string CustId, string ProductPaymentID, YesNo yesNo)
        {
            return rmisGateway.GetProductPaymentInfoEntity(CustId, ProductPaymentID, yesNo);
        }


        public List<ProductPaymentTransactionEntity> GetAllProductPaymentTranEntities(string CustId, string ProductPaymentID, YesNo yesNo)
        {
            return rmisGateway.GetAllProductPaymentTranEntities(CustId, ProductPaymentID, yesNo);
        }


        public List<SellerInfoEntity> GetListSellerInfoEntities(string CustId, int PageIndex, int PageSize, out int count, SortExpression expression, YesNo yesNo)
        {
            return rmisGateway.GetListSellerInfoEntities(CustId, PageIndex, PageSize, out  count, expression, yesNo);
        }

        public SellerInfoEntity CheckSellerNameExist(string CustId, string SellerName, YesNo yesNo)
        {
            return rmisGateway.CheckSellerNameExist(CustId, SellerName, yesNo);
        }


        public BuyerInfoEntity CheckBuyerNameExist(string CustId, string BuyerName, YesNo yesNo)
        {
            return rmisGateway.CheckBuyerNameExist(CustId, BuyerName, yesNo);
        }

        public List<BuyerInfoEntity> GetListBuyerInfoEntities(string CustId, int PageIndex, int PageSize, out int count, SortExpression expression, YesNo yesNo)
        {
            return rmisGateway.GetListBuyerInfoEntities(CustId, PageIndex, PageSize, out  count, expression, yesNo);
        }


        public SellerInfoEntity CheckISValidSeller(string CustId, string SellerID, string SellerName, YesNo yesNo)
        {
            return rmisGateway.CheckISValidSeller(CustId, SellerID, SellerName, yesNo);
        }


        public double GetBagTotalAmount(string CustId, string SellerID, YesNo yesNo)
        {
            return rmisGateway.GetBagTotalAmount(CustId, SellerID, yesNo);
        }

        public double GetBagTotalAmountPaid(string CustId, string SellerID, YesNo yesNo)
        {
            return rmisGateway.GetBagTotalAmountPaid(CustId, SellerID, yesNo);
        }


        public void SaveOrUpdateBagPaymentEntity(BagPaymentInfoEntity bagPaymentDetailsEntity, bool isCopy)
        {
            try
            {

                genericGateway.SaveOrUpdateEntity<BagPaymentInfo>(mapper.GetBagPaymentDetails(bagPaymentDetailsEntity), isCopy);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at SaveOrUpdateBagPaymentEntity", ex);
                Logger.Error("Error in SaveOrUpdateBagPaymentEntity: Message - " + ex.Message + " StackTrace - " + ex.StackTrace);
                throw;
            }
        }

        public List<BagPaymentInfoEntity> GetAllBagPaymentDetailsEntity(string CustId, YesNo yesNo)
        {
            return rmisGateway.GetAllBagPaymentDetailsEntity(CustId, yesNo);
        }
    }
}
