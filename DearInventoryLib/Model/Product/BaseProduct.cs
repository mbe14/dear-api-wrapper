using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Runtime.Serialization;

namespace DearInventoryLib.Model.Product
{
    public class BaseProduct
    {
        public Guid ID { get; set; }
        public string SKU { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string DefaultLocation { get; set; }
        public decimal PriceTier1 { get; set; }
        public decimal PriceTier2 { get; set; }
        public decimal PriceTier3 { get; set; }
        public decimal PriceTier4 { get; set; }
        public decimal PriceTier5 { get; set; }
        public decimal PriceTier6 { get; set; }
        public decimal PriceTier7 { get; set; }
        public decimal PriceTier8 { get; set; }
        public decimal PriceTier9 { get; set; }
        public decimal PriceTier10 { get; set; }
        public decimal MinimumBeforeReorder { get; set; }
        public decimal ReorderQuantity { get; set; }
        public string UOM { get; set; }
        public DateTime LastModifiedOn { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public object AttributeSet { get; set; }
        public object DiscountRule { get; set; }
        public object Brand { get; set; }
        public string Tags { get; set; }
        public object COGSAccount { get; set; }
        public object RevenueAccount { get; set; }
        public object InventoryAccount { get; set; }
        public object PurchaseTaxRule { get; set; }
        public object SaleTaxRule { get; set; }
        public CostingMethod CostingMethod { get; set; }
        public DropShipMode DropShipMode { get; set; }        
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum DropShipMode
    {
        [EnumMember(Value = "No Drop Ship")]
        NoDropShip,

        [EnumMember(Value = "Optional Drop Ship")]
        OptionalDropShip,

        [EnumMember(Value = "Always Drop Ship")]
        AlwaysDropShip
    }

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
