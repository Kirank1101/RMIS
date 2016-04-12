using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RMIS.Domain.RiceMill;
using RMIS.Binder.BackEnd;
using RMIS.Domain.Mediator;

namespace RMIS.Business
{
  
    
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
