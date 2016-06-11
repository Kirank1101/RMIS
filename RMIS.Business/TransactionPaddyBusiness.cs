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
        public Domain.DataTranserClass.ResultDTO SaveSellerInfo(string name, string street, string street1, string town, string city, string district, string state, string pincode, string contactNo, string mobileNo, string phoneNo)
        {
            SellerInfoEntity objSellerInfoEntity = new SellerInfoEntity();
            objSellerInfoEntity.ObsInd = YesNo.N;
            objSellerInfoEntity.CustID = provider.GetCurrentCustomerId();
            objSellerInfoEntity.LastModifiedBy = provider.GetLoggedInUserId();
            objSellerInfoEntity.City = city;
            objSellerInfoEntity.ContactNo = contactNo;
            objSellerInfoEntity.LastModifiedDate = DateTime.Now;
            objSellerInfoEntity.District = district;
            objSellerInfoEntity.MobileNo = mobileNo;
            objSellerInfoEntity.Name = name;
            objSellerInfoEntity.PhoneNo = phoneNo;
            objSellerInfoEntity.PinCode = pincode;
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
        public Domain.DataTranserClass.ResultDTO SavePaddyStockInfo(string sellerId, string paddyTypeId, string godownId, string lotId, string UnitsTypeID, string vehicleNo, string DriverName, decimal totalBags, decimal Price, DateTime purchaseDate, double AmountPaid, DateTime PaidDate, string HandOverTo, DateTime NextPaymentDate, string PaymentMode, string ChequeuNo, string BankName)
        {
            #region Save PaddyStock
            PaddyStockInfoEntity objPaddyStockInfoEntity = new PaddyStockInfoEntity();
            objPaddyStockInfoEntity.ObsInd = YesNo.N;
            objPaddyStockInfoEntity.CustID = provider.GetCurrentCustomerId();
            objPaddyStockInfoEntity.LastModifiedBy = provider.GetLoggedInUserId();
            objPaddyStockInfoEntity.MGodownID = godownId;
            objPaddyStockInfoEntity.MLotID = lotId;
            objPaddyStockInfoEntity.UnitsTypeID = UnitsTypeID;
            objPaddyStockInfoEntity.LastModifiedDate = DateTime.Now;
            objPaddyStockInfoEntity.PaddyStockID = CommonUtil.CreateUniqueID("PS");
            objPaddyStockInfoEntity.PaddyTypeID = paddyTypeId;
            objPaddyStockInfoEntity.PurchaseDate = purchaseDate;
            objPaddyStockInfoEntity.Price = Price;
            objPaddyStockInfoEntity.SellerID = sellerId;
            objPaddyStockInfoEntity.TotalBags = totalBags;
            objPaddyStockInfoEntity.VehicalNo = vehicleNo;
            objPaddyStockInfoEntity.DriverName = DriverName;
            #endregion
            #region Save PaddyPayment
            PaddyPaymentDetailsEntity objPaddyPaymentDetailsEntity = new PaddyPaymentDetailsEntity();
            objPaddyPaymentDetailsEntity.ObsInd = YesNo.N;
            objPaddyPaymentDetailsEntity.CustID = provider.GetCurrentCustomerId();
            objPaddyPaymentDetailsEntity.LastModifiedBy = provider.GetLoggedInUserId();
            objPaddyPaymentDetailsEntity.AmountPaid = AmountPaid;
            objPaddyPaymentDetailsEntity.HandoverTo = HandOverTo;
            objPaddyPaymentDetailsEntity.LastModifiedDate = DateTime.Now;
            objPaddyPaymentDetailsEntity.PaddyPaymentID = CommonUtil.CreateUniqueID("PP");
            objPaddyPaymentDetailsEntity.PaidDate = PaidDate;
            objPaddyPaymentDetailsEntity.NextPaymentDate = NextPaymentDate;
            objPaddyPaymentDetailsEntity.SellerID = sellerId;
            objPaddyPaymentDetailsEntity.PaddyStockID = objPaddyStockInfoEntity.PaddyStockID;
            objPaddyPaymentDetailsEntity.PaymentMode = PaymentMode;
            objPaddyPaymentDetailsEntity.ChequeNo = ChequeuNo;
            objPaddyPaymentDetailsEntity.BankName = BankName;
            #endregion
            try
            {
                imp.BeginTransaction();
                imp.SaveOrUpdatePaddyStockInfoEntity(objPaddyStockInfoEntity, false);
                imp.SaveOrUpdatePaddyPaymentDetailsEntity(objPaddyPaymentDetailsEntity, false);
                imp.CommitAndCloseSession();
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.Error08, provider.GetCurrentCustomerId()) };
            }
            return new ResultDTO() { Message = msgInstance.GetMessage(RMSConstants.Success08, provider.GetCurrentCustomerId()) };
        }
        public Domain.DataTranserClass.ResultDTO SavePaddyPaymentDetails(string sellerId, double amountPaid, DateTime paidDate, string handOverTo, DateTime nextPaymentDate, string PaddyStockID, string PaymentMode, string ChequeuNo, string BankName)
        {
            PaddyPaymentDetailsEntity objPaddyPaymentDetailsEntity = new PaddyPaymentDetailsEntity();
            objPaddyPaymentDetailsEntity.ObsInd = YesNo.N;
            objPaddyPaymentDetailsEntity.CustID = provider.GetCurrentCustomerId();
            objPaddyPaymentDetailsEntity.LastModifiedBy = provider.GetLoggedInUserId();
            objPaddyPaymentDetailsEntity.AmountPaid = amountPaid;
            objPaddyPaymentDetailsEntity.HandoverTo = handOverTo;
            objPaddyPaymentDetailsEntity.LastModifiedDate = DateTime.Now;
            objPaddyPaymentDetailsEntity.PaddyPaymentID = CommonUtil.CreateUniqueID("PP");
            objPaddyPaymentDetailsEntity.PaidDate = paidDate;
            objPaddyPaymentDetailsEntity.NextPaymentDate = nextPaymentDate;
            objPaddyPaymentDetailsEntity.SellerID = sellerId;
            objPaddyPaymentDetailsEntity.PaddyStockID = PaddyStockID;
            objPaddyPaymentDetailsEntity.PaymentMode = PaymentMode;
            objPaddyPaymentDetailsEntity.ChequeNo = ChequeuNo;
            objPaddyPaymentDetailsEntity.BankName = BankName;
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
            List<SellerInfoEntity> listSellerinfo = imp.GetListSellerInfoEntities(provider.GetCurrentCustomerId(),YesNo.N);
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

        public List<SellerInfoEntity> GetPaddySellerInfo(int count, string prefixText,string context)
        {

            List<SellerInfoEntity> listSellerInfoEntity = null;
            List<SellerInfoEntity> listSellerinfo = imp.GetSellerInfoEntities(context, YesNo.N, count, prefixText);
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


        public ResultDTO SaveBagStockInfo(string sellerId, string BagTypeId, string vehicleNo, string DriverName, int totalBags, decimal Price, DateTime purchaseDate)
        {
            BagStockInfoEntity objBagStockInfoEntity = new BagStockInfoEntity();
            objBagStockInfoEntity.ObsInd = YesNo.N;
            objBagStockInfoEntity.CustID = provider.GetCurrentCustomerId();
            objBagStockInfoEntity.LastModifiedBy = provider.GetLoggedInUserId();
            objBagStockInfoEntity.LastModifiedDate = DateTime.Now;
            objBagStockInfoEntity.BagStockID = CommonUtil.CreateUniqueID("BS");
            objBagStockInfoEntity.BagTypeID = BagTypeId;
            objBagStockInfoEntity.PurchaseDate = purchaseDate;
            objBagStockInfoEntity.Price = Price;
            objBagStockInfoEntity.SellerID = sellerId;
            objBagStockInfoEntity.TotalBags = (short)totalBags;
            objBagStockInfoEntity.VehicalNo = vehicleNo;
            objBagStockInfoEntity.DriverName = DriverName;
            try
            {
                imp.BeginTransaction();
                imp.SaveOrUpdateBagStockInfoEntity(objBagStockInfoEntity, false);
                imp.CommitAndCloseSession();
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.Error08, provider.GetCurrentCustomerId()) };
            }
            return new ResultDTO() { Message = msgInstance.GetMessage(RMSConstants.Success08, provider.GetCurrentCustomerId()) };

        }
        public ResultDTO SaveRiceStockInfo(string MRiceProdTypeID, string MRiceBrandID, int totalBags, int QWeight, string UnitsTypeID)
        {
            RiceStockInfoEntity objRiceStockInfoEntity = new RiceStockInfoEntity();
            objRiceStockInfoEntity.CustID = provider.GetCurrentCustomerId();
            objRiceStockInfoEntity.ObsInd = YesNo.N;
            objRiceStockInfoEntity.LastModifiedBy = provider.GetLoggedInUserId();
            objRiceStockInfoEntity.LastModifiedDate = DateTime.Now;
            objRiceStockInfoEntity.RiceStockID = CommonUtil.CreateUniqueID("RS");
            objRiceStockInfoEntity.MRiceProdTypeID = MRiceProdTypeID;
            objRiceStockInfoEntity.MRiceBrandID = MRiceBrandID;
            objRiceStockInfoEntity.QWeight = (short)QWeight;
            objRiceStockInfoEntity.UnitsTypeID = UnitsTypeID;
            objRiceStockInfoEntity.TotalBags = (short)totalBags;
            try
            {
                imp.BeginTransaction();
                imp.SaveOrUpdateRiceStockInfoEntity(objRiceStockInfoEntity, false);
                imp.CommitAndCloseSession();
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.Error08, provider.GetCurrentCustomerId()) };
            }
            return new ResultDTO() { Message = msgInstance.GetMessage(RMSConstants.Success08, provider.GetCurrentCustomerId()) };
        }
        public List<RiceStockInfoEntity> GetAllRiceStockInfoEntities()
        {
            return imp.GetAllRiceStockInfoEntities(provider.GetCurrentCustomerId(),YesNo.N);
        }
        public ResultDTO SaveBrokenRiceStockInfo(string BrokenRiceTypeId, int totalBags, int QWeight, string UnitsTypeID)
        {
            BrokenRiceStockInfoEntity objBrokenRiceStockInfoEntity = new BrokenRiceStockInfoEntity();
            objBrokenRiceStockInfoEntity.CustID = provider.GetCurrentCustomerId();
            objBrokenRiceStockInfoEntity.ObsInd = YesNo.N;
            objBrokenRiceStockInfoEntity.LastModifiedBy = provider.GetLoggedInUserId();
            objBrokenRiceStockInfoEntity.LastModifiedDate = DateTime.Now;
            objBrokenRiceStockInfoEntity.BrokenRiceStockID = CommonUtil.CreateUniqueID("BR");
            objBrokenRiceStockInfoEntity.BrokenRiceTypeID = BrokenRiceTypeId;
            objBrokenRiceStockInfoEntity.UnitsTypeID = UnitsTypeID;
            objBrokenRiceStockInfoEntity.TotalBags = (short)totalBags;
            objBrokenRiceStockInfoEntity.QWeight = (short)QWeight;
            try
            {
                imp.BeginTransaction();
                imp.SaveOrUpdateBrokenRiceStockInfoEntity(objBrokenRiceStockInfoEntity, false);
                imp.CommitAndCloseSession();
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.Error08, provider.GetCurrentCustomerId()) };
            }
            return new ResultDTO() { Message = msgInstance.GetMessage(RMSConstants.Success08, provider.GetCurrentCustomerId()) };
        }
        public List<BrokenRiceStockInfoEntity> GetAllBrokenRiceStockInfoEntities()
        {
            return imp.GetAllBrokenRiceStockInfoEntities(provider.GetCurrentCustomerId(),YesNo.N);
        }
        public ResultDTO SaveDustStockInfo(int totalBags, int QWeight, string UnitsTypeID)
        {
            DustStockInfoEntity objDustStockInfoEntity = new DustStockInfoEntity();
            objDustStockInfoEntity.CustID = provider.GetCurrentCustomerId();
            objDustStockInfoEntity.ObsInd = YesNo.N;
            objDustStockInfoEntity.LastModifiedBy = provider.GetLoggedInUserId();
            objDustStockInfoEntity.LastModifiedDate = DateTime.Now;
            objDustStockInfoEntity.DustStockID = CommonUtil.CreateUniqueID("DU");
            objDustStockInfoEntity.QWeight = (short)QWeight;
            objDustStockInfoEntity.UnitsTypeID = UnitsTypeID;
            objDustStockInfoEntity.TotalBags = (short)totalBags;
            try
            {
                imp.BeginTransaction();
                imp.SaveOrUpdateDustStockInfoEntity(objDustStockInfoEntity, false);
                imp.CommitAndCloseSession();
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.Error08, provider.GetCurrentCustomerId()) };
            }
            return new ResultDTO() { Message = msgInstance.GetMessage(RMSConstants.Success08, provider.GetCurrentCustomerId()) };
        }
        public List<DustStockInfoEntity> GetAllDustStockInfoEntities()
        {
            return imp.GetAllDustStockInfoEntities(provider.GetCurrentCustomerId(),YesNo.N);
        }


        public ResultDTO SaveRiceSellingInfo(string sellerId, string MRiceProdTypeID, string MRiceBrandId, string vehicleNo, string DriverName, int totalBags, int qWeight, string UnitsTypeID, int qPrice, DateTime SellingDate)
        {
            RiceSellingInfoEntity objRiceSellingInfoEntity = new RiceSellingInfoEntity();
            objRiceSellingInfoEntity.ObsInd = YesNo.N;
            objRiceSellingInfoEntity.CustID = provider.GetCurrentCustomerId();
            objRiceSellingInfoEntity.LastModifiedBy = provider.GetLoggedInUserId();
            objRiceSellingInfoEntity.MRiceBrandID = MRiceBrandId;
            objRiceSellingInfoEntity.DriverName = DriverName;
            objRiceSellingInfoEntity.LastModifiedDate = DateTime.Now;
            objRiceSellingInfoEntity.RiceSellingID = CommonUtil.CreateUniqueID("RS");
            objRiceSellingInfoEntity.MRiceProdTypeID = MRiceProdTypeID;
            objRiceSellingInfoEntity.SellingDate = SellingDate;
            objRiceSellingInfoEntity.QPrice = (short)qPrice;
            objRiceSellingInfoEntity.QWeight = (short)qWeight;
            objRiceSellingInfoEntity.SellerID = sellerId;
            objRiceSellingInfoEntity.TotalBags = (short)totalBags;
            objRiceSellingInfoEntity.VehicalNo = vehicleNo;
            try
            {
                imp.BeginTransaction();
                imp.SaveOrUpdateRiceSellingInfoEntity(objRiceSellingInfoEntity, false);
                imp.CommitAndCloseSession();
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.Error08, provider.GetCurrentCustomerId()) };
            }
            return new ResultDTO() { Message = msgInstance.GetMessage(RMSConstants.Success08, provider.GetCurrentCustomerId()) };
        }

        public List<RiceSellingInfoEntity> GetAllRiceSellingInfoEntities()
        {
            return imp.GetAllRiceSellingInfoEntities(provider.GetCurrentCustomerId(), YesNo.N);
        }


        public ResultDTO SaveBrokenRiceSellingInfo(string sellerId, string BrokenRiceTypeId, string vehicleNo, string DriverName, int totalBags, int qWeight, string UnitsTypeID, int qPrice, DateTime SellingDate)
        {
            BrokenRiceSellingInfoEntity objBrokenRiceSellingInfoEntity = new BrokenRiceSellingInfoEntity();
            objBrokenRiceSellingInfoEntity.ObsInd = YesNo.N;
            objBrokenRiceSellingInfoEntity.CustID = provider.GetCurrentCustomerId();
            objBrokenRiceSellingInfoEntity.LastModifiedBy = provider.GetLoggedInUserId();
            objBrokenRiceSellingInfoEntity.DriverName = DriverName;
            objBrokenRiceSellingInfoEntity.LastModifiedDate = DateTime.Now;
            objBrokenRiceSellingInfoEntity.BrokenRiceSellingID = CommonUtil.CreateUniqueID("BRS");
            objBrokenRiceSellingInfoEntity.BrokenRiceTypeID = BrokenRiceTypeId;
            objBrokenRiceSellingInfoEntity.SellingDate = SellingDate;
            objBrokenRiceSellingInfoEntity.QPrice = (short)qPrice;
            objBrokenRiceSellingInfoEntity.QWeight = (short)qWeight;
            objBrokenRiceSellingInfoEntity.SellerID = sellerId;
            objBrokenRiceSellingInfoEntity.TotalBags = (short)totalBags;
            objBrokenRiceSellingInfoEntity.VehicalNo = vehicleNo;
            try
            {
                imp.BeginTransaction();
                imp.SaveOrUpdateBrokenRiceSellingInfoEntity(objBrokenRiceSellingInfoEntity, false);
                imp.CommitAndCloseSession();
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.Error08, provider.GetCurrentCustomerId()) };
            }
            return new ResultDTO() { Message = msgInstance.GetMessage(RMSConstants.Success08, provider.GetCurrentCustomerId()) };
        }
        public List<BrokenRiceSellingInfoEntity> GetAllBrokenRiceSellingInfoEntities()
        {
            return imp.GetAllBrokenRiceSellingInfoEntities(provider.GetCurrentCustomerId(),YesNo.N);
        }
        public ResultDTO SaveDustSellingInfo(string sellerId, string vehicleNo, string DriverName, int totalBags, int qWeight, string UnitsTypeID, int qPrice, DateTime SellingDate)
        {
            DustSellingInfoEntity objDustSellingInfoEntity = new DustSellingInfoEntity();
            objDustSellingInfoEntity.ObsInd = YesNo.N;
            objDustSellingInfoEntity.CustID = provider.GetCurrentCustomerId();
            objDustSellingInfoEntity.LastModifiedBy = provider.GetLoggedInUserId();
            objDustSellingInfoEntity.DriverName = DriverName;
            objDustSellingInfoEntity.LastModifiedDate = DateTime.Now;
            objDustSellingInfoEntity.DustSellingID = CommonUtil.CreateUniqueID("DS");
            objDustSellingInfoEntity.SellingDate = SellingDate;
            objDustSellingInfoEntity.QPrice = (short)qPrice;
            objDustSellingInfoEntity.QWeight = (short)qWeight;
            objDustSellingInfoEntity.SellerID = sellerId;
            objDustSellingInfoEntity.TotalBags = (short)totalBags;
            objDustSellingInfoEntity.VehicalNo = vehicleNo;
            try
            {
                imp.BeginTransaction();
                imp.SaveOrUpdateDustSellingInfoEntity(objDustSellingInfoEntity, false);
                imp.CommitAndCloseSession();
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.Error08, provider.GetCurrentCustomerId()) };
            }
            return new ResultDTO() { Message = msgInstance.GetMessage(RMSConstants.Success08, provider.GetCurrentCustomerId()) };

        }
        public List<DustSellingInfoEntity> GetAllDustSellingInfoEntities()
        {
            return imp.GetAllDustSellingInfoEntities(provider.GetCurrentCustomerId(),YesNo.N);
        }


        public bool SaveCustomerInformation(string customerName, string organizationName, string custId)
        {
            CustomerInfoEntity custEntity = new CustomerInfoEntity();
            custEntity.CustID = custId;
            custEntity.Name = customerName;
            custEntity.OrganizationName = organizationName;
            custEntity.ObsInd = YesNo.N;
            custEntity.LastModifiedBy = provider.GetLoggedInUserId();
            custEntity.LastModifiedDate = DateTime.Now;
            try
            {
                imp.BeginTransaction();
                imp.SaveOrUpdateCustomerInfoEntity(custEntity, false);
                imp.CommitAndCloseSession();
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                return false;
            }
            return true;
        }


        public List<CustomerInfoEntity> GetAllCustomerInfoEntities()
        {
            return imp.GetCustomerInfoEntities(YesNo.N);
        }

        public bool SaveMenuConfiguration(string custId, string roleId, string menuId)
        {
            MenuConfigurationEntity menuConfigEntity = new MenuConfigurationEntity();
            menuConfigEntity.MenuConfigId = CommonUtil.CreateUniqueID("MC"); ;
            menuConfigEntity.CustID = custId;
            menuConfigEntity.MenuID = menuId.ConvertToInt();
            menuConfigEntity.RoleId = roleId;
            menuConfigEntity.ObsInd = YesNo.N;
            menuConfigEntity.LastModifiedBy = provider.GetLoggedInUserId();
            menuConfigEntity.LastModifiedDate = DateTime.Now;
            try
            {
                imp.BeginTransaction();
                imp.SaveOrUpdateMenuConfigEntity(menuConfigEntity, false);
                imp.CommitAndCloseSession();
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                return false;
            }
            return true;
        }

        public List<MenuConfigurationEntity> GetMenuConfigurationEntities()
        {
            return imp.GetMenuConfigurationEntities(provider.GetCurrentCustomerId(),YesNo.N);
        }

        public List<MenuConfigurationEntity> GetMenuConfigurationEntities(string custId)
        {
            return imp.GetMenuConfigurationEntities(custId,YesNo.N);
        }




        public ResultDTO SaveProductSellingInfo(string SellingProductType, string sellerId, string MRiceProdTypeID, string MRiceBrandId, string BrokenRiceTypeId, decimal totalBags, string UnitsTypeID, double Price, DateTime SellingDate, string OrderNo, string PaymentMode,
                                         string ChequeNo, string DDno, string BankName, double ReceivedAmount, DateTime NextPaymentDate)
        {

            ProductPaymentInfoEntity productPaymentInfoEntity = new ProductPaymentInfoEntity();
            productPaymentInfoEntity.ProductPaymentID = CommonUtil.CreateUniqueID("PP");
            productPaymentInfoEntity.CustID = provider.GetCurrentCustomerId();
            productPaymentInfoEntity.TotalAmount = Convert.ToDouble(totalBags) * Price;
            productPaymentInfoEntity.Status = 'P';
            productPaymentInfoEntity.LastModifiedBy = provider.GetLoggedInUserId();
            productPaymentInfoEntity.LastModifiedDate = DateTime.Now;
            productPaymentInfoEntity.ObsInd = YesNo.N;

            ProductPaymentTransactionEntity ProdPayTranEnt = new ProductPaymentTransactionEntity();
            ProdPayTranEnt.ProductPaymentTranID = CommonUtil.CreateUniqueID("PT");
            ProdPayTranEnt.ProductPaymentID = productPaymentInfoEntity.ProductPaymentID;
            ProdPayTranEnt.CustID = provider.GetCurrentCustomerId();
            ProdPayTranEnt.Paymentmode = PaymentMode;
            ProdPayTranEnt.ChequeNo = ChequeNo;
            ProdPayTranEnt.DDNo = DDno;
            ProdPayTranEnt.BankName = BankName;
            ProdPayTranEnt.ReceivedAmount = ReceivedAmount;
            ProdPayTranEnt.PaymentDueDate = NextPaymentDate;
            ProdPayTranEnt.LastModifiedBy = provider.GetLoggedInUserId();
            ProdPayTranEnt.LastModifiedDate = DateTime.Now;
            ProdPayTranEnt.ObsInd = YesNo.N;

            ProductSellingInfoEntity objProductSellingInfoEntity = new ProductSellingInfoEntity();
            objProductSellingInfoEntity.ObsInd = YesNo.N;
            objProductSellingInfoEntity.CustID = provider.GetCurrentCustomerId();
            objProductSellingInfoEntity.SellingProductType = SellingProductType;
            objProductSellingInfoEntity.LastModifiedBy = provider.GetLoggedInUserId();
            objProductSellingInfoEntity.MRiceBrandID = MRiceBrandId;
            objProductSellingInfoEntity.BrokenRiceTypeID = BrokenRiceTypeId;
            objProductSellingInfoEntity.LastModifiedDate = DateTime.Now;
            objProductSellingInfoEntity.ProductID = CommonUtil.CreateUniqueID("PI");
            objProductSellingInfoEntity.ProductPaymentID = productPaymentInfoEntity.ProductPaymentID;
            objProductSellingInfoEntity.MRiceProdTypeID = MRiceProdTypeID;
            objProductSellingInfoEntity.SellingDate = SellingDate;
            objProductSellingInfoEntity.Price = Price;
            objProductSellingInfoEntity.SellerID = sellerId;
            objProductSellingInfoEntity.TotalBags = totalBags;
            objProductSellingInfoEntity.UnitsTypeID = UnitsTypeID;
            
            
            try
            {
                imp.BeginTransaction();
                imp.SaveOrUpdateProductPaymentInfoEntity(productPaymentInfoEntity, false);
                imp.SaveOrUpdateProductPaymentTransEntity(ProdPayTranEnt, false);
                imp.SaveOrUpdateProductSellingInfoEntity(objProductSellingInfoEntity, false);
                imp.CommitAndCloseSession();
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.Error08, provider.GetCurrentCustomerId()) };
            }
            return new ResultDTO() { Message = msgInstance.GetMessage(RMSConstants.Success08, provider.GetCurrentCustomerId()) };
        }

        public List<ProductSellingInfoEntity> GetAllProductSellingInfoEntities()
        {
            return imp.GetAllproductSellingInfoEntities(provider.GetCurrentCustomerId(),YesNo.N);
        }


        public ResultDTO SaveHullingProcessInfo(string PaddyTypeID, string UnitsTypeID, int TotalBags, string ProcessBy, DateTime ProcessDate, char Status)
        {
            HullingProcessEntity objHullingProcessEntity = new HullingProcessEntity();
            objHullingProcessEntity.ObsInd = YesNo.N;
            objHullingProcessEntity.HullingProcessID = CommonUtil.CreateUniqueID("HP");
            objHullingProcessEntity.PaddyTypeID = PaddyTypeID;
            objHullingProcessEntity.CustID = provider.GetCurrentCustomerId();
            objHullingProcessEntity.UnitsTypeID = UnitsTypeID;
            objHullingProcessEntity.TotalBags = (short)TotalBags;
            objHullingProcessEntity.ProcessDate = ProcessDate;
            objHullingProcessEntity.ProcessedBy = ProcessBy;
            objHullingProcessEntity.LastModifiedBy = provider.GetLoggedInUserId();
            objHullingProcessEntity.LastModifiedDate = DateTime.Now;
            objHullingProcessEntity.Status = Status;
            try
            {
                imp.BeginTransaction();
                imp.SaveOrUpdateHullingProcessInfoEntity(objHullingProcessEntity, false);
                imp.CommitAndCloseSession();
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.Error08, provider.GetCurrentCustomerId()) };
            }
            return new ResultDTO() { Message = msgInstance.GetMessage(RMSConstants.Success08, provider.GetCurrentCustomerId()) };
        }

        public List<HullingProcessEntity> GetAllHullingProcessInfoEntities()
        {
            return imp.GetAllHullingProcessInfoEntity(provider.GetCurrentCustomerId(),YesNo.N);
        }


        public ResultDTO SaveHullingProcessTransInfo(string HullingProcessID, string ProductTypeID, string PaddyTypeID, string RiceType, string BrokenRiceType, char IsDust, string UnitsTypeID, int TotalBags, double Price)
        {
            HullingProcessTransactionEntity objHullingProcessTransEntity = new HullingProcessTransactionEntity();
            objHullingProcessTransEntity.ObsInd = YesNo.N;
            objHullingProcessTransEntity.HullingTransID = CommonUtil.CreateUniqueID("HT");
            objHullingProcessTransEntity.HullingProcessID = HullingProcessID;
            objHullingProcessTransEntity.ProductTypeID = ProductTypeID;
            objHullingProcessTransEntity.PaddyTypeID = PaddyTypeID;
            objHullingProcessTransEntity.MRiceProdTypeID = RiceType;
            objHullingProcessTransEntity.BrokenRiceTypeID = BrokenRiceType;
            objHullingProcessTransEntity.IsDust = IsDust;
            objHullingProcessTransEntity.CustID = provider.GetCurrentCustomerId();
            objHullingProcessTransEntity.UnitsTypeID = UnitsTypeID;
            objHullingProcessTransEntity.TotalBags = (short)TotalBags;
            objHullingProcessTransEntity.Price = Price;
            objHullingProcessTransEntity.LastModifiedBy = provider.GetLoggedInUserId();
            objHullingProcessTransEntity.LastModifiedDate = DateTime.Now;
            try
            {
                imp.BeginTransaction();
                imp.SaveOrUpdateHullingProcessTransInfoEntity(objHullingProcessTransEntity, false);
                imp.CommitAndCloseSession();
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.Error08, provider.GetCurrentCustomerId()) };
            }
            return new ResultDTO() { Message = msgInstance.GetMessage(RMSConstants.Success08, provider.GetCurrentCustomerId()) };
        }

        public List<HullingProcessTransactionEntity> GetAllHullingProcessTransInfoEntities()
        {
            return imp.GetAllHullingProcessTransInfoEntity(provider.GetCurrentCustomerId(),YesNo.N);
        }

        public List<PaddyStockDTO> GetPaddyStockDTO(int pageindex, int pageSize, out int count, SortExpression expression)
        {
            List<PaddyStockDTO> listPaddyStockDTO = null;
            List<PaddyStockInfoEntity> listPaddyStockInfoEntity = imp.GetPaddyStockInfoEntity(provider.GetCurrentCustomerId(), pageindex, pageSize, out count, expression,YesNo.N);
            if (listPaddyStockInfoEntity != null && listPaddyStockInfoEntity.Count > 0)
            {
                listPaddyStockDTO = new List<PaddyStockDTO>();
                foreach (PaddyStockInfoEntity objPaddyStockInfoEntity in listPaddyStockInfoEntity)
                {
                    PaddyStockDTO objPaddyStockDTO = new PaddyStockDTO();
                    objPaddyStockDTO.Id = objPaddyStockInfoEntity.PaddyStockID;
                    MGodownDetailsEntity objMGodownDetailsEntity = imp.GetMGodownDetailsEntity(objPaddyStockInfoEntity.MGodownID, YesNo.Null);
                    if (objMGodownDetailsEntity != null)
                    {
                        objPaddyStockDTO.GodownName = objMGodownDetailsEntity.Name;
                    }
                    MLotDetailsEntity objMLotDetailsEntity = imp.GetMLotDetailsEntity(objPaddyStockInfoEntity.MLotID, YesNo.Null);
                    if (objMLotDetailsEntity != null)
                    {
                        objPaddyStockDTO.LotName = objMLotDetailsEntity.LotName;
                    }
                    SellerInfoEntity objSellerInfoEntity = imp.GetSellerInfoEntity(objPaddyStockInfoEntity.SellerID, YesNo.Null);
                    if (objSellerInfoEntity != null)
                    {
                        objPaddyStockDTO.SellerName = objSellerInfoEntity.Name;
                    }

                    MPaddyTypeEntity objMPaddyTypeEntity = imp.GetMPaddyTypeEntity(objPaddyStockInfoEntity.PaddyTypeID, YesNo.Null);
                    if (objMPaddyTypeEntity != null)
                    {
                        objPaddyStockDTO.PaddyName = objMPaddyTypeEntity.Name;
                    }

                    MUnitsTypeEntity objMUnitsTypeEntity = imp.GetMUnitsTypeEntity(objPaddyStockInfoEntity.UnitsTypeID, YesNo.Null);
                    if (objMUnitsTypeEntity != null)
                    {
                        objPaddyStockDTO.UnitName = objMUnitsTypeEntity.UnitsType;
                    }

                    objPaddyStockDTO.DriverName = objPaddyStockInfoEntity.DriverName;
                    objPaddyStockDTO.Price = objPaddyStockInfoEntity.Price;
                    objPaddyStockDTO.PurchaseDate = objPaddyStockInfoEntity.PurchaseDate;
                    objPaddyStockDTO.TotalBags = objPaddyStockInfoEntity.TotalBags;
                    objPaddyStockDTO.VehicalNo = objPaddyStockInfoEntity.VehicalNo;
                    listPaddyStockDTO.Add(objPaddyStockDTO);
                }
            }

            return listPaddyStockDTO;
        }


        public ResultDTO SaveÜserInfo(string userName, string passWord, string custId)
        {
            UsersEntity objUsersEntity = new UsersEntity();
            objUsersEntity.ObsInd = YesNo.N;
            objUsersEntity.CustID = custId;
            objUsersEntity.LastModifiedBy = provider.GetLoggedInUserId();
            objUsersEntity.PassWord = Utilities.Encrypt(passWord, true);
            objUsersEntity.UserID = CommonUtil.CreateUniqueID("UI");
            objUsersEntity.Name = userName;
            objUsersEntity.LastModifiedDate = DateTime.Now;
            try
            {
                imp.BeginTransaction();
                imp.SaveOrUpdateUsersEntity(objUsersEntity, false);
                imp.CommitAndCloseSession();
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                return new ResultDTO() { IsSuccess = false, Message = "Not working" };
            }
            return new ResultDTO() { Message = "User Name created" };
        }


        public ResultDTO SaveÜserRole(string userId, string roleId, string custId)
        {
            RMUserRoleEntity objUsersEntity = new RMUserRoleEntity();
            objUsersEntity.ObsInd = YesNo.N;
            objUsersEntity.CustID = custId;
            objUsersEntity.LastModifiedBy = provider.GetLoggedInUserId();
            objUsersEntity.UserID = userId;
            objUsersEntity.UserRoleId = CommonUtil.CreateUniqueID("UR");
            objUsersEntity.RoleId = roleId;
            objUsersEntity.LastModifiedDate = DateTime.Now;
            try
            {
                imp.BeginTransaction();
                imp.SaveOrUpdateUserRoleEntity(objUsersEntity, false);
                imp.CommitAndCloseSession();
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                return new ResultDTO() { IsSuccess = false, Message = "Not working" };
            }
            return new ResultDTO() { Message = "User Name created" };
        }


        public UsersEntity ValidateUsersEntity(string userName, string custId, string password)
        {
            UsersEntity userEntity = imp.GetUsersEntity(userName, custId, YesNo.N); 
            if (userEntity != null)
            {
                if (password.Equals(Utilities.Decrypt(userEntity.PassWord, true)))
                    return userEntity;

            }

            return null;
        }


        public List<RMUserRoleEntity> GetUserRoles(string userName, string custId)
        {
            List<RMUserRoleEntity> listRMUserRoleEntity = null;
            UsersEntity objUsersEntity = GetUsersEntity(userName, custId);
            if (objUsersEntity != null)
            {
                return imp.GetUserRoleEntities(objUsersEntity.UserID, YesNo.N);

            }
            return listRMUserRoleEntity;
        }

        public UsersEntity GetUsersEntity(string userName, string custId)
        {
            return imp.GetUsersEntity(userName, custId, YesNo.N);
        }


        public ResultDTO SaveHullingProcessExpensesInfo(string HullingProcessID, double PowerExpenses, double LabourExpenses, double OtherExpenses)
        {
            HullingProcessExpensesEntity objHullingProcessExpensesEntity = new HullingProcessExpensesEntity();
            objHullingProcessExpensesEntity.ObsInd = YesNo.N;
            objHullingProcessExpensesEntity.HullingProcessExpenID = CommonUtil.CreateUniqueID("HPE");
            objHullingProcessExpensesEntity.HullingProcessID = HullingProcessID;
            objHullingProcessExpensesEntity.CustID = provider.GetCurrentCustomerId();
            objHullingProcessExpensesEntity.PowerExpenses = PowerExpenses;
            objHullingProcessExpensesEntity.LabourExpenses = LabourExpenses;
            objHullingProcessExpensesEntity.OtherExpenses = OtherExpenses;
            objHullingProcessExpensesEntity.LastModifiedBy = provider.GetLoggedInUserId();
            objHullingProcessExpensesEntity.LastModifiedDate = DateTime.Now;

            try
            {
                imp.BeginTransaction();
                imp.SaveOrUpdateHullingProcessExpensesInfoEntity(objHullingProcessExpensesEntity, false);
                imp.CommitAndCloseSession();
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.Error08, provider.GetCurrentCustomerId()) };
            }
            return new ResultDTO() { Message = msgInstance.GetMessage(RMSConstants.Success08, provider.GetCurrentCustomerId()) };
        }
        public List<HullingProcessExpensesEntity> GetAllHullingProcessExpensesEntities()
        {
            return imp.GetAllHullingProcessExpensesEntity(provider.GetCurrentCustomerId(), YesNo.N);
        }




        public ResultDTO SaveBuyerSellerRating(string SellerID, Int16 Rating, string Remarks)
        {
            BuyerSellerRatingEntity objBuyerSellerRatingEntity = new BuyerSellerRatingEntity();
            objBuyerSellerRatingEntity.ObsInd = YesNo.N;
            objBuyerSellerRatingEntity.BRMSID = CommonUtil.CreateUniqueID("BRM");
            objBuyerSellerRatingEntity.SellerID = SellerID;
            objBuyerSellerRatingEntity.CustID = provider.GetCurrentCustomerId();
            objBuyerSellerRatingEntity.Rating = Rating;
            objBuyerSellerRatingEntity.Remarks = Remarks;
            objBuyerSellerRatingEntity.LastModifiedBy = provider.GetLoggedInUserId();
            objBuyerSellerRatingEntity.LastModifiedDate = DateTime.Now;

            try
            {
                imp.BeginTransaction();
                imp.SaveOrUpdateBuyyerSellerRatingEnity(objBuyerSellerRatingEntity, false);
                imp.CommitAndCloseSession();
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.Error08, provider.GetCurrentCustomerId()) };
            }
            return new ResultDTO() { Message = msgInstance.GetMessage(RMSConstants.Success08, provider.GetCurrentCustomerId()) };

        }

        public List<BuyerSellerRatingEntity> GetAllBuyerSellerRatingEntities()
        {
            return imp.GetAllBuyerSellerRatingEntities(provider.GetCurrentCustomerId(), YesNo.N);
        }
        public ResultDTO SaveBuyerInfo(string name, string street, string street1, string town, string city, string district, string state, string pincode, string contactNo, string mobileNo, string phoneNo)
        {
            BuyerInfoEntity objBuyerInfoEntity = new BuyerInfoEntity();
            objBuyerInfoEntity.ObsInd = YesNo.N;
            objBuyerInfoEntity.CustID = provider.GetCurrentCustomerId();
            objBuyerInfoEntity.LastModifiedBy = provider.GetLoggedInUserId();
            objBuyerInfoEntity.City = city;
            objBuyerInfoEntity.ContactNo = contactNo;
            objBuyerInfoEntity.LastModifiedDate = DateTime.Now;
            objBuyerInfoEntity.District = district;
            objBuyerInfoEntity.MobileNo = mobileNo;
            objBuyerInfoEntity.Name = name;
            objBuyerInfoEntity.PhoneNo = phoneNo;
            objBuyerInfoEntity.PinCode = pincode;
            objBuyerInfoEntity.State = state;
            objBuyerInfoEntity.Street = street;
            objBuyerInfoEntity.Street1 = street1;
            objBuyerInfoEntity.BuyerID = CommonUtil.CreateUniqueID("BI");

            try
            {
                imp.BeginTransaction();
                imp.SaveOrUpdateBuyerInfoEntity(objBuyerInfoEntity, false);
                imp.CommitAndCloseSession();
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.Error07, provider.GetCurrentCustomerId()) };
            }
            return new ResultDTO() { Message = msgInstance.GetMessage(RMSConstants.Success07, provider.GetCurrentCustomerId()) };
        }

        public List<BuyerInfoEntity> GetBuyerInfo()
        {
            return imp.GetListBuyerInfoEntities(YesNo.N);
        }

        public List<BuyerInfoEntity> GetBuyerInfo(int count, string prefixText,string context)
        {
            return imp.GetBuyerInfoEntities(context, YesNo.N, count, prefixText);
        }


        public ResultDTO SaveEmployeeDetails(string name, string street, string street1, string town, string city, string district, string state, string pincode, string contactNo, string mobileNo, string phoneNo)
        {
            EmployeeDetailsEntity objEmployeeDetailsEntity = new EmployeeDetailsEntity();
            objEmployeeDetailsEntity.ObsInd = YesNo.N;
            objEmployeeDetailsEntity.CustID = provider.GetCurrentCustomerId();
            objEmployeeDetailsEntity.LastModifiedBy = provider.GetLoggedInUserId();
            objEmployeeDetailsEntity.City = city;
            objEmployeeDetailsEntity.ContactNo = contactNo;
            objEmployeeDetailsEntity.LastModifiedDate = DateTime.Now;
            objEmployeeDetailsEntity.District = district;
            objEmployeeDetailsEntity.MobileNo = mobileNo;
            objEmployeeDetailsEntity.Name = name;
            objEmployeeDetailsEntity.PhoneNo = phoneNo;
            objEmployeeDetailsEntity.PinCode = pincode;
            objEmployeeDetailsEntity.State = state;
            objEmployeeDetailsEntity.Street = street;
            objEmployeeDetailsEntity.Street1 = street1;
            objEmployeeDetailsEntity.EmployeeID = CommonUtil.CreateUniqueID("EI");

            try
            {
                imp.BeginTransaction();
                imp.SaveOrUpdateEmployeeDetailsEntity(objEmployeeDetailsEntity, false);
                imp.CommitAndCloseSession();
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.Error07, provider.GetCurrentCustomerId()) };
            }
            return new ResultDTO() { Message = msgInstance.GetMessage(RMSConstants.Success07, provider.GetCurrentCustomerId()) };
        }

        public List<EmployeeDetailsEntity> GetEmployeeDetails()
        {
            List<EmployeeDetailsEntity> listEmployeeDetailsEntity = null;
            List<EmployeeDetailsEntity> listEmployeeDetails = imp.GetListEmployeeDetailsEntities(provider.GetCurrentCustomerId(), YesNo.N);
            if (listEmployeeDetails != null && listEmployeeDetails.Count > 0)
            {
                listEmployeeDetailsEntity = new List<EmployeeDetailsEntity>();
                foreach (EmployeeDetailsEntity objEmployeeinfo in listEmployeeDetails)
                {

                    EmployeeDetailsEntity objEmployeeDetailsEntity = new EmployeeDetailsEntity();
                    objEmployeeDetailsEntity.EmployeeID = objEmployeeinfo.EmployeeID;
                    objEmployeeDetailsEntity.Name = objEmployeeinfo.Name;
                    listEmployeeDetailsEntity.Add(objEmployeeDetailsEntity);
                }

            }
            return listEmployeeDetailsEntity;

        }

        public List<EmployeeDetailsEntity> GetEmployeeDetails(string context,int count,string prefixText)
        {
            List<EmployeeDetailsEntity> listEmployeeDetailsEntity = null;
            List<EmployeeDetailsEntity> listEmployeeDetails = imp.GetEmployeeDetailsEntities(context, YesNo.N, count,prefixText);
            if (listEmployeeDetails != null && listEmployeeDetails.Count > 0)
            {
                listEmployeeDetailsEntity = new List<EmployeeDetailsEntity>();
                foreach (EmployeeDetailsEntity objEmployeeinfo in listEmployeeDetails)
                {

                    EmployeeDetailsEntity objEmployeeDetailsEntity = new EmployeeDetailsEntity();
                    objEmployeeDetailsEntity.EmployeeID = objEmployeeinfo.EmployeeID;
                    objEmployeeDetailsEntity.Name = objEmployeeinfo.Name;
                    listEmployeeDetailsEntity.Add(objEmployeeDetailsEntity);
                }

            }
            return listEmployeeDetailsEntity;

        }


        public bool CheckEmployeeExist(string EmployeeName)
        {
            bool IsEmployeeExist = false;

            EmployeeDetailsEntity EmployeeDetailsEntity = imp.CheckEmployeeExist(provider.GetCurrentCustomerId(), EmployeeName, YesNo.N);
            if (EmployeeDetailsEntity != null)
                IsEmployeeExist = true;

            return IsEmployeeExist;
        }
        public bool CheckEmployeeSalaryExist(string EmployeeID)
        {
            bool IsEmployeeSalaryExist = false;
            EmployeeSalaryEntity EmployeeSalaryEntity = imp.CheckEmployeeSalaryExist(provider.GetCurrentCustomerId(), EmployeeID, YesNo.N);
            if (EmployeeSalaryEntity != null)
                IsEmployeeSalaryExist = true;
            return IsEmployeeSalaryExist;
        }

        public ResultDTO SaveEmployeeSalary(string EmployeeID, string SalaryTypeID, string EmpDesigID, double Salary)
        {
            EmployeeSalaryEntity objEmployeeSalaryEntity = new EmployeeSalaryEntity();
            objEmployeeSalaryEntity.ObsInd = YesNo.N;
            objEmployeeSalaryEntity.CustID = provider.GetCurrentCustomerId();
            objEmployeeSalaryEntity.LastModifiedBy = provider.GetLoggedInUserId();
            objEmployeeSalaryEntity.EmployeeID = EmployeeID;
            objEmployeeSalaryEntity.MSalaryTypeID = SalaryTypeID;
            objEmployeeSalaryEntity.LastModifiedDate = DateTime.Now;
            objEmployeeSalaryEntity.MEmpDsgID = EmpDesigID;
            objEmployeeSalaryEntity.Salary = Salary;
            objEmployeeSalaryEntity.EmpSalaryID = CommonUtil.CreateUniqueID("ES");

            try
            {
                imp.BeginTransaction();
                imp.SaveOrUpdateEmployeeSalaryEntity(objEmployeeSalaryEntity, false);
                imp.CommitAndCloseSession();
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.Error07, provider.GetCurrentCustomerId()) };
            }
            return new ResultDTO() { Message = msgInstance.GetMessage(RMSConstants.Success07, provider.GetCurrentCustomerId()) };
        }

        public List<EmployeeSalaryEntity> GetEmployeeSalary()
        {
            return imp.GetAllEmployeeSalaryEntities(provider.GetCurrentCustomerId(), YesNo.N);
        }


        public string GetEmployeeName(string EmployeeID)
        {
            string EmployeeName = string.Empty;
            EmployeeDetailsEntity EmployeeDetails = imp.GetEmployeeDetailsEntity(provider.GetCurrentCustomerId(), EmployeeID, YesNo.N);
            if (EmployeeDetails != null) 
                EmployeeName = EmployeeDetails.Name;

            return EmployeeName;
        }


        public EmployeeSalaryEntity GetEmployeeSalaryEntity(string EmployeeID)
        {
            return imp.GetEmployeeSalaryEntity(provider.GetCurrentCustomerId(), EmployeeID, YesNo.N);
        }



        public ResultDTO SaveEmployeeSalaryPayment(string EmployeeID, string SalaryTypeID, string EmpDesigID, double Salary, double AmountSpent, double ExtraCharges)
        {
            EmployeeSalaryPaymentEntity objEmployeeSalaryPaymentEntity = new EmployeeSalaryPaymentEntity();

            objEmployeeSalaryPaymentEntity.ExpTranID = CommonUtil.CreateUniqueID("ET");
            objEmployeeSalaryPaymentEntity.CustID = provider.GetCurrentCustomerId();
            objEmployeeSalaryPaymentEntity.EmployeeID = EmployeeID;
            objEmployeeSalaryPaymentEntity.MSalaryTypeID = SalaryTypeID;
            objEmployeeSalaryPaymentEntity.MEmpDsgID = EmpDesigID;
            objEmployeeSalaryPaymentEntity.Salary = Salary;
            objEmployeeSalaryPaymentEntity.AmountSpent = AmountSpent;
            objEmployeeSalaryPaymentEntity.ExtraCharges = ExtraCharges;
            objEmployeeSalaryPaymentEntity.PaymentDate = DateTime.Now;
            objEmployeeSalaryPaymentEntity.LastModifiedBy = provider.GetLoggedInUserId();
            objEmployeeSalaryPaymentEntity.LastModifiedDate = DateTime.Now;
            objEmployeeSalaryPaymentEntity.ObsInd = YesNo.N;
            try
            {
                imp.BeginTransaction();
                imp.SaveOrUpdateEmployeeSalaryPaymentEntity(objEmployeeSalaryPaymentEntity, false);
                imp.CommitAndCloseSession();
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.Error07, provider.GetCurrentCustomerId()) };
            }
            return new ResultDTO() { Message = msgInstance.GetMessage(RMSConstants.Success07, provider.GetCurrentCustomerId()) };
        }

        public List<EmployeeSalaryPaymentEntity> GetEmployeeSalaryPayment()
        {
            return imp.GetAllEmployeeSalaryPaymentEntities(provider.GetCurrentCustomerId(), YesNo.N);
        }


        public List<EmployeeSalaryPaymentEntity> GetSalaryPaymentOnEmployee(string EmployeeID)
        {

            List<EmployeeSalaryPaymentEntity> listEmployeeSalaryPaymentEntity = null;
            List<EmployeeSalaryPaymentEntity> listEmployeeSalaryPayment = imp.GetSalaryPaymentOnEmployee(provider.GetCurrentCustomerId(), EmployeeID, YesNo.N);
            if (listEmployeeSalaryPayment != null && listEmployeeSalaryPayment.Count > 0)
            {
                listEmployeeSalaryPaymentEntity = new List<EmployeeSalaryPaymentEntity>();
                foreach (EmployeeSalaryPaymentEntity objEmployeeinfo in listEmployeeSalaryPayment)
                {
                    EmployeeSalaryPaymentEntity objEmployeeSalaryPaymentEntity = new EmployeeSalaryPaymentEntity();
                    objEmployeeSalaryPaymentEntity.ExpTranID = objEmployeeinfo.ExpTranID;
                    objEmployeeSalaryPaymentEntity.PaymentDate = objEmployeeinfo.PaymentDate;
                    objEmployeeSalaryPaymentEntity.AmountSpent = objEmployeeinfo.AmountSpent;
                    objEmployeeSalaryPaymentEntity.ExtraCharges = objEmployeeinfo.ExtraCharges;
                    listEmployeeSalaryPaymentEntity.Add(objEmployeeSalaryPaymentEntity);
                }
            }
            return listEmployeeSalaryPaymentEntity;
        }


        public int GetMPaddyTypeEntitiesCount()
        {
           int paddyCount=  imp.GetMPaddyTypeEntitiesCount(provider.GetCurrentCustomerId(), YesNo.N);
           int paddyUsedCount = imp.GetPaddyStockUsedCount(provider.GetCurrentCustomerId(), YesNo.N);
           if (paddyCount > paddyUsedCount)
               paddyCount = paddyCount - paddyUsedCount;
           return paddyCount;
        }

        public int GetBrokenRiceStockInfoCount()
        {
            return imp.GetBrokenRiceStockInfoCount(provider.GetCurrentCustomerId(), YesNo.N);
        }

        public int GetMRiceProductionTypeCount()
        {
            return imp.GetMRiceProductionTypeCount(provider.GetCurrentCustomerId(), YesNo.N);
        }
		public ResultDTO SaveOtherExpenses(string Description, string GivenTo, double PaidAmount)
        {
            OtherExpensesEntity objOtherExpensesEntity = new OtherExpensesEntity();

            objOtherExpensesEntity.ExpTranID = CommonUtil.CreateUniqueID("ET");
            objOtherExpensesEntity.CustID = provider.GetCurrentCustomerId();
            objOtherExpensesEntity.Description = Description;
            objOtherExpensesEntity.GivenTo = GivenTo;
            objOtherExpensesEntity.AmountSpent = PaidAmount;
            objOtherExpensesEntity.PaymentDate = DateTime.Now;
            objOtherExpensesEntity.LastModifiedBy = provider.GetLoggedInUserId();
            objOtherExpensesEntity.LastModifiedDate = DateTime.Now;
            objOtherExpensesEntity.ObsInd = YesNo.N;
            try
            {
                imp.BeginTransaction();
                imp.SaveOrUpdateOtherExpensesEntity(objOtherExpensesEntity, false);
                imp.CommitAndCloseSession();
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.Error07, provider.GetCurrentCustomerId()) };
            }
            return new ResultDTO() { Message = msgInstance.GetMessage(RMSConstants.Success07, provider.GetCurrentCustomerId()) };

        }

        public List<OtherExpensesEntity> GetAllOtherExpenses()
        {
            List<OtherExpensesEntity> listOtherExpensesEntity = null;
            List<OtherExpensesEntity> listOtherExpenses = imp.GetAllOtherExpensesEntities(provider.GetCurrentCustomerId(), YesNo.N);
            if (listOtherExpenses != null && listOtherExpenses.Count > 0)
            {
                listOtherExpensesEntity = new List<OtherExpensesEntity>();
                foreach (OtherExpensesEntity objOtherExpenses in listOtherExpenses)
                {
                    OtherExpensesEntity objOtherExpensesEntity = new OtherExpensesEntity();
                    objOtherExpensesEntity.ExpTranID = objOtherExpenses.ExpTranID;
                    objOtherExpensesEntity.PaymentDate = objOtherExpenses.PaymentDate;
                    objOtherExpensesEntity.AmountSpent = objOtherExpenses.AmountSpent;
                    objOtherExpensesEntity.GivenTo = objOtherExpenses.GivenTo;
                    objOtherExpensesEntity.Description = objOtherExpenses.Description;
                    listOtherExpensesEntity.Add(objOtherExpensesEntity);
                }
            }
            return listOtherExpensesEntity;
        }


        public ResultDTO SaveProductPaymentInfo(double TotalAmount, char Status)
        {
            throw new NotImplementedException();
        }

        public List<ProductPaymentInfoEntity> GetAllProductPaymentInfo()
        {
            throw new NotImplementedException();
        }
    }
}
