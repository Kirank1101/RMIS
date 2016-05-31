﻿using System;
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

        public ResultDTO ValidatePaddyStockDetails(int godown, int lot, int Unitstype, int paddy, int seller, string vehicleNo, string totalbags, string price, string purchaseDate)
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
            return new ResultDTO();
        }
        public ResultDTO ValidateRiceStockDetails(int RiceType, int RiceBrand, int UnitsType, string totalbags, string weight)
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
            else if (string.IsNullOrEmpty(weight.Trim()))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateValidateRiceStockDetailsWeightEmpty, provider.GetCurrentCustomerId()) };
            }
            else if (weight.ConvertToInt() <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateValidateRiceStockDetailsWeightValidate, provider.GetCurrentCustomerId()) };
            }

            return new ResultDTO();
        }
        public ResultDTO ValidateBrokenRiceStockDetails(int BrokenRiceType, int UnitsType, string totalbags, string weight)
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
            else if (string.IsNullOrEmpty(weight.Trim()))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateBrokenRiceStockDetailsWeightEmpty, provider.GetCurrentCustomerId()) };
            }
            else if (weight.ConvertToInt() <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateBrokenRiceStockDetailsWeightValidate, provider.GetCurrentCustomerId()) };
            }

            return new ResultDTO();
        }

        public ResultDTO ValidateDustStockDetails(int UnitsType, string totalbags, string weight)
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
            else if (string.IsNullOrEmpty(weight.Trim()))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateDustStockDetailsWeightEmpty, provider.GetCurrentCustomerId()) };
            }
            else if (weight.ConvertToInt() <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateDustStockDetailsWeightValidate, provider.GetCurrentCustomerId()) };
            }

            return new ResultDTO();
        }
        public ResultDTO ValidateRiceSellingDetails(int seller, int RiceType, int RiceBrand, int UnitsType, string vehicleNo, string totalbags, string weight, string price, string SellingDate)
        {
            if (seller <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateRiceSellingDetailsSeller, provider.GetCurrentCustomerId()) };
            }
            else if (RiceType <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateRiceSellingDetailsRiceType, provider.GetCurrentCustomerId()) };
            }
            else if (RiceBrand <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateRiceSellingDetailsRiceBrand, provider.GetCurrentCustomerId()) };
            }
            else if (UnitsType <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateRiceSellingDetailsUnitsType, provider.GetCurrentCustomerId()) };
            }
            else if (string.IsNullOrEmpty(vehicleNo.Trim()))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateRiceSellingDetailsVehicleNoEmpty, provider.GetCurrentCustomerId()) };
            }
            else if (vehicleNo.Trim().Length > 10)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateRiceSellingDetailsVehicleNoLength, provider.GetCurrentCustomerId()) };
            }
            else if (string.IsNullOrEmpty(totalbags.Trim()))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateRiceSellingDetailsTotalbagsEmpty, provider.GetCurrentCustomerId()) };
            }
            else if (totalbags.ConvertToInt() <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateRiceSellingDetailsTotalbagsValidate, provider.GetCurrentCustomerId()) };
            }
            else if (string.IsNullOrEmpty(weight.Trim()))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateRiceSellingDetailsWeightEmpty, provider.GetCurrentCustomerId()) };
            }
            else if (weight.ConvertToInt() <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateRiceSellingDetailsWeightValidate, provider.GetCurrentCustomerId()) };
            }
            else if (string.IsNullOrEmpty(price.Trim()))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateRiceSellingDetailsPriceEmpty, provider.GetCurrentCustomerId()) };
            }
            else if (price.ConvertToInt() <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateRiceSellingDetailsPriceValidate, provider.GetCurrentCustomerId()) };
            }
            else if (string.IsNullOrEmpty(SellingDate.Trim()))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateRiceSellingDetailsSelingDateEmpty, provider.GetCurrentCustomerId()) };
            }
            else if (!SellingDate.IsDate())
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateRiceSellingDetailsSellingDateValidate, provider.GetCurrentCustomerId()) };
            }
            return new ResultDTO();
        }
        public ResultDTO ValidateBrokenRiceSellingDetails(int seller, int BrokenRiceType, int UnitsType, string vehicleNo, string totalbags, string weight, string price, string SellingDate)
        {
            if (seller <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateBrokenRiceSellingDetailsSeller, provider.GetCurrentCustomerId()) };
            }
            else if (BrokenRiceType <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateBrokenRiceSellingDetailsBrokenRiceType, provider.GetCurrentCustomerId()) };
            }
            else if (UnitsType <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateBrokenRiceSellingDetailsUnitsType, provider.GetCurrentCustomerId()) };
            }
            else if (string.IsNullOrEmpty(vehicleNo.Trim()))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateBrokenRiceSellingDetailsVehicleNoEmpty, provider.GetCurrentCustomerId()) };
            }
            else if (vehicleNo.Trim().Length > 10)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateBrokenRiceSellingDetailsVehicleNoLength, provider.GetCurrentCustomerId()) };
            }
            else if (string.IsNullOrEmpty(totalbags.Trim()))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateBrokenRiceSellingDetailsTotalbagsEmpty, provider.GetCurrentCustomerId()) };
            }
            else if (totalbags.ConvertToInt() <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateBrokenRiceSellingDetailsTotalbagsValidate, provider.GetCurrentCustomerId()) };
            }
            else if (string.IsNullOrEmpty(weight.Trim()))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateBrokenRiceSellingDetailsWeightEmpty, provider.GetCurrentCustomerId()) };
            }
            else if (weight.ConvertToInt() <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateBrokenRiceSellingDetailsWeightValidate, provider.GetCurrentCustomerId()) };
            }
            else if (string.IsNullOrEmpty(price.Trim()))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateBrokenRiceSellingDetailsPriceEmpty, provider.GetCurrentCustomerId()) };
            }
            else if (price.ConvertToInt() <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateBrokenRiceSellingDetailsPriceValidate, provider.GetCurrentCustomerId()) };
            }
            else if (string.IsNullOrEmpty(SellingDate.Trim()))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateBrokenRiceSellingDetailsSelingDateEmpty, provider.GetCurrentCustomerId()) };
            }
            else if (!SellingDate.IsDate())
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateBrokenRiceSellingDetailsSellingDateValidate, provider.GetCurrentCustomerId()) };
            }
            return new ResultDTO();
        }
        public ResultDTO ValidateDustSellingDetails(int seller, int UnitsType, string vehicleNo, string totalbags, string weight, string price, string SellingDate)
        {
            if (seller <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateDustSellingDetailsSeller, provider.GetCurrentCustomerId()) };
            }
            else if (UnitsType <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateDustSellingDetailsUnitsType, provider.GetCurrentCustomerId()) };
            }
            else if (string.IsNullOrEmpty(vehicleNo.Trim()))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateDustSellingDetailsVehicleNoEmpty, provider.GetCurrentCustomerId()) };
            }
            else if (vehicleNo.Trim().Length > 10)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateDustSellingDetailsVehicleNoLength, provider.GetCurrentCustomerId()) };
            }
            else if (string.IsNullOrEmpty(totalbags.Trim()))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateDustSellingDetailsTotalbagsEmpty, provider.GetCurrentCustomerId()) };
            }
            else if (totalbags.ConvertToInt() <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateDustSellingDetailsTotalbagsValidate, provider.GetCurrentCustomerId()) };
            }
            else if (string.IsNullOrEmpty(weight.Trim()))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateDustSellingDetailsWeightEmpty, provider.GetCurrentCustomerId()) };
            }
            else if (weight.ConvertToInt() <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateDustSellingDetailsWeightValidate, provider.GetCurrentCustomerId()) };
            }
            else if (string.IsNullOrEmpty(price.Trim()))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateDustSellingDetailsPriceEmpty, provider.GetCurrentCustomerId()) };
            }
            else if (price.ConvertToInt() <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateDustSellingDetailsPriceValidate, provider.GetCurrentCustomerId()) };
            }
            else if (string.IsNullOrEmpty(SellingDate.Trim()))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateDustSellingDetailsSelingDateEmpty, provider.GetCurrentCustomerId()) };
            }
            else if (!SellingDate.IsDate())
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateDustSellingDetailsSellingDateValidate, provider.GetCurrentCustomerId()) };
            }
            return new ResultDTO();
        }


        public ResultDTO ValidateProductSellingDetails(int ProductSellingTypeId, int seller, int RiceType, int RiceBrand, int BrokenRiceType, int UnitsType, string vehicleNo, string totalbags, string weight, string price, string SellingDate)
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
            else if (string.IsNullOrEmpty(vehicleNo.Trim()))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateProductSellingDetailsVehicleNoEmpty, provider.GetCurrentCustomerId()) };
            }
            else if (vehicleNo.Trim().Length > 10)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateProductSellingDetailsVehicleNoLength, provider.GetCurrentCustomerId()) };
            }
            else if (string.IsNullOrEmpty(totalbags.Trim()))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateProductSellingDetailsTotalbagsEmpty, provider.GetCurrentCustomerId()) };
            }
            else if (totalbags.ConvertToInt() <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateProductSellingDetailsTotalbagsValidate, provider.GetCurrentCustomerId()) };
            }
            else if (string.IsNullOrEmpty(weight.Trim()))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateProductSellingDetailsWeightEmpty, provider.GetCurrentCustomerId()) };
            }
            else if (weight.ConvertToInt() <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateProductSellingDetailsWeightValidate, provider.GetCurrentCustomerId()) };
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
        public ResultDTO ValidateHullingProcessTrans(int paddyType, int RiceType, int BrokenRiceType, int PaddyUnitsType, int RiceUnitsType, int BrokenRiceUnitsType, int DustUnitsType, string Paddytotalbags, string Ricetotalbags, string BrokenRicetotalbags, string Dusttotalbags, string PaddyPrice, string RicePrice, string BrokenRicePrice, string DustPrice)
        {
            if (paddyType <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateHullingProcessDetailsPaddyType, provider.GetCurrentCustomerId()) };
            }
            else if (RiceType <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateHullingProcessDetailsUnitsType, provider.GetCurrentCustomerId()) };
            }
            else if (BrokenRiceType <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateHullingProcessDetailsUnitsType, provider.GetCurrentCustomerId()) };
            }
            else if (PaddyUnitsType <= 0)
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
            else if (string.IsNullOrEmpty(Paddytotalbags.Trim()))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateHullingProcessDetailsTotalbagsEmpty, provider.GetCurrentCustomerId()) };
            }
            else if (Paddytotalbags.ConvertToInt() <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateHullingProcessDetailsTotalbagsValidate, provider.GetCurrentCustomerId()) };
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

            else if (string.IsNullOrEmpty(PaddyPrice.Trim()))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateHullingProcessDetailsTotalbagsEmpty, provider.GetCurrentCustomerId()) };
            }
            else if (PaddyPrice.ConvertToInt() <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateHullingProcessDetailsTotalbagsValidate, provider.GetCurrentCustomerId()) };
            }
            else if (string.IsNullOrEmpty(RicePrice.Trim()))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateHullingProcessDetailsTotalbagsEmpty, provider.GetCurrentCustomerId()) };
            }
            else if (RicePrice.ConvertToInt() <= 0)
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

    }
}

