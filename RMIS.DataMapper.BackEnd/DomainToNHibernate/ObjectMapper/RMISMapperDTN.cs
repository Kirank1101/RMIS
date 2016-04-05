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
        SellerInfo GetSellerInfo(SellerInfoEntity SellerInfoEntity);
        CustomerInfo GetCustomerInfo(CustomerInfoEntity CustomerInfoEntity);
        MUserType GetMUserType(MUserTypeEntity MUserTypeEntity);
        Users GetUsers(UsersEntity UsersEntity);
        MPaddyType GetMPaddyType(MPaddyTypeEntity mPaddyTypeEntity);
        PaddyStockInfo GetPaddyStockInfo(PaddyStockInfoEntity paddyStockInfoEntity);
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
        public  MSellerType GetSellerType(SellerTypeEntity SellerTypeEntity)
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
    }
}
