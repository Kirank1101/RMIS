using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RMIS.Domain.Business;

namespace RMIS.UserMessageStore
{
    public class UserMessage : IUserMessage
    {
       public string GetMessage(string msgCode)
       {
           return string.Empty;
       }     
    }
}
