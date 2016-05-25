using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RMIS.Entities.BackEnd
{
    public class RMUserRole
    {
        private string _RoleId;
        private string _UserRoleId;
        private string _UserID;
        private string _CustID;
        private string _LastModifiedBy;
        private DateTime _LastModifiedDate;
        private string _ObsInd;

        public virtual string RoleId
        {
            get { return _RoleId; }
            set { _RoleId = value; }
        }
        public virtual string UserRoleId
        {
            get { return _UserRoleId; }
            set { _UserRoleId = value; }
        }

        public virtual string UserID
        {
            get { return _UserID; }
            set { _UserID = value; }
        }

        public virtual string CustID
        {
            get { return _CustID; }
            set { _CustID = value; }
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
