using System;
using System.Collections.Generic;

namespace DearInventoryLib.Model.ProductCategory
{
    public class ProductCategoryList : PagedData
    {
        public List<ProductCategory> CategoryList { get; set; }
    }

    public class ProductCategory : DIModel
    { 
        public string Name { get; set; }
    }
}
