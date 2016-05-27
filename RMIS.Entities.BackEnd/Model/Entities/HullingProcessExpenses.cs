using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RMIS.Entities.BackEnd
{
    public class HullingProcessExpenses
    {
        private string _HullingProcessExpenID; 
        private string _HullingProcessID;        
        private string _CustID;
        private double _PowerExpenses;
        private double _LabourExpenses;
        private double _OtherExpenses;
        private string _LastModifiedBy;
        private DateTime _LastModifiedDate;
        private string _ObsInd;
        
        public virtual string HullingProcessExpenID
        {
            get { return _HullingProcessExpenID; }
            set { _HullingProcessExpenID = value; }
        }
        public virtual string HullingProcessID
        {
            get { return _HullingProcessID; }
            set { _HullingProcessID = value; }
        }
        public virtual string CustID
        {
            get { return _CustID; }
            set { _CustID = value; }
        }
        public virtual double PowerExpenses
        {
            get { return _PowerExpenses; }
            set { _PowerExpenses = value; }
        }        
        public virtual double LabourExpenses
        {
            get { return _LabourExpenses; }
            set { _LabourExpenses = value; }
        }
        public virtual double OtherExpenses
        {
            get { return _OtherExpenses; }
            set { _OtherExpenses = value; }
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
