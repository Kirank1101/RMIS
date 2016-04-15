using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RMIS.Domain.Business
{
    public interface ICustomerProvider
    {
        string  GetCurrentCustomerId();
    }

}
