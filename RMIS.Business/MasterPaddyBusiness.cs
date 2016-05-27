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
                    objSellerTypeDTO.Id = objSellerTypeEntity.SellerTypeID;
                    listSellerTypeDTO.Add(objSellerTypeDTO);
                }

            }
            return listSellerTypeDTO;
        }

        public List<MenuInfoEntity> GetMenuInfoEnity()
        {
            return imp.GetAllMenuInfoEntities();
        }

        public List<MBagTypeDTO> GetMBagTypeEntities()
        {
            List<MBagTypeDTO> listMBagTypeDTO = null;
            // imp.GetSellerTypeEntity(
            List<MBagTypeEntity> listMBagTypeEntity = imp.GetMBagTypeEntities(provider.GetCurrentCustomerId());
            if (listMBagTypeEntity != null && listMBagTypeEntity.Count > 0)
            {
                listMBagTypeDTO = new List<MBagTypeDTO>();
                foreach (MBagTypeEntity objMBagTypeEntity in listMBagTypeEntity)
                {
                    MBagTypeDTO objMBagTypeDTO = new MBagTypeDTO();
                    objMBagTypeDTO.BagType = objMBagTypeEntity.BagType;
                    objMBagTypeDTO.Indicator = GetYesorNo(objMBagTypeEntity.ObsInd);
                    objMBagTypeDTO.Id = objMBagTypeEntity.BagTypeID;
                    listMBagTypeDTO.Add(objMBagTypeDTO);
                }

            }
            return listMBagTypeDTO;
        }
        public List<PaddyTypeDTO> GetMPaddyTypeEntities()
        {
            List<PaddyTypeDTO> listPaddyTypeDTO = null;
            // imp.GetSellerTypeEntity(
            List<MPaddyTypeEntity> listMPaddyTypeEntity = imp.GetMPaddyTypeEntitiies(provider.GetCurrentCustomerId());
            if (listMPaddyTypeEntity != null && listMPaddyTypeEntity.Count > 0)
            {
                listPaddyTypeDTO = new List<PaddyTypeDTO>();
                foreach (MPaddyTypeEntity objPaddyTypeEntity in listMPaddyTypeEntity)
                {
                    PaddyTypeDTO objPaddyTypeDTO = new PaddyTypeDTO();
                    objPaddyTypeDTO.PaddyType = objPaddyTypeEntity.Name;
                    objPaddyTypeDTO.Indicator = GetYesorNo(objPaddyTypeEntity.ObsInd);
                    objPaddyTypeDTO.Id = objPaddyTypeEntity.PaddyTypeID;
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
                    objGodownTypeDTO.Id = objMGodownDetailsEntity.MGodownID;
                    listGodownTypeDTO.Add(objGodownTypeDTO);
                }
            }
            return listGodownTypeDTO;
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
                    RiceBrandDTO objRiceBrandDTO = new RiceBrandDTO();
                    objRiceBrandDTO.RiceBrand = objMRiceBrandDetailsEntity.Name;
                    objRiceBrandDTO.Indicator = GetYesorNo(objMRiceBrandDetailsEntity.ObsInd);
                    objRiceBrandDTO.Id = objMRiceBrandDetailsEntity.MRiceBrandID;
                    listRiceBrandDTO.Add(objRiceBrandDTO);
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
                foreach (MRiceProductionTypeEntity objMRiceProductionTypeEntity in listMRiceProductionTypeEntity)
                {
                    RiceProductDTO objRiceProductDTO = new RiceProductDTO();
                    objRiceProductDTO.RiceType = objMRiceProductionTypeEntity.RiceType;
                    objRiceProductDTO.Indicator = GetYesorNo(objMRiceProductionTypeEntity.ObsInd);
                    objRiceProductDTO.Id = objMRiceProductionTypeEntity.MRiceProdTypeID;
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
                    objLotDetailsDTO.Id = objMLotDetailsEntity.MLotID;
                    listLotDetailsDTO.Add(objLotDetailsDTO);
                }
            }
            return listLotDetailsDTO;
        }
        public List<LotDetailsDTO> GetLotDetailsEntities()
        {
            List<LotDetailsDTO> listLotDetailsDTO = null;
            // imp.GetSellerTypeEntity(
            List<MLotDetailsEntity> listMLotDetailsEntity = imp.GetMLotDetailsEntities(provider.GetCurrentCustomerId());
            if (listMLotDetailsEntity != null && listMLotDetailsEntity.Count > 0)
            {
                listLotDetailsDTO = new List<LotDetailsDTO>();
                foreach (MLotDetailsEntity objMLotDetailsEntity in listMLotDetailsEntity)
                {
                    LotDetailsDTO objLotDetailsDTO = new LotDetailsDTO();
                    objLotDetailsDTO.LotDetails = objMLotDetailsEntity.LotName;
                    objLotDetailsDTO.Indicator = GetYesorNo(objMLotDetailsEntity.ObsInd);
                    objLotDetailsDTO.Id = objMLotDetailsEntity.MLotID;
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
                    objWeightDetailsDTO.Id = objMLotDetailsEntity.MWeightID;
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
        public List<BrokenRiceTypeDTO> GetMBrokenRiceTypeEntities()
        {
            List<BrokenRiceTypeDTO> listBrokenRiceTypeDTO = null;
            // imp.GetSellerTypeEntity(
            List<MBrokenRiceTypeEntity> listMBrokenRiceTypeEntity = imp.GetMBrokenRiceTypeEntitiies(provider.GetCurrentCustomerId());
            if (listMBrokenRiceTypeEntity != null && listMBrokenRiceTypeEntity.Count > 0)
            {
                listBrokenRiceTypeDTO = new List<BrokenRiceTypeDTO>();
                foreach (MBrokenRiceTypeEntity objSellerTypeEntity in listMBrokenRiceTypeEntity)
                {
                    BrokenRiceTypeDTO objBrokenRiceTypeDTO = new BrokenRiceTypeDTO();
                    objBrokenRiceTypeDTO.BrokenRiceType = objSellerTypeEntity.BrokenRiceName;
                    objBrokenRiceTypeDTO.Indicator = GetYesorNo(objSellerTypeEntity.ObsInd);
                    objBrokenRiceTypeDTO.Id = objSellerTypeEntity.BrokenRiceTypeID;
                    listBrokenRiceTypeDTO.Add(objBrokenRiceTypeDTO);
                }

            }
            return listBrokenRiceTypeDTO;
        }
        public List<MUnitsTypeDTO> GetMUnitsTypeEntities()
        {
            List<MUnitsTypeDTO> listMUnitsTypeDTO = null;
            // imp.GetSellerTypeEntity(
            List<MUnitsTypeEntity> listMUnitsTypeEntity = imp.GetMUnitsTypeEntities(provider.GetCurrentCustomerId());
            if (listMUnitsTypeEntity != null && listMUnitsTypeEntity.Count > 0)
            {
                listMUnitsTypeDTO = new List<MUnitsTypeDTO>();
                foreach (MUnitsTypeEntity objMUnitsTypeEntity in listMUnitsTypeEntity)
                {
                    MUnitsTypeDTO objMUnitsTypeDTO = new MUnitsTypeDTO();
                    objMUnitsTypeDTO.UnitsType = objMUnitsTypeEntity.UnitsType;
                    objMUnitsTypeDTO.Indicator = GetYesorNo(objMUnitsTypeEntity.ObsInd);
                    objMUnitsTypeDTO.Id = objMUnitsTypeEntity.UnitsTypeID;
                    listMUnitsTypeDTO.Add(objMUnitsTypeDTO);
                }
            }
            return listMUnitsTypeDTO;
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
        public ResultDTO SaveBagType(string BagType)
        {
            MBagTypeEntity objMBagTypeEntity = new MBagTypeEntity();
            objMBagTypeEntity.ObsInd = YesNo.N;
            objMBagTypeEntity.CustID = provider.GetCurrentCustomerId();
            objMBagTypeEntity.LastModifiedBy = provider.GetLoggedInUserId();
            objMBagTypeEntity.BagType = BagType;
            objMBagTypeEntity.BagTypeID = CommonUtil.CreateUniqueID("BT");
            objMBagTypeEntity.LastModifiedDate = DateTime.Now;
            try
            {
                imp.BeginTransaction();
                imp.SaveOrUpdateMBagTypeEntity(objMBagTypeEntity, false);
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
        public ResultDTO SaveWeightDetails(string weight)
        {
            MWeightDetailsEntity objMWeightDetailsEntity = new MWeightDetailsEntity();
            objMWeightDetailsEntity.ObsInd = YesNo.N;
            objMWeightDetailsEntity.CustID = provider.GetCurrentCustomerId();
            objMWeightDetailsEntity.LastModifiedBy = provider.GetLoggedInUserId();
            objMWeightDetailsEntity.Weight = (short)weight.ConvertToInt();
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
        public ResultDTO SaveUnitsType(string UnitsType)
        {
            MUnitsTypeEntity objMUnitsTypeEntity = new MUnitsTypeEntity();
            objMUnitsTypeEntity.ObsInd = YesNo.N;
            objMUnitsTypeEntity.CustID = provider.GetCurrentCustomerId();
            objMUnitsTypeEntity.LastModifiedBy = provider.GetLoggedInUserId();
            objMUnitsTypeEntity.UnitsType = UnitsType;
            objMUnitsTypeEntity.UnitsTypeID = CommonUtil.CreateUniqueID("BT");
            objMUnitsTypeEntity.LastModifiedDate = DateTime.Now;
            try
            {
                imp.BeginTransaction();
                imp.SaveOrUpdateMUnitsTypeEntity(objMUnitsTypeEntity, false);
                imp.CommitAndCloseSession();
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.Error01, provider.GetCurrentCustomerId()) };
            }
            return new ResultDTO() { Message = msgInstance.GetMessage(RMSConstants.Success01, provider.GetCurrentCustomerId()) };
        }
        public ResultDTO SaveBrokenRiceType(string BrokenRiceType)
        {

            MBrokenRiceTypeEntity objMBrokenRiceTypeEntity = new MBrokenRiceTypeEntity();
            objMBrokenRiceTypeEntity.ObsInd = YesNo.N;
            objMBrokenRiceTypeEntity.CustID = provider.GetCurrentCustomerId();
            objMBrokenRiceTypeEntity.LastModifiedBy = provider.GetLoggedInUserId();
            objMBrokenRiceTypeEntity.BrokenRiceName = BrokenRiceType;
            objMBrokenRiceTypeEntity.BrokenRiceTypeID = CommonUtil.CreateUniqueID("PT");
            objMBrokenRiceTypeEntity.LastModifiedDate = DateTime.Now;
            try
            {
                imp.BeginTransaction();
                imp.SaveOrUpdateMBrokenRiceTypeEntity(objMBrokenRiceTypeEntity, false);
                imp.CommitAndCloseSession();
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.Error02, provider.GetCurrentCustomerId()) };
            }
            return new ResultDTO() { Message = msgInstance.GetMessage(RMSConstants.Success02, provider.GetCurrentCustomerId()) };
        }
        #endregion



        public List<ProductSellingTypeDTO> GetMProductSellingTypeEntities()
        {

            List<ProductSellingTypeDTO> listProductSellingTypeDTO = null;
            // imp.GetSellerTypeEntity(
            List<MProductSellingTypeEntity> listMProductSellingTypeEntity = imp.GetMProductSellingTypeEnties(provider.GetCurrentCustomerId());
            if (listMProductSellingTypeEntity != null && listMProductSellingTypeEntity.Count > 0)
            {
                listProductSellingTypeDTO = new List<ProductSellingTypeDTO>();
                foreach (MProductSellingTypeEntity objProductSellingTypeEntity in listMProductSellingTypeEntity)
                {
                    ProductSellingTypeDTO objProductSellingTypeDTO = new ProductSellingTypeDTO();
                    objProductSellingTypeDTO.ProductSellingType = objProductSellingTypeEntity.ProductType;
                    objProductSellingTypeDTO.Indicator = GetYesorNo(objProductSellingTypeEntity.ObsInd);
                    objProductSellingTypeDTO.Id = objProductSellingTypeEntity.ProductTypeID;
                    listProductSellingTypeDTO.Add(objProductSellingTypeDTO);
                }

            }
            return listProductSellingTypeDTO;
        }

        public ResultDTO SaveProductSellingType(string productSellingType)
        {

            MProductSellingTypeEntity objMProductSellingTypeEntity = new MProductSellingTypeEntity();
            objMProductSellingTypeEntity.ObsInd = YesNo.N;
            objMProductSellingTypeEntity.CustID = provider.GetCurrentCustomerId();
            objMProductSellingTypeEntity.LastModifiedBy = provider.GetLoggedInUserId();
            objMProductSellingTypeEntity.ProductType = productSellingType;
            objMProductSellingTypeEntity.ProductTypeID = CommonUtil.CreateUniqueID("PRT");
            objMProductSellingTypeEntity.LastModifiedDate = DateTime.Now;
            try
            {
                imp.BeginTransaction();
                imp.SaveOrUpdateMProductSellingTypeEntity(objMProductSellingTypeEntity, false);
                imp.CommitAndCloseSession();
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.Error02, provider.GetCurrentCustomerId()) };
            }
            return new ResultDTO() { Message = msgInstance.GetMessage(RMSConstants.Success02, provider.GetCurrentCustomerId()) };
        }


        public ResultDTO SaveRoleEntity(string roleName)
        {

            MRolesEntity objMRolesEntity = new MRolesEntity();
            objMRolesEntity.ObsInd = YesNo.N;
            objMRolesEntity.RoleId  = CommonUtil.CreateUniqueID("RL");
            objMRolesEntity.LastModifiedBy = provider.GetLoggedInUserId();
            objMRolesEntity.RoleName = roleName;
            objMRolesEntity.Description = roleName;
            objMRolesEntity.LastModifiedDate = DateTime.Now;
            
            try
            {
                imp.BeginTransaction();
                imp.SaveOrUpdateRoleEntity(objMRolesEntity, false);
                imp.CommitAndCloseSession();
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                return new ResultDTO() { IsSuccess = false, Message = "Role was not created" };
            }
            return new ResultDTO() { Message = "Role created successfully." };
        }


        public List<MRolesEntity> GetAllRolesEntities()
        {
           return  imp.GetAllRolesEntity();
        }
    }
}
