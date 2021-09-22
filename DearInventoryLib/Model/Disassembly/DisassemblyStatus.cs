using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DearInventoryLib.Model.Disassembly
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DisassemblyStatus
    {
        [EnumMember(Value = "DRAFT")]
        DRAFT,

        [EnumMember(Value = "WORK IN PROGRESS")]
        WORK_IN_PROGRESS,

        [EnumMember(Value = "COMPLETED")]
        COMPLETED,

        [EnumMember(Value = "VOIDED")]
        VOIDED
    }
}
