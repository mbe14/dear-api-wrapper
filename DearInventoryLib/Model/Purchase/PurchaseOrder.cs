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
    public class PurchaseOrder
    {
        public Guid TaskID { get; set; }
        public bool CombineAdditionalCharges { get; set; }
        public string Memo { get; set; }
        public PurchaseOrderStatus Status { get; set; }
        public List<PurchaseOrderLineModel> Lines { get; set; }
        public List<PurchaseAdditionalChargeModel> AdditionalCharges { get; set; }
        public decimal TotalBeforeTax { get; set; }
        public decimal Tax { get; set; }
        public decimal Total { get; set; }


    }

    //For POST only DRAFT and AUTHORISED values accepted
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PurchaseOrderStatus
    {
        [EnumMember(Value = "NOT AVAILABLE")]
        NOT_AVAILABLE,

        [EnumMember(Value = "DRAFT")]
        DRAFT,

        [EnumMember(Value = "AUTHORISED")]
        AUTHORISED,

        [EnumMember(Value = "VOIDED")]
        VOIDED
    }
}
