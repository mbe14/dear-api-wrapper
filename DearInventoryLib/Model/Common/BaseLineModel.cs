using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Runtime.Serialization;

namespace DearInventoryLib.Model.Common
{
    public class BaseLineModel : AdditionalFields
    {
        public Guid ProductID { get; set; }
        public string SKU { get; set; }
        public string Name { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public decimal Tax { get; set; }
        public string TaxRule { get; set; }
        public string SupplierSKU { get; set; }
        public string Comment { get; set; }
        public decimal Total { get; set; }       
    }    
}
