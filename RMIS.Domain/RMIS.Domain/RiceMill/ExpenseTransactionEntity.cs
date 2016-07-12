﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RMIS.Domain.Abstract;

namespace RMIS.Domain.RiceMill
{
    [Serializable]
    public class ExpenseTransactionEntity : AbstractAllInOne
    {
        public string ExpenseTransID { get; set; }
        public string ExpenseID { get; set; }
        public string CustID { get; set; }
        public string Name { get; set; }
        public string Reason { get; set; }
        public double Amount { get; set; }
        public DateTime PayDate { get; set; }
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

            ExpenseTransactionEntity toCompareWith = obj as ExpenseTransactionEntity;
            return toCompareWith == null ? false : ((this.ExpenseTransID == toCompareWith.ExpenseTransID));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.ExpenseTransID.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}
