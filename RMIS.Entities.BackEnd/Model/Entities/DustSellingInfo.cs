using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RMIS.Entities.BackEnd
{
    public class DustSellingInfo
    {
        private string _DustSellingID;
        private string _SellerID;
        private string _CustID;
        private string _VehicalNo;
        private string _DriverName;
        private Int16 _TotalBags; 
        private Int16 _QWeight;
        private Int16 _QPrice;
        private string _UnitsTypeID;
        private DateTime _SellingDate;
        private string _LastModifiedBy;
        private DateTime _LastModifiedDate;
        private string _ObsInd;

        public virtual string DustSellingID
        {
            get { return _DustSellingID; }
            set { _DustSellingID = value; }
        }
        public virtual string SellerID
        {
            get { return _SellerID; }
            set { _SellerID = value; }
        }
        public virtual string CustID
        {
            get { return _CustID; }
            set { _CustID = value; }
        }
        public virtual string VehicalNo
        {
            get { return _VehicalNo; }
            set { _VehicalNo = value; }
        }
        public virtual string DriverName
        {
            get { return _DriverName; }
            set { _DriverName = value; }
        }
        public virtual Int16 TotalBags
        {
            get { return _TotalBags; }
            set { _TotalBags = value; }
        }
        public virtual Int16 QWeight
        {
            get { return _QWeight; }
            set { _QWeight = value; }
        }
        public virtual Int16 QPrice
        {
            get { return _QPrice; }
            set { _QPrice = value; }
        }
        public virtual string UnitsTypeID
        {
            get { return _UnitsTypeID; }
            set { _UnitsTypeID = value; }
        }
        public virtual DateTime SellingDate
        {
            get { return _SellingDate; }
            set { _SellingDate = value; }
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
