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


   public class GodownTypeDTO
   {
       public GodownTypeDTO()
       {
           GodownType = Indicator = string.Empty;
       }
       public string GodownType
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
