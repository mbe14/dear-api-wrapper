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
    public class Address
    {
        public Guid ID { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Postcode { get; set; }
        public string Country { get; set; }
        public Type Type { get; set; }
        public bool DefaultForType { get; set; }
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Type
    {
        [EnumMember(Value = "Billing")]
        Billing,

        [EnumMember(Value = "Business")]
        Business,

        [EnumMember(Value = "Shipping")]
        Shipping
    }
}
