using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DearInventoryLib.Model.FinishedGoods
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FinishedGoodsTaskStatus
    {
        [EnumMember(Value = "DRAFT")]
        DRAFT,

        [EnumMember(Value = "AUTHORISED")]
        AUTHORISED,

        [EnumMember(Value = "IN PROGRESS")]
        IN_PROGRESS,

        [EnumMember(Value = "COMPLETED")]
        COMPLETED,

        [EnumMember(Value = "VOIDED")]
        VOIDED
    }
}
