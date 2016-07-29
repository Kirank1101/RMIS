using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RMIS.Domain.Abstract;

namespace RMIS.Domain.RiceMill
{
    [Serializable]
    public class CustomerAddressInfoEntity : AbstractAllInOne
    {
        public string CustAdrsID { get; set; }
        public string CustID { get; set; }
        public string Street1 { get; set; }
        public string Street2 { get; set; }
        public string Town { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string State { get; set; }
        public Int32 Pincode { get; set; }
        public string ContactNo { get; set; }
        public string MobileNo { get; set; }
        public string PhoneNo { get; set; }
        public string TINNumber { get; set; }
        public string MillName { get; set; }

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

            CustomerAddressInfoEntity toCompareWith = obj as CustomerAddressInfoEntity;
            return toCompareWith == null ? false : ((this.CustAdrsID == toCompareWith.CustAdrsID));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.CustAdrsID.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}
