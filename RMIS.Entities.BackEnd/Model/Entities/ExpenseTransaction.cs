using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RMIS.Entities.BackEnd
{
    public class ExpenseTransaction
    {
        private string _ExpenseTransID;
        private string _CustID;
        private string _ExpenseID;
        private string _Name;
        private string _Reason;
        private double _Amount;
        private string _LastModifiedBy;
        private DateTime _LastModifiedDate;
        private string _ObsInd;

        public virtual string ExpenseTransID
        {
            get { return _ExpenseTransID; }
            set { _ExpenseTransID = value; }
        }
        public virtual string ExpenseID
        {
            get { return _ExpenseID; }
            set { _ExpenseID = value; }
        }
        public virtual string CustID
        {
            get { return _CustID; }
            set { _CustID = value; }
        }
        public virtual string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public virtual string Reason
        {
            get { return _Reason; }
            set { _Reason = value; }
        }
        public virtual double Amount
        {
            get { return _Amount; }
            set { _Amount = value; }
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
