using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RMIS.Domain.DataTranserClass
{
   public  class SellerTypeDTO
    {
       public SellerTypeDTO()
       {
           SellerType = Indicator = string.Empty;
       }
       public string SellerType
       {
           get;
           set;
       }

       public string Indicator
       {
           get;
           set;
       }
    }
}
