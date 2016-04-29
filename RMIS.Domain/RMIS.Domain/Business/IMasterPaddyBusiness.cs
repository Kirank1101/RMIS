using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RMIS.Domain.RiceMill;
using RMIS.Domain.DataTranserClass;

namespace RMIS.Domain.Business
{
    public interface IMasterPaddyBusiness
    {
        List<SellerTypeDTO> GetMasterSellerTypeEntities();
        List<MUserTypeEntity> GetMUserTypeEntities();
        List<PaddyTypeDTO> GetMPaddyTypeEntities();
        List<GodownTypeDTO> GetMGodownTypeEntities();
        List<RiceBrandDTO> GetRiceBrandEntities();
        List<RiceProductDTO> GetRiceProductEntities();
        List<LotDetailsDTO> GetLotDetailsEntities(string godownId);
        List<PaddyStockInfoEntity> GetPaddyStockInfoEntities();
        List<WeightDetailsDTO> GetMWeightDetailsEntities();
        ResultDTO SaveSellerType(string sellerType);
        ResultDTO SavePaddyType(string paddyType);
        ResultDTO SaveGodownType(string godownType);
        ResultDTO SaveRiceBrandType(string riceBrand);
        ResultDTO SaveRiceProductType(string riceProduct);
        ResultDTO SaveLotDetails(string lotName,string godownId);
        ResultDTO SaveWeightDetails(string weight);
    }
}
