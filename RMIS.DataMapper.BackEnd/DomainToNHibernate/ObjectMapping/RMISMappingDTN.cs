using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;


//using RMIS.DataMapper.BackEnd.Utilities;
using log4net;
using RMIS.Entities.BackEnd;
using RMIS.Domain.RiceMill;
using RMIS.Entities.BackEnd;
using RMIS.DataMapper.BackEnd.Utilities;

namespace RMIS.DataMapper.BackEnd.DomainToNHibernate.ObjectMapping
{
    internal class RMISMappingDTN
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(RMISMappingDTN));

        #endregion Fields

        internal void MapSellerTypeEntityToSellerType()
        {
            try
            {
                Mapper.CreateMap<SellerTypeEntity, MSellerType>()
                    .ForMember(dest => dest.SellerTypeID, opts => opts.MapFrom(src => src.SellerTypeID))
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID ))
                    .ForMember(dest => dest.SellerType, opts => opts.MapFrom(src => src.SellerType))
                    .ForMember(dest => dest.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    ;

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapSellerTypeEntityToSellerType", ex);
                throw;
            }
        }

        internal void MapSellerInfoEntityToSellerInfo()
        {
            try
            {
                Mapper.CreateMap<SellerInfoEntity, SellerInfo>()
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
                    .ForMember(dest => dest.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    ;

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapSellerInfoEntityToSellerInfo", ex);
                throw;
            }
        }
        internal void MapCustomerInfoEntityToCustomerInfo()
        {
            try
            {
                Mapper.CreateMap<CustomerInfoEntity, CustomerInfo>()
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID))
                    .ForMember(dest => dest.Name, opts => opts.MapFrom(src => src.Name))
                    .ForMember(dest => dest.OrganizationName, opts => opts.MapFrom(src => src.OrganizationName))
                    .ForMember(dest => dest.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    ;

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapCustomerInfoEntityToCustomerInfo", ex);
                throw;
            }
        }
        internal void MapMUserTypeEntityToMUserType()
        {
            try
            {
                Mapper.CreateMap<MUserTypeEntity, MUserType>()
                    .ForMember(dest => dest.UserTypeID, opts => opts.MapFrom(src => src.UserTypeID))
                    .ForMember(dest => dest.UserType, opts => opts.MapFrom(src => src.UserType))
                    .ForMember(dest => dest.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    ;

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapMUserTypeEntityToMUserType", ex);
                throw;
            }
        }
        internal void MapUsersEntityToUsers()
        {
            try
            {
                Mapper.CreateMap<UsersEntity, Users>()
                    .ForMember(dest => dest.UserID, opts => opts.MapFrom(src => src.UserID))
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID))
                    .ForMember(dest => dest.UserTypeID, opts => opts.MapFrom(src => src.UserTypeID))
                    .ForMember(dest => dest.Name, opts => opts.MapFrom(src => src.Name))
                    .ForMember(dest => dest.PassWord, opts => opts.MapFrom(src => src.PassWord))
                    .ForMember(dest => dest.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    ;

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapUsersEntityToUsers", ex);
                throw;
            }
        }
        internal void MapMPaddyTypeEntityToMPaddyType()
        {
            try
            {
                Mapper.CreateMap<MPaddyTypeEntity, MPaddyType>()
                    .ForMember(dest => dest.PaddyTypeID, opts => opts.MapFrom(src => src.PaddyTypeID))
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID))
                    .ForMember(dest => dest.Name, opts => opts.MapFrom(src => src.Name))
                    .ForMember(dest => dest.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    ;

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapMPaddyTypeEntityToMPaddyType", ex);
                throw;
            }
        }
        internal void MapPaddyStockInfoEntityToPaddyStockInfo()
        {
            try
            {
                Mapper.CreateMap<PaddyStockInfoEntity, PaddyStockInfo>()
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
                    .ForMember(dest => dest.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    ;

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapPaddyStockInfoEntityToPaddyStockInfo", ex);
                throw;
            }
        }
        internal void MapMLotDetailsEntityToMLotDetails()
        {
            try
            {
                Mapper.CreateMap<MLotDetailsEntity, MLotDetails>()
                    .ForMember(dest => dest.MLotID, opts => opts.MapFrom(src => src.MLotID))
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID))
                    .ForMember(dest => dest.LotName, opts => opts.MapFrom(src => src.LotName))
                    .ForMember(dest => dest.MGodownID, opts => opts.MapFrom(src => src.MGodownID))
                    .ForMember(dest => dest.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    ;

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapMLotDetailsEntityToMLotDetails", ex);
                throw;
            }
        }
        internal void MapMGodownDetailsEntityToMGodownDetails()
        {
            try
            {
                Mapper.CreateMap<MGodownDetailsEntity, MGodownDetails>()
                    .ForMember(dest => dest.MGodownID, opts => opts.MapFrom(src => src.MGodownID))
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID))
                    .ForMember(dest => dest.Place, opts => opts.MapFrom(src => src.Place))
                    .ForMember(dest => dest.Name, opts => opts.MapFrom(src => src.Name))
                    .ForMember(dest => dest.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    ;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapMGodownDetailsEntityToMGodownDetails", ex);
                throw;
            }
        }
        internal void MapPaddyPaymentDetailsEntityToPaddyPaymentDetails()
        {
            try
            {
                Mapper.CreateMap<PaddyPaymentDetailsEntity, PaddyPaymentDetails>()
                    .ForMember(dest => dest.PaddyPaymentID, opts => opts.MapFrom(src => src.PaddyPaymentID))
                    .ForMember(dest => dest.SellerID, opts => opts.MapFrom(src => src.SellerID))
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID))
                    .ForMember(dest => dest.AmountPaid, opts => opts.MapFrom(src => src.AmountPaid))
                    .ForMember(dest => dest.PaidDate, opts => opts.MapFrom(src => src.PaidDate))
                    .ForMember(dest => dest.HandoverTo, opts => opts.MapFrom(src => src.HandoverTo))
                    .ForMember(dest => dest.NextPaymentDate, opts => opts.MapFrom(src => src.NextPaymentDate))
                    .ForMember(dest => dest.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    ;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapPaddyPaymentDetailsEntityToPaddyPaymentDetails", ex);
                throw;
            }
        }
        internal void MapMWeightDetailsEntityToMWeightDetails()
        {
            try
            {
                Mapper.CreateMap<MWeightDetailsEntity, MWeightDetails>()
                    .ForMember(dest => dest.MWeightID, opts => opts.MapFrom(src => src.MWeightID))
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID))
                    .ForMember(dest => dest.Weight, opts => opts.MapFrom(src => src.Weight))
                    .ForMember(dest => dest.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    ;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapMWeightDetailsEntityToMWeightDetails", ex);
                throw;
            }
        }
        internal void MapCustomerAddressInfoEntityToCustomerAddressInfo()
        {
            try
            {
                Mapper.CreateMap<CustomerAddressInfoEntity, CustomerAddressInfo>()
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
                    .ForMember(dest => dest.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    ;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapCustomerAddressInfoEntityToCustomerAddressInfo", ex);
                throw;
            }
        }
        internal void MapCustomerActivationEntityToCustomerActivation()
        {
            try
            {
                Mapper.CreateMap<CustomerActivationEntity, CustomerActivation>()
                    .ForMember(dest => dest.CustActiveID, opts => opts.MapFrom(src => src.CustActiveID))
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID))
                    .ForMember(dest => dest.ApplicationStartDate, opts => opts.MapFrom(src => src.ApplicationStartDate))
                    .ForMember(dest => dest.ApplicationEndDate, opts => opts.MapFrom(src => src.ApplicationEndDate))
                    .ForMember(dest => dest.Status, opts => opts.MapFrom(src => src.Status))
                    .ForMember(dest => dest.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    ;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapCustomerActivationEntityToCustomerActivation", ex);
                throw;
            }
        }
        internal void MapCustTrailUsageEntityToCustTrailUsage()
        {
            try
            {
                Mapper.CreateMap<CustTrailUsageEntity, CustTrailUsage>()
                    .ForMember(dest => dest.CustTrailID, opts => opts.MapFrom(src => src.CustTrailID))
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID))
                    .ForMember(dest => dest.TrailStartDate, opts => opts.MapFrom(src => src.TrailStartDate))
                    .ForMember(dest => dest.TrailEndDate, opts => opts.MapFrom(src => src.TrailEndDate))                    
                    .ForMember(dest => dest.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    ;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapCustTrailUsageEntityToCustTrailUsage", ex);
                throw;
            }
        }
        internal void MapCustomerPaymentEntityToCustomerPayment()
        {
            try
            {
                Mapper.CreateMap<CustomerPaymentEntity, CustomerPayment>()
                    .ForMember(dest => dest.CustPaymentID, opts => opts.MapFrom(src => src.CustPaymentID))
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID))
                    .ForMember(dest => dest.OutstandingAmount, opts => opts.MapFrom(src => src.OutstandingAmount))                    
                    .ForMember(dest => dest.Status, opts => opts.MapFrom(src => src.Status))
                    .ForMember(dest => dest.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    ;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapCustomerPaymentEntityToCustomerPayment", ex);
                throw;
            }
        }
        internal void MapCustomerPartPayDetailsEntityToCustomerPartPayDetails()
        {
            try
            {
                Mapper.CreateMap<CustomerPartPayDetailsEntity, CustomerPartPayDetails>()
                    .ForMember(dest => dest.CustPartPayID, opts => opts.MapFrom(src => src.CustPartPayID))
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID))
                    .ForMember(dest => dest.PaidAmount, opts => opts.MapFrom(src => src.PaidAmount))
                    .ForMember(dest => dest.PaidDate, opts => opts.MapFrom(src => src.PaidDate))
                    .ForMember(dest => dest.NextPayDate, opts => opts.MapFrom(src => src.NextPayDate))
                    .ForMember(dest => dest.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    ;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapCustomerPartPayDetailsEntityToCustomerPartPayDetails", ex);
                throw;
            }
        }
        internal void MapMDrierTypeDetailsEntityToMDrierTypeDetails()
        {
            try
            {
                Mapper.CreateMap<MDrierTypeDetailsEntity, MDrierTypeDetails>()
                    .ForMember(dest => dest.MDrierTypeID, opts => opts.MapFrom(src => src.MDrierTypeID))
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID))
                    .ForMember(dest => dest.DrierName, opts => opts.MapFrom(src => src.DrierName))                    
                    .ForMember(dest => dest.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    ;

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapMDrierTypeDetailsEntityToMDrierTypeDetails", ex);
                throw;
            }
        }
        internal void MapMRiceProductionTypeEntityToMRiceProductionType()
        {
            try
            {
                Mapper.CreateMap<MRiceProductionTypeEntity, MRiceProductionType>()
                    .ForMember(dest => dest.MRiceProdTypeID, opts => opts.MapFrom(src => src.MRiceProdTypeID))
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID))
                    .ForMember(dest => dest.RiceType, opts => opts.MapFrom(src => src.RiceType))
                    .ForMember(dest => dest.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    ;

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapMRiceProductionTypeEntityToMRiceProductionType", ex);
                throw;
            }
        }
        internal void MapMRiceBrandDetailsEntityToMRiceBrandDetails()
        {
            try
            {
                Mapper.CreateMap<MRiceBrandDetailsEntity, MRiceBrandDetails>()
                    .ForMember(dest => dest.MRiceBrandID, opts => opts.MapFrom(src => src.MRiceBrandID))
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID))
                    .ForMember(dest => dest.Name, opts => opts.MapFrom(src => src.Name))
                    .ForMember(dest => dest.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    ;

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapMRiceBrandDetailsEntityToMRiceBrandDetails", ex);
                throw;
            }
        }

    }
}
