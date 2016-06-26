using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RMIS.Entities.BackEnd
{
    public class MessageInfo
    {
        private string _MessageTypeID;
        private string _CustID;
        private string _MessageCode;
        private string _Message;    
        private string _LastModifiedBy;
        private DateTime _LastModifiedDate;
        private string _ObsInd;

        public virtual string MessageTypeID
        {
            get { return _MessageTypeID; }
            set { _MessageTypeID = value; }
        }
        public virtual string CustID
        {
            get { return _CustID; }
            set { _CustID = value; }
        }
        public virtual string MessageCode
        {
            get { return _MessageCode; }
            set { _MessageCode = value; }
        }
        public virtual string Message
        {
            get { return _Message; }
            set { _Message = value; }
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
