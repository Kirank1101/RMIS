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
        public ResultDTO ValidateSellerDetails(int sellerType, string sellerName, string city, string district, string state, string contactNo)
        {
            if (sellerType <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateSellerDetailsSelleTypes, provider.GetCurrentCustomerId()) };
            }
            else if (string.IsNullOrEmpty(sellerName.Trim()))
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

        public ResultDTO ValidatePaddyStockDetails(int godown,int lot,int paddy,int seller, string vehicleNo, string totalbags, string weight, string price, string purchaseDate)
        {
            if (godown <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateValidatePaddyStockDetailsGodown, provider.GetCurrentCustomerId()) };
            }
            else if (lot <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateValidatePaddyStockDetailsLotDetails, provider.GetCurrentCustomerId()) };
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
            else if (totalbags.ConvertToInt()<=0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateValidatePaddyStockDetailsTotalbagsValidate, provider.GetCurrentCustomerId()) };
            }
            else if (string.IsNullOrEmpty(weight.Trim()))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateValidatePaddyStockDetailsWeightEmpty, provider.GetCurrentCustomerId()) };
            }
            else if (weight.ConvertToInt() <= 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateValidatePaddyStockDetailsWeightValidate, provider.GetCurrentCustomerId()) };
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

    }
}

