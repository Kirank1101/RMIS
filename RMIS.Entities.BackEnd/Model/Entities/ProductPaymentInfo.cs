﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RMIS.Entities.BackEnd
{
    public class ProductPaymentInfo
    {
        private string _ProductPaymentID;
        private string _CustID;
        private string _BuyerID;
        private string _MediatorID;
        private double _TotalAmount; 
        private string _Status;
        private DateTime _NextPayDate;
        private string _LastModifiedBy;
        private DateTime _LastModifiedDate;
        private string _ObsInd;

        public virtual string ProductPaymentID
        {
            get { return _ProductPaymentID; }
            set { _ProductPaymentID = value; }
        }
        public virtual string CustID
        {
            get { return _CustID; }
            set { _CustID = value; }
        }
        public virtual string BuyerID
        {
            get { return _BuyerID; }
            set { _BuyerID = value; }
        }
        public virtual string MediatorID
        {
            get { return _MediatorID; }
            set { _MediatorID = value; }
        }
        public virtual double TotalAmount
        {
            get { return _TotalAmount; }
            set { _TotalAmount = value; }
        }
        public virtual string Status
        {
            get { return _Status; }
            set { _Status = value; }
        }
        public virtual DateTime NextPayDate
        {
            get { return _NextPayDate; }
            set { _NextPayDate = value; }
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
