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

namespace RMIS.Business
{

    public class PaddyBusiness : IPaddyBusiness
    {
       
        IRMISMediator imp;
        ISessionProvider provider;
        public PaddyBusiness(IRMISMediator imp, ISessionProvider provider)
        {
            this.provider = provider;
            this.imp = imp;
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
                    objSellerTypeDTO.Indicator = Enum.GetName(typeof(YesNo), objSellerTypeEntity.ObsInd);
                    listSellerTypeDTO.Add(objSellerTypeDTO);
                }

            }
            return listSellerTypeDTO;
        }
        public List<MUserTypeEntity> GetMUserTypeEntities()
        {
            return imp.GetMUserTypeEntities(provider.GetCurrentCustomerId());
        }
        public void SaveSellerType(string sellerType)
        {
            SellerTypeEntity objSellerTypeEntity = new SellerTypeEntity();
            objSellerTypeEntity.ObsInd = YesNo.N;
            objSellerTypeEntity.CustID = provider.GetCurrentCustomerId();
            objSellerTypeEntity.LastModifiedBy = provider.GetLoggedInUserId();
            objSellerTypeEntity.SellerType = sellerType;
            objSellerTypeEntity.SellerTypeID = CommonUtil.CreateUniqueID("ST");
            objSellerTypeEntity.LastModifiedDate = DateTime.Now;
            imp.BeginTransaction();
            imp.SaveOrUpdateSellerTypeEntity(objSellerTypeEntity, false);
            imp.CommitAndCloseSession();
        }


        public List<MPaddyTypeEntity> GetMPaddyTypeEntities()
        {
            return imp.GetMPaddyTypeEntitiies(provider.GetCurrentCustomerId());
        }


        public List<PaddyStockInfoEntity> GetPaddyStockInfoEntities()
        {
            return imp.GetPaddyStockInfoEntities(provider.GetCurrentCustomerId());
        }


        public List<MWeightDetailsEntity> GetMWeightDetailsEntities()
        {
            return imp.GetMWeightDetailsEntities(provider.GetCurrentCustomerId());
        }
    }
}
