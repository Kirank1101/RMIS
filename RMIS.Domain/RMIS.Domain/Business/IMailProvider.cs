using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RMIS.Domain.Business
{
    public interface IMailProvider
    {
        void CallMailQueue();
        bool AddToMailQueue(string messagebody, string subject, string to);
    }
}
