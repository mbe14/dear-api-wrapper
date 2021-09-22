using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DearInventoryLib.Model.AttributeSet
{
    public class Attribute
    {
        public string Name { get; set; }
        public AttributeType Type { get; set; }
        public string Values { get; set; }
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum AttributeType
    {
        [EnumMember(Value = "Not used")]
        NOT_USED,

        [EnumMember(Value = "Text")]
        TEXT,

        [EnumMember(Value = "Checkbox")]
        CHECKBOX,

        [EnumMember(Value = "List")]
        LIST
    }
}
