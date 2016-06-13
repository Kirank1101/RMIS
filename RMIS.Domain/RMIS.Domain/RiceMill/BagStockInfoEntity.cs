using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RMIS.Domain.Abstract;

namespace RMIS.Domain.RiceMill
{
    [Serializable]
    public class BagStockInfoEntity : AbstractAllInOne
    {
        public string BagStockID { get; set; }
        public string SellerID { get; set; }
        public string BagTypeID { get; set; }
        public string CustID { get; set; }
        public string UnitsTypeID { get; set; }
        public string MRiceBrandID { get; set; }
        public string VehicalNo { get; set; }
        public string DriverName { get; set; }
        public Int16 TotalBags { get; set; }
        public decimal Price { get; set; }
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

            BagStockInfoEntity toCompareWith = obj as BagStockInfoEntity;
            return toCompareWith == null ? false : ((this.BagStockID == toCompareWith.BagStockID));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.BagStockID.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}
