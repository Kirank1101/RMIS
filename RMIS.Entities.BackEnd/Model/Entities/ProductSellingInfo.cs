using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RMIS.Entities.BackEnd
{
    public class ProductSellingInfo
    {
        private string _ProductID;
        private string _BuyerID;
        private string _ProductPaymentID;
        private string _SellingProductType;
        private string _MRiceProdTypeID;
        private string _MRiceBrandID;
        private string _BrokenRiceTypeID;
        private string _CustID;
        private string _UnitsTypeID;
        private decimal _TotalBags; 
        private double _Price;
        private DateTime _SellingDate;
        private string _LastModifiedBy;
        private DateTime _LastModifiedDate;
        private string _ObsInd;

        public virtual string ProductID
        {
            get { return _ProductID; }
            set { _ProductID = value; }
        }
        public virtual string BuyerID
        {
            get { return _BuyerID; }
            set { _BuyerID = value; }
        }
        public virtual string ProductPaymentID
        {
            get { return _ProductPaymentID; }
            set { _ProductPaymentID = value; }
        }
        public virtual string SellingProductType
        {
            get { return _SellingProductType; }
            set { _SellingProductType = value; }
        }
        public virtual string MRiceProdTypeID
        {
            get { return _MRiceProdTypeID; }
            set { _MRiceProdTypeID = value; }
        }
        public virtual string MRiceBrandID
        {
            get { return _MRiceBrandID; }
            set { _MRiceBrandID = value; }
        }
        public virtual string BrokenRiceTypeID
        {
            get { return _BrokenRiceTypeID; }
            set { _BrokenRiceTypeID = value; }
        }
        public virtual string CustID
        {
            get { return _CustID; }
            set { _CustID = value; }
        }
        public virtual decimal TotalBags
        {
            get { return _TotalBags; }
            set { _TotalBags = value; }
        }
        public virtual double Price
        {
            get { return _Price; }
            set { _Price = value; }
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
