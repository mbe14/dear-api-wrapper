using DearInventoryLib.Model.Common;
using DearInventoryLib.Model.Purchase.Common;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace DearInventoryLib.Model.Purchase
{
    public class AdvancedPurchase : SimplePurchaseModel
    {
        public string InventoryAccount { get; set; }
        public string BaseCurrency { get; set; }
        public string SupplierCurrency { get; set; }
        public string OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public CombinedReceivingStatus CombinedReceivingStatus { get; set; }
        public CombinedInvoiceStatus CombinedInvoiceStatus { get; set; }
        public PaymentStatus CombinedPaymentStatus { get; set; }
        public TypeOfPurchase Type { get; set; }
        public bool IsServiceOnly { get; set; }
        public PurchaseStatus Status { get; set; }
        public Guid RelatedDropShipSaleTask { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public PurchaseOrderModel Order { get; set; }
        public List<AdvancedPurchaseStockModel> StockReceived { get; set; }
        public List<AdvancedPurchasePutAwayModel> PutAway { get; set; }
        public List<AdvancedPurchaseInvoiceModel> Invoice { get; set; }
        public List<AdvancedPurchaseCreditNoteModel> CreditNote { get; set; }
        public List<AdvancedPurchaseManualJournalModel> ManualJournals { get; set; }
        public List<AttachmentLineModel> Attachments { get; set; }
        public InventoryMovementLineModel InventoryMovements { get; set; }
    }

    public class AdvancedPurchasePutAwayModel
    {
        public Guid TaskID { get; set; }
        public Status Status { get; set; }
        public List<AdvancedPurchasePutAwayLineModel> Lines { get; set; }
    }

    public class AdvancedPurchasePutAwayLineModel : LineModel
    {
        public DateTime Date { get; set; }
        public string Location { get; set; }
        public Guid LocationID { get; set; }
        public bool Received { get; set; }
        public string BatchSN { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public Guid CardID { get; set; }
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum CombinedReceivingStatus
    {
        [EnumMember(Value = "FULLY RECEIVED")]
        FULLY_RECEIVED,

        [EnumMember(Value = "PARTIALLY RECEIVED")] 
        PARTIALLY_RECEIVED,

        [EnumMember(Value = "NOT AVAILABLE")]
        NOT_AVAILABLE,

        [EnumMember(Value = "NOT RECEIVED")]
        NOT_RECEIVED,

        [EnumMember(Value = "VOIDED")]
        VOIDED
    }

    public class AdvancedPurchaseStockModel
    {
        public Guid TaskID { get; set; }
        public Status Status { get; set; }
        public List<AdvancedPurchaseStockLineModel> Lines { get; set; }
    }

    public class AdvancedPurchaseInvoiceModel
    {
        public Guid TaskID { get; set; }
        public DateTime InvoiceDate { get; set; }
        public DateTime InvoiceDueDate { get; set; }
        public string InvoiceNumber { get; set; }
        public Status Status { get; set; }
        public List<PurchaseInvoiceLineModel> Lines { get; set; }
        public List<PurchaseInvoiceAdditionalChargeModel> AdditionalCharges { get; set; }
        public List<PurchasePaymentLineModel> MyProperty { get; set; }
    }

    public class PurchasePaymentLineModel
    {

    }

    public class AdvancedPurchaseCreditNoteModel
    {

    }

    public class AdvancedPurchaseManualJournalModel
    {

    }
}
