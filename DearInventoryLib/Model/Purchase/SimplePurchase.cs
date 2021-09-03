using DearInventoryLib.Model.Common;
using DearInventoryLib.Model.Other;
using DearInventoryLib.Model.Purchase.Common;
using System;
using System.Collections.Generic;

namespace DearInventoryLib.Model.Purchase
{
    public class SimplePurchase : BaseSimplePurchase
    {
        public string InventoryAccount { get; set; }
        public string BaseCurrency { get; set; }
        public string SupplierCurrency { get; set; }
        public string OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public PurchaseStatus Status { get; set; }
        public Guid? RelatedDropShipSaleTask { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public PurchaseOrderModel Order { get; set; }
        public PurchaseStockModel StockReceived { get; set; }
        public PurchaseInvoiceModel Invoice { get; set; }
        public PurchaseCreditNoteModel CreditNote { get; set; }
        public PurchaseManualJournalModel ManualJournals { get; set; }
        public List<Attachment> Attachments { get; set; }
        public List<InventoryMovementLineModel> InventoryMovements { get; set; }

    }

    public class SimplePurchaseModel : BaseSimplePurchase
    {

    }

    public class BaseSimplePurchase
    {
        public Guid ID { get; set; }
        public Guid SupplierID { get; set; }
        public string Supplier { get; set; }
        public string Contact { get; set; }
        public string Phone { get; set; }
        public bool BlindReceipt { get; set; }
        public string Approach { get; set; }
        public BillingAddress BillingAddress { get; set; }
        public ShippingAddress ShippingAddress { get; set; }
        public string TaxRule { get; set; }
        public string TaxCalculation { get; set; }
        public string Terms { get; set; }
        public DateTime? RequiredBy { get; set; }
        public string Location { get; set; }
        public string Note { get; set; }
        public decimal CurrencyRate { get; set; }
        public AdditionalAttribute AdditionalAttributes { get; set; }
    }
}
