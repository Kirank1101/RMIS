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

   public class RiceBrandDTO
   {
       public RiceBrandDTO()
       {
           RiceBrand = Indicator = string.Empty;
       }
       public string RiceBrand
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

   public class RiceProductDTO
   {
       public RiceProductDTO()
       {
           RiceProduct = Indicator = string.Empty;
       }
       public string RiceProduct
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

   public class LotDetailsDTO
   {
       public LotDetailsDTO()
       {
           LotDetails =GodownId= Indicator = string.Empty;
       }
       public string LotDetails
       {
           get;
           set;
       }

       public string GodownId
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

   public class WeightDetailsDTO
   {
       public WeightDetailsDTO()
       {
            Indicator = string.Empty;
            WeightDetails = 0;
       }
       public int  WeightDetails
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
