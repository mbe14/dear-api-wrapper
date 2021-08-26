using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DearInventoryLib.Model.Common
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CombinedInvoiceStatus
    {
        [EnumMember(Value = "INVOICED")]
        INVOICED,

        [EnumMember(Value = "INVOICED / CREDITED")]
        INVOICED_CREDITED,

        [EnumMember(Value = "NOT AVAILABLE")]
        NOT_AVAILABLE,

        [EnumMember(Value = "NOT INVOICED")]
        NOT_INVOICED,

        [EnumMember(Value = "PARTIALLY INVOICED")]
        PARTIALLY_INVOICED,

        [EnumMember(Value = "PARTIALLY INVOICED / CREDITED")]
        PARTIALLY_INVOICED_CREDITED,

        [EnumMember(Value = "")]
        Undefined
    }
}
