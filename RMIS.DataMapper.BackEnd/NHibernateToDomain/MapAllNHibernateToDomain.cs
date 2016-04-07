﻿namespace RMIS.DataMapper.BackEnd.NHibernateToDomain
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
                objRMISMappingNTD.MapSellerTypeEntity();
                objRMISMappingNTD.MapSellerInfoEntity();
                objRMISMappingNTD.MapCustomerInfoEntity();
                objRMISMappingNTD.MapMUserTypeEntity();
                objRMISMappingNTD.MapUsersEntity();
                objRMISMappingNTD.MapMPaddyTypeEntity();
                objRMISMappingNTD.MapPaddyStockInfoEntity();
                objRMISMappingNTD.MapMLotDetailsEntity();
                objRMISMappingNTD.MapMGodownDetailsEntity();
                objRMISMappingNTD.MapMWeightDetailsEntity();
                objRMISMappingNTD.MapCustomerAddressInfoEntity();
                objRMISMappingNTD.MapCustomerActivationEntity();
                objRMISMappingNTD.MapCustTrailUsageEntity();
                objRMISMappingNTD.MapCustomerPaymentEntity();
                objRMISMappingNTD.MapCustomerPartPayDetailsEntity();
                objRMISMappingNTD.MapMDrierTypeDetailsEntity();
                objRMISMappingNTD.MapMRiceProductionTypeEntity();
                objRMISMappingNTD.MapMRiceBrandDetailsEntity();
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