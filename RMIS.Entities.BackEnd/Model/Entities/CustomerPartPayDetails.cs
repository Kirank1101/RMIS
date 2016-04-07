using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RMIS.Entities.BackEnd
{
    public class CustomerPartPayDetails
    {
        private string _CustPartPayID;
        private string _CustID;
        private Int32 _PaidAmount;
        private DateTime _PaidDate;
        private DateTime _NextPayDate;
        private string _LastModifiedBy;
        private DateTime _LastModifiedDate;
        private string _ObsInd;

        public virtual string CustPartPayID
        {
            get { return _CustPartPayID; }
            set { _CustPartPayID = value; }
        }
        public virtual string CustID
        {
            get { return _CustID; }
            set { _CustID = value; }
        }
        public virtual Int32 PaidAmount
        {
            get { return _PaidAmount; }
            set { _PaidAmount = value; }
        }
        public virtual DateTime PaidDate
        {
            get { return _PaidDate; }
            set { _PaidDate = value; }
        }
        public virtual DateTime NextPayDate
        {
            get { return _NextPayDate; }
            set { _NextPayDate = value; }
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
