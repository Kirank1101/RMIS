using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net;

using AutoMapper;
using RMIS.Entities.BackEnd;
using RMIS.Domain.RiceMill;
using RMIS.Entities.BackEnd;

namespace RMIS.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper
{

    public interface IRMISMapper
    {
        MSellerType GetSellerType(SellerTypeEntity SellerTypeEntity);
        SellerInfo GetSellerInfo(SellerInfoEntity SellerInfoEntity);
    }

    public class RMISMapperDTN : IRMISMapper
    {


        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(RMISMapperDTN));

        #endregion Fields

        /// <summary>
        /// Gets the <see cref="AASObjection"/>
        /// </summary>
        /// <param name="SellerTypeEntity">The AASObjectionEntity.</param>
        /// <returns></returns>
        public  MSellerType GetSellerType(SellerTypeEntity SellerTypeEntity)
        {
            MSellerType sellerType = null;
            try
            {
                sellerType = Mapper.Map<SellerTypeEntity, MSellerType>(SellerTypeEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetSellerType", ex);
                throw;
            }
            return sellerType;
        }

        public SellerInfo GetSellerInfo(SellerInfoEntity SellerInfoEntity)
        {
            SellerInfo sellerInfo = null;
            try
            {
                sellerInfo = Mapper.Map<SellerInfoEntity, SellerInfo>(SellerInfoEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetSellerInfo", ex);
                throw;
            }
            return sellerInfo;
        }
    }
}
