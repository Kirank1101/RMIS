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
            objSellerInfoEntity.City = city;
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
        public Domain.DataTranserClass.ResultDTO SavePaddyStockInfo(string sellerId, string paddyTypeId, string godownId, string lotId, string UnitsTypeID, string vehicleNo, string DriverName, decimal totalBags, decimal Price, DateTime purchaseDate)
        {
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
            objPaddyPaymentDetailsEntity.PaddyPaymentID = CommonUtil.CreateUniqueID("PP");
            objPaddyPaymentDetailsEntity.PaidDate = paidDate;
            objPaddyPaymentDetailsEntity.NextPaymentDate = nextPaymentDate;
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
            return imp.GetAllRiceStockInfoEntities(provider.GetCurrentCustomerId());
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
            return imp.GetAllBrokenRiceStockInfoEntities(provider.GetCurrentCustomerId());
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
            return imp.GetAllDustStockInfoEntities(provider.GetCurrentCustomerId());
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
            return imp.GetAllRiceSellingInfoEntities(provider.GetCurrentCustomerId());
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
            return imp.GetAllBrokenRiceSellingInfoEntities(provider.GetCurrentCustomerId());
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
            return imp.GetAllDustSellingInfoEntities(provider.GetCurrentCustomerId());
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
            return imp.GetCustomerInfoEntities();
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
            return imp.GetMenuConfigurationEntities(provider.GetCurrentCustomerId());
        }

        public List<MenuConfigurationEntity> GetMenuConfigurationEntities(string custId)
        {
            return imp.GetMenuConfigurationEntities(custId);
        }




        public ResultDTO SaveProductSellingInfo(string ProductSellingTypeId, string sellerId, string MRiceProdTypeID, string MRiceBrandId, string BrokenRiceTypeId, string vehicleNo, string DriverName, int totalBags, int qWeight, string UnitsTypeID, int qPrice, DateTime SellingDate)
        {

            ProductSellingInfoEntity objProductSellingInfoEntity = new ProductSellingInfoEntity();
            objProductSellingInfoEntity.ObsInd = YesNo.N;
            objProductSellingInfoEntity.CustID = provider.GetCurrentCustomerId();
            objProductSellingInfoEntity.ProductTypeID = ProductSellingTypeId;
            objProductSellingInfoEntity.LastModifiedBy = provider.GetLoggedInUserId();
            objProductSellingInfoEntity.MRiceBrandID = MRiceBrandId;
            objProductSellingInfoEntity.BrokenRiceTypeID = BrokenRiceTypeId;
            objProductSellingInfoEntity.DriverName = DriverName;
            objProductSellingInfoEntity.LastModifiedDate = DateTime.Now;
            objProductSellingInfoEntity.ProductID = CommonUtil.CreateUniqueID("PI");
            objProductSellingInfoEntity.MRiceProdTypeID = MRiceProdTypeID;
            objProductSellingInfoEntity.SellingDate = SellingDate;
            objProductSellingInfoEntity.QPrice = (short)qPrice;
            objProductSellingInfoEntity.QWeight = (short)qWeight;
            objProductSellingInfoEntity.SellerID = sellerId;
            objProductSellingInfoEntity.TotalBags = (short)totalBags;
            objProductSellingInfoEntity.VehicalNo = vehicleNo;
            try
            {
                imp.BeginTransaction();
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
            return imp.GetAllproductSellingInfoEntities(provider.GetCurrentCustomerId());
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
            return imp.GetAllHullingProcessInfoEntity(provider.GetCurrentCustomerId());
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
            return imp.GetAllHullingProcessTransInfoEntity(provider.GetCurrentCustomerId());
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
            UsersEntity userEntity = imp.GetUsersEntity(userName, custId);
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
                return imp.GetUserRoleEntities(objUsersEntity.UserID);

            }
            return listRMUserRoleEntity;
        }

        public UsersEntity GetUsersEntity(string userName, string custId)
        {
            return imp.GetUsersEntity(userName, custId);
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
            return imp.GetAllHullingProcessExpensesEntity(provider.GetCurrentCustomerId());
        }

        public List<SellerInfoEntity> GetAllSellerInfo(string SellerType)
        {
            return imp.GetAllSellerInfoEntities(provider.GetCurrentCustomerId(), SellerType);
        }


        public ResultDTO SaveBuyerSellerRating(string SellerTypeID, string SellerID, Int16 Rating, string Remarks)
        {
            BuyerSellerRatingEntity objBuyerSellerRatingEntity = new BuyerSellerRatingEntity();
            objBuyerSellerRatingEntity.ObsInd = YesNo.N;
            objBuyerSellerRatingEntity.BRMSID = CommonUtil.CreateUniqueID("BRM");
            objBuyerSellerRatingEntity.SellerID= SellerID;
            objBuyerSellerRatingEntity.CustID = provider.GetCurrentCustomerId();
            objBuyerSellerRatingEntity.SellerTypeID = SellerTypeID;
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
            return imp.GetAllBuyerSellerRatingEntities(provider.GetCurrentCustomerId());
        }
    }
}
