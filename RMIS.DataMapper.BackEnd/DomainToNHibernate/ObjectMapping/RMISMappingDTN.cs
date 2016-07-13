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

        internal void MapMBagTypeEntityToMBagType()
        {
            try
            {
                Mapper.CreateMap<MBagTypeEntity, MBagType>()
                    .ForMember(dest => dest.BagTypeID, opts => opts.MapFrom(src => src.BagTypeID))
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID))
                    .ForMember(dest => dest.BagType, opts => opts.MapFrom(src => src.BagType))
                    .ForMember(dest => dest.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    ;

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapMBagTypeEntityToMBagType", ex);
                throw;
            }
        }
        internal void MapMUnitsTypeEntityToMUnitsType()
        {
            try
            {
                Mapper.CreateMap<MUnitsTypeEntity, MUnitsType>()
                    .ForMember(dest => dest.UnitsTypeID, opts => opts.MapFrom(src => src.UnitsTypeID))
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID))
                    .ForMember(dest => dest.UnitsType, opts => opts.MapFrom(src => src.UnitsType))
                    .ForMember(dest => dest.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    ;

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapMBagTypeEntityToMBagType", ex);
                throw;
            }
        }

        internal void MapSellerInfoEntityToSellerInfo()
        {
            try
            {
                Mapper.CreateMap<SellerInfoEntity, SellerInfo>()
                    .ForMember(dest => dest.SellerID, opts => opts.MapFrom(src => src.SellerID))
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

        internal void MapMRolesEntityToMRoles()
        {
            try
            {
                Mapper.CreateMap<MRolesEntity, MRoles>()
                    .ForMember(dest => dest.RoleId, opts => opts.MapFrom(src => src.RoleId))
                    .ForMember(dest => dest.RoleName, opts => opts.MapFrom(src => src.RoleName))
                    .ForMember(dest => dest.Description, opts => opts.MapFrom(src => src.Description))
                    .ForMember(dest => dest.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    ;

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapMRolesEntityToMRoles", ex);
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
                    .ForMember(dest => dest.UnitsTypeID, opts => opts.MapFrom(src => src.UnitsTypeID))
                    .ForMember(dest => dest.VehicalNo, opts => opts.MapFrom(src => src.VehicalNo))
                    .ForMember(dest => dest.DriverName, opts => opts.MapFrom(src => src.DriverName))
                    .ForMember(dest => dest.TotalBags, opts => opts.MapFrom(src => src.TotalBags))
                    .ForMember(dest => dest.Price, opts => opts.MapFrom(src => src.Price))
                    .ForMember(dest => dest.PurchaseDate, opts => opts.MapFrom(src => src.PurchaseDate))
                    .ForMember(dest => dest.NextPayDate, opts => opts.MapFrom(src => src.NextPayDate))
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
        internal void MapBagStockInfoEntityToBagStockInfo()
        {
            try
            {
                Mapper.CreateMap<BagStockInfoEntity, BagStockInfo>()
                    .ForMember(dest => dest.BagStockID, opts => opts.MapFrom(src => src.BagStockID))
                    .ForMember(dest => dest.SellerID, opts => opts.MapFrom(src => src.SellerID))                   
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID))
                    .ForMember(dest => dest.UnitsTypeID, opts => opts.MapFrom(src => src.UnitsTypeID))
                    .ForMember(dest => dest.MRiceBrandID, opts => opts.MapFrom(src => src.MRiceBrandID))
                    .ForMember(dest => dest.VehicalNo, opts => opts.MapFrom(src => src.VehicalNo))
                    .ForMember(dest => dest.DriverName, opts => opts.MapFrom(src => src.DriverName))
                    .ForMember(dest => dest.TotalBags, opts => opts.MapFrom(src => src.TotalBags))
                    .ForMember(dest => dest.Price, opts => opts.MapFrom(src => src.Price))
                    .ForMember(dest => dest.PurchaseDate, opts => opts.MapFrom(src => src.PurchaseDate))
                    .ForMember(dest => dest.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    ;

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapBagStockInfoEntityToBagStockInfo", ex);
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
                    .ForMember(dest => dest.PaddyStockID, opts => opts.MapFrom(src => src.PaddyStockID))
                    .ForMember(dest => dest.PaymentMode, opts => opts.MapFrom(src => src.PaymentMode))
                    .ForMember(dest => dest.ChequeNo, opts => opts.MapFrom(src => src.ChequeNo))
                    .ForMember(dest => dest.BankName, opts => opts.MapFrom(src => src.BankName))
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
        internal void MapMBrokenRiceTypeEntityToMBrokenRiceType()
        {
            try
            {
                Mapper.CreateMap<MBrokenRiceTypeEntity, MBrokenRiceType>()
                    .ForMember(dest => dest.BrokenRiceTypeID, opts => opts.MapFrom(src => src.BrokenRiceTypeID))
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID))
                    .ForMember(dest => dest.BrokenRiceName, opts => opts.MapFrom(src => src.BrokenRiceName))
                    .ForMember(dest => dest.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    ;

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapMBrokenRiceTypeEntityToMBrokenRiceType", ex);
                throw;
            }
        }
        internal void MapRiceStockInfoEntityToRiceStockInfo()
        {
            try
            {
                Mapper.CreateMap<RiceStockInfoEntity, RiceStockInfo>()
                    .ForMember(dest => dest.RiceStockID, opts => opts.MapFrom(src => src.RiceStockID))
                    .ForMember(dest => dest.MRiceProdTypeID, opts => opts.MapFrom(src => src.MRiceProdTypeID))
                    .ForMember(dest => dest.MRiceBrandID, opts => opts.MapFrom(src => src.MRiceBrandID))
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID))
                    .ForMember(dest => dest.TotalBags, opts => opts.MapFrom(src => src.TotalBags))
                    .ForMember(dest => dest.UnitsTypeID, opts => opts.MapFrom(src => src.UnitsTypeID))
                    .ForMember(dest => dest.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    ;

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapRiceStockInfoEntityToRiceStockInfo", ex);
                throw;
            }
        }
        internal void MapBrokenRiceStockInfoEntityToBrokenRiceStockInfo()
        {
            try
            {
                Mapper.CreateMap<BrokenRiceStockInfoEntity, BrokenRiceStockInfo>()
                    .ForMember(dest => dest.BrokenRiceStockID, opts => opts.MapFrom(src => src.BrokenRiceStockID))
                    .ForMember(dest => dest.BrokenRiceTypeID, opts => opts.MapFrom(src => src.BrokenRiceTypeID))
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID))
                    .ForMember(dest => dest.TotalBags, opts => opts.MapFrom(src => src.TotalBags))
                    .ForMember(dest => dest.UnitsTypeID, opts => opts.MapFrom(src => src.UnitsTypeID))
                    .ForMember(dest => dest.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    ;

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapBrokenRiceStockInfoEntityToRiceStockInfo", ex);
                throw;
            }
        }
        internal void MapDustStockInfoEntityToDustStockInfo()
        {
            try
            {
                Mapper.CreateMap<DustStockInfoEntity, DustStockInfo>()
                    .ForMember(dest => dest.DustStockID, opts => opts.MapFrom(src => src.DustStockID))
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID))
                    .ForMember(dest => dest.TotalBags, opts => opts.MapFrom(src => src.TotalBags))
                    .ForMember(dest => dest.UnitsTypeID, opts => opts.MapFrom(src => src.UnitsTypeID))
                    .ForMember(dest => dest.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    ;

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapDustStockInfoEntityToDustStockInfo", ex);
                throw;
            }
        }
        

        internal void MapMenuInfoEntityToMenuInfo()
        {
            try
            {
                Mapper.CreateMap<MenuInfoEntity, MenuInfo>()
                    .ForMember(dest => dest.MenuID, opts => opts.MapFrom(src => src.MenuID))
                    .ForMember(dest => dest.ParentMenuID, opts => opts.MapFrom(src => src.ParentMenuID))
                    .ForMember(dest => dest.Title, opts => opts.MapFrom(src => src.Title))
                    .ForMember(dest => dest.Description, opts => opts.MapFrom(src => src.Description))
                    .ForMember(dest => dest.URL, opts => opts.MapFrom(src => src.URL))
                    .ForMember(dest => dest.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    ;

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapMenuInfoEntityToMenuInfo", ex);
                throw;
            }
        }

        internal void MapRMUserRoleEntityToRMUserRole()
        {
            try
            {
                Mapper.CreateMap<RMUserRoleEntity, RMUserRole>()
                    .ForMember(dest => dest.UserRoleId, opts => opts.MapFrom(src => src.UserRoleId))
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID))
                    .ForMember(dest => dest.RoleId, opts => opts.MapFrom(src => src.RoleId))
                    .ForMember(dest => dest.UserID, opts => opts.MapFrom(src => src.UserID))
                    .ForMember(dest => dest.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    ;

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapRMUserRoleEntityToRMUserRole", ex);
                throw;
            }
        }

        internal void MapMenuConfigEntiryToMenuConfig()
        {
            try
            {
                Mapper.CreateMap<MenuConfigurationEntity, MenuConfiguration>()
                    .ForMember(dest => dest.MenuID, opts => opts.MapFrom(src => src.MenuID))
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID))
                    .ForMember(dest => dest.MenuConfigId, opts => opts.MapFrom(src => src.MenuConfigId))
                    .ForMember(dest => dest.RoleId, opts => opts.MapFrom(src => src.RoleId))
                    .ForMember(dest => dest.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    ;

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapMenuInfoEntityToMenuInfo", ex);
                throw;
            }
        }
        internal void MapProductSellingInfoEntityToProductSellingInfo()
        {
            try
            {
                Mapper.CreateMap<ProductSellingInfoEntity, ProductSellingInfo>()
                    .ForMember(dest => dest.ProductID, opts => opts.MapFrom(src => src.ProductID))
                    .ForMember(dest => dest.BuyerID, opts => opts.MapFrom(src => src.BuyerID))
                    .ForMember(dest => dest.MediatorID, opts => opts.MapFrom(src => src.MediatorID))
                    .ForMember(dest => dest.ProductPaymentID, opts => opts.MapFrom(src => src.ProductPaymentID))
                    .ForMember(dest => dest.SellingProductType, opts => opts.MapFrom(src => src.SellingProductType))
                    .ForMember(dest => dest.MRiceProdTypeID, opts => opts.MapFrom(src => src.MRiceProdTypeID))
                    .ForMember(dest => dest.MRiceBrandID, opts => opts.MapFrom(src => src.MRiceBrandID))
                    .ForMember(dest => dest.BrokenRiceTypeID, opts => opts.MapFrom(src => src.BrokenRiceTypeID))
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID))
                    .ForMember(dest => dest.UnitsTypeID, opts => opts.MapFrom(src => src.UnitsTypeID))
                    .ForMember(dest => dest.TotalBags, opts => opts.MapFrom(src => src.TotalBags))
                    .ForMember(dest => dest.Price, opts => opts.MapFrom(src => src.Price))
                    .ForMember(dest => dest.SellingDate, opts => opts.MapFrom(src => src.SellingDate))
                    .ForMember(dest => dest.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    ;

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapProductSellingInfoEntityToRiceSellingInfo", ex);
                throw;
            }
        }
        internal void MapHullingProcessInfoEntityToHullingProcessInfo()
        {
            try
            {
                Mapper.CreateMap<HullingProcessEntity, HullingProcess>()
                    .ForMember(dest => dest.HullingProcessID, opts => opts.MapFrom(src => src.HullingProcessID))
                    .ForMember(dest => dest.PaddyTypeID, opts => opts.MapFrom(src => src.PaddyTypeID))
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID))
                    .ForMember(dest => dest.UnitsTypeID, opts => opts.MapFrom(src => src.UnitsTypeID))
                    .ForMember(dest => dest.MGodownID, opts => opts.MapFrom(src => src.MGodownID))
                    .ForMember(dest => dest.MLotID, opts => opts.MapFrom(src => src.MLotID))
                    .ForMember(dest => dest.TotalBags, opts => opts.MapFrom(src => src.TotalBags))
                    .ForMember(dest => dest.Price, opts => opts.MapFrom(src => src.Price))
                    .ForMember(dest => dest.ProcessDate, opts => opts.MapFrom(src => src.ProcessDate))
                    .ForMember(dest => dest.ProcessedBy, opts => opts.MapFrom(src => src.ProcessedBy))
                    .ForMember(dest => dest.Status, opts => opts.MapFrom(src => src.Status))
                    .ForMember(dest => dest.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    ;

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapHullingProcessInfoEntityToHullingProcessInfo", ex);
                throw;
            }
        }
        internal void MapHullingProcessTranInfoEntityToHullingProcessTranInfo()
        {
            try
            {
                Mapper.CreateMap<HullingProcessTransactionEntity, HullingTransaction>()
                    .ForMember(dest => dest.HullingTransID, opts => opts.MapFrom(src => src.HullingTransID))
                    .ForMember(dest => dest.HullingProcessID, opts => opts.MapFrom(src => src.HullingProcessID))
                    .ForMember(dest => dest.MRiceBrandID, opts => opts.MapFrom(src => src.MRiceBrandID))
                    .ForMember(dest => dest.MRiceProdTypeID, opts => opts.MapFrom(src => src.MRiceProdTypeID))
                    .ForMember(dest => dest.BrokenRiceTypeID, opts => opts.MapFrom(src => src.BrokenRiceTypeID))
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID))
                    .ForMember(dest => dest.UnitsTypeID, opts => opts.MapFrom(src => src.UnitsTypeID))
                    .ForMember(dest => dest.TotalBags, opts => opts.MapFrom(src => src.TotalBags))
                    .ForMember(dest => dest.Price, opts => opts.MapFrom(src => src.Price))
                    .ForMember(dest => dest.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    ;

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapHullingProcessInfoEntityToHullingProcessInfo", ex);
                throw;
            }
        }
        internal void MapHullingProcessExpensesInfoEntityToHullingProcessExpensesInfo()
        {
            try
            {
                Mapper.CreateMap<HullingProcessExpensesEntity, HullingProcessExpenses>()
                    .ForMember(dest => dest.HullingProcessExpenID, opts => opts.MapFrom(src => src.HullingProcessExpenID))
                    .ForMember(dest => dest.HullingProcessID, opts => opts.MapFrom(src => src.HullingProcessID))
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID))
                    .ForMember(dest => dest.HullingExpenses, opts => opts.MapFrom(src => src.HullingExpenses))
                    .ForMember(dest => dest.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    ;

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapHullingProcessExpensesInfoEntityToHullingProcessExpensesInfo", ex);
                throw;
            }
        }
        internal void MapBuyerSellerRatingEntityToBuyerSellerRating()
        {
            try
            {
                Mapper.CreateMap<BuyerSellerRatingEntity, BuyerSellerRating>()
                    .ForMember(dest => dest.BRMSID, opts => opts.MapFrom(src => src.BRMSID))
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID))
                    .ForMember(dest => dest.SellerID, opts => opts.MapFrom(src => src.SellerID))
                    .ForMember(dest => dest.Rating, opts => opts.MapFrom(src => src.Rating))
                    .ForMember(dest => dest.Remarks, opts => opts.MapFrom(src => src.Remarks))
                    .ForMember(dest => dest.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    ;

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapBuyerSellerRatingEntityToBuyerSellerRating", ex);
                throw;
            }
        }
        internal void MapBuyerInfoEntityToBuyerInfo()
        {
            try
            {
                Mapper.CreateMap<BuyerInfoEntity, BuyerInfo>()
                    .ForMember(dest => dest.BuyerID, opts => opts.MapFrom(src => src.BuyerID))
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
                Logger.Error("Error encountered at MapBuyerInfoEntityToBuyerInfo", ex);
                throw;
            }
        }
        internal void MapMEmployeeDesignationEntityToMEmployeeDesignation()
        {
            try
            {
                Mapper.CreateMap<MEmployeeDesignationEntity, MEmployeeDesignation>()
                    .ForMember(dest => dest.MEmpDsgID, opts => opts.MapFrom(src => src.MEmpDsgID))
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID))
                    .ForMember(dest => dest.DesignationType, opts => opts.MapFrom(src => src.DesignationType))
                    .ForMember(dest => dest.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    ;

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MEmployeeDesignationEntityToMEmployeeDesignation", ex);
                throw;
            }
        }
        internal void MapMSalaryTypeEntityToMSalaryType()
        {
            try
            {
                Mapper.CreateMap<MSalaryTypeEntity, MSalaryType>()
                    .ForMember(dest => dest.MSalaryTypeID, opts => opts.MapFrom(src => src.MSalaryTypeID))
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID))
                    .ForMember(dest => dest.Salarytype, opts => opts.MapFrom(src => src.Salarytype))
                    .ForMember(dest => dest.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    ;

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapMSalaryTypeEntityToMSalaryType", ex);
                throw;
            }
        }
        internal void MapEmployeeDetailsEntityToEmployeeDetails()
        {
            try
            {
                Mapper.CreateMap<EmployeeDetailsEntity, EmployeeDetails>()
                    .ForMember(dest => dest.EmployeeID, opts => opts.MapFrom(src => src.EmployeeID))
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
                Logger.Error("Error encountered at MapEmployeeDetailsEntityToEmployeeDetails", ex);
                throw;
            }
        }
        internal void MapEmployeeSalaryEntityToEmployeeSalary()
        {
            try
            {
                Mapper.CreateMap<EmployeeSalaryEntity, EmployeeSalary>()
                    .ForMember(dest => dest.EmpSalaryID, opts => opts.MapFrom(src => src.EmpSalaryID))
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID))
                    .ForMember(dest => dest.EmployeeID, opts => opts.MapFrom(src => src.EmployeeID))
                    .ForMember(dest => dest.MEmpDsgID, opts => opts.MapFrom(src => src.MEmpDsgID))
                    .ForMember(dest => dest.MSalaryTypeID, opts => opts.MapFrom(src => src.MSalaryTypeID))
                    .ForMember(dest => dest.Salary, opts => opts.MapFrom(src => src.Salary))
                    .ForMember(dest => dest.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapEmployeeSalaryEntityToEmployeeSalary", ex);
                throw;
            }
        }
        internal void MapEmployeeSalaryPaymentEntityToEmployeeSalaryPayment()
        {
            try
            {
                Mapper.CreateMap<EmployeeSalaryPaymentEntity, MoneyTransaction>()
                    .ForMember(dest => dest.ExpTranID, opts => opts.MapFrom(src => src.ExpTranID))
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID))
                    .ForMember(dest => dest.EmployeeID, opts => opts.MapFrom(src => src.EmployeeID))
                    .ForMember(dest => dest.MEmpDsgID, opts => opts.MapFrom(src => src.MEmpDsgID))
                    .ForMember(dest => dest.MSalaryTypeID, opts => opts.MapFrom(src => src.MSalaryTypeID))
                    .ForMember(dest => dest.Salary, opts => opts.MapFrom(src => src.Salary))
                    .ForMember(dest => dest.GivenTo, opts => opts.MapFrom(src => src.GivenTo))
                    .ForMember(dest => dest.Description, opts => opts.MapFrom(src => src.Description))
                    .ForMember(dest => dest.AmountSpent, opts => opts.MapFrom(src => src.AmountSpent))
                    .ForMember(dest => dest.ExtraCharges, opts => opts.MapFrom(src => src.ExtraCharges))
                    .ForMember(dest => dest.PaymentDate, opts => opts.MapFrom(src => src.PaymentDate))
                    .ForMember(dest => dest.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapEmployeeSalaryPaymentEntityToEmployeeSalaryPayment", ex);
                throw;
            }
        }
        internal void MapOtherExpensesEntityToMoneytransaction()
        {
            try
            {
                Mapper.CreateMap<OtherExpensesEntity, MoneyTransaction>()
                    .ForMember(dest => dest.ExpTranID, opts => opts.MapFrom(src => src.ExpTranID))
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID))
                    .ForMember(dest => dest.GivenTo, opts => opts.MapFrom(src => src.GivenTo))
                    .ForMember(dest => dest.Description, opts => opts.MapFrom(src => src.Description))
                    .ForMember(dest => dest.AmountSpent, opts => opts.MapFrom(src => src.AmountSpent))
                    .ForMember(dest => dest.PaymentDate, opts => opts.MapFrom(src => src.PaymentDate))
                    .ForMember(dest => dest.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapOtherExpensesEntityToMoneytransaction", ex);
                throw;
            }
        }
        internal void MapProductPaymentInfoEntityToProductPaymentInfo()
        {
            try
            {
                Mapper.CreateMap<ProductPaymentInfoEntity, ProductPaymentInfo>()
                    .ForMember(dest => dest.ProductPaymentID, opts => opts.MapFrom(src => src.ProductPaymentID))
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID))
                    .ForMember(dest => dest.BuyerID, opts => opts.MapFrom(src => src.BuyerID))
                    .ForMember(dest => dest.MediatorID, opts => opts.MapFrom(src => src.MediatorID))
                    .ForMember(dest => dest.TotalAmount, opts => opts.MapFrom(src => src.TotalAmount))
                    .ForMember(dest => dest.Status, opts => opts.MapFrom(src => src.Status))
                    .ForMember(dest => dest.NextPayDate, opts => opts.MapFrom(src => src.NextPayDate))
                    .ForMember(dest => dest.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapProductPaymentInfoEntityToProductPaymentInfo", ex);
                throw;
            }
        }
        internal void MapProductPaymentTranEntityToProductPaymentTran()
        {
            try
            {
                Mapper.CreateMap<ProductPaymentTransactionEntity, ProductPaymentTransaction>()
                    .ForMember(dest => dest.ProductPaymentTranID, opts => opts.MapFrom(src => src.ProductPaymentTranID))
                    .ForMember(dest => dest.ProductPaymentID, opts => opts.MapFrom(src => src.ProductPaymentID))
                     .ForMember(dest => dest.BuyerID , opts => opts.MapFrom(src => src.BuyerID ))
                     .ForMember(dest => dest.MediatorID, opts => opts.MapFrom(src => src.MediatorID))
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID))
                    .ForMember(dest => dest.Paymentmode, opts => opts.MapFrom(src => src.Paymentmode))
                    .ForMember(dest => dest.ChequeNo, opts => opts.MapFrom(src => src.ChequeNo))
                    .ForMember(dest => dest.DDNo, opts => opts.MapFrom(src => src.DDNo))
                    .ForMember(dest => dest.BankName, opts => opts.MapFrom(src => src.BankName))
                    .ForMember(dest => dest.ReceivedAmount, opts => opts.MapFrom(src => src.ReceivedAmount))
                    .ForMember(dest => dest.PaymentDueDate, opts => opts.MapFrom(src => src.PaymentDueDate))
                    .ForMember(dest => dest.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapProductPaymentTranEntityToProductPaymentTran", ex);
                throw;
            }
        }
        internal void MapBagPaymentDetailsEntityToBagPaymentDetails()
        {
            try
            {
                Mapper.CreateMap<BagPaymentInfoEntity, BagPaymentInfo>()
                    .ForMember(dest => dest.BagPaymentID, opts => opts.MapFrom(src => src.BagPaymentID))
                    .ForMember(dest => dest.SellerID, opts => opts.MapFrom(src => src.SellerID))
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID))
                    .ForMember(dest => dest.AmountPaid, opts => opts.MapFrom(src => src.AmountPaid))
                    .ForMember(dest => dest.PaidDate, opts => opts.MapFrom(src => src.PaidDate))
                    .ForMember(dest => dest.HandoverTo, opts => opts.MapFrom(src => src.HandoverTo))
                    .ForMember(dest => dest.NextPaymentDate, opts => opts.MapFrom(src => src.NextPaymentDate))
                    .ForMember(dest => dest.PaymentMode, opts => opts.MapFrom(src => src.PaymentMode))
                    .ForMember(dest => dest.ChequeNo, opts => opts.MapFrom(src => src.ChequeNo))
                    .ForMember(dest => dest.BankName, opts => opts.MapFrom(src => src.BankName))
                    .ForMember(dest => dest.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    ;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapBagPaymentDetailsEntityToBagPaymentDetails", ex);
                throw;
            }
        }

        internal void MapMessageInfoEntityToMessageInfo()
        {
            try
            {
                Mapper.CreateMap<MessageInfoEntity, MessageInfo>()
                    .ForMember(dest => dest.MessageTypeID, opts => opts.MapFrom(src => src.MessageTypeID))
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID))
                    .ForMember(dest => dest.MessageCode, opts => opts.MapFrom(src => src.MessageCode))
                    .ForMember(dest => dest.Message, opts => opts.MapFrom(src => src.Message))
                    .ForMember(dest => dest.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    ;

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapMBagTypeEntityToMBagType", ex);
                throw;
            }
        }
        internal void MapMediatorInfoEntityToMediatorInfo()
        {
            try
            {
                Mapper.CreateMap<MediatorInfoEntity, MediatorInfo>()
                    .ForMember(dest => dest.MediatorID, opts => opts.MapFrom(src => src.MediatorID))
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
                Logger.Error("Error encountered at MapMediatorInfoEntityToMediatorInfo", ex);
                throw;
            }
        }
        internal void MapMExpenseTypeEntityToMExpenseType()
        {
            try
            {
                Mapper.CreateMap<MExpenseTypeEntity, MExpenseType>()
                    .ForMember(dest => dest.ExpenseID, opts => opts.MapFrom(src => src.ExpenseID))
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID))
                    .ForMember(dest => dest.ExpenseType, opts => opts.MapFrom(src => src.ExpenseType))
                    .ForMember(dest => dest.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapMExpenseTypeEntityToMExpenseType", ex);
                throw;
            }
        }
        internal void MapExpenseTranEntityToExpenseTran()
        {
            try
            {
                Mapper.CreateMap<ExpenseTransactionEntity, ExpenseTransaction>()
                    .ForMember(dest => dest.ExpenseTransID, opts => opts.MapFrom(src => src.ExpenseTransID))
                    .ForMember(dest => dest.ExpenseID, opts => opts.MapFrom(src => src.ExpenseID))
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID))
                    .ForMember(dest => dest.Name, opts => opts.MapFrom(src => src.Name))
                    .ForMember(dest => dest.Amount, opts => opts.MapFrom(src => src.Amount))
                    .ForMember(dest => dest.Reason, opts => opts.MapFrom(src => src.Reason))
                    .ForMember(dest => dest.PayDate, opts => opts.MapFrom(src => src.PayDate))
                    .ForMember(dest => dest.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapExpenseTranEntityToExpenseTran", ex);
                throw;
            }
        }
        internal void MapMJobWorkEntityToMJobWorkType()
        {
            try
            {
                Mapper.CreateMap<MJobWorkEntity, MJobWork>()
                    .ForMember(dest => dest.JobWorkID, opts => opts.MapFrom(src => src.JobWorkID))
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID))
                    .ForMember(dest => dest.JobWorkType, opts => opts.MapFrom(src => src.JobWorkType))
                    .ForMember(dest => dest.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapMJobWorkEntityToMJobWorkType", ex);
                throw;
            }
        }
        internal void MapRentHullingEntityToRentHulling()
        {
            try
            {
                Mapper.CreateMap<RentalHullingEntity, RentalHulling>()
                    .ForMember(dest => dest.RentalHulingID, opts => opts.MapFrom(src => src.RentalHulingID))
                    .ForMember(dest => dest.JobWorkID, opts => opts.MapFrom(src => src.JobWorkID))
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID))
                    .ForMember(dest => dest.Name, opts => opts.MapFrom(src => src.Name))
                    .ForMember(dest => dest.PaddyType, opts => opts.MapFrom(src => src.PaddyType))
                    .ForMember(dest => dest.TotalBags, opts => opts.MapFrom(src => src.TotalBags))
                    .ForMember(dest => dest.Price, opts => opts.MapFrom(src => src.Price))
                    .ForMember(dest => dest.ProcessedDate, opts => opts.MapFrom(src => src.ProcessedDate))
                    .ForMember(dest => dest.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapRentHullingEntityToRentHulling", ex);
                throw;
            }
        }

        internal void MapBankTransactionEntityToBankTransaction()
        {
            try
            {
                Mapper.CreateMap<BankTransactionEntity, BankTransaction>()
                    .ForMember(dest => dest.BankTransID, opts => opts.MapFrom(src => src.BankTransID))
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID))
                    .ForMember(dest => dest.TransactionDate, opts => opts.MapFrom(src => src.TransactionDate))
                    .ForMember(dest => dest.Withdraw, opts => opts.MapFrom(src => src.Withdraw))
                    .ForMember(dest => dest.Deposit, opts => opts.MapFrom(src => src.Deposit))
                    .ForMember(dest => dest.Balance, opts => opts.MapFrom(src => src.Balance))
                    .ForMember(dest => dest.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapBankTransactionEntityToBankTransaction", ex);
                throw;
            }
        }

    }
}
