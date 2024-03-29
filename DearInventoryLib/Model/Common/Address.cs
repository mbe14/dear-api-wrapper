﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Runtime.Serialization;

namespace DearInventoryLib.Model.Common
{
    public class Address : DIModel
    {
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Postcode { get; set; }
        public string Country { get; set; }
        public AddressType Type { get; set; }
        public bool DefaultForType { get; set; }
    }

    public class BillingAddress
    {
        public string DisplayAddressLine1 { get; set; }
        public string DisplayAddressLine2 { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Postcode { get; set; }
        public string Country { get; set; }
    }

    public class ShippingAddress : BillingAddress
    {
        public bool ShipToOther { get; set; }
        public string Company { get; set; }
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum AddressType
    {
        [EnumMember(Value = "Billing")]
        Billing,

        [EnumMember(Value = "Business")]
        Business,

        [EnumMember(Value = "Shipping")]
        Shipping
    }
}
