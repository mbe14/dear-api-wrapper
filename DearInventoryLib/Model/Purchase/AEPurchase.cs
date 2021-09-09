using DearInventoryLib.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DearInventoryLib.Model.Purchase
{
    public class AEPurchase
    {
        public Guid ID { get; set; } //Unique DEAR Purchase ID.Required for PUT
        public Guid SupplierID { get; set; } // Identifier of Supplier. Required if Supplier not provided
        public string Supplier { get; set; }
        public string Contact { get; set; }
        public string Phone { get; set; }
        public bool BlindReceipt { get; set; }
        public string Approach { get; set; }
        public BillingAddress BillingAddress { get; set; }
        public BillingAddress ShippingAddress { get; set; }
        public string TaxRule { get; set; }
        public string TaxCalculation { get; set; }
        public string Terms { get; set; }
        public DateTime RequiredBy { get; set; }
        public string Location { get; set; }
        public TypeOfPurchase PurchaseType { get; set; }
        public string Note { get; set; }
        public bool IsServiceOnly { get; set; }
        public decimal CurrencyRate { get; set; }
        public AdditionalAttribute AdditionalAttributes { get; set; }
    }
}
