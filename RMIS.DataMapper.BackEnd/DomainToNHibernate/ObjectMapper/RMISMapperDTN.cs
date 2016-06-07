﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net;

using AutoMapper;
using RMIS.Entities.BackEnd;
using RMIS.Domain.RiceMill;


namespace RMIS.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper
{

    public interface IRMISMapper
    {   
        MBagType GetBagType(MBagTypeEntity mBagTypeEntity);
        MUnitsType GetUnitsType(MUnitsTypeEntity mUnitsTypeEntity);
        SellerInfo GetSellerInfo(SellerInfoEntity SellerInfoEntity);
        CustomerInfo GetCustomerInfo(CustomerInfoEntity CustomerInfoEntity);
        MUserType GetMUserType(MUserTypeEntity MUserTypeEntity);
        Users GetUsers(UsersEntity UsersEntity);
        MPaddyType GetMPaddyType(MPaddyTypeEntity mPaddyTypeEntity);
        MBrokenRiceType GetMBrokenRiceType(MBrokenRiceTypeEntity mBrokenRiceTypeEntity);
        PaddyStockInfo GetPaddyStockInfo(PaddyStockInfoEntity paddyStockInfoEntity);
        RiceStockInfo GetRiceStockInfo(RiceStockInfoEntity riceStockInfoEntity);
        DustStockInfo GetDustStockInfo(DustStockInfoEntity dustStockInfoEntity);
        BagStockInfo GetBagStockInfo(BagStockInfoEntity bagStockInfoEntity);
        MLotDetails GetMLotDetails(MLotDetailsEntity mLotDetailsEntity);
        MGodownDetails GetMGodownDetails(MGodownDetailsEntity mGodownDetailsEntity);
        PaddyPaymentDetails GetPaddyPaymentDetails(PaddyPaymentDetailsEntity paddyPaymentDetailsEntity);
        MWeightDetails GetMWeightDetails(MWeightDetailsEntity mWeightDetailsEntity);
        CustomerAddressInfo GetCustomerAddressInfo(CustomerAddressInfoEntity customerAddressInfoEntity);
        CustomerActivation GetCustomerActivation(CustomerActivationEntity customerActivationEntity);
        CustTrailUsage GetCustTrailUsage(CustTrailUsageEntity custTrailUsageEntity);
        CustomerPayment GetCustomerPayment(CustomerPaymentEntity customerPaymentEntity);
        CustomerPartPayDetails GetCustomerPartPayDetails(CustomerPartPayDetailsEntity customerPartPayDetailsEntity);
        MDrierTypeDetails GetMDrierTypeDetails(MDrierTypeDetailsEntity mDrierTypeDetailsEntity);
        MRiceProductionType GetMRiceProductionType(MRiceProductionTypeEntity mRiceProductionTypeEntity);
        MRiceBrandDetails GetMRiceBrandDetails(MRiceBrandDetailsEntity mRiceBrandDetailsEntity);
        BrokenRiceStockInfo GetBrokenRiceStockInfo(BrokenRiceStockInfoEntity brokenRiceStockInfoEntity);
        RiceSellingInfo GetRiceSellingInfo(RiceSellingInfoEntity riceSellingInfoEntity);
        BrokenRiceSellingInfo GetBrokenRiceSellingInfo(BrokenRiceSellingInfoEntity brokenRiceSellingInfoEntity);
        DustSellingInfo GetDustSellingInfo(DustSellingInfoEntity dustSellingInfoEntity);
        MenuInfo GetMenuInfo(MenuInfoEntity menuInfoEntity);
        MenuConfiguration GetMenuConfig(MenuConfigurationEntity menuConfigEntity);
        MProductSellingType GetMProductSellingType(MProductSellingTypeEntity mProductSellingTypeEntity);
        ProductSellingInfo GetProductSellingInfo(ProductSellingInfoEntity productSellingInfoEntity);
        HullingProcess GetHullingProcessInfo(HullingProcessEntity hullingProcessEntity);
        HullingTransaction GetHullingProcessTransaction(HullingProcessTransactionEntity hullingProcessTransactionEntity);
        MRoles GetRoles(MRolesEntity hullingProcessTransactionEntity);
        RMUserRole GetUserRole(RMUserRoleEntity userRoleEntity);
        HullingProcessExpenses GetHullingProcessExpensesinfo(HullingProcessExpensesEntity hullingProcessExpensesEntity);
        BuyerSellerRating GetBuyerSellerRating(BuyerSellerRatingEntity buyerSellerRatingEntity);
        BuyerInfo GetBuyerInfo(BuyerInfoEntity BuyerInfoEntity);
        MEmployeeDesignation GetMEmployeeDesignation(MEmployeeDesignationEntity MEmployeeDesignationEntity);
        MSalaryType GetMSalaryType(MSalaryTypeEntity MSalaryTypeEntity);
        EmployeeDetails GetEmployeeDetails(EmployeeDetailsEntity EmployeeDetailsEntity);
    }

