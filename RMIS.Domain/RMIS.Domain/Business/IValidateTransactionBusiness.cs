using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RMIS.Domain.DataTranserClass;

namespace RMIS.Domain.Business
{
    public interface IValidateTransactionBusiness
    {
        ResultDTO ValidateSellerDetails(int sellerType, string sellerName, string city, string district, string state, string contactNo);
        ResultDTO ValidatePaddyStockDetails(int godown, int lot, int paddy, int seller, string vehicleNo, string totalbags, string price, string purchaseDate);
        ResultDTO ValidateRiceStockDetails(int RiceType, int RiceBrand, int UnitsType,string totalbags, string weight);
        ResultDTO ValidateBrokenRiceStockDetails(int BrokenRiceType, int UnitsType, string totalbags, string weight);
        ResultDTO ValidateDustStockDetails(int UnitsType, string totalbags, string weight);
        ResultDTO ValidateRiceSellingDetails(int seller, int RiceType, int RiceBrand, int UnitsType, string vehicleNo, string totalbags, string weight, string price, string SellingDate);
        ResultDTO ValidateBrokenRiceSellingDetails(int seller, int BrokenRiceType, int UnitsType, string vehicleNo, string totalbags, string weight, string price, string SellingDate);
        ResultDTO ValidateDustSellingDetails(int seller, int UnitsType, string vehicleNo, string totalbags, string weight, string price, string SellingDate);
        ResultDTO ValidateProductSellingDetails(int ProductSellingTypeId, int seller, int RiceType, int RiceBrand, int BrokenRiceType, int UnitsType, string vehicleNo, string totalbags, string weight, string price, string SellingDate);
        
    }
}
