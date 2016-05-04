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
        ResultDTO SaveRiceStockInfo(string RiceTypeId, int totalBags, int QWeight, string WeightUnits);
        ResultDTO SaveBrokenRiceStockInfo(string BrokenRiceTypeId, int totalBags, int QWeight, string WeightUnits);
        ResultDTO SaveDustStockInfo(int totalBags, int QWeight, string WeightUnits);
        ResultDTO SaveRiceSellingInfo(string sellerId, string RiceTypeId, string RiceBrandId,
            string vehicleNo, string DriverName, int totalBags, int qWeight, string UnitWeight, int qPrice,
            DateTime SellingDate);
        

        List<SellerInfoEntity> GetPaddySellerInfo();
        List<RiceStockInfoEntity> GetAllRiceStockInfoEntities();
        List<BrokenRiceStockInfoEntity> GetAllBrokenRiceStockInfoEntities();
        List<DustStockInfoEntity> GetAllDustStockInfoEntities();
        List<RiceSellingInfoEntity> GetAllRiceSellingInfoEntities();
    }
}
