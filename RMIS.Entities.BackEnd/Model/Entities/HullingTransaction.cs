using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RMIS.Entities.BackEnd
{
    public class HullingTransaction
    {
        private string _HullingTransID;
        private string _HullingProcessID;
        private string _ProductTypeID;
        private string _MRiceProdTypeID;
        private string _BrokenRiceTypeID;
        private char _IsDust;
        private string _PaddyTypeID;
        private string _CustID;
        private string _UnitsTypeID;
        private Int16 _TotalBags;
        private double _Price;
        private string _LastModifiedBy;
        private DateTime _LastModifiedDate;
        private string _ObsInd;
       


        public virtual string HullingTransID
        {
            get { return _HullingTransID; }
            set { _HullingTransID = value; }
        }
        public virtual string HullingProcessID
        {
            get { return _HullingProcessID; }
            set { _HullingProcessID = value; }
        }
        public virtual string ProductTypeID
        {
            get { return _ProductTypeID; }
            set { _ProductTypeID = value; }
        }
        public virtual string MRiceProdTypeID
        {
            get { return _MRiceProdTypeID; }
            set { _MRiceProdTypeID = value; }
        }
        public virtual string BrokenRiceTypeID
        {
            get { return _BrokenRiceTypeID; }
            set { _BrokenRiceTypeID = value; }
        }
        public virtual char IsDust
        {
            get { return _IsDust; }
            set { _IsDust = value; }
        }
        public virtual double Price
        {
            get { return _Price; }
            set { _Price = value; }
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
        public virtual string UnitsTypeID
        {
            get { return _UnitsTypeID; }
            set { _UnitsTypeID = value; }
        }
        public virtual Int16 TotalBags
        {
            get { return _TotalBags; }
            set { _TotalBags = value; }
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
