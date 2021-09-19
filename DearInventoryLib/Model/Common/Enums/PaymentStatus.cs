using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DearInventoryLib.Model.Common
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PaymentStatus
    {
        [EnumMember(Value = "PREPAID")]
        PREPAID,

        [EnumMember(Value = "PARTIALLY PAID")]
        PARTIALLY_PAID,

        [EnumMember(Value = "UNPAID")]
        UNPAID,

        [EnumMember(Value = "PAID")]
        PAID,

        [EnumMember(Value = "OVERPAID / CREDITED")]
        OVERPAID_CREDITED,

        [EnumMember(Value = "VOIDED")]
        VOIDED,

        [EnumMember(Value = "")]
        Undefined
    }
}
