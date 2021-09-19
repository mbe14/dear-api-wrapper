using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DearInventoryLib.Model.Common
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DocumentStatus
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

        [EnumMember(Value = "PARTIALLY RECEIVED")]
        PARTIALLY_RECEIVED,

        [EnumMember(Value = "")]
        Undefined
    }
}
