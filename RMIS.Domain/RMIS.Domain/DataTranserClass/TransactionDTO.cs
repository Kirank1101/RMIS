using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RMIS.Domain.DataTranserClass
{
    public class PaddyPaymentDueDTO
    {
        public PaddyPaymentDueDTO()
        {
            SellerID=SellerName  = string.Empty;
            TotalAmount = TotalAmountDue = TotalAmountPaid = 0.0;
        }
        public string SellerID { get; set; }
        public string SellerName { get; set; }
        public double TotalAmount { get; set; }
        public double TotalAmountPaid { get; set; }
        public double TotalAmountDue { get; set; }
    }
    public class PaddyPaymentDTO
    {
        public PaddyPaymentDTO()
        {
            SellerName =PaymentMode=  string.Empty;
            AmountPaid = 0.0;
        }
        
        public string SellerName { get; set; }
        public double AmountPaid { get; set; }
        public DateTime PaidDate { get; set; }
        public string PaymentMode { get; set; }
        public DateTime NextPayDate { get; set; }
    }
    public class PaddyStockDTO
    {
        public PaddyStockDTO()
        {
            Id = SellerName = PaddyName = LotName = GodownName = UnitName =
                VehicalNo = DriverName = string.Empty;
            TotalBags = Price = 0.0;
        }
        public string Id { get; set; }
        public string SellerName { get; set; }
        public string PaddyName { get; set; }

        public string GodownName { get; set; }
        public string LotName { get; set; }
        public string UnitName { get; set; }
        public string VehicalNo { get; set; }
        public string DriverName { get; set; }
        public double TotalBags { get; set; }
        public double Price { get; set; }
        public DateTime PurchaseDate { get; set; }

    }
    public class PaddyStockOverViewDTO
    {
        public PaddyStockOverViewDTO()
        {
            PaddyName = LotName = GodownName = UnitName = string.Empty;
            TotalBags = 0.0;
        }
        public string PaddyName { get; set; }
        public string GodownName { get; set; }
        public string LotName { get; set; }
        public string UnitName { get; set; }
        public double TotalBags { get; set; }

    }
    public class BagStockDTO
    {
        public BagStockDTO()
        {
            Id = SellerName = TypeBrand = UnitName = VehicalNo = DriverName = string.Empty;
            TotalBags = 0; Price = 0.0;
        }
        public string Id { get; set; }
        public string SellerName { get; set; }
        public string TypeBrand { get; set; }

        public string UnitName { get; set; }
        public string VehicalNo { get; set; }
        public string DriverName { get; set; }
        public int TotalBags { get; set; }
        public double Price { get; set; }
        public double TotalAmount { get; set; }
        public DateTime PurchaseDate { get; set; }

    }

    [Serializable]
    public class SellerInfoDTO
    {
        public string ID { get; set; }
        public string SellerName { get; set; }
        public string Town { get; set; }
        public string ContactNo { get; set; }
        public string MobileNo { get; set; }
    }
    [Serializable]
    public class BuyerInfoDTO
    {
        public string ID { get; set; }
        public string BuyerName { get; set; }
        public string Town { get; set; }
        public string ContactNo { get; set; }
        public string MobileNo { get; set; }
    }
    [Serializable]
    public class ProductBuyerPaymentDTO
    {
        public int SlNo { get; set; }
        public string ProductPaymentID { get; set; }
        public string BuyerName { get; set; }
        public double TotalAmountDue { get; set; }
        public DateTime SellingDate { get; set; }
    }
    [Serializable]
    public class ProductSellingInfoDTO
    {
        public int ProductID { get; set; }
        public string SellingProductType { get; set; }
        public string BuyerID { get; set; }
        public string MRiceProdTypeID { get; set; }
        public string MRiceBrandID { get; set; }
        public string BrokenRiceTypeID { get; set; }
        public string UnitsTypeID { get; set; }
        public string BuyerName { get; set; }
        public string ProductType { get; set; }
        public string ProductName { get; set; }
        public string Brand { get; set; }
        public string UnitsType { get; set; }
        public int TotalBags { get; set; }
        public double Price { get; set; }
        public double TotalPrice { get; set; }
        public DateTime ProductSellingDate { get; set; }
    }


    [Serializable]
    public class RiceStockDetailsDTO
    {
        public int Id { get; set; }
        public string MRiceProdTypeID { get; set; }
        public string MRiceBrandID { get; set; }
        public string UnitsTypeID { get; set; }
        public string RiceType { get; set; }
        public string BrandName { get; set; }
        public string UnitsType { get; set; }
        public int TotalBags { get; set; }
        public double PricePerBag { get; set; }

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
        public string Status { get; set; }
    }
    public class PaddySpentOnHullingProcessDTO
    {
        public PaddySpentOnHullingProcessDTO()
        {
            PaddyName = LotName = GodownName = UnitName = string.Empty;
            TotalBags = 0.0;
        }
        public string PaddyName { get; set; }
        public string GodownName { get; set; }
        public string LotName { get; set; }
        public string UnitName { get; set; }
        public double TotalBags { get; set; }

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
