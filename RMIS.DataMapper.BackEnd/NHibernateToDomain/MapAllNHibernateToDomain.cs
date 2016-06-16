namespace RMIS.DataMapper.BackEnd.NHibernateToDomain
{
    using System;

    using RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapping;

    using log4net;

    /// <summary>
    /// Class implementing call to all the Map methods, mapping NHibernate entities to Domain objects.
    /// </summary>
    public class MapAllNHibernateToDomain
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(MapAllNHibernateToDomain));


        // HospitalMapping hospitalMapping=null ;
        RMISMappingNTD objRMISMappingNTD = null;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MapAllNHibernateToDomain"/> class.
        /// </summary>
        /// <remarks>Initializes all the mapping.</remarks>
        public MapAllNHibernateToDomain()
        {
            // hospitalMapping = new HospitalMapping();
            objRMISMappingNTD = new RMISMappingNTD();

        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Method which calls to all the Map methods, mapping Domain objects to NHibernate entities. 
        /// </summary>
        public void MapAll()
        {
            Logger.Debug("Initialised MapAll");
            try
            {
                objRMISMappingNTD.MapSellerInfoEntity();
                objRMISMappingNTD.MapCustomerInfoEntity();
                objRMISMappingNTD.MapMUserTypeEntity();
                objRMISMappingNTD.MapUsersEntity();
                objRMISMappingNTD.MapMPaddyTypeEntity();
                objRMISMappingNTD.MapPaddyStockInfoEntity();
                objRMISMappingNTD.MapMLotDetailsEntity();
                objRMISMappingNTD.MapMGodownDetailsEntity();
                objRMISMappingNTD.MapCustomerAddressInfoEntity();
                objRMISMappingNTD.MapCustomerActivationEntity();
                objRMISMappingNTD.MapCustTrailUsageEntity();
                objRMISMappingNTD.MapCustomerPaymentEntity();
                objRMISMappingNTD.MapCustomerPartPayDetailsEntity();
                objRMISMappingNTD.MapMDrierTypeDetailsEntity();
                objRMISMappingNTD.MapMRiceProductionTypeEntity();
                objRMISMappingNTD.MapMRiceBrandDetailsEntity();
                objRMISMappingNTD.MapMUnitsTypeEntity();
                objRMISMappingNTD.MapMBagTypeEntity();
                objRMISMappingNTD.MapBagStockInfoEntity();
                objRMISMappingNTD.MapMBrokenRiceTypeEntity();
                objRMISMappingNTD.MapRiceStockInfoEntity();
                objRMISMappingNTD.MapBrokenRiceStockInfoEntity();
                objRMISMappingNTD.MapDustStockInfoEntity();
                objRMISMappingNTD.MapMenuInfoToMenuInfoEntity();
                objRMISMappingNTD.MapMenuConfigurationToMenuConfigurationEntity();
                objRMISMappingNTD.MapProductSellingInfoEntity();
                objRMISMappingNTD.MapHullingProcessInfoEntity();
                objRMISMappingNTD.MapHullingProcessTransInfoEntity();
                objRMISMappingNTD.MapMRolesToMRolesEntity();
                objRMISMappingNTD.MapRMUserRoleToRMUserRoleEntity();
                objRMISMappingNTD.MapHullingProcessExpensesInfoEntity();
                objRMISMappingNTD.MapBuyerSellerRatingEntity();
                objRMISMappingNTD.MapBuyerInfoEntity();
                objRMISMappingNTD.MapMEmployeeDesignationEntity();
                objRMISMappingNTD.MapMSalaryTypeEntity();
                objRMISMappingNTD.MapEmployeeDetailsEntity();
                objRMISMappingNTD.MapEmployeeSalaryEntity();
                objRMISMappingNTD.MapEmployeeSalaryPaymentEntity();
                objRMISMappingNTD.MapOtherExpensesEntity();
                objRMISMappingNTD.MapProductPaymentInfoEntity();
                objRMISMappingNTD.MapProductPaymentTranEntity();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at NHibernateToDomain>> Mapping >> MapAll", ex);
                throw;
            }
        }

        #endregion Methods
    }
}