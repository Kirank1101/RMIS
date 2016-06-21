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
        internal List<MBagTypeEntity> GetMBagTypeEntities(string custId, YesNo yesNo)
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
        internal List<EmployeeDetailsEntity> GetEmployeeDetailsEntities(string custId, YesNo yesNo, int count, string prefixText)
        {
            try
            {
                List<EmployeeDetailsEntity> ListEmployeeDetailsEntity = new List<EmployeeDetailsEntity>();
                IRepository<EmployeeDetails> EmployeeDetailsRepository = new RepositoryImpl<EmployeeDetails>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(EmployeeDetails))
                                                                   .Add(Expression.Eq("CustID", custId))
                                                                     .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) })))
                                                                      .Add(Restrictions.Like("Name", prefixText + "%"))
                                                                     .AddOrder(Order.Asc("Name"))
                                                                     .SetMaxResults(count);
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


        internal List<BuyerInfoEntity> GetBuyerInfoEntities(string custId, YesNo yesNo, int count, string prefixText)
        {
            try
            {
                List<BuyerInfoEntity> ListBuyerInfoEntity = new List<BuyerInfoEntity>();
                IRepository<BuyerInfo> BuyerTypeRepository = new RepositoryImpl<BuyerInfo>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(BuyerInfo))
                                                                   .Add(Expression.Eq("CustID", custId))
                 .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) })))
                 .Add(Restrictions.Like("Name", prefixText + "%"))
                                                                     .AddOrder(Order.Asc("Name"))
                                                                     .SetMaxResults(count);
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

        internal List<BuyerInfoEntity> GetBuyerInfoEntities(string custId, YesNo yesNo)
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


        internal List<SellerInfoEntity> GetSellerInfoEntities(string custId, YesNo yesNo, int count, string prefixText)
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


        internal List<SellerInfoEntity> GetSellerInfoEntities(string custId, YesNo yesNo)
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





        internal int GetMRiceProductionTypeCount(string CustId, YesNo yesNo)
        {
            try
            {
                IRepository<MRiceProductionType> UsersRepository = new RepositoryImpl<MRiceProductionType>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(MRiceProductionType))
                                                                   .Add(Expression.Eq("CustID", CustId))
                                                                     .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) }))
                                                                   );
                return UsersRepository.GetCountUsingFuture(detachedCriteria);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMRiceProductionTypeCount", ex);
                throw;
            }

        }

        #region Rice Product Count and calculation
        internal int GetRiceProductTotal(string CustId, YesNo yesNo)
        {
            try
            {
                IRepository<HullingTransaction> UsersRepository = new RepositoryImpl<HullingTransaction>(applicationSession);
                DetachedCriteria detachedCriteria =
                DetachedCriteria.For(typeof(HullingTransaction))
                                                                      .Add(Expression.Eq("CustID", CustId))
                                                                        .Add(Restrictions.IsNotNull("MRiceProdTypeID"))
                                                                        .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) })))

                                                                        ;
                return UsersRepository.GetSumResults(detachedCriteria, "TotalBags");
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetRiceProductTotal", ex);
                throw;
            }

        }
        internal int GetRiceProductUsedTotal(string CustId, YesNo yesNo)
        {
            try
            {
                IRepository<ProductSellingInfo> UsersRepository = new RepositoryImpl<ProductSellingInfo>(applicationSession);
                DetachedCriteria detachedCriteria =
                DetachedCriteria.For(typeof(ProductSellingInfo))
                                                                      .Add(Expression.Eq("CustID", CustId))
                                                                        .Add(Restrictions.IsNotNull("MRiceProdTypeID"))
                                                                        .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) })))

                                                                        ;
                return UsersRepository.GetSumResults(detachedCriteria, "TotalBags");
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetRiceProductUsedTotal", ex);
                throw;
            }

        }
        internal int GetBrokenRiceProductTotal(string CustId, YesNo yesNo)
        {
            try
            {
                IRepository<HullingTransaction> UsersRepository = new RepositoryImpl<HullingTransaction>(applicationSession);
                DetachedCriteria detachedCriteria =
                DetachedCriteria.For(typeof(HullingTransaction))
                                                                      .Add(Expression.Eq("CustID", CustId))
                                                                        .Add(Restrictions.IsNotNull("BrokenRiceTypeID"))
                                                                        .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) })))

                                                                        ;
                return UsersRepository.GetSumResults(detachedCriteria, "TotalBags");
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetRiceProductTotal", ex);
                throw;
            }

        }
        internal int GetBrokenRiceProductUsedTotal(string CustId, YesNo yesNo)
        {
            try
            {
                IRepository<ProductSellingInfo> UsersRepository = new RepositoryImpl<ProductSellingInfo>(applicationSession);
                DetachedCriteria detachedCriteria =
                DetachedCriteria.For(typeof(ProductSellingInfo))
                                                                      .Add(Expression.Eq("CustID", CustId))
                                                                        .Add(Restrictions.IsNotNull("BrokenRiceTypeID"))
                                                                        .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) })))

                                                                        ;
                return UsersRepository.GetSumResults(detachedCriteria, "TotalBags");
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetRiceProductUsedTotal", ex);
                throw;
            }

        }

        internal int GetRiceProductTotal(string CustId, string UnitsTypeID, string RiceProdTypeID, string RiceBrandId, YesNo yesNo)
        {

            try
            {
                IRepository<HullingTransaction> UsersRepository = new RepositoryImpl<HullingTransaction>(applicationSession);
                DetachedCriteria detachedCriteria =
                DetachedCriteria.For(typeof(HullingTransaction))
                                                                      .Add(Expression.Eq("CustID", CustId))
                                                                         .Add(Expression.Eq("UnitsTypeID", UnitsTypeID))
                                                                          .Add(Expression.Eq("MRiceProdTypeID", RiceProdTypeID))
                                                                          .Add(Expression.Eq("MRiceBrandID", RiceBrandId))
                                                                        .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) })))

                                                                        ;
                return UsersRepository.GetSumResults(detachedCriteria, "TotalBags");
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetRiceProductTotal", ex);
                throw;
            }

        }

        internal int GetRiceProductUsedTotal(string CustId, string UnitsTypeID, string RiceProdTypeID, string RiceBrandId, YesNo yesNo)
        {
            try
            {
                IRepository<ProductSellingInfo> UsersRepository = new RepositoryImpl<ProductSellingInfo>(applicationSession);
                DetachedCriteria detachedCriteria =
                DetachedCriteria.For(typeof(ProductSellingInfo))
                                                                    .Add(Expression.Eq("CustID", CustId))
                                                                             .Add(Expression.Eq("UnitsTypeID", UnitsTypeID))
                                                                              .Add(Expression.Eq("MRiceProdTypeID", RiceProdTypeID))
                                                                              .Add(Expression.Eq("MRiceBrandID", RiceBrandId))
                                                                            .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) })))

                                                                            ;

                ;
                return UsersRepository.GetSumResults(detachedCriteria, "TotalBags");
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetRiceProductUsedTotal", ex);
                throw;
            }
        }

        internal int GetBrokenRiceProductTotal(string CustId, string UnitsTypeID, string BrokenRiceTypeID, YesNo yesNo)
        {

            try
            {
                IRepository<HullingTransaction> UsersRepository = new RepositoryImpl<HullingTransaction>(applicationSession);
                DetachedCriteria detachedCriteria =
                DetachedCriteria.For(typeof(HullingTransaction))
                                                                      .Add(Expression.Eq("CustID", CustId))
                                                                         .Add(Expression.Eq("UnitsTypeID", UnitsTypeID))
                                                                          .Add(Expression.Eq("BrokenRiceTypeID", BrokenRiceTypeID))
                                                                        .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) })))

                                                                        ;
                return UsersRepository.GetSumResults(detachedCriteria, "TotalBags");
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetRiceProductTotal", ex);
                throw;
            }

        }
        internal int GetBrokenRiceProductUsedTotal(string CustId, string UnitsTypeID, string BrokenRiceTypeID, YesNo yesNo)
        {
            try
            {
                IRepository<ProductSellingInfo> UsersRepository = new RepositoryImpl<ProductSellingInfo>(applicationSession);
                DetachedCriteria detachedCriteria =
                DetachedCriteria.For(typeof(ProductSellingInfo))
                                                                    .Add(Expression.Eq("CustID", CustId))
                                                                             .Add(Expression.Eq("UnitsTypeID", UnitsTypeID))
                                                                              .Add(Expression.Eq("BrokenRiceTypeID", BrokenRiceTypeID))
                                                                            .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) })))

                                                                            ;

                ;
                return UsersRepository.GetSumResults(detachedCriteria, "TotalBags");
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetRiceProductUsedTotal", ex);
                throw;
            }

        }


        #endregion


        #region Paddy Amount Due
        internal double GetPaddyTotalAmount(string CustId, YesNo yesNo)
        {
            try
            {
                IRepository<PaddyStockInfo> UsersRepository = new RepositoryImpl<PaddyStockInfo>(applicationSession);
                DetachedCriteria detachedCriteria =
                DetachedCriteria.For(typeof(PaddyStockInfo))
                                                                      .Add(Expression.Eq("CustID", CustId))
                                                                        .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) })))

                                                                        ;
                return UsersRepository.GetMultiplySumResultsAsDouble(detachedCriteria, "Price", "TotalBags");
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetPaddyTotalAmountDue", ex);
                throw;
            }

        }
        internal double GetPaddyTotalAmountPaid(string CustId, YesNo yesNo)
        {
            try
            {
                IRepository<PaddyPaymentDetails> UsersRepository = new RepositoryImpl<PaddyPaymentDetails>(applicationSession);
                DetachedCriteria detachedCriteria =
                DetachedCriteria.For(typeof(PaddyPaymentDetails))
                                                                      .Add(Expression.Eq("CustID", CustId))
                                                                        .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) })))

                                                                        ;
                return UsersRepository.GetSumResultsAsDouble(detachedCriteria, "AmountPaid");
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetPaddyTotalAmountDue", ex);
                throw;
            }

        }
        internal double GetPaddyTotalAmount(string CustId, string SellerId, YesNo yesNo)
        {
            try
            {
                IRepository<PaddyStockInfo> UsersRepository = new RepositoryImpl<PaddyStockInfo>(applicationSession);
                DetachedCriteria detachedCriteria =
                DetachedCriteria.For(typeof(PaddyStockInfo))
                                                                      .Add(Expression.Eq("CustID", CustId))
                                                                      .Add(Expression.Eq("SellerID", SellerId))
                                                                        .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) })))

                                                                        ;
                return UsersRepository.GetMultiplySumResultsAsDouble(detachedCriteria, "Price", "TotalBags");
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetPaddyTotalAmount", ex);
                throw;
            }

        }
        internal double GetPaddyTotalAmountPaid(string CustId, string SellerId, YesNo yesNo)
        {
            try
            {
                IRepository<PaddyPaymentDetails> UsersRepository = new RepositoryImpl<PaddyPaymentDetails>(applicationSession);
                DetachedCriteria detachedCriteria =
                DetachedCriteria.For(typeof(PaddyPaymentDetails))
                                                                      .Add(Expression.Eq("CustID", CustId))
                                                                        .Add(Expression.Eq("SellerID", SellerId))
                                                                        .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) })))

                                                                        ;
                return UsersRepository.GetSumResultsAsDouble(detachedCriteria, "AmountPaid");
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetPaddyTotalAmountDue", ex);
                throw;
            }

        }
        #endregion


        #region Bag Stock Information
        internal int GetBagStockTotal(string CustId, YesNo yesNo)
        {
            try
            {
                IRepository<BagStockInfo> UsersRepository = new RepositoryImpl<BagStockInfo>(applicationSession);
                DetachedCriteria detachedCriteria =
                DetachedCriteria.For(typeof(BagStockInfo))
                                                                      .Add(Expression.Eq("CustID", CustId))
                                                                        .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) })))

                                                                        ;
                return UsersRepository.GetSumResults(detachedCriteria, "TotalBags");
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetBagStockTotal", ex);
                throw;
            }

        }
        internal int GetBagStockTotalUsed(string CustId, YesNo yesNo)
        {
            try
            {
                IRepository<HullingTransaction> UsersRepository = new RepositoryImpl<HullingTransaction>(applicationSession);
                DetachedCriteria detachedCriteria =
                DetachedCriteria.For(typeof(HullingTransaction))
                                                                      .Add(Expression.Eq("CustID", CustId))
                                                                        .Add(Restrictions.IsNotNull("MRiceBrandID"))
                                                                        .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) })))

                                                                        ;
                return UsersRepository.GetSumResults(detachedCriteria, "TotalBags");
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetBagStockTotalUsed", ex);
                throw;
            }

        }

        internal int GetBagStockTotal(string CustId, string UnitsTypeID, string RiceBrandId, YesNo yesNo)
        {

            try
            {
                IRepository<BagStockInfo> UsersRepository = new RepositoryImpl<BagStockInfo>(applicationSession);
                DetachedCriteria detachedCriteria =
                DetachedCriteria.For(typeof(BagStockInfo))
                                                                      .Add(Expression.Eq("CustID", CustId))
                                                                         .Add(Expression.Eq("UnitsTypeID", UnitsTypeID))
                                                                          .Add(Expression.Eq("MRiceBrandID", RiceBrandId))
                                                                        .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) })))

                                                                        ;
                return UsersRepository.GetSumResults(detachedCriteria, "TotalBags");
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetRiceProductTotal", ex);
                throw;
            }

        }

        internal int GetBagStockTotalUsed(string CustId, string UnitsTypeID, string RiceBrandId, YesNo yesNo)
        {
            try
            {
                IRepository<HullingTransaction> UsersRepository = new RepositoryImpl<HullingTransaction>(applicationSession);
                DetachedCriteria detachedCriteria =
                DetachedCriteria.For(typeof(ProductSellingInfo))
                                                                    .Add(Expression.Eq("CustID", CustId))
                                                                             .Add(Expression.Eq("UnitsTypeID", UnitsTypeID))
                                                                              .Add(Expression.Eq("MRiceBrandID", RiceBrandId))
                                                                            .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) })))

                                                                            ;

                ;
                return UsersRepository.GetSumResults(detachedCriteria, "TotalBags");
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetRiceProductUsedTotal", ex);
                throw;
            }
        }

        #endregion


        #region Product Amount Due
        internal double GetProductTotalAmount(string CustId, YesNo yesNo)
        {
            try
            {
                IRepository<ProductSellingInfo> UsersRepository = new RepositoryImpl<ProductSellingInfo>(applicationSession);
                DetachedCriteria detachedCriteria =
                DetachedCriteria.For(typeof(ProductSellingInfo))
                                                                      .Add(Expression.Eq("CustID", CustId))
                                                                        .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) })))

                                                                        ;
                return UsersRepository.GetMultiplySumResultsAsDouble(detachedCriteria, "Price", "TotalBags");
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetPaddyTotalAmountDue", ex);
                throw;
            }

        }
        internal double GetProductTotalAmountPaid(string CustId, YesNo yesNo)
        {
            try
            {
                IRepository<ProductPaymentTransaction> UsersRepository = new RepositoryImpl<ProductPaymentTransaction>(applicationSession);
                DetachedCriteria detachedCriteria =
                DetachedCriteria.For(typeof(ProductPaymentTransaction))
                                                                      .Add(Expression.Eq("CustID", CustId))
                                                                        .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) })))

                                                                        ;
                return UsersRepository.GetSumResultsAsDouble(detachedCriteria, "ReceivedAmount");
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetPaddyTotalAmountDue", ex);
                throw;
            }

        }
        internal double GetProductTotalAmount(string CustId, string BuyerID, YesNo yesNo)
        {
            try
            {
                IRepository<ProductSellingInfo> UsersRepository = new RepositoryImpl<ProductSellingInfo>(applicationSession);
                DetachedCriteria detachedCriteria =
                DetachedCriteria.For(typeof(ProductSellingInfo))
                                                                      .Add(Expression.Eq("CustID", CustId))
                                                                      .Add(Expression.Eq("BuyerID", BuyerID))
                                                                        .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) })))

                                                                        ;
                return UsersRepository.GetMultiplySumResultsAsDouble(detachedCriteria, "Price", "TotalBags");
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetPaddyTotalAmount", ex);
                throw;
            }

        }
        internal double GetProductTotalAmountPaid(string CustId, string BuyerID, YesNo yesNo)
        {
            try
            {
                IRepository<ProductPaymentTransaction> UsersRepository = new RepositoryImpl<ProductPaymentTransaction>(applicationSession);
                DetachedCriteria detachedCriteria =
                DetachedCriteria.For(typeof(ProductPaymentTransaction))
                                                                      .Add(Expression.Eq("CustID", CustId))
                                                                        .Add(Expression.Eq("BuyerID", BuyerID))
                                                                        .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) })))

                                                                        ;
                return UsersRepository.GetSumResultsAsDouble(detachedCriteria, "ReceivedAmount");
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetProductTotalAmountPaid", ex);
                throw;
            }

        }
        #endregion

        internal int GetPaddyStockEntityTotal(string CustId, string UnitsTypeID, string PaddyTypeID, YesNo yesNo)
        {
            try
            {
                IRepository<PaddyStockInfo> UsersRepository = new RepositoryImpl<PaddyStockInfo>(applicationSession);
                DetachedCriteria detachedCriteria =
                DetachedCriteria.For(typeof(PaddyStockInfo))
                                                                      .Add(Expression.Eq("CustID", CustId))
                                                                      .Add(Expression.Eq("UnitsTypeID", UnitsTypeID))
                                                                      .Add(Expression.Eq("PaddyTypeID", PaddyTypeID))
                                                                        .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) })))

                                                                        ;
                return UsersRepository.GetSumResults(detachedCriteria, "TotalBags");
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetPaddyStockEntityCount", ex);
                throw;
            }

        }
        internal int GetPaddyStockUsedTotal(string CustId, string UnitsTypeID, string PaddyTypeID, YesNo yesNo)
        {
            try
            {
                IRepository<HullingProcess> UsersRepository = new RepositoryImpl<HullingProcess>(applicationSession);
                DetachedCriteria detachedCriteria =
                DetachedCriteria.For(typeof(HullingProcess))
                                                                      .Add(Expression.Eq("CustID", CustId))
                                                                      .Add(Expression.Eq("UnitsTypeID", UnitsTypeID))
                                                                       .Add(Expression.Eq("PaddyTypeID", PaddyTypeID))
                                                                        .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) })));

                return UsersRepository.GetSumResults(detachedCriteria, "TotalBags");
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetPaddyStockUsedCount", ex);
                throw;
            }

        }
        internal int GetPaddyStockEntityTotal(string CustId, YesNo yesNo)
        {
            try
            {
                IRepository<PaddyStockInfo> UsersRepository = new RepositoryImpl<PaddyStockInfo>(applicationSession);
                DetachedCriteria detachedCriteria =
                DetachedCriteria.For(typeof(PaddyStockInfo))
                                                                      .Add(Expression.Eq("CustID", CustId))
                                                                        .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) })))

                                                                        ;
                return UsersRepository.GetSumResults(detachedCriteria, "TotalBags");
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetPaddyStockEntityCount", ex);
                throw;
            }

        }
        internal int GetPaddyStockUsedTotal(string CustId, YesNo yesNo)
        {
            try
            {
                IRepository<HullingProcess> UsersRepository = new RepositoryImpl<HullingProcess>(applicationSession);
                DetachedCriteria detachedCriteria =
                DetachedCriteria.For(typeof(HullingProcess))
                                                                      .Add(Expression.Eq("CustID", CustId))
                                                                        .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) })));

                return UsersRepository.GetSumResults(detachedCriteria, "TotalBags");
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetPaddyStockUsedCount", ex);
                throw;
            }

        }
        internal int GetPaddyStockEntityCount(string CustId, YesNo yesNo)
        {
            try
            {
                IRepository<PaddyStockInfo> UsersRepository = new RepositoryImpl<PaddyStockInfo>(applicationSession);
                DetachedCriteria detachedCriteria =
                DetachedCriteria.For(typeof(PaddyStockInfo))
                                                                      .Add(Expression.Eq("CustID", CustId))
                                                                        .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) })))

                                                                        ;
                return UsersRepository.GetCountUsingFuture(detachedCriteria);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetPaddyStockEntityCount", ex);
                throw;
            }

        }


        internal int GetPaddyStockUsedCount(string CustId, YesNo yesNo)
        {
            try
            {
                IRepository<HullingProcess> UsersRepository = new RepositoryImpl<HullingProcess>(applicationSession);
                DetachedCriteria detachedCriteria =
                DetachedCriteria.For(typeof(HullingProcess))
                                                                      .Add(Expression.Eq("CustID", CustId))
                                                                        .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) })));

                return UsersRepository.GetCountUsingFuture(detachedCriteria);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetPaddyStockUsedCount", ex);
                throw;
            }

        }





        internal List<MPaddyTypeEntity> GetMPaddyTypeEntities(string CustId, int pageindex, int pageSize, out int count, SortExpression expression, YesNo yesNo)
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
                                                                      ).AddOrder(Order.Asc("Name"));
                else
                    detachedCriteria = DetachedCriteria.For(typeof(MPaddyType))
                                                                   .Add(Expression.Eq("CustID", CustId))
                                                                     .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) }))
                                                                   ).AddOrder(Order.Desc("Name"));


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
        internal List<PaddyStockInfoEntity> GetPaddyStockInfoEntity(string CustId, int pageindex, int pageSize, out int count, SortExpression expression, YesNo yesNo)
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
                                                                   .Add(Expression.Eq("CustID", CustId))
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
        internal SellerInfoEntity GetSellerInfoEntity(string CustId, string SellerID, YesNo yesNo)
        {
            SellerInfoEntity sellerInfoEntity = new SellerInfoEntity();

            try
            {
                IRepository<SellerInfo> SellerInfoRepository = new RepositoryImpl<SellerInfo>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(SellerInfo))
                                                                   .Add(Expression.Eq("CustID", CustId))
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


            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetSellerInfoEntity", ex);
                throw;
            }
            return sellerInfoEntity;
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
        internal MUserTypeEntity GetMUserTypeEntity(string UserTypeID, YesNo yesNo)
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
        internal UsersEntity GetUsersEntity(string Username, string custId, YesNo yesNo)
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
        internal List<RMUserRoleEntity> GetUserRoles(string userId, YesNo yesNo)
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
        internal UsersEntity GetUsersEntity(string UserID, YesNo yesNo)
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
        internal MPaddyTypeEntity GetMPaddyTypeEntity(string PaddyTypeID, YesNo yesNo)
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
        internal PaddyStockInfoEntity GetPaddyStockInfoEntity(string PaddyStockID, YesNo yesNo)
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
        internal BagStockInfoEntity GetBagStockInfoEntity(string BagStockID, YesNo yesNo)
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
        internal MLotDetailsEntity GetMLotDetailsEntity(string MLotID, YesNo yesNo)
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
        internal MGodownDetailsEntity GetMGodownDetailsEntity(string MGodownID, YesNo yesNo)
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
        internal List<MGodownDetailsEntity> GetAllMGodownDetailsEntity(string custId, YesNo yesNo)
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
        internal PaddyPaymentDetailsEntity GetPaddyPaymentDetailsEntity(string PaddyPaymentID, YesNo yesNo)
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
        internal CustomerAddressInfoEntity GetCustomerAddressInfoEntity(string CustAdrsID, YesNo yesNo)
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
        internal CustomerActivationEntity GetCustomerActivationEntity(string CustActiveID, YesNo yesNo)
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
        internal CustTrailUsageEntity GetCustTrailUsageEntity(string CustTrailID, YesNo yesNo)
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
        internal CustomerPaymentEntity GetCustomerPaymentEntity(string CustPaymentID, YesNo yesNo)
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
        internal CustomerPartPayDetailsEntity GetCustomerPartPayDetailsEntity(string CustPartPayID, YesNo yesNo)
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
        internal MDrierTypeDetailsEntity GetMDrierTypeDetailsEntity(string MDrierTypeID, YesNo yesNo)
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
        internal MRiceProductionTypeEntity GetMRiceProductionTypeEntity(string MRiceProdTypeID, YesNo yesNo)
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
        internal List<MRiceProductionTypeEntity> GetMRiceProductionTypeEntities(string custID, YesNo yesNo)
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
        internal MRiceBrandDetailsEntity GetMRiceBrandDetailsEntity(string MRiceBrandID, YesNo yesNo)
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
        internal List<MRiceBrandDetailsEntity> GetMRiceBrandDetailsEntities(string custId, YesNo yesNo)
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
        internal List<RiceStockInfoEntity> GetAllRiceStockInfoEntities(string CustId, YesNo yesNo)
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
        internal List<BrokenRiceStockInfoEntity> GetAllBrokenRiceStockInfoEntities(string CustId, YesNo yesNo)
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
        internal List<DustStockInfoEntity> GetAllDustStockInfoEntities(string CustId, YesNo yesNo)
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
        internal List<MenuConfigurationEntity> GetMenuConfigurationEntities(string CustId, YesNo yesNo)
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

        internal List<ProductSellingInfoEntity> GetAllProductSellingInfoEntities(string CustId, YesNo yesNo)
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
        internal List<HullingProcessEntity> GetHullingProcessInfoEntities(string CustId, YesNo yesNo)
        {
            try
            {
                List<HullingProcessEntity> listHullingProcessEntity = new List<HullingProcessEntity>();
                IRepository<HullingProcess> UsersRepository = new RepositoryImpl<HullingProcess>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(HullingProcess))
                                                                   .Add(Expression.Eq("CustID", CustId))
                                                                   .Add(Expression.Eq("Status", "P"))
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
        internal List<HullingProcessTransactionEntity> GetHullingProcessTransInfoEntities(string CustId, YesNo yesNo)
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
        internal List<HullingProcessExpensesEntity> GetHullingProcessExpensesEntities(string CustId, YesNo yesNo)
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
        internal List<BuyerSellerRatingEntity> GetAllBuyerSellerRatingEntities(string CustId, YesNo yesNo)
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
        //internal List<BuyerInfoEntity> GetBuyerInfoEntities(string custId, YesNo yesNo)
        //{
        //    try
        //    {
        //        List<BuyerInfoEntity> ListBuyerInfoEntity = new List<BuyerInfoEntity>();
        //        IRepository<BuyerInfo> BuyerTypeRepository = new RepositoryImpl<BuyerInfo>(applicationSession);
        //        DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(BuyerInfo))
        //                                                           .Add(Expression.Eq("CustID", custId))
        //         .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) })));
        //        List<BuyerInfo> listBuyerInfo = BuyerTypeRepository.GetAll(detachedCriteria) as List<BuyerInfo>;
        //        if (listBuyerInfo != null && listBuyerInfo.Count > 0)
        //        {
        //            foreach (BuyerInfo adMInfo in listBuyerInfo)
        //            {
        //                ListBuyerInfoEntity.Add(RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetBuyerInfoEntity(adMInfo));
        //            }
        //        }
        //        else
        //            ListBuyerInfoEntity = null;

        //        return ListBuyerInfoEntity;
        //    }
        //    catch (Exception ex)
        //    {
        //        Logger.Error("Error encountered at GetBuyerInfoEntities", ex);
        //        throw;
        //    }
        //}
        internal List<MEmployeeDesignationEntity> GetMEmployeeDesignationEntities(string custId, YesNo yesNo)
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
        internal List<MSalaryTypeEntity> GetMSalaryTypeEntities(string custId, YesNo yesNo)
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
        internal List<EmployeeDetailsEntity> GetEmployeeDetailsEntities(string custId, YesNo yesNo)
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
        internal List<EmployeeSalaryEntity> GetEmployeeSalaryEntities(string custId, YesNo yesNo)
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
        internal EmployeeDetailsEntity GetEmployeeDetailsEntity(string custId, string EmployeeID, YesNo yesNo)
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
        internal MEmployeeDesignationEntity GetMEmployeeDesignationEntity(string custId, string DesignationID, YesNo yesNo)
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
        internal MSalaryTypeEntity GetListMSalaryTypeEntity(string custId, string SalaryTypeId, YesNo yesNo)
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
        internal EmployeeSalaryEntity GetEmployeeSalaryEntity(string custId, string EmployeeID, YesNo yesNo)
        {
            try
            {
                EmployeeSalaryEntity EmployeeSalaryEntity = new EmployeeSalaryEntity();
                IRepository<EmployeeSalary> UsersRepository = new RepositoryImpl<EmployeeSalary>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(EmployeeSalary))
                                                                   .Add(Expression.Eq("EmployeeID", EmployeeID))
                                                                   .Add(Expression.Eq("CustID", custId))
                                                                     .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) }))
                                                                   );
                List<EmployeeSalary> listEmployeeSalaryEntity = UsersRepository.GetAll(detachedCriteria) as List<EmployeeSalary>;
                if (listEmployeeSalaryEntity != null && listEmployeeSalaryEntity.Count > 0)
                {
                    foreach (EmployeeSalary adMInfo in listEmployeeSalaryEntity)
                    {
                        EmployeeSalaryEntity = RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetEmployeeSalaryEntity(adMInfo);
                    }
                }
                else
                    EmployeeSalaryEntity = null;

                return EmployeeSalaryEntity;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetEmployeeSalaryEntity", ex);
                throw;
            }
        }
        internal List<EmployeeSalaryPaymentEntity> GetEmployeeSalaryPaymentEntities(string custId, YesNo yesNo)
        {
            try
            {
                List<EmployeeSalaryPaymentEntity> ListEmployeeSalaryPaymentEntity = new List<EmployeeSalaryPaymentEntity>();
                IRepository<MoneyTransaction> EmployeeSalaryRepository = new RepositoryImpl<MoneyTransaction>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(MoneyTransaction))
                                                                   .Add(Expression.Eq("CustID", custId))
                                                                     .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) })));
                List<MoneyTransaction> listEmployeeSalaryPayment = EmployeeSalaryRepository.GetAll(detachedCriteria) as List<MoneyTransaction>;
                if (listEmployeeSalaryPayment != null && listEmployeeSalaryPayment.Count > 0)
                {
                    foreach (MoneyTransaction adMInfo in listEmployeeSalaryPayment)
                    {
                        ListEmployeeSalaryPaymentEntity.Add(RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetEmployeeSalaryPaymentEntity(adMInfo));
                    }
                }
                else
                    ListEmployeeSalaryPaymentEntity = null;

                return ListEmployeeSalaryPaymentEntity;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetEmployeeSalaryPaymentEntities", ex);
                throw;
            }
        }
        internal List<EmployeeSalaryPaymentEntity> GetSalaryPaymentOnEmployee(string custId, string EmployeeID, YesNo yesNo)
        {
            try
            {
                List<EmployeeSalaryPaymentEntity> ListEmployeeSalaryPaymentEntity = new List<EmployeeSalaryPaymentEntity>();
                IRepository<MoneyTransaction> EmployeeSalaryRepository = new RepositoryImpl<MoneyTransaction>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(MoneyTransaction))
                                                                   .Add(Expression.Eq("CustID", custId))
                                                                   .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) })));
                List<MoneyTransaction> listEmployeeSalaryPayment = EmployeeSalaryRepository.GetAll(detachedCriteria) as List<MoneyTransaction>;
                if (listEmployeeSalaryPayment != null && listEmployeeSalaryPayment.Count > 0)
                {
                    foreach (MoneyTransaction adMInfo in listEmployeeSalaryPayment)
                    {
                        ListEmployeeSalaryPaymentEntity.Add(RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetEmployeeSalaryPaymentEntity(adMInfo));
                    }
                }
                else
                    ListEmployeeSalaryPaymentEntity = null;

                return ListEmployeeSalaryPaymentEntity;
                //.Add(Expression.Eq("EmployeeID", EmployeeID))
                //.Add(Expression.Between("PaymentDate",DateTime.Now.AddDays(-(DateTime.Now.Day-1)),  DateTime.Now.AddDays(-(DateTime.Now.Day-1)).AddDays(DateTime.DaysInMonth(DateTime.Now.Year,DateTime.Now.Month))))

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetEmployeeSalaryPaymentEntities", ex);
                throw;
            }
        }
        internal List<OtherExpensesEntity> GetOtherExpensesEntities(string custId, YesNo yesNo)
        {
            try
            {
                List<OtherExpensesEntity> ListOtherExpensesEntity = new List<OtherExpensesEntity>();
                IRepository<MoneyTransaction> MoneyTransactionRepository = new RepositoryImpl<MoneyTransaction>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(MoneyTransaction))
                                                                   .Add(Expression.Eq("CustID", custId))
                                                                   .Add(Expression.Between("PaymentDate", DateTime.Now.AddDays(-(DateTime.Now.Day - 1)), DateTime.Now.AddDays(-(DateTime.Now.Day - 1)).AddDays(DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month))))
                                                                   .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) })));

                List<MoneyTransaction> listMoneyTransaction = MoneyTransactionRepository.GetAll(detachedCriteria) as List<MoneyTransaction>;
                if (listMoneyTransaction != null && listMoneyTransaction.Count > 0)
                {
                    foreach (MoneyTransaction adMInfo in listMoneyTransaction)
                        ListOtherExpensesEntity.Add(RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetOtherExpensesEntity(adMInfo));

                }
                else
                    ListOtherExpensesEntity = null;

                return ListOtherExpensesEntity;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetOtherExpensesEntities", ex);
                throw;
            }
        }
        internal List<ProductPaymentInfoEntity> GetAllProductPaymentInfoEntities(string CustId, YesNo yesNo)
        {
            try
            {
                List<ProductPaymentInfoEntity> listProductPaymentInfoEntity = new List<ProductPaymentInfoEntity>();
                IRepository<ProductPaymentInfo> UsersRepository = new RepositoryImpl<ProductPaymentInfo>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(ProductPaymentInfo))
                                                                   .Add(Expression.Eq("CustID", CustId))
                                                                   .Add(Expression.Eq("Status", "P"))
                                                                   .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) }))
                                                                   );
                List<ProductPaymentInfo> listProductPaymentInfo = UsersRepository.GetAll(detachedCriteria) as List<ProductPaymentInfo>;
                if (listProductPaymentInfo != null && listProductPaymentInfo.Count > 0)
                {
                    foreach (ProductPaymentInfo adMInfo in listProductPaymentInfo)
                    {
                        listProductPaymentInfoEntity.Add(RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetProductPaymentInfoEntity(adMInfo));
                    }
                }
                else
                    listProductPaymentInfoEntity = null;

                return listProductPaymentInfoEntity;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetProductPaymentInfoEntities", ex);
                throw;
            }
        }
        internal List<ProductPaymentTransactionEntity> GetAllProductPaymentTranEntities(string CustId, YesNo yesNo)
        {
            try
            {
                List<ProductPaymentTransactionEntity> listProdPayTranEnt = new List<ProductPaymentTransactionEntity>();
                IRepository<ProductPaymentTransaction> UsersRepository = new RepositoryImpl<ProductPaymentTransaction>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(ProductPaymentTransaction))
                                                                   .Add(Expression.Eq("CustID", CustId))
                                                                     .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) }))
                                                                   );
                List<ProductPaymentTransaction> listProdPayTran = UsersRepository.GetAll(detachedCriteria) as List<ProductPaymentTransaction>;
                if (listProdPayTran != null && listProdPayTran.Count > 0)
                {
                    foreach (ProductPaymentTransaction adMInfo in listProdPayTran)
                    {
                        listProdPayTranEnt.Add(RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetProductPaymentTranEntity(adMInfo));
                    }
                }
                else
                    listProdPayTranEnt = null;

                return listProdPayTranEnt;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetAllProductPaymentTranEntities", ex);
                throw;
            }
        }
        internal List<PaddyStockInfoEntity> GetAllPaddyStockInfoEntities(string CustId, string PaddyTypeID, string UnitTypeID, string GodownID, string LotID, YesNo yesNo)
        {
            try
            {
                List<PaddyStockInfoEntity> listPaddyStockInfoEntity = new List<PaddyStockInfoEntity>();
                IRepository<PaddyStockInfo> UsersRepository = new RepositoryImpl<PaddyStockInfo>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(PaddyStockInfo))
                                                                   .Add(Expression.Eq("CustID", CustId))
                                                                   .Add(Expression.Eq("PaddyTypeID", PaddyTypeID))
                                                                   .Add(Expression.Eq("UnitsTypeID", UnitTypeID))
                                                                   .Add(Expression.Eq("MGodownID", GodownID))
                                                                   .Add(Expression.Eq("MLotID", LotID))
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
                Logger.Error("Error encountered at GetAllPaddyStockInfoEntities", ex);
                throw;
            }
        }


        #endregion

        #region Check Data Exist
        internal List<MPaddyTypeEntity> CheckPaddyTypeExist(string CustId, string paddytype, YesNo yesNo)
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
        internal MGodownDetailsEntity CheckGodownNameExist(string custId, string GodownName, YesNo yesNo)
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
        internal MUnitsTypeEntity CheckUnitTypeExist(string custId, string UnitsType, YesNo yesNo)
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
                Logger.Error("Error encountered at GetUnitTypeExist", ex);
                throw;
            }
        }
        internal MLotDetailsEntity CheckLotNameExist(string custId, string LotName, YesNo yesNo)
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
        internal MEmployeeDesignationEntity CheckEmpDesigExist(string custId, string DesignationType, YesNo yesNo)
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
        internal MSalaryTypeEntity CheckSalaryTypeExist(string custId, string SalaryType, YesNo yesNo)
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
        internal EmployeeDetailsEntity CheckEmployeeExist(string custId, string EmployeeName, YesNo yesNo)
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
        internal EmployeeSalaryEntity CheckEmployeeSalaryExist(string custId, string EmployeeID, YesNo yesNo)
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



        internal List<HullingProcessEntity> GetAllHullingProcessPaddyStock(string CustId, string PaddyTypeID, string UnitTypeID, string GodownID, string LotID, YesNo yesNo)
        {
            try
            {
                List<HullingProcessEntity> listHullingProcessEntity = new List<HullingProcessEntity>();
                IRepository<HullingProcess> UsersRepository = new RepositoryImpl<HullingProcess>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(HullingProcess))
                                                                   .Add(Expression.Eq("CustID", CustId))
                                                                   .Add(Expression.Eq("PaddyTypeID", PaddyTypeID))
                                                                   .Add(Expression.Eq("UnitsTypeID", UnitTypeID))
                                                                   .Add(Expression.Eq("MGodownID", GodownID))
                                                                   .Add(Expression.Eq("MLotID", LotID))
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
                Logger.Error("Error encountered at GetAllHullingProcessPaddyStock", ex);
                throw;
            }
        }

        internal HullingProcessEntity GetHullingProcessEntity(string CustId, string HullingProcessID, YesNo yesNo)
        {
            try
            {
                HullingProcessEntity HullingProcessEntity = new HullingProcessEntity();
                IRepository<HullingProcess> UsersRepository = new RepositoryImpl<HullingProcess>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(HullingProcess))
                                                                   .Add(Expression.Eq("CustID", CustId))
                                                                   .Add(Expression.Eq("HullingProcessID", HullingProcessID))
                                                                   .Add(Expression.Eq("Status", "P"))
                                                                     .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) }))
                                                                   );
                List<HullingProcess> listHullingProcessEntity = UsersRepository.GetAll(detachedCriteria) as List<HullingProcess>;
                if (listHullingProcessEntity != null && listHullingProcessEntity.Count > 0)
                {
                    foreach (HullingProcess adMInfo in listHullingProcessEntity)
                    {
                        HullingProcessEntity = RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetHullingProcessInfoEntity(adMInfo);
                    }
                }
                else
                    HullingProcessEntity = null;

                return HullingProcessEntity;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetHullingProcessEntity", ex);
                throw;
            }
        }

        internal List<BuyerInfoEntity> GetListBuyerInfoEntities(string CustId, YesNo yesNo)
        {
            try
            {
                List<BuyerInfoEntity> ListBuyerInfoEntity = new List<BuyerInfoEntity>();
                IRepository<BuyerInfo> BuyerInfoRepository = new RepositoryImpl<BuyerInfo>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(BuyerInfo))
                                                                   .Add(Expression.Eq("CustID", CustId))
                                                                     .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) }))
                                                                   );
                List<BuyerInfo> listBuyerInfo = BuyerInfoRepository.GetAll(detachedCriteria) as List<BuyerInfo>;
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
        internal List<MUnitsTypeEntity> GetMUnitsTypeEntities(string custId, YesNo yesNo)
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

        internal List<MUnitsTypeEntity> GetMUnitsTypeEntities(string CustId, int pageindex, int pageSize, out int count, SortExpression expression, YesNo yesNo)
        {
            try
            {
                List<MUnitsTypeEntity> listMUnitsTypeEntity = new List<MUnitsTypeEntity>();
                IRepository<MUnitsType> UsersRepository = new RepositoryImpl<MUnitsType>(applicationSession);
                DetachedCriteria detachedCriteria = null;
                if (expression == SortExpression.Desc)
                    detachedCriteria = DetachedCriteria.For(typeof(MUnitsType))
                                                                      .Add(Expression.Eq("CustID", CustId))
                                                                        .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) }))
                                                                      ).AddOrder(Order.Asc("UnitsType"));
                else
                    detachedCriteria = DetachedCriteria.For(typeof(MUnitsType))
                                                                   .Add(Expression.Eq("CustID", CustId))
                                                                     .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) }))
                                                                   ).AddOrder(Order.Desc("UnitsType"));


                List<MUnitsType> listMUnitsType = UsersRepository.GetAllWithPagingMultiCriteria(detachedCriteria, pageindex, pageSize, out count) as List<MUnitsType>;
                if (listMUnitsType != null && listMUnitsType.Count > 0)
                {
                    foreach (MUnitsType adMInfo in listMUnitsType)
                    {
                        listMUnitsTypeEntity.Add(RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetMUnitsTypeEntity(adMInfo));
                    }
                }
                else
                    listMUnitsTypeEntity = null;

                return listMUnitsTypeEntity;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMUnitsTypeEntities", ex);
                throw;
            }
        }

        internal List<MGodownDetailsEntity> GetMGodownDetailsEntities(string CustId, int PageIndex, int PageSize, out int count, SortExpression expression, YesNo yesNo)
        {
            try
            {
                List<MGodownDetailsEntity> listMGodownDetailsEntity = new List<MGodownDetailsEntity>();
                IRepository<MGodownDetails> UsersRepository = new RepositoryImpl<MGodownDetails>(applicationSession);
                DetachedCriteria detachedCriteria = null;
                if (expression == SortExpression.Desc)
                    detachedCriteria = DetachedCriteria.For(typeof(MGodownDetails))
                                                                      .Add(Expression.Eq("CustID", CustId))
                                                                        .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) }))
                                                                      ).AddOrder(Order.Asc("Name"));
                else
                    detachedCriteria = DetachedCriteria.For(typeof(MGodownDetails))
                                                                   .Add(Expression.Eq("CustID", CustId))
                                                                     .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) }))
                                                                   ).AddOrder(Order.Desc("Name"));


                List<MGodownDetails> listMGodownDetails = UsersRepository.GetAllWithPagingMultiCriteria(detachedCriteria, PageIndex, PageSize, out count) as List<MGodownDetails>;
                if (listMGodownDetails != null && listMGodownDetails.Count > 0)
                {
                    foreach (MGodownDetails adMInfo in listMGodownDetails)
                    {
                        listMGodownDetailsEntity.Add(RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetMGodownDetailsEntity(adMInfo));
                    }
                }
                else
                    listMGodownDetailsEntity = null;

                return listMGodownDetailsEntity;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMGodownDetailsEntities", ex);
                throw;
            }
        }

        internal List<MLotDetailsEntity> GetMLotDetailsEntities(string CustId, string GodownID, int PageIndex, int PageSize, out int count, SortExpression expression, YesNo yesNo)
        {
            try
            {
                List<MLotDetailsEntity> listMLotDetailsEntity = new List<MLotDetailsEntity>();
                IRepository<MLotDetails> UsersRepository = new RepositoryImpl<MLotDetails>(applicationSession);
                DetachedCriteria detachedCriteria = null;
                if (expression == SortExpression.Desc)
                    detachedCriteria = DetachedCriteria.For(typeof(MLotDetails))
                                                                      .Add(Expression.Eq("CustID", CustId))
                                                                        .Add(Expression.Eq("MGodownID", GodownID))
                                                                            .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) }))
                                                                      ).AddOrder(Order.Asc("LotName"));
                else
                    detachedCriteria = DetachedCriteria.For(typeof(MLotDetails))
                                                                   .Add(Expression.Eq("CustID", CustId))
                                                                   .Add(Expression.Eq("MGodownID", GodownID))
                                                                     .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) }))
                                                                   ).AddOrder(Order.Desc("LotName"));


                List<MLotDetails> listMLotDetails = UsersRepository.GetAllWithPagingMultiCriteria(detachedCriteria, PageIndex, PageSize, out count) as List<MLotDetails>;
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

        internal MBagTypeEntity GetMBagTypeEntity(string BagTypeID, YesNo yesNo)
        {
            try
            {
                MBagTypeEntity MBagTypeEntity = new MBagTypeEntity();
                IRepository<MBagType> UsersRepository = new RepositoryImpl<MBagType>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(MBagType))
                                                                   .Add(Expression.Eq("BagTypeID", BagTypeID))
                                                                     .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) }))
                                                                   );
                List<MBagType> listMBagTypeEntity = UsersRepository.GetAll(detachedCriteria) as List<MBagType>;
                if (listMBagTypeEntity != null && listMBagTypeEntity.Count > 0)
                {
                    foreach (MBagType adMInfo in listMBagTypeEntity)
                    {
                        MBagTypeEntity = RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetMBagTypeEntity(adMInfo);
                    }
                }
                else
                    MBagTypeEntity = null;

                return MBagTypeEntity;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMBagTypeEntity", ex);
                throw;
            }
        }

        internal List<MBagTypeEntity> GetMBagTypeEntities(string CustId, int PageIndex, int PageSize, out int count, SortExpression expression, YesNo yesNo)
        {
            try
            {
                List<MBagTypeEntity> listMBagTypeEntity = new List<MBagTypeEntity>();
                IRepository<MBagType> UsersRepository = new RepositoryImpl<MBagType>(applicationSession);
                DetachedCriteria detachedCriteria = null;
                if (expression == SortExpression.Desc)
                    detachedCriteria = DetachedCriteria.For(typeof(MBagType))
                                                                      .Add(Expression.Eq("CustID", CustId))
                                                                        .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) }))
                                                                      ).AddOrder(Order.Asc("BagType"));
                else
                    detachedCriteria = DetachedCriteria.For(typeof(MBagType))
                                                                   .Add(Expression.Eq("CustID", CustId))
                                                                     .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) }))
                                                                   ).AddOrder(Order.Desc("BagType"));


                List<MBagType> listMBagType = UsersRepository.GetAllWithPagingMultiCriteria(detachedCriteria, PageIndex, PageSize, out count) as List<MBagType>;
                if (listMBagType != null && listMBagType.Count > 0)
                {
                    foreach (MBagType adMInfo in listMBagType)
                    {
                        listMBagTypeEntity.Add(RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetMBagTypeEntity(adMInfo));
                    }
                }
                else
                    listMBagTypeEntity = null;

                return listMBagTypeEntity;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMBagTypeEntities", ex);
                throw;
            }
        }

        internal List<MRiceProductionTypeEntity> GetMRiceProductionTypeEntities(string CustId, int PageIndex, int PageSize, out int count, SortExpression expression, YesNo yesNo)
        {

            try
            {
                List<MRiceProductionTypeEntity> listMRiceTypeEntity = new List<MRiceProductionTypeEntity>();
                IRepository<MRiceProductionType> UsersRepository = new RepositoryImpl<MRiceProductionType>(applicationSession);
                DetachedCriteria detachedCriteria = null;
                if (expression == SortExpression.Desc)
                    detachedCriteria = DetachedCriteria.For(typeof(MRiceProductionType))
                                                                      .Add(Expression.Eq("CustID", CustId))
                                                                        .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) }))
                                                                      ).AddOrder(Order.Asc("RiceType"));
                else
                    detachedCriteria = DetachedCriteria.For(typeof(MRiceProductionType))
                                                                   .Add(Expression.Eq("CustID", CustId))
                                                                     .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) }))
                                                                   ).AddOrder(Order.Desc("RiceType"));


                List<MRiceProductionType> listMRiceType = UsersRepository.GetAllWithPagingMultiCriteria(detachedCriteria, PageIndex, PageSize, out count) as List<MRiceProductionType>;
                if (listMRiceType != null && listMRiceType.Count > 0)
                {
                    foreach (MRiceProductionType adMInfo in listMRiceType)
                    {
                        listMRiceTypeEntity.Add(RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetMRiceProductionTypeEntity(adMInfo));
                    }
                }
                else
                    listMRiceTypeEntity = null;

                return listMRiceTypeEntity;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMRiceProductionTypeEntities", ex);
                throw;
            }
        }

        internal List<MBrokenRiceTypeEntity> GetMBrokenRiceTypeEntities(string CustId, int PageIndex, int PageSize, out int count, SortExpression expression, YesNo yesNo)
        {
            try
            {
                List<MBrokenRiceTypeEntity> listMBrokenRiceTypeEntity = new List<MBrokenRiceTypeEntity>();
                IRepository<MBrokenRiceType> UsersRepository = new RepositoryImpl<MBrokenRiceType>(applicationSession);
                DetachedCriteria detachedCriteria = null;
                if (expression == SortExpression.Desc)
                    detachedCriteria = DetachedCriteria.For(typeof(MBrokenRiceType))
                                                                      .Add(Expression.Eq("CustID", CustId))
                                                                        .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) }))
                                                                      ).AddOrder(Order.Asc("BrokenRiceName"));
                else
                    detachedCriteria = DetachedCriteria.For(typeof(MBrokenRiceType))
                                                                   .Add(Expression.Eq("CustID", CustId))
                                                                     .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) }))
                                                                   ).AddOrder(Order.Desc("BrokenRiceName"));


                List<MBrokenRiceType> listMBrokenRiceType = UsersRepository.GetAllWithPagingMultiCriteria(detachedCriteria, PageIndex, PageSize, out count) as List<MBrokenRiceType>;
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

        internal MBrokenRiceTypeEntity GetMBrokenRiceTypeEntity(string BrokenRiceTypeID, YesNo yesNo)
        {

            try
            {
                MBrokenRiceTypeEntity mBrokenRiceTypeEntity = new MBrokenRiceTypeEntity();
                IRepository<MBrokenRiceType> UsersRepository = new RepositoryImpl<MBrokenRiceType>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(MBrokenRiceType))
                                                                   .Add(Expression.Eq("BrokenRiceTypeID", BrokenRiceTypeID))
                                                                     .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) }))
                                                                   );
                List<MBrokenRiceType> listMBrokenRiceTypeEntity = UsersRepository.GetAll(detachedCriteria) as List<MBrokenRiceType>;
                if (listMBrokenRiceTypeEntity != null && listMBrokenRiceTypeEntity.Count > 0)
                {
                    foreach (MBrokenRiceType adMInfo in listMBrokenRiceTypeEntity)
                    {
                        mBrokenRiceTypeEntity = RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetMBrokenRiceTypeEntity(adMInfo);
                    }
                }
                else
                    mBrokenRiceTypeEntity = null;

                return mBrokenRiceTypeEntity;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMBrokenRiceTypeEntity", ex);
                throw;
            }
        }

        internal List<MRiceBrandDetailsEntity> GetMRiceBrandDetailsEntities(string CustId, int PageIndex, int PageSize, out int count, SortExpression expression, YesNo yesNo)
        {
            try
            {
                List<MRiceBrandDetailsEntity> listMRiceBrandEntity = new List<MRiceBrandDetailsEntity>();
                IRepository<MRiceBrandDetails> UsersRepository = new RepositoryImpl<MRiceBrandDetails>(applicationSession);
                DetachedCriteria detachedCriteria = null;
                if (expression == SortExpression.Desc)
                    detachedCriteria = DetachedCriteria.For(typeof(MRiceBrandDetails))
                                                                      .Add(Expression.Eq("CustID", CustId))
                                                                        .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) }))
                                                                      ).AddOrder(Order.Asc("Name"));
                else
                    detachedCriteria = DetachedCriteria.For(typeof(MRiceBrandDetails))
                                                                   .Add(Expression.Eq("CustID", CustId))
                                                                     .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) }))
                                                                   ).AddOrder(Order.Desc("Name"));


                List<MRiceBrandDetails> listMRiceBrand = UsersRepository.GetAllWithPagingMultiCriteria(detachedCriteria, PageIndex, PageSize, out count) as List<MRiceBrandDetails>;
                if (listMRiceBrand != null && listMRiceBrand.Count > 0)
                {
                    foreach (MRiceBrandDetails adMInfo in listMRiceBrand)
                    {
                        listMRiceBrandEntity.Add(RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetMRiceBrandDetailsEntity(adMInfo));
                    }
                }
                else
                    listMRiceBrandEntity = null;

                return listMRiceBrandEntity;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMRiceBrandDetailsEntities", ex);
                throw;
            }
        }

        internal MEmployeeDesignationEntity GetMEmployeeDesignationEntity(string EmpDesigID, YesNo yesNo)
        {
            try
            {
                MEmployeeDesignationEntity mEmpDesigEntity = new MEmployeeDesignationEntity();
                IRepository<MEmployeeDesignation> UsersRepository = new RepositoryImpl<MEmployeeDesignation>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(MEmployeeDesignation))
                                                                   .Add(Expression.Eq("MEmpDsgID", EmpDesigID))
                                                                     .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) }))
                                                                   );
                List<MEmployeeDesignation> listMEmployeeDesignationEntity = UsersRepository.GetAll(detachedCriteria) as List<MEmployeeDesignation>;
                if (listMEmployeeDesignationEntity != null && listMEmployeeDesignationEntity.Count > 0)
                {
                    foreach (MEmployeeDesignation adMInfo in listMEmployeeDesignationEntity)
                    {
                        mEmpDesigEntity = RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetMEmployeeDesignationEntity(adMInfo);
                    }
                }
                else
                    mEmpDesigEntity = null;

                return mEmpDesigEntity;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMEmployeeDesignationEntity", ex);
                throw;
            }
        }

        internal List<MEmployeeDesignationEntity> GetMEmployeeDesignationEntities(string CustId, int PageIndex, int PageSize, out int count, SortExpression expression, YesNo yesNo)
        {
            try
            {
                List<MEmployeeDesignationEntity> listMEmpDesigEntity = new List<MEmployeeDesignationEntity>();
                IRepository<MEmployeeDesignation> UsersRepository = new RepositoryImpl<MEmployeeDesignation>(applicationSession);
                DetachedCriteria detachedCriteria = null;
                if (expression == SortExpression.Desc)
                    detachedCriteria = DetachedCriteria.For(typeof(MEmployeeDesignation))
                                                                      .Add(Expression.Eq("CustID", CustId))
                                                                        .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) }))
                                                                      ).AddOrder(Order.Asc("DesignationType"));
                else
                    detachedCriteria = DetachedCriteria.For(typeof(MEmployeeDesignation))
                                                                   .Add(Expression.Eq("CustID", CustId))
                                                                     .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) }))
                                                                   ).AddOrder(Order.Desc("DesignationType"));


                List<MEmployeeDesignation> listMEmpDesigBrand = UsersRepository.GetAllWithPagingMultiCriteria(detachedCriteria, PageIndex, PageSize, out count) as List<MEmployeeDesignation>;
                if (listMEmpDesigBrand != null && listMEmpDesigBrand.Count > 0)
                {
                    foreach (MEmployeeDesignation adMInfo in listMEmpDesigBrand)
                    {
                        listMEmpDesigEntity.Add(RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetMEmployeeDesignationEntity(adMInfo));
                    }
                }
                else
                    listMEmpDesigEntity = null;

                return listMEmpDesigEntity;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMEmployeeDesignationEntities", ex);
                throw;
            }
        }

        internal MSalaryTypeEntity GetMSalaryTypeEntity(string SalaryTypeID, YesNo yesNo)
        {
            try
            {
                MSalaryTypeEntity mSalaryTypeEntity = new MSalaryTypeEntity();
                IRepository<MSalaryType> UsersRepository = new RepositoryImpl<MSalaryType>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(MSalaryType))
                                                                   .Add(Expression.Eq("MSalaryTypeID", SalaryTypeID))
                                                                     .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) }))
                                                                   );
                List<MSalaryType> listMSalaryTypeEntity = UsersRepository.GetAll(detachedCriteria) as List<MSalaryType>;
                if (listMSalaryTypeEntity != null && listMSalaryTypeEntity.Count > 0)
                {
                    foreach (MSalaryType adMInfo in listMSalaryTypeEntity)
                    {
                        mSalaryTypeEntity = RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetMSalaryTypeEntity(adMInfo);
                    }
                }
                else
                    mSalaryTypeEntity = null;

                return mSalaryTypeEntity;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMSalaryTypeEntity", ex);
                throw;
            }
        }

        internal List<MSalaryTypeEntity> GetListMSalaryTypeEntities(string CustId, int PageIndex, int PageSize, out int count, SortExpression expression, YesNo yesNo)
        {
            try
            {
                List<MSalaryTypeEntity> listMSalaryTpyeEntity = new List<MSalaryTypeEntity>();
                IRepository<MSalaryType> UsersRepository = new RepositoryImpl<MSalaryType>(applicationSession);
                DetachedCriteria detachedCriteria = null;
                if (expression == SortExpression.Desc)
                    detachedCriteria = DetachedCriteria.For(typeof(MSalaryType))
                                                                      .Add(Expression.Eq("CustID", CustId))
                                                                        .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) }))
                                                                      ).AddOrder(Order.Asc("Salarytype"));
                else
                    detachedCriteria = DetachedCriteria.For(typeof(MSalaryType))
                                                                   .Add(Expression.Eq("CustID", CustId))
                                                                     .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) }))
                                                                   ).AddOrder(Order.Desc("Salarytype"));


                List<MSalaryType> listMSalaryType = UsersRepository.GetAllWithPagingMultiCriteria(detachedCriteria, PageIndex, PageSize, out count) as List<MSalaryType>;
                if (listMSalaryType != null && listMSalaryType.Count > 0)
                {
                    foreach (MSalaryType adMInfo in listMSalaryType)
                    {
                        listMSalaryTpyeEntity.Add(RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetMSalaryTypeEntity(adMInfo));
                    }
                }
                else
                    listMSalaryTpyeEntity = null;

                return listMSalaryTpyeEntity;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMSalaryTypeEntities", ex);
                throw;
            }
        }

        internal MBagTypeEntity GetMBagTypeEntity(string CustId, string BagType, YesNo yesNo)
        {

            try
            {
                MBagTypeEntity MBagTypeEntity = new MBagTypeEntity();
                IRepository<MBagType> unitsTypeRepository = new RepositoryImpl<MBagType>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(MBagType))
                                                                   .Add(Expression.Eq("BagType", BagType))
                                                                   .Add(Expression.Eq("CustID", CustId))
                                                                     .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) })));
                List<MBagType> listMBagType = unitsTypeRepository.GetAll(detachedCriteria) as List<MBagType>;
                if (listMBagType != null && listMBagType.Count > 0)
                {
                    foreach (MBagType adMInfo in listMBagType)
                    {
                        MBagTypeEntity = (RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetMBagTypeEntity(adMInfo));
                        break;
                    }
                }
                else
                    MBagTypeEntity = null;

                return MBagTypeEntity;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMBagTypeEntity", ex);
                throw;
            }
        }

        internal MRiceProductionTypeEntity GetMRiceProductionTypeEntity(string CustId, string RiceType, YesNo yesNo)
        {
            try
            {
                MRiceProductionTypeEntity MRiceProductionTypeEntity = new MRiceProductionTypeEntity();
                IRepository<MRiceProductionType> RiceTypeRepository = new RepositoryImpl<MRiceProductionType>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(MRiceProductionType))
                                                                   .Add(Expression.Eq("RiceType", RiceType))
                                                                   .Add(Expression.Eq("CustID", CustId))
                                                                     .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) })));
                List<MRiceProductionType> listMRiceProductionType = RiceTypeRepository.GetAll(detachedCriteria) as List<MRiceProductionType>;
                if (listMRiceProductionType != null && listMRiceProductionType.Count > 0)
                {
                    foreach (MRiceProductionType adMInfo in listMRiceProductionType)
                    {
                        MRiceProductionTypeEntity = (RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetMRiceProductionTypeEntity(adMInfo));
                        break;
                    }
                }
                else
                    MRiceProductionTypeEntity = null;

                return MRiceProductionTypeEntity;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMRiceProductionTypeEntity", ex);
                throw;
            }
        }

        internal MBrokenRiceTypeEntity GetMBrokenRiceTypeEntity(string CustId, string BrokenRiceType, YesNo yesNo)
        {
            try
            {
                MBrokenRiceTypeEntity MBrokenRiceTypeEntity = new MBrokenRiceTypeEntity();
                IRepository<MBrokenRiceType> BrokenRiceTypeRepository = new RepositoryImpl<MBrokenRiceType>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(MBrokenRiceType))
                                                                   .Add(Expression.Eq("BrokenRiceName", BrokenRiceType))
                                                                   .Add(Expression.Eq("CustID", CustId))
                                                                     .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) })));
                List<MBrokenRiceType> listMBrokenRiceType = BrokenRiceTypeRepository.GetAll(detachedCriteria) as List<MBrokenRiceType>;
                if (listMBrokenRiceType != null && listMBrokenRiceType.Count > 0)
                {
                    foreach (MBrokenRiceType adMInfo in listMBrokenRiceType)
                    {
                        MBrokenRiceTypeEntity = (RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetMBrokenRiceTypeEntity(adMInfo));
                        break;
                    }
                }
                else
                    MBrokenRiceTypeEntity = null;

                return MBrokenRiceTypeEntity;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMBrokenRiceTypeEntity", ex);
                throw;
            }
        }
        internal MRiceBrandDetailsEntity GetMRiceBrandDetailsEntity(string CustId, string RiceBrand, YesNo yesNo)
        {
            try
            {
                MRiceBrandDetailsEntity MRiceBrandDetailsEntity = new MRiceBrandDetailsEntity();
                IRepository<MRiceBrandDetails> RiceBrandDetailsRepository = new RepositoryImpl<MRiceBrandDetails>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(MRiceBrandDetails))
                                                                   .Add(Expression.Eq("Name", RiceBrand))
                                                                   .Add(Expression.Eq("CustID", CustId))
                                                                     .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) })));
                List<MRiceBrandDetails> listMRiceBrandDetails = RiceBrandDetailsRepository.GetAll(detachedCriteria) as List<MRiceBrandDetails>;
                if (listMRiceBrandDetails != null && listMRiceBrandDetails.Count > 0)
                {
                    foreach (MRiceBrandDetails adMInfo in listMRiceBrandDetails)
                    {
                        MRiceBrandDetailsEntity = (RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetMRiceBrandDetailsEntity(adMInfo));
                        break;
                    }
                }
                else
                    MRiceBrandDetailsEntity = null;

                return MRiceBrandDetailsEntity;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetMRiceBrandDetailsEntity", ex);
                throw;
            }
        }

        internal List<BagStockInfoEntity> GetBagStockInfoEntity(string CustId, int pageindex, int pageSize, out int count, SortExpression expression, YesNo yesNo)
        {

            try
            {
                List<BagStockInfoEntity> listBagStockInfoEntity = new List<BagStockInfoEntity>();
                IRepository<BagStockInfo> UsersRepository = new RepositoryImpl<BagStockInfo>(applicationSession);
                DetachedCriteria detachedCriteria = null;
                if (expression == SortExpression.Desc)
                    detachedCriteria = DetachedCriteria.For(typeof(BagStockInfo))
                                                                      .Add(Expression.Eq("CustID", CustId))
                                                                        .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) }))
                                                                      ).AddOrder(Order.Asc("BagStockID"));
                else
                    detachedCriteria = DetachedCriteria.For(typeof(BagStockInfo))
                                                                   .Add(Expression.Eq("CustID", CustId))
                                                                     .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) }))
                                                                   ).AddOrder(Order.Desc("BagStockID"));
                List<BagStockInfo> listBagStockInfo = UsersRepository.GetAllWithPagingMultiCriteria(detachedCriteria, pageindex, pageSize, out count) as List<BagStockInfo>;
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
                Logger.Error("Error encountered at GetBagStockInfoEntity", ex);
                throw;
            }
        }

        internal List<RiceStockInfoEntity> GetAllRiceStockInfoEntities(string CustId, string RiceTypeID, string RiceBrandID, string UnitTypeID, YesNo yesNo)
        {
            try
            {
                List<RiceStockInfoEntity> listRiceStockInfoEntity = new List<RiceStockInfoEntity>();
                IRepository<RiceStockInfo> UsersRepository = new RepositoryImpl<RiceStockInfo>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(RiceStockInfo))
                                                                   .Add(Expression.Eq("CustID", CustId))
                                                                   .Add(Expression.Eq("MRiceProdTypeID", RiceTypeID))
                                                                   .Add(Expression.Eq("MRiceBrandID", RiceBrandID))
                                                                   .Add(Expression.Eq("UnitsTypeID", UnitTypeID))
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
                Logger.Error("Error encountered at GetAllRiceStockInfoEntities for Rice Stock", ex);
                throw;
            }
        }

        internal List<ProductSellingInfoEntity> GetAllProductSellingInfoEntities(string CustId, string RiceTypeID, string RiceBrandID, string UnitTypeID, YesNo yesNo)
        {
            try
            {
                List<ProductSellingInfoEntity> listProductSellingInfoEntity = new List<ProductSellingInfoEntity>();
                IRepository<ProductSellingInfo> UsersRepository = new RepositoryImpl<ProductSellingInfo>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(ProductSellingInfo))
                                                                   .Add(Expression.Eq("CustID", CustId))
                                                                   .Add(Expression.Eq("MRiceProdTypeID", RiceTypeID))
                                                                   .Add(Expression.Eq("MRiceBrandID", RiceBrandID))
                                                                   .Add(Expression.Eq("UnitsTypeID", UnitTypeID))
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

        internal List<BrokenRiceStockInfoEntity> GetAllBrokenRiceStockInfoEntities(string CustId, string BrokenRiceTypeID, string UnitTypeID, YesNo yesNo)
        {
            try
            {
                List<BrokenRiceStockInfoEntity> listBrokenRiceStockInfoEntity = new List<BrokenRiceStockInfoEntity>();
                IRepository<BrokenRiceStockInfo> UsersRepository = new RepositoryImpl<BrokenRiceStockInfo>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(BrokenRiceStockInfo))
                                                                   .Add(Expression.Eq("CustID", CustId))
                                                                   .Add(Expression.Eq("BrokenRiceTypeID", BrokenRiceTypeID))
                                                                   .Add(Expression.Eq("UnitsTypeID", UnitTypeID))
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
                Logger.Error("Error encountered at GetAllBrokenRiceStockInfoEntities for BrokenRiceStock info", ex);
                throw;
            }
        }

        internal List<ProductSellingInfoEntity> GetAllProductSellingInfoEntities(string CustId, string BrokenRiceTypeID, string UnitTypeID, YesNo yesNo)
        {
            try
            {
                List<ProductSellingInfoEntity> listProductSellingInfoEntity = new List<ProductSellingInfoEntity>();
                IRepository<ProductSellingInfo> UsersRepository = new RepositoryImpl<ProductSellingInfo>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(ProductSellingInfo))
                                                                   .Add(Expression.Eq("CustID", CustId))
                                                                   .Add(Expression.Eq("BrokenRiceTypeID", BrokenRiceTypeID))
                                                                   .Add(Expression.Eq("UnitsTypeID", UnitTypeID))
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
                Logger.Error("Error encountered at GetProductSellingInfoEntities for BrokenRice ", ex);
                throw;
            }
        }

        internal List<DustStockInfoEntity> GetAllDustStockInfoEntities(string CustId, string UnitTypeID, YesNo yesNo)
        {
            try
            {
                List<DustStockInfoEntity> listDustStockInfoEntity = new List<DustStockInfoEntity>();
                IRepository<DustStockInfo> UsersRepository = new RepositoryImpl<DustStockInfo>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(DustStockInfo))
                                                                   .Add(Expression.Eq("CustID", CustId))
                                                                   .Add(Expression.Eq("UnitsTypeID", UnitTypeID))
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
                Logger.Error("Error encountered at GetAllDustStockInfoEntities for DustStock info", ex);
                throw;
            }
        }

        internal List<ProductSellingInfoEntity> GetAllProductSellingInfoEntities(string CustId, string UnitTypeID, YesNo yesNo)
        {
            try
            {
                List<ProductSellingInfoEntity> listProductSellingInfoEntity = new List<ProductSellingInfoEntity>();
                IRepository<ProductSellingInfo> UsersRepository = new RepositoryImpl<ProductSellingInfo>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(ProductSellingInfo))
                                                                   .Add(Expression.Eq("CustID", CustId))
                                                                   .Add(Expression.Eq("MRiceProdTypeID", null))
                                                                   .Add(Expression.Eq("MRiceBrandID", null))
                                                                   .Add(Expression.Eq("BrokenRiceTypeID", null))
                                                                   .Add(Expression.Eq("UnitsTypeID", UnitTypeID))
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
                Logger.Error("Error encountered at GetProductSellingInfoEntities for dust", ex);
                throw;
            }
        }

        internal List<ProductSellingInfoEntity> GetAllBuyerproductSellingInfoEntities(string CustId, string BuyerID, YesNo yesNo)
        {
            try
            {
                List<ProductSellingInfoEntity> listProductSellingInfoEntity = new List<ProductSellingInfoEntity>();
                IRepository<ProductSellingInfo> UsersRepository = new RepositoryImpl<ProductSellingInfo>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(ProductSellingInfo))
                                                                   .Add(Expression.Eq("CustID", CustId))
                                                                   .Add(Expression.Eq("BuyerID", BuyerID))
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
                Logger.Error("Error encountered at GetAllBuyerproductSellingInfoEntities", ex);
                throw;
            }
        }

        internal List<ProductPaymentInfoEntity> GetAllProductPaymentInfoEntities(string CustId, string BuyerID, YesNo yesNo)
        {
            try
            {
                List<ProductPaymentInfoEntity> listProductPaymentInfoEntity = new List<ProductPaymentInfoEntity>();
                IRepository<ProductPaymentInfo> UsersRepository = new RepositoryImpl<ProductPaymentInfo>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(ProductPaymentInfo))
                                                                   .Add(Expression.Eq("CustID", CustId))
                                                                   .Add(Expression.Eq("Status", "P"))
                                                                   .Add(Expression.Eq("BuyerID", BuyerID))
                                                                   .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) }))
                                                                   );
                List<ProductPaymentInfo> listProductPaymentInfo = UsersRepository.GetAll(detachedCriteria) as List<ProductPaymentInfo>;
                if (listProductPaymentInfo != null && listProductPaymentInfo.Count > 0)
                {
                    foreach (ProductPaymentInfo adMInfo in listProductPaymentInfo)
                    {
                        listProductPaymentInfoEntity.Add(RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetProductPaymentInfoEntity(adMInfo));
                    }
                }
                else
                    listProductPaymentInfoEntity = null;

                return listProductPaymentInfoEntity;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetProductPaymentInfoEntities with BuyerID", ex);
                throw;
            }
        }

        internal BuyerInfoEntity GetBuyerInfoEntity(string CustId, string BuyerID, YesNo yesNo)
        {
            BuyerInfoEntity BuyerInfoEntity = new BuyerInfoEntity();

            try
            {
                IRepository<BuyerInfo> BuyerInfoRepository = new RepositoryImpl<BuyerInfo>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(BuyerInfo))
                                                                   .Add(Expression.Eq("CustID", CustId))
                                                                   .Add(Expression.Eq("BuyerID", BuyerID))
                                                                   .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) }))
                                                                   );
                List<BuyerInfo> listBuyerInfoEntity = BuyerInfoRepository.GetAll(detachedCriteria) as List<BuyerInfo>;
                if (listBuyerInfoEntity != null && listBuyerInfoEntity.Count > 0)
                {
                    foreach (BuyerInfo adMInfo in listBuyerInfoEntity)
                    {
                        BuyerInfoEntity = RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetBuyerInfoEntity(adMInfo);
                    }
                }
                else
                    BuyerInfoEntity = null;


            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetBuyerInfoEntity", ex);
                throw;
            }
            return BuyerInfoEntity;
        }

        internal ProductPaymentInfoEntity GetProductPaymentInfoEntity(string CustId, string ProductPaymentID, YesNo yesNo)
        {

            try
            {
                ProductPaymentInfoEntity ProductPaymentInfoEntity = new ProductPaymentInfoEntity();
                IRepository<ProductPaymentInfo> ProductPaymentInfoRepository = new RepositoryImpl<ProductPaymentInfo>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(ProductPaymentInfo))
                                                                   .Add(Expression.Eq("CustID", CustId))
                                                                   .Add(Expression.Eq("ProductPaymentID", ProductPaymentID))
                                                                     .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) })));
                List<ProductPaymentInfo> listProductPaymentInfo = ProductPaymentInfoRepository.GetAll(detachedCriteria) as List<ProductPaymentInfo>;
                if (listProductPaymentInfo != null && listProductPaymentInfo.Count > 0)
                {
                    foreach (ProductPaymentInfo adMInfo in listProductPaymentInfo)
                    {
                        ProductPaymentInfoEntity = (RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetProductPaymentInfoEntity(adMInfo));
                        break;
                    }
                }
                else
                    ProductPaymentInfoEntity = null;

                return ProductPaymentInfoEntity;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetProductPaymentInfoEntity", ex);
                throw;
            }
        }

        internal List<ProductPaymentTransactionEntity> GetAllProductPaymentTranEntities(string CustId, string ProductPaymentID, YesNo yesNo)
        {

            try
            {
                List<ProductPaymentTransactionEntity> listProdPayTranEnt = new List<ProductPaymentTransactionEntity>();
                IRepository<ProductPaymentTransaction> UsersRepository = new RepositoryImpl<ProductPaymentTransaction>(applicationSession);
                DetachedCriteria detachedCriteria = DetachedCriteria.For(typeof(ProductPaymentTransaction))
                                                                   .Add(Expression.Eq("CustID", CustId))
                                                                   .Add(Expression.Eq("ProductPaymentID", ProductPaymentID))
                                                                   .Add(Expression.In("ObsInd", (yesNo == YesNo.Null ? new string[] { Enum.GetName(typeof(YesNo), YesNo.Y), Enum.GetName(typeof(YesNo), YesNo.N) } : new string[] { Enum.GetName(typeof(YesNo), yesNo) }))
                                                                   );
                List<ProductPaymentTransaction> listProdPayTran = UsersRepository.GetAll(detachedCriteria) as List<ProductPaymentTransaction>;
                if (listProdPayTran != null && listProdPayTran.Count > 0)
                {
                    foreach (ProductPaymentTransaction adMInfo in listProdPayTran)
                    {
                        listProdPayTranEnt.Add(RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.RMISMapperNTD.GetProductPaymentTranEntity(adMInfo));
                    }
                }
                else
                    listProdPayTranEnt = null;

                return listProdPayTranEnt;
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetAllProductPaymentTranEntities", ex);
                throw;
            }
        }
    }
}