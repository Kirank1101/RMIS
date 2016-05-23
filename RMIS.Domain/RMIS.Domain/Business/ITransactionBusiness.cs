﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RMIS.Domain.DataTranserClass;
using RMIS.Domain.RiceMill;

namespace RMIS.Domain.Business
{
    public interface ITransactionBusiness
    {
        ResultDTO SaveSellerInfo(string sellerTypeId, string name,
           string street, string street1, string town, string city, string district, string state,
           string pincode, string contactNo, string mobileNo, string phoneNo);
        ResultDTO SavePaddyStockInfo(string sellerId, string paddyTypeId,
           string godownId, string lotId, string vehicleNo, string DriverName, decimal totalBags, decimal Price,
           DateTime purchaseDate);
        ResultDTO SaveBagStockInfo(string sellerId, string BagTypeId,
                     string vehicleNo, string DriverName, int totalBags, decimal Price,
                     DateTime purchaseDate);
        ResultDTO SavePaddyPaymentDetails(string sellerId, double amountPaid,
           DateTime paidDate, string handOverTo, DateTime nextPaymentDate);
        ResultDTO SaveRiceStockInfo(string MRiceProdTypeID, string MRiceBrandID, int totalBags, int QWeight, string UnitsTypeID);
        ResultDTO SaveBrokenRiceStockInfo(string BrokenRiceTypeId, int totalBags, int QWeight, string UnitsTypeID);
        ResultDTO SaveDustStockInfo(int totalBags, int QWeight, string UnitsTypeID);
        ResultDTO SaveRiceSellingInfo(string sellerId, string MRiceProdTypeID, string MRiceBrandId,
            string vehicleNo, string DriverName, int totalBags, int qWeight, string UnitsTypeID, int qPrice,
            DateTime SellingDate);
        ResultDTO SaveBrokenRiceSellingInfo(string sellerId, string BrokenRiceTypeId, string vehicleNo, string DriverName,
            int totalBags, int qWeight, string UnitsTypeID, int qPrice, DateTime SellingDate);
        ResultDTO SaveDustSellingInfo(string sellerId, string vehicleNo, string DriverName, int totalBags,
            int qWeight, string UnitsTypeID, int qPrice, DateTime SellingDate);
        bool SaveCustomerInformation(string customerName, string organizationName,string custId);
        bool SaveMenuConfiguration(string custId, string roleId, string menuId);
        ResultDTO SaveProductSellingInfo(string ProductSellingTypeId, string sellerId, string MRiceProdTypeID, string MRiceBrandId, string BrokenRiceTypeId,
            string vehicleNo, string DriverName, int totalBags, int qWeight, string UnitsTypeID, int qPrice,
            DateTime SellingDate);
        ResultDTO SaveHullingProcessInfo(string PaddyTypeID, string UnitsTypeID, int TotalBags, string ProcessBy, DateTime ProcessDate, char Status);
        ResultDTO SaveHullingProcessTransInfo(string HullingProcessID,string ProductTypeID,string PaddyTypeID, string RiceType,string BrokenRiceType,char IsDust, string UnitsTypeID, int TotalBags, double Price);

        List<SellerInfoEntity> GetPaddySellerInfo();
        List<RiceStockInfoEntity> GetAllRiceStockInfoEntities();
        List<BrokenRiceStockInfoEntity> GetAllBrokenRiceStockInfoEntities();
        List<DustStockInfoEntity> GetAllDustStockInfoEntities();
        List<RiceSellingInfoEntity> GetAllRiceSellingInfoEntities();
        List<BrokenRiceSellingInfoEntity> GetAllBrokenRiceSellingInfoEntities();
        List<DustSellingInfoEntity> GetAllDustSellingInfoEntities();
        List<CustomerInfoEntity> GetAllCustomerInfoEntities();
        List<ProductSellingInfoEntity> GetAllProductSellingInfoEntities();
        List<MenuConfigurationEntity> GetMenuConfigurationEntities();
        List<MenuConfigurationEntity> GetMenuConfigurationEntities(string custId);
        List<HullingProcessEntity> GetAllHullingProcessInfoEntities();
        List<HullingProcessTransactionEntity> GetAllHullingProcessTransInfoEntities();
    
    }
}
