using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RMIS.Entities.BackEnd
{
    public class MenuInfo
    {
        private int _MenuID;
        private string _CustID;
        private int _ParentMenuID;
        private string _Title;
        private string _Description;
        private string _URL;
        private string _LastModifiedBy;
        private DateTime _LastModifiedDate;
        private string _ObsInd;

        public virtual int MenuID
        {
            get { return _MenuID; }
            set { _MenuID = value; }
        }
        public virtual string CustID
        {
            get { return _CustID; }
            set { _CustID = value; }
        }

        public virtual int ParentMenuID
        {
            get { return _ParentMenuID; }
            set { _ParentMenuID = value; }
        }
        public virtual string Title
        {
            get { return _Title; }
            set { _Title = value; }
        }
        public virtual string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }

        public virtual string URL
        {
            get { return _URL; }
            set { _URL = value; }
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
