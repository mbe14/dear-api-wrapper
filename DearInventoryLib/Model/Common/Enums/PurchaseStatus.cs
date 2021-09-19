using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DearInventoryLib.Model.Common
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PurchaseStatus
    {
        [EnumMember(Value = "DRAFT")] //No data is added to Purchase details.
        DRAFT,

        [EnumMember(Value = "VOIDED")] //Task has been voided
        VOIDED,

        [EnumMember(Value = "ORDERING")] //OrderStatus = DRAFT
        ORDERING,

        [EnumMember(Value = "ORDERED")] //OrderStatus = AUTHORISED
        ORDERED,

        [EnumMember(Value = "RECEIVING")] //OrderStatus = AUTHORISED, StockReceivedStatus = DRAFT
        RECEIVING,

        [EnumMember(Value = "RECEIVED")] //StockReceivedStatus = AUTHORISED
        RECEIVED,

        [EnumMember(Value = "INVOICED")] //InvoiceStatus = AUTHORISED
        INVOICED,

        [EnumMember(Value = "CREDITED")] //CreditNoteStatus = AUTHORISED
        CREDITED,

        [EnumMember(Value = "RECEIVING / CREDITED")] //Combined Stock Status = PARTIALLY RECEIVED, RestockReceivedStatus = AUTHORISED
        RECEIVING_CREDITED,

        [EnumMember(Value = "RECEIVED / CREDITED")] //Combined Stock Status = FULLY RECEIVED, RestockReceivedStatus = AUTHORISED
        RECEIVED_CREDITED,

        [EnumMember(Value = "PARTIALLY INVOICED")] //Combined Invoice Status = PARTIALLY INVOICED
        PARTIALLY_INVOICED,

        [EnumMember(Value = "COMPLETED")] //InvoiceStatus = AUTHORISED, RestockReceivedStatus = AUTHORISED
        COMPLETED
    }
}
