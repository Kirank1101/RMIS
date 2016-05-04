using System;
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
        MSellerType GetSellerType(SellerTypeEntity SellerTypeEntity);
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
        public MSellerType GetSellerType(SellerTypeEntity SellerTypeEntity)
        {
            MSellerType sellerType = null;
            try
            {
                sellerType = Mapper.Map<SellerTypeEntity, MSellerType>(SellerTypeEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetSellerType", ex);
                throw;
            }
            return sellerType;
        }

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
    }
}
