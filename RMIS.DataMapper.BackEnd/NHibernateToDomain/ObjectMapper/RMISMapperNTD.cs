using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RMIS.Entities.BackEnd;

using AutoMapper;
using log4net;
using RMIS.Entities.BackEnd;
using RMIS.Domain.RiceMill;
using RMIS.Entities.BackEnd;

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
      public static SellerTypeEntity GetSellerTypeEntity(MSellerType sellerType)
        {
            SellerTypeEntity sellerTypeEntity = null;

            try
            {
                if (sellerType != null)
                {
                    sellerTypeEntity = Mapper.Map<MSellerType, SellerTypeEntity>(sellerType);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetSellerTypeEntity", ex);
                throw;
            }

            return sellerTypeEntity;
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
    }
}
