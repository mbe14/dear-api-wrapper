using DearInventoryLib.Model.Common;
using System;
using System.Collections.Generic;

namespace DearInventoryLib.Model.Purchase
{
    public class PurchasesList : PagedData
    {
        public List<PurchaseData> PurchaseList { get; set; }

    }

    public class PurchaseData : DIModel
    {
        public bool BlindReceipt { get; set; }
        public string OrderNumber { get; set; }
        public PurchaseStatus Status { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public string Supplier { get; set; }
        public Guid SupplierID { get; set; }
        public string InvoiceNumber { get; set; }
        public decimal InvoiceAmount { get; set; }
        public decimal PaidAmount { get; set; }
        public DateTime? InvoiceDueDate { get; set; }
        public DateTime? RequiredBy { get; set; }
        public string BaseCurrency { get; set; }
        public string SupplierCurrency { get; set; }
        public string CreditNoteNumber { get; set; }
        public DocumentStatus OrderStatus { get; set; }
        public DocumentStatus StockReceivedStatus { get; set; }
        public DocumentStatus UnstockStatus { get; set; }
        public DocumentStatus InvoiceStatus { get; set; }
        public DocumentStatus CreditNoteStatus { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public CombinedPutAwayStatus CombinedReceivingStatus { get; set; }
        public CombinedInvoiceStatus CombinedInvoiceStatus { get; set; }
        public PaymentStatus CombinedPaymentStatus { get; set; }
        public TypeOfPurchase Type { get; set; }
        public bool IsServiceOnly { get; set; }
        public Guid? DropShipTaskID { get; set; }


    }
}

