using DearInventoryLib.Model.Common;
using DearInventoryLib.Model.Other;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace DearInventoryLib.Model.Product
{
    public class PriceTiers
    {
        [JsonProperty("Tier 1")]
        public decimal Tier1 { get; set; }

        [JsonProperty("Tier 2")]
        public decimal Tier2 { get; set; }

        [JsonProperty("Tier 3")]
        public decimal Tier3 { get; set; }

        [JsonProperty("Tier 4")]
        public decimal Tier4 { get; set; }

        [JsonProperty("Tier 5")]
        public decimal Tier5 { get; set; }

        [JsonProperty("Tier 6")]
        public decimal Tier6 { get; set; }

        [JsonProperty("Tier 7")]
        public decimal Tier7 { get; set; }

        [JsonProperty("Tier 8")]
        public decimal Tier8 { get; set; }

        [JsonProperty("Tier 9")]
        public decimal Tier9 { get; set; }

        [JsonProperty("Tier 10")]
        public decimal Tier10 { get; set; }
    }

    public class ReorderLevel
    {
        public string LocationID { get; set; }
        public string LocationName { get; set; }
        public decimal MinimumBeforeReorder { get; set; }
        public decimal ReorderQuantity { get; set; }
        public string StockLocator { get; set; }
        public string PickZones { get; set; }
    }

    public class BillOfMaterialsProduct
    {
        public string ComponentProductID { get; set; }
        public string ProductCode { get; set; }
        public string Name { get; set; }
        public decimal Quantity { get; set; }
        public decimal WastagePercent { get; set; }
        public decimal WastageQuantity { get; set; }
        public decimal CostPercentage { get; set; }
    }

    public class BillOfMaterialsService
    {
        public string ComponentProductID { get; set; }
        public string Name { get; set; }
        public decimal Quantity { get; set; }
        public string ExpenseAccount { get; set; }
        public decimal PriceTier { get; set; }
    }

    public class Movement
    {
        public string TaskID { get; set; }
        public string Type { get; set; }
        public DateTime Date { get; set; }
        public string Number { get; set; }
        public decimal Quantity { get; set; }
        public decimal Amount { get; set; }
        public string Location { get; set; }
        public string BatchSN { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string FromTo { get; set; }
    }

    public class Product : BaseProduct
    {
        public Type Type { get; set; }
        public decimal Length { get; set; }
        public decimal Width { get; set; }
        public decimal Height { get; set; }
        public decimal Weight { get; set; }
        public string WeightUnits { get; set; }
        public object DimensionsUnits { get; set; }
        public string Barcode { get; set; }
        public PriceTiers PriceTiers { get; set; }
        public decimal AverageCost { get; set; }
        public string InternalNote { get; set; }
        public string AdditionalAttribute1 { get; set; }
        public string AdditionalAttribute2 { get; set; }
        public string AdditionalAttribute3 { get; set; }
        public string AdditionalAttribute4 { get; set; }
        public string AdditionalAttribute5 { get; set; }
        public string AdditionalAttribute6 { get; set; }
        public string AdditionalAttribute7 { get; set; }
        public string AdditionalAttribute8 { get; set; }
        public string AdditionalAttribute9 { get; set; }
        public string AdditionalAttribute10 { get; set; }
        public Status Status { get; set; }
        public string StockLocator { get; set; }
        public bool Sellable { get; set; }
        public string PickZones { get; set; }
        public bool BillOfMaterial { get; set; }
        public bool AutoAssembly { get; set; }
        public bool AutoDisassembly { get; set; }
        public decimal QuantityToProduce { get; set; }
        public string AssemblyInstructionURL { get; set; }
        public string AssemblyCostEstimationMethod { get; set; }
        public List<Supplier> Suppliers { get; set; }
        public List<ReorderLevel> ReorderLevels { get; set; }
        public List<BillOfMaterialsProduct> BillOfMaterialsProducts { get; set; }
        public List<BillOfMaterialsService> BillOfMaterialsServices { get; set; }
        public List<Movement> Movements { get; set; }
        public List<Attachment> Attachments { get; set; }
    }

    public class ProductList
    {
        public int Total { get; set; }
        public int Page { get; set; }
        public List<Product> Products { get; set; }
    }

    public class Supplier
    {
        public Guid SupplierID { get; set; }
        public string SupplierName { get; set; }
        public string SupplierInventoryCode { get; set; }
        public string SupplierProductName { get; set; }
        public decimal Cost { get; set; }
        public decimal FixedCost { get; set; }
        public string Currency { get; set; }
        public bool DropShip { get; set; }
        public DateTime LastSupplied { get; set; }
        public string URL { get; set; }

    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Type
    {
        [EnumMember(Value = "Stock")]
        Stock,

        [EnumMember(Value = "Service")]
        Service
    }
}
