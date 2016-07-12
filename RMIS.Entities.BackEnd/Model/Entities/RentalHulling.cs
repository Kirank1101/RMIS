using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RMIS.Entities.BackEnd
{
    public class RentalHulling
    {
        private string _RentalHulingID;
        private string _CustID;
        private string _JobWorkID;
        private string _Name;
        private string _PaddyType;
        private double _Price;
        private int _TotalBags;
        private DateTime _ProcessedDate;
        private string _LastModifiedBy;
        private DateTime _LastModifiedDate;
        private string _ObsInd;

        public virtual string RentalHulingID
        {
            get { return _RentalHulingID; }
            set { _RentalHulingID = value; }
        }
        public virtual string JobWorkID
        {
            get { return _JobWorkID; }
            set { _JobWorkID = value; }
        }
        public virtual string CustID
        {
            get { return _CustID; }
            set { _CustID = value; }
        }
        public virtual string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public virtual string PaddyType
        {
            get { return _PaddyType; }
            set { _PaddyType = value; }
        }
        public virtual double Price
        {
            get { return _Price; }
            set { _Price = value; }
        }
        public virtual int TotalBags
        {
            get { return _TotalBags; }
            set { _TotalBags = value; }
        }
        public virtual DateTime ProcessedDate
        {
            get { return _ProcessedDate; }
            set { _ProcessedDate = value; }
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
