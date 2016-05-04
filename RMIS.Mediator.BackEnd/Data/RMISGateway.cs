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

        internal List<SellerTypeEntity> GetSellerTypeEntities(string custId)
        {
            try
            {
                List<SellerTypeEntity> ListsellerTypeEntity = new List<SellerTypeEntity>();
                IRepository<MSellerType> SellerTypeRepository = new RepositoryImpl<MSellerType>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(MSellerType))
                                                                   .Add(Expression.Eq("CustID", custId));
                List<MSellerType> listSellerType = SellerTypeRepository.GetAll(detachedCriteria) as List<MSellerType>;
                if (listSellerType != null && listSellerType.Count > 0)
                {
                    foreach (MSellerType adMInfo in listSellerType)
                    {
                        ListsellerTypeEntity.Add( RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetSellerTypeEntity(adMInfo));
                    }
                }
                else
                    ListsellerTypeEntity = null;

                return ListsellerTypeEntity;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetSellerInfoEntity", ex);
                throw;
            }
        }
        internal List<MBagTypeEntity> GetMBagTypeEntities(string custId)
        {
            try
            {
                List<MBagTypeEntity> ListMBagTypeEntity = new List<MBagTypeEntity>();
                IRepository<MBagType> BagTypeRepository = new RepositoryImpl<MBagType>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(MBagType))
                                                                   .Add(Expression.Eq("CustID", custId));
                List<MBagType> listMBagType = BagTypeRepository.GetAll(detachedCriteria) as List<MBagType>;
                if (listMBagType != null && listMBagType.Count > 0)
                {
                    foreach (MBagType adMInfo in listMBagType)
                    {
                        ListMBagTypeEntity.Add(RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetMBagTypeEntity(adMInfo));
                    }
                }
                else
                    ListMBagTypeEntity = null;

                return ListMBagTypeEntity;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMBagTypeEntities", ex);
                throw;
            }
        }
        internal List<MUnitsTypeEntity> GetMUnitsTypeEntities(string custId)
        {
            try
            {
                List<MUnitsTypeEntity> ListMUnitsTypeEntity = new List<MUnitsTypeEntity>();
                IRepository<MUnitsType> unitsTypeRepository = new RepositoryImpl<MUnitsType>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(MUnitsType))
                                                                   .Add(Expression.Eq("CustID", custId));
                List<MUnitsType> listMUnitsType = unitsTypeRepository.GetAll(detachedCriteria) as List<MUnitsType>;
                if (listMUnitsType != null && listMUnitsType.Count > 0)
                {
                    foreach (MUnitsType adMInfo in listMUnitsType)
                    {
                        ListMUnitsTypeEntity.Add(RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetMUnitsTypeEntity(adMInfo));
                    }
                }
                else
                    ListMUnitsTypeEntity = null;

                return ListMUnitsTypeEntity;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMUnitsTypeEntities", ex);
                throw;
            }
        }
        internal List<SellerInfoEntity> GetSellerInfoEntities(string custId)
        {
            try
            {
                List<SellerInfoEntity> ListSellerInfoEntity = new List<SellerInfoEntity>();
                IRepository<SellerInfo> SellerTypeRepository = new RepositoryImpl<SellerInfo>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(SellerInfo))
                                                                   .Add(Expression.Eq("CustID", custId));
                List<SellerInfo> listSellerInfo = SellerTypeRepository.GetAll(detachedCriteria) as List<SellerInfo>;
                if (listSellerInfo != null && listSellerInfo.Count > 0)
                {
                    foreach (SellerInfo adMInfo in listSellerInfo)
                    {
                        ListSellerInfoEntity.Add(RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetSellerInfoEntity(adMInfo));
                    }
                }
                else
                    ListSellerInfoEntity = null;

                return ListSellerInfoEntity;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetSellerInfoEntities", ex);
                throw;
            }
        }

        internal List<MUserTypeEntity> GetMUserTypeEntities(string CustId)
        {
            try
            {
                List<MUserTypeEntity> lstMUserTypeEntity = new List<MUserTypeEntity>();
                IRepository<MUserType> MUserTypeRepository = new RepositoryImpl<MUserType>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(MUserType))
                                                                   .Add(Expression.Eq("CustID", CustId));
                List<MUserType> listMUserType = MUserTypeRepository.GetAll(detachedCriteria) as List<MUserType>;
                if (listMUserType != null && listMUserType.Count > 0)
                {
                    foreach (MUserType adMInfo in listMUserType)
                    {
                        lstMUserTypeEntity.Add(RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetMUserTypeEntity(adMInfo));
                    }
                }
                else
                    lstMUserTypeEntity = null;

                return lstMUserTypeEntity;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMUserTypeEntities", ex);
                throw;
            }
        }
        internal List<MPaddyTypeEntity> GetMPaddyTypeEntities(string CustId)
        {
            try
            {
                List<MPaddyTypeEntity> listMPaddyTypeEntity = new List<MPaddyTypeEntity>();
                IRepository<MPaddyType> UsersRepository = new RepositoryImpl<MPaddyType>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(MPaddyType))
                                                                   .Add(Expression.Eq("CustID", CustId));
                List<MPaddyType> listMPaddyType = UsersRepository.GetAll(detachedCriteria) as List<MPaddyType>;
                if (listMPaddyType != null && listMPaddyType.Count > 0)
                {
                    foreach (MPaddyType adMInfo in listMPaddyType)
                    {
                        listMPaddyTypeEntity.Add(RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetMPaddyTypeEntity(adMInfo));
                    }
                }
                else
                    listMPaddyTypeEntity = null;

                return listMPaddyTypeEntity;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMPaddyTypeEntities", ex);
                throw;
            }
        }
        internal List<MBrokenRiceTypeEntity> GetMBrokenRiceTypeEntities(string CustId)
        {
            try
            {
                List<MBrokenRiceTypeEntity> listMBrokenRiceTypeEntity = new List<MBrokenRiceTypeEntity>();
                IRepository<MBrokenRiceType> UsersRepository = new RepositoryImpl<MBrokenRiceType>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(MBrokenRiceType))
                                                                   .Add(Expression.Eq("CustID", CustId));
                List<MBrokenRiceType> listMBrokenRiceType = UsersRepository.GetAll(detachedCriteria) as List<MBrokenRiceType>;
                if (listMBrokenRiceType != null && listMBrokenRiceType.Count > 0)
                {
                    foreach (MBrokenRiceType adMInfo in listMBrokenRiceType)
                    {
                        listMBrokenRiceTypeEntity.Add(RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetMBrokenRiceTypeEntity(adMInfo));
                    }
                }
                else
                    listMBrokenRiceTypeEntity = null;

                return listMBrokenRiceTypeEntity;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMBrokenRiceTypeEntities", ex);
                throw;
            }
        }
        internal List<PaddyStockInfoEntity> GetPaddyStockInfoEntities(string CustId)
        {
            try
            {
                List<PaddyStockInfoEntity> listPaddyStockInfoEntity = new List<PaddyStockInfoEntity>();
                IRepository<PaddyStockInfo> UsersRepository = new RepositoryImpl<PaddyStockInfo>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(PaddyStockInfo))
                                                                   .Add(Expression.Eq("CustID", CustId));
                List<PaddyStockInfo> listPaddyStockInfo = UsersRepository.GetAll(detachedCriteria) as List<PaddyStockInfo>;
                if (listPaddyStockInfo != null && listPaddyStockInfo.Count > 0)
                {
                    foreach (PaddyStockInfo adMInfo in listPaddyStockInfo)
                    {
                        listPaddyStockInfoEntity.Add(RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetPaddyStockInfoEntity(adMInfo));
                    }
                }
                else
                    listPaddyStockInfoEntity = null;

                return listPaddyStockInfoEntity;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetPaddyStockInfoEntities", ex);
                throw;
            }
        }
        internal List<BagStockInfoEntity> GetBagStockInfoEntities(string CustId)
        {
            try
            {
                List<BagStockInfoEntity> listBagStockInfoEntity = new List<BagStockInfoEntity>();
                IRepository<BagStockInfo> UsersRepository = new RepositoryImpl<BagStockInfo>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(BagStockInfo))
                                                                   .Add(Expression.Eq("CustID", CustId));
                List<BagStockInfo> listBagStockInfo = UsersRepository.GetAll(detachedCriteria) as List<BagStockInfo>;
                if (listBagStockInfo != null && listBagStockInfo.Count > 0)
                {
                    foreach (BagStockInfo adMInfo in listBagStockInfo)
                    {
                        listBagStockInfoEntity.Add(RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetBagStockInfoEntity(adMInfo));
                    }
                }
                else
                    listBagStockInfoEntity = null;

                return listBagStockInfoEntity;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetBagStockInfoEntities", ex);
                throw;
            }
        }
        internal List<MLotDetailsEntity> GetMLotDetailsEntities(string CustId, string MGodownID)
        {
            try
            {
                List<MLotDetailsEntity> listMLotDetailsEntity = new List<MLotDetailsEntity>();
                IRepository<MLotDetails> UsersRepository = new RepositoryImpl<MLotDetails>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(MLotDetails))
                                                                   .Add(Expression.Eq("CustID", CustId))
                                                                   .Add(Expression.Eq("MGodownID", MGodownID));                                                                   
                List<MLotDetails> listMLotDetails = UsersRepository.GetAll(detachedCriteria) as List<MLotDetails>;
                if (listMLotDetails != null && listMLotDetails.Count > 0)
                {
                    foreach (MLotDetails adMInfo in listMLotDetails)
                    {
                        listMLotDetailsEntity.Add(RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetMLotDetailsEntity(adMInfo));
                    }
                }
                else
                    listMLotDetailsEntity = null;

                return listMLotDetailsEntity;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMLotDetailsEntities", ex);
                throw;
            }
        }


        internal List<MLotDetailsEntity> GetMLotDetailsEntities(string CustId)
        {
            try
            {
                List<MLotDetailsEntity> listMLotDetailsEntity = new List<MLotDetailsEntity>();
                IRepository<MLotDetails> UsersRepository = new RepositoryImpl<MLotDetails>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(MLotDetails))
                                                                   .Add(Expression.Eq("CustID", CustId)
                                                                   );
                List<MLotDetails> listMLotDetails = UsersRepository.GetAll(detachedCriteria) as List<MLotDetails>;
                if (listMLotDetails != null && listMLotDetails.Count > 0)
                {
                    foreach (MLotDetails adMInfo in listMLotDetails)
                    {
                        listMLotDetailsEntity.Add(RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetMLotDetailsEntity(adMInfo));
                    }
                }
                else
                    listMLotDetailsEntity = null;

                return listMLotDetailsEntity;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMLotDetailsEntities", ex);
                throw;
            }
        }


        internal List<MWeightDetailsEntity> GetMWeightDetailsEntities(string CustId)
        {
            try
            {
                List<MWeightDetailsEntity> listMWeightDetailsEntity = new List<MWeightDetailsEntity>();
                IRepository<MWeightDetails> UsersRepository = new RepositoryImpl<MWeightDetails>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(MWeightDetails))
                                                                   .Add(Expression.Eq("CustID", CustId));
                List<MWeightDetails> listMWeightDetails = UsersRepository.GetAll(detachedCriteria) as List<MWeightDetails>;
                if (listMWeightDetails != null && listMWeightDetails.Count > 0)
                {
                    foreach (MWeightDetails adMInfo in listMWeightDetails)
                    {
                        listMWeightDetailsEntity.Add(RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetMWeightDetailsEntity(adMInfo));
                    }
                }
                else
                    listMWeightDetailsEntity = null;

                return listMWeightDetailsEntity;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMWeightDetailsEntities", ex);
                throw;
            }
        }
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
        internal BagStockInfoEntity GetBagStockInfoEntity(string BagStockID)
        {
            try
            {
                BagStockInfoEntity bagStockInfoEntity = new BagStockInfoEntity();
                IRepository<BagStockInfo> UsersRepository = new RepositoryImpl<BagStockInfo>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(BagStockInfo))
                                                                   .Add(Expression.Eq("BagStockID", BagStockID));
                List<BagStockInfo> listBagStockInfoEntity = UsersRepository.GetAll(detachedCriteria) as List<BagStockInfo>;
                if (listBagStockInfoEntity != null && listBagStockInfoEntity.Count > 0)
                {
                    foreach (BagStockInfo adMInfo in listBagStockInfoEntity)
                    {
                        bagStockInfoEntity = RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetBagStockInfoEntity(adMInfo);
                    }
                }
                else
                    bagStockInfoEntity = null;

                return bagStockInfoEntity;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetBagStockInfoEntity", ex);
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
        internal MGodownDetailsEntity GetMGodownDetailsEntity(string MGodownID)
        {
            try
            {
                MGodownDetailsEntity MGodownDetailsEntity = new MGodownDetailsEntity();
                IRepository<MGodownDetails> UsersRepository = new RepositoryImpl<MGodownDetails>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(MGodownDetails))
                                                                   .Add(Expression.Eq("MGodownID", MGodownID));
                List<MGodownDetails> listMGodownDetailsEntity = UsersRepository.GetAll(detachedCriteria) as List<MGodownDetails>;
                if (listMGodownDetailsEntity != null && listMGodownDetailsEntity.Count > 0)
                {
                    foreach (MGodownDetails adMInfo in listMGodownDetailsEntity)
                    {
                        MGodownDetailsEntity = RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetMGodownDetailsEntity(adMInfo);
                    }
                }
                else
                    MGodownDetailsEntity = null;

                return MGodownDetailsEntity;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMGodownDetailsEntity", ex);
                throw;
            }
        }
        internal PaddyPaymentDetailsEntity GetPaddyPaymentDetailsEntity(string PaddyPaymentID)
        {
            try
            {
                PaddyPaymentDetailsEntity paddyPaymentDetailsEntity = new PaddyPaymentDetailsEntity();
                IRepository<PaddyPaymentDetails> UsersRepository = new RepositoryImpl<PaddyPaymentDetails>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(PaddyPaymentDetails))
                                                                   .Add(Expression.Eq("PaddyPaymentID", PaddyPaymentID));
                List<PaddyPaymentDetails> listPaddyPaymentDetailsEntity = UsersRepository.GetAll(detachedCriteria) as List<PaddyPaymentDetails>;
                if (listPaddyPaymentDetailsEntity != null && listPaddyPaymentDetailsEntity.Count > 0)
                {
                    foreach (PaddyPaymentDetails adMInfo in listPaddyPaymentDetailsEntity)
                    {
                        paddyPaymentDetailsEntity = RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetPaddyPaymentDetailsEntity(adMInfo);
                    }
                }
                else
                    paddyPaymentDetailsEntity = null;

                return paddyPaymentDetailsEntity;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetPaddyPaymentDetailsEntity", ex);
                throw;
            }
        }
        internal MWeightDetailsEntity GetMWeightDetailsEntity(string MWeightID)
        {
            try
            {
                MWeightDetailsEntity mWeightDetailsEntity = new MWeightDetailsEntity();
                IRepository<MWeightDetails> UsersRepository = new RepositoryImpl<MWeightDetails>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(MWeightDetails))
                                                                   .Add(Expression.Eq("PaddyPaymentID", MWeightID));
                List<MWeightDetails> listMWeightDetailsEntity = UsersRepository.GetAll(detachedCriteria) as List<MWeightDetails>;
                if (listMWeightDetailsEntity != null && listMWeightDetailsEntity.Count > 0)
                {
                    foreach (MWeightDetails adMInfo in listMWeightDetailsEntity)
                    {
                        mWeightDetailsEntity = RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetMWeightDetailsEntity(adMInfo);
                    }
                }
                else
                    mWeightDetailsEntity = null;

                return mWeightDetailsEntity;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMWeightDetailsEntity", ex);
                throw;
            }
        }
        internal CustomerAddressInfoEntity GetCustomerAddressInfoEntity(string CustAdrsID)
        {
            try
            {
                CustomerAddressInfoEntity customerAddressInfoEntity = new CustomerAddressInfoEntity();
                IRepository<CustomerAddressInfo> UsersRepository = new RepositoryImpl<CustomerAddressInfo>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(CustomerAddressInfo))
                                                                   .Add(Expression.Eq("CustAdrsID", CustAdrsID));
                List<CustomerAddressInfo> listCustomerAddressInfoEntity = UsersRepository.GetAll(detachedCriteria) as List<CustomerAddressInfo>;
                if (listCustomerAddressInfoEntity != null && listCustomerAddressInfoEntity.Count > 0)
                {
                    foreach (CustomerAddressInfo adMInfo in listCustomerAddressInfoEntity)
                    {
                        customerAddressInfoEntity = RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetCustomerAddressInfoEntity(adMInfo);
                    }
                }
                else
                    customerAddressInfoEntity = null;

                return customerAddressInfoEntity;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetCustomerAddressInfoEntity", ex);
                throw;
            }
        }
        internal CustomerActivationEntity GetCustomerActivationEntity(string CustActiveID)
        {
            try
            {
                CustomerActivationEntity customerActivationEntity = new CustomerActivationEntity();
                IRepository<CustomerActivation> UsersRepository = new RepositoryImpl<CustomerActivation>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(CustomerActivation))
                                                                   .Add(Expression.Eq("CustActiveID", CustActiveID));
                List<CustomerActivation> listCustomerActivationEntity = UsersRepository.GetAll(detachedCriteria) as List<CustomerActivation>;
                if (listCustomerActivationEntity != null && listCustomerActivationEntity.Count > 0)
                {
                    foreach (CustomerActivation adMInfo in listCustomerActivationEntity)
                    {
                        customerActivationEntity = RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetCustomerActivationEntity(adMInfo);
                    }
                }
                else
                    customerActivationEntity = null;

                return customerActivationEntity;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetCustomerActivationEntity", ex);
                throw;
            }
        }
        internal CustTrailUsageEntity GetCustTrailUsageEntity(string CustTrailID)
        {
            try
            {
                CustTrailUsageEntity custTrailUsageEntity = new CustTrailUsageEntity();
                IRepository<CustTrailUsage> UsersRepository = new RepositoryImpl<CustTrailUsage>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(CustTrailUsage))
                                                                   .Add(Expression.Eq("CustTrailID", CustTrailID));
                List<CustTrailUsage> listCustTrailUsageEntity = UsersRepository.GetAll(detachedCriteria) as List<CustTrailUsage>;
                if (listCustTrailUsageEntity != null && listCustTrailUsageEntity.Count > 0)
                {
                    foreach (CustTrailUsage adMInfo in listCustTrailUsageEntity)
                    {
                        custTrailUsageEntity = RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetCustTrailUsageEntity(adMInfo);
                    }
                }
                else
                    custTrailUsageEntity = null;

                return custTrailUsageEntity;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetCustTrailUsageEntity", ex);
                throw;
            }
        }
        internal CustomerPaymentEntity GetCustomerPaymentEntity(string CustPaymentID)
        {
            try
            {
                CustomerPaymentEntity customerPaymentEntity = new CustomerPaymentEntity();
                IRepository<CustomerPayment> UsersRepository = new RepositoryImpl<CustomerPayment>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(CustomerPayment))
                                                                   .Add(Expression.Eq("CustPaymentID", CustPaymentID));
                List<CustomerPayment> listCustomerPaymentEntity = UsersRepository.GetAll(detachedCriteria) as List<CustomerPayment>;
                if (listCustomerPaymentEntity != null && listCustomerPaymentEntity.Count > 0)
                {
                    foreach (CustomerPayment adMInfo in listCustomerPaymentEntity)
                    {
                        customerPaymentEntity = RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetCustomerPaymentEntity(adMInfo);
                    }
                }
                else
                    customerPaymentEntity = null;

                return customerPaymentEntity;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetCustomerPaymentEntity", ex);
                throw;
            }
        }
        internal CustomerPartPayDetailsEntity GetCustomerPartPayDetailsEntity(string CustPartPayID)
        {
            try
            {
                CustomerPartPayDetailsEntity customerPartPayDetailsEntity = new CustomerPartPayDetailsEntity();
                IRepository<CustomerPartPayDetails> UsersRepository = new RepositoryImpl<CustomerPartPayDetails>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(CustomerPartPayDetails))
                                                                   .Add(Expression.Eq("CustPartPayID", CustPartPayID));
                List<CustomerPartPayDetails> listCustomerPartPayDetailsEntity = UsersRepository.GetAll(detachedCriteria) as List<CustomerPartPayDetails>;
                if (listCustomerPartPayDetailsEntity != null && listCustomerPartPayDetailsEntity.Count > 0)
                {
                    foreach (CustomerPartPayDetails adMInfo in listCustomerPartPayDetailsEntity)
                    {
                        customerPartPayDetailsEntity = RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetCustomerPartPayDetailsEntity(adMInfo);
                    }
                }
                else
                    customerPartPayDetailsEntity = null;

                return customerPartPayDetailsEntity;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetCustomerPartPayDetailsEntity", ex);
                throw;
            }
        }
        internal MDrierTypeDetailsEntity GetMDrierTypeDetailsEntity(string MDrierTypeID)
        {
            try
            {
                MDrierTypeDetailsEntity mDrierTypeDetailsEntity = new MDrierTypeDetailsEntity();
                IRepository<MDrierTypeDetails> UsersRepository = new RepositoryImpl<MDrierTypeDetails>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(MDrierTypeDetails))
                                                                   .Add(Expression.Eq("MDrierTypeID", MDrierTypeID));
                List<MDrierTypeDetails> listMDrierTypeDetailsEntity = UsersRepository.GetAll(detachedCriteria) as List<MDrierTypeDetails>;
                if (listMDrierTypeDetailsEntity != null && listMDrierTypeDetailsEntity.Count > 0)
                {
                    foreach (MDrierTypeDetails adMInfo in listMDrierTypeDetailsEntity)
                    {
                        mDrierTypeDetailsEntity = RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetMDrierTypeDetailsEntity(adMInfo);
                    }
                }
                else
                    mDrierTypeDetailsEntity = null;

                return mDrierTypeDetailsEntity;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMDrierTypeDetailsEntity", ex);
                throw;
            }
        }
        internal MRiceProductionTypeEntity GetMRiceProductionTypeEntity(string MRiceProdTypeID)
        {
            try
            {
                MRiceProductionTypeEntity mRiceProductionTypeEntity = new MRiceProductionTypeEntity();
                IRepository<MRiceProductionType> UsersRepository = new RepositoryImpl<MRiceProductionType>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(MRiceProductionType))
                                                                   .Add(Expression.Eq("MRiceProdTypeID", MRiceProdTypeID));
                List<MRiceProductionType> listMRiceProductionTypeEntity = UsersRepository.GetAll(detachedCriteria) as List<MRiceProductionType>;
                if (listMRiceProductionTypeEntity != null && listMRiceProductionTypeEntity.Count > 0)
                {
                    foreach (MRiceProductionType adMInfo in listMRiceProductionTypeEntity)
                    {
                        mRiceProductionTypeEntity = RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetMRiceProductionTypeEntity(adMInfo);
                    }
                }
                else
                    mRiceProductionTypeEntity = null;

                return mRiceProductionTypeEntity;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMRiceProductionTypeEntity", ex);
                throw;
            }
        }

        internal List<MRiceProductionTypeEntity> GetMRiceProductionTypeEntities(string custID)
        {
            try
            {
                List<MRiceProductionTypeEntity> mRiceProductionTypeEntityList = new List<MRiceProductionTypeEntity>();
                IRepository<MRiceProductionType> UsersRepository = new RepositoryImpl<MRiceProductionType>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(MRiceProductionType))
                                                                   .Add(Expression.Eq("CustID", custID));
                List<MRiceProductionType> listMRiceProductionTypeEntity = UsersRepository.GetAll(detachedCriteria) as List<MRiceProductionType>;
                if (listMRiceProductionTypeEntity != null && listMRiceProductionTypeEntity.Count > 0)
                {
                    foreach (MRiceProductionType adMInfo in listMRiceProductionTypeEntity)
                    {
                        mRiceProductionTypeEntityList.Add(RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetMRiceProductionTypeEntity(adMInfo));
                    }
                }
                else
                    mRiceProductionTypeEntityList = null;

                return mRiceProductionTypeEntityList;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMRiceProductionTypeEntity", ex);
                throw;
            }
        }

        internal MRiceBrandDetailsEntity GetMRiceBrandDetailsEntity(string MRiceBrandID)
        {
            try
            {
                MRiceBrandDetailsEntity mRiceBrandDetailsEntity = new MRiceBrandDetailsEntity();
                IRepository<MRiceBrandDetails> UsersRepository = new RepositoryImpl<MRiceBrandDetails>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(MRiceBrandDetails))
                                                                   .Add(Expression.Eq("MRiceBrandID", MRiceBrandID));
                List<MRiceBrandDetails> listMRiceBrandDetailsEntity = UsersRepository.GetAll(detachedCriteria) as List<MRiceBrandDetails>;
                if (listMRiceBrandDetailsEntity != null && listMRiceBrandDetailsEntity.Count > 0)
                {
                    foreach (MRiceBrandDetails adMInfo in listMRiceBrandDetailsEntity)
                    {
                        mRiceBrandDetailsEntity = RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetMRiceBrandDetailsEntity(adMInfo);
                    }
                }
                else
                    mRiceBrandDetailsEntity = null;

                return mRiceBrandDetailsEntity;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMRiceBrandDetailsEntity", ex);
                throw;
            }
        }

        internal List<MRiceBrandDetailsEntity> GetMRiceBrandDetailsEntities(string custId)
        {
            try
            {
                List<MRiceBrandDetailsEntity> listMRiceBrandDetailsEntity = new List<MRiceBrandDetailsEntity>();
                IRepository<MRiceBrandDetails> UsersRepository = new RepositoryImpl<MRiceBrandDetails>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(MRiceBrandDetails))
                                                                   .Add(Expression.Eq("CustID", custId));
                List<MRiceBrandDetails> listMRiceBrandDetails = UsersRepository.GetAll(detachedCriteria) as List<MRiceBrandDetails>;
                if (listMRiceBrandDetails != null && listMRiceBrandDetails.Count > 0)
                {
                    foreach (MRiceBrandDetails adMInfo in listMRiceBrandDetails)
                    {
                        listMRiceBrandDetailsEntity.Add( RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetMRiceBrandDetailsEntity(adMInfo));
                    }
                }
                else
                    listMRiceBrandDetailsEntity = null;

                return listMRiceBrandDetailsEntity;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMRiceBrandDetailsEntity", ex);
                throw;
            }
        }
        internal List<RiceStockInfoEntity> GetAllRiceStockInfoEntities(string CustId)
        {
            try
            {
                List<RiceStockInfoEntity> listRiceStockInfoEntity = new List<RiceStockInfoEntity>();
                IRepository<RiceStockInfo> UsersRepository = new RepositoryImpl<RiceStockInfo>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(RiceStockInfo))
                                                                   .Add(Expression.Eq("CustID", CustId));
                List<RiceStockInfo> listRiceStockInfo = UsersRepository.GetAll(detachedCriteria) as List<RiceStockInfo>;
                if (listRiceStockInfo != null && listRiceStockInfo.Count > 0)
                {
                    foreach (RiceStockInfo adMInfo in listRiceStockInfo)
                    {
                        listRiceStockInfoEntity.Add(RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetRiceStockInfoEntity(adMInfo));
                    }
                }
                else
                    listRiceStockInfoEntity = null;

                return listRiceStockInfoEntity;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetRiceStockInfoEntities", ex);
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