using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DearInventoryLib.Model.Common
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DropShipMode
    {
        [EnumMember(Value = "No Drop Ship")]
        NoDropShip,

        [EnumMember(Value = "Optional Drop Ship")]
        OptionalDropShip,

        [EnumMember(Value = "Always Drop Ship")]
        AlwaysDropShip
    }
}
