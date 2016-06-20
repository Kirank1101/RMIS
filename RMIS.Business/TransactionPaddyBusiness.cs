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



        public Domain.DataTranserClass.ResultDTO SavePaddyStockInfo(string sellerId, string paddyTypeId, string godownId, string lotId, string UnitsTypeID, string vehicleNo, string DriverName, int totalBags, double Price, DateTime purchaseDate)
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
            List<SellerInfoEntity> listSellerinfo = imp.GetListSellerInfoEntities(provider.GetCurrentCustomerId(), YesNo.N);
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

        public List<SellerInfoEntity> GetPaddySellerInfo(int count, string prefixText, string context)
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


        public ResultDTO SaveBagStockInfo(string sellerId, string vehicleNo, string DriverName, int totalBags, double Price, DateTime purchaseDate, string RiceBrandID, string UnitTypeID)
        {
            BagStockInfoEntity objBagStockInfoEntity = new BagStockInfoEntity();
            objBagStockInfoEntity.ObsInd = YesNo.N;
            objBagStockInfoEntity.CustID = provider.GetCurrentCustomerId();
            objBagStockInfoEntity.LastModifiedBy = provider.GetLoggedInUserId();
            objBagStockInfoEntity.LastModifiedDate = DateTime.Now;
            objBagStockInfoEntity.BagStockID = CommonUtil.CreateUniqueID("BS");
            objBagStockInfoEntity.MRiceBrandID = RiceBrandID;
            objBagStockInfoEntity.UnitsTypeID = UnitTypeID;
            objBagStockInfoEntity.PurchaseDate = purchaseDate;
            objBagStockInfoEntity.Price = Price;
            objBagStockInfoEntity.SellerID = sellerId;
            objBagStockInfoEntity.TotalBags = totalBags;
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
        public ResultDTO SaveRiceStockInfo(string MRiceProdTypeID, string MRiceBrandID, int totalBags, string UnitsTypeID)
        {
            RiceStockInfoEntity objRiceStockInfoEntity = new RiceStockInfoEntity();
            objRiceStockInfoEntity.CustID = provider.GetCurrentCustomerId();
            objRiceStockInfoEntity.ObsInd = YesNo.N;
            objRiceStockInfoEntity.LastModifiedBy = provider.GetLoggedInUserId();
            objRiceStockInfoEntity.LastModifiedDate = DateTime.Now;
            objRiceStockInfoEntity.RiceStockID = CommonUtil.CreateUniqueID("RS");
            objRiceStockInfoEntity.MRiceProdTypeID = MRiceProdTypeID;
            objRiceStockInfoEntity.MRiceBrandID = MRiceBrandID;
            objRiceStockInfoEntity.UnitsTypeID = UnitsTypeID;
            objRiceStockInfoEntity.TotalBags = totalBags;
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
            return imp.GetAllRiceStockInfoEntities(provider.GetCurrentCustomerId(), YesNo.N);
        }
        public ResultDTO SaveBrokenRiceStockInfo(string BrokenRiceTypeId, int totalBags, string UnitsTypeID)
        {
            BrokenRiceStockInfoEntity objBrokenRiceStockInfoEntity = new BrokenRiceStockInfoEntity();
            objBrokenRiceStockInfoEntity.CustID = provider.GetCurrentCustomerId();
            objBrokenRiceStockInfoEntity.ObsInd = YesNo.N;
            objBrokenRiceStockInfoEntity.LastModifiedBy = provider.GetLoggedInUserId();
            objBrokenRiceStockInfoEntity.LastModifiedDate = DateTime.Now;
            objBrokenRiceStockInfoEntity.BrokenRiceStockID = CommonUtil.CreateUniqueID("BR");
            objBrokenRiceStockInfoEntity.BrokenRiceTypeID = BrokenRiceTypeId;
            objBrokenRiceStockInfoEntity.UnitsTypeID = UnitsTypeID;
            objBrokenRiceStockInfoEntity.TotalBags = totalBags;

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
            return imp.GetAllBrokenRiceStockInfoEntities(provider.GetCurrentCustomerId(), YesNo.N);
        }
        public ResultDTO SaveDustStockInfo(int totalBags, string UnitsTypeID)
        {
            DustStockInfoEntity objDustStockInfoEntity = new DustStockInfoEntity();
            objDustStockInfoEntity.CustID = provider.GetCurrentCustomerId();
            objDustStockInfoEntity.ObsInd = YesNo.N;
            objDustStockInfoEntity.LastModifiedBy = provider.GetLoggedInUserId();
            objDustStockInfoEntity.LastModifiedDate = DateTime.Now;
            objDustStockInfoEntity.DustStockID = CommonUtil.CreateUniqueID("DU");
            objDustStockInfoEntity.UnitsTypeID = UnitsTypeID;
            objDustStockInfoEntity.TotalBags = totalBags;
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
            return imp.GetAllDustStockInfoEntities(provider.GetCurrentCustomerId(), YesNo.N);
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
            return imp.GetMenuConfigurationEntities(provider.GetCurrentCustomerId(), YesNo.N);
        }

        public List<MenuConfigurationEntity> GetMenuConfigurationEntities(string custId)
        {
            return imp.GetMenuConfigurationEntities(custId, YesNo.N);
        }




        public ResultDTO SaveProductSellingInfo(string SellingProductType, string BuyerId, string MRiceProdTypeID, string MRiceBrandId, string BrokenRiceTypeId, int totalBags, string UnitsTypeID, double Price, DateTime SellingDate, string OrderNo, string PaymentMode,
                                         string ChequeNo, string DDno, string BankName, double ReceivedAmount, DateTime NextPaymentDate)
        {

            ProductPaymentInfoEntity productPaymentInfoEntity = new ProductPaymentInfoEntity();
            productPaymentInfoEntity.ProductPaymentID = CommonUtil.CreateUniqueID("PP");
            productPaymentInfoEntity.CustID = provider.GetCurrentCustomerId();
            productPaymentInfoEntity.TotalAmount = totalBags * Price;
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
            ProdPayTranEnt.BuyerID = BuyerId;
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
            objProductSellingInfoEntity.BuyerID = BuyerId;
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
            return imp.GetAllproductSellingInfoEntities(provider.GetCurrentCustomerId(), YesNo.N);
        }


        public ResultDTO SaveHullingProcessInfo(string PaddyTypeID, string UnitsTypeID, string GodownID, string LotID, int TotalPaddyBags, double paddyprice, DateTime HullingProcessDate, string HullingProcessBy, string Status)
        {
            HullingProcessEntity objHullingProcessEntity = new HullingProcessEntity();
            objHullingProcessEntity.ObsInd = YesNo.N;
            objHullingProcessEntity.HullingProcessID = CommonUtil.CreateUniqueID("HP");
            objHullingProcessEntity.PaddyTypeID = PaddyTypeID;
            objHullingProcessEntity.CustID = provider.GetCurrentCustomerId();
            objHullingProcessEntity.UnitsTypeID = UnitsTypeID;
            objHullingProcessEntity.MGodownID = GodownID;
            objHullingProcessEntity.MLotID = LotID;
            objHullingProcessEntity.TotalBags = TotalPaddyBags;
            objHullingProcessEntity.Price = paddyprice;
            objHullingProcessEntity.ProcessDate = HullingProcessDate;
            objHullingProcessEntity.ProcessedBy = HullingProcessBy;
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
                return new ResultDTO() { ID = objHullingProcessEntity.HullingProcessID, IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.Error08, provider.GetCurrentCustomerId()) };
            }
            return new ResultDTO() { ID = objHullingProcessEntity.HullingProcessID, Message = msgInstance.GetMessage(RMSConstants.Success08, provider.GetCurrentCustomerId()) };
        }
        public HullingProcessDTO GetAllHullingProcessInfoEntities()
        {
            HullingProcessDTO objHullingProcessDTO = null;
            List<HullingProcessEntity> listHullingProcessExpensesEntity = imp.GetAllHullingProcessInfoEntity(provider.GetCurrentCustomerId(), YesNo.N);
            if (listHullingProcessExpensesEntity != null && listHullingProcessExpensesEntity.Count > 0)
            {
                foreach (HullingProcessEntity objHullingProcessEntity in listHullingProcessExpensesEntity)
                {
                    objHullingProcessDTO = new HullingProcessDTO();
                    objHullingProcessDTO.HullingProcessID = objHullingProcessEntity.HullingProcessID;
                    objHullingProcessDTO.PaddyTypeID = objHullingProcessEntity.PaddyTypeID;
                    objHullingProcessDTO.CustID = objHullingProcessEntity.CustID;
                    objHullingProcessDTO.UnitsTypeID = objHullingProcessEntity.UnitsTypeID;
                    objHullingProcessDTO.MGodownID = objHullingProcessEntity.MGodownID;
                    objHullingProcessDTO.MLotID = objHullingProcessEntity.MLotID;
                    objHullingProcessDTO.Price = objHullingProcessEntity.Price;
                    objHullingProcessDTO.TotalBags = objHullingProcessEntity.TotalBags;
                    objHullingProcessDTO.ProcessedBy = objHullingProcessEntity.ProcessedBy;
                    objHullingProcessDTO.ProcessDate = objHullingProcessEntity.ProcessDate;
                    objHullingProcessDTO.Status = objHullingProcessEntity.Status;
                }
            }
            return objHullingProcessDTO;
        }
        public ResultDTO SaveHullingProcessTransInfo(string HullingProcessID, string RiceTypeID, string RiceBrandID, string riceUnittypeID, int ricetotalbags,
                         List<BrokenRiceStockDetailsDTO> listBrokenRiceDetails, string DustUnitsTypeID, int DustTotalBags, double DustPriceperbag, double PowerExpenses, double LabourExpenses, double OtherExpenses)
        {

            try
            {
                #region SaveHullingTransaction
                List<HullingProcessTransactionEntity> lstHPT = new List<HullingProcessTransactionEntity>();
                List<BrokenRiceStockInfoEntity> lstBRStock = new List<BrokenRiceStockInfoEntity>();
                HullingProcessTransactionEntity RiceTranEntity = new HullingProcessTransactionEntity();
                RiceTranEntity.HullingTransID = CommonUtil.CreateUniqueID("HT");
                RiceTranEntity.HullingProcessID = HullingProcessID;
                RiceTranEntity.MRiceProdTypeID = RiceTypeID;
                RiceTranEntity.MRiceBrandID = RiceBrandID;
                RiceTranEntity.CustID = provider.GetCurrentCustomerId();
                RiceTranEntity.UnitsTypeID = riceUnittypeID;
                RiceTranEntity.TotalBags = ricetotalbags;
                RiceTranEntity.Price = 0;
                RiceTranEntity.LastModifiedBy = provider.GetLoggedInUserId();
                RiceTranEntity.LastModifiedDate = DateTime.Now;
                RiceTranEntity.ObsInd = YesNo.N;
                lstHPT.Add(RiceTranEntity);
                foreach (BrokenRiceStockDetailsDTO BRD in listBrokenRiceDetails)
                {
                    HullingProcessTransactionEntity BRTranEntity = new HullingProcessTransactionEntity();
                    BRTranEntity.HullingTransID = CommonUtil.CreateUniqueID("HT");
                    BRTranEntity.HullingProcessID = HullingProcessID;
                    BRTranEntity.BrokenRiceTypeID = BRD.BrokenRiceTypeID;
                    BRTranEntity.CustID = provider.GetCurrentCustomerId();
                    BRTranEntity.UnitsTypeID = BRD.UnitsTypeID;
                    BRTranEntity.TotalBags = BRD.TotalBags;
                    BRTranEntity.Price = BRD.PricePerBag;
                    BRTranEntity.LastModifiedBy = provider.GetLoggedInUserId();
                    BRTranEntity.LastModifiedDate = DateTime.Now;
                    BRTranEntity.ObsInd = YesNo.N;
                    lstHPT.Add(BRTranEntity);

                    BrokenRiceStockInfoEntity BroRiceStock = new BrokenRiceStockInfoEntity();
                    BroRiceStock.BrokenRiceStockID = BRTranEntity.HullingTransID;
                    BroRiceStock.BrokenRiceTypeID = BRD.BrokenRiceTypeID;
                    BroRiceStock.CustID = provider.GetCurrentCustomerId();
                    BroRiceStock.UnitsTypeID = BRD.UnitsTypeID;
                    BroRiceStock.TotalBags = BRD.TotalBags;
                    BroRiceStock.LastModifiedBy = provider.GetLoggedInUserId();
                    BroRiceStock.LastModifiedDate = DateTime.Now;
                    BroRiceStock.ObsInd = YesNo.N;
                    lstBRStock.Add(BroRiceStock);
                }
                HullingProcessTransactionEntity DustTranEntity = new HullingProcessTransactionEntity();
                DustTranEntity.HullingTransID = CommonUtil.CreateUniqueID("HT");
                DustTranEntity.HullingProcessID = HullingProcessID;
                DustTranEntity.CustID = provider.GetCurrentCustomerId();
                DustTranEntity.UnitsTypeID = DustUnitsTypeID;
                DustTranEntity.TotalBags = DustTotalBags;
                DustTranEntity.Price = DustPriceperbag;
                DustTranEntity.LastModifiedBy = provider.GetLoggedInUserId();
                DustTranEntity.LastModifiedDate = DateTime.Now;
                DustTranEntity.ObsInd = YesNo.N;
                lstHPT.Add(DustTranEntity);
                #endregion
                RiceStockInfoEntity Ricestockinfo = new RiceStockInfoEntity();
                Ricestockinfo.RiceStockID = RiceTranEntity.HullingTransID;
                Ricestockinfo.MRiceProdTypeID = RiceTranEntity.MRiceProdTypeID;
                Ricestockinfo.MRiceBrandID = RiceTranEntity.MRiceBrandID;
                Ricestockinfo.CustID = provider.GetCurrentCustomerId();
                Ricestockinfo.UnitsTypeID = RiceTranEntity.UnitsTypeID;
                Ricestockinfo.TotalBags = RiceTranEntity.TotalBags;
                Ricestockinfo.LastModifiedBy = provider.GetLoggedInUserId();
                Ricestockinfo.LastModifiedDate = DateTime.Now;
                Ricestockinfo.ObsInd = YesNo.N;

                DustStockInfoEntity DustStockInfo = new DustStockInfoEntity();
                DustStockInfo.DustStockID = DustTranEntity.HullingTransID;
                DustStockInfo.CustID = provider.GetCurrentCustomerId();
                DustStockInfo.UnitsTypeID = DustTranEntity.UnitsTypeID;
                DustStockInfo.TotalBags = DustTranEntity.TotalBags;
                DustStockInfo.LastModifiedBy = provider.GetLoggedInUserId();
                DustStockInfo.LastModifiedDate = DateTime.Now;
                DustStockInfo.ObsInd = YesNo.N;

                HullingProcessExpensesEntity HPEE = new HullingProcessExpensesEntity();
                HPEE.HullingProcessExpenID = CommonUtil.CreateUniqueID("HPE");
                HPEE.CustID = provider.GetCurrentCustomerId();
                HPEE.HullingProcessID = HullingProcessID;
                HPEE.LabourExpenses = LabourExpenses;
                HPEE.OtherExpenses = OtherExpenses;
                HPEE.PowerExpenses = PowerExpenses;
                HPEE.LastModifiedBy = provider.GetLoggedInUserId();
                HPEE.LastModifiedDate = DateTime.Now;
                HPEE.ObsInd = YesNo.N;

                HullingProcessEntity HPE = new HullingProcessEntity();
                HPE = imp.GetHullingProcessEnitity(provider.GetCurrentCustomerId(), HullingProcessID, YesNo.N);
                HPE.LastModifiedBy = provider.GetLoggedInUserId();
                HPE.LastModifiedDate = DateTime.Now;
                HPE.Status = "A";
                imp.BeginTransaction();

                foreach (HullingProcessTransactionEntity item in lstHPT)
                    imp.SaveOrUpdateHullingProcessTransInfoEntity(item, false);
                imp.SaveOrUpdateRiceStockInfoEntity(Ricestockinfo, false);
                foreach (BrokenRiceStockInfoEntity BRitem in lstBRStock)
                    imp.SaveOrUpdateBrokenRiceStockInfoEntity(BRitem, false);
                imp.SaveOrUpdateDustStockInfoEntity(DustStockInfo, false);
                imp.SaveOrUpdateHullingProcessInfoEntity(HPE, true);
                imp.SaveOrUpdateHullingProcessExpensesInfoEntity(HPEE, false);
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
            return imp.GetAllHullingProcessTransInfoEntity(provider.GetCurrentCustomerId(), YesNo.N);
        }
        public List<PaddyStockDTO> GetPaddyStockDTO(int pageindex, int pageSize, out int count, SortExpression expression)
        {
            List<PaddyStockDTO> listPaddyStockDTO = null;
            List<PaddyStockInfoEntity> listPaddyStockInfoEntity = imp.GetPaddyStockInfoEntity(provider.GetCurrentCustomerId(), pageindex, pageSize, out count, expression, YesNo.N);
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
            List<BuyerInfoEntity> listBuyerInfoEntity = null;
            List<BuyerInfoEntity> listBuyerinfo = imp.GetListBuyerInfoEntities(provider.GetCurrentCustomerId(), YesNo.N);
            if (listBuyerinfo != null && listBuyerinfo.Count > 0)
            {
                listBuyerInfoEntity = new List<BuyerInfoEntity>();
                foreach (BuyerInfoEntity objBuyerinfo in listBuyerinfo)
                {

                    BuyerInfoEntity objBuyerInfoEntity = new BuyerInfoEntity();
                    objBuyerInfoEntity.BuyerID = objBuyerinfo.BuyerID;
                    objBuyerInfoEntity.Name = objBuyerinfo.Name;
                    listBuyerInfoEntity.Add(objBuyerInfoEntity);
                }

            }
            return listBuyerInfoEntity;
        }

        public List<BuyerInfoEntity> GetBuyerInfo(int count, string prefixText, string context)
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

        public List<EmployeeDetailsEntity> GetEmployeeDetails(string context, int count, string prefixText)
        {
            List<EmployeeDetailsEntity> listEmployeeDetailsEntity = null;
            List<EmployeeDetailsEntity> listEmployeeDetails = imp.GetEmployeeDetailsEntities(context, YesNo.N, count, prefixText);
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



        public int GetPaddyStockTotalSum()
        {
            int paddySum = 0;
            paddySum = imp.GetMPaddyTypeEntitiesTotal(provider.GetCurrentCustomerId(), YesNo.N);
            int paddyUsedSum = imp.GetPaddyStockUsedTotal(provider.GetCurrentCustomerId(), YesNo.N);
            if (paddySum > paddyUsedSum)
                paddySum = paddySum - paddyUsedSum;
            if (paddySum > 0)
                return paddySum;
            return 0;
        }

        int GetPaddyStockTotalCount()
        {
            int paddyCount = 0;
            paddyCount = imp.GetPaddyStockEntityCount(provider.GetCurrentCustomerId(), YesNo.N);
            int paddyUsedCount = imp.GetPaddyStockUsedCount(provider.GetCurrentCustomerId(), YesNo.N);
            if (paddyCount > paddyUsedCount)
                paddyCount = paddyCount - paddyUsedCount;
            if (paddyCount > 0)
                return paddyCount;
            return 0;
        }

        public int GetRiceStockTotalSum()
        {
            int riceSum = 0;
            riceSum = imp.GetRiceProductTotal(provider.GetCurrentCustomerId(), YesNo.N);
            int riceUsedSum = imp.GetRiceProductUsedTotal(provider.GetCurrentCustomerId(), YesNo.N);
            if (riceSum > riceUsedSum)
                riceSum = riceSum - riceUsedSum;
            if (riceSum > 0)
                return riceSum;
            return 0;
        }

        public int GetBagStockTotalSum()
        {
            int bagSum = 0;
            bagSum = imp.GetBagStockTotal(provider.GetCurrentCustomerId(), YesNo.N);
            int bagUsedSum = imp.GetBagStockTotalUsed(provider.GetCurrentCustomerId(), YesNo.N);
            if (bagSum > bagUsedSum)
                bagSum = bagSum - bagUsedSum;
            if (bagSum > 0)
                return bagSum;
            return 0;
        }


        public int GetBrockenRiceStockTotalSum()
        {
            int riceSum = 0;
            riceSum = imp.GetBrokenRiceProductTotal(provider.GetCurrentCustomerId(), YesNo.N);
            int riceUsedSum = imp.GetBrokenRiceProductUsedTotal(provider.GetCurrentCustomerId(), YesNo.N);
            if (riceSum > riceUsedSum)
                riceSum = riceSum - riceUsedSum;
            if (riceSum > 0)
                return riceSum;
            return 0;
        }


        public double GetPaddyTotalAmountDue()
        {
            double riceSum = 0;
            riceSum = imp.GetPaddyTotalAmount(provider.GetCurrentCustomerId(), YesNo.N);
            double riceUsedSum = imp.GetPaddyTotalAmountPaid(provider.GetCurrentCustomerId(), YesNo.N);
            if (riceSum > riceUsedSum)
                riceSum = riceSum - riceUsedSum;
            if (riceSum > 0)
                return Math.Round(riceSum, 2, MidpointRounding.ToEven);
            return 0;
        }

        public double GetProductTotalAmountDue()
        {
            double productSum = 0;
            productSum = imp.GetProductTotalAmount(provider.GetCurrentCustomerId(), YesNo.N);
            double productUsedSum = imp.GetProductTotalAmountPaid(provider.GetCurrentCustomerId(), YesNo.N);
            if (productSum > productUsedSum)
                productSum = productSum - productUsedSum;
            if (productSum > 0)
                return Math.Round(productSum, 2, MidpointRounding.ToEven);
            return 0;
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


        public List<WidgetDTO> GetTotalBrokenRiceStockWidget()
        {
            int totalStockSum = GetBrockenRiceStockTotalSum();

            List<WidgetDTO> listTotalBrokenRiceStock = new List<WidgetDTO>();
            List<MBrokenRiceTypeEntity> listMBrokenRiceTypeEntity = imp.GetMBrokenRiceTypeEntitiies(provider.GetCurrentCustomerId(), YesNo.N);
            if (listMBrokenRiceTypeEntity != null && listMBrokenRiceTypeEntity.Count > 0)
            {
                foreach (MBrokenRiceTypeEntity objMBrokenRiceTypeEntity in listMBrokenRiceTypeEntity)
                {
                    List<MUnitsTypeEntity> listMUnitsTypeEntity = imp.GetMUnitsTypeEntities(provider.GetCurrentCustomerId(), YesNo.N);
                    if (listMUnitsTypeEntity != null && listMUnitsTypeEntity.Count > 0)
                    {
                        // <br /> <b></b> &nbsp;
                        foreach (MUnitsTypeEntity objMUnitsTypeEntity in listMUnitsTypeEntity)
                        {
                            int paddySum = imp.GetBrokenRiceProductTotal(provider.GetCurrentCustomerId(), objMUnitsTypeEntity.UnitsTypeID, objMBrokenRiceTypeEntity.BrokenRiceTypeID, YesNo.N);
                            int paddyUsedSum = imp.GetBrokenRiceProductUsedTotal(provider.GetCurrentCustomerId(), objMUnitsTypeEntity.UnitsTypeID, objMBrokenRiceTypeEntity.BrokenRiceTypeID, YesNo.N);
                            if (paddySum > paddyUsedSum)
                                paddySum = paddySum - paddyUsedSum;
                            if (paddySum > 0)
                            {
                                WidgetDTO objTotlaPaddyStock = new WidgetDTO();
                                objTotlaPaddyStock.Headerone = objMBrokenRiceTypeEntity.BrokenRiceName;
                                objTotlaPaddyStock.HeaderTwo = objMUnitsTypeEntity.UnitsType;
                                objTotlaPaddyStock.Value = paddySum.ToString();
                                double percentage = (((double)paddySum / ((double)totalStockSum)));
                                objTotlaPaddyStock.Percentage = Math.Round(percentage * 100, 2, MidpointRounding.ToEven).ToString() + "%";
                                listTotalBrokenRiceStock.Add(objTotlaPaddyStock);
                            }
                        }
                    }
                }
            }
            return listTotalBrokenRiceStock.DistinctBy(A => new { A.Value, A.Headerone }).OrderByDescending(A => A.Value).Take(5).ToList();
        }

        public List<WidgetDTO> GetTotalPaddyStockWidget()
        {
            int totalStockSum = GetPaddyStockTotalSum();
            int totalStockCount = GetPaddyStockTotalCount();

            List<WidgetDTO> listTotlaPaddyStock = new List<WidgetDTO>();
            List<MPaddyTypeEntity> listMPaddyTypeEntity = imp.GetMPaddyTypeEntitiies(provider.GetCurrentCustomerId(), YesNo.N);
            if (listMPaddyTypeEntity != null && listMPaddyTypeEntity.Count > 0)
            {
                foreach (MPaddyTypeEntity objMPaddyTypeEntity in listMPaddyTypeEntity)
                {
                    List<MUnitsTypeEntity> listMUnitsTypeEntity = imp.GetMUnitsTypeEntities(provider.GetCurrentCustomerId(), YesNo.N);
                    if (listMUnitsTypeEntity != null && listMUnitsTypeEntity.Count > 0)
                    {
                        // <br /> <b></b> &nbsp;
                        foreach (MUnitsTypeEntity objMUnitsTypeEntity in listMUnitsTypeEntity)
                        {
                            int paddySum = imp.GetMPaddyTypeEntitiesTotal(provider.GetCurrentCustomerId(), objMUnitsTypeEntity.UnitsTypeID, objMPaddyTypeEntity.PaddyTypeID, YesNo.N);
                            int paddyUsedSum = imp.GetPaddyStockUsedTotal(provider.GetCurrentCustomerId(), objMUnitsTypeEntity.UnitsTypeID, objMPaddyTypeEntity.PaddyTypeID, YesNo.N);
                            if (paddySum > paddyUsedSum)
                                paddySum = paddySum - paddyUsedSum;
                            if (paddySum > 0)
                            {
                                WidgetDTO objTotlaPaddyStock = new WidgetDTO();
                                objTotlaPaddyStock.Headerone = objMPaddyTypeEntity.Name;
                                objTotlaPaddyStock.HeaderTwo = objMUnitsTypeEntity.UnitsType;
                                objTotlaPaddyStock.Value = paddySum.ToString();
                                double percentage = (((double)paddySum / ((double)totalStockSum)));
                                objTotlaPaddyStock.Percentage = Math.Round(percentage * 100, 2, MidpointRounding.ToEven).ToString() + "%";
                                listTotlaPaddyStock.Add(objTotlaPaddyStock);
                            }
                        }
                    }
                }
            }
            return listTotlaPaddyStock.DistinctBy(A => new { A.Value, A.Headerone }).OrderByDescending(A => A.Value).Take(5).ToList();
        }

        public List<WidgetDTO> GetTotalRiceStockWidget()
        {
            int totalStockSum = GetRiceStockTotalSum();
            List<WidgetDTO> listTotlaPaddyStock = new List<WidgetDTO>();
            List<MRiceProductionTypeEntity> listMRiceProductionTypeEntity = imp.GetMRiceProductionTypeEntities(provider.GetCurrentCustomerId(), YesNo.N);
            if (listMRiceProductionTypeEntity != null && listMRiceProductionTypeEntity.Count > 0)
            {
                foreach (MRiceProductionTypeEntity objMRiceProductionTypeEntity in listMRiceProductionTypeEntity)
                {
                    List<MRiceBrandDetailsEntity> listMRiceBrandDetailsEntity = imp.GetMRiceBrandDetailsEntities(provider.GetCurrentCustomerId(), YesNo.N);
                    if (listMRiceBrandDetailsEntity != null && listMRiceBrandDetailsEntity.Count > 0)
                    {
                        foreach (MRiceBrandDetailsEntity objMRiceBrandDetailsEntity in listMRiceBrandDetailsEntity)
                        {

                            List<MUnitsTypeEntity> listMUnitsTypeEntity = imp.GetMUnitsTypeEntities(provider.GetCurrentCustomerId(), YesNo.N);
                            if (listMUnitsTypeEntity != null && listMUnitsTypeEntity.Count > 0)
                            {
                                // <br /> <b></b> &nbsp;
                                foreach (MUnitsTypeEntity objMUnitsTypeEntity in listMUnitsTypeEntity)
                                {
                                    int riceSum = imp.GetRiceProductTotal(provider.GetCurrentCustomerId(), objMUnitsTypeEntity.UnitsTypeID, objMRiceProductionTypeEntity.MRiceProdTypeID, objMRiceBrandDetailsEntity.MRiceBrandID, YesNo.N);
                                    int riceUsedSum = imp.GetRiceProductUsedTotal(provider.GetCurrentCustomerId(), objMUnitsTypeEntity.UnitsTypeID, objMRiceProductionTypeEntity.MRiceProdTypeID, objMRiceBrandDetailsEntity.MRiceBrandID, YesNo.N);
                                    if (riceSum > riceUsedSum)
                                        riceSum = riceSum - riceUsedSum;
                                    if (riceSum > 0)
                                    {
                                        WidgetDTO objTotlaPaddyStock = new WidgetDTO();
                                        objTotlaPaddyStock.Headerone = objMRiceProductionTypeEntity.RiceType + " (" + objMRiceBrandDetailsEntity.Name + ")";
                                        objTotlaPaddyStock.HeaderTwo = objMUnitsTypeEntity.UnitsType;
                                        objTotlaPaddyStock.Value = riceSum.ToString();
                                        double percentage = (((double)riceSum / ((double)totalStockSum)));
                                        objTotlaPaddyStock.Percentage = Math.Round(percentage * 100, 2, MidpointRounding.ToEven).ToString() + "%";
                                        listTotlaPaddyStock.Add(objTotlaPaddyStock);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return listTotlaPaddyStock.DistinctBy(A => new { A.Value, A.Headerone }).OrderByDescending(A => A.Value).Take(5).ToList();
        }

        public List<WidgetDTO> GetTotalBagStockWidget()
        {
            int totalStockSum = GetBagStockTotalSum();
            List<WidgetDTO> listTotlaBagStock = new List<WidgetDTO>();

            List<MRiceBrandDetailsEntity> listMRiceBrandDetailsEntity = imp.GetMRiceBrandDetailsEntities(provider.GetCurrentCustomerId(), YesNo.N);
            if (listMRiceBrandDetailsEntity != null && listMRiceBrandDetailsEntity.Count > 0)
            {
                foreach (MRiceBrandDetailsEntity objMRiceBrandDetailsEntity in listMRiceBrandDetailsEntity)
                {

                    List<MUnitsTypeEntity> listMUnitsTypeEntity = imp.GetMUnitsTypeEntities(provider.GetCurrentCustomerId(), YesNo.N);
                    if (listMUnitsTypeEntity != null && listMUnitsTypeEntity.Count > 0)
                    {
                        // <br /> <b></b> &nbsp;
                        foreach (MUnitsTypeEntity objMUnitsTypeEntity in listMUnitsTypeEntity)
                        {
                            int bagSum = imp.GetBagStockTotal(provider.GetCurrentCustomerId(), objMUnitsTypeEntity.UnitsTypeID, objMRiceBrandDetailsEntity.MRiceBrandID, YesNo.N);
                            int bagUsedSum = imp.GetBagStockTotalUsed(provider.GetCurrentCustomerId(), objMUnitsTypeEntity.UnitsTypeID, objMRiceBrandDetailsEntity.MRiceBrandID, YesNo.N);
                            if (bagSum > bagUsedSum)
                                bagSum = bagSum - bagUsedSum;
                            if (bagSum > 0)
                            {
                                WidgetDTO objTotlaPaddyStock = new WidgetDTO();
                                objTotlaPaddyStock.Headerone = objMRiceBrandDetailsEntity.Name;
                                objTotlaPaddyStock.HeaderTwo = objMUnitsTypeEntity.UnitsType;
                                objTotlaPaddyStock.Value = bagSum.ToString();
                                double percentage = (((double)bagSum / ((double)totalStockSum)));
                                objTotlaPaddyStock.Percentage = Math.Round(percentage * 100, 2, MidpointRounding.ToEven).ToString() + "%";
                                listTotlaBagStock.Add(objTotlaPaddyStock);
                            }
                        }
                    }

                }
            }
            return listTotlaBagStock.DistinctBy(A => new { A.Value, A.Headerone }).OrderByDescending(A => A.Value).Take(5).ToList();
        }

        public double GetPaddyTotalAmountDueBySeller(string sellerId)
        {
            if (!string.IsNullOrEmpty(sellerId))
            {

                double riceSum = imp.GetPaddyTotalAmount(provider.GetCurrentCustomerId(), sellerId, YesNo.N);
                double riceUsedSum = imp.GetPaddyTotalAmountPaid(provider.GetCurrentCustomerId(), sellerId, YesNo.N);
                if (riceSum > riceUsedSum)
                    riceSum = riceSum - riceUsedSum;
                if (riceSum > 0)
                {
                    return riceSum;
                }
            }
            return 0;
        }

        public List<WidgetDTO> GetPaddyTotalAmountDueWidget()
        {
            double totalStockSum = GetPaddyTotalAmountDue();
            List<WidgetDTO> listTotlaPaddyStock = new List<WidgetDTO>();
            List<SellerInfoEntity> listSellerInfoEntity = imp.GetListSellerInfoEntities(provider.GetCurrentCustomerId(), YesNo.N);
            if (listSellerInfoEntity != null && listSellerInfoEntity.Count > 0)
            {
                foreach (SellerInfoEntity objSellerInfoEntity in listSellerInfoEntity)
                {

                    double riceSum = imp.GetPaddyTotalAmount(provider.GetCurrentCustomerId(), objSellerInfoEntity.SellerID, YesNo.N);
                    double riceUsedSum = imp.GetPaddyTotalAmountPaid(provider.GetCurrentCustomerId(), objSellerInfoEntity.SellerID, YesNo.N);
                    if (riceSum > riceUsedSum)
                        riceSum = riceSum - riceUsedSum;
                    if (riceSum > 0)
                    {
                        WidgetDTO objTotlaPaddyStock = new WidgetDTO();
                        objTotlaPaddyStock.Headerone = objSellerInfoEntity.Name;
                        objTotlaPaddyStock.Value = riceSum.ToString();
                        double percentage = (((double)riceSum / ((double)totalStockSum)));
                        objTotlaPaddyStock.Percentage = Math.Round(percentage * 100, 2, MidpointRounding.ToEven).ToString() + "%";
                        listTotlaPaddyStock.Add(objTotlaPaddyStock);
                    }
                }
            }
            return listTotlaPaddyStock.DistinctBy(A => new { A.Value, A.Headerone }).OrderByDescending(A => A.Value).Take(5).ToList();
        }

        public List<WidgetDTO> GetProductTotalAmountDueWidget()
        {
            double totalStockSum = GetProductTotalAmountDue();
            List<WidgetDTO> listTotlaPaddyStock = new List<WidgetDTO>();
            List<BuyerInfoEntity> listBuyerInfoEntity = imp.GetBuyerInfoEntities(provider.GetCurrentCustomerId(), YesNo.N);
            if (listBuyerInfoEntity != null && listBuyerInfoEntity.Count > 0)
            {
                foreach (BuyerInfoEntity objBuyerInfoEntity in listBuyerInfoEntity)
                {

                    double riceSum = imp.GetProductTotalAmount(provider.GetCurrentCustomerId(), objBuyerInfoEntity.BuyerID, YesNo.N);
                    double riceUsedSum = imp.GetProductTotalAmountPaid(provider.GetCurrentCustomerId(), objBuyerInfoEntity.BuyerID, YesNo.N);
                    if (riceSum > riceUsedSum)
                        riceSum = riceSum - riceUsedSum;
                    if (riceSum > 0)
                    {
                        WidgetDTO objTotlaPaddyStock = new WidgetDTO();
                        objTotlaPaddyStock.Headerone = objBuyerInfoEntity.Name;
                        objTotlaPaddyStock.Value = riceSum.ToString();
                        double percentage = (((double)riceSum / ((double)totalStockSum)));
                        objTotlaPaddyStock.Percentage = Math.Round(percentage * 100, 2, MidpointRounding.ToEven).ToString() + "%";
                        listTotlaPaddyStock.Add(objTotlaPaddyStock);
                    }
                }
            }
            return listTotlaPaddyStock.DistinctBy(A => new { A.Value, A.Headerone }).OrderByDescending(A => A.Value).Take(5).ToList();
        }

        public long CheckHullingProcessPaddyCount(string PaddyTypeID, string UnitTypeID, string GodownID, string LotID)
        {

            long paddystockcount = 0;
            long HullingProcesspaddystock = 0;
            List<PaddyStockInfoEntity> listPaddyStockInfoEntity = imp.GetAllPaddyStockInfoEntities(provider.GetCurrentCustomerId(), PaddyTypeID, UnitTypeID, GodownID, LotID, YesNo.N);
            List<HullingProcessEntity> listHullingprocessenty = imp.GetAllHullingProcessPaddyStock(provider.GetCurrentCustomerId(), PaddyTypeID, UnitTypeID, GodownID, LotID, YesNo.N);
            if (listPaddyStockInfoEntity != null && listPaddyStockInfoEntity.Count > 0)
                foreach (PaddyStockInfoEntity objPaddyStockInfoEntity in listPaddyStockInfoEntity)
                    paddystockcount += objPaddyStockInfoEntity.TotalBags;

            if (listHullingprocessenty != null && listHullingprocessenty.Count > 0)
                foreach (HullingProcessEntity objHullingprocessEntity in listHullingprocessenty)
                    HullingProcesspaddystock += objHullingprocessEntity.TotalBags;

            return paddystockcount - HullingProcesspaddystock;
        }


        public List<BagStockDTO> GetBagStockDTO(int pageindex, int pageSize, out int count, SortExpression expression)
        {

            List<BagStockDTO> listBagStockDTO = null;
            List<BagStockInfoEntity> listBagStockInfoEntity = imp.GetBagStockInfoEntity(provider.GetCurrentCustomerId(), pageindex, pageSize, out count, expression, YesNo.N);
            if (listBagStockInfoEntity != null && listBagStockInfoEntity.Count > 0)
            {
                listBagStockDTO = new List<BagStockDTO>();
                foreach (BagStockInfoEntity objBagStockInfoEntity in listBagStockInfoEntity)
                {
                    BagStockDTO objBagStockDTO = new BagStockDTO();
                    objBagStockDTO.Id = objBagStockInfoEntity.BagStockID;
                    SellerInfoEntity objSellerInfoEntity = imp.GetSellerInfoEntity(objBagStockInfoEntity.SellerID, YesNo.Null);
                    if (objSellerInfoEntity != null)
                    {
                        objBagStockDTO.SellerName = objSellerInfoEntity.Name;
                    }
                    //MBagTypeEntity objMbagtypeEntity = imp.GetMBagTypeEntity(objBagStockInfoEntity.BagTypeID, YesNo.Null);
                    //if (objMbagtypeEntity != null)
                    //{
                    //    objBagStockDTO.TypeBrand = objMbagtypeEntity.BagType;
                    //    if (objBagStockInfoEntity.MRiceBrandID != null)
                    //    {
                    MRiceBrandDetailsEntity objMRiceBrandEntity = imp.GetMRiceBrandDetailsEntity(objBagStockInfoEntity.MRiceBrandID, YesNo.Null);
                    if (objMRiceBrandEntity != null)
                    {
                        objBagStockDTO.TypeBrand += objMRiceBrandEntity.Name;
                    }
                    //    }
                    //}
                    MUnitsTypeEntity objMUnitsTypeEntity = imp.GetMUnitsTypeEntity(objBagStockInfoEntity.UnitsTypeID, YesNo.Null);
                    if (objMUnitsTypeEntity != null)
                    {
                        objBagStockDTO.UnitName = objMUnitsTypeEntity.UnitsType;
                    }

                    objBagStockDTO.VehicalNo = objBagStockInfoEntity.VehicalNo;
                    objBagStockDTO.DriverName = objBagStockInfoEntity.DriverName;
                    objBagStockDTO.Price = objBagStockInfoEntity.Price;
                    objBagStockDTO.PurchaseDate = objBagStockInfoEntity.PurchaseDate;
                    objBagStockDTO.TotalBags = objBagStockInfoEntity.TotalBags;
                    objBagStockDTO.TotalAmount = objBagStockInfoEntity.TotalBags * objBagStockInfoEntity.Price;
                    listBagStockDTO.Add(objBagStockDTO);
                }
            }

            return listBagStockDTO;
        }


        public ResultDTO SaveProductSellingInfo(List<ProductSellingInfoDTO> lstProductSellingInfoDTO)
        {
            ProductPaymentInfoEntity productPaymentInfoEntity = new ProductPaymentInfoEntity();
            List<ProductSellingInfoDTO> lstProdSellingDTO = lstProductSellingInfoDTO;

            productPaymentInfoEntity.ProductPaymentID = CommonUtil.CreateUniqueID("PP");
            productPaymentInfoEntity.CustID = provider.GetCurrentCustomerId();
            foreach (ProductSellingInfoDTO PSID in lstProdSellingDTO)
                productPaymentInfoEntity.TotalAmount += PSID.TotalBags * PSID.Price;

            productPaymentInfoEntity.Status = 'P';
            productPaymentInfoEntity.LastModifiedBy = provider.GetLoggedInUserId();
            productPaymentInfoEntity.LastModifiedDate = DateTime.Now;
            productPaymentInfoEntity.ObsInd = YesNo.N;


            List<ProductSellingInfoEntity> lstPSIE = new List<ProductSellingInfoEntity>();
            foreach (ProductSellingInfoDTO ProSIDTO in lstProdSellingDTO)
            {
                ProductSellingInfoEntity objProductSellingInfoEntity = new ProductSellingInfoEntity();
                objProductSellingInfoEntity.ProductID = CommonUtil.CreateUniqueID("PI");
                objProductSellingInfoEntity.ProductPaymentID = productPaymentInfoEntity.ProductPaymentID;
                objProductSellingInfoEntity.CustID = provider.GetCurrentCustomerId();
                objProductSellingInfoEntity.MRiceProdTypeID = ProSIDTO.MRiceProdTypeID;
                objProductSellingInfoEntity.MRiceBrandID = ProSIDTO.MRiceBrandID;
                objProductSellingInfoEntity.BrokenRiceTypeID = ProSIDTO.BrokenRiceTypeID;
                objProductSellingInfoEntity.UnitsTypeID = ProSIDTO.UnitsTypeID;
                objProductSellingInfoEntity.SellingDate = ProSIDTO.ProductSellingDate;
                objProductSellingInfoEntity.Price = ProSIDTO.Price;
                objProductSellingInfoEntity.BuyerID = ProSIDTO.BuyerID;
                objProductSellingInfoEntity.TotalBags = ProSIDTO.TotalBags;
                objProductSellingInfoEntity.LastModifiedBy = provider.GetLoggedInUserId();
                objProductSellingInfoEntity.LastModifiedDate = DateTime.Now;
                objProductSellingInfoEntity.ObsInd = YesNo.N;
                lstPSIE.Add(objProductSellingInfoEntity);
            }



            try
            {
                imp.BeginTransaction();
                imp.SaveOrUpdateProductPaymentInfoEntity(productPaymentInfoEntity, false);
                foreach (ProductSellingInfoEntity ProdSelInfoEnt in lstPSIE)
                    imp.SaveOrUpdateProductSellingInfoEntity(ProdSelInfoEnt, false);

                imp.CommitAndCloseSession();

            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.Error08, provider.GetCurrentCustomerId()) };
            }
            return new ResultDTO() { Message = msgInstance.GetMessage(RMSConstants.Success08, provider.GetCurrentCustomerId()) };
        }


        public ResultDTO CheckRiceStockAvailability(string RiceTypeID, string RiceBrandID, string UnitTypeID, int TotalBags)
        {
            ResultDTO resultDTO = new ResultDTO();
            try
            {
                List<RiceStockInfoEntity> lstricestockinfo = new List<RiceStockInfoEntity>();
                List<ProductSellingInfoEntity> lstprodsellinginfo = new List<ProductSellingInfoEntity>();
                lstricestockinfo = imp.GetAllRiceStockInfoEntities(provider.GetCurrentCustomerId(), RiceTypeID, RiceBrandID, UnitTypeID, YesNo.N);
                lstprodsellinginfo = imp.GetAllproductSellingInfoEntities(provider.GetCurrentCustomerId(), RiceTypeID, RiceBrandID, UnitTypeID, YesNo.N);

                if (lstricestockinfo != null && lstricestockinfo.Count > 0)
                {
                    int TotalProdRiceSell = 0;
                    int totalricestock = 0;
                    totalricestock = lstricestockinfo.Sum(x => x.TotalBags);
                    if (lstprodsellinginfo != null && lstprodsellinginfo.Count > 0)
                        TotalProdRiceSell = lstprodsellinginfo.Sum(y => y.TotalBags);

                    if (TotalBags > (totalricestock - TotalProdRiceSell))
                    {
                        resultDTO.Message = RMSConstants.InsufficiantRiceStock;
                        resultDTO.IsSuccess = false;
                    }
                }
                else
                {
                    resultDTO.Message = RMSConstants.NoStock;
                    resultDTO.IsSuccess = false;
                }

            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.Error08, provider.GetCurrentCustomerId()) };
            }
            return resultDTO;
        }



        public ResultDTO CheckBrokenriceStockAvailability(string BrokenRiceTypeID, string UnitTypeID, int TotalBags)
        {
            ResultDTO resultDTO = new ResultDTO();
            try
            {
                List<BrokenRiceStockInfoEntity> lstBrokenricestockinfo = new List<BrokenRiceStockInfoEntity>();
                List<ProductSellingInfoEntity> lstprodsellinginfo = new List<ProductSellingInfoEntity>();
                lstBrokenricestockinfo = imp.GetAllBrokenRiceStockInfoEntities(provider.GetCurrentCustomerId(), BrokenRiceTypeID, UnitTypeID, YesNo.N);
                lstprodsellinginfo = imp.GetAllproductSellingInfoEntities(provider.GetCurrentCustomerId(), BrokenRiceTypeID, UnitTypeID, YesNo.N);

                if (lstBrokenricestockinfo != null && lstBrokenricestockinfo.Count > 0)
                {
                    int TotalProdBrokenRiceSell = 0;
                    int totalBrokenricestock = 0;
                    totalBrokenricestock = lstBrokenricestockinfo.Sum(x => x.TotalBags);
                    if (lstprodsellinginfo != null && lstprodsellinginfo.Count > 0)
                        TotalProdBrokenRiceSell = lstprodsellinginfo.Sum(y => y.TotalBags);

                    if (TotalBags > (totalBrokenricestock - TotalProdBrokenRiceSell))
                    {
                        resultDTO.Message = RMSConstants.InsufficiantBrokenRiceStock;
                        resultDTO.IsSuccess = false;
                    }
                }
                else
                {
                    resultDTO.Message = RMSConstants.NoStock;
                    resultDTO.IsSuccess = false;
                }

            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.Error08, provider.GetCurrentCustomerId()) };
            }
            return resultDTO;
        }


        public ResultDTO CheckDustStockAvailability(string UnitTypeID, int TotalBags)
        {
            ResultDTO resultDTO = new ResultDTO();
            try
            {
                List<DustStockInfoEntity> lstDustStockInfoEntity = new List<DustStockInfoEntity>();
                List<ProductSellingInfoEntity> lstprodsellinginfo = new List<ProductSellingInfoEntity>();
                lstDustStockInfoEntity = imp.GetAllDustStockInfoEntities(provider.GetCurrentCustomerId(), UnitTypeID, YesNo.N);
                lstprodsellinginfo = imp.GetAllproductSellingInfoEntities(provider.GetCurrentCustomerId(), UnitTypeID, YesNo.N);

                if (lstDustStockInfoEntity != null && lstDustStockInfoEntity.Count > 0)
                {
                    int TotalProdBrokenRiceSell = 0;
                    int totalBrokenricestock = 0;
                    totalBrokenricestock = lstDustStockInfoEntity.Sum(x => x.TotalBags);
                    if (lstprodsellinginfo != null && lstprodsellinginfo.Count > 0)
                        TotalProdBrokenRiceSell = lstprodsellinginfo.Sum(y => y.TotalBags);

                    if (TotalBags > (totalBrokenricestock - TotalProdBrokenRiceSell))
                    {
                        resultDTO.Message = RMSConstants.InsufficiantBrokenRiceStock;
                        resultDTO.IsSuccess = false;
                    }
                }
                else
                {
                    resultDTO.Message = RMSConstants.NoStock;
                    resultDTO.IsSuccess = false;
                }

            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.Error08, provider.GetCurrentCustomerId()) };
            }
            return resultDTO;
        }
    }
}
