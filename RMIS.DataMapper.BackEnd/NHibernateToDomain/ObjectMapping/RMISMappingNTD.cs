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
    }
}
