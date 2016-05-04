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
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID))
                    .ForMember(dest => dest.SellerType, opts => opts.MapFrom(src => src.SellerType))
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapSellerTypeToSellerTypeEntity", ex);
                throw;
            }
        }

        internal void MapMBagTypeEntity()
        {
            try
            {
                Mapper.CreateMap<MBagType, MBagTypeEntity>()
                    .ForMember(dest => dest.BagTypeID, opts => opts.MapFrom(src => src.BagTypeID))
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID))
                    .ForMember(dest => dest.BagType, opts => opts.MapFrom(src => src.BagType))
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MBagTypeToMBagTypeEntity", ex);
                throw;
            }
        }

        internal void MapMUnitsTypeEntity()
        {
            try
            {
                Mapper.CreateMap<MUnitsType, MUnitsTypeEntity>()
                    .ForMember(dest => dest.UnitsTypeID, opts => opts.MapFrom(src => src.UnitsTypeID))
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID))
                    .ForMember(dest => dest.UnitsType, opts => opts.MapFrom(src => src.UnitsType))
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MUnitsTypeToMUnitsTypeEntity", ex);
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
                    .ForMember(dest => dest.DriverName, opts => opts.MapFrom(src => src.DriverName))
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
        internal void MapBagStockInfoEntity()
        {
            try
            {
                Mapper.CreateMap<BagStockInfo, BagStockInfoEntity>()
                    .ForMember(dest => dest.BagStockID, opts => opts.MapFrom(src => src.BagStockID))
                    .ForMember(dest => dest.SellerID, opts => opts.MapFrom(src => src.SellerID))
                    .ForMember(dest => dest.BagTypeID, opts => opts.MapFrom(src => src.BagTypeID))
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID))
                    .ForMember(dest => dest.VehicalNo, opts => opts.MapFrom(src => src.VehicalNo))
                    .ForMember(dest => dest.DriverName, opts => opts.MapFrom(src => src.DriverName))
                    .ForMember(dest => dest.TotalBags, opts => opts.MapFrom(src => src.TotalBags))
                    .ForMember(dest => dest.PricePerBag, opts => opts.MapFrom(src => src.PricePerBag))
                    .ForMember(dest => dest.PurchaseDate, opts => opts.MapFrom(src => src.PurchaseDate))
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapBagStockInfoEntity", ex);
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
        internal void MapMGodownDetailsEntity()
        {
            try
            {
                Mapper.CreateMap<MGodownDetails, MGodownDetailsEntity>()
                    .ForMember(dest => dest.MGodownID, opts => opts.MapFrom(src => src.MGodownID))
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID))
                    .ForMember(dest => dest.Place, opts => opts.MapFrom(src => src.Place))
                    .ForMember(dest => dest.Name, opts => opts.MapFrom(src => src.Name))
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapMGodownDetailsEntity", ex);
                throw;
            }
        }
        internal void MapPaddyPaymentDetailsEntity()
        {
            try
            {
                Mapper.CreateMap<PaddyPaymentDetails, PaddyPaymentDetailsEntity>()
                    .ForMember(dest => dest.PaddyPaymentID, opts => opts.MapFrom(src => src.PaddyPaymentID))
                    .ForMember(dest => dest.SellerID, opts => opts.MapFrom(src => src.SellerID))
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID))
                    .ForMember(dest => dest.AmountPaid, opts => opts.MapFrom(src => src.AmountPaid))
                    .ForMember(dest => dest.PaidDate, opts => opts.MapFrom(src => src.PaidDate))
                    .ForMember(dest => dest.HandoverTo, opts => opts.MapFrom(src => src.HandoverTo))
                    .ForMember(dest => dest.NextPaymentDate, opts => opts.MapFrom(src => src.NextPaymentDate))
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapPaddyPaymentDetailsEntity", ex);
                throw;
            }
        }
        internal void MapMWeightDetailsEntity()
        {
            try
            {
                Mapper.CreateMap<MWeightDetails, MWeightDetailsEntity>()
                    .ForMember(dest => dest.MWeightID, opts => opts.MapFrom(src => src.MWeightID))
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID))
                    .ForMember(dest => dest.Weight, opts => opts.MapFrom(src => src.Weight))
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MWeightDetailsEntity", ex);
                throw;
            }
        }
        internal void MapCustomerAddressInfoEntity()
        {
            try
            {
                Mapper.CreateMap<CustomerAddressInfo, CustomerAddressInfoEntity>()
                    .ForMember(dest => dest.CustAdrsID, opts => opts.MapFrom(src => src.CustAdrsID))
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID))
                    .ForMember(dest => dest.Street1, opts => opts.MapFrom(src => src.Street1))
                    .ForMember(dest => dest.Street2, opts => opts.MapFrom(src => src.Street2))
                    .ForMember(dest => dest.Town, opts => opts.MapFrom(src => src.Town))
                    .ForMember(dest => dest.City, opts => opts.MapFrom(src => src.City))
                    .ForMember(dest => dest.District, opts => opts.MapFrom(src => src.District))
                    .ForMember(dest => dest.State, opts => opts.MapFrom(src => src.State))
                    .ForMember(dest => dest.Pincode, opts => opts.MapFrom(src => src.Pincode))
                    .ForMember(dest => dest.ContactNo, opts => opts.MapFrom(src => src.ContactNo))
                    .ForMember(dest => dest.MobileNo, opts => opts.MapFrom(src => src.MobileNo))
                    .ForMember(dest => dest.PhoneNo, opts => opts.MapFrom(src => src.PhoneNo))
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapCustomerAddressInfoEntity", ex);
                throw;
            }
        }
        internal void MapCustomerActivationEntity()
        {
            try
            {
                Mapper.CreateMap<CustomerActivation, CustomerActivationEntity>()
                    .ForMember(dest => dest.CustActiveID, opts => opts.MapFrom(src => src.CustActiveID))
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID))
                    .ForMember(dest => dest.ApplicationStartDate, opts => opts.MapFrom(src => src.ApplicationStartDate))
                    .ForMember(dest => dest.ApplicationEndDate, opts => opts.MapFrom(src => src.ApplicationEndDate))
                    .ForMember(dest => dest.Status, opts => opts.MapFrom(src => src.Status))
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapCustomerActivationEntity", ex);
                throw;
            }
        }
        internal void MapCustTrailUsageEntity()
        {
            try
            {
                Mapper.CreateMap<CustTrailUsage, CustTrailUsageEntity>()
                    .ForMember(dest => dest.CustTrailID, opts => opts.MapFrom(src => src.CustTrailID))
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID))
                    .ForMember(dest => dest.TrailStartDate, opts => opts.MapFrom(src => src.TrailStartDate))
                    .ForMember(dest => dest.TrailEndDate, opts => opts.MapFrom(src => src.TrailEndDate))
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapCustTrailUsageEntity", ex);
                throw;
            }
        }
        internal void MapCustomerPaymentEntity()
        {
            try
            {
                Mapper.CreateMap<CustomerPayment, CustomerPaymentEntity>()
                    .ForMember(dest => dest.CustPaymentID, opts => opts.MapFrom(src => src.CustPaymentID))
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID))
                    .ForMember(dest => dest.OutstandingAmount, opts => opts.MapFrom(src => src.OutstandingAmount))
                    .ForMember(dest => dest.Status, opts => opts.MapFrom(src => src.Status))
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapCustomerPaymentEntity", ex);
                throw;
            }
        }
        internal void MapCustomerPartPayDetailsEntity()
        {
            try
            {
                Mapper.CreateMap<CustomerPartPayDetails, CustomerPartPayDetailsEntity>()
                    .ForMember(dest => dest.CustPartPayID, opts => opts.MapFrom(src => src.CustPartPayID))
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID))
                    .ForMember(dest => dest.PaidAmount, opts => opts.MapFrom(src => src.PaidAmount))
                    .ForMember(dest => dest.PaidDate, opts => opts.MapFrom(src => src.PaidDate))
                    .ForMember(dest => dest.NextPayDate, opts => opts.MapFrom(src => src.NextPayDate))
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapCustomerPartPayDetailsEntity", ex);
                throw;
            }
        }
        internal void MapMDrierTypeDetailsEntity()
        {
            try
            {
                Mapper.CreateMap<MDrierTypeDetails, MDrierTypeDetailsEntity>()
                    .ForMember(dest => dest.MDrierTypeID, opts => opts.MapFrom(src => src.MDrierTypeID))
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID))
                    .ForMember(dest => dest.DrierName, opts => opts.MapFrom(src => src.DrierName))
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapMDrierTypeDetailsEntity", ex);
                throw;
            }
        }
        internal void MapMRiceProductionTypeEntity()
        {
            try
            {
                Mapper.CreateMap<MRiceProductionType, MRiceProductionTypeEntity>()
                    .ForMember(dest => dest.MRiceProdTypeID, opts => opts.MapFrom(src => src.MRiceProdTypeID))
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID))
                    .ForMember(dest => dest.RiceType, opts => opts.MapFrom(src => src.RiceType))
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapMRiceProductionTypeEntity", ex);
                throw;
            }
        }
        internal void MapMRiceBrandDetailsEntity()
        {
            try
            {
                Mapper.CreateMap<MRiceBrandDetails, MRiceBrandDetailsEntity>()
                    .ForMember(dest => dest.MRiceBrandID, opts => opts.MapFrom(src => src.MRiceBrandID))
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID))
                    .ForMember(dest => dest.Name, opts => opts.MapFrom(src => src.Name))
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapMapMRiceBrandDetailsEntity", ex);
                throw;
            }
        }
        internal void MapMBrokenRiceTypeEntity()
        {
            try
            {
                Mapper.CreateMap<MBrokenRiceType, MBrokenRiceTypeEntity>()
                    .ForMember(dest => dest.BrokenRiceTypeID, opts => opts.MapFrom(src => src.BrokenRiceTypeID))
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID))
                    .ForMember(dest => dest.BrokenRiceName, opts => opts.MapFrom(src => src.BrokenRiceName))
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapMBrokenRiceTypeEntity", ex);
                throw;
            }
        }
        internal void MapRiceStockInfoEntity()
        {
            try
            {
                Mapper.CreateMap<RiceStockInfo, RiceStockInfoEntity>()
                    .ForMember(dest => dest.RiceStockID, opts => opts.MapFrom(src => src.RiceStockID))
                    .ForMember(dest => dest.RiceTypeID, opts => opts.MapFrom(src => src.RiceTypeID))
                    .ForMember(dest => dest.RiceBrandID, opts => opts.MapFrom(src => src.RiceBrandID))
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID))
                    .ForMember(dest => dest.TotalBags, opts => opts.MapFrom(src => src.TotalBags))
                    .ForMember(dest => dest.WeightUnits, opts => opts.MapFrom(src => src.WeightUnits))
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapRiceStockInfoEntity", ex);
                throw;
            }
        }
        internal void MapBrokenRiceStockInfoEntity()
        {
            try
            {
                Mapper.CreateMap<BrokenRiceStockInfo, BrokenRiceStockInfoEntity>()
                    .ForMember(dest => dest.BrokenRiceStockID, opts => opts.MapFrom(src => src.BrokenRiceStockID))
                    .ForMember(dest => dest.BrokenRiceTypeID, opts => opts.MapFrom(src => src.BrokenRiceTypeID))
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID))
                    .ForMember(dest => dest.TotalBags, opts => opts.MapFrom(src => src.TotalBags))
                    .ForMember(dest => dest.WeightUnits, opts => opts.MapFrom(src => src.WeightUnits))
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapBrokenRiceStockInfoEntity", ex);
                throw;
            }
        }
        internal void MapDustStockInfoEntity()
        {
            try
            {
                Mapper.CreateMap<DustStockInfo, DustStockInfoEntity>()
                    .ForMember(dest => dest.DustStockID, opts => opts.MapFrom(src => src.DustStockID))
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID))
                    .ForMember(dest => dest.TotalBags, opts => opts.MapFrom(src => src.TotalBags))
                    .ForMember(dest => dest.WeightUnits, opts => opts.MapFrom(src => src.WeightUnits))
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapDustStockInfoEntity", ex);
                throw;
            }
        }
        internal void MapRiceSellingInfoEntity()
        {
            try
            {
                Mapper.CreateMap<RiceSellingInfo, RiceSellingInfoEntity>()
                    .ForMember(dest => dest.RiceSellingID, opts => opts.MapFrom(src => src.RiceSellingID))
                    .ForMember(dest => dest.SellerID, opts => opts.MapFrom(src => src.SellerID))
                    .ForMember(dest => dest.RiceTypeID, opts => opts.MapFrom(src => src.RiceTypeID))
                    .ForMember(dest => dest.RiceBrandID, opts => opts.MapFrom(src => src.RiceBrandID))
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID))
                    .ForMember(dest => dest.DriverName, opts => opts.MapFrom(src => src.DriverName))
                    .ForMember(dest => dest.UnitWeight, opts => opts.MapFrom(src => src.UnitWeight))
                    .ForMember(dest => dest.VehicalNo, opts => opts.MapFrom(src => src.VehicalNo))
                    .ForMember(dest => dest.TotalBags, opts => opts.MapFrom(src => src.TotalBags))
                    .ForMember(dest => dest.QWeight, opts => opts.MapFrom(src => src.QWeight))
                    .ForMember(dest => dest.QPrice, opts => opts.MapFrom(src => src.QPrice))
                    .ForMember(dest => dest.SellingDate, opts => opts.MapFrom(src => src.SellingDate))
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapRiceSellingInfoEntity", ex);
                throw;
            }
        }
        internal void MapBrokenRiceSellingInfoEntity()
        {
            try
            {
                Mapper.CreateMap<BrokenRiceSellingInfo, BrokenRiceSellingInfoEntity>()
                    .ForMember(dest => dest.BrokenRiceSellingID, opts => opts.MapFrom(src => src.BrokenRiceSellingID))
                    .ForMember(dest => dest.SellerID, opts => opts.MapFrom(src => src.SellerID))
                    .ForMember(dest => dest.RiceTypeID, opts => opts.MapFrom(src => src.RiceTypeID))
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID))
                    .ForMember(dest => dest.DriverName, opts => opts.MapFrom(src => src.DriverName))
                    .ForMember(dest => dest.UnitWeight, opts => opts.MapFrom(src => src.UnitWeight))
                    .ForMember(dest => dest.VehicalNo, opts => opts.MapFrom(src => src.VehicalNo))
                    .ForMember(dest => dest.TotalBags, opts => opts.MapFrom(src => src.TotalBags))
                    .ForMember(dest => dest.QWeight, opts => opts.MapFrom(src => src.QWeight))
                    .ForMember(dest => dest.QPrice, opts => opts.MapFrom(src => src.QPrice))
                    .ForMember(dest => dest.SellingDate, opts => opts.MapFrom(src => src.SellingDate))
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapBrokenRiceSellingInfoEntity", ex);
                throw;
            }
        }
        internal void MapDustSellingInfoEntity()
        {
            try
            {
                Mapper.CreateMap<DustSellingInfo, DustSellingInfoEntity>()
                    .ForMember(dest => dest.DustSellingID, opts => opts.MapFrom(src => src.DustSellingID))
                    .ForMember(dest => dest.SellerID, opts => opts.MapFrom(src => src.SellerID))                    
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID))
                    .ForMember(dest => dest.DriverName, opts => opts.MapFrom(src => src.DriverName))
                    .ForMember(dest => dest.UnitWeight, opts => opts.MapFrom(src => src.UnitWeight))
                    .ForMember(dest => dest.VehicalNo, opts => opts.MapFrom(src => src.VehicalNo))
                    .ForMember(dest => dest.TotalBags, opts => opts.MapFrom(src => src.TotalBags))
                    .ForMember(dest => dest.QWeight, opts => opts.MapFrom(src => src.QWeight))
                    .ForMember(dest => dest.QPrice, opts => opts.MapFrom(src => src.QPrice))
                    .ForMember(dest => dest.SellingDate, opts => opts.MapFrom(src => src.SellingDate))
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapDustSellingInfoEntity", ex);
                throw;
            }
        }
    }
}
