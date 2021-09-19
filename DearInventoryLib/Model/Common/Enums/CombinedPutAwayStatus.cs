using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DearInventoryLib.Model.Common
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CombinedPutAwayStatus
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
        VOIDED,

        [EnumMember(Value = "")]
        Undefined
    }
}
