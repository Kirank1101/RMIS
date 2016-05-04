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
            string godownId, string lotId, string vehicleNo, int totalBags, int qWeight, int qPrice,
            DateTime purchaseDate);
        ResultDTO SaveBagStockInfo(string sellerId, string BagTypeId,
                     string vehicleNo, string DriverName, int totalBags, int PricePerBag,
                     DateTime purchaseDate);
         ResultDTO SavePaddyPaymentDetails(string sellerId, double amountPaid,
            DateTime paidDate, string handOverTo, DateTime nextPaymentDate);
         ResultDTO SaveRiceStockInfo(string sellerId, string RiceTypeId, int totalBags, string WeightUnits);

         List<SellerInfoEntity> GetPaddySellerInfo();
         List<RiceStockInfoEntity> GetAllRiceStockInfoEntities();

    }
}
