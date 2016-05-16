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
        ResultDTO ValidatePaddyStockDetails(int godown, int lot, int paddy, int seller, string vehicleNo, string totalbags, string weight, string price, string purchaseDate);
        ResultDTO ValidateRiceStockDetails(int RiceType, int RiceBrand, int UnitsType,string totalbags, string weight);
        ResultDTO ValidateBrokenRiceStockDetails(int RiceType, int UnitsType, string totalbags, string weight);
    }
}
