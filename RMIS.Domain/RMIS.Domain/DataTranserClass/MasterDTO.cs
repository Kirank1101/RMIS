using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RMIS.Domain.DataTranserClass
{

    public  class MasterPaddyDTO
    {
        public MasterPaddyDTO()
        {
            Id = Indicator =string.Empty;
        }
        public string Id
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

    public class PaddyTypeDTO : MasterPaddyDTO
    {
        public PaddyTypeDTO():base()
        {
            PaddyType = string.Empty;
        }
        public string PaddyType
        {
            get;
            set;
        }

    }
    public class BrokenRiceTypeDTO : MasterPaddyDTO
    {
        public BrokenRiceTypeDTO()
            : base()
        {
            BrokenRiceType = string.Empty;
        }
        public string BrokenRiceType
        {
            get;
            set;
        }

    }
    public class SellerTypeDTO : MasterPaddyDTO
    {
       public SellerTypeDTO():base()
       {
           SellerType = string.Empty;
       }
       public string SellerType
       {
           get;
           set;
       }
      
    }
    public class MBagTypeDTO : MasterPaddyDTO
    {
        public MBagTypeDTO()
            : base()
        {
            BagType = string.Empty;
        }
        public string BagType
        {
            get;
            set;
        }

    }
    public class MUnitsTypeDTO : MasterPaddyDTO
    {
        public MUnitsTypeDTO()
            : base()
        {
            UnitsType = string.Empty;
        }
        public string UnitsType
        {
            get;
            set;
        }

    }

    public class GodownTypeDTO : MasterPaddyDTO
   {
        public GodownTypeDTO()
            : base()
       {
           GodownType  = string.Empty;
       }
       public string GodownType
       {
           get;
           set;
       }
   }

    public class RiceBrandDTO : MasterPaddyDTO
   {
        public RiceBrandDTO()
            : base()
       {
           RiceBrand  = string.Empty;
       }
       public string RiceBrand
       {
           get;
           set;
       }     
   }

    public class RiceProductDTO : MasterPaddyDTO
   {
        public RiceProductDTO()
            : base()
       {
           RiceProduct = string.Empty;
       }
       public string RiceProduct
       {
           get;
           set;
       }       
   }

    public class LotDetailsDTO : MasterPaddyDTO
   {
        public LotDetailsDTO()
            : base()
       {
           LotDetails =GodownId = string.Empty;
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
    }

    public class WeightDetailsDTO : MasterPaddyDTO
   {
        public WeightDetailsDTO()
            : base()
       {            
            WeightDetails = 0;
       }
       public int  WeightDetails
       {
           get;
           set;
       }    

   }
}
