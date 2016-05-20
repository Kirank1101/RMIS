using System;
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
           string godownId, string lotId, string vehicleNo, string DriverName, int totalBags, int qWeight, int qPrice,
           DateTime purchaseDate);
        ResultDTO SaveBagStockInfo(string sellerId, string BagTypeId,
                     string vehicleNo, string DriverName, int totalBags, int PricePerBag,
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

        List<SellerInfoEntity> GetPaddySellerInfo();
        List<RiceStockInfoEntity> GetAllRiceStockInfoEntities();
        List<BrokenRiceStockInfoEntity> GetAllBrokenRiceStockInfoEntities();
        List<DustStockInfoEntity> GetAllDustStockInfoEntities();
        List<RiceSellingInfoEntity> GetAllRiceSellingInfoEntities();
        List<BrokenRiceSellingInfoEntity> GetAllBrokenRiceSellingInfoEntities();
        List<DustSellingInfoEntity> GetAllDustSellingInfoEntities();
        List<CustomerInfoEntity> GetAllCustomerInfoEntities();
        bool SaveCustomerInformation(string customerName, string organizationName);
    }
}
