using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RMIS.Entities.BackEnd
{
    public class MSellerType
    {
        private string _SellerTypeID;
        private string _CustID;
        private string _SellerType;
        private string _LastModifiedBy;
        private DateTime _LastModifiedDate;
        private string  _ObsInd;

        public virtual string SellerTypeID { 
        get {return _SellerTypeID;} set{_SellerTypeID=value;} }
        public virtual string  CustID {
            get { return _CustID; }
            set { _CustID = value; }
        }
        public virtual string SellerType {
            get { return _SellerType; }
            set { _SellerType = value; }
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
        public virtual string  ObsInd
        {
            get { return _ObsInd; }
            set { _ObsInd = value; }
        }
    }
}
