using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RMIS.Domain.RiceMill;
using RMIS.Mediator.BackEnd;
using RMIS.Binder.BackEnd;

namespace RMIS.Business
{
    public  class PaddyBusiness
    {

        public List<SellerTypeEntity> GetMasterSellerTypeEntities(string custId)
        {
            IRMISMediator imp = BinderSingleton.Instance.GetInstance<IRMISMediator>();
           // imp.GetSellerTypeEntity(
            return imp.GetSellerTypeEntities(custId);
        }

    }
}
