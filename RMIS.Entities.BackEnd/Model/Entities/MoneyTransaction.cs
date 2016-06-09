using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RMIS.Entities.BackEnd
{
    public class MoneyTransaction
    {
        private string _ExpTranID;
        private string _CustID;
        private string _EmployeeID;
        private string _MSalaryTypeID;
        private string _MEmpDsgID;
        private double _Salary;
        private string _GivenTo;
        private string _Description;
        private double _AmountSpent;
        private double _ExtraCharges;
        private DateTime _PaymentDate;
        private string _LastModifiedBy;
        private DateTime _LastModifiedDate;
        private string _ObsInd;

        public virtual string ExpTranID
        {
            get { return _ExpTranID; }
            set { _ExpTranID = value; }
        }
        public virtual string CustID
        {
            get { return _CustID; }
            set { _CustID = value; }
        }
        public virtual string EmployeeID
        {
            get { return _EmployeeID; }
            set { _EmployeeID = value; }
        }
        public virtual string MSalaryTypeID
        {
            get { return _MSalaryTypeID; }
            set { _MSalaryTypeID = value; }
        }
        public virtual string MEmpDsgID
        {
            get { return _MEmpDsgID; }
            set { _MEmpDsgID = value; }
        }
        public virtual double Salary
        {
            get { return _Salary; }
            set { _Salary = value; }
        }
        public virtual string GivenTo
        {
            get { return _GivenTo; }
            set { _GivenTo = value; }
        }
        public virtual string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }
        public virtual double AmountSpent
        {
            get { return _AmountSpent; }
            set { _AmountSpent = value; }
        }
        public virtual double ExtraCharges
        {
            get { return _ExtraCharges; }
            set { _ExtraCharges = value; }
        }
        public virtual DateTime PaymentDate
        {
            get { return _PaymentDate; }
            set { _PaymentDate = value; }
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
