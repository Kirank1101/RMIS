using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RMIS.Domain.DataTranserClass
{
    public class ExpenseDetailsDTO
    {
        public ExpenseDetailsDTO()
        {
            ExpenseType = GivenTo = Amount = Reason = string.Empty;
        }
        public string ExpenseType { get; set; }
        public string GivenTo { get; set; }
        public string Amount { get; set; }
        public DateTime PaidDate { get; set; }
        public string Reason { get; set; }
    }
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
        public DateTime NextPayDate { get; set; }
    }
    public class PaddyPaymentReceiptDTO
    {
        public PaddyPaymentReceiptDTO()
        {
            SellerName =PaymentMode=  string.Empty;            
        }
        public string ID { get; set; }
        public string SellerName { get; set; }
        public string PaidAmount { get; set; }
        public DateTime PaidDate { get; set; }
        public string PaymentMode { get; set; }
        public DateTime NextPayDate { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public int PinCode { get; set; }
        public string ContactNo { get; set; }
        public string TIN { get; set; }
    }
    public class PaddyPaymentDTO
    {
        public PaddyPaymentDTO()
        {
            ID=SellerName = PaymentMode = string.Empty;
            AmountPaid = 0.0;
        }
        public string ID { get; set; }
        public string SellerName { get; set; }
        public double AmountPaid { get; set; }
        public string DisplayAmountPaid { get; set; }
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
        public string PriceDisplay { get; set; }
        public double TotalPrice { get; set; }
        public DateTime PurchaseDate { get; set; }
        public DateTime NextPayDate { get; set; }
        public int UsedBags { get; set; }
        public string AllBagsUsed { get; set; }
    }

    public class PaddyPurchaseReceiptDTO
    {
        public PaddyPurchaseReceiptDTO()
        {
            Id = SellerName = PaddyType = UnitName =string.Empty;
            Price = 0.0;
        }

        public string Id { get; set; }
        public string SellerName { get; set; }
        public string PaddyType { get; set; }
        public string UnitName { get; set; }
        public int TotalBags { get; set; }
        public decimal Quintals { get; set; }
        public string QuintalPrice { get; set; }
        public string TotalPrice { get; set; }
        public double Price { get; set; }
        public string PriceDisplay { get; set; }
        public string GrandTotalPrice { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public int PinCode { get; set; }
        public string ContactNo { get; set; }
        public string TIN { get; set; }


    }
    public class PaddyStockOverViewDTO
    {
        public PaddyStockOverViewDTO()
        {
            PaddyName = LotName = GodownName = UnitName = string.Empty;
            TotalBags = 0;
        }
        public string PaddyName { get; set; }
        public string GodownName { get; set; }
        public string LotName { get; set; }
        public string UnitName { get; set; }
        public int TotalBags { get; set; }

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
    public class BagPaymentDTO
    {
        public BagPaymentDTO()
        {
            SellerName = PaymentMode = string.Empty;
            AmountPaid = 0.0;
        }

        public string SellerName { get; set; }
        public double AmountPaid { get; set; }
        public DateTime PaidDate { get; set; }
        public string PaymentMode { get; set; }
        public DateTime NextPayDate { get; set; }
    }
    public class BagPaymentDueDTO
    {
        public BagPaymentDueDTO()
        {
            SellerID = SellerName = string.Empty;
            TotalAmount = TotalAmountDue = TotalAmountPaid = 0.0;
        }
        public string SellerID { get; set; }
        public string SellerName { get; set; }
        public double TotalAmount { get; set; }
        public double TotalAmountPaid { get; set; }
        public double TotalAmountDue { get; set; }
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
        public string MediatorName { get; set; }
        public double TotalAmountDue { get; set; }
        public DateTime SellingDate { get; set; }
    }
    [Serializable]
    public class ProductSellingInfoDTO
    {
        public string ProdID { get; set; }
        public int ProductID { get; set; }
        public string SellingProductType { get; set; }
        public string BuyerID { get; set; }
        public string MediatorID { get; set; }
        public string MRiceProdTypeID { get; set; }
        public string MRiceBrandID { get; set; }
        public string BrokenRiceTypeID { get; set; }
        public string UnitsTypeID { get; set; }
        public string BuyerName { get; set; }
        public string MediatorName { get; set; }
        public string ProductType { get; set; }
        public string ProductName { get; set; }
        public string Brand { get; set; }
        public string UnitsType { get; set; }
        public int TotalBags { get; set; }
        public double Price { get; set; }
        public double TotalPrice { get; set; }
        public DateTime ProductSellingDate { get; set; }        
    }
    public class ProductSellingInvoiceDTO
    {
        public string MillName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string EmailId { get; set; }
        public string BuyerName { get; set; }
        public string BuyerAddress1 { get; set; }
        public string BuyerAddress2 { get; set; }
        public string BuyerAddress3 { get; set; }
        public string MediatorName { get; set; }
        public string MediatorContactNo { get; set; }
        public string VehicalNo { get; set; }
        public string DriverName { get; set; }
        public string ItemName { get; set; }
        public int TotalBags { get; set; }
        public string Weight { get; set; }
        public decimal TotalQtl { get; set; }
        public string Price { get; set; }
        public string Amount { get; set; }
        public string TotalAmount { get; set; }
        public string TINNumber { get; set; }
        public string BuyerTINNumber { get; set; }
        public string CustContactNo { get; set; }
        public string CustOffPhNo { get; set; }
        public string BuyerContactNo { get; set; }
    }
    public class ProductPaymentDTO
    {
        
        public ProductPaymentDTO()
        {
            BuyerName = MediatorName = PaymentMode = string.Empty;
            
        }
        public int TranNo { get; set; }
        public string BuyerName { get; set; }
        public string MediatorName { get; set; }
        public string AmountPaid { get; set; }
        public DateTime PaidDate { get; set; }
        public string PaymentMode { get; set; }
        public DateTime NextPayDate { get; set; }
        public string TotalAmount { get; set; }
        public string BalanceAmount { get; set; }
        public string CompPayment { get; set; }
        public string PaySettlement { get; set; }
    }
    public class ProductPaymentDueDTO
    {

        public ProductPaymentDueDTO()
        {
            BuyerName = MediatorName = string.Empty;

        }public string BuyerName { get; set; }
        public string MediatorName { get; set; }
        public string TotalAmount { get; set; }
        public string ReceivedAmount { get; set; }
        public string OutstandingDue { get; set; }
        public DateTime NextPayDate { get; set; }
    }
    public class DustStockDetailsDTO 
    {
        public string DustStockID { get; set; }
        public string CustID { get; set; }
        public int TotalBags { get; set; }
        public string UnitsTypeID { get; set; }
        
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
        public double PriceperQuintal { get; set; }

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
        public string Status { get; set; }
    }

    public class HullingProcessExpenseDTO
    {
        public string HullingProcessExpenID { get; set; }
        public string HullingProcessID { get; set; }
        public double HullingExpenses { get; set; }
        
    }
    public class PaddySpentOnHullingProcessDTO
    {
        public PaddySpentOnHullingProcessDTO()
        {
            PaddyName = LotName = GodownName = UnitName = string.Empty;
            TotalBags = 0;
        }
        public string PaddyName { get; set; }
        public string GodownName { get; set; }
        public string LotName { get; set; }
        public string UnitName { get; set; }
        public int TotalBags { get; set; }

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
    public class MediatorInfoDTO
    {
        public string ID { get; set; }
        public string MediatorName { get; set; }
        public string Town { get; set; }
        public string ContactNo { get; set; }
        public string MobileNo { get; set; }
    }

    public class BankTransactionDTO
    {
        public DateTime TransactionDate { get; set; }
        public string Description { get; set; }
        public double Withdrawal { get; set; }
        public double Deposits { get; set; }
        public double Balance { get; set; }
    }
    public class RentHullingDTO
    {
        public string JobType { get; set; }
        public string Name { get; set; }
        public string PaddyType { get; set; }
        public int TotalBags { get; set; }
        public double Price { get; set; }
        public DateTime ProcessDate { get; set; }
    }
    public class OtherExpenses
    {
        public string ExpenseType { get; set; }
        public string Name { get; set; }
        public double PaidAmount { get; set; }
        public DateTime PaidDate { get; set; }
        public string Reason { get; set; }
    }
    public class ProfileDTO
    {
        public ProfileDTO()
        { 
        
        }
        public string MillName { get; set; }
        public string TINNumber { get; set; }
        public string Street1 { get; set; }
        public string Street2 { get; set; }
        public string Town { get; set; }
        public string City { get; set; }
        public string  District { get; set; }
        public string State { get; set; }
        public int PinCode { get; set; }
        public string ContactNo { get; set; }
        public string MobileNo { get; set; }
        public string PhoneNo { get; set; }
    }
}
