using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DearInventoryLib.Model.Common.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DITaskStatus
    {
        [EnumMember(Value = "DRAFT")]
        DRAFT,

        [EnumMember(Value = "COMPLETED")]
        COMPLETED,

        [EnumMember(Value = "VOIDED")]
        VOIDED
    }
}
