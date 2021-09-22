using DearInventoryLib.Model.Common;
using DearInventoryLib.Model.Common;
using System.Collections.Generic;

namespace DearInventoryLib.Model.Purchase.Common
{
    public class PurchaseOrderModel
    {
        public string Memo { get; set; }
        public DocumentStatus Status { get; set; }
        public List<PurchaseOrderLineModel> Lines { get; set; }
        public List<PurchaseAdditionalChargeModel> AdditionalCharges { get; set; }
        public List<SalePaymentLineModel> Prepayments { get; set; }
        public decimal TotalBeforeTax { get; set; }
        public decimal Tax { get; set; }
        public decimal Total { get; set; }
    }
}
