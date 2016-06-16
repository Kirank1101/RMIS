using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RMIS.Domain.DataTranserClass
{

    public class MasterPaddyDTO
    {
        public MasterPaddyDTO()
        {
            Id = Indicator = string.Empty;
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
        public PaddyTypeDTO()
            : base()
        {
            PaddyType = string.Empty;
        }
        public string PaddyType
        {
            get;
            set;
        }

    }
    public class ProductSellingTypeDTO : MasterPaddyDTO
    {
        public ProductSellingTypeDTO()
            : base()
        {
            ProductSellingType = string.Empty;
        }
        public string ProductSellingType
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
            GodownType = string.Empty;
        }
        public const string dataColumnGodownType = "GodownType";
        public const string dataColumnId = "Id";
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
            RiceBrand = string.Empty;
        }
        public string RiceBrand
        {
            get;
            set;
        }
    }

    public class RiceTypeDTO : MasterPaddyDTO
    {
        public RiceTypeDTO()
            : base()
        {
            RiceType = string.Empty;
        }
        public string RiceType
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
            LotDetails = GodownId = string.Empty;
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
        public int WeightDetails
        {
            get;
            set;
        }

    }
    public class MEmpDesigDTO : MasterPaddyDTO
    {
        public MEmpDesigDTO()
            : base()
        {
            DesignationType = string.Empty;
        }
        public const string dataColumnText = "DesignationType";
        public const string dataColumnId = "Id";
        
        public string DesignationType
        {
            get;
            set;
        }

    }
    public class MSalarytypeDTO : MasterPaddyDTO
    {
        public MSalarytypeDTO()
            : base()
        {
            SalaryType = string.Empty;
        }
        public const string dataColumnText = "SalaryType";
        public const string dataColumnId = "Id";
        public string SalaryType
        {
            get;
            set;
        }

    }

}
