using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RMIS.Domain.DataTranserClass;

namespace RMIS.Domain.Business
{
    public interface IValidateTransactionBusiness
    {
        ResultDTO ValidateSellerDetails( string sellerName, string city, string district, string state, string contactNo);
        ResultDTO ValidatePaddyStockDetails(int godown, int lot, int Unitstype, int paddy, int seller, string vehicleNo, string totalbags, string price, string purchaseDate
            ,string paymentmode,string ChequeuNo, string Bankname,double amountpaid, string paiddate,string Handoverto,string nextpaymentdate);
        ResultDTO ValidateRiceStockDetails(int RiceType, int RiceBrand, int UnitsType,string totalbags, string weight);
        ResultDTO ValidateBrokenRiceStockDetails(int BrokenRiceType, int UnitsType, string totalbags, string weight);
        ResultDTO ValidateDustStockDetails(int UnitsType, string totalbags, string weight);
        ResultDTO ValidateRiceSellingDetails(int seller, int RiceType, int RiceBrand, int UnitsType, string vehicleNo, string totalbags, string weight, string price, string SellingDate);
        ResultDTO ValidateBrokenRiceSellingDetails(int seller, int BrokenRiceType, int UnitsType, string vehicleNo, string totalbags, string weight, string price, string SellingDate);
        ResultDTO ValidateDustSellingDetails(int seller, int UnitsType, string vehicleNo, string totalbags, string weight, string price, string SellingDate);
        ResultDTO ValidateProductSellingDetails(int ProductSellingTypeId, int seller, int RiceType, int RiceBrand, int BrokenRiceType, int UnitsType, string vehicleNo, string totalbags, string weight, string price, string SellingDate);
        ResultDTO ValidateHullingProcess(int paddyType, int UnitsType, string totalbags, string ProcessBy, string ProcessDate);
        ResultDTO ValidateHullingProcessTrans(int paddyType, int RiceType, int BrokenRiceType, int PaddyUnitsType, int RiceUnitsType, int BrokenRiceUnitsType, int DustUnitsType, string Paddytotalbags, string Ricetotalbags, string BrokenRicetotalbags, string Dusttotalbags, string PaddyPrice, string RicePrice, string BrokenRicePrice, string DustPrice);
        ResultDTO ValidateBuyerSellerRating(int SellerID,Int16 Rating, string Remark);
        ResultDTO ValidateBuyerDetails(string BuyerName, string city, string district, string state, string contactNo);                
    }
}
