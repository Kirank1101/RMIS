using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RMIS.Domain.RiceMill;
using RMIS.Domain.DataTranserClass;

namespace RMIS.Domain.Business
{
    public interface IPaddyBusiness
    {
        List<SellerTypeDTO> GetMasterSellerTypeEntities();
        List<MUserTypeEntity> GetMUserTypeEntities();
        List<MPaddyTypeEntity> GetMPaddyTypeEntities();
        List<PaddyStockInfoEntity> GetPaddyStockInfoEntities();
        List<MWeightDetailsEntity> GetMWeightDetailsEntities();
        void SaveSellerType(string  sellerType);
    }
}
