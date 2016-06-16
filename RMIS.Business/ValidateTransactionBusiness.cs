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

        public ResultDTO ValidatePaddyStockDetails(int godown, int lot, int Unitstype, int paddy, int seller, string vehicleNo, string totalbags, string price, string purchaseDate
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
            else if (seller <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateValidatePaddyStockDetailsSeller, provider.GetCurrentCustomerId()) };
            }
            else if (string.IsNullOrEmpty(vehicleNo.Trim()))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateValidatePaddyStockDetailsVehicleNoEmpty, provider.GetCurrentCustomerId()) };
            }
            else if (vehicleNo.Trim().Length > 10)
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
            else if (price.ConvertToInt() <= 0)
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
        

        public ResultDTO ValidateProductSellingDetails(int ProductSellingTypeId, int seller, int RiceType, int RiceBrand, int BrokenRiceType, int UnitsType, string totalbags, string price, string SellingDate)
        {
            if (ProductSellingTypeId <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateProductSellingDetailsProductSellingTypeId, provider.GetCurrentCustomerId()) };
            }
            else if (seller <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateProductSellingDetailsSeller, provider.GetCurrentCustomerId()) };
            }
            else if (RiceType <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateProductSellingDetailsRiceType, provider.GetCurrentCustomerId()) };
            }
            else if (RiceBrand <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateProductSellingDetailsRiceBrand, provider.GetCurrentCustomerId()) };
            }
            else if (BrokenRiceType <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateProductSellingDetailsBrokenRiceType, provider.GetCurrentCustomerId()) };
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
            return new ResultDTO();
        }


        public ResultDTO ValidateHullingProcess(int paddyType, int UnitsType, string totalbags, string ProcessBy, string ProcessDate)
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
            else if (string.IsNullOrEmpty(ProcessBy.Trim()))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateHullingProcessDetailsProcessBy, provider.GetCurrentCustomerId()) };
            }
            else if (string.IsNullOrEmpty(ProcessDate.Trim()))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateHullingProcessDetailsProcessDateEmpty, provider.GetCurrentCustomerId()) };
            }
            else if (!ProcessDate.IsDate())
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateHullingProcessDetailsProcessDateValidate, provider.GetCurrentCustomerId()) };
            }
            return new ResultDTO();
        }
        public ResultDTO ValidateHullingProcessTrans(int RiceType, int BrokenRiceType, int RiceUnitsType, int BrokenRiceUnitsType,List<BrokenRiceStockDetailsDTO> listBrokenRiceStockDetailsDTO, int DustUnitsType, string Ricetotalbags, string BrokenRicetotalbags, string Dusttotalbags, string BrokenRicePrice, string DustPrice)
        {
            if (RiceType <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateHullingProcessDetailsUnitsType, provider.GetCurrentCustomerId()) };
            }
            else if (listBrokenRiceStockDetailsDTO.Count == 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateHullingProcessDetailsUnitsType, provider.GetCurrentCustomerId()) };
            }
            else if (RiceUnitsType <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateHullingProcessDetailsUnitsType, provider.GetCurrentCustomerId()) };
            }
            else if (BrokenRiceUnitsType <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateHullingProcessDetailsUnitsType, provider.GetCurrentCustomerId()) };
            }
            else if (DustUnitsType <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateHullingProcessDetailsUnitsType, provider.GetCurrentCustomerId()) };
            }
            else if (string.IsNullOrEmpty(Ricetotalbags.Trim()))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateHullingProcessDetailsTotalbagsEmpty, provider.GetCurrentCustomerId()) };
            }
            else if (Ricetotalbags.ConvertToInt() <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateHullingProcessDetailsTotalbagsValidate, provider.GetCurrentCustomerId()) };
            }
            else if (string.IsNullOrEmpty(BrokenRicetotalbags.Trim()))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateHullingProcessDetailsTotalbagsEmpty, provider.GetCurrentCustomerId()) };
            }
            else if (BrokenRicetotalbags.ConvertToInt() <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateHullingProcessDetailsTotalbagsValidate, provider.GetCurrentCustomerId()) };
            }
            else if (string.IsNullOrEmpty(Dusttotalbags.Trim()))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateHullingProcessDetailsTotalbagsEmpty, provider.GetCurrentCustomerId()) };
            }
            else if (Dusttotalbags.ConvertToInt() <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateHullingProcessDetailsTotalbagsValidate, provider.GetCurrentCustomerId()) };
            }
            else if (string.IsNullOrEmpty(BrokenRicePrice.Trim()))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateHullingProcessDetailsTotalbagsEmpty, provider.GetCurrentCustomerId()) };
            }
            else if (BrokenRicePrice.ConvertToInt() <= 0)
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
    }
}

