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

    public class MasterPaddyBusiness : IMasterPaddyBusiness
    {
        IRMISMediator imp;
        ISessionProvider provider;
        IUserMessage msgInstance;
        private static readonly ILog Logger = LogManager.GetLogger(typeof(MasterPaddyBusiness));
        public MasterPaddyBusiness(IRMISMediator imp, ISessionProvider provider, IUserMessage msgInstance)
        {
            this.provider = provider;
            this.imp = imp;
            this.msgInstance = msgInstance;
        }

        #region Get Methods
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

        public List<RiceBrandDTO> GetRiceBrandEntities()
        {
            List<RiceBrandDTO> listRiceBrandDTO = null;
            // imp.GetSellerTypeEntity(
            List<MRiceBrandDetailsEntity> listMRiceBrandDetailsEntity = imp.GetMRiceBrandDetailsEntities(provider.GetCurrentCustomerId());
            if (listMRiceBrandDetailsEntity != null && listMRiceBrandDetailsEntity.Count > 0)
            {
                listRiceBrandDTO = new List<RiceBrandDTO>();
                foreach (MRiceBrandDetailsEntity objMRiceBrandDetailsEntity in listMRiceBrandDetailsEntity)
                {
                    RiceBrandDTO objGodownTypeDTO = new RiceBrandDTO();
                    objGodownTypeDTO.RiceBrand = objMRiceBrandDetailsEntity.Name;
                    objGodownTypeDTO.Indicator = GetYesorNo(objMRiceBrandDetailsEntity.ObsInd);
                    listRiceBrandDTO.Add(objGodownTypeDTO);
                }
            }
            return listRiceBrandDTO;
        }

        public List<RiceProductDTO> GetRiceProductEntities()
        {
            List<RiceProductDTO> listRiceProductDTO = null;
            // imp.GetSellerTypeEntity(
            List<MRiceProductionTypeEntity> listMRiceProductionTypeEntity = imp.GetMRiceProductionTypeEntities(provider.GetCurrentCustomerId());
            if (listMRiceProductionTypeEntity != null && listMRiceProductionTypeEntity.Count > 0)
            {
                listRiceProductDTO = new List<RiceProductDTO>();
                foreach (MRiceProductionTypeEntity objMRiceBrandDetailsEntity in listMRiceProductionTypeEntity)
                {
                    RiceProductDTO objRiceProductDTO = new RiceProductDTO();
                    objRiceProductDTO.RiceProduct = objMRiceBrandDetailsEntity.RiceType;
                    objRiceProductDTO.Indicator = GetYesorNo(objMRiceBrandDetailsEntity.ObsInd);
                    listRiceProductDTO.Add(objRiceProductDTO);
                }
            }
            return listRiceProductDTO;
        }

        public List<LotDetailsDTO> GetLotDetailsEntities(string GodownId)
        {
            List<LotDetailsDTO> listLotDetailsDTO = null;
            // imp.GetSellerTypeEntity(
            List<MLotDetailsEntity> listMLotDetailsEntity = imp.GetMLotDetailsEntities(provider.GetCurrentCustomerId(), GodownId);
            if (listMLotDetailsEntity != null && listMLotDetailsEntity.Count > 0)
            {
                listLotDetailsDTO = new List<LotDetailsDTO>();
                foreach (MLotDetailsEntity objMLotDetailsEntity in listMLotDetailsEntity)
                {
                    LotDetailsDTO objLotDetailsDTO = new LotDetailsDTO();
                    objLotDetailsDTO.LotDetails = objMLotDetailsEntity.LotName;
                    objLotDetailsDTO.Indicator = GetYesorNo(objMLotDetailsEntity.ObsInd);
                    listLotDetailsDTO.Add(objLotDetailsDTO);
                }
            }
            return listLotDetailsDTO;
        }       


        public List<PaddyStockInfoEntity> GetPaddyStockInfoEntities()
        {
            return imp.GetPaddyStockInfoEntities(provider.GetCurrentCustomerId());
        }


        public List<WeightDetailsDTO> GetMWeightDetailsEntities()
        {
            List<WeightDetailsDTO> listWeightDetailsDTO = null;
            // imp.GetSellerTypeEntity(
            List<MWeightDetailsEntity> listMWeightDetailsEntity = imp.GetMWeightDetailsEntities(provider.GetCurrentCustomerId());
            if (listMWeightDetailsEntity != null && listMWeightDetailsEntity.Count > 0)
            {
                listWeightDetailsDTO = new List<WeightDetailsDTO>();
                foreach (MWeightDetailsEntity objMLotDetailsEntity in listMWeightDetailsEntity)
                {
                    WeightDetailsDTO objWeightDetailsDTO = new WeightDetailsDTO();
                    objWeightDetailsDTO.WeightDetails = objMLotDetailsEntity.Weight;
                    objWeightDetailsDTO.Indicator = GetYesorNo(objMLotDetailsEntity.ObsInd);
                    listWeightDetailsDTO.Add(objWeightDetailsDTO);
                }
            }
            return listWeightDetailsDTO;
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

        List<PaddyTypeDTO> IMasterPaddyBusiness.GetMPaddyTypeEntities()
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

        public List<GodownTypeDTO> GetMGodownTypeEntities()
        {

            List<GodownTypeDTO> listGodownTypeDTO = null;
            // imp.GetSellerTypeEntity(
            List<MGodownDetailsEntity> listGodownDetailsEntiy = imp.GetMGodownDetailsEntities(provider.GetCurrentCustomerId());
            if (listGodownDetailsEntiy != null && listGodownDetailsEntiy.Count > 0)
            {
                listGodownTypeDTO = new List<GodownTypeDTO>();
                foreach (MGodownDetailsEntity objMGodownDetailsEntity in listGodownDetailsEntiy)
                {
                    GodownTypeDTO objGodownTypeDTO = new GodownTypeDTO();
                    objGodownTypeDTO.GodownType = objMGodownDetailsEntity.Name;
                    objGodownTypeDTO.Indicator = GetYesorNo(objMGodownDetailsEntity.ObsInd);
                    listGodownTypeDTO.Add(objGodownTypeDTO);
                }
            }
            return listGodownTypeDTO;
        } 
        #endregion


        #region Set Methods
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

        public ResultDTO SaveGodownType(string godownType)
        {
            MGodownDetailsEntity objMGodownDetailsEntity = new MGodownDetailsEntity();
            objMGodownDetailsEntity.ObsInd = YesNo.N;
            objMGodownDetailsEntity.CustID = provider.GetCurrentCustomerId();
            objMGodownDetailsEntity.LastModifiedBy = provider.GetLoggedInUserId();
            objMGodownDetailsEntity.Name = godownType;
            objMGodownDetailsEntity.MGodownID = CommonUtil.CreateUniqueID("GD");
            objMGodownDetailsEntity.LastModifiedDate = DateTime.Now;
            try
            {
                imp.BeginTransaction();
                imp.SaveOrUpdateMGodownDetailsEntity(objMGodownDetailsEntity, false);
                imp.CommitAndCloseSession();
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.Error03, provider.GetCurrentCustomerId()) };
            }
            return new ResultDTO() { Message = msgInstance.GetMessage(RMSConstants.Success03, provider.GetCurrentCustomerId()) };
        }

        public ResultDTO SaveRiceBrandType(string riceBrand)
        {
            MRiceBrandDetailsEntity objMRiceBrandDetailsEntityy = new MRiceBrandDetailsEntity();
            objMRiceBrandDetailsEntityy.ObsInd = YesNo.N;
            objMRiceBrandDetailsEntityy.CustID = provider.GetCurrentCustomerId();
            objMRiceBrandDetailsEntityy.LastModifiedBy = provider.GetLoggedInUserId();
            objMRiceBrandDetailsEntityy.Name = riceBrand;
            objMRiceBrandDetailsEntityy.MRiceBrandID = CommonUtil.CreateUniqueID("RB");
            objMRiceBrandDetailsEntityy.LastModifiedDate = DateTime.Now;
            try
            {
                imp.BeginTransaction();
                imp.SaveOrUpdateMRiceBrandDetailsEntity(objMRiceBrandDetailsEntityy, false);
                imp.CommitAndCloseSession();
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.Error04, provider.GetCurrentCustomerId()) };
            }
            return new ResultDTO() { Message = msgInstance.GetMessage(RMSConstants.Success04, provider.GetCurrentCustomerId()) };
        }

        public ResultDTO SaveRiceProductType(string riceProduct)
        {
            MRiceProductionTypeEntity objMRiceProductionTypeEntity = new MRiceProductionTypeEntity();
            objMRiceProductionTypeEntity.ObsInd = YesNo.N;
            objMRiceProductionTypeEntity.CustID = provider.GetCurrentCustomerId();
            objMRiceProductionTypeEntity.LastModifiedBy = provider.GetLoggedInUserId();
            objMRiceProductionTypeEntity.RiceType = riceProduct;
            objMRiceProductionTypeEntity.MRiceProdTypeID = CommonUtil.CreateUniqueID("RP");
            objMRiceProductionTypeEntity.LastModifiedDate = DateTime.Now;
            try
            {
                imp.BeginTransaction();
                imp.SaveOrUpdateMRiceProductionTypeEntity(objMRiceProductionTypeEntity, false);
                imp.CommitAndCloseSession();
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.Error05, provider.GetCurrentCustomerId()) };
            }
            return new ResultDTO() { Message = msgInstance.GetMessage(RMSConstants.Success05, provider.GetCurrentCustomerId()) };
        }

        public ResultDTO SaveLotDetails(string lotName, string godownId)
        {
            MLotDetailsEntity objMLotDetailsEntity = new MLotDetailsEntity();
            objMLotDetailsEntity.ObsInd = YesNo.N;
            objMLotDetailsEntity.CustID = provider.GetCurrentCustomerId();
            objMLotDetailsEntity.LastModifiedBy = provider.GetLoggedInUserId();
            objMLotDetailsEntity.LotName = lotName;
            objMLotDetailsEntity.MGodownID = godownId;
            objMLotDetailsEntity.MLotID = CommonUtil.CreateUniqueID("LT");
            objMLotDetailsEntity.LastModifiedDate = DateTime.Now;
            try
            {
                imp.BeginTransaction();
                imp.SaveOrUpdateMLotDetailsEntity(objMLotDetailsEntity, false);
                imp.CommitAndCloseSession();
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.Error06, provider.GetCurrentCustomerId()) };
            }
            return new ResultDTO() { Message = msgInstance.GetMessage(RMSConstants.Success06, provider.GetCurrentCustomerId()) };
        } 
        #endregion

        public ResultDTO SaveWeightDetails(string weight)
        {
            MWeightDetailsEntity objMWeightDetailsEntity = new MWeightDetailsEntity();
            objMWeightDetailsEntity.ObsInd = YesNo.N;
            objMWeightDetailsEntity.CustID = provider.GetCurrentCustomerId();
            objMWeightDetailsEntity.LastModifiedBy = provider.GetLoggedInUserId();
            objMWeightDetailsEntity.Weight =(short) weight.ConvertToInt();            
            objMWeightDetailsEntity.MWeightID = CommonUtil.CreateUniqueID("WE");
            objMWeightDetailsEntity.LastModifiedDate = DateTime.Now;
            try
            {
                imp.BeginTransaction();
                imp.SaveOrUpdateMWeightDetailsEntity(objMWeightDetailsEntity, false);
                imp.CommitAndCloseSession();
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.Error06, provider.GetCurrentCustomerId()) };
            }
            return new ResultDTO() { Message = msgInstance.GetMessage(RMSConstants.Success06, provider.GetCurrentCustomerId()) };
        }
    }
}
