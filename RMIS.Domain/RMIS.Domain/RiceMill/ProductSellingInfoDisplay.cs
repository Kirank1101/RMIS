using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RMIS.Domain.Abstract;

namespace RMIS.Domain.RiceMill
{
    [Serializable]
    public class ProductSellingInfoDisplay : AbstractAllInOne
    {
        public string ProductID { get; set; }
        public string BuyerName { get; set; }
        public string ProductType { get; set; }
        public string ProductName { get; set; }
        public string Brand { get; set; }
        public string UnitsType { get; set; }
        public int TotalBags { get; set; }
        public double Price { get; set; }
        public double TotalPrice { get; set; }

    }
}
