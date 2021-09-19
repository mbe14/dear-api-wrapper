using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DearInventoryLib.DataAccess.Enum
{
    [JsonConverter(typeof(StringEnumConverter))]
    internal enum HTTPMethod
    {
        [EnumMember(Value = "GET")]
        GET,

        [EnumMember(Value = "PUT")]
        PUT,

        [EnumMember(Value = "POST")]
        POST,

        [EnumMember(Value = "DELETE")]
        DELETE
    }
}
