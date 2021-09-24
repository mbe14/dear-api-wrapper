using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DearInventoryLib.Model.FixedAssetType
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AveragingMethod
    {
        [EnumMember(Value = "Full Month")]
        FULL_MONTH,

        [EnumMember(Value = "Actual Days")]
        ACTUAL_DAYS
    }
}