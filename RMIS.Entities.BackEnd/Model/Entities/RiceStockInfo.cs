using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RMIS.Entities.BackEnd
{
    public class RiceStockInfo
    {
        private string _RiceStockID;
        private string _RiceTypeID;
        private string _RiceBrandID; 
        private string _CustID;
        private Int16 _TotalBags; 
        private Int16 _QWeight;
        private string _WeightUnits;
        private string _LastModifiedBy;
        private DateTime _LastModifiedDate;
        private string _ObsInd;

        public virtual string RiceStockID
        {
            get { return _RiceStockID; }
            set { _RiceStockID = value; }
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
        public virtual string WeightUnits
        {
            get { return _WeightUnits; }
            set { _WeightUnits = value; }
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
