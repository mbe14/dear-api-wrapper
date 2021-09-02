using DearInventoryLib.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DearInventoryLib.Model.Purchase.Common
{
    public class PurchaseInvoiceModel
    {
        public DateTime InvoiceDate { get; set; }
        public DateTime InvoiceDueDate { get; set; }
        public string InvoiceNumber { get; set; }
        public DocumentStatus Status { get; set; }
        public List<PurchaseInvoiceLineModel> Lines { get; set; }
        public List<PurchaseAdditionalChargeModel> AdditionalCharges { get; set; }
        public List<SalePaymentLineModel> Refunds { get; set; }
        public decimal TotalBeforeTax { get; set; }
        public decimal Tax { get; set; }
        public decimal Total { get; set; }
        public decimal Paid { get; set; }

    }
}
