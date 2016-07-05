using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RMIS.Entities.BackEnd
{
    public class PaddyStockInfo
    {
        private string _PaddyStockID;
        private string _SellerID;
        private string _PaddyTypeID; 
        private string _CustID;
        private string _MGodownID;
        private string _MLotID;
        private string _UnitsTypeID;
        private string _VehicalNo;
        private string _DriverName;
        private int _TotalBags;
        private decimal _TotalQuintals; 
        private double _Price;
        private DateTime _PurchaseDate;
        private string _LastModifiedBy;
        private DateTime _LastModifiedDate;
        private string _ObsInd;

        public virtual string PaddyStockID
        {
            get { return _PaddyStockID; }
            set { _PaddyStockID = value; }
        }
        public virtual string SellerID
        {
            get { return _SellerID; }
            set { _SellerID = value; }
        }
        public virtual string PaddyTypeID
        {
            get { return _PaddyTypeID; }
            set { _PaddyTypeID = value; }
        }
        public virtual string CustID
        {
            get { return _CustID; }
            set { _CustID = value; }
        }
        public virtual string MGodownID
        {
            get { return _MGodownID; }
            set { _MGodownID = value; }
        }
        public virtual string MLotID
        {
            get { return _MLotID; }
            set { _MLotID = value; }
        }
        public virtual string UnitsTypeID
        {
            get { return _UnitsTypeID; }
            set { _UnitsTypeID = value; }
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
        public virtual int TotalBags
        {
            get { return _TotalBags; }
            set { _TotalBags = value; }
        }
        public virtual decimal TotalQuintals
        {
            get { return _TotalQuintals; }
            set { _TotalQuintals = value; }
        }
        public virtual double Price
        {
            get { return _Price; }
            set { _Price = value; }
        }
        public virtual DateTime PurchaseDate
        {
            get { return _PurchaseDate; }
            set { _PurchaseDate = value; }
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
