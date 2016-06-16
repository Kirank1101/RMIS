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

        public List<MenuInfoEntity> GetMenuInfoEnity()
        {
            return imp.GetAllMenuInfoEntities(YesNo.N);
        }

        public List<MBagTypeDTO> GetMBagTypeEntities()
        {
            List<MBagTypeDTO> listMBagTypeDTO = null;

            List<MBagTypeEntity> listMBagTypeEntity = imp.GetMBagTypeEntities(provider.GetCurrentCustomerId(), YesNo.N);
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

            List<MPaddyTypeEntity> listMPaddyTypeEntity = imp.GetMPaddyTypeEntitiies(provider.GetCurrentCustomerId(), YesNo.N);
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

        public bool CheckPaddyTypeExist(string paddytype)
        {
            bool IsPaddyTypeExist = false;

            List<MPaddyTypeEntity> listMPaddyTypeEntity = imp.CheckPaddyTypeExist(provider.GetCurrentCustomerId(), paddytype, YesNo.N);
            if (listMPaddyTypeEntity != null && listMPaddyTypeEntity.Count > 0)
                IsPaddyTypeExist = true;

            return IsPaddyTypeExist;
        }

        public bool CheckUnitTypeExist(string UnitType)
        {
            bool IsUnitTypeExist = false;

            MUnitsTypeEntity UnitTypeEntity = imp.CheckUnitTypeExist(provider.GetCurrentCustomerId(), UnitType, YesNo.N);
            if (UnitTypeEntity != null)
                IsUnitTypeExist = true;

            return IsUnitTypeExist;
        }

        public List<PaddyTypeDTO> GetMPaddyTypeEntities(int pageindex, int pageSize, out int count, SortExpression expression)
        {
            List<PaddyTypeDTO> listPaddyTypeDTO = null;

            List<MPaddyTypeEntity> listMPaddyTypeEntity = imp.GetMPaddyTypeEntities(provider.GetCurrentCustomerId(), pageindex, pageSize, out count, expression, YesNo.N);
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

            List<MGodownDetailsEntity> listGodownDetailsEntiy = imp.GetMGodownDetailsEntities(provider.GetCurrentCustomerId(), YesNo.N);
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
            return imp.GetMUserTypeEntities(provider.GetCurrentCustomerId(), YesNo.N);
        }
        public List<RiceBrandDTO> GetRiceBrandEntities()
        {
            List<RiceBrandDTO> listRiceBrandDTO = null;

            List<MRiceBrandDetailsEntity> listMRiceBrandDetailsEntity = imp.GetMRiceBrandDetailsEntities(provider.GetCurrentCustomerId(), YesNo.N);
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
        public List<RiceTypeDTO> GetRiceProductEntities()
        {
            List<RiceTypeDTO> listRiceProductDTO = null;

            List<MRiceProductionTypeEntity> listMRiceProductionTypeEntity = imp.GetMRiceProductionTypeEntities(provider.GetCurrentCustomerId(), YesNo.N);
            if (listMRiceProductionTypeEntity != null && listMRiceProductionTypeEntity.Count > 0)
            {
                listRiceProductDTO = new List<RiceTypeDTO>();
                foreach (MRiceProductionTypeEntity objMRiceProductionTypeEntity in listMRiceProductionTypeEntity)
                {
                    RiceTypeDTO objRiceProductDTO = new RiceTypeDTO();
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

            List<MLotDetailsEntity> listMLotDetailsEntity = imp.GetMLotDetailsEntities(provider.GetCurrentCustomerId(), GodownId, YesNo.N);
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

            List<MLotDetailsEntity> listMLotDetailsEntity = imp.GetMLotDetailsEntities(provider.GetCurrentCustomerId(), YesNo.N);
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
            return imp.GetPaddyStockInfoEntities(provider.GetCurrentCustomerId(), YesNo.N);
        }
        public List<WeightDetailsDTO> GetMWeightDetailsEntities()
        {
            List<WeightDetailsDTO> listWeightDetailsDTO = null;

            List<MWeightDetailsEntity> listMWeightDetailsEntity = imp.GetMWeightDetailsEntities(provider.GetCurrentCustomerId(), YesNo.N);
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
        public List<BrokenRiceTypeDTO> GetMBrokenRiceTypeEntities()
        {
            List<BrokenRiceTypeDTO> listBrokenRiceTypeDTO = null;

            List<MBrokenRiceTypeEntity> listMBrokenRiceTypeEntity = imp.GetMBrokenRiceTypeEntitiies(provider.GetCurrentCustomerId(), YesNo.N);
            if (listMBrokenRiceTypeEntity != null && listMBrokenRiceTypeEntity.Count > 0)
            {
                listBrokenRiceTypeDTO = new List<BrokenRiceTypeDTO>();
                foreach (MBrokenRiceTypeEntity objMBrokenRiceTypeEntity in listMBrokenRiceTypeEntity)
                {
                    BrokenRiceTypeDTO objBrokenRiceTypeDTO = new BrokenRiceTypeDTO();
                    objBrokenRiceTypeDTO.BrokenRiceType = objMBrokenRiceTypeEntity.BrokenRiceName;
                    objBrokenRiceTypeDTO.Indicator = GetYesorNo(objMBrokenRiceTypeEntity.ObsInd);
                    objBrokenRiceTypeDTO.Id = objMBrokenRiceTypeEntity.BrokenRiceTypeID;
                    listBrokenRiceTypeDTO.Add(objBrokenRiceTypeDTO);
                }

            }
            return listBrokenRiceTypeDTO;
        }
        public List<MUnitsTypeDTO> GetMUnitsTypeEntities()
        {
            List<MUnitsTypeDTO> listMUnitsTypeDTO = null;

            List<MUnitsTypeEntity> listMUnitsTypeEntity = imp.GetMUnitsTypeEntities(provider.GetCurrentCustomerId(), YesNo.N);
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
        public List<MEmpDesigDTO> GetMEmpDesigTypeEntities()
        {
            List<MEmpDesigDTO> listMEmpDesigDTO = null;

            List<MEmployeeDesignationEntity> listMEmployeeDesignationEntity = imp.GetListMEmployeeDesignationEntities(provider.GetCurrentCustomerId(), YesNo.N);
            if (listMEmployeeDesignationEntity != null && listMEmployeeDesignationEntity.Count > 0)
            {
                listMEmpDesigDTO = new List<MEmpDesigDTO>();
                foreach (MEmployeeDesignationEntity objMEmpDesigEntity in listMEmployeeDesignationEntity)
                {
                    MEmpDesigDTO objMEmpDesigDTO = new MEmpDesigDTO();
                    objMEmpDesigDTO.DesignationType = objMEmpDesigEntity.DesignationType;
                    objMEmpDesigDTO.Indicator = GetYesorNo(objMEmpDesigEntity.ObsInd);
                    objMEmpDesigDTO.Id = objMEmpDesigEntity.MEmpDsgID;
                    listMEmpDesigDTO.Add(objMEmpDesigDTO);
                }

            }
            return listMEmpDesigDTO;
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
        #endregion


        #region Set Methods

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

        public ResultDTO DeletePaddyType(string Id)
        {

            MPaddyTypeEntity objMPaddyTypeEntity = imp.GetMPaddyTypeEntity(Id, YesNo.N);
            if (objMPaddyTypeEntity is MPaddyTypeEntity)
            {
                objMPaddyTypeEntity.ObsInd = YesNo.Y;
                objMPaddyTypeEntity.LastModifiedBy = provider.GetLoggedInUserId();
                objMPaddyTypeEntity.LastModifiedDate = DateTime.Now;
                try
                {
                    imp.BeginTransaction();
                    imp.SaveOrUpdateMPaddyTypeEntity(objMPaddyTypeEntity, true);
                    imp.CommitAndCloseSession();
                }
                catch (Exception ex)
                {
                    Logger.Error(ex);
                    return new ResultDTO() { IsSuccess = false, Message = ex.Message };
                }
            }
            return new ResultDTO();
        }

        public ResultDTO UpdatePaddyType(string Id, string paddyType)
        {

            MPaddyTypeEntity objMPaddyTypeEntity = imp.GetMPaddyTypeEntity(Id, YesNo.N);
            if (objMPaddyTypeEntity is MPaddyTypeEntity)
            {
                objMPaddyTypeEntity.Name = paddyType;
                objMPaddyTypeEntity.LastModifiedBy = provider.GetLoggedInUserId();
                objMPaddyTypeEntity.LastModifiedDate = DateTime.Now;
                try
                {

                    imp.BeginTransaction();
                    imp.SaveOrUpdateMPaddyTypeEntity(objMPaddyTypeEntity, true);
                    imp.CommitAndCloseSession();
                }
                catch (Exception ex)
                {
                    Logger.Error(ex);
                    return new ResultDTO() { IsSuccess = false, Message = ex.Message };
                }
            }
            return new ResultDTO();
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

            List<MProductSellingTypeEntity> listMProductSellingTypeEntity = imp.GetMProductSellingTypeEnties(provider.GetCurrentCustomerId(), YesNo.N);
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
            objMRolesEntity.RoleId = CommonUtil.CreateUniqueID("RL");
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
            return imp.GetAllRolesEntity(YesNo.N);
        }


        public bool CheckGodownNameExist(string GodownName)
        {
            bool IsGodownNameExist = false;

            MGodownDetailsEntity MGodownDetailsEntity = imp.CheckGodownNameExist(provider.GetCurrentCustomerId(), GodownName, YesNo.N);
            if (MGodownDetailsEntity != null)
                IsGodownNameExist = true;

            return IsGodownNameExist;
        }


        public bool CheckLotNameExist(string LotName)
        {
            bool IsLotNameExist = false;

            MLotDetailsEntity MLotDetailsEntity = imp.CheckLotNameExist(provider.GetCurrentCustomerId(), LotName, YesNo.N);
            if (MLotDetailsEntity != null)
                IsLotNameExist = true;

            return IsLotNameExist;
        }



        public ResultDTO SaveEmpDesigType(string DesignationType)
        {
            MEmployeeDesignationEntity objMEmployeeDesignationEntity = new MEmployeeDesignationEntity();
            objMEmployeeDesignationEntity.ObsInd = YesNo.N;
            objMEmployeeDesignationEntity.MEmpDsgID = CommonUtil.CreateUniqueID("EI");
            objMEmployeeDesignationEntity.LastModifiedBy = provider.GetLoggedInUserId();
            objMEmployeeDesignationEntity.CustID = provider.GetCurrentCustomerId();
            objMEmployeeDesignationEntity.DesignationType = DesignationType;
            objMEmployeeDesignationEntity.LastModifiedDate = DateTime.Now;

            try
            {
                imp.BeginTransaction();
                imp.SaveOrUpdateMEmployeeDesignationEntity(objMEmployeeDesignationEntity, false);
                imp.CommitAndCloseSession();
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.Error02, provider.GetCurrentCustomerId()) };
            }
            return new ResultDTO() { Message = msgInstance.GetMessage(RMSConstants.Success02, provider.GetCurrentCustomerId()) };
        }
        public bool CheckEmpDesigExist(string DesignationType)
        {
            bool IsDesignationExist = false;

            MEmployeeDesignationEntity MEmployeeDesignationEntity = imp.CheckEmpDesigExist(provider.GetCurrentCustomerId(), DesignationType, YesNo.N);
            if (MEmployeeDesignationEntity != null)
                IsDesignationExist = true;

            return IsDesignationExist;
        }
        public bool CheckSalaryTypeExist(string SalaryType)
        {
            bool IsSalaryTypeExist = false;

            MSalaryTypeEntity MSalaryTypeEntityEntity = imp.CheckSalaryTypeExist(provider.GetCurrentCustomerId(), SalaryType, YesNo.N);
            if (MSalaryTypeEntityEntity != null)
                IsSalaryTypeExist = true;

            return IsSalaryTypeExist;
        }

        public List<MSalarytypeDTO> GetMSalaryTypeEntities()
        {
            List<MSalarytypeDTO> listMSalarytypeDTO = null;

            List<MSalaryTypeEntity> listMSalaryTypeEntity = imp.GetListMSalaryTypeEntities(provider.GetCurrentCustomerId(), YesNo.N);
            if (listMSalaryTypeEntity != null && listMSalaryTypeEntity.Count > 0)
            {
                listMSalarytypeDTO = new List<MSalarytypeDTO>();
                foreach (MSalaryTypeEntity objMEmpDesigEntity in listMSalaryTypeEntity)
                {
                    MSalarytypeDTO objMSalarytypeDTO = new MSalarytypeDTO();
                    objMSalarytypeDTO.SalaryType = objMEmpDesigEntity.Salarytype;
                    objMSalarytypeDTO.Indicator = GetYesorNo(objMEmpDesigEntity.ObsInd);
                    objMSalarytypeDTO.Id = objMEmpDesigEntity.MSalaryTypeID;
                    listMSalarytypeDTO.Add(objMSalarytypeDTO);
                }

            }
            return listMSalarytypeDTO;
        }

        public ResultDTO SaveSalaryType(string SalaryType)
        {
            MSalaryTypeEntity objMSalaryTypeEntity = new MSalaryTypeEntity();
            objMSalaryTypeEntity.ObsInd = YesNo.N;
            objMSalaryTypeEntity.MSalaryTypeID = CommonUtil.CreateUniqueID("ST");
            objMSalaryTypeEntity.LastModifiedBy = provider.GetLoggedInUserId();
            objMSalaryTypeEntity.CustID = provider.GetCurrentCustomerId();
            objMSalaryTypeEntity.Salarytype = SalaryType;
            objMSalaryTypeEntity.LastModifiedDate = DateTime.Now;

            try
            {
                imp.BeginTransaction();
                imp.SaveOrUpdateMSalaryTypeEntity(objMSalaryTypeEntity, false);
                imp.CommitAndCloseSession();
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                return new ResultDTO() { IsSuccess = false, Message = msgInstance.GetMessage(RMSConstants.Error02, provider.GetCurrentCustomerId()) };
            }
            return new ResultDTO() { Message = msgInstance.GetMessage(RMSConstants.Success02, provider.GetCurrentCustomerId()) };
        }


        public string GetEmployeeDesignation(string DesignationID)
        {
            string designation = string.Empty;
            MEmployeeDesignationEntity empdesig = imp.GetMEmployeeDesignationEntity(provider.GetCurrentCustomerId(), DesignationID, YesNo.N);
            if (empdesig != null)
                designation = empdesig.DesignationType;

            return designation;
        }
        public string GetSalaryType(string SalaryTypeId)
        {
            string SalaryType = string.Empty;
            MSalaryTypeEntity Msalarytype = imp.GetListMSalaryTypeEntity(provider.GetCurrentCustomerId(), SalaryTypeId, YesNo.N);
            if (Msalarytype != null)
                SalaryType = Msalarytype.Salarytype;
            return SalaryType;
        }


        public ResultDTO DeleteUnitsType(string Id)
        {
            MUnitsTypeEntity objMUnitsTypeEntity = imp.GetMUnitsTypeEntity(Id, YesNo.N);
            if (objMUnitsTypeEntity is MUnitsTypeEntity)
            {
                objMUnitsTypeEntity.ObsInd = YesNo.Y;
                objMUnitsTypeEntity.LastModifiedBy = provider.GetLoggedInUserId();
                objMUnitsTypeEntity.LastModifiedDate = DateTime.Now;
                try
                {
                    imp.BeginTransaction();
                    imp.SaveOrUpdateMUnitsTypeEntity(objMUnitsTypeEntity, true);
                    imp.CommitAndCloseSession();
                }
                catch (Exception ex)
                {
                    Logger.Error(ex);
                    return new ResultDTO() { IsSuccess = false, Message = ex.Message };
                }
            }
            return new ResultDTO();
        }
        public ResultDTO DeleteGodownType(string ID)
        {
            MGodownDetailsEntity objMGodownDetailsEntity = imp.GetMGodownDetailsEntity(ID, YesNo.N);
            if (objMGodownDetailsEntity is MGodownDetailsEntity)
            {
                objMGodownDetailsEntity.ObsInd = YesNo.Y;
                objMGodownDetailsEntity.LastModifiedBy = provider.GetLoggedInUserId();
                objMGodownDetailsEntity.LastModifiedDate = DateTime.Now;
                try
                {
                    imp.BeginTransaction();
                    imp.SaveOrUpdateMGodownDetailsEntity(objMGodownDetailsEntity, true);
                    imp.CommitAndCloseSession();
                }
                catch (Exception ex)
                {
                    Logger.Error(ex);
                    return new ResultDTO() { IsSuccess = false, Message = ex.Message };
                }
            }
            return new ResultDTO();
        }
        public ResultDTO DeleteLotDetails(string ID)
        {
            MLotDetailsEntity objMLotDetailsEntity = imp.GetMLotDetailsEntity(ID, YesNo.N);
            if (objMLotDetailsEntity is MLotDetailsEntity)
            {
                objMLotDetailsEntity.ObsInd = YesNo.Y;
                objMLotDetailsEntity.LastModifiedBy = provider.GetLoggedInUserId();
                objMLotDetailsEntity.LastModifiedDate = DateTime.Now;
                try
                {
                    imp.BeginTransaction();
                    imp.SaveOrUpdateMLotDetailsEntity(objMLotDetailsEntity, true);
                    imp.CommitAndCloseSession();
                }
                catch (Exception ex)
                {
                    Logger.Error(ex);
                    return new ResultDTO() { IsSuccess = false, Message = ex.Message };
                }
            }
            return new ResultDTO();
        }
        public ResultDTO DeleteBagType(string ID)
        {
            MBagTypeEntity objMBagTypeEntity = imp.GetMBagTypeEntity(ID, YesNo.N);
            if (objMBagTypeEntity is MBagTypeEntity)
            {
                objMBagTypeEntity.ObsInd = YesNo.Y;
                objMBagTypeEntity.LastModifiedBy = provider.GetLoggedInUserId();
                objMBagTypeEntity.LastModifiedDate = DateTime.Now;
                try
                {
                    imp.BeginTransaction();
                    imp.SaveOrUpdateMBagTypeEntity(objMBagTypeEntity, true);
                    imp.CommitAndCloseSession();
                }
                catch (Exception ex)
                {
                    Logger.Error(ex);
                    return new ResultDTO() { IsSuccess = false, Message = ex.Message };
                }
            }
            return new ResultDTO();
        }
        public ResultDTO DeleteRiceType(string ID)
        {
            MRiceProductionTypeEntity objMRiceTypeEntity = imp.GetMRiceProductionTypeEntity(ID, YesNo.N);
            if (objMRiceTypeEntity is MRiceProductionTypeEntity)
            {
                objMRiceTypeEntity.ObsInd = YesNo.Y;
                objMRiceTypeEntity.LastModifiedBy = provider.GetLoggedInUserId();
                objMRiceTypeEntity.LastModifiedDate = DateTime.Now;
                try
                {
                    imp.BeginTransaction();
                    imp.SaveOrUpdateMRiceProductionTypeEntity(objMRiceTypeEntity, true);
                    imp.CommitAndCloseSession();
                }
                catch (Exception ex)
                {
                    Logger.Error(ex);
                    return new ResultDTO() { IsSuccess = false, Message = ex.Message };
                }
            }
            return new ResultDTO();
        }
        public ResultDTO DeleteBrokenRiceType(string ID)
        {
            MBrokenRiceTypeEntity objMBrokenRiceTypeEntity = imp.GetMBrokenRiceTypeEntity(ID, YesNo.N);
            if (objMBrokenRiceTypeEntity is MBrokenRiceTypeEntity)
            {
                objMBrokenRiceTypeEntity.ObsInd = YesNo.Y;
                objMBrokenRiceTypeEntity.LastModifiedBy = provider.GetLoggedInUserId();
                objMBrokenRiceTypeEntity.LastModifiedDate = DateTime.Now;
                try
                {
                    imp.BeginTransaction();
                    imp.SaveOrUpdateMBrokenRiceTypeEntity(objMBrokenRiceTypeEntity, true);
                    imp.CommitAndCloseSession();
                }
                catch (Exception ex)
                {
                    Logger.Error(ex);
                    return new ResultDTO() { IsSuccess = false, Message = ex.Message };
                }
            }
            return new ResultDTO();
        }
        public ResultDTO DeleteRiceBrandType(string ID)
        {
            MRiceBrandDetailsEntity objMRiceBrandEntity = imp.GetMRiceBrandDetailsEntity(ID, YesNo.N);
            if (objMRiceBrandEntity is MRiceBrandDetailsEntity)
            {
                objMRiceBrandEntity.ObsInd = YesNo.Y;
                objMRiceBrandEntity.LastModifiedBy = provider.GetLoggedInUserId();
                objMRiceBrandEntity.LastModifiedDate = DateTime.Now;
                try
                {
                    imp.BeginTransaction();
                    imp.SaveOrUpdateMRiceBrandDetailsEntity(objMRiceBrandEntity, true);
                    imp.CommitAndCloseSession();
                }
                catch (Exception ex)
                {
                    Logger.Error(ex);
                    return new ResultDTO() { IsSuccess = false, Message = ex.Message };
                }
            }
            return new ResultDTO();
        }
        public ResultDTO DeleteDesigType(string ID)
        {
            MEmployeeDesignationEntity objMEmpDesigEntity = imp.GetMEmployeeDesignationEntity(ID, YesNo.N);
            if (objMEmpDesigEntity is MEmployeeDesignationEntity)
            {
                objMEmpDesigEntity.ObsInd = YesNo.Y;
                objMEmpDesigEntity.LastModifiedBy = provider.GetLoggedInUserId();
                objMEmpDesigEntity.LastModifiedDate = DateTime.Now;
                try
                {
                    imp.BeginTransaction();
                    imp.SaveOrUpdateMEmployeeDesignationEntity(objMEmpDesigEntity, true);
                    imp.CommitAndCloseSession();
                }
                catch (Exception ex)
                {
                    Logger.Error(ex);
                    return new ResultDTO() { IsSuccess = false, Message = ex.Message };
                }
            }
            return new ResultDTO();
        }
        public ResultDTO DeleteSalaryType(string ID)
        {
            MSalaryTypeEntity objMSalaryTypeEntity = imp.GetMSalaryTypeEntity(ID, YesNo.N);
            if (objMSalaryTypeEntity is MSalaryTypeEntity)
            {
                objMSalaryTypeEntity.ObsInd = YesNo.Y;
                objMSalaryTypeEntity.LastModifiedBy = provider.GetLoggedInUserId();
                objMSalaryTypeEntity.LastModifiedDate = DateTime.Now;
                try
                {
                    imp.BeginTransaction();
                    imp.SaveOrUpdateMSalaryTypeEntity(objMSalaryTypeEntity, true);
                    imp.CommitAndCloseSession();
                }
                catch (Exception ex)
                {
                    Logger.Error(ex);
                    return new ResultDTO() { IsSuccess = false, Message = ex.Message };
                }
            }
            return new ResultDTO();
        }

        public ResultDTO UpdateUnitsType(string Id, string UnitType)
        {
            MUnitsTypeEntity objMUnitsTypeEntity = imp.GetMUnitsTypeEntity(Id, YesNo.N);
            if (objMUnitsTypeEntity is MUnitsTypeEntity)
            {
                objMUnitsTypeEntity.UnitsType = UnitType;
                objMUnitsTypeEntity.LastModifiedBy = provider.GetLoggedInUserId();
                objMUnitsTypeEntity.LastModifiedDate = DateTime.Now;
                try
                {

                    imp.BeginTransaction();
                    imp.SaveOrUpdateMUnitsTypeEntity(objMUnitsTypeEntity, true);
                    imp.CommitAndCloseSession();
                }
                catch (Exception ex)
                {
                    Logger.Error(ex);
                    return new ResultDTO() { IsSuccess = false, Message = ex.Message };
                }
            }
            return new ResultDTO();
        }
        public ResultDTO UpdateGodownType(string ID, string GodownName)
        {
            MGodownDetailsEntity objMGodownDetailsEntity = imp.GetMGodownDetailsEntity(ID, YesNo.N);
            if (objMGodownDetailsEntity is MGodownDetailsEntity)
            {
                objMGodownDetailsEntity.Name = GodownName;
                objMGodownDetailsEntity.LastModifiedBy = provider.GetLoggedInUserId();
                objMGodownDetailsEntity.LastModifiedDate = DateTime.Now;
                try
                {

                    imp.BeginTransaction();
                    imp.SaveOrUpdateMGodownDetailsEntity(objMGodownDetailsEntity, true);
                    imp.CommitAndCloseSession();
                }
                catch (Exception ex)
                {
                    Logger.Error(ex);
                    return new ResultDTO() { IsSuccess = false, Message = ex.Message };
                }
            }
            return new ResultDTO();
        }
        public ResultDTO UpdateLotDetails(string ID, string LotName)
        {
            MLotDetailsEntity objMLotDetailsEntity = imp.GetMLotDetailsEntity(ID, YesNo.N);
            if (objMLotDetailsEntity is MLotDetailsEntity)
            {
                objMLotDetailsEntity.LotName = LotName;
                objMLotDetailsEntity.LastModifiedBy = provider.GetLoggedInUserId();
                objMLotDetailsEntity.LastModifiedDate = DateTime.Now;
                try
                {

                    imp.BeginTransaction();
                    imp.SaveOrUpdateMLotDetailsEntity(objMLotDetailsEntity, true);
                    imp.CommitAndCloseSession();
                }
                catch (Exception ex)
                {
                    Logger.Error(ex);
                    return new ResultDTO() { IsSuccess = false, Message = ex.Message };
                }
            }
            return new ResultDTO();
        }
        public ResultDTO UpdateBagType(string ID, string BagType)
        {
            MBagTypeEntity objMBagTypeEntity = imp.GetMBagTypeEntity(ID, YesNo.N);
            if (objMBagTypeEntity is MBagTypeEntity)
            {
                objMBagTypeEntity.BagType = BagType;
                objMBagTypeEntity.LastModifiedBy = provider.GetLoggedInUserId();
                objMBagTypeEntity.LastModifiedDate = DateTime.Now;
                try
                {

                    imp.BeginTransaction();
                    imp.SaveOrUpdateMBagTypeEntity(objMBagTypeEntity, true);
                    imp.CommitAndCloseSession();
                }
                catch (Exception ex)
                {
                    Logger.Error(ex);
                    return new ResultDTO() { IsSuccess = false, Message = ex.Message };
                }
            }
            return new ResultDTO();
        }
        public ResultDTO UpdateRiceType(string ID, string RiceType)
        {
            MRiceProductionTypeEntity objMRiceTypeEntity = imp.GetMRiceProductionTypeEntity(ID, YesNo.N);
            if (objMRiceTypeEntity is MRiceProductionTypeEntity)
            {
                objMRiceTypeEntity.RiceType= RiceType;
                objMRiceTypeEntity.LastModifiedBy = provider.GetLoggedInUserId();
                objMRiceTypeEntity.LastModifiedDate = DateTime.Now;
                try
                {

                    imp.BeginTransaction();
                    imp.SaveOrUpdateMRiceProductionTypeEntity(objMRiceTypeEntity, true);
                    imp.CommitAndCloseSession();
                }
                catch (Exception ex)
                {
                    Logger.Error(ex);
                    return new ResultDTO() { IsSuccess = false, Message = ex.Message };
                }
            }
            return new ResultDTO();
        }
        public ResultDTO UpdateBrokenRiceType(string ID, string BrokenRiceType)
        {
            MBrokenRiceTypeEntity objMBrokenRiceTypeEntity = imp.GetMBrokenRiceTypeEntity(ID, YesNo.N);
            if (objMBrokenRiceTypeEntity is MBrokenRiceTypeEntity)
            {
                objMBrokenRiceTypeEntity.BrokenRiceName = BrokenRiceType;
                objMBrokenRiceTypeEntity.LastModifiedBy = provider.GetLoggedInUserId();
                objMBrokenRiceTypeEntity.LastModifiedDate = DateTime.Now;
                try
                {

                    imp.BeginTransaction();
                    imp.SaveOrUpdateMBrokenRiceTypeEntity(objMBrokenRiceTypeEntity, true);
                    imp.CommitAndCloseSession();
                }
                catch (Exception ex)
                {
                    Logger.Error(ex);
                    return new ResultDTO() { IsSuccess = false, Message = ex.Message };
                }
            }
            return new ResultDTO();
        }
        public ResultDTO UpdateRiceBrandType(string ID, string RiceBrandType)
        {
            MRiceBrandDetailsEntity objMRiceBrandEntity = imp.GetMRiceBrandDetailsEntity(ID, YesNo.N);
            if (objMRiceBrandEntity is MRiceBrandDetailsEntity)
            {
                objMRiceBrandEntity.Name = RiceBrandType;
                objMRiceBrandEntity.LastModifiedBy = provider.GetLoggedInUserId();
                objMRiceBrandEntity.LastModifiedDate = DateTime.Now;
                try
                {

                    imp.BeginTransaction();
                    imp.SaveOrUpdateMRiceBrandDetailsEntity(objMRiceBrandEntity, true);
                    imp.CommitAndCloseSession();
                }
                catch (Exception ex)
                {
                    Logger.Error(ex);
                    return new ResultDTO() { IsSuccess = false, Message = ex.Message };
                }
            }
            return new ResultDTO();
        }
        public ResultDTO UpdateDesigType(string ID, string DesigType)
        {
            MEmployeeDesignationEntity objMEmpDesigEntity = imp.GetMEmployeeDesignationEntity(ID, YesNo.N);
            if (objMEmpDesigEntity is MEmployeeDesignationEntity)
            {
                objMEmpDesigEntity.DesignationType = DesigType;
                objMEmpDesigEntity.LastModifiedBy = provider.GetLoggedInUserId();
                objMEmpDesigEntity.LastModifiedDate = DateTime.Now;
                try
                {

                    imp.BeginTransaction();
                    imp.SaveOrUpdateMEmployeeDesignationEntity(objMEmpDesigEntity, true);
                    imp.CommitAndCloseSession();
                }
                catch (Exception ex)
                {
                    Logger.Error(ex);
                    return new ResultDTO() { IsSuccess = false, Message = ex.Message };
                }
            }
            return new ResultDTO();
        }
        public ResultDTO UpdateSalaryType(string ID, string SalaryType)
        {
            MSalaryTypeEntity objMSalaryTypeEntity = imp.GetMSalaryTypeEntity(ID, YesNo.N);
            if (objMSalaryTypeEntity is MSalaryTypeEntity)
            {
                objMSalaryTypeEntity.Salarytype = SalaryType;
                objMSalaryTypeEntity.LastModifiedBy = provider.GetLoggedInUserId();
                objMSalaryTypeEntity.LastModifiedDate = DateTime.Now;
                try
                {

                    imp.BeginTransaction();
                    imp.SaveOrUpdateMSalaryTypeEntity(objMSalaryTypeEntity, true);
                    imp.CommitAndCloseSession();
                }
                catch (Exception ex)
                {
                    Logger.Error(ex);
                    return new ResultDTO() { IsSuccess = false, Message = ex.Message };
                }
            }
            return new ResultDTO();
        }

        public List<MUnitsTypeDTO> GetMUnitsTypeEntities(int pageindex, int pageSize, out int count, SortExpression expression)
        {
            List<MUnitsTypeDTO> listUnitsTypeDTO = null;

            List<MUnitsTypeEntity> listMUnitsTypeEntity = imp.GetMUnitsTypeEntities(provider.GetCurrentCustomerId(), pageindex, pageSize, out count, expression, YesNo.N);
            if (listMUnitsTypeEntity != null && listMUnitsTypeEntity.Count > 0)
            {
                listUnitsTypeDTO = new List<MUnitsTypeDTO>();
                foreach (MUnitsTypeEntity objUnitsTypeEntity in listMUnitsTypeEntity)
                {
                    MUnitsTypeDTO objUnitsTypeDTO = new MUnitsTypeDTO();
                    objUnitsTypeDTO.UnitsType = objUnitsTypeEntity.UnitsType;
                    objUnitsTypeDTO.Indicator = GetYesorNo(objUnitsTypeEntity.ObsInd);
                    objUnitsTypeDTO.Id = objUnitsTypeEntity.UnitsTypeID;
                    listUnitsTypeDTO.Add(objUnitsTypeDTO);
                }
            }
            return listUnitsTypeDTO;
        }
        public List<GodownTypeDTO> GetMGodownTypeEntities(int PageIndex, int PageSize, out int count, SortExpression expression)
        {
            List<GodownTypeDTO> listGodownTypeDTO = null;

            List<MGodownDetailsEntity> listMGodownDetailsEntity = imp.GetMGodownDetailsEntities(provider.GetCurrentCustomerId(), PageIndex, PageSize, out count, expression, YesNo.N);
            if (listMGodownDetailsEntity != null && listMGodownDetailsEntity.Count > 0)
            {
                listGodownTypeDTO = new List<GodownTypeDTO>();
                foreach (MGodownDetailsEntity objGodwonTypeEntity in listMGodownDetailsEntity)
                {
                    GodownTypeDTO objUnitsTypeDTO = new GodownTypeDTO();
                    objUnitsTypeDTO.GodownType = objGodwonTypeEntity.Name;
                    objUnitsTypeDTO.Indicator = GetYesorNo(objGodwonTypeEntity.ObsInd);
                    objUnitsTypeDTO.Id = objGodwonTypeEntity.MGodownID;
                    listGodownTypeDTO.Add(objUnitsTypeDTO);
                }
            }
            return listGodownTypeDTO;
        }
        public List<LotDetailsDTO> GetMLotDetailsEntities(int PageIndex, int PageSize, out int count, SortExpression expression)
        {
            List<LotDetailsDTO> listLotDetailsDTO = null;

            List<MLotDetailsEntity> listMLotDetailsEntity = imp.GetMLotDetailsEntities(provider.GetCurrentCustomerId(), PageIndex, PageSize, out count, expression, YesNo.N);
            if (listMLotDetailsEntity != null && listMLotDetailsEntity.Count > 0)
            {
                listLotDetailsDTO = new List<LotDetailsDTO>();
                foreach (MLotDetailsEntity objLotTypeEntity in listMLotDetailsEntity)
                {
                    LotDetailsDTO objLotDetailsDTO = new LotDetailsDTO();
                    objLotDetailsDTO.LotDetails = objLotTypeEntity.LotName;
                    objLotDetailsDTO.Indicator = GetYesorNo(objLotTypeEntity.ObsInd);
                    objLotDetailsDTO.Id = objLotTypeEntity.MLotID;
                    listLotDetailsDTO.Add(objLotDetailsDTO);
                }
            }
            return listLotDetailsDTO;
        }
        public List<MBagTypeDTO> GetMBagTypeEntities(int PageIndex, int PageSize, out int count, SortExpression expression)
        {
            List<MBagTypeDTO> listBagTypeDTO = null;

            List<MBagTypeEntity> listMBagTypeEntity = imp.GetMBagTypeEntities(provider.GetCurrentCustomerId(), PageIndex, PageSize, out count, expression, YesNo.N);
            if (listMBagTypeEntity != null && listMBagTypeEntity.Count > 0)
            {
                listBagTypeDTO = new List<MBagTypeDTO>();
                foreach (MBagTypeEntity objBagTypeEntity in listMBagTypeEntity)
                {
                    MBagTypeDTO objBagTypeDTO = new MBagTypeDTO();
                    objBagTypeDTO.BagType= objBagTypeEntity.BagType;
                    objBagTypeDTO.Indicator = GetYesorNo(objBagTypeEntity.ObsInd);
                    objBagTypeDTO.Id = objBagTypeEntity.BagTypeID;
                    listBagTypeDTO.Add(objBagTypeDTO);
                }
            }
            return listBagTypeDTO;
        }
        public List<RiceTypeDTO> GetMRiceTypeEntities(int PageIndex, int PageSize, out int count, SortExpression expression)
        {
            List<RiceTypeDTO> listRiceTypeDTO = null;

            List<MRiceProductionTypeEntity> listMRiceTypeEntity = imp.GetMRiceProductionTypeEntities(provider.GetCurrentCustomerId(), PageIndex, PageSize, out count, expression, YesNo.N);
            if (listMRiceTypeEntity != null && listMRiceTypeEntity.Count > 0)
            {
                listRiceTypeDTO = new List<RiceTypeDTO>();
                foreach (MRiceProductionTypeEntity objRiceTypeEntity in listMRiceTypeEntity)
                {
                    RiceTypeDTO objRiceTypeDTO = new RiceTypeDTO();
                    objRiceTypeDTO.RiceType = objRiceTypeEntity.RiceType;
                    objRiceTypeDTO.Indicator = GetYesorNo(objRiceTypeEntity.ObsInd);
                    objRiceTypeDTO.Id = objRiceTypeEntity.MRiceProdTypeID;
                    listRiceTypeDTO.Add(objRiceTypeDTO);
                }
            }
            return listRiceTypeDTO;
        }
        public List<BrokenRiceTypeDTO> GetMBrokenRiceTypeEntities(int PageIndex, int PageSize, out int count, SortExpression expression)
        {
            List<BrokenRiceTypeDTO> listBrokenRiceTypeDTO = null;

            List<MBrokenRiceTypeEntity> listMBrokenRiceTypeEntity = imp.GetMBrokenRiceTypeEntitiies(provider.GetCurrentCustomerId(), PageIndex, PageSize, out count, expression, YesNo.N);
            if (listMBrokenRiceTypeEntity != null && listMBrokenRiceTypeEntity.Count > 0)
            {
                listBrokenRiceTypeDTO = new List<BrokenRiceTypeDTO>();
                foreach (MBrokenRiceTypeEntity objBrokenRiceTypeEntity in listMBrokenRiceTypeEntity)
                {
                    BrokenRiceTypeDTO objBrokenRiceTypeDTO = new BrokenRiceTypeDTO();
                    objBrokenRiceTypeDTO.BrokenRiceType = objBrokenRiceTypeEntity.BrokenRiceName;
                    objBrokenRiceTypeDTO.Indicator = GetYesorNo(objBrokenRiceTypeEntity.ObsInd);
                    objBrokenRiceTypeDTO.Id = objBrokenRiceTypeEntity.BrokenRiceTypeID;
                    listBrokenRiceTypeDTO.Add(objBrokenRiceTypeDTO);
                }
            }
            return listBrokenRiceTypeDTO;
        }
        public List<RiceBrandDTO> GetMRiceBrandTypeEntities(int PageIndex, int PageSize, out int count, SortExpression expression)
        {
            List<RiceBrandDTO> listRiceBrandDTO = null;

            List<MRiceBrandDetailsEntity> listMRiceBrandEntity = imp.GetMRiceBrandDetailsEntities(provider.GetCurrentCustomerId(), PageIndex, PageSize, out count, expression, YesNo.N);
            if (listMRiceBrandEntity != null && listMRiceBrandEntity.Count > 0)
            {
                listRiceBrandDTO = new List<RiceBrandDTO>();
                foreach (MRiceBrandDetailsEntity objRiceBrandEntity in listMRiceBrandEntity)
                {
                    RiceBrandDTO objRiceBrandDTO = new RiceBrandDTO();
                    objRiceBrandDTO.RiceBrand = objRiceBrandEntity.Name;
                    objRiceBrandDTO.Indicator = GetYesorNo(objRiceBrandEntity.ObsInd);
                    objRiceBrandDTO.Id = objRiceBrandEntity.MRiceBrandID;
                    listRiceBrandDTO.Add(objRiceBrandDTO);
                }
            }
            return listRiceBrandDTO;
        }
        public List<MEmpDesigDTO> GetMDesigTypeEntities(int PageIndex, int PageSize, out int count, SortExpression expression)
        {
            List<MEmpDesigDTO> listEmpDesigDTO = null;

            List<MEmployeeDesignationEntity> listMEmpDesigEntity = imp.GetMEmployeeDesignationEntities(provider.GetCurrentCustomerId(), PageIndex, PageSize, out count, expression, YesNo.N);
            if (listMEmpDesigEntity != null && listMEmpDesigEntity.Count > 0)
            {
                listEmpDesigDTO = new List<MEmpDesigDTO>();
                foreach (MEmployeeDesignationEntity objEmpDesigEntity in listMEmpDesigEntity)
                {
                    MEmpDesigDTO objEmpDesigDTO = new MEmpDesigDTO();
                    objEmpDesigDTO.DesignationType = objEmpDesigEntity.DesignationType;
                    objEmpDesigDTO.Indicator = GetYesorNo(objEmpDesigEntity.ObsInd);
                    objEmpDesigDTO.Id = objEmpDesigEntity.MEmpDsgID;
                    listEmpDesigDTO.Add(objEmpDesigDTO);
                }
            }
            return listEmpDesigDTO;
        }
        public List<MSalarytypeDTO> GetMSalaryTypeEntities(int PageIndex, int PageSize, out int count, SortExpression expression)
        {
            List<MSalarytypeDTO> listSalaryTypeDTO = null;

            List<MSalaryTypeEntity> listMSalaryTypeEntity = imp.GetListMSalaryTypeEntities(provider.GetCurrentCustomerId(), PageIndex, PageSize, out count, expression, YesNo.N);
            if (listMSalaryTypeEntity != null && listMSalaryTypeEntity.Count > 0)
            {
                listSalaryTypeDTO = new List<MSalarytypeDTO>();
                foreach (MSalaryTypeEntity objSalTypeEntity in listMSalaryTypeEntity)
                {
                    MSalarytypeDTO objMSalarytypeDTO = new MSalarytypeDTO();
                    objMSalarytypeDTO.SalaryType = objSalTypeEntity.Salarytype;
                    objMSalarytypeDTO.Indicator = GetYesorNo(objSalTypeEntity.ObsInd);
                    objMSalarytypeDTO.Id = objSalTypeEntity.MSalaryTypeID;
                    listSalaryTypeDTO.Add(objMSalarytypeDTO);
                }
            }
            return listSalaryTypeDTO;
        }
    }
}
