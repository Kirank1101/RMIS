using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RMIS.Entities.BackEnd
{
    public class BankTransaction
    {
        private string _BankTransID;
        private string _CustID;
        private string _Description;
        private double _Withdraw;
        private double _Deposit;
        private double _Balance;
        private DateTime _TransactionDate;
        private string _LastModifiedBy;
        private DateTime _LastModifiedDate;
        private string _ObsInd;

        public virtual string BankTransID
        {
            get { return _BankTransID; }
            set { _BankTransID = value; }
        }
        public virtual string CustID
        {
            get { return _CustID; }
            set { _CustID = value; }
        }
        public virtual string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }
        public virtual double Withdraw
        {
            get { return _Withdraw; }
            set { _Withdraw = value; }
        }
        public virtual double Deposit
        {
            get { return _Deposit; }
            set { _Deposit = value; }
        }
        public virtual double Balance
        {
            get { return _Balance; }
            set { _Balance = value; }
        }
        public virtual DateTime TransactionDate
        {
            get { return _TransactionDate; }
            set { _TransactionDate = value; }
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
