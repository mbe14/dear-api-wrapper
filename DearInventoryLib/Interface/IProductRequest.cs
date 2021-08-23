using DearInventoryLib.Model.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DearInventoryLib.Interface
{
    interface IProductRequest
    {
        List<Product> GetAllProducts(bool IncludeDeprecated, bool IncludeBOM, bool IncludeSuppliers, bool IncludeMovements, bool IncludeAttachments, bool IncludeReorderLevels);
        Product GetProductBySKU(string sku, bool IncludeDeprecated, bool IncludeBOM, bool IncludeSuppliers, bool IncludeMovements, bool IncludeAttachments, bool IncludeReorderLevels);
        Product GetProductByID(Guid guid, bool IncludeDeprecated, bool IncludeBOM, bool IncludeSuppliers, bool IncludeMovements, bool IncludeAttachments, bool IncludeReorderLevels);
        string AddProduct(Product product);
        bool EditProduct(Product product); //ID is mandatory
    }
}
