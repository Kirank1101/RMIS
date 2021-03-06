﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RMIS.Entities.BackEnd
{
    public class MenuConfiguration
    {
        private string _MenuConfigId;
        private int _MenuID;
        private string _CustID;
        private string _RoleId;
        private string _LastModifiedBy;
        private DateTime _LastModifiedDate;
        private string _ObsInd;

        public virtual string MenuConfigId
        {
            get { return _MenuConfigId; }
            set { _MenuConfigId = value; }
        }

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
        public virtual string RoleId
        {
            get { return _RoleId; }
            set { _RoleId = value; }
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
