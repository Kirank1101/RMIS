using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RMIS.Domain.Abstract;

namespace RMIS.Domain.RiceMill
{
    [Serializable]
    public class UsersEntity : AbstractAllInOne
    {
        public string UserID { get; set; }
        public string CustID { get; set; }
        public string UserTypeID { get; set; }
        public string Name { get; set; }
        public string PassWord { get; set; }
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

            UsersEntity toCompareWith = obj as UsersEntity;
            return toCompareWith == null ? false : ((this.UserID == toCompareWith.UserID));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.UserID.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}
