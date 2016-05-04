﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RMIS.Entities.BackEnd
{
    public class RiceSellingInfo
    {
        private string _RiceSellingID;
        private string _SellerID;
        private string _RiceTypeID;
        private string _RiceBrandID;
        private string _CustID;
        private string _VehicalNo;
        private string _DriverName;
        private Int16 _TotalBags; 
        private Int16 _QWeight;
        private Int16 _QPrice;
        private string _UnitWeight;
        private DateTime _SellingDate;
        private string _LastModifiedBy;
        private DateTime _LastModifiedDate;
        private string _ObsInd;

        public virtual string RiceSellingID
        {
            get { return _RiceSellingID; }
            set { _RiceSellingID = value; }
        }
        public virtual string SellerID
        {
            get { return _SellerID; }
            set { _SellerID = value; }
        }
        public virtual string RiceTypeID
        {
            get { return _RiceTypeID; }
            set { _RiceTypeID = value; }
        }
        public virtual string RiceBrandID
        {
            get { return _RiceBrandID; }
            set { _RiceBrandID = value; }
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
        public virtual string UnitWeight
        {
            get { return _UnitWeight; }
            set { _UnitWeight = value; }
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