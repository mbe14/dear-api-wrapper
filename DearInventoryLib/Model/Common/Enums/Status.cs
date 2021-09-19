using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DearInventoryLib.Model.Common
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Status
    {
        [EnumMember(Value = "Deprecated")]
        Deprecated,

        [EnumMember(Value = "Active")]
        Active
    }
}
