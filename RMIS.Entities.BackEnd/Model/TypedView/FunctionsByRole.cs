namespace RMIS.Entities.BackEnd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;

    using RMIS.Entities.BackEnd;

    /// <summary>
    ///	Generated by MyGeneration using the NHibernate Object Mapping template
    /// </summary>
    public class FunctionsByRole : IBackEndSpecific
    {
        #region Fields

        private System.String m_functioncode;
        private System.String m_obsind;
        private System.String m_userid;

        #endregion Fields

        #region Constructors

        public FunctionsByRole()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        public virtual System.String FunctionCode
        {
            get { return m_functioncode; }
            set
            {
                if( value == null )
                    throw new ArgumentOutOfRangeException("Null value not allowed for FunctionCode", value, "null");

                m_functioncode = value;
            }
        }

        public virtual System.String ObsInd
        {
            get { return m_obsind; }
            set
            {
                if( value == null )
                    throw new ArgumentOutOfRangeException("Null value not allowed for ObsInd", value, "null");

                m_obsind = value;
            }
        }

        public virtual System.String UserId
        {
            get { return m_userid; }
            set
            {
                if( value == null )
                    throw new ArgumentOutOfRangeException("Null value not allowed for UserId", value, "null");

                m_userid = value;
            }
        }

        #endregion Properties

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
            FunctionsByRole toCompareWith = obj as FunctionsByRole;
            return toCompareWith == null ? false : ((this.FunctionCode == toCompareWith.FunctionCode));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.FunctionCode.GetHashCode();
            return toReturn;
        }

        public override string ToString()
        {
            return 		"UserId=" + UserId + "--" +
            "FunctionCode=" + FunctionCode + "--" +
            "ObsInd=" + ObsInd + "--" +
            "";
        }

        #endregion Methods
    }
}