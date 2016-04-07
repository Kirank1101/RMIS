using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RMIS.Entities.BackEnd
{
    public class CustomerPayment
    {
        private string _CustPaymentID;
        private string _CustID;
        private string _OutstandingAmount;
        private string _Status;
        private string _LastModifiedBy;
        private DateTime _LastModifiedDate;
        private string _ObsInd;

        public virtual string CustPaymentID
        {
            get { return _CustPaymentID; }
            set { _CustPaymentID = value; }
        }
        public virtual string CustID
        {
            get { return _CustID; }
            set { _CustID = value; }
        }
        public virtual string OutstandingAmount
        {
            get { return _OutstandingAmount; }
            set { _OutstandingAmount = value; }
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
