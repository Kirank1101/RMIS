namespace RMIS.Mediator.BackEnd.Data
{

    using AllInOne.Common.DataAccess.NHibernate.NHibernateSessionManagement;
    using AllInOne.Common.DataAccess.Utilities;
    using System;
    using NHibernate;
    using log4net;
    using System.Collections.Generic;
    
    using NHibernate.Criterion;
    using RMIS.Entities.BackEnd;
    using RMIS.Repositories.BackEnd;
    using System.Linq;
    
    
    using RMIS.Domain.RiceMill;
    using RMIS.Entities.BackEnd;



    internal class RMISGateway
    {
        #region Fields

        private ISession applicationSession;

        private static readonly ILog Logger = LogManager.GetLogger(typeof(RMISGateway));

        #endregion Fields

        #region Constructors

        internal RMISGateway()
        {
            var applicationSessionManager = new ApplicationSessionManager(DataBaseConnectivity.Application);
            applicationSession = applicationSessionManager.Session;
        }

        #endregion Constructors

        #region Methods


        #endregion Methods

        internal SellerTypeEntity GetSellerTypeEntity(string SellerTypeID)
        {
            try
            {
                SellerTypeEntity sellerTypeEntity = new SellerTypeEntity();
                IRepository<MSellerType> SellerTypeRepository = new RepositoryImpl<MSellerType>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(MSellerType))
                                                                   .Add(Expression.Eq("SellerTypeID", SellerTypeID));
                List<MSellerType> listSellerType = SellerTypeRepository.GetAll(detachedCriteria) as List<MSellerType>;
                if (listSellerType != null && listSellerType.Count > 0)
                {
                    foreach (MSellerType adMInfo in listSellerType)
                    {
                        sellerTypeEntity = RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetSellerTypeEntity(adMInfo);
                    }
                }
                else
                    sellerTypeEntity = null;

                return sellerTypeEntity;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetSellerInfoEntity", ex);
                throw;
            }
        }

        private List<T> GetAllFromRepository<T>()
        {
            IRepository<T> repository = new RepositoryImpl<T>(applicationSession);
            return repository.GetAll() as List<T>;
        }
    }
}