using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RMIS.Entities.BackEnd;

using AutoMapper;
using log4net;
using RMIS.Entities.BackEnd;
using RMIS.Domain.RiceMill;
using RMIS.Entities.BackEnd;

namespace RMIS.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper
{
    public class RMISMapperNTD
    {

        #region Fields
        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(RMISMapperNTD));

        #endregion Fields

        /// <summary>
        /// Gets the <see cref="ReportConfigUser"/> from <see cref="ReportConfigUserEntity"/> input.
        /// </summary>
        /// <param name="reportConfigUserEntity"><see cref="ReportConfigUserEntity"/></param>
        /// <returns>Returns <see cref="ReportConfigUser"/>, else null.</returns>
      public static SellerTypeEntity GetSellerTypeEntity(MSellerType sellerType)
        {
            SellerTypeEntity sellerTypeEntity = null;

            try
            {
                if (sellerType != null)
                {
                    sellerTypeEntity = Mapper.Map<MSellerType, SellerTypeEntity>(sellerType);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetSellerTypeEntity", ex);
                throw;
            }

            return sellerTypeEntity;
        }
    }
}
