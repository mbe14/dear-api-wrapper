using DearInventoryLib.Model.Purchase.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DearInventoryLib.Model.Purchase
{
    public class PurchaseStockReceived
    {
        public Guid TaskID { get; set; }
        public PurchaseOrderStatus Status { get; set; }
        public List<PurchaseStockLineModel> Lines { get; set; }
    }
}
