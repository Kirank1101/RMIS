using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RMIS.Domain.RiceMill;
using RMIS.Domain.Mediator;
using RMIS.Domain.Business;
using RMIS.Domain.DataTranserClass;
using RMIS.Domain;
using AllInOne.Common.Library.Util;
using RMIS.Domain.Constant;
using log4net;

namespace RMIS.Business
{

    public class PaddyBusiness : IPaddyBusiness
    {
        IRMISMediator imp;
        ISessionProvider provider;
        IUserMessage msgInstance;
        private static readonly ILog Logger = LogManager.GetLogger(typeof(PaddyBusiness));
        public PaddyBusiness(IRMISMediator imp, ISessionProvider provider, IUserMessage msgInstance)
        {
            this.provider = provider;
            this.imp = imp;
            this.msgInstance = msgInstance;
        }

        public List<SellerTypeDTO> GetMasterSellerTypeEntities()
        {
            List<SellerTypeDTO> listSellerTypeDTO = null;
            // imp.GetSellerTypeEntity(
            List<SellerTypeEntity> listSellerTypeEntity = imp.GetSellerTypeEntities(provider.GetCurrentCustomerId());
            if (listSellerTypeEntity != null && listSellerTypeEntity.Count > 0)
            {
                listSellerTypeDTO = new List<SellerTypeDTO>();
                foreach (SellerTypeEntity objSellerTypeEntity in listSellerTypeEntity)
                {
                    SellerTypeDTO objSellerTypeDTO = new SellerTypeDTO();
                    objSellerTypeDTO.SellerType = objSellerTypeEntity.SellerType;
                    objSellerTypeDTO.Indicator = GetYesorNo(objSellerTypeEntity.ObsInd);
                    listSellerTypeDTO.Add(objSellerTypeDTO);
                }

            }
            return listSellerTypeDTO;
        }
        public List<MUserTypeEntity> GetMUserTypeEntities()
        {
            return imp.GetMUserTypeEntities(provider.GetCurrentCustomerId());
        }
        public ResultDTO SaveSellerType(string sellerType)
        {
            SellerTypeEntity objSellerTypeEntity = new SellerTypeEntity();
            objSellerTypeEntity.ObsInd = YesNo.N;
            objSellerTypeEntity.CustID = provider.GetCurrentCustomerId();
            objSellerTypeEntity.LastModifiedBy = provider.GetLoggedInUserId();
            objSellerTypeEntity.SellerType = sellerType;
            objSellerTypeEntity.SellerTypeID = CommonUtil.CreateUniqueID("ST");
            objSellerTypeEntity.LastModifiedDate = DateTime.Now;
            try
            {
                imp.BeginTransaction();
                imp.SaveOrUpdateSellerTypeEntity(objSellerTypeEntity, false);
                imp.CommitAndCloseSession();
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.Error01, provider.GetCurrentCustomerId()) };
            }
            return new ResultDTO() { Message = msgInstance.GetMessage(RMSConstants.Success01, provider.GetCurrentCustomerId()) };
        }





        public List<PaddyStockInfoEntity> GetPaddyStockInfoEntities()
        {
            return imp.GetPaddyStockInfoEntities(provider.GetCurrentCustomerId());
        }


        public List<MWeightDetailsEntity> GetMWeightDetailsEntities()
        {
            return imp.GetMWeightDetailsEntities(provider.GetCurrentCustomerId());
        }

        string GetYesorNo(YesNo yesNo)
        {
            if (yesNo == YesNo.Y)
            {
                return "Yes";
            }
            else
                if (yesNo == YesNo.N)
                {
                    return "No";

                }
            return "No";
        }

        List<PaddyTypeDTO> IPaddyBusiness.GetMPaddyTypeEntities()
        {
            List<PaddyTypeDTO> listPaddyTypeDTO = null;
            // imp.GetSellerTypeEntity(
            List<MPaddyTypeEntity> listMPaddyTypeEntity = imp.GetMPaddyTypeEntitiies(provider.GetCurrentCustomerId());
            if (listMPaddyTypeEntity != null && listMPaddyTypeEntity.Count > 0)
            {
                listPaddyTypeDTO = new List<PaddyTypeDTO>();
                foreach (MPaddyTypeEntity objSellerTypeEntity in listMPaddyTypeEntity)
                {
                    PaddyTypeDTO objPaddyTypeDTO = new PaddyTypeDTO();
                    objPaddyTypeDTO.PaddyType = objSellerTypeEntity.Name;
                    objPaddyTypeDTO.Indicator = GetYesorNo(objSellerTypeEntity.ObsInd);
                    listPaddyTypeDTO.Add(objPaddyTypeDTO);
                }

            }
            return listPaddyTypeDTO;
        }


        public ResultDTO SavePaddyType(string paddyType)
        {
            MPaddyTypeEntity objMPaddyTypeEntity = new MPaddyTypeEntity();
            objMPaddyTypeEntity.ObsInd = YesNo.N;
            objMPaddyTypeEntity.CustID = provider.GetCurrentCustomerId();
            objMPaddyTypeEntity.LastModifiedBy = provider.GetLoggedInUserId();
            objMPaddyTypeEntity.Name = paddyType;
            objMPaddyTypeEntity.PaddyTypeID = CommonUtil.CreateUniqueID("PT");
            objMPaddyTypeEntity.LastModifiedDate = DateTime.Now;
            try
            {
                imp.BeginTransaction();
                imp.SaveOrUpdateMPaddyTypeEntity(objMPaddyTypeEntity, false);
                imp.CommitAndCloseSession();
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.Error02, provider.GetCurrentCustomerId()) };
            }
            return new ResultDTO() { Message = msgInstance.GetMessage(RMSConstants.Success02, provider.GetCurrentCustomerId()) };
        }
    }
}
