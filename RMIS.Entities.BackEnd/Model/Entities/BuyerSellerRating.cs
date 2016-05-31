using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RMIS.Entities.BackEnd
{
    public class BuyerSellerRating
    {
        private string _BRMSID;
        private string _SellerID;
        private string _SellerTypeID;
        private string _CustID;
        private string _Remarks;
        private Int16 _Rating;
        private string _LastModifiedBy;
        private DateTime _LastModifiedDate;
        private string _ObsInd;

        public virtual string BRMSID
        {
            get { return _BRMSID; }
            set { _BRMSID = value; }
        }
        public virtual string SellerID
        {
            get { return _SellerID; }
            set { _SellerID = value; }
        }
        public virtual string SellerTypeID
        {
            get { return _SellerTypeID; }
            set { _SellerTypeID = value; }
        }
        public virtual string CustID
        {
            get { return _CustID; }
            set { _CustID = value; }
        }
        public virtual string Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }
        public virtual Int16 Rating
        {
            get { return _Rating; }
            set { _Rating = value; }
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
