using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RMIS.Domain.RiceMill;
using RMIS.Domain.DataTranserClass;
using RMIS.Domain.Constant;

namespace RMIS.Domain.Business
{
    public interface IMasterPaddyBusiness
    {
        bool CheckUnitTypeExist(string UnitType);
        bool CheckPaddyTypeExist(string PaddyType);
        bool CheckGodownNameExist(string GodownName);
        bool CheckLotNameExist(string LotName);
        bool CheckEmpDesigExist(string DesignationType);
        bool CheckSalaryTypeExist(string SalaryType);

        List<MBagTypeDTO> GetMBagTypeEntities();
        List<MUnitsTypeDTO> GetMUnitsTypeEntities();
        List<MUserTypeEntity> GetMUserTypeEntities();
        List<PaddyTypeDTO> GetMPaddyTypeEntities();
        List<PaddyTypeDTO> GetMPaddyTypeEntities(int pageindex, int pageSize, out int count, SortExpression expression);
        List<MUnitsTypeDTO> GetMUnitsTypeEntities(int pageindex, int pageSize, out int count, SortExpression expression);
        List<BrokenRiceTypeDTO> GetMBrokenRiceTypeEntities();
        List<GodownTypeDTO> GetMGodownTypeEntities();
        List<RiceBrandDTO> GetRiceBrandEntities();
        List<RiceProductDTO> GetRiceProductEntities();
        List<LotDetailsDTO> GetLotDetailsEntities(string godownId);
        List<PaddyStockInfoEntity> GetPaddyStockInfoEntities();
        List<WeightDetailsDTO> GetMWeightDetailsEntities();
        List<ProductSellingTypeDTO> GetMProductSellingTypeEntities();
        List<MEmpDesigDTO> GetMEmpDesigTypeEntities();
        List<MSalarytypeDTO> GetMSalaryTypeEntities();
        
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
        List<MRolesEntity> GetAllRolesEntities();
        ResultDTO SaveRoleEntity(string roleName);
        ResultDTO DeletePaddyType(string Id);
        ResultDTO UpdatePaddyType(string Id, string paddyType);
        ResultDTO SaveEmpDesigType(string DesignationType);
        ResultDTO SaveSalaryType(string SalaryType); 
        string GetEmployeeDesignation(string DesignationID);
        string GetSalaryType(string SalaryTypeId);

        ResultDTO DeleteUnitsType(string Id);
        ResultDTO UpdateUnitsType(string Id, string UnitType);

    }
}
