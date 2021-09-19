using DearInventoryLib.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DearInventoryLib.Model.Purchase
{    
    public class AdvancedPurchaseStockReceived
    {
        public Guid PurchaseID { get; set; }
        public Guid TaskID { get; set; }
        public Status Status { get; set; }
        public List<AdvancedPurchaseStockLineModel> Lines { get; set; }
    }

    public class AdvancedPurchaseStockLineModel : AdditionalFields
    {
        public DateTime Date { get; set; }
        public decimal Quantity { get; set; }
        public string SKU { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public Guid LocationID { get; set; }
        public bool Received { get; set; }
        public string BatchSN { get; set; }
        public string SupplierSKU { get; set; }
        public DateTime? ExpiryDate { get; set; }
    }
}
