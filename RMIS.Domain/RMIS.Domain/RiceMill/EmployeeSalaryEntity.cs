﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RMIS.Domain.Abstract;

namespace RMIS.Domain.RiceMill
{
    [Serializable]
    public class EmployeeSalaryEntity : AbstractAllInOne
    {
        public string EmpSalaryID { get; set; }
        public string CustID { get; set; }
        public string EmployeeID { get; set; }
        public string MSalaryTypeID { get; set; }
        public string MEmpDsgID { get; set; }
        public double Salary { get; set; }
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

            EmployeeSalaryEntity toCompareWith = obj as EmployeeSalaryEntity;
            return toCompareWith == null ? false : ((this.EmpSalaryID == toCompareWith.EmpSalaryID));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.EmpSalaryID.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}
