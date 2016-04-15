using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RMIS.Domain.RiceMill;

namespace RMIS.Domain.Business
{
    public interface IPaddyBusiness
    {
        List<SellerTypeEntity> GetMasterSellerTypeEntities();
        void SaveSellerType(SellerTypeEntity objSellerTypeEntity);
    }
}
