﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RMIS.Entities.BackEnd
{
    public class BagPaymentInfo
    {
        private string _BagPaymentID;
        private string _SellerID;
        private string _CustID;
        private double  _AmountPaid; 
        private DateTime _PaidDate;
        private string _HandoverTo;
        private DateTime _NextPaymentDate;
        private string _PaymentMode;
        private string _ChequeNo;
        private string _BankName;
        private string _LastModifiedBy;
        private DateTime _LastModifiedDate;
        private string _ObsInd;

        public virtual string BagPaymentID
        {
            get { return _BagPaymentID; }
            set { _BagPaymentID = value; }
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
        public virtual double  AmountPaid
        {
            get { return _AmountPaid; }
            set { _AmountPaid = value; }
        }
        public virtual DateTime PaidDate
        {
            get { return _PaidDate; }
            set { _PaidDate = value; }
        }
        public virtual string HandoverTo
        {
            get { return _HandoverTo; }
            set { _HandoverTo = value; }
        }
        public virtual DateTime NextPaymentDate
        {
            get { return _NextPaymentDate; }
            set { _NextPaymentDate = value; }
        }
        public virtual string PaymentMode
        {
            get { return _PaymentMode; }
            set { _PaymentMode = value; }
        }
        public virtual string ChequeNo
        {
            get { return _ChequeNo; }
            set { _ChequeNo = value; }
        }
        public virtual string BankName
        {
            get { return _BankName; }
            set { _BankName = value; }
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
