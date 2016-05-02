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
    public class ValidateMasterBusiness : IValidateMasterBusiness
    {
        IUserMessage msgInstance;
        ISessionProvider provider;
        public ValidateMasterBusiness(IUserMessage msgInstance, ISessionProvider provider)
        {
            this.msgInstance = msgInstance;
            this.provider = provider;
        }

        #region Set Methods
        public ResultDTO ValidateSellerType(string sellerType)
        {
            if (string.IsNullOrEmpty(sellerType.Trim()))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateSellerTypeEmpty, provider.GetCurrentCustomerId()) };
            }
            else if (sellerType.Trim().Length > 10)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateSellerTypeLength, provider.GetCurrentCustomerId()) };
            }
            return new ResultDTO();
        }

        public ResultDTO ValiadtePaddyType(string paddyType)
        {
            if (string.IsNullOrEmpty(paddyType.Trim()))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidatePaddyTypeEmpty, provider.GetCurrentCustomerId()) };
            }
            else if (paddyType.Trim().Length > 50)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidatePaddyTypeLength, provider.GetCurrentCustomerId()) };
            }
            return new ResultDTO();
        }

        public ResultDTO ValidateGodownType(string godownType)
        {
            if (string.IsNullOrEmpty(godownType.Trim()))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateGodownTypeEmpty, provider.GetCurrentCustomerId()) };
            }
            else if (godownType.Trim().Length > 20)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateGodownTypeLength, provider.GetCurrentCustomerId()) };
            }
            return new ResultDTO();
        }

        public ResultDTO ValidateRiceBrandType(string riceBrand)
        {
            if (string.IsNullOrEmpty(riceBrand.Trim()))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateRiceBrandTypeEmpty, provider.GetCurrentCustomerId()) };
            }
            else if (riceBrand.Trim().Length > 50)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateRiceBrandTypeLength, provider.GetCurrentCustomerId()) };
            }
            return new ResultDTO();
        }

        public ResultDTO ValidateRiceProductType(string riceProduct)
        {
            if (string.IsNullOrEmpty(riceProduct.Trim()))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateRiceProductTypeEmpty, provider.GetCurrentCustomerId()) };
            }
            else if (riceProduct.Trim().Length > 30)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateRiceProductTypeLength, provider.GetCurrentCustomerId()) };
            }
            return new ResultDTO();
        }

        public ResultDTO ValidateLotDetails(string lotName, string godownId)
        {
            if (string.IsNullOrEmpty(lotName.Trim()))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateLotDetailsEmpty, provider.GetCurrentCustomerId()) };
            }
            else if (lotName.Trim().Length > 30)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateLotDetailsLength, provider.GetCurrentCustomerId()) };
            }
            else if (string.IsNullOrEmpty(godownId.Trim()))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateLotDetailsGodown, provider.GetCurrentCustomerId()) };
            }
            return new ResultDTO();
        }
        #endregion

        public ResultDTO ValidateWeightDetails(string weight)
        {
            if (string.IsNullOrEmpty(weight.Trim()))
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateWeightDetailsEmpty, provider.GetCurrentCustomerId()) };
            }
            else if (weight.ConvertToInt() < 0)
            {
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.ValidateWeightDetailSize, provider.GetCurrentCustomerId()) };
            }
            return new ResultDTO();
        }
    }
}
