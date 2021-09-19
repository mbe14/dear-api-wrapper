using DearInventoryLib.Model.Other;
using DearInventoryLib.Model.Product;
using System;
using System.Collections.Generic;

namespace DearInventoryLib.Model.ProductFamily
{
    public class ProductFamilyList : PageObject
    {
        public List<ProductFamily> ProductFamilies { get; set; }
    }

    public class Product: MainObject
    {
        public string SKU { get; set; }
        public string Name { get; set; }
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
    }

    public class ProductFamily : BaseProduct
    {
        public List<Product> Products { get; set; }
        public string Option1Name { get; set; }
        public string Option2Name { get; set; }
        public string Option3Name { get; set; }
        public string Option1Values { get; set; }
        public string Option2Values { get; set; }
        public string Option3Values { get; set; }
        public List<Attachment> Attachments { get; set; }
    }
}
