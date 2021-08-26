using DearInventoryLib.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DearInventoryLib.Model.Other
{
    public class PurchaseStockModel
    {
        public DocumentStatus Status { get; set; }
        public List<PurchaseStockLineModel> Lines { get; set; }
    }
}
