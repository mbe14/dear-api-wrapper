namespace DearInventoryLib.Model.Purchase.Common
{
    public class PurchaseAdditionalChargeModel
    {
        public string Description { get; set; }
        public string Reference { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
        public decimal Discount { get; set; }
        public decimal Tax { get; set; }
        public decimal Total { get; set; }
        public string TaxRule { get; set; }
    }
}
