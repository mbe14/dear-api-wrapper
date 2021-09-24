using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DearInventoryLib.Model.FixedAssetType
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DepreciationMethod
    {
        [EnumMember(Value = "No Depreciation")]
        NO_DEPRECIATION,

        [EnumMember(Value = "Straight Line")]
        STRAIGHT_LINE,

        [EnumMember(Value = "Declining Balance")]
        DECLINING_BALANCE,

        [EnumMember(Value = "Declining Balance (150%)")]
        DECLINING_BALANCE_150,

        [EnumMember(Value = "Declining Balance (200%)")]
        DECLINING_BALANCE_200,

        [EnumMember(Value = "Sum of the Years' Digits")]
        SUM_OF_THE_YEARS_DIGITS,

        [EnumMember(Value = "Full Depreciation at Purchase")]
        FULL_DEPRECIATION_AT_PURCHASE
    }
}