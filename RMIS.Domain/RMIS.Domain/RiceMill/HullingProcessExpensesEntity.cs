using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RMIS.Domain.Abstract;

namespace RMIS.Domain.RiceMill
{
    [Serializable]
    public class HullingProcessExpensesEntity : AbstractAllInOne
    {
        public string HullingProcessExpenID { get; set; }
        public string HullingProcessID { get; set; }
        public string CustID { get; set; }
        public double HullingExpenses { get; set; }
        
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

            HullingProcessExpensesEntity toCompareWith = obj as HullingProcessExpensesEntity;
            return toCompareWith == null ? false : ((this.HullingProcessExpenID == toCompareWith.HullingProcessExpenID));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.HullingProcessExpenID.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}
