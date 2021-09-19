using DearInventoryLib.Model.Common;
using System;

namespace DearInventoryLib.Model.Purchase.Common
{
    public class PurchaseStockLineModel : StockLineModel
    {
        public Guid LocationID { get; set; }
        public bool Received { get; set; }
        public string SupplierSKU { get; set; }
    }
}
