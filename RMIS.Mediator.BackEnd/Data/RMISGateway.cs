﻿namespace RMIS.Mediator.BackEnd.Data
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
                        ListsellerTypeEntity.Add(RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetSellerTypeEntity(adMInfo));
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
        internal List<SellerInfoEntity> GetAllSellerInfoEntities(string custId,string SellerType)
        {
            try
            {
                List<SellerInfoEntity> ListSellerInfoEntity = new List<SellerInfoEntity>();
                IRepository<SellerInfo> SellerTypeRepository = new RepositoryImpl<SellerInfo>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(SellerInfo))
                                                                   .Add(Expression.Eq("CustID", custId))
                                                                   .Add(Expression.Eq("SellerTypeID", SellerType));
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



        internal List<CustomerInfoEntity> GetCustomerInfoEntities()
        {
            try
            {
                List<CustomerInfoEntity> customerInfoEntityList = new List<CustomerInfoEntity>();
                IRepository<CustomerInfo> CustomerInfoRepository = new RepositoryImpl<CustomerInfo>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(CustomerInfo))
                                                                   .Add(Expression.Eq("ObsInd", "N"));
                List<CustomerInfo> listCustomerInfoEntity = CustomerInfoRepository.GetAll(detachedCriteria) as List<CustomerInfo>;
                if (listCustomerInfoEntity != null && listCustomerInfoEntity.Count > 0)
                {
                    foreach (CustomerInfo adMInfo in listCustomerInfoEntity)
                    {
                        customerInfoEntityList.Add(RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetCustomerInfoEntity(adMInfo));
                    }
                }
                else
                    customerInfoEntityList = null;

                return customerInfoEntityList;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetCustomerInfoEntities", ex);
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

        internal UsersEntity GetUsersEntity(string Username, string custId)
        {
            try
            {
                UsersEntity usersEntity = new UsersEntity();
                IRepository<Users> UsersRepository = new RepositoryImpl<Users>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(Users))
                                                                   .Add(Expression.Eq("Name", Username))
                                                                   .Add(Expression.Eq("CustID", custId));
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



        internal List<RMUserRoleEntity> GetUserRoles(string userId)
        {
            try
            {
                List<RMUserRoleEntity> listRMUserRoleEntity = new List<RMUserRoleEntity>();
                IRepository<RMUserRole> UsersRepository = new RepositoryImpl<RMUserRole>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(RMUserRole))
                                                                   .Add(Expression.Eq("UserID", userId))
                                                                   .Add(Expression.Eq("ObsInd", "N")
                                                                   );
                List<RMUserRole> listUsersEntity = UsersRepository.GetAll(detachedCriteria) as List<RMUserRole>;
                if (listUsersEntity != null && listUsersEntity.Count > 0)
                {
                    foreach (RMUserRole adMInfo in listUsersEntity)
                    {
                        listRMUserRoleEntity.Add(RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetUserRoleEntity(adMInfo));
                    }
                }
                else
                    listRMUserRoleEntity = null;

                return listRMUserRoleEntity;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetUserRoles", ex);
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


        internal List<MGodownDetailsEntity> GetAllMGodownDetailsEntity(string custId)
        {
            try
            {
                List<MGodownDetailsEntity> listMGodownDetailsEntity = new List<MGodownDetailsEntity>();
                IRepository<MGodownDetails> UsersRepository = new RepositoryImpl<MGodownDetails>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(MGodownDetails))
                                                                    .Add(Expression.Eq("CustID", custId));
                List<MGodownDetails> listMGodownDetails = UsersRepository.GetAll(detachedCriteria) as List<MGodownDetails>;
                if (listMGodownDetails != null && listMGodownDetails.Count > 0)
                {
                    foreach (MGodownDetails objMGodownDetail in listMGodownDetails)
                    {
                        listMGodownDetailsEntity.Add(RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetMGodownDetailsEntity(objMGodownDetail));
                    }
                }
                else
                    listMGodownDetailsEntity = null;

                return listMGodownDetailsEntity;
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
                        listMRiceBrandDetailsEntity.Add(RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetMRiceBrandDetailsEntity(adMInfo));
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
        internal List<BrokenRiceStockInfoEntity> GetAllBrokenRiceStockInfoEntities(string CustId)
        {
            try
            {
                List<BrokenRiceStockInfoEntity> listBrokenRiceStockInfoEntity = new List<BrokenRiceStockInfoEntity>();
                IRepository<BrokenRiceStockInfo> UsersRepository = new RepositoryImpl<BrokenRiceStockInfo>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(BrokenRiceStockInfo))
                                                                   .Add(Expression.Eq("CustID", CustId));
                List<BrokenRiceStockInfo> listBrokenRiceStockInfo = UsersRepository.GetAll(detachedCriteria) as List<BrokenRiceStockInfo>;
                if (listBrokenRiceStockInfo != null && listBrokenRiceStockInfo.Count > 0)
                {
                    foreach (BrokenRiceStockInfo adMInfo in listBrokenRiceStockInfo)
                    {
                        listBrokenRiceStockInfoEntity.Add(RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetBrokenRiceStockInfoEntity(adMInfo));
                    }
                }
                else
                    listBrokenRiceStockInfoEntity = null;

                return listBrokenRiceStockInfoEntity;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetBrokenRiceStockInfoEntities", ex);
                throw;
            }
        }
        internal List<DustStockInfoEntity> GetAllDustStockInfoEntities(string CustId)
        {
            try
            {
                List<DustStockInfoEntity> listDustStockInfoEntity = new List<DustStockInfoEntity>();
                IRepository<DustStockInfo> UsersRepository = new RepositoryImpl<DustStockInfo>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(DustStockInfo))
                                                                   .Add(Expression.Eq("CustID", CustId));
                List<DustStockInfo> listDustStockInfo = UsersRepository.GetAll(detachedCriteria) as List<DustStockInfo>;
                if (listDustStockInfo != null && listDustStockInfo.Count > 0)
                {
                    foreach (DustStockInfo adMInfo in listDustStockInfo)
                    {
                        listDustStockInfoEntity.Add(RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetDustStockInfoEntity(adMInfo));
                    }
                }
                else
                    listDustStockInfoEntity = null;

                return listDustStockInfoEntity;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetDustStockInfoEntities", ex);
                throw;
            }
        }
        internal List<RiceSellingInfoEntity> GetAllRiceSellingInfoEntities(string CustId)
        {
            try
            {
                List<RiceSellingInfoEntity> listRiceSellingInfoEntity = new List<RiceSellingInfoEntity>();
                IRepository<RiceSellingInfo> UsersRepository = new RepositoryImpl<RiceSellingInfo>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(RiceSellingInfo))
                                                                   .Add(Expression.Eq("CustID", CustId));
                List<RiceSellingInfo> listRiceSellingInfo = UsersRepository.GetAll(detachedCriteria) as List<RiceSellingInfo>;
                if (listRiceSellingInfo != null && listRiceSellingInfo.Count > 0)
                {
                    foreach (RiceSellingInfo adMInfo in listRiceSellingInfo)
                    {
                        listRiceSellingInfoEntity.Add(RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetRiceSellingInfoEntity(adMInfo));
                    }
                }
                else
                    listRiceSellingInfoEntity = null;

                return listRiceSellingInfoEntity;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetRiceSellingInfoEntities", ex);
                throw;
            }
        }
        internal List<BrokenRiceSellingInfoEntity> GetAllBrokenRiceSellingInfoEntities(string CustId)
        {
            try
            {
                List<BrokenRiceSellingInfoEntity> listBrokenRiceSellingInfoEntity = new List<BrokenRiceSellingInfoEntity>();
                IRepository<BrokenRiceSellingInfo> UsersRepository = new RepositoryImpl<BrokenRiceSellingInfo>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(BrokenRiceSellingInfo))
                                                                   .Add(Expression.Eq("CustID", CustId));
                List<BrokenRiceSellingInfo> listBrokenRiceSellingInfo = UsersRepository.GetAll(detachedCriteria) as List<BrokenRiceSellingInfo>;
                if (listBrokenRiceSellingInfo != null && listBrokenRiceSellingInfo.Count > 0)
                {
                    foreach (BrokenRiceSellingInfo adMInfo in listBrokenRiceSellingInfo)
                    {
                        listBrokenRiceSellingInfoEntity.Add(RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetBrokenRiceSellingInfoEntity(adMInfo));
                    }
                }
                else
                    listBrokenRiceSellingInfoEntity = null;

                return listBrokenRiceSellingInfoEntity;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetBrokenRiceSellingInfoEntities", ex);
                throw;
            }
        }
        internal List<DustSellingInfoEntity> GetAllDustSellingInfoEntities(string CustId)
        {
            try
            {
                List<DustSellingInfoEntity> listDustSellingInfoEntity = new List<DustSellingInfoEntity>();
                IRepository<DustSellingInfo> UsersRepository = new RepositoryImpl<DustSellingInfo>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(DustSellingInfo))
                                                                   .Add(Expression.Eq("CustID", CustId));
                List<DustSellingInfo> listDustSellingInfo = UsersRepository.GetAll(detachedCriteria) as List<DustSellingInfo>;
                if (listDustSellingInfo != null && listDustSellingInfo.Count > 0)
                {
                    foreach (DustSellingInfo adMInfo in listDustSellingInfo)
                    {
                        listDustSellingInfoEntity.Add(RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetDustSellingInfoEntity(adMInfo));
                    }
                }
                else
                    listDustSellingInfoEntity = null;

                return listDustSellingInfoEntity;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetDustSellingInfoEntities", ex);
                throw;
            }
        }

        internal List<MenuInfoEntity> GetMenuInfoEntities()
        {
            try
            {
                List<MenuInfoEntity> menuInfoEntityList = new List<MenuInfoEntity>();
                IRepository<MenuInfo> UsersRepository = new RepositoryImpl<MenuInfo>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(MenuInfo))
                                                                   .Add(Expression.Eq("ObsInd", "N"));
                List<MenuInfo> listMenuInfo = UsersRepository.GetAll(detachedCriteria) as List<MenuInfo>;
                if (listMenuInfo != null && listMenuInfo.Count > 0)
                {
                    foreach (MenuInfo adMInfo in listMenuInfo)
                    {
                        menuInfoEntityList.Add(RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetMenuInfoEntity(adMInfo));
                    }
                }
                else
                    menuInfoEntityList = null;

                return menuInfoEntityList;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMenuInfoEntities", ex);
                throw;
            }
        }


        internal List<MRolesEntity> GetRoleEntities()
        {
            try
            {
                List<MRolesEntity> mRolesEntityList = new List<MRolesEntity>();
                IRepository<MRoles> UsersRepository = new RepositoryImpl<MRoles>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(MRoles))
                                                                   .Add(Expression.Eq("ObsInd", "N"));
                List<MRoles> listMRoles = UsersRepository.GetAll(detachedCriteria) as List<MRoles>;
                if (listMRoles != null && listMRoles.Count > 0)
                {
                    foreach (MRoles adMInfo in listMRoles)
                    {
                        mRolesEntityList.Add(RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetRoleEntity(adMInfo));
                    }
                }
                else
                    mRolesEntityList = null;

                return mRolesEntityList;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetRoleEntities", ex);
                throw;
            }
        }


        internal List<MenuConfigurationEntity> GetMenuConfigurationEntities(string CustId)
        {
            try
            {
                List<MenuConfigurationEntity> MenuConfigurationEntityList = new List<MenuConfigurationEntity>();
                IRepository<MenuConfiguration> UsersRepository = new RepositoryImpl<MenuConfiguration>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(MenuConfiguration))
                                                                   .Add(Expression.Eq("CustID", CustId));
                List<MenuConfiguration> listMenuConfiguration = UsersRepository.GetAll(detachedCriteria) as List<MenuConfiguration>;
                if (listMenuConfiguration != null && listMenuConfiguration.Count > 0)
                {
                    foreach (MenuConfiguration adMInfo in listMenuConfiguration)
                    {
                        MenuConfigurationEntityList.Add(RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetMenuConfigEntity(adMInfo));
                    }
                }
                else
                    MenuConfigurationEntityList = null;

                return MenuConfigurationEntityList;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMenuConfigurationEntities", ex);
                throw;
            }
        }
        internal List<MProductSellingTypeEntity> GetMProductSellingTypeEnties(string CustId)
        {
            try
            {
                List<MProductSellingTypeEntity> listMProductSellingTypeEntity = new List<MProductSellingTypeEntity>();
                IRepository<MProductSellingType> UsersRepository = new RepositoryImpl<MProductSellingType>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(MProductSellingType))
                                                                   .Add(Expression.Eq("CustID", CustId));
                List<MProductSellingType> listMProductSellingType = UsersRepository.GetAll(detachedCriteria) as List<MProductSellingType>;
                if (listMProductSellingType != null && listMProductSellingType.Count > 0)
                {
                    foreach (MProductSellingType adMInfo in listMProductSellingType)
                    {
                        listMProductSellingTypeEntity.Add(RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetMProductSellingTypeEntity(adMInfo));
                    }
                }
                else
                    listMProductSellingTypeEntity = null;

                return listMProductSellingTypeEntity;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMProductSellingTypeEnties", ex);
                throw;
            }
        }

        internal List<ProductSellingInfoEntity> GetAllProductSellingInfoEntities(string CustId)
        {
            try
            {
                List<ProductSellingInfoEntity> listProductSellingInfoEntity = new List<ProductSellingInfoEntity>();
                IRepository<ProductSellingInfo> UsersRepository = new RepositoryImpl<ProductSellingInfo>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(ProductSellingInfo))
                                                                   .Add(Expression.Eq("CustID", CustId));
                List<ProductSellingInfo> listProductSellingInfo = UsersRepository.GetAll(detachedCriteria) as List<ProductSellingInfo>;
                if (listProductSellingInfo != null && listProductSellingInfo.Count > 0)
                {
                    foreach (ProductSellingInfo adMInfo in listProductSellingInfo)
                    {
                        listProductSellingInfoEntity.Add(RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetProductSellingInfoEntity(adMInfo));
                    }
                }
                else
                    listProductSellingInfoEntity = null;

                return listProductSellingInfoEntity;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetProductSellingInfoEntities", ex);
                throw;
            }
        }
        internal List<HullingProcessEntity> GetHullingProcessInfoEntities(string CustId)
        {
            try
            {
                List<HullingProcessEntity> listHullingProcessEntity = new List<HullingProcessEntity>();
                IRepository<HullingProcess> UsersRepository = new RepositoryImpl<HullingProcess>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(HullingProcess))
                                                                   .Add(Expression.Eq("CustID", CustId));
                List<HullingProcess> listHullingProcess = UsersRepository.GetAll(detachedCriteria) as List<HullingProcess>;
                if (listHullingProcess != null && listHullingProcess.Count > 0)
                {
                    foreach (HullingProcess adMInfo in listHullingProcess)
                    {
                        listHullingProcessEntity.Add(RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetHullingProcessInfoEntity(adMInfo));
                    }
                }
                else
                    listHullingProcessEntity = null;

                return listHullingProcessEntity;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetHullingProcessfoEntities", ex);
                throw;
            }
        }
        internal List<HullingProcessTransactionEntity> GetHullingProcessTransInfoEntities(string CustId)
        {
            try
            {
                List<HullingProcessTransactionEntity> listHullingProcessTrnsEntity = new List<HullingProcessTransactionEntity>();
                IRepository<HullingTransaction> UsersRepository = new RepositoryImpl<HullingTransaction>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(HullingTransaction))
                                                                   .Add(Expression.Eq("CustID", CustId));
                List<HullingTransaction> listHullingProcessTrans = UsersRepository.GetAll(detachedCriteria) as List<HullingTransaction>;
                if (listHullingProcessTrans != null && listHullingProcessTrans.Count > 0)
                {
                    foreach (HullingTransaction adMInfo in listHullingProcessTrans)
                    {
                        listHullingProcessTrnsEntity.Add(RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetHullingProcessTransInfoEntity(adMInfo));
                    }
                }
                else
                    listHullingProcessTrnsEntity = null;

                return listHullingProcessTrnsEntity;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetHullingProcessTransInfoEntities", ex);
                throw;
            }
        }
        internal List<HullingProcessExpensesEntity> GetHullingProcessExpensesEntities(string CustId)
        {
            try
            {
                List<HullingProcessExpensesEntity> listHullingProcessExpensesEntity = new List<HullingProcessExpensesEntity>();
                IRepository<HullingProcessExpenses> UsersRepository = new RepositoryImpl<HullingProcessExpenses>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(HullingProcessExpenses))
                                                                   .Add(Expression.Eq("CustID", CustId));
                List<HullingProcessExpenses> listHullingProcessExpenses = UsersRepository.GetAll(detachedCriteria) as List<HullingProcessExpenses>;
                if (listHullingProcessExpenses != null && listHullingProcessExpenses.Count > 0)
                {
                    foreach (HullingProcessExpenses adMInfo in listHullingProcessExpenses)
                    {
                        listHullingProcessExpensesEntity.Add(RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetHullingProcessExpensesEntityInfoEntity(adMInfo));
                    }
                }
                else
                    listHullingProcessExpensesEntity = null;

                return listHullingProcessExpensesEntity;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetHullingProcessExpensesEntities", ex);
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