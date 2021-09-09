using DearInventoryLib.Model.Purchase.Common;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DearInventoryLib.Model.Purchase
{
    public class PurchaseInvoice
    {
        public Guid TaskID { get; set; }
        public bool CombineAdditionalCharges { get; set; }
        public DateTime InvoiceDate { get; set; }
        public DateTime InvoiceDueDate { get; set; }
        public string InvoiceNumber { get; set; }
        public Status Status { get; set; }
        public List<PurchaseInvoiceLineModel> Lines { get; set; }
        public List<PurchaseInvoiceAdditionalChargeModel> AdditionalCharges { get; set; }
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Status
    {
        [EnumMember(Value = "VOIDED")]
        VOIDED,

        [EnumMember(Value = "DRAFT")]
        DRAFT,

        [EnumMember(Value = "AUTHORISED")]
        AUTHORISED,

        [EnumMember(Value = "NOT AVAILABLE")]
        NOT_AVAILABLE,

        [EnumMember(Value = "PAID")]
        PAID,

        [EnumMember(Value = "")]
        Undefined
    }

    public class PurchaseInvoiceAdditionalChargeModel
    {
        public string Description { get; set; }
        public string Reference { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public decimal Tax { get; set; }
        public string TaxRule { get; set; }
        public string Account { get; set; }
        public decimal Total { get; set; }
    }
}
