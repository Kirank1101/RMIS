using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RMIS.Domain.RiceMill;
using RMIS.Mediator.BackEnd;
using RMIS.Binder.BackEnd;

namespace RMIS.Business
{
    interface IPaddyBusiness
    {
        List<SellerTypeEntity> GetMasterSellerTypeEntities();
        void SaveSellerType(SellerTypeEntity objSellerTypeEntity);
    }
    
    public  class PaddyBusiness
    {
        string custId = string.Empty;
        public PaddyBusiness(string custId)
        {
            this.custId = custId;
        }

        public List<SellerTypeEntity> GetMasterSellerTypeEntities()
        {
            IRMISMediator imp = BinderSingleton.Instance.GetInstance<IRMISMediator>();
           // imp.GetSellerTypeEntity(
            return imp.GetSellerTypeEntities(custId);
        }

        public void SaveSellerType(SellerTypeEntity objSellerTypeEntity)
        {
            IRMISMediator imp = BinderSingleton.Instance.GetInstance<IRMISMediator>();
            imp.SaveOrUpdateSellerTypeEntity(objSellerTypeEntity, false);
        }

    }
}
