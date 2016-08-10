using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RMIS.Entities.BackEnd
{
    public class BuyerInfo
    {
        private string _BuyerID;
        private string _CustID;
        private string _Name;
        private string _Street;
        private string _Street1;
        private string _Town;
        private string _City;
        private string _District;
        private string _State;
        private string _PinCode;
        private string _ContactNo;
        private string _MobileNo;
        private string _PhoneNo;
        private string _TINNumber;
        private string _LastModifiedBy;
        private DateTime _LastModifiedDate;
        private string _ObsInd;

        public virtual string BuyerID
        {
            get { return _BuyerID; }
            set { _BuyerID = value; }
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
        public virtual string Street
        {
            get { return _Street; }
            set { _Street = value; }
        }
        public virtual string Street1
        {
            get { return _Street1; }
            set { _Street1 = value; }
        }
        public virtual string Town
        {
            get { return _Town; }
            set { _Town = value; }
        }
        public virtual string City
        {
            get { return _City; }
            set { _City = value; }
        }
        public virtual string District
        {
            get { return _District; }
            set { _District = value; }
        }
        public virtual string State
        {
            get { return _State; }
            set { _State = value; }
        }
        public virtual string PinCode
        {
            get { return _PinCode; }
            set { _PinCode = value; }
        }
        public virtual string ContactNo
        {
            get { return _ContactNo; }
            set { _ContactNo = value; }
        }
        public virtual string MobileNo
        {
            get { return _MobileNo; }
            set { _MobileNo = value; }
        }
        public virtual string PhoneNo
        {
            get { return _PhoneNo; }
            set { _PhoneNo = value; }
        }
        public virtual string TINNumber
        {
            get { return _TINNumber; }
            set { _TINNumber = value; }
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
