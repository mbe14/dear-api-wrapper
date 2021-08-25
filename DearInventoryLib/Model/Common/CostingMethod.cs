using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DearInventoryLib.Model.Common
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CostingMethod
    {
        [EnumMember(Value = "FIFO")]
        FIFO,

        [EnumMember(Value = "Special - Batch")]
        Special_Batch,

        [EnumMember(Value = "Special - Serial Number")]
        Special_SerialNumber,

        [EnumMember(Value = "FIFO - Serial Number")]
        FIFO_SerialNumber,

        [EnumMember(Value = "FIFO - Batch")]
        FIFO_Batch,

        [EnumMember(Value = "FEFO - Batch")]
        FEFO_Batch,

        [EnumMember(Value = "FEFO - Serial Number")]
        FEFO_SerialNumber
    }
}
