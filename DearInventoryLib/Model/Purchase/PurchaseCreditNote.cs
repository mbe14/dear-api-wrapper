using DearInventoryLib.Model.Purchase.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DearInventoryLib.Model.Purchase
{
    public class PurchaseCreditNote
    {
        public Guid TaskID { get; set; }
        public bool CombineAdditionalCharges { get; set; }
        public string CreditNoteNumber { get; set; }
        public DateTime CreditNoteDate { get; set; }
        public Status Status { get; set; }
        public List<PurchaseInvoiceLineModel> Lines { get; set; }
        public List<PurchaseInvoiceAdditionalChargeModel> AdditionalCharges { get; set; }
        public List<PurchaseUnstockLineModel> Unstock { get; set; }
        public decimal TotalBeforeTax { get; set; }
        public decimal Tax { get; set; }
        public decimal Total { get; set; }

    }
}
