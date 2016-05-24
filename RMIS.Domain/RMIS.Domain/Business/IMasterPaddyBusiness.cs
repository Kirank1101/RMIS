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
        List<MBagTypeDTO> GetMBagTypeEntities();
        List<MUnitsTypeDTO> GetMUnitsTypeEntities();
        List<MUserTypeEntity> GetMUserTypeEntities();
        List<PaddyTypeDTO> GetMPaddyTypeEntities();
        List<BrokenRiceTypeDTO> GetMBrokenRiceTypeEntities();
        List<GodownTypeDTO> GetMGodownTypeEntities();
        List<RiceBrandDTO> GetRiceBrandEntities();
        List<RiceProductDTO> GetRiceProductEntities();
        List<LotDetailsDTO> GetLotDetailsEntities(string godownId);
        List<PaddyStockInfoEntity> GetPaddyStockInfoEntities();
        List<WeightDetailsDTO> GetMWeightDetailsEntities();
        List<ProductSellingTypeDTO> GetMProductSellingTypeEntities();
        ResultDTO SaveSellerType(string sellerType);
        ResultDTO SaveBagType(string BagType);
        ResultDTO SaveUnitsType(string UnitsType);
        ResultDTO SavePaddyType(string paddyType);
        ResultDTO SaveBrokenRiceType(string BrokenRiceType);
        ResultDTO SaveGodownType(string godownType);
        ResultDTO SaveRiceBrandType(string riceBrand);
        ResultDTO SaveRiceProductType(string riceProduct);
        ResultDTO SaveLotDetails(string lotName,string godownId);
        ResultDTO SaveWeightDetails(string weight);
        List<MenuInfoEntity> GetMenuInfoEnity();
        ResultDTO SaveProductSellingType(string productSellingType);        

    }
}
