using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RMIS.Entities.BackEnd
{
    public class ProductPaymentTransaction
    {
        private string _ProductPaymentTranID;
        private string _ProductPaymentID;
        private string _BuyerID;
        private string _MediatorID;
        private string _CustID;
        private string _Paymentmode;
        private string _ChequeNo;
        private string _DDNo;
        private string _BankName;
        private double _ReceivedAmount;
        private DateTime _PaymentDueDate;
        private string _LastModifiedBy;
        private DateTime _LastModifiedDate;
        private string _ObsInd;

        public virtual string ProductPaymentTranID
        {
            get { return _ProductPaymentTranID; }
            set { _ProductPaymentTranID = value; }
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
        public virtual string ProductPaymentID
        {
            get { return _ProductPaymentID; }
            set { _ProductPaymentID = value; }
        }
        public virtual string Paymentmode
        {
            get { return _Paymentmode; }
            set { _Paymentmode = value; }
        }
        public virtual string ChequeNo
        {
            get { return _ChequeNo; }
            set { _ChequeNo = value; }
        }
        public virtual string DDNo
        {
            get { return _DDNo; }
            set { _DDNo = value; }
        }
        public virtual string BankName
        {
            get { return _BankName; }
            set { _BankName = value; }
        }
        public virtual string CustID
        {
            get { return _CustID; }
            set { _CustID = value; }
        }
        public virtual double ReceivedAmount
        {
            get { return _ReceivedAmount; }
            set { _ReceivedAmount = value; }
        }
        public virtual DateTime PaymentDueDate
        {
            get { return _PaymentDueDate; }
            set { _PaymentDueDate = value; }
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
