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
        List<BrokenRiceTypeDTO> GetMBrokenRiceTypeEntities();
        List<GodownTypeDTO> GetMGodownTypeEntities();
        List<RiceBrandDTO> GetRiceBrandEntities();
        List<RiceTypeDTO> GetRiceProductEntities();
        List<LotDetailsDTO> GetLotDetailsEntities(string godownId);
        List<PaddyStockInfoEntity> GetPaddyStockInfoEntities();
        List<MEmpDesigDTO> GetMEmpDesigTypeEntities();
        List<MSalarytypeDTO> GetMSalaryTypeEntities();

        ResultDTO SaveBagType(string BagType);
        ResultDTO SaveUnitsType(string UnitsType);
        ResultDTO SavePaddyType(string paddyType);
        ResultDTO SaveBrokenRiceType(string BrokenRiceType);
        ResultDTO SaveGodownType(string godownType);
        ResultDTO SaveRiceBrandType(string riceBrand);
        ResultDTO SaveRiceProductType(string riceProduct);
        ResultDTO SaveLotDetails(string lotName, string godownId);
        List<MenuInfoEntity> GetMenuInfoEnity();
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
        List<MUnitsTypeDTO> GetMUnitsTypeEntities(int pageindex, int pageSize, out int count, SortExpression expression);

        ResultDTO DeleteGodownType(string ID);
        ResultDTO UpdateGodownType(string ID, string GodownName);
        List<GodownTypeDTO> GetMGodownTypeEntities(int PageIndex, int PageSize, out int count, SortExpression expression);

        ResultDTO DeleteLotDetails(string ID);
        ResultDTO UpdateLotDetails(string ID, string LotName);
        List<LotDetailsDTO> GetMLotDetailsEntities(int PageIndex, int PageSize, out int count, SortExpression expression);

        ResultDTO DeleteBagType(string ID);
        ResultDTO UpdateBagType(string ID, string BagType);
        List<MBagTypeDTO> GetMBagTypeEntities(int PageIndex, int PageSize, out int count, SortExpression expression);

        ResultDTO DeleteRiceType(string ID);
        ResultDTO UpdateRiceType(string ID, string RiceType);
        List<RiceTypeDTO> GetMRiceTypeEntities(int PageIndex, int PageSize, out int count, SortExpression expression);

        ResultDTO DeleteBrokenRiceType(string ID);
        ResultDTO UpdateBrokenRiceType(string ID, string BrokenRiceType);
        List<BrokenRiceTypeDTO> GetMBrokenRiceTypeEntities(int PageIndex, int PageSize, out int count, SortExpression expression);


        ResultDTO DeleteRiceBrandType(string ID);
        ResultDTO UpdateRiceBrandType(string ID, string RiceBrandType);
        List<RiceBrandDTO> GetMRiceBrandTypeEntities(int PageIndex, int PageSize, out int count, SortExpression expression);



        ResultDTO DeleteDesigType(string ID);
        ResultDTO UpdateDesigType(string ID, string DesigType);
        List<MEmpDesigDTO> GetMDesigTypeEntities(int PageIndex, int PageSize, out int count, SortExpression expression);

        ResultDTO DeleteSalaryType(string ID);
        ResultDTO UpdateSalaryType(string ID, string SalaryType);
        List<MSalarytypeDTO> GetMSalaryTypeEntities(int PageIndex, int PageSize, out int count, SortExpression expression);
    }
}
