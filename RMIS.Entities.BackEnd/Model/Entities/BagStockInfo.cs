﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RMIS.Entities.BackEnd
{
    public class BagStockInfo
    {
        private string _BagStockID;
        private string _SellerID;
        private string _BagTypeID; 
        private string _CustID;
        private string _VehicalNo;
        private string _DriverName; 
        private Int16 _TotalBags;         
        private Int16 _PricePerBag;
        private DateTime _PurchaseDate;
        private string _LastModifiedBy;
        private DateTime _LastModifiedDate;
        private string _ObsInd;

        public virtual string BagStockID
        {
            get { return _BagStockID; }
            set { _BagStockID = value; }
        }
        public virtual string SellerID
        {
            get { return _SellerID; }
            set { _SellerID = value; }
        }
        public virtual string BagTypeID
        {
            get { return _BagTypeID; }
            set { _BagTypeID = value; }
        }
        public virtual string CustID
        {
            get { return _CustID; }
            set { _CustID = value; }
        }
        public virtual string DriverName
        {
            get { return _DriverName; }
            set { _DriverName = value; }
        }
        public virtual string VehicalNo
        {
            get { return _VehicalNo; }
            set { _VehicalNo = value; }
        }
        public virtual Int16 TotalBags
        {
            get { return _TotalBags; }
            set { _TotalBags = value; }
        }
        public virtual Int16 PricePerBag
        {
            get { return _PricePerBag; }
            set { _PricePerBag = value; }
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