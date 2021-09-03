using System;

namespace DearInventoryLib.Model.Common
{
    public class BaseStockLineModel
    {
        public Guid CardID { get; set; }
        public DateTime Date { get; set; }
        public decimal Quantity { get; set; }
        public Guid ProductID { get; set; }
        public string SKU { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string BatchSN { get; set; }
        public DateTime? ExpiryDate { get; set; }
    }
}
