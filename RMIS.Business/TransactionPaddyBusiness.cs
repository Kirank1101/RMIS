using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RMIS.Domain.Mediator;
using RMIS.Domain.Business;
using log4net;
using RMIS.Domain.RiceMill;
using RMIS.Domain;
using AllInOne.Common.Library.Util;
using RMIS.Domain.DataTranserClass;
using RMIS.Domain.Constant;

namespace RMIS.Business
{
    public class TransactionPaddyBusiness : ITransactionBusiness
    {
        IRMISMediator imp;
        ISessionProvider provider;
        IUserMessage msgInstance;
        private static readonly ILog Logger = LogManager.GetLogger(typeof(TransactionPaddyBusiness));
        public TransactionPaddyBusiness(IRMISMediator imp, ISessionProvider provider, IUserMessage msgInstance)
        {
            this.provider = provider;
            this.imp = imp;
            this.msgInstance = msgInstance;
        }

        public Domain.DataTranserClass.ResultDTO SaveSellerInfo(string sellerTypeId, string name, string street, string street1, string town, string city, string district, string state, string pincode, string contactNo, string mobileNo, string phoneNo)
        {
            SellerInfoEntity objSellerInfoEntity = new SellerInfoEntity();
            objSellerInfoEntity.ObsInd = YesNo.N;
            objSellerInfoEntity.CustID = provider.GetCurrentCustomerId();
            objSellerInfoEntity.LastModifiedBy = provider.GetLoggedInUserId();
            objSellerInfoEntity.City = city ;
            objSellerInfoEntity.ContactNo = contactNo;
            objSellerInfoEntity.LastModifiedDate = DateTime.Now;
            objSellerInfoEntity.District = district;
            objSellerInfoEntity.MobileNo = mobileNo;
            objSellerInfoEntity.Name = name;
            objSellerInfoEntity.PhoneNo = phoneNo;
            objSellerInfoEntity.PinCode = pincode;
            objSellerInfoEntity.SellerTypeID = sellerTypeId;
            objSellerInfoEntity.State = state;
            objSellerInfoEntity.Street = street;
            objSellerInfoEntity.Street1 = street1;
            objSellerInfoEntity.SellerID = CommonUtil.CreateUniqueID("SE");

            try
            {
                imp.BeginTransaction();
                imp.SaveOrUpdateSellerInfoEntity(objSellerInfoEntity, false);
                imp.CommitAndCloseSession();
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.Error07, provider.GetCurrentCustomerId()) };
            }
            return new ResultDTO() { Message = msgInstance.GetMessage(RMSConstants.Success07, provider.GetCurrentCustomerId()) };
        }

        public Domain.DataTranserClass.ResultDTO SavePaddyStockInfo(string sellerId, string paddyTypeId, string godownId, string lotId, string vehicleNo, int totalBags, int qWeight, int qPrice, DateTime purchaseDate)
        {
            PaddyStockInfoEntity objPaddyStockInfoEntity = new PaddyStockInfoEntity();
            objPaddyStockInfoEntity.ObsInd = YesNo.N;
            objPaddyStockInfoEntity.CustID = provider.GetCurrentCustomerId();
            objPaddyStockInfoEntity.LastModifiedBy = provider.GetLoggedInUserId();
            objPaddyStockInfoEntity.MGodownID  = godownId;
            objPaddyStockInfoEntity.MLotID  = lotId ;
            objPaddyStockInfoEntity.LastModifiedDate = DateTime.Now;
            objPaddyStockInfoEntity.PaddyStockID  = CommonUtil.CreateUniqueID("PS");
            objPaddyStockInfoEntity.PaddyTypeID  = paddyTypeId;
            objPaddyStockInfoEntity.PurchaseDate  = purchaseDate;
            objPaddyStockInfoEntity.QPrice  =(short) qPrice;
            objPaddyStockInfoEntity.QWeight  = (short) qWeight;
            objPaddyStockInfoEntity.SellerID  = sellerId;
            objPaddyStockInfoEntity.TotalBags  = (short) totalBags;
            objPaddyStockInfoEntity.VehicalNo  = vehicleNo;          
            try
            {
                imp.BeginTransaction();
                imp.SaveOrUpdatePaddyStockInfoEntity(objPaddyStockInfoEntity, false);
                imp.CommitAndCloseSession();
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.Error08, provider.GetCurrentCustomerId()) };
            }
            return new ResultDTO() { Message = msgInstance.GetMessage(RMSConstants.Success08, provider.GetCurrentCustomerId()) };
        }

        public Domain.DataTranserClass.ResultDTO SavePaddyPaymentDetails(string sellerId, double amountPaid, DateTime paidDate, string handOverTo, DateTime nextPaymentDate)
        {
            PaddyPaymentDetailsEntity objPaddyPaymentDetailsEntity = new PaddyPaymentDetailsEntity();
            objPaddyPaymentDetailsEntity.ObsInd = YesNo.N;
            objPaddyPaymentDetailsEntity.CustID = provider.GetCurrentCustomerId();
            objPaddyPaymentDetailsEntity.LastModifiedBy = provider.GetLoggedInUserId();
            objPaddyPaymentDetailsEntity.AmountPaid = amountPaid;
            objPaddyPaymentDetailsEntity.HandoverTo = handOverTo;
            objPaddyPaymentDetailsEntity.LastModifiedDate = DateTime.Now;
            objPaddyPaymentDetailsEntity.PaddyPaymentID  = CommonUtil.CreateUniqueID("PP");
            objPaddyPaymentDetailsEntity.PaidDate  = paidDate ;
            objPaddyPaymentDetailsEntity.NextPaymentDate  = nextPaymentDate ;
            objPaddyPaymentDetailsEntity.SellerID = sellerId;          
            try
            {
                imp.BeginTransaction();
                imp.SaveOrUpdatePaddyPaymentDetailsEntity(objPaddyPaymentDetailsEntity, false);
                imp.CommitAndCloseSession();
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.Error09, provider.GetCurrentCustomerId()) };
            }
            return new ResultDTO() { Message = msgInstance.GetMessage(RMSConstants.Success09, provider.GetCurrentCustomerId()) };
        }

        public List<SellerInfoEntity> GetPaddySellerInfo()
        {
            List<SellerInfoEntity> listSellerInfoEntity = null;            
            List<SellerInfoEntity> listSellerinfo = imp.GetListSellerInfoEntities(provider.GetCurrentCustomerId());
            if (listSellerinfo != null && listSellerinfo.Count > 0)
            {
                listSellerInfoEntity = new List<SellerInfoEntity>();
                foreach (SellerInfoEntity objSellerinfo in listSellerinfo)
                {
                    
                    SellerInfoEntity objSellerInfoEntity = new SellerInfoEntity();
                    objSellerInfoEntity.SellerID = objSellerinfo.SellerID;
                    objSellerInfoEntity.Name = objSellerinfo.Name;
                    listSellerInfoEntity.Add(objSellerInfoEntity);
                }

            }
            return listSellerInfoEntity;
        }
    }
}
