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
    using RMIS.Domain.Constant;
using RMIS.Domain;



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

        #region Get Methods
        internal List<MBagTypeEntity> GetMBagTypeEntities(string custId,YesNo yesNo)
        {
            try
            {
                List<MBagTypeEntity> ListMBagTypeEntity = new List<MBagTypeEntity>();
                IRepository<MBagType> BagTypeRepository = new RepositoryImpl<MBagType>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(MBagType))
                                                                   .Add(Expression.Eq("CustID", custId))
                                                                     .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) }))
                                                                   );

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
        internal MUnitsTypeEntity GetMUnitsTypeEntity(string unitTypeId)
        {
            try
            {
                MUnitsTypeEntity mUnitsTypeEntity = new MUnitsTypeEntity();
                IRepository<MUnitsType> unitsTypeRepository = new RepositoryImpl<MUnitsType>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(MUnitsType))
                                                                   .Add(Expression.Eq("UnitsTypeID", unitTypeId)
                                                                   );
                List<MUnitsType> listMUnitsType = unitsTypeRepository.GetAll(detachedCriteria) as List<MUnitsType>;
                if (listMUnitsType != null && listMUnitsType.Count > 0)
                {
                    foreach (MUnitsType adMInfo in listMUnitsType)
                    {
                        mUnitsTypeEntity = (RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetMUnitsTypeEntity(adMInfo));
                        break;
                    }
                }
                else
                    mUnitsTypeEntity = null;

                return mUnitsTypeEntity;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMUnitsTypeEntities", ex);
                throw;
            }
        }
        internal List<MUnitsTypeEntity> GetMUnitsTypeEntities(string custId,YesNo yesNo)
        {
            try
            {
                List<MUnitsTypeEntity> ListMUnitsTypeEntity = new List<MUnitsTypeEntity>();
                IRepository<MUnitsType> unitsTypeRepository = new RepositoryImpl<MUnitsType>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(MUnitsType))
                                                                   .Add(Expression.Eq("CustID", custId))
                                                                     .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) }))
                                                                   );
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


        internal List<SellerInfoEntity> GetSellerInfoEntities(string custId, YesNo yesNo,int count,string prefixText)
        {
            try
            {
                List<SellerInfoEntity> ListSellerInfoEntity = new List<SellerInfoEntity>();
                IRepository<SellerInfo> SellerTypeRepository = new RepositoryImpl<SellerInfo>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(SellerInfo))
                                                                   .Add(Expression.Eq("CustID", custId))
                                                                     .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) })))
                                                                     .Add(Restrictions.Like("Name", prefixText + "%"))
                                                                     .AddOrder(Order.Asc("Name"))
                                                                     .SetMaxResults(count);
                                                                     
                                                                 
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


        internal List<SellerInfoEntity> GetSellerInfoEntities(string custId,YesNo yesNo)
        {
            try
            {
                List<SellerInfoEntity> ListSellerInfoEntity = new List<SellerInfoEntity>();
                IRepository<SellerInfo> SellerTypeRepository = new RepositoryImpl<SellerInfo>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(SellerInfo))
                                                                   .Add(Expression.Eq("CustID", custId))
                                                                     .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) }))
                                                                   );
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
        internal List<MUserTypeEntity> GetMUserTypeEntities(string CustId, YesNo yesNo)
        {
            try
            {
                List<MUserTypeEntity> lstMUserTypeEntity = new List<MUserTypeEntity>();
                IRepository<MUserType> MUserTypeRepository = new RepositoryImpl<MUserType>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(MUserType))
                                                                   .Add(Expression.Eq("CustID", CustId))
                                                                     .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) }))
                                                                   );
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
        internal List<MPaddyTypeEntity> GetMPaddyTypeEntities(string CustId, int pageindex, int pageSize, out int count, SortExpression expression,YesNo yesNo)
        {
            try
            {
                List<MPaddyTypeEntity> listMPaddyTypeEntity = new List<MPaddyTypeEntity>();
                IRepository<MPaddyType> UsersRepository = new RepositoryImpl<MPaddyType>(applicationSession);
                DetachedCriteria detachedCriteria = null;
                if (expression == SortExpression.Desc)
                    detachedCriteria = DetachedCriteria.For(typeof(MPaddyType))
                                                                      .Add(Expression.Eq("CustID", CustId))
                                                                        .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) }))
                                                                      ).AddOrder(Order.Asc("PaddyTypeID"));
                else
                    detachedCriteria = DetachedCriteria.For(typeof(MPaddyType))
                                                                   .Add(Expression.Eq("CustID", CustId))
                                                                     .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) }))
                                                                   ).AddOrder(Order.Desc("PaddyTypeID"));


                List<MPaddyType> listMPaddyType = UsersRepository.GetAllWithPagingMultiCriteria(detachedCriteria, pageindex, pageSize, out count) as List<MPaddyType>;
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
        internal List<PaddyStockInfoEntity> GetPaddyStockInfoEntity(string CustId, int pageindex, int pageSize, out int count, SortExpression expression,YesNo yesNo)
        {
            try
            {
                List<PaddyStockInfoEntity> listpaddyStockInfoEntity = new List<PaddyStockInfoEntity>();
                IRepository<PaddyStockInfo> UsersRepository = new RepositoryImpl<PaddyStockInfo>(applicationSession);
                DetachedCriteria detachedCriteria = null;
                if (expression == SortExpression.Desc)
                    detachedCriteria = DetachedCriteria.For(typeof(PaddyStockInfo))
                                                                      .Add(Expression.Eq("CustID", CustId))
                                                                        .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) }))
                                                                      ).AddOrder(Order.Asc("PaddyStockID"));
                else
                    detachedCriteria = DetachedCriteria.For(typeof(PaddyStockInfo))
                                                                   .Add(Expression.Eq("CustID", CustId))
                                                                     .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) }))
                                                                   ).AddOrder(Order.Desc("PaddyStockID"));
                List<PaddyStockInfo> listPaddyStockInfoEntity = UsersRepository.GetAllWithPagingMultiCriteria(detachedCriteria, pageindex, pageSize, out count) as List<PaddyStockInfo>;
                if (listPaddyStockInfoEntity != null && listPaddyStockInfoEntity.Count > 0)
                {
                    foreach (PaddyStockInfo adMInfo in listPaddyStockInfoEntity)
                    {
                        listpaddyStockInfoEntity.Add(RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetPaddyStockInfoEntity(adMInfo));
                    }
                }
                else
                    listpaddyStockInfoEntity = null;

                return listpaddyStockInfoEntity;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetPaddyStockInfoEntity", ex);
                throw;
            }
        }
        internal List<MPaddyTypeEntity> GetMPaddyTypeEntities(string CustId, YesNo yesNo)
        {
            try
            {
                List<MPaddyTypeEntity> listMPaddyTypeEntity = new List<MPaddyTypeEntity>();
                IRepository<MPaddyType> UsersRepository = new RepositoryImpl<MPaddyType>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(MPaddyType))
                                                                   .Add(Expression.Eq("CustID", CustId))
                                                                   .Add(Expression.In("ObsInd",( yesNo==YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y),Enum.GetName(typeof(YesNo), YesNo.N)}:  new string[] { Enum.GetName(typeof(YesNo), yesNo) }))
                                                                   );

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
        internal List<MBrokenRiceTypeEntity> GetMBrokenRiceTypeEntities(string CustId, YesNo yesNo)
        {
            try
            {
                List<MBrokenRiceTypeEntity> listMBrokenRiceTypeEntity = new List<MBrokenRiceTypeEntity>();
                IRepository<MBrokenRiceType> UsersRepository = new RepositoryImpl<MBrokenRiceType>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(MBrokenRiceType))
                                                                   .Add(Expression.Eq("CustID", CustId))
                                                                     .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) }))
                                                                   );

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
        internal List<PaddyStockInfoEntity> GetPaddyStockInfoEntities(string CustId, YesNo yesNo)
        {
            try
            {
                List<PaddyStockInfoEntity> listPaddyStockInfoEntity = new List<PaddyStockInfoEntity>();
                IRepository<PaddyStockInfo> UsersRepository = new RepositoryImpl<PaddyStockInfo>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(PaddyStockInfo))
                                                                   .Add(Expression.Eq("CustID", CustId))
                                                                      .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) }))
                                                                   );
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
        internal List<BagStockInfoEntity> GetBagStockInfoEntities(string CustId, YesNo yesNo)
        {
            try
            {
                List<BagStockInfoEntity> listBagStockInfoEntity = new List<BagStockInfoEntity>();
                IRepository<BagStockInfo> UsersRepository = new RepositoryImpl<BagStockInfo>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(BagStockInfo))
                                                                   .Add(Expression.Eq("CustID", CustId))
                                                                     .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) }))
                                                                   );

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
        internal List<MLotDetailsEntity> GetMLotDetailsEntities(string CustId, string MGodownID, YesNo yesNo)
        {
            try
            {
                List<MLotDetailsEntity> listMLotDetailsEntity = new List<MLotDetailsEntity>();
                IRepository<MLotDetails> UsersRepository = new RepositoryImpl<MLotDetails>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(MLotDetails))
                                                                   .Add(Expression.Eq("CustID", CustId))
                                                                   .Add(Expression.Eq("MGodownID", MGodownID))
                                                                     .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) }))
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
        internal List<MLotDetailsEntity> GetMLotDetailsEntities(string CustId, YesNo yesNo)
        {
            try
            {
                List<MLotDetailsEntity> listMLotDetailsEntity = new List<MLotDetailsEntity>();
                IRepository<MLotDetails> UsersRepository = new RepositoryImpl<MLotDetails>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(MLotDetails))
                                                                   .Add(Expression.Eq("CustID", CustId)
                                                                   )
                                                                     .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) }))
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
        internal List<MWeightDetailsEntity> GetMWeightDetailsEntities(string CustId, YesNo yesNo)
        {
            try
            {
                List<MWeightDetailsEntity> listMWeightDetailsEntity = new List<MWeightDetailsEntity>();
                IRepository<MWeightDetails> UsersRepository = new RepositoryImpl<MWeightDetails>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(MWeightDetails))
                                                                   .Add(Expression.Eq("CustID", CustId))
                                                                     .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) }))
                                                                   );
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
        internal SellerInfoEntity GetSellerInfoEntity(string SellerID, YesNo yesNo)
        {
            try
            {
                SellerInfoEntity sellerInfoEntity = new SellerInfoEntity();
                IRepository<SellerInfo> SellerInfoRepository = new RepositoryImpl<SellerInfo>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(SellerInfo))
                                                                   .Add(Expression.Eq("SellerID", SellerID))
                                                                     .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) }))
                                                                   );
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
        internal CustomerInfoEntity GetCustomerInfoEntity(string CustID, YesNo yesNo)
        {
            try
            {
                CustomerInfoEntity customerInfoEntity = new CustomerInfoEntity();
                IRepository<CustomerInfo> CustomerInfoRepository = new RepositoryImpl<CustomerInfo>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(CustomerInfo))
                                                                   .Add(Expression.Eq("CustID", CustID))
                                                                     .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) }))
                                                                   );
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
        internal List<CustomerInfoEntity> GetCustomerInfoEntities(YesNo yesNo)
        {
            try
            {
                List<CustomerInfoEntity> customerInfoEntityList = new List<CustomerInfoEntity>();
                IRepository<CustomerInfo> CustomerInfoRepository = new RepositoryImpl<CustomerInfo>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(CustomerInfo))
                                                                    .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) })))
                                                                     .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) }))
                                                                   );
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
        internal MUserTypeEntity GetMUserTypeEntity(string UserTypeID,YesNo yesNo)
        {
            try
            {
                MUserTypeEntity mUserTypeEntity = new MUserTypeEntity();
                IRepository<MUserType> MUserTypeRepository = new RepositoryImpl<MUserType>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(MUserType))
                                                                   .Add(Expression.Eq("UserTypeID", UserTypeID))
                                                                     .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) }))
                                                                   );
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
        internal UsersEntity GetUsersEntity(string Username, string custId,YesNo yesNo)
        {
            try
            {
                UsersEntity usersEntity = new UsersEntity();
                IRepository<Users> UsersRepository = new RepositoryImpl<Users>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(Users))
                                                                   .Add(Expression.Eq("Name", Username))
                                                                   .Add(Expression.Eq("CustID", custId))
                                                                     .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) }))
                                                                   );
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
        internal List<RMUserRoleEntity> GetUserRoles(string userId,YesNo yesNo)
        {
            try
            {
                List<RMUserRoleEntity> listRMUserRoleEntity = new List<RMUserRoleEntity>();
                IRepository<RMUserRole> UsersRepository = new RepositoryImpl<RMUserRole>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(RMUserRole))
                                                                   .Add(Expression.Eq("UserID", userId))
                                                                    .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) }))
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
        internal UsersEntity GetUsersEntity(string UserID,YesNo yesNo)
        {
            try
            {
                UsersEntity usersEntity = new UsersEntity();
                IRepository<Users> UsersRepository = new RepositoryImpl<Users>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(Users))
                                                                   .Add(Expression.Eq("UserID", UserID))
                                                                     .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) }))
                                                                   );
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
        internal MPaddyTypeEntity GetMPaddyTypeEntity(string PaddyTypeID,YesNo yesNo)
        {
            try
            {
                MPaddyTypeEntity mPaddyTypeEntity = new MPaddyTypeEntity();
                IRepository<MPaddyType> UsersRepository = new RepositoryImpl<MPaddyType>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(MPaddyType))
                                                                   .Add(Expression.Eq("PaddyTypeID", PaddyTypeID))
                                                                      .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) }))
                                                                   );
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
        internal PaddyStockInfoEntity GetPaddyStockInfoEntity(string PaddyStockID,YesNo yesNo)
        {
            try
            {
                PaddyStockInfoEntity paddyStockInfoEntity = new PaddyStockInfoEntity();
                IRepository<PaddyStockInfo> UsersRepository = new RepositoryImpl<PaddyStockInfo>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(PaddyStockInfo))
                                                                   .Add(Expression.Eq("PaddyStockID", PaddyStockID))
                                                                     .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) }))
                                                                   );
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
        internal BagStockInfoEntity GetBagStockInfoEntity(string BagStockID,YesNo yesNo)
        {
            try
            {
                BagStockInfoEntity bagStockInfoEntity = new BagStockInfoEntity();
                IRepository<BagStockInfo> UsersRepository = new RepositoryImpl<BagStockInfo>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(BagStockInfo))
                                                                   .Add(Expression.Eq("BagStockID", BagStockID))
                                                                     .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) }))
                                                                   );
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
        internal MLotDetailsEntity GetMLotDetailsEntity(string MLotID,YesNo yesNo)
        {
            try
            {
                MLotDetailsEntity mLotDetailsEntity = new MLotDetailsEntity();
                IRepository<MLotDetails> UsersRepository = new RepositoryImpl<MLotDetails>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(MLotDetails))
                                                                   .Add(Expression.Eq("MLotID", MLotID))
                                                                     .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) }))
                                                                   );
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
        internal MGodownDetailsEntity GetMGodownDetailsEntity(string MGodownID,YesNo yesNo)
        {
            try
            {
                MGodownDetailsEntity MGodownDetailsEntity = new MGodownDetailsEntity();
                IRepository<MGodownDetails> UsersRepository = new RepositoryImpl<MGodownDetails>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(MGodownDetails))
                                                                   .Add(Expression.Eq("MGodownID", MGodownID))
                                                                     .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) }))
                                                                   );
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
        internal List<MGodownDetailsEntity> GetAllMGodownDetailsEntity(string custId,YesNo yesNo)
        {
            try
            {
                List<MGodownDetailsEntity> listMGodownDetailsEntity = new List<MGodownDetailsEntity>();
                IRepository<MGodownDetails> UsersRepository = new RepositoryImpl<MGodownDetails>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(MGodownDetails))
                                                                    .Add(Expression.Eq("CustID", custId))
                                                                      .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) }))
                                                                   );
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
        internal PaddyPaymentDetailsEntity GetPaddyPaymentDetailsEntity(string PaddyPaymentID,YesNo yesNo)
        {
            try
            {
                PaddyPaymentDetailsEntity paddyPaymentDetailsEntity = new PaddyPaymentDetailsEntity();
                IRepository<PaddyPaymentDetails> UsersRepository = new RepositoryImpl<PaddyPaymentDetails>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(PaddyPaymentDetails))
                                                                   .Add(Expression.Eq("PaddyPaymentID", PaddyPaymentID))
                                                                     .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) }))
                                                                   );
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
        internal MWeightDetailsEntity GetMWeightDetailsEntity(string MWeightID,YesNo yesNo)
        {
            try
            {
                MWeightDetailsEntity mWeightDetailsEntity = new MWeightDetailsEntity();
                IRepository<MWeightDetails> UsersRepository = new RepositoryImpl<MWeightDetails>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(MWeightDetails))
                                                                   .Add(Expression.Eq("PaddyPaymentID", MWeightID))
                                                                     .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) }))
                                                                   );
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
        internal CustomerAddressInfoEntity GetCustomerAddressInfoEntity(string CustAdrsID,YesNo yesNo)
        {
            try
            {
                CustomerAddressInfoEntity customerAddressInfoEntity = new CustomerAddressInfoEntity();
                IRepository<CustomerAddressInfo> UsersRepository = new RepositoryImpl<CustomerAddressInfo>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(CustomerAddressInfo))
                                                                   .Add(Expression.Eq("CustAdrsID", CustAdrsID))
                                                                     .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) }))
                                                                   );
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
        internal CustomerActivationEntity GetCustomerActivationEntity(string CustActiveID,YesNo yesNo)
        {
            try
            {
                CustomerActivationEntity customerActivationEntity = new CustomerActivationEntity();
                IRepository<CustomerActivation> UsersRepository = new RepositoryImpl<CustomerActivation>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(CustomerActivation))
                                                                   .Add(Expression.Eq("CustActiveID", CustActiveID))
                                                                     .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) }))
                                                                   );
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
        internal CustTrailUsageEntity GetCustTrailUsageEntity(string CustTrailID,YesNo yesNo)
        {
            try
            {
                CustTrailUsageEntity custTrailUsageEntity = new CustTrailUsageEntity();
                IRepository<CustTrailUsage> UsersRepository = new RepositoryImpl<CustTrailUsage>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(CustTrailUsage))
                                                                   .Add(Expression.Eq("CustTrailID", CustTrailID))
                                                                     .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) }))
                                                                   );
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
        internal CustomerPaymentEntity GetCustomerPaymentEntity(string CustPaymentID,YesNo yesNo)
        {
            try
            {
                CustomerPaymentEntity customerPaymentEntity = new CustomerPaymentEntity();
                IRepository<CustomerPayment> UsersRepository = new RepositoryImpl<CustomerPayment>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(CustomerPayment))
                                                                   .Add(Expression.Eq("CustPaymentID", CustPaymentID))
                                                                     .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) }))
                                                                   );
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
        internal CustomerPartPayDetailsEntity GetCustomerPartPayDetailsEntity(string CustPartPayID,YesNo yesNo)
        {
            try
            {
                CustomerPartPayDetailsEntity customerPartPayDetailsEntity = new CustomerPartPayDetailsEntity();
                IRepository<CustomerPartPayDetails> UsersRepository = new RepositoryImpl<CustomerPartPayDetails>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(CustomerPartPayDetails))
                                                                   .Add(Expression.Eq("CustPartPayID", CustPartPayID))
                                                                     .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) }))
                                                                   );
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
        internal MDrierTypeDetailsEntity GetMDrierTypeDetailsEntity(string MDrierTypeID,YesNo yesNo)
        {
            try
            {
                MDrierTypeDetailsEntity mDrierTypeDetailsEntity = new MDrierTypeDetailsEntity();
                IRepository<MDrierTypeDetails> UsersRepository = new RepositoryImpl<MDrierTypeDetails>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(MDrierTypeDetails))
                                                                   .Add(Expression.Eq("MDrierTypeID", MDrierTypeID))
                                                                     .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) }))
                                                                   );
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
        internal MRiceProductionTypeEntity GetMRiceProductionTypeEntity(string MRiceProdTypeID,YesNo yesNo)
        {
            try
            {
                MRiceProductionTypeEntity mRiceProductionTypeEntity = new MRiceProductionTypeEntity();
                IRepository<MRiceProductionType> UsersRepository = new RepositoryImpl<MRiceProductionType>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(MRiceProductionType))
                                                                   .Add(Expression.Eq("MRiceProdTypeID", MRiceProdTypeID))
                                                                     .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) }))
                                                                   );
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
        internal List<MRiceProductionTypeEntity> GetMRiceProductionTypeEntities(string custID,YesNo yesNo)
        {
            try
            {
                List<MRiceProductionTypeEntity> mRiceProductionTypeEntityList = new List<MRiceProductionTypeEntity>();
                IRepository<MRiceProductionType> UsersRepository = new RepositoryImpl<MRiceProductionType>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(MRiceProductionType))
                                                                   .Add(Expression.Eq("CustID", custID))
                                                                     .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) }))
                                                                   );
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
        internal MRiceBrandDetailsEntity GetMRiceBrandDetailsEntity(string MRiceBrandID,YesNo yesNo)
        {
            try
            {
                MRiceBrandDetailsEntity mRiceBrandDetailsEntity = new MRiceBrandDetailsEntity();
                IRepository<MRiceBrandDetails> UsersRepository = new RepositoryImpl<MRiceBrandDetails>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(MRiceBrandDetails))
                                                                   .Add(Expression.Eq("MRiceBrandID", MRiceBrandID))
                                                                     .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) }))
                                                                   );
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
        internal List<MRiceBrandDetailsEntity> GetMRiceBrandDetailsEntities(string custId,YesNo yesNo)
        {
            try
            {
                List<MRiceBrandDetailsEntity> listMRiceBrandDetailsEntity = new List<MRiceBrandDetailsEntity>();
                IRepository<MRiceBrandDetails> UsersRepository = new RepositoryImpl<MRiceBrandDetails>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(MRiceBrandDetails))
                                                                   .Add(Expression.Eq("CustID", custId))
                                                                     .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) }))
                                                                   );
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
        internal List<RiceStockInfoEntity> GetAllRiceStockInfoEntities(string CustId,YesNo yesNo)
        {
            try
            {
                List<RiceStockInfoEntity> listRiceStockInfoEntity = new List<RiceStockInfoEntity>();
                IRepository<RiceStockInfo> UsersRepository = new RepositoryImpl<RiceStockInfo>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(RiceStockInfo))
                                                                   .Add(Expression.Eq("CustID", CustId))
                                                                     .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) }))
                                                                   );
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
        internal List<BrokenRiceStockInfoEntity> GetAllBrokenRiceStockInfoEntities(string CustId,YesNo yesNo)
        {
            try
            {
                List<BrokenRiceStockInfoEntity> listBrokenRiceStockInfoEntity = new List<BrokenRiceStockInfoEntity>();
                IRepository<BrokenRiceStockInfo> UsersRepository = new RepositoryImpl<BrokenRiceStockInfo>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(BrokenRiceStockInfo))
                                                                   .Add(Expression.Eq("CustID", CustId))
                                                                     .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) }))
                                                                   );
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
        internal List<DustStockInfoEntity> GetAllDustStockInfoEntities(string CustId,YesNo yesNo)
        {
            try
            {
                List<DustStockInfoEntity> listDustStockInfoEntity = new List<DustStockInfoEntity>();
                IRepository<DustStockInfo> UsersRepository = new RepositoryImpl<DustStockInfo>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(DustStockInfo))
                                                                   .Add(Expression.Eq("CustID", CustId))
                                                                     .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) }))
                                                                   );
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
        internal List<RiceSellingInfoEntity> GetAllRiceSellingInfoEntities(string CustId,YesNo yesNo)
        {
            try
            {
                List<RiceSellingInfoEntity> listRiceSellingInfoEntity = new List<RiceSellingInfoEntity>();
                IRepository<RiceSellingInfo> UsersRepository = new RepositoryImpl<RiceSellingInfo>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(RiceSellingInfo))
                                                                   .Add(Expression.Eq("CustID", CustId))
                                                                     .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) }))
                                                                   );
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
        internal List<BrokenRiceSellingInfoEntity> GetAllBrokenRiceSellingInfoEntities(string CustId,YesNo yesNo)
        {
            try
            {
                List<BrokenRiceSellingInfoEntity> listBrokenRiceSellingInfoEntity = new List<BrokenRiceSellingInfoEntity>();
                IRepository<BrokenRiceSellingInfo> UsersRepository = new RepositoryImpl<BrokenRiceSellingInfo>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(BrokenRiceSellingInfo))
                                                                   .Add(Expression.Eq("CustID", CustId))
                                                                     .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) }))
                                                                   );
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
        internal List<DustSellingInfoEntity> GetAllDustSellingInfoEntities(string CustId,YesNo yesNo)
        {
            try
            {
                List<DustSellingInfoEntity> listDustSellingInfoEntity = new List<DustSellingInfoEntity>();
                IRepository<DustSellingInfo> UsersRepository = new RepositoryImpl<DustSellingInfo>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(DustSellingInfo))
                                                                   .Add(Expression.Eq("CustID", CustId))
                                                                     .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) }))
                                                                   );
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
        internal List<MenuInfoEntity> GetMenuInfoEntities(YesNo yesNo)
        {
            try
            {
                List<MenuInfoEntity> menuInfoEntityList = new List<MenuInfoEntity>();
                IRepository<MenuInfo> UsersRepository = new RepositoryImpl<MenuInfo>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(MenuInfo))
                                                                    .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) })));
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
        internal List<MRolesEntity> GetRoleEntities(YesNo yesNo)
        {
            try
            {
                List<MRolesEntity> mRolesEntityList = new List<MRolesEntity>();
                IRepository<MRoles> UsersRepository = new RepositoryImpl<MRoles>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(MRoles))
                                                                    .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) })));
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
        internal List<MenuConfigurationEntity> GetMenuConfigurationEntities(string CustId,YesNo yesNo)
        {
            try
            {
                List<MenuConfigurationEntity> MenuConfigurationEntityList = new List<MenuConfigurationEntity>();
                IRepository<MenuConfiguration> UsersRepository = new RepositoryImpl<MenuConfiguration>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(MenuConfiguration))
                                                                   .Add(Expression.Eq("CustID", CustId))
                                                                     .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) }))
                                                                   );
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
        internal List<MProductSellingTypeEntity> GetMProductSellingTypeEnties(string CustId,YesNo yesNo)
        {
            try
            {
                List<MProductSellingTypeEntity> listMProductSellingTypeEntity = new List<MProductSellingTypeEntity>();
                IRepository<MProductSellingType> UsersRepository = new RepositoryImpl<MProductSellingType>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(MProductSellingType))
                                                                   .Add(Expression.Eq("CustID", CustId))
                                                                     .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) }))
                                                                   );
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
        internal List<ProductSellingInfoEntity> GetAllProductSellingInfoEntities(string CustId,YesNo yesNo)
        {
            try
            {
                List<ProductSellingInfoEntity> listProductSellingInfoEntity = new List<ProductSellingInfoEntity>();
                IRepository<ProductSellingInfo> UsersRepository = new RepositoryImpl<ProductSellingInfo>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(ProductSellingInfo))
                                                                   .Add(Expression.Eq("CustID", CustId))
                                                                     .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) }))
                                                                   );
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
        internal List<HullingProcessEntity> GetHullingProcessInfoEntities(string CustId,YesNo yesNo)
        {
            try
            {
                List<HullingProcessEntity> listHullingProcessEntity = new List<HullingProcessEntity>();
                IRepository<HullingProcess> UsersRepository = new RepositoryImpl<HullingProcess>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(HullingProcess))
                                                                   .Add(Expression.Eq("CustID", CustId))
                                                                     .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) }))
                                                                   );
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
        internal List<HullingProcessTransactionEntity> GetHullingProcessTransInfoEntities(string CustId,YesNo yesNo)
        {
            try
            {
                List<HullingProcessTransactionEntity> listHullingProcessTrnsEntity = new List<HullingProcessTransactionEntity>();
                IRepository<HullingTransaction> UsersRepository = new RepositoryImpl<HullingTransaction>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(HullingTransaction))
                                                                   .Add(Expression.Eq("CustID", CustId))
                                                                     .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) }))
                                                                   );
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
        internal List<HullingProcessExpensesEntity> GetHullingProcessExpensesEntities(string CustId,YesNo yesNo)
        {
            try
            {
                List<HullingProcessExpensesEntity> listHullingProcessExpensesEntity = new List<HullingProcessExpensesEntity>();
                IRepository<HullingProcessExpenses> UsersRepository = new RepositoryImpl<HullingProcessExpenses>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(HullingProcessExpenses))
                                                                   .Add(Expression.Eq("CustID", CustId))
                                                                     .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) }))
                                                                   );
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
        internal List<BuyerSellerRatingEntity> GetAllBuyerSellerRatingEntities(string CustId,YesNo yesNo)
        {
            try
            {
                List<BuyerSellerRatingEntity> listBuyerSellerRatingEntity = new List<BuyerSellerRatingEntity>();
                IRepository<BuyerSellerRating> UsersRepository = new RepositoryImpl<BuyerSellerRating>(applicationSession);

                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(BuyerSellerRating))
                                                                   .Add(Expression.Eq("CustID", CustId))
                                                                     .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) }))
                                                                   ).SetFirstResult(0).SetMaxResults(10);
                List<BuyerSellerRating> listBuyerSellerRating = UsersRepository.GetAll(detachedCriteria) as List<BuyerSellerRating>;
                if (listBuyerSellerRating != null && listBuyerSellerRating.Count > 0)
                {
                    foreach (BuyerSellerRating adMInfo in listBuyerSellerRating)
                    {
                        listBuyerSellerRatingEntity.Add(RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetBuyerSellerRatingEntity(adMInfo));
                    }
                }
                else
                    listBuyerSellerRatingEntity = null;

                return listBuyerSellerRatingEntity;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetBuyerSellerRatingEntities", ex);
                throw;
            }
        }
        internal List<BuyerInfoEntity> GetBuyerInfoEntities(string custId,YesNo yesNo)
        {
            try
            {
                List<BuyerInfoEntity> ListBuyerInfoEntity = new List<BuyerInfoEntity>();
                IRepository<BuyerInfo> BuyerTypeRepository = new RepositoryImpl<BuyerInfo>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(BuyerInfo))
                                                                   .Add(Expression.Eq("CustID", custId))
                 .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) })));
                List<BuyerInfo> listBuyerInfo = BuyerTypeRepository.GetAll(detachedCriteria) as List<BuyerInfo>;
                if (listBuyerInfo != null && listBuyerInfo.Count > 0)
                {
                    foreach (BuyerInfo adMInfo in listBuyerInfo)
                    {
                        ListBuyerInfoEntity.Add(RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetBuyerInfoEntity(adMInfo));
                    }
                }
                else
                    ListBuyerInfoEntity = null;

                return ListBuyerInfoEntity;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetBuyerInfoEntities", ex);
                throw;
            }
        }
        internal List<MEmployeeDesignationEntity> GetMEmployeeDesignationEntities(string custId,YesNo yesNo)
        {
            try
            {
                List<MEmployeeDesignationEntity> ListMEmployeeDesignationEntity = new List<MEmployeeDesignationEntity>();
                IRepository<MEmployeeDesignation> EmpDesigTypeRepository = new RepositoryImpl<MEmployeeDesignation>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(MEmployeeDesignation))
                                                                   .Add(Expression.Eq("CustID", custId))
                                                                    .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) })));
                List<MEmployeeDesignation> listMEmployeeDesignation = EmpDesigTypeRepository.GetAll(detachedCriteria) as List<MEmployeeDesignation>;
                if (listMEmployeeDesignation != null && listMEmployeeDesignation.Count > 0)
                {
                    foreach (MEmployeeDesignation adMInfo in listMEmployeeDesignation)
                    {
                        ListMEmployeeDesignationEntity.Add(RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetMEmployeeDesignationEntity(adMInfo));
                    }
                }
                else
                    ListMEmployeeDesignationEntity = null;

                return ListMEmployeeDesignationEntity;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMEmployeeDesignationEntities", ex);
                throw;
            }
        }
        internal List<MSalaryTypeEntity> GetMSalaryTypeEntities(string custId,YesNo yesNo)
        {
            try
            {
                List<MSalaryTypeEntity> ListMSalaryTypeEntity = new List<MSalaryTypeEntity>();
                IRepository<MSalaryType> EmpSalaryRepository = new RepositoryImpl<MSalaryType>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(MSalaryType))
                                                                   .Add(Expression.Eq("CustID", custId))
                                                                    .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) })));
                List<MSalaryType> listMSalaryType = EmpSalaryRepository.GetAll(detachedCriteria) as List<MSalaryType>;
                if (listMSalaryType != null && listMSalaryType.Count > 0)
                {
                    foreach (MSalaryType adMInfo in listMSalaryType)
                    {
                        ListMSalaryTypeEntity.Add(RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetMSalaryTypeEntity(adMInfo));
                    }
                }
                else
                    ListMSalaryTypeEntity = null;

                return ListMSalaryTypeEntity;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMSalaryTypeEntities", ex);
                throw;
            }
        }
        internal List<EmployeeDetailsEntity> GetEmployeeDetailsEntities(string custId,YesNo yesNo)
        {
            try
            {
                List<EmployeeDetailsEntity> ListEmployeeDetailsEntity = new List<EmployeeDetailsEntity>();
                IRepository<EmployeeDetails> EmployeeDetailsRepository = new RepositoryImpl<EmployeeDetails>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(EmployeeDetails))
                                                                   .Add(Expression.Eq("CustID", custId))
                                                                     .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) })));
                List<EmployeeDetails> listEmployeeDetails = EmployeeDetailsRepository.GetAll(detachedCriteria) as List<EmployeeDetails>;
                if (listEmployeeDetails != null && listEmployeeDetails.Count > 0)
                {
                    foreach (EmployeeDetails adMInfo in listEmployeeDetails)
                    {
                        ListEmployeeDetailsEntity.Add(RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetEmployeeDetailsEntity(adMInfo));
                    }
                }
                else
                    ListEmployeeDetailsEntity = null;

                return ListEmployeeDetailsEntity;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetEmployeeDetailsEntities", ex);
                throw;
            }
        }
        internal List<EmployeeSalaryEntity> GetEmployeeSalaryEntities(string custId,YesNo yesNo)
        {
            try
            {
                List<EmployeeSalaryEntity> ListEmployeeSalaryEntity = new List<EmployeeSalaryEntity>();
                IRepository<EmployeeSalary> EmployeeSalaryRepository = new RepositoryImpl<EmployeeSalary>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(EmployeeSalary))
                                                                   .Add(Expression.Eq("CustID", custId))
                                                                     .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) })));
                List<EmployeeSalary> listEmployeeSalary = EmployeeSalaryRepository.GetAll(detachedCriteria) as List<EmployeeSalary>;
                if (listEmployeeSalary != null && listEmployeeSalary.Count > 0)
                {
                    foreach (EmployeeSalary adMInfo in listEmployeeSalary)
                    {
                        ListEmployeeSalaryEntity.Add(RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetEmployeeSalaryEntity(adMInfo));
                    }
                }
                else
                    ListEmployeeSalaryEntity = null;

                return ListEmployeeSalaryEntity;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetEmployeeSalaryEntities", ex);
                throw;
            }
        }
        internal EmployeeDetailsEntity GetEmployeeDetailsEntity(string custId,string EmployeeID,YesNo yesNo)
        {
            try
            {
                EmployeeDetailsEntity EmployeeDetailsEntity = new EmployeeDetailsEntity();
                IRepository<EmployeeDetails> UsersRepository = new RepositoryImpl<EmployeeDetails>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(EmployeeDetails))
                                                                   .Add(Expression.Eq("EmployeeID", EmployeeID))
                                                                   .Add(Expression.Eq("CustID", custId))
                                                                     .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) }))
                                                                   );
                List<EmployeeDetails> listEmployeeDetailsEntity = UsersRepository.GetAll(detachedCriteria) as List<EmployeeDetails>;
                if (listEmployeeDetailsEntity != null && listEmployeeDetailsEntity.Count > 0)
                {
                    foreach (EmployeeDetails adMInfo in listEmployeeDetailsEntity)
                    {
                        EmployeeDetailsEntity = RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetEmployeeDetailsEntity(adMInfo);
                    }
                }
                else
                    EmployeeDetailsEntity = null;

                return EmployeeDetailsEntity;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetEmployeeDetailsEntity", ex);
                throw;
            }
        }
        internal MEmployeeDesignationEntity GetMEmployeeDesignationEntity(string custId, string DesignationID,YesNo yesNo)
        {
            try
            {
                MEmployeeDesignationEntity MEmployeeDesignationEntity = new MEmployeeDesignationEntity();
                IRepository<MEmployeeDesignation> UsersRepository = new RepositoryImpl<MEmployeeDesignation>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(MEmployeeDesignation))
                                                                   .Add(Expression.Eq("MEmpDsgID", DesignationID))
                                                                   .Add(Expression.Eq("CustID", custId))
                                                                     .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) }))
                                                                   );
                List<MEmployeeDesignation> listMEmployeeDesignationEntity = UsersRepository.GetAll(detachedCriteria) as List<MEmployeeDesignation>;
                if (listMEmployeeDesignationEntity != null && listMEmployeeDesignationEntity.Count > 0)
                {
                    foreach (MEmployeeDesignation adMInfo in listMEmployeeDesignationEntity)
                    {
                        MEmployeeDesignationEntity = RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetMEmployeeDesignationEntity(adMInfo);
                    }
                }
                else
                    MEmployeeDesignationEntity = null;

                return MEmployeeDesignationEntity;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMEmployeeDesignationEntity", ex);
                throw;
            }
        }
        internal MSalaryTypeEntity GetListMSalaryTypeEntity(string custId, string SalaryTypeId,YesNo yesNo)
        {
            try
            {
                MSalaryTypeEntity MSalaryTypeEntity = new MSalaryTypeEntity();
                IRepository<MSalaryType> UsersRepository = new RepositoryImpl<MSalaryType>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(MSalaryType))
                                                                   .Add(Expression.Eq("MSalaryTypeID", SalaryTypeId))
                                                                   .Add(Expression.Eq("CustID", custId))
                                                                     .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) }))
                                                                   );
                List<MSalaryType> listMSalaryTypeEntity = UsersRepository.GetAll(detachedCriteria) as List<MSalaryType>;
                if (listMSalaryTypeEntity != null && listMSalaryTypeEntity.Count > 0)
                {
                    foreach (MSalaryType adMInfo in listMSalaryTypeEntity)
                    {
                        MSalaryTypeEntity = RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetMSalaryTypeEntity(adMInfo);
                    }
                }
                else
                    MSalaryTypeEntity = null;

                return MSalaryTypeEntity;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMSalaryTypeEntity", ex);
                throw;
            }
        }
        
        #endregion

        #region Check Data Exist
        internal List<MPaddyTypeEntity> CheckPaddyTypeExist(string CustId, string paddytype,YesNo yesNo)
        {
            try
            {
                List<MPaddyTypeEntity> listMPaddyTypeEntity = new List<MPaddyTypeEntity>();
                IRepository<MPaddyType> UsersRepository = new RepositoryImpl<MPaddyType>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(MPaddyType))
                                                                   .Add(Expression.Eq("CustID", CustId))
                                                                   .Add(Expression.Eq("Name", paddytype))
                                                                     .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) }))
                                                                   );

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
        internal MGodownDetailsEntity CheckGodownNameExist(string custId, string GodownName,YesNo yesNo)
        {
            try
            {
                MGodownDetailsEntity MGodownDetailsEntity = new MGodownDetailsEntity();
                IRepository<MGodownDetails> unitsTypeRepository = new RepositoryImpl<MGodownDetails>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(MGodownDetails))
                                                                   .Add(Expression.Eq("Name", GodownName))
                                                                   .Add(Expression.Eq("CustID", custId))
                                                                     .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) })));
                List<MGodownDetails> listMGodownDetails = unitsTypeRepository.GetAll(detachedCriteria) as List<MGodownDetails>;
                if (listMGodownDetails != null && listMGodownDetails.Count > 0)
                {
                    foreach (MGodownDetails adMInfo in listMGodownDetails)
                    {
                        MGodownDetailsEntity = (RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetMGodownDetailsEntity(adMInfo));
                        break;
                    }
                }
                else
                    MGodownDetailsEntity = null;

                return MGodownDetailsEntity;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at CheckGodownNameExist", ex);
                throw;
            }
        }
        internal MUnitsTypeEntity CheckUnitTypeExist(string custId, string UnitsType,YesNo yesNo)
        {
            try
            {
                MUnitsTypeEntity mUnitsTypeEntity = new MUnitsTypeEntity();
                IRepository<MUnitsType> unitsTypeRepository = new RepositoryImpl<MUnitsType>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(MUnitsType))
                                                                   .Add(Expression.Eq("UnitsType", UnitsType))
                                                                   .Add(Expression.Eq("CustID", custId))
                                                                     .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) })));
                List<MUnitsType> listMUnitsType = unitsTypeRepository.GetAll(detachedCriteria) as List<MUnitsType>;
                if (listMUnitsType != null && listMUnitsType.Count > 0)
                {
                    foreach (MUnitsType adMInfo in listMUnitsType)
                    {
                        mUnitsTypeEntity = (RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetMUnitsTypeEntity(adMInfo));
                        break;
                    }
                }
                else
                    mUnitsTypeEntity = null;

                return mUnitsTypeEntity;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMUnitsTypeEntities", ex);
                throw;
            }
        }
        internal MLotDetailsEntity CheckLotNameExist(string custId, string LotName,YesNo yesNo)
        {
            try
            {
                MLotDetailsEntity MLotDetailsEntity = new MLotDetailsEntity();
                IRepository<MLotDetails> unitsTypeRepository = new RepositoryImpl<MLotDetails>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(MLotDetails))
                                                                   .Add(Expression.Eq("LotName", LotName))
                                                                   .Add(Expression.Eq("CustID", custId))
                                                                     .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) })));
                List<MLotDetails> listMLotDetails = unitsTypeRepository.GetAll(detachedCriteria) as List<MLotDetails>;
                if (listMLotDetails != null && listMLotDetails.Count > 0)
                {
                    foreach (MLotDetails adMInfo in listMLotDetails)
                    {
                        MLotDetailsEntity = (RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetMLotDetailsEntity(adMInfo));
                        break;
                    }
                }
                else
                    MLotDetailsEntity = null;

                return MLotDetailsEntity;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at CheckLotNameExist", ex);
                throw;
            }
        }
        internal MEmployeeDesignationEntity CheckEmpDesigExist(string custId, string DesignationType,YesNo yesNo)
        {
            try
            {
                MEmployeeDesignationEntity MEmployeeDesignationEntity = new MEmployeeDesignationEntity();
                IRepository<MEmployeeDesignation> DesigTypeRepository = new RepositoryImpl<MEmployeeDesignation>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(MEmployeeDesignation))
                                                                   .Add(Expression.Eq("DesignationType", DesignationType))
                                                                   .Add(Expression.Eq("CustID", custId))
                                                                     .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) })));
                List<MEmployeeDesignation> listMEmployeeDesignation = DesigTypeRepository.GetAll(detachedCriteria) as List<MEmployeeDesignation>;
                if (listMEmployeeDesignation != null && listMEmployeeDesignation.Count > 0)
                {
                    foreach (MEmployeeDesignation adMInfo in listMEmployeeDesignation)
                    {
                        MEmployeeDesignationEntity = (RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetMEmployeeDesignationEntity(adMInfo));
                        break;
                    }
                }
                else
                    MEmployeeDesignationEntity = null;

                return MEmployeeDesignationEntity;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at CheckEmpDesigExist", ex);
                throw;
            }
        }
        internal MSalaryTypeEntity CheckSalaryTypeExist(string custId, string SalaryType,YesNo yesNo)
        {
            try
            {
                MSalaryTypeEntity MSalaryTypeEntity = new MSalaryTypeEntity();
                IRepository<MSalaryType> DesigTypeRepository = new RepositoryImpl<MSalaryType>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(MSalaryType))
                                                                   .Add(Expression.Eq("Salarytype", SalaryType))
                                                                   .Add(Expression.Eq("CustID", custId))
                                                                     .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) })));
                List<MSalaryType> listMSalaryType = DesigTypeRepository.GetAll(detachedCriteria) as List<MSalaryType>;
                if (listMSalaryType != null && listMSalaryType.Count > 0)
                {
                    foreach (MSalaryType adMInfo in listMSalaryType)
                    {
                        MSalaryTypeEntity = (RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetMSalaryTypeEntity(adMInfo));
                        break;
                    }
                }
                else
                    MSalaryTypeEntity = null;

                return MSalaryTypeEntity;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at CheckSalaryTypeExist", ex);
                throw;
            }
        }
        internal EmployeeDetailsEntity CheckEmployeeExist(string custId, string EmployeeName,YesNo yesNo)
        {
            try
            {
                EmployeeDetailsEntity EmployeeDetailsEntity = new EmployeeDetailsEntity();
                IRepository<EmployeeDetails> DesigTypeRepository = new RepositoryImpl<EmployeeDetails>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(EmployeeDetails))
                                                                   .Add(Expression.Eq("Name", EmployeeName))
                                                                   .Add(Expression.Eq("CustID", custId))
                                                                     .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) })));
                List<EmployeeDetails> listEmployeeDetails = DesigTypeRepository.GetAll(detachedCriteria) as List<EmployeeDetails>;
                if (listEmployeeDetails != null && listEmployeeDetails.Count > 0)
                {
                    foreach (EmployeeDetails adMInfo in listEmployeeDetails)
                    {
                        EmployeeDetailsEntity = (RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetEmployeeDetailsEntity(adMInfo));
                        break;
                    }
                }
                else
                    EmployeeDetailsEntity = null;

                return EmployeeDetailsEntity;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at CheckEmployeeExist", ex);
                throw;
            }
        }
        internal EmployeeSalaryEntity CheckEmployeeSalaryExist(string custId, string EmployeeID,YesNo yesNo)
        {
            try
            {
                EmployeeSalaryEntity EmployeeSalaryEntity = new EmployeeSalaryEntity();
                IRepository<EmployeeSalary> DesigTypeRepository = new RepositoryImpl<EmployeeSalary>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(EmployeeSalary))
                                                                   .Add(Expression.Eq("EmployeeID", EmployeeID))
                                                                   .Add(Expression.Eq("CustID", custId))
                                                                     .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) })));
                List<EmployeeSalary> listEmployeeSalary = DesigTypeRepository.GetAll(detachedCriteria) as List<EmployeeSalary>;
                if (listEmployeeSalary != null && listEmployeeSalary.Count > 0)
                {
                    foreach (EmployeeSalary adMInfo in listEmployeeSalary)
                    {
                        EmployeeSalaryEntity = (RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetEmployeeSalaryEntity(adMInfo));
                        break;
                    }
                }
                else
                    EmployeeSalaryEntity = null;

                return EmployeeSalaryEntity;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at CheckEmployeeExist", ex);
                throw;
            }
        }
        #endregion
        private List<T> GetAllFromRepository<T>()
        {
            IRepository<T> repository = new RepositoryImpl<T>(applicationSession);
            return repository.GetAll() as List<T>;
        }


    }
}