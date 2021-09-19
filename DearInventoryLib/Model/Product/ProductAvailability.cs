using System;
using System.Collections.Generic;

namespace DearInventoryLib.Model.ProductAvailability
{
    public class ProductAvailabilityList : MainObject
    {
        public string SKU { get; set; }
        public string Name { get; set; }
        public string Barcode { get; set; }
        public string Location { get; set; }
        public string Bin { get; set; }
        public string Batch { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public decimal OnHand { get; set; }
        public decimal Allocated { get; set; }
        public decimal Available { get; set; }
        public decimal OnOrder { get; set; }
        public decimal StockOnHand { get; set; }
    }

    public class ProductAvailability : PageObject
    {
        public List<ProductAvailabilityList> ProductAvailabilityList { get; set; }
    }
}
