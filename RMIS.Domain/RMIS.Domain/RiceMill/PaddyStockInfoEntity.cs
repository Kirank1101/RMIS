using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RMIS.Domain.Abstract;

namespace RMIS.Domain.RiceMill
{
    [Serializable]
    public class PaddyStockInfoEntity : AbstractAllInOne
    {
        public string PaddyStockID { get; set; }
        public string SellerID { get; set; }
        public string PaddyTypeID { get; set; }
        public string CustID { get; set; }
        public string MGodownID { get; set; }
        public string MLotID { get; set; }
        public string UnitsTypeID { get; set; }
        public string VehicalNo { get; set; }
        public string DriverName { get; set; }
        public int TotalBags { get; set; }
        public int TotalQuintals { get; set; }
        public double Price { get; set; }
        public DateTime PurchaseDate { get; set; }
        #region Methods
        /// <summary>Determines whether the specified object is equal to this instance.</summary>
        /// <param name="obj">The <see cref="System.Object"/> to compare with this instance.</param>
        /// <returns><c>true</c> if the specified <see cref="System.Object"/> is equal to this instance{ get; set; }otherwise, <c>false</c>.</returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            PaddyStockInfoEntity toCompareWith = obj as PaddyStockInfoEntity;
            return toCompareWith == null ? false : ((this.PaddyStockID == toCompareWith.PaddyStockID));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.PaddyStockID.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}
