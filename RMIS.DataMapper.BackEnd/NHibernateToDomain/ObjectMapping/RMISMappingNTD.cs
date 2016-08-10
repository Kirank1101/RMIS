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
        internal void MapMessageInfoEntity()
        {
            try
            {
                Mapper.CreateMap<MessageInfo, MessageInfoEntity>()
                    .ForMember(dest => dest.MessageTypeID, opts => opts.MapFrom(src => src.MessageTypeID))
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID))
                    .ForMember(dest => dest.MessageCode, opts => opts.MapFrom(src => src.MessageCode))
                    .ForMember(dest => dest.Message, opts => opts.MapFrom(src => src.Message))
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapMessageInfoEntity", ex);
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
                    .ForMember(dest => dest.EmailId, opts => opts.MapFrom(src => src.EmailId))
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
                    .ForMember(dest => dest.Name, opts => opts.MapFrom(src => src.Name))
                    .ForMember(dest => dest.PassWord, opts => opts.MapFrom(src => src.PassWord))
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                     .ForMember(dest => dest.EmailId, opts => opts.MapFrom(src => src.EmailId))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapUserEntity", ex);
                throw;
            }
        }

        internal void MapMailQueueEntity()
        {
            try
            {
                Mapper.CreateMap<MailQueue, MailQueueEntity>()
                    .ForMember(dest => dest.MailId, opts => opts.MapFrom(src => src.MailId))
                    .ForMember(dest => dest.MessageBody, opts => opts.MapFrom(src => src.MessageBody))
                    .ForMember(dest => dest.Subject, opts => opts.MapFrom(src => src.Subject))
                    .ForMember(dest => dest.ToEmail, opts => opts.MapFrom(src => src.ToEmail))
                    .ForMember(dest => dest.FromEmail, opts => opts.MapFrom(src => src.FromEmail))
                    .ForMember(dest => dest.Status, opts => opts.MapFrom(src => src.Status))
                     .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate)
                    );
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapMailQueueEntity", ex);
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
                    .ForMember(dest => dest.UnitsTypeID, opts => opts.MapFrom(src => src.UnitsTypeID))
                    .ForMember(dest => dest.VehicalNo, opts => opts.MapFrom(src => src.VehicalNo))
                    .ForMember(dest => dest.DriverName, opts => opts.MapFrom(src => src.DriverName))
                    .ForMember(dest => dest.TotalBags, opts => opts.MapFrom(src => src.TotalBags))
                    .ForMember(dest => dest.Price, opts => opts.MapFrom(src => src.Price))
                    .ForMember(dest => dest.PurchaseDate, opts => opts.MapFrom(src => src.PurchaseDate))
                    .ForMember(dest => dest.NextPayDate, opts => opts.MapFrom(src => src.NextPayDate))
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    .ForMember(dest => dest.AllBagsUsed, opts => opts.MapFrom(src => src.AllBagsUsed))
                    .ForMember(dest => dest.PriceAdjust, opts => opts.MapFrom(src => src.PriceAdjust))
                    .ForMember(dest => dest.UsedBags, opts => opts.MapFrom(src => src.UsedBags));
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
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID))
                    .ForMember(dest => dest.UnitsTypeID, opts => opts.MapFrom(src => src.UnitsTypeID))
                    .ForMember(dest => dest.MRiceBrandID, opts => opts.MapFrom(src => src.MRiceBrandID))
                    .ForMember(dest => dest.VehicalNo, opts => opts.MapFrom(src => src.VehicalNo))
                    .ForMember(dest => dest.DriverName, opts => opts.MapFrom(src => src.DriverName))
                    .ForMember(dest => dest.TotalBags, opts => opts.MapFrom(src => src.TotalBags))
                    .ForMember(dest => dest.Price, opts => opts.MapFrom(src => src.Price))
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
                    .ForMember(dest => dest.PaddyStockID, opts => opts.MapFrom(src => src.PaddyStockID))
                    .ForMember(dest => dest.PaymentMode, opts => opts.MapFrom(src => src.PaymentMode))
                    .ForMember(dest => dest.ChequeNo, opts => opts.MapFrom(src => src.ChequeNo))
                    .ForMember(dest => dest.BankName, opts => opts.MapFrom(src => src.BankName))
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
                    .ForMember(dest => dest.TINNumber, opts => opts.MapFrom(src => src.TINNumber))
                    .ForMember(dest => dest.MillName, opts => opts.MapFrom(src => src.MillName))
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
                    .ForMember(dest => dest.MRiceProdTypeID, opts => opts.MapFrom(src => src.MRiceProdTypeID))
                    .ForMember(dest => dest.MRiceBrandID, opts => opts.MapFrom(src => src.MRiceBrandID))
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID))
                    .ForMember(dest => dest.TotalBags, opts => opts.MapFrom(src => src.TotalBags))
                    .ForMember(dest => dest.UnitsTypeID, opts => opts.MapFrom(src => src.UnitsTypeID))
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
                    .ForMember(dest => dest.UnitsTypeID, opts => opts.MapFrom(src => src.UnitsTypeID))
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
                    .ForMember(dest => dest.UnitsTypeID, opts => opts.MapFrom(src => src.UnitsTypeID))
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

        internal void MapMenuInfoToMenuInfoEntity()
        {
            try
            {
                Mapper.CreateMap<MenuInfo, MenuInfoEntity>()
                    .ForMember(dest => dest.MenuID, opts => opts.MapFrom(src => src.MenuID))
                    .ForMember(dest => dest.ParentMenuID, opts => opts.MapFrom(src => src.ParentMenuID))
                    .ForMember(dest => dest.Title, opts => opts.MapFrom(src => src.Title))
                    .ForMember(dest => dest.Description, opts => opts.MapFrom(src => src.Description))
                    .ForMember(dest => dest.URL, opts => opts.MapFrom(src => src.URL))
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    ;

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapMenuInfoToMenuInfoEntity", ex);
                throw;
            }
        }


        internal void MapMenuConfigurationToMenuConfigurationEntity()
        {
            try
            {
                Mapper.CreateMap<MenuConfiguration, MenuConfigurationEntity>()
                    .ForMember(dest => dest.MenuID, opts => opts.MapFrom(src => src.MenuID))
                    .ForMember(dest => dest.MenuConfigId, opts => opts.MapFrom(src => src.MenuConfigId))
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID))
                    .ForMember(dest => dest.RoleId, opts => opts.MapFrom(src => src.RoleId))
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    ;

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapMenuConfigurationToMenuConfigurationEntity", ex);
                throw;
            }
        }

        internal void MapProductSellingInfoEntity()
        {
            try
            {
                Mapper.CreateMap<ProductSellingInfo, ProductSellingInfoEntity>()
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
                    .ForMember(dest => dest.DriverName, opts => opts.MapFrom(src => src.DriverName))
                    .ForMember(dest => dest.VehicalNo, opts => opts.MapFrom(src => src.VehicalNo))
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapProductSellingInfoEntity", ex);
                throw;
            }
        }
        internal void MapHullingProcessInfoEntity()
        {
            try
            {
                Mapper.CreateMap<HullingProcess, HullingProcessEntity>()
                    .ForMember(dest => dest.HullingProcessID, opts => opts.MapFrom(src => src.HullingProcessID))
                    .ForMember(dest => dest.PaddyTypeID, opts => opts.MapFrom(src => src.PaddyTypeID))
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID))
                    .ForMember(dest => dest.UnitsTypeID, opts => opts.MapFrom(src => src.UnitsTypeID))
                    .ForMember(dest => dest.MGodownID, opts => opts.MapFrom(src => src.MGodownID))
                    .ForMember(dest => dest.MLotID, opts => opts.MapFrom(src => src.MLotID))
                    .ForMember(dest => dest.TotalBags, opts => opts.MapFrom(src => src.TotalBags))
                    .ForMember(dest => dest.Status, opts => opts.MapFrom(src => src.Status))
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapHullingProcessInfoEntity", ex);
                throw;
            }
        }
        internal void MapHullingProcessTransInfoEntity()
        {
            try
            {
                Mapper.CreateMap<HullingTransaction, HullingProcessTransactionEntity>()
                    .ForMember(dest => dest.HullingTransID, opts => opts.MapFrom(src => src.HullingTransID))
                    .ForMember(dest => dest.HullingProcessID, opts => opts.MapFrom(src => src.HullingProcessID))
                    .ForMember(dest => dest.MRiceBrandID, opts => opts.MapFrom(src => src.MRiceBrandID))
                    .ForMember(dest => dest.MRiceProdTypeID, opts => opts.MapFrom(src => src.MRiceProdTypeID))
                    .ForMember(dest => dest.BrokenRiceTypeID, opts => opts.MapFrom(src => src.BrokenRiceTypeID))
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID))
                    .ForMember(dest => dest.UnitsTypeID, opts => opts.MapFrom(src => src.UnitsTypeID))
                    .ForMember(dest => dest.Price, opts => opts.MapFrom(src => src.Price))
                    .ForMember(dest => dest.TotalBags, opts => opts.MapFrom(src => src.TotalBags))
                    .ForMember(dest => dest.Price, opts => opts.MapFrom(src => src.Price))
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapHullingProcessTransInfoEntity", ex);
                throw;
            }

        }

        internal void MapMRolesToMRolesEntity()
        {
            try
            {
                Mapper.CreateMap<MRoles, MRolesEntity>()
                    .ForMember(dest => dest.RoleId, opts => opts.MapFrom(src => src.RoleId))
                    .ForMember(dest => dest.RoleName, opts => opts.MapFrom(src => src.RoleName))
                    .ForMember(dest => dest.Description, opts => opts.MapFrom(src => src.Description))
                     .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    ;

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapMRolesToMRolesEntity", ex);
                throw;
            }
        }


        internal void MapRMUserRoleToRMUserRoleEntity()
        {
            try
            {
                Mapper.CreateMap<RMUserRole, RMUserRoleEntity>()
                    .ForMember(dest => dest.UserRoleId, opts => opts.MapFrom(src => src.UserRoleId))
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID))
                    .ForMember(dest => dest.RoleId, opts => opts.MapFrom(src => src.RoleId))
                    .ForMember(dest => dest.UserID, opts => opts.MapFrom(src => src.UserID))
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    ;

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapRMUserRoleToRMUserRoleEntity", ex);
                throw;
            }
        }
        internal void MapHullingProcessExpensesInfoEntity()
        {
            try
            {
                Mapper.CreateMap<HullingProcessExpenses, HullingProcessExpensesEntity>()
                    .ForMember(dest => dest.HullingProcessExpenID, opts => opts.MapFrom(src => src.HullingProcessExpenID))
                    .ForMember(dest => dest.HullingProcessID, opts => opts.MapFrom(src => src.HullingProcessID))
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID))
                    .ForMember(dest => dest.HullingExpenses, opts => opts.MapFrom(src => src.HullingExpenses))
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapHullingProcessExpensesInfoEntity", ex);
                throw;
            }
        }
        internal void MapBuyerSellerRatingEntity()
        {
            try
            {
                Mapper.CreateMap<BuyerSellerRating, BuyerSellerRatingEntity>()
                    .ForMember(dest => dest.BRMSID, opts => opts.MapFrom(src => src.BRMSID))
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID))
                    .ForMember(dest => dest.SellerID, opts => opts.MapFrom(src => src.SellerID))
                    .ForMember(dest => dest.Rating, opts => opts.MapFrom(src => src.Rating))
                    .ForMember(dest => dest.Remarks, opts => opts.MapFrom(src => src.Remarks))
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapBuyerSellerRatingEntity", ex);
                throw;
            }
        }
        internal void MapBuyerInfoEntity()
        {
            try
            {
                Mapper.CreateMap<BuyerInfo, BuyerInfoEntity>()
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
                    .ForMember(dest => dest.TINNumber, opts => opts.MapFrom(src => src.TINNumber))
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapBuyerInfoEntity", ex);
                throw;
            }
        }
        internal void MapMEmployeeDesignationEntity()
        {
            try
            {
                Mapper.CreateMap<MEmployeeDesignation, MEmployeeDesignationEntity>()
                    .ForMember(dest => dest.MEmpDsgID, opts => opts.MapFrom(src => src.MEmpDsgID))
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID))
                    .ForMember(dest => dest.DesignationType, opts => opts.MapFrom(src => src.DesignationType))
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapMEmployeeDesignationEntity", ex);
                throw;
            }
        }
        internal void MapMSalaryTypeEntity()
        {
            try
            {
                Mapper.CreateMap<MSalaryType, MSalaryTypeEntity>()
                    .ForMember(dest => dest.MSalaryTypeID, opts => opts.MapFrom(src => src.MSalaryTypeID))
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID))
                    .ForMember(dest => dest.Salarytype, opts => opts.MapFrom(src => src.Salarytype))
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapSalarytypeEntity", ex);
                throw;
            }
        }
        internal void MapEmployeeDetailsEntity()
        {
            try
            {
                Mapper.CreateMap<EmployeeDetails, EmployeeDetailsEntity>()
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
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapEmployeeDetailsEntity", ex);
                throw;
            }
        }
        internal void MapEmployeeSalaryEntity()
        {
            try
            {
                Mapper.CreateMap<EmployeeSalary, EmployeeSalaryEntity>()
                    .ForMember(dest => dest.EmpSalaryID, opts => opts.MapFrom(src => src.EmpSalaryID))
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID))
                    .ForMember(dest => dest.EmployeeID, opts => opts.MapFrom(src => src.EmployeeID))
                    .ForMember(dest => dest.MEmpDsgID, opts => opts.MapFrom(src => src.MEmpDsgID))
                    .ForMember(dest => dest.MSalaryTypeID, opts => opts.MapFrom(src => src.MSalaryTypeID))
                    .ForMember(dest => dest.Salary, opts => opts.MapFrom(src => src.Salary))
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapEmployeeSalaryEntity", ex);
                throw;
            }
        }
        internal void MapEmployeeSalaryPaymentEntity()
        {
            try
            {
                Mapper.CreateMap<MoneyTransaction, EmployeeSalaryPaymentEntity>()
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
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapEmployeeSalaryPaymentEntity", ex);
                throw;
            }
        }
        internal void MapOtherExpensesEntity()
        {
            try
            {
                Mapper.CreateMap<MoneyTransaction, OtherExpensesEntity>()
                    .ForMember(dest => dest.ExpTranID, opts => opts.MapFrom(src => src.ExpTranID))
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID))
                    .ForMember(dest => dest.GivenTo, opts => opts.MapFrom(src => src.GivenTo))
                    .ForMember(dest => dest.Description, opts => opts.MapFrom(src => src.Description))
                    .ForMember(dest => dest.AmountSpent, opts => opts.MapFrom(src => src.AmountSpent))
                    .ForMember(dest => dest.PaymentDate, opts => opts.MapFrom(src => src.PaymentDate))
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapOtherExpensesEntity", ex);
                throw;
            }
        }
        internal void MapProductPaymentInfoEntity()
        {
            try
            {
                Mapper.CreateMap<ProductPaymentInfo, ProductPaymentInfoEntity>()
                    .ForMember(dest => dest.ProductPaymentID, opts => opts.MapFrom(src => src.ProductPaymentID))
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID))
                    .ForMember(dest => dest.BuyerID, opts => opts.MapFrom(src => src.BuyerID))
                    .ForMember(dest => dest.MediatorID, opts => opts.MapFrom(src => src.MediatorID))
                    .ForMember(dest => dest.TotalAmount, opts => opts.MapFrom(src => src.TotalAmount))
                    .ForMember(dest => dest.Status, opts => opts.MapFrom(src => src.Status))
                    .ForMember(dest => dest.NextPayDate, opts => opts.MapFrom(src => src.NextPayDate))
                    .ForMember(dest => dest.Discount, opts => opts.MapFrom(src => src.Discount))
                    .ForMember(dest => dest.settlementbalance, opts => opts.MapFrom(src => src.settlementbalance))
                    .ForMember(dest => dest.IsSettlement, opts => opts.MapFrom(src => src.IsSettlement))
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapProductPaymentInfoEntity", ex);
                throw;
            }
        }
        internal void MapProductPaymentTranEntity()
        {
            try
            {
                Mapper.CreateMap<ProductPaymentTransaction, ProductPaymentTransactionEntity>()
                    .ForMember(dest => dest.ProductPaymentTranID, opts => opts.MapFrom(src => src.ProductPaymentTranID))
                    .ForMember(dest => dest.ProductPaymentID, opts => opts.MapFrom(src => src.ProductPaymentID))
                    .ForMember(dest => dest.BuyerID, opts => opts.MapFrom(src => src.BuyerID))
                    .ForMember(dest => dest.MediatorID, opts => opts.MapFrom(src => src.MediatorID))
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID))
                    .ForMember(dest => dest.Paymentmode, opts => opts.MapFrom(src => src.Paymentmode))
                    .ForMember(dest => dest.ChequeNo, opts => opts.MapFrom(src => src.ChequeNo))
                    .ForMember(dest => dest.DDNo, opts => opts.MapFrom(src => src.DDNo))
                    .ForMember(dest => dest.BankName, opts => opts.MapFrom(src => src.BankName))
                    .ForMember(dest => dest.ReceivedAmount, opts => opts.MapFrom(src => src.ReceivedAmount))
                    .ForMember(dest => dest.PaymentDueDate, opts => opts.MapFrom(src => src.PaymentDueDate))
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapProductPaymentTranEntity", ex);
                throw;
            }
        }
        internal void MapBagPaymentDetailsEntity()
        {
            try
            {
                Mapper.CreateMap<BagPaymentInfo, BagPaymentInfoEntity>()
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
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapBagPaymentDetailsEntity", ex);
                throw;
            }
        }
        internal void MapMediatorInfoEntity()
        {
            try
            {
                Mapper.CreateMap<MediatorInfo, MediatorInfoEntity>()
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
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapMediatorInfoEntity", ex);
                throw;
            }
        }
        internal void MapMExpenseTypeEntity()
        {
            try
            {
                Mapper.CreateMap<MExpenseType, MExpenseTypeEntity>()
                    .ForMember(dest => dest.ExpenseID, opts => opts.MapFrom(src => src.ExpenseID))
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID))
                    .ForMember(dest => dest.ExpenseType, opts => opts.MapFrom(src => src.ExpenseType))
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MExpenseTypeToMExpenseTypeEntity", ex);
                throw;
            }
        }
        internal void MapExpenseTransEntity()
        {
            try
            {
                Mapper.CreateMap<ExpenseTransaction, ExpenseTransactionEntity>()
                    .ForMember(dest => dest.ExpenseTransID, opts => opts.MapFrom(src => src.ExpenseTransID))
                    .ForMember(dest => dest.ExpenseID, opts => opts.MapFrom(src => src.ExpenseID))
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID))
                    .ForMember(dest => dest.Name, opts => opts.MapFrom(src => src.Name))
                    .ForMember(dest => dest.Amount, opts => opts.MapFrom(src => src.Amount))
                    .ForMember(dest => dest.Reason, opts => opts.MapFrom(src => src.Reason))
                    .ForMember(dest => dest.PayDate, opts => opts.MapFrom(src => src.PayDate))
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapExpenseTransToExpenseTransEntity", ex);
                throw;
            }
        }
        internal void MapMJobWorkEntity()
        {
            try
            {
                Mapper.CreateMap<MJobWork, MJobWorkEntity>()
                    .ForMember(dest => dest.JobWorkID, opts => opts.MapFrom(src => src.JobWorkID))
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID))
                    .ForMember(dest => dest.JobWorkType, opts => opts.MapFrom(src => src.JobWorkType))
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapMJobWorkToMapMJobWorkEntity", ex);
                throw;
            }
        }
        internal void MapRentalHullingEntity()
        {
            try
            {
                Mapper.CreateMap<RentalHulling, RentalHullingEntity>()
                    .ForMember(dest => dest.RentalHulingID, opts => opts.MapFrom(src => src.RentalHulingID))
                    .ForMember(dest => dest.JobWorkID, opts => opts.MapFrom(src => src.JobWorkID))
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID))
                    .ForMember(dest => dest.Name, opts => opts.MapFrom(src => src.Name))
                    .ForMember(dest => dest.PaddyType, opts => opts.MapFrom(src => src.PaddyType))
                    .ForMember(dest => dest.TotalBags, opts => opts.MapFrom(src => src.TotalBags))
                    .ForMember(dest => dest.Price, opts => opts.MapFrom(src => src.Price))
                    .ForMember(dest => dest.ProcessedDate, opts => opts.MapFrom(src => src.ProcessedDate))
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapExpenseTransEntity", ex);
                throw;
            }
        }
        internal void MapBankTransactionEntity()
        {
            try
            {
                Mapper.CreateMap<BankTransaction, BankTransactionEntity>()
                    .ForMember(dest => dest.BankTransID, opts => opts.MapFrom(src => src.BankTransID))
                    .ForMember(dest => dest.CustID, opts => opts.MapFrom(src => src.CustID))
                    .ForMember(dest => dest.TransactionDate, opts => opts.MapFrom(src => src.TransactionDate))
                    .ForMember(dest => dest.Withdraw, opts => opts.MapFrom(src => src.Withdraw))
                    .ForMember(dest => dest.Deposit, opts => opts.MapFrom(src => src.Deposit))
                    .ForMember(dest => dest.Balance, opts => opts.MapFrom(src => src.Balance))
                    .ForMember(dest => dest.ObsInd, opts => opts.MapFrom(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapBankTransactionEntity", ex);
                throw;
            }
        }

    }
}
