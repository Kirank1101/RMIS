using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RMIS.Domain.DataTranserClass;
using RMIS.Domain.Business;
using RMIS.Domain.Constant;
using AllInOne.Common.Library.Util;

namespace RMIS.Business
{
    public class ValidateTransactionBusiness : IValidateTransactionBusiness
    {
        IUserMessage msgInstance;
        ISessionProvider provider;
        public ValidateTransactionBusiness(IUserMessage msgInstance, ISessionProvider provider)
        {
            this.msgInstance = msgInstance;
            this.provider = provider;
        }
        public ResultDTO ValidateSellerDetails(string sellerName, string city, string district, string state, string contactNo)
        {
            if (string.IsNullOrEmpty(sellerName.Trim()))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateSellerDetailsSellerNameEmpty, provider.GetCurrentCustomerId()) };
            }
            else if (sellerName.Trim().Length > 50)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateSellerDetailsSellerNameLenth, provider.GetCurrentCustomerId()) };
            }
            else if (string.IsNullOrEmpty(city.Trim()))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateSellerDetailCityEmpty, provider.GetCurrentCustomerId()) };
            }
            else if (city.Trim().Length > 50)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateSellerDetailCityLength, provider.GetCurrentCustomerId()) };
            }

            else if (string.IsNullOrEmpty(district.Trim()))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateSellerDetailsDistrictEmpty, provider.GetCurrentCustomerId()) };
            }
            else if (district.Trim().Length > 50)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateSellerDetailsDistrictLength, provider.GetCurrentCustomerId()) };
            }

            else if (string.IsNullOrEmpty(state.Trim()))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateSellerDetailsStateEmpty, provider.GetCurrentCustomerId()) };
            }
            else if (state.Trim().Length > 50)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateSellerDetailsStateLength, provider.GetCurrentCustomerId()) };
            }

            else if (string.IsNullOrEmpty(contactNo.Trim()))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateSellerDetailsContactNoEmpty, provider.GetCurrentCustomerId()) };
            }
            else if (contactNo.Trim().Length > 11)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateSellerDetailsContactNoLength, provider.GetCurrentCustomerId()) };
            }
            return new ResultDTO();
        }

        public ResultDTO ValidatePaddyStockDetails(int godown, int lot, int Unitstype, int paddy, string SellerName, string vehicleNo, string totalbags, string price, string purchaseDate
            )
        {
            if (godown <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateValidatePaddyStockDetailsGodown, provider.GetCurrentCustomerId()) };
            }
            else if (lot <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateValidatePaddyStockDetailsLotDetails, provider.GetCurrentCustomerId()) };
            }
            else if (Unitstype <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateValidatePaddyStockDetailsUnitstype, provider.GetCurrentCustomerId()) };
            }
            else if (string.IsNullOrEmpty(SellerName))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateValidatePaddyStockDetailsSeller, provider.GetCurrentCustomerId()) };
            }
            else if (string.IsNullOrEmpty(vehicleNo.Trim()))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateValidatePaddyStockDetailsVehicleNoEmpty, provider.GetCurrentCustomerId()) };
            }
            else if (vehicleNo.Trim().Length > 13)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateValidatePaddyStockDetailsVehicleNoLength, provider.GetCurrentCustomerId()) };
            }
            else if (string.IsNullOrEmpty(totalbags.Trim()))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateValidatePaddyStockDetailsTotalbagsEmpty, provider.GetCurrentCustomerId()) };
            }
            else if (totalbags.ConvertToInt() <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateValidatePaddyStockDetailsTotalbagsValidate, provider.GetCurrentCustomerId()) };
            }
            else if (string.IsNullOrEmpty(price.Trim()))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateValidatePaddyStockDetailsPriceEmpty, provider.GetCurrentCustomerId()) };
            }
            else if (price.ConvertToDouble() <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateValidatePaddyStockDetailsPriceValidate, provider.GetCurrentCustomerId()) };
            }
            else if (string.IsNullOrEmpty(purchaseDate.Trim()))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateValidatePaddyStockDetailsPurchaseDateEmpty, provider.GetCurrentCustomerId()) };
            }
            else if (!purchaseDate.IsDate())
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateValidatePaddyStockDetailsPurchaseDateValidate, provider.GetCurrentCustomerId()) };
            }
            //else if (paymentmode == "Cash")
            //{
            //    #region Validate on Cash
            //    if (!paiddate.IsDate())
            //    {
            //        return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidatePaddyStockDetailsPaidDate, provider.GetCurrentCustomerId()) };
            //    }
            //    else if (amountpaid <= 0)
            //    {
            //        return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidatePaddyStockDetailsAmountPaid, provider.GetCurrentCustomerId()) };
            //    }
            //    else if (string.IsNullOrEmpty(Handoverto.Trim()))
            //    {
            //        return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidatePaddyStockDetailsHandOverToEmpty, provider.GetCurrentCustomerId()) };
            //    }
            //    else if (Handoverto.Trim().Length > 50)
            //    {
            //        return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidatePaddyStockDetailsHandOverToLength, provider.GetCurrentCustomerId()) };
            //    }

            //    #endregion
            //}
            //else if (paymentmode == "Cheque")
            //{
            //    #region Validate Cheque Payment
            //    if (!paiddate.IsDate())
            //    {
            //        return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidatePaddyStockDetailsPaidDate, provider.GetCurrentCustomerId()) };
            //    }
            //    else if (amountpaid <= 0)
            //    {
            //        return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidatePaddyStockDetailsAmountPaid, provider.GetCurrentCustomerId()) };
            //    }
            //    else if (string.IsNullOrEmpty(ChequeuNo.Trim()))
            //    {
            //        return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidatePaddyStockDetailsChequeNoEmpty, provider.GetCurrentCustomerId()) };
            //    }
            //    else if (ChequeuNo.Trim().Length > 50)
            //    {
            //        return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidatePaddyStockDetailsChequeNoLength, provider.GetCurrentCustomerId()) };
            //    }
            //    else if (string.IsNullOrEmpty(Bankname.Trim()))
            //    {
            //        return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidatePaddyStockDetailsBankNameEmpty, provider.GetCurrentCustomerId()) };
            //    }
            //    else if (Bankname.Trim().Length > 50)
            //    {
            //        return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidatePaddyStockDetailsBankNameLength, provider.GetCurrentCustomerId()) };
            //    }
            //    else if (string.IsNullOrEmpty(Handoverto.Trim()))
            //    {
            //        return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidatePaddyStockDetailsHandOverToEmpty, provider.GetCurrentCustomerId()) };
            //    }
            //    else if (Handoverto.Trim().Length > 50)
            //    {
            //        return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidatePaddyStockDetailsHandOverToLength, provider.GetCurrentCustomerId()) };
            //    }
            //    #endregion
            //}
            //else if (!nextpaymentdate.IsDate())
            //{
            //    return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidatePaddyStockDetailsnextpaymentdate, provider.GetCurrentCustomerId()) };
            //}
            return new ResultDTO();
        }
        public ResultDTO ValidateRiceStockDetails(int RiceType, int RiceBrand, int UnitsType, string totalbags)
        {

            if (RiceType <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateValidateRiceStockDetailsRiceType, provider.GetCurrentCustomerId()) };
            }
            else if (RiceBrand <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateValidateRiceStockDetailsRiceBrand, provider.GetCurrentCustomerId()) };
            }
            else if (UnitsType <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateValidateRiceStockDetailsUnitsType, provider.GetCurrentCustomerId()) };
            }
            else if (string.IsNullOrEmpty(totalbags.Trim()))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateValidateRiceStockDetailsTotalbagsEmpty, provider.GetCurrentCustomerId()) };
            }
            else if (totalbags.ConvertToInt() <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateValidateRiceStockDetailsTotalbagsValidate, provider.GetCurrentCustomerId()) };
            }


            return new ResultDTO();
        }
        public ResultDTO ValidateBrokenRiceStockDetails(int BrokenRiceType, int UnitsType, string totalbags)
        {

            if (BrokenRiceType <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateBrokenRiceStockDetailsRiceType, provider.GetCurrentCustomerId()) };
            }
            else if (UnitsType <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateBrokenRiceStockDetailsUnitsType, provider.GetCurrentCustomerId()) };
            }
            else if (string.IsNullOrEmpty(totalbags.Trim()))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateBrokenRiceStockDetailsTotalbagsEmpty, provider.GetCurrentCustomerId()) };
            }
            else if (totalbags.ConvertToInt() <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateBrokenRiceStockDetailsTotalbagsValidate, provider.GetCurrentCustomerId()) };
            }

            return new ResultDTO();
        }

        public ResultDTO ValidateDustStockDetails(int UnitsType, string totalbags)
        {

            if (UnitsType <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateDustStockDetailsUnitsType, provider.GetCurrentCustomerId()) };
            }
            else if (string.IsNullOrEmpty(totalbags.Trim()))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateDustStockDetailsTotalbagsEmpty, provider.GetCurrentCustomerId()) };
            }
            else if (totalbags.ConvertToInt() <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateDustStockDetailsTotalbagsValidate, provider.GetCurrentCustomerId()) };
            }


            return new ResultDTO();
        }


        public ResultDTO ValidateProductSellingDetails(int ProductSellingTypeId, string ProductSellingType, string BuyerName, int RiceType, int RiceBrand, int BrokenRiceType, int UnitsType, string totalbags, string price, string SellingDate,string NextPayDate)
        {
            if (ProductSellingTypeId < 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateProductSellingDetailsProductSellingTypeId, provider.GetCurrentCustomerId()) };
            }
            else if (ProductSellingTypeId >= 0)
            {
                if (ProductSellingType == "Rice")
                {
                    if (RiceType <= 0)
                    {
                        return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateProductSellingDetailsRiceType, provider.GetCurrentCustomerId()) };
                    }
                    if (RiceBrand <= 0)
                    {
                        return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateProductSellingDetailsRiceBrand, provider.GetCurrentCustomerId()) };
                    }
                }

                else if (ProductSellingType == "BrokenRice")
                {
                    if (BrokenRiceType <= 0)
                    {
                        return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateProductSellingDetailsBrokenRiceType, provider.GetCurrentCustomerId()) };
                    }
                }
            }
            else if (string.IsNullOrEmpty(BuyerName))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateProductSellingDetailsbuyer, provider.GetCurrentCustomerId()) };
            }
            else if (UnitsType <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateProductSellingDetailsUnitsType, provider.GetCurrentCustomerId()) };
            }
            else if (string.IsNullOrEmpty(totalbags.Trim()))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateProductSellingDetailsTotalbagsEmpty, provider.GetCurrentCustomerId()) };
            }
            else if (totalbags.ConvertToInt() <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateProductSellingDetailsTotalbagsValidate, provider.GetCurrentCustomerId()) };
            }
            else if (string.IsNullOrEmpty(price.Trim()))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateProductSellingDetailsPriceEmpty, provider.GetCurrentCustomerId()) };
            }
            else if (price.ConvertToInt() <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateProductSellingDetailsPriceValidate, provider.GetCurrentCustomerId()) };
            }
            else if (string.IsNullOrEmpty(SellingDate.Trim()))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateProductSellingDetailsSelingDateEmpty, provider.GetCurrentCustomerId()) };
            }
            else if (!SellingDate.IsDate())
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateProductSellingDetailsSellingDateValidate, provider.GetCurrentCustomerId()) };
            }
            else if (string.IsNullOrEmpty(NextPayDate.Trim()))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateProductSellingDetailsNextPayDateEmpty, provider.GetCurrentCustomerId()) };
            }
            else if (!NextPayDate.IsDate())
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateProductSellingDetailsNextPayDateValidate, provider.GetCurrentCustomerId()) };
            }
            return new ResultDTO();
        }


        public ResultDTO ValidateHullingProcess(int paddyType, int UnitsType, string totalbags, string PaddyPrice,string HullingExpenses)
        {
            if (paddyType <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateHullingProcessDetailsPaddyType, provider.GetCurrentCustomerId()) };
            }
            else if (UnitsType <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateHullingProcessDetailsUnitsType, provider.GetCurrentCustomerId()) };
            }
            else if (string.IsNullOrEmpty(totalbags.Trim()))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateHullingProcessDetailsTotalbagsEmpty, provider.GetCurrentCustomerId()) };
            }
            else if (totalbags.ConvertToInt() <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateHullingProcessDetailsTotalbagsValidate, provider.GetCurrentCustomerId()) };
            }

            else if (string.IsNullOrEmpty(PaddyPrice.Trim()))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateHullingProcessDetailsPaddyPriceEmpty, provider.GetCurrentCustomerId()) };
            }
            else if (PaddyPrice.ConvertToDouble() <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateHullingProcessDetailsPaddyPriceValidate, provider.GetCurrentCustomerId()) };
            }
            else if (string.IsNullOrEmpty(HullingExpenses.Trim()))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateHullingProcessDetailsHullingExpensesEmpty, provider.GetCurrentCustomerId()) };
            }
            else if (HullingExpenses.ConvertToDouble() <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateHullingProcessDetailsHullingExpensesValidate, provider.GetCurrentCustomerId()) };
            }
            
            return new ResultDTO();
        }
        public ResultDTO ValidateHullingProcessTrans(int Ricestockadded, int BrokenRiceStockadded, int RiceType, int BrokenRiceType, int RiceUnitsType, int BrokenRiceUnitsType, int DustUnitsType, string Ricetotalbags, string BrokenRicetotalbags, string Dusttotalbags, string BrokenRicePrice, string DustPrice, int RiceBrand)
        {
            if (Ricestockadded <= 0)
            {
                if (RiceType <= 0)
                {
                    return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateHullingProcessDetailsUnitsType, provider.GetCurrentCustomerId()) };
                }
                else if (RiceUnitsType <= 0)
                {
                    return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateHullingProcessDetailsUnitsType, provider.GetCurrentCustomerId()) };
                }
                else if (RiceBrand <= 0)
                {
                    return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateHullingProcessDetailsRiceBrand, provider.GetCurrentCustomerId()) };
                }
                else if (string.IsNullOrEmpty(Ricetotalbags.Trim()))
                {
                    return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateHullingProcessDetailsTotalbagsEmpty, provider.GetCurrentCustomerId()) };
                }
                else if (Ricetotalbags.ConvertToInt() <= 0)
                {
                    return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateHullingProcessDetailsTotalbagsValidate, provider.GetCurrentCustomerId()) };
                }

            }
            else if (RiceType <= 0 || RiceUnitsType <= 0 || RiceBrand <= 0 || Ricetotalbags.ConvertToInt() <= 0)
            {
                if (RiceType > 0 || RiceUnitsType > 0 || RiceBrand > 0 || Ricetotalbags.ConvertToInt() > 0)
                    return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateHullingProcessTransactionRiceDetails, provider.GetCurrentCustomerId()) };
            }
            if (BrokenRiceStockadded <= 0)
            {
                if (BrokenRiceType <= 0)
                {
                    return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateHullingProcessDetailsBrokenRiceType, provider.GetCurrentCustomerId()) };
                }
                else if (BrokenRiceUnitsType <= 0)
                {
                    return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateHullingProcessDetailsUnitsType, provider.GetCurrentCustomerId()) };
                }
                else if (string.IsNullOrEmpty(BrokenRicetotalbags.Trim()))
                {
                    return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateHullingProcessDetailsTotalbagsEmpty, provider.GetCurrentCustomerId()) };
                }
                else if (BrokenRicetotalbags.ConvertToInt() <= 0)
                {
                    return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateHullingProcessDetailsTotalbagsValidate, provider.GetCurrentCustomerId()) };
                }
                else if (string.IsNullOrEmpty(BrokenRicePrice.Trim()))
                {
                    return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateHullingProcessDetailsTotalbagsEmpty, provider.GetCurrentCustomerId()) };
                }
                else if (BrokenRicePrice.ConvertToDouble() <= 0)
                {
                    return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateHullingProcessDetailsTotalbagsValidate, provider.GetCurrentCustomerId()) };
                }
            }
            else if (BrokenRiceType <= 0 || BrokenRiceUnitsType <= 0 || BrokenRicePrice.ConvertToDouble() <= 0 || BrokenRicetotalbags.ConvertToInt() <= 0)
            {
                if (BrokenRiceType > 0 || BrokenRiceUnitsType > 0 || BrokenRicePrice.ConvertToDouble() > 0 || BrokenRicetotalbags.ConvertToInt() > 0)
                    return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateHullingProcessTransactionBrokenRiceDetails, provider.GetCurrentCustomerId()) };
            }


            if (DustUnitsType <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateHullingProcessDetailsUnitsType, provider.GetCurrentCustomerId()) };
            }
            else if (string.IsNullOrEmpty(Dusttotalbags.Trim()))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateHullingProcessDetailsTotalbagsEmpty, provider.GetCurrentCustomerId()) };
            }
            else if (Dusttotalbags.ConvertToInt() <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateHullingProcessDetailsTotalbagsValidate, provider.GetCurrentCustomerId()) };
            }
            else if (string.IsNullOrEmpty(DustPrice.Trim()))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateHullingProcessDetailsTotalbagsEmpty, provider.GetCurrentCustomerId()) };
            }
            else if (DustPrice.ConvertToInt() <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateHullingProcessDetailsTotalbagsValidate, provider.GetCurrentCustomerId()) };
            }
            return new ResultDTO();
        }
        public ResultDTO ValidateBuyerSellerRating(int SellerID, Int16 Rating, string Remark)
        {
            if (SellerID <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateBuyerSellerRatingSellerID, provider.GetCurrentCustomerId()) };
            }
            else if (Rating <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateBuyerSellerRatingRateing, provider.GetCurrentCustomerId()) };
            }
            else if (Remark.Trim().Length > 50)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateBuyerSellerRatingRemark, provider.GetCurrentCustomerId()) };
            }
            else if (string.IsNullOrEmpty(Remark.Trim()))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateBuyerSellerRatingRemarkEmpty, provider.GetCurrentCustomerId()) };
            }
            return new ResultDTO();
        }
        public ResultDTO ValidateBuyerDetails(string BuyerName, string city, string district, string state, string contactNo)
        {
            if (string.IsNullOrEmpty(BuyerName.Trim()))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateBuyerDetailsBuyerNameEmpty, provider.GetCurrentCustomerId()) };
            }
            else if (BuyerName.Trim().Length > 50)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateBuyerDetailsBuyerNameLenth, provider.GetCurrentCustomerId()) };
            }
            else if (string.IsNullOrEmpty(city.Trim()))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateBuyerDetailCityEmpty, provider.GetCurrentCustomerId()) };
            }
            else if (city.Trim().Length > 50)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateBuyerDetailCityLength, provider.GetCurrentCustomerId()) };
            }

            else if (string.IsNullOrEmpty(district.Trim()))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateBuyerDetailsDistrictEmpty, provider.GetCurrentCustomerId()) };
            }
            else if (district.Trim().Length > 50)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateBuyerDetailsDistrictLength, provider.GetCurrentCustomerId()) };
            }

            else if (string.IsNullOrEmpty(state.Trim()))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateBuyerDetailsStateEmpty, provider.GetCurrentCustomerId()) };
            }
            else if (state.Trim().Length > 50)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateBuyerDetailsStateLength, provider.GetCurrentCustomerId()) };
            }

            else if (string.IsNullOrEmpty(contactNo.Trim()))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateBuyerDetailsContactNoEmpty, provider.GetCurrentCustomerId()) };
            }
            else if (contactNo.Trim().Length > 11)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateBuyerDetailsContactNoLength, provider.GetCurrentCustomerId()) };
            }
            return new ResultDTO();
        }
        public ResultDTO ValidateEmployeeDetails(string EmployeeName, string city, string district, string state, string contactNo)
        {

            if (string.IsNullOrEmpty(EmployeeName.Trim()))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateEmployeeDetailEmployeeNameEmpty, provider.GetCurrentCustomerId()) };
            }
            else if (EmployeeName.Trim().Length > 50)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateEmployeeDetailEmployeeNameLength, provider.GetCurrentCustomerId()) };
            }
            else if (string.IsNullOrEmpty(city.Trim()))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateEmployeeDetailCityEmpty, provider.GetCurrentCustomerId()) };
            }
            else if (city.Trim().Length > 50)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateEmployeeDetailCityLength, provider.GetCurrentCustomerId()) };
            }

            else if (string.IsNullOrEmpty(district.Trim()))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateEmployeeDetailsDistrictEmpty, provider.GetCurrentCustomerId()) };
            }
            else if (district.Trim().Length > 50)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateEmployeeDetailsDistrictLength, provider.GetCurrentCustomerId()) };
            }

            else if (string.IsNullOrEmpty(state.Trim()))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateEmployeeDetailsStateEmpty, provider.GetCurrentCustomerId()) };
            }
            else if (state.Trim().Length > 50)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateEmployeeDetailsStateLength, provider.GetCurrentCustomerId()) };
            }

            else if (string.IsNullOrEmpty(contactNo.Trim()))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateEmployeeDetailsContactNoEmpty, provider.GetCurrentCustomerId()) };
            }
            else if (contactNo.Trim().Length > 11)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateEmployeeDetailsContactNoLength, provider.GetCurrentCustomerId()) };
            }
            return new ResultDTO();
        }



        public ResultDTO ValidateEmployeeSalary(int EmployeeName, int SalaryType, int Designation, double Salary)
        {
            if (EmployeeName <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateEmployeeSalaryEmployee, provider.GetCurrentCustomerId()) };
            }
            else if (SalaryType <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateEmployeeSalarySalaryType, provider.GetCurrentCustomerId()) };
            }
            else if (Designation <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateEmployeeSalaryDesignation, provider.GetCurrentCustomerId()) };
            }
            else if (Salary <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateEmployeeSalarySalary, provider.GetCurrentCustomerId()) };
            }
            return new ResultDTO();
        }

        public ResultDTO ValidateEmployeeSalaryPayment(int EmployeeName, int SalaryType, int Designation, double Salary, double SalaryPaid, double OTCharges)
        {

            if (EmployeeName <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateEmpSalPayEmployee, provider.GetCurrentCustomerId()) };
            }
            else if (SalaryType <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateEmpSalPaySalaryType, provider.GetCurrentCustomerId()) };
            }
            else if (Designation <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateEmpSalPayDesignation, provider.GetCurrentCustomerId()) };
            }
            else if (Salary <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateEmpSalPaySalary, provider.GetCurrentCustomerId()) };
            }
            else if (SalaryPaid <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateEmpSalPaySalaryPaid, provider.GetCurrentCustomerId()) };
            }
            else if (OTCharges <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateEmpSalPayOTCharges, provider.GetCurrentCustomerId()) };
            }
            return new ResultDTO();
        }


        public ResultDTO ValidateOtherExpenses(string GivenTo, string Description, double PaidAmount)
        {
            if (string.IsNullOrEmpty(GivenTo.Trim()))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateOtherExpensesGivenToEmpty, provider.GetCurrentCustomerId()) };
            }
            else if (GivenTo.Trim().Length > 11)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateOtherExpensesGivenToLength, provider.GetCurrentCustomerId()) };
            }
            else if (string.IsNullOrEmpty(Description.Trim()))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateOtherExpensesDescriptionEmpty, provider.GetCurrentCustomerId()) };
            }
            else if (Description.Trim().Length > 11)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateOtherExpensesDescriptionLength, provider.GetCurrentCustomerId()) };
            }
            else if (PaidAmount <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateOtherExpensesPaidAmount, provider.GetCurrentCustomerId()) };
            }
            return new ResultDTO();
        }


        public ResultDTO ValidateProductPaymentDetails(int PaymentMode, string Buyername, double ReceivedAmount, double TotalAmountDue)
        {
            if (PaymentMode < 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateProductPaymentPayMode, provider.GetCurrentCustomerId()) };
            }
            else if (string.IsNullOrEmpty(Buyername))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateProductPaymentBuyerName, provider.GetCurrentCustomerId()) };
            }
            else if (Buyername.Length > 40)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateProductPaymentBuyerNameLength, provider.GetCurrentCustomerId()) };
            }
            else if (ReceivedAmount <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateProductPaymentReceivedAmount, provider.GetCurrentCustomerId()) };
            }
            else if (TotalAmountDue <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateProductPaymentAmountDue, provider.GetCurrentCustomerId()) };
            }
            return new ResultDTO();
        }


        public ResultDTO ValidateMediatorDetails(string MediatorName, string city, string district, string state, string contactNo)
        {

            if (string.IsNullOrEmpty(MediatorName.Trim()))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateMediatorDetailsMediatorNameEmpty, provider.GetCurrentCustomerId()) };
            }
            else if (MediatorName.Trim().Length > 50)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateMediatorDetailsMediatorNameLenth, provider.GetCurrentCustomerId()) };
            }
            else if (string.IsNullOrEmpty(city.Trim()))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateMediatorDetailCityEmpty, provider.GetCurrentCustomerId()) };
            }
            else if (city.Trim().Length > 50)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateMediatorDetailCityLength, provider.GetCurrentCustomerId()) };
            }

            else if (string.IsNullOrEmpty(district.Trim()))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateMediatorDetailsDistrictEmpty, provider.GetCurrentCustomerId()) };
            }
            else if (district.Trim().Length > 50)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateMediatorDetailsDistrictLength, provider.GetCurrentCustomerId()) };
            }
            else if (string.IsNullOrEmpty(state.Trim()))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateMediatorDetailsStateEmpty, provider.GetCurrentCustomerId()) };
            }
            else if (state.Trim().Length > 50)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateMediatorDetailsStateLength, provider.GetCurrentCustomerId()) };
            }
            else if (string.IsNullOrEmpty(contactNo.Trim()))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateMediatorDetailsContactNoEmpty, provider.GetCurrentCustomerId()) };
            }
            else if (contactNo.Trim().Length > 11)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateMediatorDetailsContactNoLength, provider.GetCurrentCustomerId()) };
            }
            return new ResultDTO();
        }


        public ResultDTO ValidateExpenseTransaction(int ExpenseType, string Name, string Reason, double Amount, string PayDate)
        {
            if (ExpenseType <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateExpenseTranExpenseType, provider.GetCurrentCustomerId()) };
            }
            else if (string.IsNullOrEmpty(Name.Trim()))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateExpenseTranName, provider.GetCurrentCustomerId()) };
            }
            else if (Name.Trim().Length > 50)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateExpenseTranNameLength, provider.GetCurrentCustomerId()) };
            }
            else if (string.IsNullOrEmpty(Reason.Trim()))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateExpenseTranReasonEmpty, provider.GetCurrentCustomerId()) };
            }
            else if (!string.IsNullOrEmpty(Reason))
            {
                if (Reason.Trim().Length > 400)
                    return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateExpenseTranReasonLength, provider.GetCurrentCustomerId()) };
            }
            else if (Amount <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateExpenseTranSAmount, provider.GetCurrentCustomerId()) };
            }
            else if (string.IsNullOrEmpty(PayDate.Trim()))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateExpenseTranPayDateEmpty, provider.GetCurrentCustomerId()) };
            }
            else if (!PayDate.IsDate())
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateExpenseTranPayDateValidate, provider.GetCurrentCustomerId()) };
            }

            return new ResultDTO();
        }
        public ResultDTO ValidateRentHullingTransaction(int JobWorkType, string Name, string PaddyType, int TotalBags, double Price, string ProcessDate)
        {
            if (JobWorkType <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateRentHullingJobWorkType, provider.GetCurrentCustomerId()) };
            }
            else if (string.IsNullOrEmpty(Name.Trim()))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateRentHullingName, provider.GetCurrentCustomerId()) };
            }
            else if (Name.Trim().Length > 50)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateRentHullingNameLength, provider.GetCurrentCustomerId()) };
            }
            else if (string.IsNullOrEmpty(PaddyType.Trim()))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateRentHullingPaddyTypeEmpty, provider.GetCurrentCustomerId()) };
            }
            else if (string.IsNullOrEmpty(PaddyType))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateRentHullingPaddyTypeLength, provider.GetCurrentCustomerId()) };
            }
            else if (TotalBags <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateRentHullingTotalBags, provider.GetCurrentCustomerId()) };
            }
            else if (Price <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateRentHullingPrice, provider.GetCurrentCustomerId()) };
            }
            else if (string.IsNullOrEmpty(ProcessDate.Trim()))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateRentHullingProcessDateEmpty, provider.GetCurrentCustomerId()) };
            }
            else if (!ProcessDate.IsDate())
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateRentHullingProcessDateValidate, provider.GetCurrentCustomerId()) };
            }

            return new ResultDTO();
        }


        public ResultDTO ValidatePaddyStockReport(string SellerName, string PurchaseDateFrom, string PurchaseDateTo)
        {
            if (string.IsNullOrEmpty(SellerName) && string.IsNullOrEmpty(PurchaseDateFrom) && string.IsNullOrEmpty(PurchaseDateTo))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidatePaddyStockReportRequired, provider.GetCurrentCustomerId()) };
            }
            else if (!string.IsNullOrEmpty(SellerName))
            {
                if (!string.IsNullOrEmpty(PurchaseDateFrom) || !string.IsNullOrEmpty(PurchaseDateTo))
                {
                    if (string.IsNullOrEmpty(PurchaseDateFrom) || string.IsNullOrEmpty(PurchaseDateTo))
                        return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidatePaddyStockValidDate, provider.GetCurrentCustomerId()) }; 
                }
                
            }
            else if (string.IsNullOrEmpty(PurchaseDateFrom) || string.IsNullOrEmpty(PurchaseDateTo))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidatePaddyStockValidDate, provider.GetCurrentCustomerId()) };
            }
            return new ResultDTO();
        }


        public ResultDTO ValidateBankBalance(double BankBalance)
        {
            if (BankBalance <= 0)
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateBankTransactionBankBalance, provider.GetCurrentCustomerId()) };

            return new ResultDTO();
        }


        public ResultDTO ValidateBankTransReport(string TransFromDate, string TransToDate)
        {
            if (string.IsNullOrEmpty(TransFromDate) || string.IsNullOrEmpty(TransToDate) || !TransFromDate.IsDate() || !TransToDate.IsDate())
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateBankTransValidDate, provider.GetCurrentCustomerId()) };
            }
            return new ResultDTO();            
        }


        public ResultDTO ValidateGetPaddyPrice(int PaddyType, int UnitType, int GodownType, int LotType, string totalbags)
        {
            if (PaddyType <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateGetPaddyPricePaddyType, provider.GetCurrentCustomerId()) };
            }
            else if (UnitType <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateGetPaddyPriceUnitType, provider.GetCurrentCustomerId()) };
            }
            else if (GodownType <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateGetPaddyPriceGodownType, provider.GetCurrentCustomerId()) };
            }
            else if (LotType <= 0)  
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateGetPaddyPriceLotType, provider.GetCurrentCustomerId()) };
            }
            else if (string.IsNullOrEmpty(totalbags.Trim()))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateGetPaddyPriceTotalbagsEmpty, provider.GetCurrentCustomerId()) };
            }
            else if (totalbags.ConvertToInt() <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateGetPaddyPriceTotalbagsValidate, provider.GetCurrentCustomerId()) };
            }
            return new ResultDTO();            
        }
    }
}

