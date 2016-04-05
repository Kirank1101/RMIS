using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;

using log4net;
using RMIS.Entities.BackEnd;
using RMIS.Entities.BackEnd;
using RMIS.Domain.RiceMill;

namespace RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapping
{
    internal class RMISMappingNTD
    {


        #region Fields

        private static readonly ILog Logger = LogManager.GetLogger(typeof(RMISMappingNTD));

        #endregion Fields
        /// <summary>
        /// Method which maps the <see cref="AffidavitDeponentDetail"/> to <see cref="AffidavitDeponentDetailEntity"/>.
        /// </summary>
        internal void MapSellerTypeEntity()
        {
            try
            {
                Mapper.CreateMap<MSellerType, SellerTypeEntity>()
                    .ForMember(dest => dest.SellerTypeID, opts => opts.MapFrom(src => src.SellerTypeID))
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID ))
                    .ForMember(dest => dest.SellerType, opts => opts.MapFrom(src => src.SellerType ))
                    .ForMember(dest => dest.ObsInd , opts => opts.MapFrom(src => src.ObsInd ))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapSellerTypeToSellerTypeEntity", ex);
                throw;
            }
        }

        internal void MapSellerInfoEntity()
        {
            try
            {
                Mapper.CreateMap<SellerInfo, SellerInfoEntity>()
                    .ForMember(dest => dest.SellerID, opts => opts.MapFrom(src => src.SellerID))
                    .ForMember(dest => dest.SellerTypeID, opts => opts.MapFrom(src => src.SellerTypeID))
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID))
                    .ForMember(dest => dest.Name, opts => opts.MapFrom(src => src.Name))
                    .ForMember(dest => dest.Street, opts => opts.MapFrom(src => src.Street))
                    .ForMember(dest => dest.Street1, opts => opts.MapFrom(src => src.Street1))
                    .ForMember(dest => dest.Town, opts => opts.MapFrom(src => src.Town))
                    .ForMember(dest => dest.City, opts => opts.MapFrom(src => src.City))
                    .ForMember(dest => dest.District, opts => opts.MapFrom(src => src.District))
                    .ForMember(dest => dest.State, opts => opts.MapFrom(src => src.State))
                    .ForMember(dest => dest.PinCode, opts => opts.MapFrom(src => src.PinCode))
                    .ForMember(dest => dest.ContactNo, opts => opts.MapFrom(src => src.ContactNo))
                    .ForMember(dest => dest.MobileNo, opts => opts.MapFrom(src => src.MobileNo))
                    .ForMember(dest => dest.PhoneNo, opts => opts.MapFrom(src => src.PhoneNo))
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapSellerInfoEntity", ex);
                throw;
            }
        }

        internal void MapCustomerInfoEntity()
        {
            try
            {
                Mapper.CreateMap<CustomerInfo, CustomerInfoEntity>()
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID))
                    .ForMember(dest => dest.Name, opts => opts.MapFrom(src => src.Name))
                    .ForMember(dest => dest.OrganizationName, opts => opts.MapFrom(src => src.OrganizationName))
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapCustomerInfoEntity", ex);
                throw;
            }
        }
        internal void MapMUserTypeEntity()
        {
            try
            {
                Mapper.CreateMap<MUserType, MUserTypeEntity>()
                    .ForMember(dest => dest.UserTypeID, opts => opts.MapFrom(src => src.UserTypeID))
                    .ForMember(dest => dest.UserType, opts => opts.MapFrom(src => src.UserType))
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapMUserTypeEntity", ex);
                throw;
            }
        }
        internal void MapUsersEntity()
        {
            try
            {
                Mapper.CreateMap<Users, UsersEntity>()
                    .ForMember(dest => dest.UserID, opts => opts.MapFrom(src => src.UserID))
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID))
                    .ForMember(dest => dest.UserTypeID, opts => opts.MapFrom(src => src.UserTypeID))
                    .ForMember(dest => dest.Name, opts => opts.MapFrom(src => src.Name))
                    .ForMember(dest => dest.PassWord, opts => opts.MapFrom(src => src.PassWord))
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapUserEntity", ex);
                throw;
            }
        }
        internal void MapMPaddyTypeEntity()
        {
            try
            {
                Mapper.CreateMap<MPaddyType, MPaddyTypeEntity>()
                    .ForMember(dest => dest.PaddyTypeID, opts => opts.MapFrom(src => src.PaddyTypeID))
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID))
                    .ForMember(dest => dest.Name, opts => opts.MapFrom(src => src.Name))
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapMPaddyTypeEntity", ex);
                throw;
            }
        }
        internal void MapPaddyStockInfoEntity()
        {
            try
            {
                Mapper.CreateMap<PaddyStockInfo, PaddyStockInfoEntity>()
                    .ForMember(dest => dest.PaddyStockID, opts => opts.MapFrom(src => src.PaddyStockID))
                    .ForMember(dest => dest.SellerID, opts => opts.MapFrom(src => src.SellerID))
                    .ForMember(dest => dest.PaddyTypeID, opts => opts.MapFrom(src => src.PaddyTypeID))
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID))
                    .ForMember(dest => dest.MGodownID, opts => opts.MapFrom(src => src.MGodownID))
                    .ForMember(dest => dest.MLotID, opts => opts.MapFrom(src => src.MLotID))
                    .ForMember(dest => dest.VehicalNo, opts => opts.MapFrom(src => src.VehicalNo))
                    .ForMember(dest => dest.TotalBags, opts => opts.MapFrom(src => src.TotalBags))
                    .ForMember(dest => dest.QWeight, opts => opts.MapFrom(src => src.QWeight))
                    .ForMember(dest => dest.QPrice, opts => opts.MapFrom(src => src.QPrice))
                    .ForMember(dest => dest.PurchaseDate, opts => opts.MapFrom(src => src.PurchaseDate))
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapPaddyStockInfoEntity", ex);
                throw;
            }
        }
        internal void MapMLotDetailsEntity()
        {
            try
            {
                Mapper.CreateMap<MLotDetails, MLotDetailsEntity>()
                    .ForMember(dest => dest.MLotID, opts => opts.MapFrom(src => src.MLotID))
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID))
                    .ForMember(dest => dest.LotName, opts => opts.MapFrom(src => src.LotName))
                    .ForMember(dest => dest.MGodownID, opts => opts.MapFrom(src => src.MGodownID))
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapMLotDetailsEntity", ex);
                throw;
            }
        }
    }
}
