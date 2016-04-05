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

        internal SellerInfoEntity GetSellerInfoEntity(string SellerID)
        {
            try
            {
                SellerInfoEntity sellerInfoEntity = new SellerInfoEntity();
                IRepository<SellerInfo> SellerInfoRepository = new RepositoryImpl<SellerInfo>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(SellerInfo))
                                                                   .Add(Expression.Eq("SellerID", SellerID));
                List<SellerInfo> listSellerInfoEntity = SellerInfoRepository.GetAll(detachedCriteria) as List<SellerInfo>;
                if (listSellerInfoEntity != null && listSellerInfoEntity.Count > 0)
                {
                    foreach (SellerInfo adMInfo in listSellerInfoEntity)
                    {
                        sellerInfoEntity = RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetSellerInfoEntity(adMInfo);
                    }
                }
                else
                    sellerInfoEntity = null;

                return sellerInfoEntity;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetSellerInfoEntity", ex);
                throw;
            }
        }

        internal CustomerInfoEntity GetCustomerInfoEntity(string CustID)
        {
            try
            {
                CustomerInfoEntity customerInfoEntity = new CustomerInfoEntity();
                IRepository<CustomerInfo> CustomerInfoRepository = new RepositoryImpl<CustomerInfo>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(CustomerInfo))
                                                                   .Add(Expression.Eq("CustID", CustID));
                List<CustomerInfo> listCustomerInfoEntity = CustomerInfoRepository.GetAll(detachedCriteria) as List<CustomerInfo>;
                if (listCustomerInfoEntity != null && listCustomerInfoEntity.Count > 0)
                {
                    foreach (CustomerInfo adMInfo in listCustomerInfoEntity)
                    {
                        customerInfoEntity = RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetCustomerInfoEntity(adMInfo);
                    }
                }
                else
                    customerInfoEntity = null;

                return customerInfoEntity;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetCustomerInfoEntity", ex);
                throw;
            }
        }

        internal MUserTypeEntity GetMUserTypeEntity(string UserTypeID)
        {
            try
            {
                MUserTypeEntity mUserTypeEntity = new MUserTypeEntity();
                IRepository<MUserType> MUserTypeRepository = new RepositoryImpl<MUserType>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(MUserType))
                                                                   .Add(Expression.Eq("UserTypeID", UserTypeID));
                List<MUserType> listMUserTypeEntity = MUserTypeRepository.GetAll(detachedCriteria) as List<MUserType>;
                if (listMUserTypeEntity != null && listMUserTypeEntity.Count > 0)
                {
                    foreach (MUserType adMInfo in listMUserTypeEntity)
                    {
                        mUserTypeEntity = RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetMUserTypeEntity(adMInfo);
                    }
                }
                else
                    mUserTypeEntity = null;

                return mUserTypeEntity;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMUserTypeEntity", ex);
                throw;
            }
        }

        internal UsersEntity GetUsersEntity(string UserID)
        {
            try
            {
                UsersEntity usersEntity = new UsersEntity();
                IRepository<Users> UsersRepository = new RepositoryImpl<Users>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(Users))
                                                                   .Add(Expression.Eq("UserID", UserID));
                List<Users> listUsersEntity = UsersRepository.GetAll(detachedCriteria) as List<Users>;
                if (listUsersEntity != null && listUsersEntity.Count > 0)
                {
                    foreach (Users adMInfo in listUsersEntity)
                    {
                        usersEntity = RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetUsersEntity(adMInfo);
                    }
                }
                else
                    usersEntity = null;

                return usersEntity;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetUsersEntity", ex);
                throw;
            }
        }
        internal MPaddyTypeEntity GetMPaddyTypeEntity(string PaddyTypeID)
        {
            try
            {
                MPaddyTypeEntity mPaddyTypeEntity = new MPaddyTypeEntity();
                IRepository<MPaddyType> UsersRepository = new RepositoryImpl<MPaddyType>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(MPaddyType))
                                                                   .Add(Expression.Eq("PaddyTypeID", PaddyTypeID));
                List<MPaddyType> listMPaddyTypeEntity = UsersRepository.GetAll(detachedCriteria) as List<MPaddyType>;
                if (listMPaddyTypeEntity != null && listMPaddyTypeEntity.Count > 0)
                {
                    foreach (MPaddyType adMInfo in listMPaddyTypeEntity)
                    {
                        mPaddyTypeEntity = RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetMPaddyTypeEntity(adMInfo);
                    }
                }
                else
                    mPaddyTypeEntity = null;

                return mPaddyTypeEntity;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMPaddyTypeEntity", ex);
                throw;
            }
        }
        internal PaddyStockInfoEntity GetPaddyStockInfoEntity(string PaddyStockID)
        {
            try
            {
                PaddyStockInfoEntity paddyStockInfoEntity = new PaddyStockInfoEntity();
                IRepository<PaddyStockInfo> UsersRepository = new RepositoryImpl<PaddyStockInfo>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(PaddyStockInfo))
                                                                   .Add(Expression.Eq("PaddyStockID", PaddyStockID));
                List<PaddyStockInfo> listPaddyStockInfoEntity = UsersRepository.GetAll(detachedCriteria) as List<PaddyStockInfo>;
                if (listPaddyStockInfoEntity != null && listPaddyStockInfoEntity.Count > 0)
                {
                    foreach (PaddyStockInfo adMInfo in listPaddyStockInfoEntity)
                    {
                        paddyStockInfoEntity = RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetPaddyStockInfoEntity(adMInfo);
                    }
                }
                else
                    paddyStockInfoEntity = null;

                return paddyStockInfoEntity;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetPaddyStockInfoEntity", ex);
                throw;
            }
        }
        internal MLotDetailsEntity GetMLotDetailsEntity(string MLotID)
        {
            try
            {
                MLotDetailsEntity mLotDetailsEntity = new MLotDetailsEntity();
                IRepository<MLotDetails> UsersRepository = new RepositoryImpl<MLotDetails>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(MLotDetails))
                                                                   .Add(Expression.Eq("MLotID", MLotID));
                List<MLotDetails> listMLotDetailsEntity = UsersRepository.GetAll(detachedCriteria) as List<MLotDetails>;
                if (listMLotDetailsEntity != null && listMLotDetailsEntity.Count > 0)
                {
                    foreach (MLotDetails adMInfo in listMLotDetailsEntity)
                    {
                        mLotDetailsEntity = RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetMLotDetailsEntity(adMInfo);
                    }
                }
                else
                    mLotDetailsEntity = null;

                return mLotDetailsEntity;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMLotDetailsEntity", ex);
                throw;
            }
        }

        #endregion Methods
        private List<T> GetAllFromRepository<T>()
        {
            IRepository<T> repository = new RepositoryImpl<T>(applicationSession);
            return repository.GetAll() as List<T>;
        }
    }
}