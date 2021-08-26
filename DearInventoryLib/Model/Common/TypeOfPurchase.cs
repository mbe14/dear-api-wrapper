using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DearInventoryLib.Model.Common
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TypeOfPurchase
    {
        [EnumMember(Value = "Simple Purchase")]
        Simple_Purchase,

        [EnumMember(Value = "Advanced Purchase")]
        Advanced_Purchase,

        [EnumMember(Value = "Service Purchase")]
        Service_Purchase
    }
}
