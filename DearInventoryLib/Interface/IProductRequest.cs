using DearInventoryLib.Model.Other;
using DearInventoryLib.Model.ProductAvailability;
using DearInventoryLib.Model.ProductFamily;
using System;
using System.Collections.Generic;
using Product = DearInventoryLib.Model.Product.Product;

namespace DearInventoryLib.Interface
{
    interface IProductRequest
    {
        List<Product> GetAllProducts(bool IncludeDeprecated, bool IncludeBOM, bool IncludeSuppliers, bool IncludeMovements, bool IncludeAttachments, bool IncludeReorderLevels);
        Product GetProductBySKU(string sku, bool IncludeDeprecated, bool IncludeBOM, bool IncludeSuppliers, bool IncludeMovements, bool IncludeAttachments, bool IncludeReorderLevels);
        Product GetProductByID(Guid guid, bool IncludeDeprecated, bool IncludeBOM, bool IncludeSuppliers, bool IncludeMovements, bool IncludeAttachments, bool IncludeReorderLevels);
        string AddProduct(Product product);
        bool EditProduct(Product product);
        List<AttachmentLineModel> GetProductAttachmentsByProductID(Guid productId);
        List<AttachmentLineModel> DeleteProductAttachment(Guid attachmentId);
        List<ProductAvailabilityList> GetProductsAvailability();
        ProductAvailabilityList GetProductAvailabilityBySKU(string sku);
        ProductAvailabilityList GetProductAvailabilityByProductID(Guid productId);
        List<ProductFamily> GetAllProductFamilies();
        bool EditProductFamily(ProductFamily productFamily);
        string AddProductFamily(ProductFamily productFamily);

    }
}
