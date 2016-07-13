using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RMIS.Entities.BackEnd
{
    public class MailQueue
    {
        private string _MailId;
        private string _MessageBody;
        private string _Subject;
        private string _ToEmail;
        private DateTime _LastModifiedDate;
        private string _FromEmail;
        private string _Status;

        public virtual string MailId
        {
            get { return _MailId; }
            set { _MailId = value; }
        }
        public virtual string MessageBody
        {
            get { return _MessageBody; }
            set { _MessageBody = value; }
        }
        public virtual string Subject
        {
            get { return _Subject; }
            set { _Subject = value; }
        }
        public virtual string ToEmail
        {
            get { return _ToEmail; }
            set { _ToEmail = value; }
        }
        public virtual DateTime LastModifiedDate
        {
            get { return _LastModifiedDate; }
            set { _LastModifiedDate = value; }
        }
        public virtual string FromEmail
        {
            get { return _FromEmail; }
            set { _FromEmail = value; }
        }

        public virtual string Status
        {
            get { return _Status; }
            set { _Status = value; }
        }
    }
}
