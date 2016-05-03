using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RMIS.Domain.DataTranserClass;

namespace RMIS.Domain.Business
{
   public  interface IValidateMasterBusiness
    {
        ResultDTO ValidateSellerType(string sellerType);
        ResultDTO ValidateBagType(string BagType);
        ResultDTO ValidateUnitsType(string UnitsType);
        ResultDTO ValiadtePaddyType(string paddyType);
        ResultDTO ValidateGodownType(string godownType);
        ResultDTO ValidateRiceBrandType(string riceBrand);
        ResultDTO ValidateRiceProductType(string riceProduct);
        ResultDTO ValidateLotDetails(string lotName, string godownId);
        ResultDTO ValidateWeightDetails(string weight);
    }
}
