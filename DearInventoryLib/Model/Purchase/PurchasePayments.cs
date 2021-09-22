using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Runtime.Serialization;

namespace DearInventoryLib.Model.Purchase
{
    public class PurchasePayments : DIModel
    {
        public Guid TaskID { get; set; }
        public PaymentType Type { get; set; }
        public string Reference { get; set; }
        public decimal Amount { get; set; }
        public DateTime DatePaid { get; set; }
        public string Account { get; set; }
        public decimal CurrencyRate { get; set; }
        public DateTime DateCreated { get; set; }

    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum PaymentType
    {
        [EnumMember(Value = "PREPAYMENT")]
        PREPAYMENT,

        [EnumMember(Value = "PAYMENT")]
        PAYMENT,

        [EnumMember(Value = "REFUND")]
        REFUND,

        [EnumMember(Value = "")]
        Undefined
    }
}