    public class RMISMapperDTN : IRMISMapper
    {


        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(RMISMapperDTN));

        #endregion Fields

        /// <summary>
        /// Gets the <see cref="AASObjection"/>
        /// </summary>
        /// <param name="SellerTypeEntity">The AASObjectionEntity.</param>
        /// <returns></returns>
        public MBagType GetBagType(MBagTypeEntity mBagTypeEntity)
        {
            MBagType BagType = null;
            try
            {
                BagType = Mapper.Map<MBagTypeEntity, MBagType>(mBagTypeEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetBagType", ex);
                throw;
            }
            return BagType;
        }

        public SellerInfo GetSellerInfo(SellerInfoEntity SellerInfoEntity)
        {
            SellerInfo sellerInfo = null;
            try
            {
                sellerInfo = Mapper.Map<SellerInfoEntity, SellerInfo>(SellerInfoEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetSellerInfo", ex);
                throw;
            }
            return sellerInfo;
        }

        public CustomerInfo GetCustomerInfo(CustomerInfoEntity customerInfoEntity)
        {
            CustomerInfo customerInfo = null;
            try
            {
                customerInfo = Mapper.Map<CustomerInfoEntity, CustomerInfo>(customerInfoEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetCustomerInfo", ex);
                throw;
            }
            return customerInfo;
        }
        public MUserType GetMUserType(MUserTypeEntity mUserTypeEntity)
        {
            MUserType mUserType = null;
            try
            {
                mUserType = Mapper.Map<MUserTypeEntity, MUserType>(mUserTypeEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMUserType", ex);
                throw;
            }
            return mUserType;
        }
        public Users GetUsers(UsersEntity usersEntity)
        {
            Users users = null;
            try
            {
                users = Mapper.Map<UsersEntity, Users>(usersEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetUsers", ex);
                throw;
            }
            return users;
        }
        public MPaddyType GetMPaddyType(MPaddyTypeEntity mPaddyTypeEntity)
        {
            MPaddyType mPaddyType = null;
            try
            {
                mPaddyType = Mapper.Map<MPaddyTypeEntity, MPaddyType>(mPaddyTypeEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMPaddyType", ex);
                throw;
            }
            return mPaddyType;
        }
        public PaddyStockInfo GetPaddyStockInfo(PaddyStockInfoEntity paddyStockInfoEntity)
        {
            PaddyStockInfo paddyStockInfo = null;
            try
            {
                paddyStockInfo = Mapper.Map<PaddyStockInfoEntity, PaddyStockInfo>(paddyStockInfoEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetPaddyStockInfo", ex);
                throw;
            }
            return paddyStockInfo;
        }
        public BagStockInfo GetBagStockInfo(BagStockInfoEntity bagStockInfoEntity)
        {
            BagStockInfo BagStockInfo = null;
            try
            {
                BagStockInfo = Mapper.Map<BagStockInfoEntity, BagStockInfo>(bagStockInfoEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetBagStockInfo", ex);
                throw;
            }
            return BagStockInfo;
        }

        public MLotDetails GetMLotDetails(MLotDetailsEntity mLotDetailsEntity)
        {
            MLotDetails mLotDetails = null;
            try
            {
                mLotDetails = Mapper.Map<MLotDetailsEntity, MLotDetails>(mLotDetailsEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMLotDetails", ex);
                throw;
            }
            return mLotDetails;
        }


        public MGodownDetails GetMGodownDetails(MGodownDetailsEntity mGodownDetailsEntity)
        {
            MGodownDetails mGodownDetails = null;
            try
            {
                mGodownDetails = Mapper.Map<MGodownDetailsEntity, MGodownDetails>(mGodownDetailsEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMGodownDetails", ex);
                throw;
            }
            return mGodownDetails;
        }


        public PaddyPaymentDetails GetPaddyPaymentDetails(PaddyPaymentDetailsEntity paddyPaymentDetailsEntity)
        {
            PaddyPaymentDetails paddyPaymentDetails = null;
            try
            {
                paddyPaymentDetails = Mapper.Map<PaddyPaymentDetailsEntity, PaddyPaymentDetails>(paddyPaymentDetailsEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetPaddyPaymentDetails", ex);
                throw;
            }
            return paddyPaymentDetails;
        }


        public MWeightDetails GetMWeightDetails(MWeightDetailsEntity mWeightDetailsEntity)
        {
            MWeightDetails mWeightDetails = null;
            try
            {
                mWeightDetails = Mapper.Map<MWeightDetailsEntity, MWeightDetails>(mWeightDetailsEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMWeightDetails", ex);
                throw;
            }
            return mWeightDetails;
        }
        public CustomerAddressInfo GetCustomerAddressInfo(CustomerAddressInfoEntity customerAddressInfoEntity)
        {
            CustomerAddressInfo customerAddressInfo = null;
            try
            {
                customerAddressInfo = Mapper.Map<CustomerAddressInfoEntity, CustomerAddressInfo>(customerAddressInfoEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetCustomerAddressInfo", ex);
                throw;
            }
            return customerAddressInfo;
        }


        public CustomerActivation GetCustomerActivation(CustomerActivationEntity customerActivationEntity)
        {
            CustomerActivation customerActivation = null;
            try
            {
                customerActivation = Mapper.Map<CustomerActivationEntity, CustomerActivation>(customerActivationEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetCustomerActivation", ex);
                throw;
            }
            return customerActivation;
        }


        public CustTrailUsage GetCustTrailUsage(CustTrailUsageEntity custTrailUsageEntity)
        {
            CustTrailUsage custTrailUsage = null;
            try
            {
                custTrailUsage = Mapper.Map<CustTrailUsageEntity, CustTrailUsage>(custTrailUsageEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetCustTrailUsage", ex);
                throw;
            }
            return custTrailUsage;
        }


        public CustomerPayment GetCustomerPayment(CustomerPaymentEntity customerPaymentEntity)
        {
            CustomerPayment customerPayment = null;
            try
            {
                customerPayment = Mapper.Map<CustomerPaymentEntity, CustomerPayment>(customerPaymentEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetCustomerPayment", ex);
                throw;
            }
            return customerPayment;
        }


        public CustomerPartPayDetails GetCustomerPartPayDetails(CustomerPartPayDetailsEntity customerPartPayDetailsEntity)
        {
            CustomerPartPayDetails customerPartPayDetails = null;
            try
            {
                customerPartPayDetails = Mapper.Map<CustomerPartPayDetailsEntity, CustomerPartPayDetails>(customerPartPayDetailsEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetCustomerPartPayDetails", ex);
                throw;
            }
            return customerPartPayDetails;
        }
        public MDrierTypeDetails GetMDrierTypeDetails(MDrierTypeDetailsEntity mDrierTypeDetailsEntity)
        {
            MDrierTypeDetails mDrierTypeDetails = null;
            try
            {
                mDrierTypeDetails = Mapper.Map<MDrierTypeDetailsEntity, MDrierTypeDetails>(mDrierTypeDetailsEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMDrierTypeDetails", ex);
                throw;
            }
            return mDrierTypeDetails;
        }
        public MRiceProductionType GetMRiceProductionType(MRiceProductionTypeEntity mRiceProductionTypeEntity)
        {
            MRiceProductionType mRiceProductionType = null;
            try
            {
                mRiceProductionType = Mapper.Map<MRiceProductionTypeEntity, MRiceProductionType>(mRiceProductionTypeEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMRiceProductionType", ex);
                throw;
            }
            return mRiceProductionType;
        }


        public MRiceBrandDetails GetMRiceBrandDetails(MRiceBrandDetailsEntity mRiceBrandDetailsEntity)
        {
            MRiceBrandDetails mRiceBrandDetails = null;
            try
            {
                mRiceBrandDetails = Mapper.Map<MRiceBrandDetailsEntity, MRiceBrandDetails>(mRiceBrandDetailsEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMRiceBrandDetails", ex);
                throw;
            }
            return mRiceBrandDetails;
        }




        public MUnitsType GetUnitsType(MUnitsTypeEntity mUnitsTypeEntity)
        {
            MUnitsType UnitsType = null;
            try
            {
                UnitsType = Mapper.Map<MUnitsTypeEntity, MUnitsType>(mUnitsTypeEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetUnitsType", ex);
                throw;
            }
            return UnitsType;
        }
        public MBrokenRiceType GetMBrokenRiceType(MBrokenRiceTypeEntity mBrokenRiceTypeEntity)
        {

            MBrokenRiceType mBrokenRiceType = null;
            try
            {
                mBrokenRiceType = Mapper.Map<MBrokenRiceTypeEntity, MBrokenRiceType>(mBrokenRiceTypeEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMBrokenRiceType", ex);
                throw;
            }
            return mBrokenRiceType;
        }
        public RiceStockInfo GetRiceStockInfo(RiceStockInfoEntity riceStockInfoEntity)
        {

            RiceStockInfo RiceStockInfo = null;
            try
            {
                RiceStockInfo = Mapper.Map<RiceStockInfoEntity, RiceStockInfo>(riceStockInfoEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetRiceStockInfo", ex);
                throw;
            }
            return RiceStockInfo;
        }
        public BrokenRiceStockInfo GetBrokenRiceStockInfo(BrokenRiceStockInfoEntity brokenRiceStockInfoEntity)
        {

            BrokenRiceStockInfo brokenRiceStockInfo = null;
            try
            {
                brokenRiceStockInfo = Mapper.Map<BrokenRiceStockInfoEntity, BrokenRiceStockInfo>(brokenRiceStockInfoEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetBrokenRiceStockInfo", ex);
                throw;
            }
            return brokenRiceStockInfo;
        }
        public DustStockInfo GetDustStockInfo(DustStockInfoEntity dustStockInfoEntity)
        {
            DustStockInfo dustStockInfo = null;
            try
            {
                dustStockInfo = Mapper.Map<DustStockInfoEntity, DustStockInfo>(dustStockInfoEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetDustStockInfo", ex);
                throw;
            }
            return dustStockInfo;
        }
        public RiceSellingInfo GetRiceSellingInfo(RiceSellingInfoEntity riceSellingInfoEntity)
        {
            RiceSellingInfo RiceSellingInfo = null;
            try
            {
                RiceSellingInfo = Mapper.Map<RiceSellingInfoEntity, RiceSellingInfo>(riceSellingInfoEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetRiceSellingInfo", ex);
                throw;
            }
            return RiceSellingInfo;
        }
        public BrokenRiceSellingInfo GetBrokenRiceSellingInfo(BrokenRiceSellingInfoEntity brokenRiceSellingInfoEntity)
        {
            BrokenRiceSellingInfo brokenRiceSellingInfo = null;
            try
            {
                brokenRiceSellingInfo = Mapper.Map<BrokenRiceSellingInfoEntity, BrokenRiceSellingInfo>(brokenRiceSellingInfoEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetBrokenRiceSellingInfo", ex);
                throw;
            }
            return brokenRiceSellingInfo;
        }
        public DustSellingInfo GetDustSellingInfo(DustSellingInfoEntity dustSellingInfoEntity)
        {
            DustSellingInfo DustSellingInfo = null;
            try
            {
                DustSellingInfo = Mapper.Map<DustSellingInfoEntity, DustSellingInfo>(dustSellingInfoEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetDustSellingInfo", ex);
                throw;
            }
            return DustSellingInfo;
        }

        public  MenuInfo GetMenuInfo(MenuInfoEntity menuInfoEntity)
        {
            MenuInfo menuInfo = null;

            try
            {
                if (menuInfoEntity != null)
                {
                    menuInfo = Mapper.Map<MenuInfoEntity, MenuInfo>(menuInfoEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetBrokenRiceSellingInfoEntity", ex);
                throw;
            }

            return menuInfo;
        }


        public MenuConfiguration GetMenuConfig(MenuConfigurationEntity menuConfigEntity)
        {
            MenuConfiguration menuInfo = null;
            try
            {
                if (menuConfigEntity != null)
                {
                    menuInfo = Mapper.Map<MenuConfigurationEntity, MenuConfiguration>(menuConfigEntity);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMenuConfig", ex);
                throw;
            }

            return menuInfo;
        }


        public MProductSellingType GetMProductSellingType(MProductSellingTypeEntity mProductSellingTypeEntity)
        {

            MProductSellingType mProductSellingType = null;
            try
            {
                mProductSellingType = Mapper.Map<MProductSellingTypeEntity, MProductSellingType>(mProductSellingTypeEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMProductSellingType", ex);
                throw;
            }
            return mProductSellingType;
        }


        public ProductSellingInfo GetProductSellingInfo(ProductSellingInfoEntity productSellingInfoEntity)
        {

            ProductSellingInfo ProductSellingInfo = null;
            try
            {
                ProductSellingInfo = Mapper.Map<ProductSellingInfoEntity, ProductSellingInfo>(productSellingInfoEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetProductSellingInfo", ex);
                throw;
            }
            return ProductSellingInfo;
        }


        public HullingProcess GetHullingProcessInfo(HullingProcessEntity hullingProcessEntity)
        {
            HullingProcess HullingProcess = null;
            try
            {
                HullingProcess = Mapper.Map<HullingProcessEntity, HullingProcess>(hullingProcessEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetHullingProcessInfo", ex);
                throw;
            }
            return HullingProcess;
        }


        public HullingTransaction GetHullingProcessTransaction(HullingProcessTransactionEntity hullingProcessTransactionEntity)
        {
            HullingTransaction HullingProcessTransaction = null;
            try
            {
                HullingProcessTransaction = Mapper.Map<HullingProcessTransactionEntity, HullingTransaction>(hullingProcessTransactionEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetHullingProcessTransaction", ex);
                throw;
            }
            return HullingProcessTransaction;
        }


        public MRoles GetRoles(MRolesEntity mRoleEntity)
        {
            MRoles mRole = null;
            try
            {
                mRole = Mapper.Map<MRolesEntity, MRoles>(mRoleEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetRoles", ex);
                throw;
            }
            return mRole;
        }


        public RMUserRole GetUserRole(RMUserRoleEntity userRoleEntity)
        {
            RMUserRole mRole = null;
            try
            {
                mRole = Mapper.Map<RMUserRoleEntity, RMUserRole>(userRoleEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetUserRole", ex);
                throw;
            }
            return mRole;
        }
        public HullingProcessExpenses GetHullingProcessExpensesinfo(HullingProcessExpensesEntity hullingProcessExpensesEntity)
        {
            HullingProcessExpenses HullingProcessExpenses = null;
            try
            {
                HullingProcessExpenses = Mapper.Map<HullingProcessExpensesEntity, HullingProcessExpenses>(hullingProcessExpensesEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetHullingProcessExpensesinfo", ex);
                throw;
            }
            return HullingProcessExpenses;
        }


        public BuyerSellerRating GetBuyerSellerRating(BuyerSellerRatingEntity buyerSellerRatingEntity)
        {
            BuyerSellerRating BuyerSellerRating = null;
            try
            {
                BuyerSellerRating = Mapper.Map<BuyerSellerRatingEntity, BuyerSellerRating>(buyerSellerRatingEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetBuyerSellerRating", ex);
                throw;
            }
            return BuyerSellerRating;
        }
        public BuyerInfo GetBuyerInfo(BuyerInfoEntity BuyerInfoEntity)
        {
            BuyerInfo BuyerInfo = null;
            try
            {
                BuyerInfo = Mapper.Map<BuyerInfoEntity, BuyerInfo>(BuyerInfoEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetBuyerInfo", ex);
                throw;
            }
            return BuyerInfo;
        }


        public MEmployeeDesignation GetMEmployeeDesignation(MEmployeeDesignationEntity MEmployeeDesignationEntity)
        {
            MEmployeeDesignation MEmployeeDesignation = null;
            try
            {
                MEmployeeDesignation = Mapper.Map<MEmployeeDesignationEntity, MEmployeeDesignation>(MEmployeeDesignationEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMEmployeeDesignation", ex);
                throw;
            }
            return MEmployeeDesignation;
        }


        public MSalaryType GetMSalaryType(MSalaryTypeEntity MSalaryTypeEntity)
        {
            MSalaryType MSalaryType = null;
            try
            {
                MSalaryType = Mapper.Map<MSalaryTypeEntity, MSalaryType>(MSalaryTypeEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMSalaryType", ex);
                throw;
            }
            return MSalaryType;
        }
        public EmployeeDetails GetEmployeeDetails(EmployeeDetailsEntity EmployeeDetailsEntity)
        {
            EmployeeDetails EmployeeDetails = null;
            try
            {
                EmployeeDetails = Mapper.Map<EmployeeDetailsEntity, EmployeeDetails>(EmployeeDetailsEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetEmployeeDetails", ex);
                throw;
            }
            return EmployeeDetails;
        }
    }
}
