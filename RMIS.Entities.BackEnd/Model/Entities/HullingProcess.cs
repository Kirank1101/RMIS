using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RMIS.Entities.BackEnd
{
    public class HullingProcess
    {
        private string _HullingProcessID;
        private string _PaddyTypeID; 
        private string _CustID;
        private string _UnitsTypeID;
        private string _MGodownID;
        private Int16 _TotalBags;
        private string _ProcessedBy;
        private DateTime _ProcessDate;
        private string _LastModifiedBy;
        private DateTime _LastModifiedDate;
        private string _ObsInd;
        private string _Status;

        public virtual string HullingProcessID
        {
            get { return _HullingProcessID; }
            set { _HullingProcessID = value; }
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
        public virtual string MGodownID
        {
            get { return _MGodownID; }
            set { _MGodownID = value; }
        }
        public virtual Int16 TotalBags
        {
            get { return _TotalBags; }
            set { _TotalBags = value; }
        }
        public virtual string ProcessedBy
        {
            get { return _ProcessedBy; }
            set { _ProcessedBy = value; }
        }
        public virtual DateTime ProcessDate
        {
            get { return _ProcessDate; }
            set { _ProcessDate = value; }
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
        public virtual string Status
        {
            get { return _Status; }
            set { _Status = value; }
        }
    }
}
