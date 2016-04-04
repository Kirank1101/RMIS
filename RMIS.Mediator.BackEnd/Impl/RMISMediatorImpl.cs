
namespace RMIS.Mediator.BackEnd.Impl
{
    using System;

    using AllInOne.Common.DataAccess.NHibernate.NHibernateSessionManagement;
    using RMIS.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper;
    
    using RMIS.Entities.BackEnd;
    using RMIS.Mediator.BackEnd.Data;

    using log4net;
    
    using System.Collections.Generic;
    
    using RMIS.Entities.BackEnd;
    using RMIS.Domain.RiceMill;
    using RMIS.Entities.BackEnd;

    public class RMISMediatorImpl : IRMISMediator
    {
        public IRMISMapper mapper;
        public RMISMediatorImpl(IRMISMapper mapper)
        {
            this.mapper = mapper;
        }

        #region Fields

        private static readonly ILog Logger = LogManager.GetLogger(typeof(RMISMediatorImpl));

        /// </summary>
        private ApplicationSessionManager applicationSessionManager = new ApplicationSessionManager();

        #endregion Fields

        #region Methods

        /// <summary>
        /// Opens a session within a transaction at the beginning.  Note that
        /// it ONLY begins transactions for those designated as being transactional i.e. isTransactional="true" in web.config.
        /// </summary>
        /// <param name="sender"></param>
        public void BeginTransaction()
        {
            Logger.Info("AuditMediatorImpl - BeginTransaction started at " + DateTime.Now.ToString());

            this.applicationSessionManager.BeginTransaction();

            Logger.Info("AuditMediatorImpl - BeginTransaction ended at " + DateTime.Now.ToString());
        }

        /// <summary>
        /// Method to Close the session.
        /// </summary>
        public void CloseSession()
        {
            Logger.Info("AuditMediatorImpl - CloseSession started at " + DateTime.Now.ToString());

            this.applicationSessionManager.CloseSession();

            Logger.Info("AuditMediatorImpl - CloseSession ended at " + DateTime.Now.ToString());
        }

        /// <summary>
        /// Method to Commit and Close the session.
        /// If exception occurs, rollback will be handled automatically.
        /// </summary>
        public void CommitAndCloseSession()
        {
            Logger.Info("AuditMediatorImpl - CommitAndCloseSession started at " + DateTime.Now.ToString());

            this.applicationSessionManager.CommitAndCloseSession();

            Logger.Info("AuditMediatorImpl - CommitAndCloseSession ended at " + DateTime.Now.ToString());
        }

        /// <summary>
        /// Saves the or update audit entity.
        /// </summary>
        /// <param name="auditEntity">The audit entity.</param>
        /// <param name="isCopy">if set to <c>true</c> [is copy].</param>
        public void SaveOrUpdateSellerTypeEntity(SellerTypeEntity sellertypeEntity, bool isCopy)
        {
            try
            {
                GenericGateway genericGateway = new GenericGateway();
                genericGateway.SaveOrUpdateEntity<MSellerType>(mapper.GetSellerType(sellertypeEntity), isCopy);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at SaveOrUpdateSellerTypeEntity", ex);
                Logger.Error("Error in SaveOrUpdateSellerTypeEntity: Message - " + ex.Message + " StackTrace - " + ex.StackTrace);
                throw;
            }
        }

        public void SaveOrUpdateSellerInfoEntity(SellerInfoEntity sellerInfoEntity, bool isCopy)
        {
            try
            {
                GenericGateway genericGateway = new GenericGateway();
                genericGateway.SaveOrUpdateEntity<SellerInfo>(mapper.GetSellerInfo(sellerInfoEntity), isCopy);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at SaveOrUpdateSellerInfoEntity", ex);
                Logger.Error("Error in SaveOrUpdateSellerInfoEntity: Message - " + ex.Message + " StackTrace - " + ex.StackTrace);
                throw;
            }
        }


        /// <summary>
        /// Gets all audit module visit.
        /// </summary>
        /// <returns></returns>
        public SellerTypeEntity GetSellerTypeEntity(string SellerTypeID)
        {
            RMISGateway auditGateway = new RMISGateway();
            return auditGateway.GetSellerTypeEntity(SellerTypeID);
        }
        public SellerInfoEntity GetSellerInfoEntity(string SellerID)
        {
            RMISGateway auditGateway = new RMISGateway();
            return auditGateway.GetSellerInfoEntity(SellerID);
        }
        #endregion


    }
}
