using DearInventoryLib.Model.Other;
using DearInventoryLib.Model.ProductAvailability;
using DearInventoryLib.Model.ProductCategory;
using DearInventoryLib.Model.ProductFamily;
using System;
using System.Collections.Generic;
using Product = DearInventoryLib.Model.Product.Product;

namespace DearInventoryLib.Interface
{
    interface IProductRequest
    {
        List<Product> GetAllProducts(bool IncludeDeprecated, bool IncludeBOM, bool IncludeSuppliers, bool IncludeMovements, bool IncludeAttachments, bool IncludeReorderLevels);
        Product GetProductBySKU(string Sku, bool IncludeDeprecated, bool IncludeBOM, bool IncludeSuppliers, bool IncludeMovements, bool IncludeAttachments, bool IncludeReorderLevels);
        Product GetProductByID(Guid Guid, bool IncludeDeprecated, bool IncludeBOM, bool IncludeSuppliers, bool IncludeMovements, bool IncludeAttachments, bool IncludeReorderLevels);
        string AddProduct(Product Product);
        bool EditProduct(Product Product);
        List<AttachmentLineModel> GetProductAttachmentsByProductID(Guid ProductId);
        List<AttachmentLineModel> DeleteProductAttachment(Guid AttachmentId);
        List<ProductAvailabilityList> GetProductsAvailability();
        ProductAvailabilityList GetProductAvailabilityBySKU(string Sku);
        ProductAvailabilityList GetProductAvailabilityByProductID(Guid ProductId);
        List<ProductFamily> GetAllProductFamilies();
        bool EditProductFamily(ProductFamily ProductFamily);
        string AddProductFamily(ProductFamily ProductFamily);
        List<ProductCategory> GetProductCategories();
        string AddProductCategory(ProductCategory ProductCategory);
        bool EditProductCategory(ProductCategory ProductCategory);
        bool DeleteProductCategory(Guid Guid);

    }
}
