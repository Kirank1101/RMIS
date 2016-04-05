using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RMIS.Entities.BackEnd
{
    public class MLotDetails
    {
        private string _MLotID;
        private string _CustID;
        private string _LotName;
        private string _MGodownID;
        private string _LastModifiedBy;
        private DateTime _LastModifiedDate;
        private string _ObsInd;

        public virtual string MLotID
        {
            get { return _MLotID; }
            set { _MLotID = value; }
        }
        public virtual string CustID
        {
            get { return _CustID; }
            set { _CustID = value; }
        }
        public virtual string LotName
        {
            get { return _LotName; }
            set { _LotName = value; }
        }
        public virtual string MGodownID
        {
            get { return _MGodownID; }
            set { _MGodownID = value; }
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
