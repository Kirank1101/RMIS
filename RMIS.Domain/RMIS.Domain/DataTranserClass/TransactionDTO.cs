using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RMIS.Domain.DataTranserClass
{
    public class PaddyStockDTO
    {
        public PaddyStockDTO()
        {
            Id = SellerName = PaddyName = LotName = GodownName = UnitName =
                VehicalNo = DriverName = string.Empty;
            TotalBags = Price = 0.0M;
        }
        public string Id { get; set; }
        public string SellerName { get; set; }
        public string PaddyName { get; set; }

        public string GodownName { get; set; }
        public string LotName { get; set; }
        public string UnitName { get; set; }
        public string VehicalNo { get; set; }
        public string DriverName { get; set; }
        public decimal TotalBags { get; set; }
        public decimal Price { get; set; }
        public DateTime PurchaseDate { get; set; }

    }
    [Serializable]
    public class BrokenRiceStockDetailsDTO
    {
        public int Id { get; set; }
        public string BrokenRiceTypeID { get; set; }
        public string UnitsTypeID { get; set; }
        public string BrokenRiceType { get; set; }
        public string UnitsType { get; set; }
        public int TotalBags { get; set; }
        public double PricePerBag { get; set; }

    }
    [Serializable]
    public class HullingProcessDTO
    {
        public string HullingProcessID { get; set; }
        public string PaddyTypeID { get; set; }
        public string CustID { get; set; }
        public string UnitsTypeID { get; set; }
        public string MGodownID { get; set; }
        public string MLotID { get; set; }
        public double Price { get; set; }
        public int TotalBags { get; set; }
        public string ProcessedBy { get; set; }
        public DateTime ProcessDate { get; set; }
        public char Status { get; set; }
    }
    public class WidgetDTO
    {
        public WidgetDTO()
        {
            Headerone = HeaderTwo = Value = Percentage = string.Empty;
        }
        public string Headerone { get; set; }
        public string HeaderTwo { get; set; }

        public string Value { get; set; }
        public string Percentage { get; set; }

    }
}
