using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RMIS.Entities.BackEnd
{
    public class BrokenRiceStockInfo
    {
        private string _BrokenRiceStockID;
        private string _BrokenRiceTypeID; 
        private string _CustID;
        private Int16 _TotalBags; 
        private Int16 _QWeight;
        private string _UnitsTypeID;
        private string _LastModifiedBy;
        private DateTime _LastModifiedDate;
        private string _ObsInd;

        public virtual string BrokenRiceStockID
        {
            get { return _BrokenRiceStockID; }
            set { _BrokenRiceStockID = value; }
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
        public virtual string UnitsTypeID
        {
            get { return _UnitsTypeID; }
            set { _UnitsTypeID = value; }
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
