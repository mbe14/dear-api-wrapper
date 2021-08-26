using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DearInventoryLib.Model.Common
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DocumentStatus
    {
        [EnumMember(Value = "VOIDED")]
        VOIDED,

        [EnumMember(Value = "DRAFT")]
        DRAFT,

        [EnumMember(Value = "AUTHORISED")]
        AUTHORISED,

        [EnumMember(Value = "NOT AVAILABLE")]
        NOT_AVAILABLE,

        [EnumMember(Value = "PAID")]
        PAID,

        [EnumMember(Value = "PARTIALLY RECEIVED")]
        PARTIALLY_RECEIVED,

        [EnumMember(Value = "")]
        Undefined
    }
}
