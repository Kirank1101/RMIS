using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RMIS.Domain.RiceMill;

using RMIS.Domain.Mediator;
using RMIS.Domain.Business;

namespace RMIS.Business
{
    public class HttpSessionUserProvider : ICustomerProvider
    {   

        public string GetCurrentCustomerId()
        {
            return string.Empty;
        }
    }

    public class PaddyBusiness : IPaddyBusiness
    {
        string custId = string.Empty;
        IRMISMediator imp;
        public PaddyBusiness(IRMISMediator imp,ICustomerProvider provider)
        {
            this.custId = provider.GetCurrentCustomerId();
            this.imp = imp;
        }

        public List<SellerTypeEntity> GetMasterSellerTypeEntities()
        {
            
           // imp.GetSellerTypeEntity(
            return imp.GetSellerTypeEntities(custId);
        }

        public void SaveSellerType(SellerTypeEntity objSellerTypeEntity)
        {
            
            imp.SaveOrUpdateSellerTypeEntity(objSellerTypeEntity, false);
        }

    }
}
