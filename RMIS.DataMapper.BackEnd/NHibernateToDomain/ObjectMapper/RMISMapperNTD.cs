﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RMIS.Entities.BackEnd;
using AutoMapper;
using log4net;
using RMIS.Domain.RiceMill;

namespace RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper
{
    public class RMISMapperNTD
    {

        #region Fields
        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(RMISMapperNTD));

        #endregion Fields

        /// <summary>
        /// Gets the <see cref="ReportConfigUser"/> from <see cref="ReportConfigUserEntity"/> input.
        /// </summary>
        /// <param name="reportConfigUserEntity"><see cref="ReportConfigUserEntity"/></param>
        /// <returns>Returns <see cref="ReportConfigUser"/>, else null.</returns>
        
        public static MBagTypeEntity GetMBagTypeEntity(MBagType mBagType)
        {
            MBagTypeEntity mBagTypeEntity = null;

            try
            {
                if (mBagType != null)
                {
                    mBagTypeEntity = Mapper.Map<MBagType, MBagTypeEntity>(mBagType);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMBagTypeEntity", ex);
                throw;
            }

            return mBagTypeEntity;
        }
        public static MUnitsTypeEntity GetMUnitsTypeEntity(MUnitsType mUnitsType)
        {
            MUnitsTypeEntity mUnitsTypeEntity = null;

            try
            {
                if (mUnitsType != null)
                {
                    mUnitsTypeEntity = Mapper.Map<MUnitsType, MUnitsTypeEntity>(mUnitsType);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMUnitsTypeEntity", ex);
                throw;
            }

            return mUnitsTypeEntity;
        }
        public static SellerInfoEntity GetSellerInfoEntity(SellerInfo sellerInfo)
        {
            SellerInfoEntity sellerInfoEntity = null;

            try
            {
                if (sellerInfo != null)
                {
                    sellerInfoEntity = Mapper.Map<SellerInfo, SellerInfoEntity>(sellerInfo);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetSellerInfoEntity", ex);
                throw;
            }

            return sellerInfoEntity;
        }
        public static CustomerInfoEntity GetCustomerInfoEntity(CustomerInfo customerInfo)
        {
            CustomerInfoEntity customerInfoEntity = null;

            try
            {
                if (customerInfo != null)
                {
                    customerInfoEntity = Mapper.Map<CustomerInfo, CustomerInfoEntity>(customerInfo);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetCustomerInfoEntity", ex);
                throw;
            }

            return customerInfoEntity;
        }
        public static MUserTypeEntity GetMUserTypeEntity(MUserType mUserType)
        {
            MUserTypeEntity mUserTypeEntity = null;

            try
            {
                if (mUserType != null)
                {
                    mUserTypeEntity = Mapper.Map<MUserType, MUserTypeEntity>(mUserType);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMUserTypeEntity", ex);
                throw;
            }

            return mUserTypeEntity;
        }
        public static UsersEntity GetUsersEntity(Users users)
        {
            UsersEntity usersEntity = null;

            try
            {
                if (users != null)
                {
                    usersEntity = Mapper.Map<Users, UsersEntity>(users);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetUsersEntity", ex);
                throw;
            }

            return usersEntity;
        }
        public static MPaddyTypeEntity GetMPaddyTypeEntity(MPaddyType mPaddyType)
        {
            MPaddyTypeEntity mPaddyTypeEntity = null;

            try
            {
                if (mPaddyType != null)
                {
                    mPaddyTypeEntity = Mapper.Map<MPaddyType, MPaddyTypeEntity>(mPaddyType);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMPaddyTypeEntity", ex);
                throw;
            }

            return mPaddyTypeEntity;
        }
        public static BagStockInfoEntity GetBagStockInfoEntity(BagStockInfo BagStockInfo)
        {
            BagStockInfoEntity BagStockInfoEntity = null;

            try
            {
                if (BagStockInfo != null)
                {
                    BagStockInfoEntity = Mapper.Map<BagStockInfo, BagStockInfoEntity>(BagStockInfo);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetBagStockInfoEntity", ex);
                throw;
            }

            return BagStockInfoEntity;
        }

        public static PaddyStockInfoEntity GetPaddyStockInfoEntity(PaddyStockInfo paddyStockInfo)
        {
            PaddyStockInfoEntity paddyStockInfoEntity = null;

            try
            {
                if (paddyStockInfo != null)
                {
                    paddyStockInfoEntity = Mapper.Map<PaddyStockInfo, PaddyStockInfoEntity>(paddyStockInfo);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetPaddyStockInfoEntity", ex);
                throw;
            }

            return paddyStockInfoEntity;
        }
        public static MLotDetailsEntity GetMLotDetailsEntity(MLotDetails mLotDetails)
        {
            MLotDetailsEntity MLotDetailsEntity = null;

            try
            {
                if (mLotDetails != null)
                {
                    MLotDetailsEntity = Mapper.Map<MLotDetails, MLotDetailsEntity>(mLotDetails);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMLotDetailsEntity", ex);
                throw;
            }

            return MLotDetailsEntity;
        }
        public static MGodownDetailsEntity GetMGodownDetailsEntity(MGodownDetails mGodownDetails)
        {
            MGodownDetailsEntity mGodownDetailsEntity = null;

            try
            {
                if (mGodownDetails != null)
                {
                    mGodownDetailsEntity = Mapper.Map<MGodownDetails, MGodownDetailsEntity>(mGodownDetails);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMGodownDetailsEntity", ex);
                throw;
            }

            return mGodownDetailsEntity;
        }
        public static PaddyPaymentDetailsEntity GetPaddyPaymentDetailsEntity(PaddyPaymentDetails paddyPaymentDetails)
        {
            PaddyPaymentDetailsEntity paddyPaymentDetailsEntity = null;

            try
            {
                if (paddyPaymentDetails != null)
                {
                    paddyPaymentDetailsEntity = Mapper.Map<PaddyPaymentDetails, PaddyPaymentDetailsEntity>(paddyPaymentDetails);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetPaddyPaymentDetailsEntity", ex);
                throw;
            }

            return paddyPaymentDetailsEntity;
        }
        public static MWeightDetailsEntity GetMWeightDetailsEntity(MWeightDetails mWeightDetails)
        {
            MWeightDetailsEntity mWeightDetailsEntity = null;

            try
            {
                if (mWeightDetails != null)
                {
                    mWeightDetailsEntity = Mapper.Map<MWeightDetails, MWeightDetailsEntity>(mWeightDetails);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMWeightDetailsEntity", ex);
                throw;
            }

            return mWeightDetailsEntity;
        }
        public static CustomerAddressInfoEntity GetCustomerAddressInfoEntity(CustomerAddressInfo customerAddressInfo)
        {
            CustomerAddressInfoEntity customerAddressInfoEntity = null;

            try
            {
                if (customerAddressInfo != null)
                {
                    customerAddressInfoEntity = Mapper.Map<CustomerAddressInfo, CustomerAddressInfoEntity>(customerAddressInfo);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetCustomerAddressInfoEntity", ex);
                throw;
            }

            return customerAddressInfoEntity;
        }
        public static CustomerActivationEntity GetCustomerActivationEntity(CustomerActivation customerActivation)
        {
            CustomerActivationEntity customerActivationEntity = null;

            try
            {
                if (customerActivation != null)
                {
                    customerActivationEntity = Mapper.Map<CustomerActivation, CustomerActivationEntity>(customerActivation);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetCustomerActivationEntity", ex);
                throw;
            }

            return customerActivationEntity;
        }
        public static CustTrailUsageEntity GetCustTrailUsageEntity(CustTrailUsage custTrailUsage)
        {
            CustTrailUsageEntity custTrailUsageEntity = null;

            try
            {
                if (custTrailUsage != null)
                {
                    custTrailUsageEntity = Mapper.Map<CustTrailUsage, CustTrailUsageEntity>(custTrailUsage);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetCustTrailUsageEntity", ex);
                throw;
            }

            return custTrailUsageEntity;
        }
        public static CustomerPaymentEntity GetCustomerPaymentEntity(CustomerPayment customerPayment)
        {
            CustomerPaymentEntity customerPaymentEntity = null;

            try
            {
                if (customerPayment != null)
                {
                    customerPaymentEntity = Mapper.Map<CustomerPayment, CustomerPaymentEntity>(customerPayment);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetCustomerPaymentEntity", ex);
                throw;
            }

            return customerPaymentEntity;
        }
        public static CustomerPartPayDetailsEntity GetCustomerPartPayDetailsEntity(CustomerPartPayDetails customerPartPayDetails)
        {
            CustomerPartPayDetailsEntity customerPartPayDetailsEntity = null;

            try
            {
                if (customerPartPayDetails != null)
                {
                    customerPartPayDetailsEntity = Mapper.Map<CustomerPartPayDetails, CustomerPartPayDetailsEntity>(customerPartPayDetails);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetCustomerPartPayDetailsEntity", ex);
                throw;
            }

            return customerPartPayDetailsEntity;
        }
        public static MDrierTypeDetailsEntity GetMDrierTypeDetailsEntity(MDrierTypeDetails mDrierTypeDetails)
        {
            MDrierTypeDetailsEntity mDrierTypeDetailsEntity = null;

            try
            {
                if (mDrierTypeDetails != null)
                {
                    mDrierTypeDetailsEntity = Mapper.Map<MDrierTypeDetails, MDrierTypeDetailsEntity>(mDrierTypeDetails);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMDrierTypeDetailsEntity", ex);
                throw;
            }

            return mDrierTypeDetailsEntity;
        }
        public static MRiceProductionTypeEntity GetMRiceProductionTypeEntity(MRiceProductionType mRiceProductionType)
        {
            MRiceProductionTypeEntity mRiceProductionTypeEntity = null;

            try
            {
                if (mRiceProductionType != null)
                {
                    mRiceProductionTypeEntity = Mapper.Map<MRiceProductionType, MRiceProductionTypeEntity>(mRiceProductionType);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMRiceProductionTypeEntity", ex);
                throw;
            }

            return mRiceProductionTypeEntity;
        }
        public static MRiceBrandDetailsEntity GetMRiceBrandDetailsEntity(MRiceBrandDetails mRiceBrandDetails)
        {
            MRiceBrandDetailsEntity mRiceBrandDetailsEntity = null;

            try
            {
                if (mRiceBrandDetails != null)
                {
                    mRiceBrandDetailsEntity = Mapper.Map<MRiceBrandDetails, MRiceBrandDetailsEntity>(mRiceBrandDetails);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMRiceBrandDetailsEntity", ex);
                throw;
            }

            return mRiceBrandDetailsEntity;
        }
        public static MBrokenRiceTypeEntity GetMBrokenRiceTypeEntity(MBrokenRiceType mBrokenRiceType)
        {
            MBrokenRiceTypeEntity mBrokenRiceTypeEntity = null;

            try
            {
                if (mBrokenRiceType != null)
                {
                    mBrokenRiceTypeEntity = Mapper.Map<MBrokenRiceType, MBrokenRiceTypeEntity>(mBrokenRiceType);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMBrokenRiceTypeEntity", ex);
                throw;
            }

            return mBrokenRiceTypeEntity;
        }
        public static RiceStockInfoEntity GetRiceStockInfoEntity(RiceStockInfo riceStockInfo)
        {
            RiceStockInfoEntity RiceStockInfoEntity = null;

            try
            {
                if (riceStockInfo != null)
                {
                    RiceStockInfoEntity = Mapper.Map<RiceStockInfo, RiceStockInfoEntity>(riceStockInfo);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetRiceStockInfoEntity", ex);
                throw;
            }

            return RiceStockInfoEntity;
        }
        public static BrokenRiceStockInfoEntity GetBrokenRiceStockInfoEntity(BrokenRiceStockInfo brokenRiceStockInfo)
        {
            BrokenRiceStockInfoEntity brokenRiceStockInfoEntity = null;

            try
            {
                if (brokenRiceStockInfo != null)
                {
                    brokenRiceStockInfoEntity = Mapper.Map<BrokenRiceStockInfo, BrokenRiceStockInfoEntity>(brokenRiceStockInfo);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetBrokenRiceStockInfoEntity", ex);
                throw;
            }

            return brokenRiceStockInfoEntity;
        }
        public static DustStockInfoEntity GetDustStockInfoEntity(DustStockInfo dustStockInfo)
        {
            DustStockInfoEntity dustStockInfoEntity = null;

            try
            {
                if (dustStockInfo != null)
                {
                    dustStockInfoEntity = Mapper.Map<DustStockInfo, DustStockInfoEntity>(dustStockInfo);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetDustStockInfoEntity", ex);
                throw;
            }

            return dustStockInfoEntity;
        }
        public static RiceSellingInfoEntity GetRiceSellingInfoEntity(RiceSellingInfo riceSellingInfo)
        {
            RiceSellingInfoEntity RiceSellingInfoEntity = null;

            try
            {
                if (riceSellingInfo != null)
                {
                    RiceSellingInfoEntity = Mapper.Map<RiceSellingInfo, RiceSellingInfoEntity>(riceSellingInfo);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetRiceSellingInfoEntity", ex);
                throw;
            }

            return RiceSellingInfoEntity;
        }
        public static BrokenRiceSellingInfoEntity GetBrokenRiceSellingInfoEntity(BrokenRiceSellingInfo brokenRiceSellingInfo)
        {
            BrokenRiceSellingInfoEntity brokenRiceSellingInfoEntity = null;

            try
            {
                if (brokenRiceSellingInfo != null)
                {
                    brokenRiceSellingInfoEntity = Mapper.Map<BrokenRiceSellingInfo, BrokenRiceSellingInfoEntity>(brokenRiceSellingInfo);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetBrokenRiceSellingInfoEntity", ex);
                throw;
            }

            return brokenRiceSellingInfoEntity;
        }
        public static DustSellingInfoEntity GetDustSellingInfoEntity(DustSellingInfo dustSellingInfo)
        {
            DustSellingInfoEntity DustSellingInfoEntity = null;

            try
            {
                if (dustSellingInfo != null)
                {
                    DustSellingInfoEntity = Mapper.Map<DustSellingInfo, DustSellingInfoEntity>(dustSellingInfo);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetDustSellingInfoEntity", ex);
                throw;
            }

            return DustSellingInfoEntity;
        }


        public static MenuInfoEntity GetMenuInfoEntity(MenuInfo menuInfo)
        {
            MenuInfoEntity menuInfoEntity = null;

            try
            {
                if (menuInfo != null)
                {
                    menuInfoEntity = Mapper.Map<MenuInfo, MenuInfoEntity>(menuInfo);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMenuInfoEntity", ex);
                throw;
            }

            return menuInfoEntity;
        }

        public static MenuConfigurationEntity GetMenuConfigEntity(MenuConfiguration menuInfo)
        {
            MenuConfigurationEntity menuInfoEntity = null;

            try
            {
                if (menuInfo != null)
                {
                    menuInfoEntity = Mapper.Map<MenuConfiguration, MenuConfigurationEntity>(menuInfo);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMenuConfigEntity", ex);
                throw;
            }

            return menuInfoEntity;
        }
        public static MProductSellingTypeEntity GetMProductSellingTypeEntity(MProductSellingType mProductSellingType)
        {
            MProductSellingTypeEntity mProductSellingTypeEntity = null;

            try
            {
                if (mProductSellingType != null)
                {
                    mProductSellingTypeEntity = Mapper.Map<MProductSellingType, MProductSellingTypeEntity>(mProductSellingType);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMProductSellingTypeEntity", ex);
                throw;
            }

            return mProductSellingTypeEntity;
        }
        public static ProductSellingInfoEntity GetProductSellingInfoEntity(ProductSellingInfo productSellingInfo)
        {
            ProductSellingInfoEntity ProductSellingInfoEntity = null;

            try
            {
                if (productSellingInfo != null)
                {
                    ProductSellingInfoEntity = Mapper.Map<ProductSellingInfo, ProductSellingInfoEntity>(productSellingInfo);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetProductSellingInfoEntity", ex);
                throw;
            }

            return ProductSellingInfoEntity;
        }
        public static HullingProcessEntity GetHullingProcessInfoEntity(HullingProcess hullingProcessInfo)
        {
            HullingProcessEntity hullingProcessEntity = null;

            try
            {
                if (hullingProcessInfo != null)
                {
                    hullingProcessEntity = Mapper.Map<HullingProcess, HullingProcessEntity>(hullingProcessInfo);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetHullingProcessInfoEntity", ex);
                throw;
            }

            return hullingProcessEntity;
        }
        public static HullingProcessTransactionEntity GetHullingProcessTransInfoEntity(HullingTransaction hullingProcessTransaction)
        {
            HullingProcessTransactionEntity HullingProcessTransactionEntity = null;

            try
            {
                if (hullingProcessTransaction != null)
                {
                    HullingProcessTransactionEntity = Mapper.Map<HullingTransaction, HullingProcessTransactionEntity>(hullingProcessTransaction);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetHullingProcessTransInfoEntity", ex);
                throw;
            }

            return HullingProcessTransactionEntity;
        }

        public static MRolesEntity GetRoleEntity(MRoles mrole)
        {
            MRolesEntity mRoleEntity = null;

            try
            {
                if (mrole != null)
                {
                    mRoleEntity = Mapper.Map<MRoles, MRolesEntity>(mrole);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetRolesEntity", ex);
                throw;
            }

            return mRoleEntity;
        }

        public static RMUserRoleEntity GetUserRoleEntity(RMUserRole mrole)
        {
            RMUserRoleEntity mRoleEntity = null;

            try
            {
                if (mrole != null)
                {
                    mRoleEntity = Mapper.Map<RMUserRole, RMUserRoleEntity>(mrole);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetUserRoleEntity", ex);
                throw;
            }

            return mRoleEntity;
        }
        public static HullingProcessExpensesEntity GetHullingProcessExpensesEntityInfoEntity(HullingProcessExpenses hullingProcessExpensesInfo)
        {
            HullingProcessExpensesEntity hullingProcessExpensesEntity = null;

            try
            {
                if (hullingProcessExpensesInfo != null)
                {
                    hullingProcessExpensesEntity = Mapper.Map<HullingProcessExpenses, HullingProcessExpensesEntity>(hullingProcessExpensesInfo);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetHullingProcessExpensesEntityInfoEntity", ex);
                throw;
            }

            return hullingProcessExpensesEntity;
        }
        public static BuyerSellerRatingEntity GetBuyerSellerRatingEntity(BuyerSellerRating BuyerSellerRating)
        {
            BuyerSellerRatingEntity BuyerSellerRatingEntity = null;

            try
            {
                if (BuyerSellerRating != null)
                {
                    BuyerSellerRatingEntity = Mapper.Map<BuyerSellerRating, BuyerSellerRatingEntity>(BuyerSellerRating);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetBuyerSellerRatingEntity", ex);
                throw;
            }

            return BuyerSellerRatingEntity;
        }
        public static BuyerInfoEntity GetBuyerInfoEntity(BuyerInfo BuyerInfo)
        {
            BuyerInfoEntity BuyerInfoEntity = null;

            try
            {
                if (BuyerInfo != null)
                {
                    BuyerInfoEntity = Mapper.Map<BuyerInfo, BuyerInfoEntity>(BuyerInfo);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetBuyerInfoEntity", ex);
                throw;
            }

            return BuyerInfoEntity;
        }
        public static MEmployeeDesignationEntity GetMEmployeeDesignationEntity(MEmployeeDesignation MEmployeeDesignation)
        {
            MEmployeeDesignationEntity MEmployeeDesignationEntity = null;

            try
            {
                if (MEmployeeDesignation != null)
                {
                    MEmployeeDesignationEntity = Mapper.Map<MEmployeeDesignation, MEmployeeDesignationEntity>(MEmployeeDesignation);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMEmployeeDesignationEntity", ex);
                throw;
            }

            return MEmployeeDesignationEntity;
        }
        public static MSalaryTypeEntity GetMSalaryTypeEntity(MSalaryType MSalaryType)
        {
            MSalaryTypeEntity MSalaryTypeEntity = null;

            try
            {
                if (MSalaryType != null)
                {
                    MSalaryTypeEntity = Mapper.Map<MSalaryType, MSalaryTypeEntity>(MSalaryType);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetMSalaryTypeEntity", ex);
                throw;
            }

            return MSalaryTypeEntity;
        }
        public static EmployeeDetailsEntity GetEmployeeDetailsEntity(EmployeeDetails EmployeeDetails)
        {
            EmployeeDetailsEntity EmployeeDetailsEntity = null;
            try
            {
                if (EmployeeDetails != null)
                {
                    EmployeeDetailsEntity = Mapper.Map<EmployeeDetails, EmployeeDetailsEntity>(EmployeeDetails);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetEmployeeDetailsEntity", ex);
                throw;
            }
            return EmployeeDetailsEntity;
        }
        public static EmployeeSalaryEntity GetEmployeeSalaryEntity(EmployeeSalary EmployeeSalary)
        {
            EmployeeSalaryEntity EmployeeSalaryEntity = null;
            try
            {
                if (EmployeeSalary != null)
                {
                    EmployeeSalaryEntity = Mapper.Map<EmployeeSalary, EmployeeSalaryEntity>(EmployeeSalary);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetEmployeeSalaryEntity", ex);
                throw;
            }
            return EmployeeSalaryEntity;
        }
        public static EmployeeSalaryPaymentEntity GetEmployeeSalaryPaymentEntity(MoneyTransaction MoneyTransaction)
        {
            EmployeeSalaryPaymentEntity EmployeeSalaryPaymentEntity = null;
            try
            {
                if (MoneyTransaction != null)
                {
                    EmployeeSalaryPaymentEntity = Mapper.Map<MoneyTransaction, EmployeeSalaryPaymentEntity>(MoneyTransaction);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetEmployeeSalaryPaymentEntity", ex);
                throw;
            }
            return EmployeeSalaryPaymentEntity;
        }
    }


}
