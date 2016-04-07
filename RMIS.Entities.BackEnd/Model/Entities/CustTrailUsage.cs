using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RMIS.Entities.BackEnd
{
    public class CustTrailUsage
    {
        private string _CustTrailID;
        private string _CustID;
        private DateTime _TrailStartDate;
        private DateTime _TrailEndDate;        
        private string _LastModifiedBy;
        private DateTime _LastModifiedDate;
        private string _ObsInd;

        public virtual string CustTrailID
        {
            get { return _CustTrailID; }
            set { _CustTrailID = value; }
        }
        public virtual string CustID
        {
            get { return _CustID; }
            set { _CustID = value; }
        }
        public virtual DateTime TrailStartDate
        {
            get { return _TrailStartDate; }
            set { _TrailStartDate = value; }
        }
        public virtual DateTime TrailEndDate
        {
            get { return _TrailEndDate; }
            set { _TrailEndDate = value; }
        }
        public virtual string LastModifiedBy
        {
            get { return _LastModifiedBy; }
            set { _LastModifiedBy = value; }
        }
        public virtual DateTime LastModifiedDate
        {
            get { return _LastModifiedDate; }
            set { _LastModifiedDate = value; }
        }
        public virtual string ObsInd
        {
            get { return _ObsInd; }
            set { _ObsInd = value; }
        }
    }
}
