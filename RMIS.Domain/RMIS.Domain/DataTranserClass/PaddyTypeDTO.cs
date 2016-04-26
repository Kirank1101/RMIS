using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RMIS.Domain.DataTranserClass
{
    public class PaddyTypeDTO
    {
        public PaddyTypeDTO()
        {
            PaddyType = Indicator = string.Empty;
        }
        public string PaddyType
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
