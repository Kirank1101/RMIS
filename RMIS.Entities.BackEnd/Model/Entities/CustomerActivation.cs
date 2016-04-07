using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RMIS.Entities.BackEnd
{
    public class CustomerActivation
    {
        private string _CustActiveID;
        private string _CustID;
        private DateTime _ApplicationStartDate;
        private DateTime _ApplicationEndDate;
        private string _Status;
        private string _LastModifiedBy;
        private DateTime _LastModifiedDate;
        private string _ObsInd;

        public virtual string CustActiveID
        {
            get { return _CustActiveID; }
            set { _CustActiveID = value; }
        }
        public virtual string CustID
        {
            get { return _CustID; }
            set { _CustID = value; }
        }
        public virtual DateTime ApplicationStartDate
        {
            get { return _ApplicationStartDate; }
            set { _ApplicationStartDate = value; }
        }
        public virtual DateTime ApplicationEndDate
        {
            get { return _ApplicationEndDate; }
            set { _ApplicationEndDate = value; }
        }
        public virtual string Status
        {
            get { return _Status; }
            set { _Status = value; }
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
