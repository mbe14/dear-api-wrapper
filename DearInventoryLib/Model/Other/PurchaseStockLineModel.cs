using DearInventoryLib.Model.Common;
using System;

namespace DearInventoryLib.Model.Other
{
    public class PurchaseStockLineModel : BaseStockLineModel
    {       
        public Guid LocationID { get; set; }
        public bool Received { get; set; }        
        public string SupplierSKU { get; set; }            
    }
}
