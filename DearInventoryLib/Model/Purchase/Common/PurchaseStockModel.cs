using DearInventoryLib.Model.Common;
using System.Collections.Generic;

namespace DearInventoryLib.Model.Purchase.Common
{
    public class PurchaseStockModel
    {
        public DocumentStatus Status { get; set; }
        public List<PurchaseStockLineModel> Lines { get; set; }
    }
}
