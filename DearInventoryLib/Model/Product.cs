using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DearInventoryLib.Model
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
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

    public class Attachment
    {
        public string ID { get; set; }
        public string ContentType { get; set; }
        public string FileName { get; set; }
        public string DownloadUrl { get; set; }
    }

    public class Product
    {
        public Guid ID { get; set; }
        public string SKU { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public object Brand { get; set; }
        public string Type { get; set; }
        public string CostingMethod { get; set; }
        public string DropShipMode { get; set; }
        public string DefaultLocation { get; set; }
        public decimal Length { get; set; }
        public decimal Width { get; set; }
        public decimal Height { get; set; }
        public decimal Weight { get; set; }
        public string UOM { get; set; }
        public string WeightUnits { get; set; }
        public object DimensionsUnits { get; set; }
        public string Barcode { get; set; }
        public decimal MinimumBeforeReorder { get; set; }
        public decimal ReorderQuantity { get; set; }
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
        public PriceTiers PriceTiers { get; set; }
        public decimal AverageCost { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
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
        public object AttributeSet { get; set; }
        public object DiscountRule { get; set; }
        public string Tags { get; set; }
        public string Status { get; set; }
        public string StockLocator { get; set; }
        public object COGSAccount { get; set; }
        public object RevenueAccount { get; set; }
        public object ExpenseAccount { get; set; }
        public object InventoryAccount { get; set; }
        public object PurchaseTaxRule { get; set; }
        public object SaleTaxRule { get; set; }
        public DateTime LastModifiedOn { get; set; }
        public bool Sellable { get; set; }
        public string PickZones { get; set; }
        public bool BillOfMaterial { get; set; }
        public bool AutoAssembly { get; set; }
        public bool AutoDisassembly { get; set; }
        public decimal QuantityToProduce { get; set; }
        public string AssemblyInstructionURL { get; set; }
        public string AssemblyCostEstimationMethod { get; set; }
        public List<object> Suppliers { get; set; }
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


}
