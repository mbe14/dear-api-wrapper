using DearInventoryLib.Model.Common;
using DearInventoryLib.Model.Other;
using System;
using System.Collections.Generic;

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
