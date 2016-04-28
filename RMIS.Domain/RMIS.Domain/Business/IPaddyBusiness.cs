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
        List<PaddyTypeDTO> GetMPaddyTypeEntities();
        List<GodownTypeDTO> GetMGodownTypeeEntities();
        List<PaddyStockInfoEntity> GetPaddyStockInfoEntities();
        List<MWeightDetailsEntity> GetMWeightDetailsEntities();
        ResultDTO SaveSellerType(string sellerType);
        ResultDTO SavePaddyType(string paddyType);
        ResultDTO SaveGodownType(string godownType);
    }
}
