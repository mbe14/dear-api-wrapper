using System;
using System.Collections.Generic;

namespace DearInventoryLib.Model.ProductCategory
{
    public class ProductCategoryList : PageObject
    {
        public List<ProductCategory> CategoryList { get; set; }
    }

    public class ProductCategory : MainObject
    { 
        public string Name { get; set; }
    }
}
