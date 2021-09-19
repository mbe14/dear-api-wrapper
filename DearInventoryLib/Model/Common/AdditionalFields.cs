using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Runtime.Serialization;

namespace DearInventoryLib.Model.Common
{
    public class AdditionalFields
    {
        public Guid ProductID { get; set; }
        public decimal? ProductLength { get; set; }
        public decimal? ProductWidth { get; set; }
        public decimal? ProductHeight { get; set; }
        public decimal? ProductWeight { get; set; }
        public WeightUnits? WeightUnits { get; set; }
        public DimensionUnits? DimensionUnits { get; set; }
        public string ProductCustomField1 { get; set; }
        public string ProductCustomField2 { get; set; }
        public string ProductCustomField3 { get; set; }
        public string ProductCustomField4 { get; set; }
        public string ProductCustomField5 { get; set; }
        public string ProductCustomField6 { get; set; }
        public string ProductCustomField7 { get; set; }
        public string ProductCustomField8 { get; set; }
        public string ProductCustomField9 { get; set; }
        public string ProductCustomField10 { get; set; }
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum WeightUnits
    {
        [EnumMember(Value = "ounces")]
        oz,

        [EnumMember(Value = "miligramm")]
        mg,

        [EnumMember(Value = "kilogramm")]
        kg,

        [EnumMember(Value = "pound")]
        lb,

        [EnumMember(Value = "gram")]
        g
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum DimensionUnits
    {
        [EnumMember(Value = "metre")]
        m,

        [EnumMember(Value = "centimetre")]
        cm,

        [EnumMember(Value = "mile")]
        mi,

        [EnumMember(Value = "millimetre")]
        mm,

        [EnumMember(Value = "inch")]
        _in,

        [EnumMember(Value = "foot")]
        ft,

        [EnumMember(Value = "yard")]
        yd,

        [EnumMember(Value = "kilometre")]
        km
    }
}
