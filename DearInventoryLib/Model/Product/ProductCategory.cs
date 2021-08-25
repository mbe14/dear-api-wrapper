using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DearInventoryLib.Model.ProductCategory
{
    public class ProductCategoryList
    {
        public int Total { get; set; }
        public int Page { get; set; }
        public List<ProductCategory> CategoryList { get; set; }
    }

    public class ProductCategory
    {     
        public Guid ID { get; set; }
        public string Name { get; set; }
    }
}
