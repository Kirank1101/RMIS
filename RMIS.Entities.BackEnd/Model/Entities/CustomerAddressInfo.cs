using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RMIS.Entities.BackEnd
{
    public class CustomerAddressInfo
    {
        private string _CustAdrsID;
        private string _CustID;
        private string _Street1; 
        private string _Street2;
        private string _Town;
        private string _City;
        private string _District;
        private string _State;
        private Int32 _Pincode;
        private string _ContactNo;
        private string _MobileNo;
        private string _PhoneNo;
        private string _TINNumber;
        private string _MillName;
        private string _LastModifiedBy;
        private DateTime _LastModifiedDate;
        private string _ObsInd;

        public virtual string CustAdrsID
        {
            get { return _CustAdrsID; }
            set { _CustAdrsID = value; }
        }
        public virtual string CustID
        {
            get { return _CustID; }
            set { _CustID = value; }
        }
        public virtual string Street1
        {
            get { return _Street1; }
            set { _Street1 = value; }
        }
        public virtual string Street2
        {
            get { return _Street2; }
            set { _Street2 = value; }
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
        public virtual Int32 Pincode
        {
            get { return _Pincode; }
            set { _Pincode = value; }
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
        public virtual string MillName
        {
            get { return _MillName; }
            set { _MillName = value; }
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
