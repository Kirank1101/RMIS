using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RMIS.Domain.Abstract;

namespace RMIS.Domain.RiceMill
{
    [Serializable]
    public class ProductSellingInfoEntity : AbstractAllInOne
    {
        public string ProductID { get; set; }
        public string ProductPaymentID { get; set; }
        public string CustID { get; set; }
        public string BuyerID { get; set; }
        public string MRiceProdTypeID { get; set; }
        public string MRiceBrandID { get; set; }
        public string BrokenRiceTypeID { get; set; }
        public string UnitsTypeID { get; set; }
        public string SellingProductType { get; set; }
        public int TotalBags { get; set; }
        public double Price { get; set; }
        public DateTime SellingDate { get; set; }
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

            ProductSellingInfoEntity toCompareWith = obj as ProductSellingInfoEntity;
            return toCompareWith == null ? false : ((this.ProductID == toCompareWith.ProductID));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.ProductID.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}
