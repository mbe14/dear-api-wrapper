using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DearInventoryLib.Service
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Field
    {
        [EnumMember(Value = "ID")]
        ID,

        [EnumMember(Value = "Bank")]
        Bank,

        [EnumMember(Value = "Name")]
        AccountName,

        [EnumMember(Value = "Sku")]
        SKU
    }
}
