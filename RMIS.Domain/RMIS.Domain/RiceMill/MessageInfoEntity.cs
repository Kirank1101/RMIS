using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RMIS.Domain.Abstract;

namespace RMIS.Domain.RiceMill
{
    [Serializable]
    public class MessageInfoEntity : AbstractAllInOne
    {
        public string MessageTypeID { get; set; }
        public string CustID { get; set; }
        public string MessageCode { get; set; }
        public string Message { get; set; }
        #region Methods
        /// <summary>Determines whether the specified object is equal to this instance.</summary>
        /// <param name="obj">The <see cref="System.Object"/> to compare with this instance.</param>
        /// <returns><c>true</c> if the specified <see cref="System.Object"/> is equal to this instance; otherwise, <c>false</c>.</returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            MessageInfoEntity toCompareWith = obj as MessageInfoEntity;
            return toCompareWith == null ? false : ((this.MessageTypeID == toCompareWith.MessageTypeID));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.MessageTypeID.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}
