using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RMIS.Domain.Business
{
    public interface ISessionProvider
    {
        string  GetCurrentCustomerId();
        string GetLoggedInUserId();


    }

}
