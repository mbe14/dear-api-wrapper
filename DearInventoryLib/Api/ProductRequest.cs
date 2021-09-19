using DearInventoryLib.Interface;
using DearInventoryLib.Model.Other;
using DearInventoryLib.Model.Product;
using DearInventoryLib.Model.ProductAttachment;
using DearInventoryLib.Model.ProductAvailability;
using DearInventoryLib.Model.ProductCategory;
using DearInventoryLib.Model.ProductFamily;
using DearInventoryLib.Service;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Product = DearInventoryLib.Model.Product.Product;

namespace DearInventoryLib.Api
{
    public class ProductRequest : RequestService, IProductRequest
    {
        private const string URLAttribute = "product";
        private const string URLAttributeAttachments = "product/attachments";
        private const string URLAttributeAvailability = "ref/productavailability";
        private const string URLAttributeProductFamily = "productFamily";
        private const string URLAttributeProductCategories = "ref/category";
        public ProductRequest(HttpClient HttpClient, string AccountId, string ApplicationKey) : base(HttpClient, AccountId, ApplicationKey)
        {

        }

        public List<Product> GetAllProducts(bool IncludeDeprecated = false, bool IncludeBOM = false, bool IncludeSuppliers = false, bool IncludeMovements = false, bool IncludeAttachments = false, bool IncludeReorderLevels = false)
        {
            List<Product> result = new List<Product>();
            int page = 1;
            bool moveToNextPage = true;
            int defaultPageSize = 100;

            do
            {
                URLParameter = $"{URLAttribute}?Page={page}&Limit={defaultPageSize}";
                URLParameter += IncludeDeprecated ? "&IncludeDeprecated=true" : "";
                URLParameter += IncludeBOM ? "&IncludeBOM=true" : "";
                URLParameter += IncludeSuppliers ? "&IncludeSuppliers=true" : "";
                URLParameter += IncludeMovements ? "&IncludeMovements=true" : "";
                URLParameter += IncludeAttachments ? "&IncludeAttachments=true" : "";
                URLParameter += IncludeReorderLevels ? "&IncludeReorderLevels=true" : "";

                if (SendHttpRequest(HTTPMethod.GET, out string httpResponse) == System.Net.HttpStatusCode.OK)
                {
                    var data = JsonConvert.DeserializeObject<ProductList>(httpResponse);
                    if (data.Products.Count() > 0)
                    {
                        result.AddRange(data.Products);
                        page++;
                    }
                    else
                    {
                        moveToNextPage = false;
                    }
                }
            }
            while (moveToNextPage);
            return result;
        }

        public Product GetProductByID(Guid Guid, bool IncludeDeprecated = false, bool IncludeBOM = false, bool IncludeSuppliers = false, bool IncludeMovements = false, bool IncludeAttachments = false, bool IncludeReorderLevels = false)
        {
            string id = Guid.ToString();
            Product result = null;

            URLParameter = $"product?ID={id}";
            URLParameter += IncludeDeprecated ? "&IncludeDeprecated=true" : "";
            URLParameter += IncludeBOM ? "&IncludeBOM=true" : "";
            URLParameter += IncludeSuppliers ? "&IncludeSuppliers=true" : "";
            URLParameter += IncludeMovements ? "&IncludeMovements=true" : "";
            URLParameter += IncludeAttachments ? "&IncludeAttachments=true" : "";
            URLParameter += IncludeReorderLevels ? "&IncludeReorderLevels=true" : "";

            if (SendHttpRequest(HTTPMethod.GET, out string httpResponse) == System.Net.HttpStatusCode.OK)
            {
                var data = JsonConvert.DeserializeObject<ProductList>(httpResponse);
                result = data.Products.FirstOrDefault();
            }
            return result;
        }

        public Product GetProductBySKU(string Sku, bool IncludeDeprecated = false, bool IncludeBOM = false, bool IncludeSuppliers = false, bool IncludeMovements = false, bool IncludeAttachments = false, bool IncludeReorderLevels = false)
        {
            string _sku = Sku;
            Product result = null;

            URLParameter = $"product?SKU={_sku}";
            URLParameter += IncludeDeprecated ? "&IncludeDeprecated=true" : "";
            URLParameter += IncludeBOM ? "&IncludeBOM=true" : "";
            URLParameter += IncludeSuppliers ? "&IncludeSuppliers=true" : "";
            URLParameter += IncludeMovements ? "&IncludeMovements=true" : "";
            URLParameter += IncludeAttachments ? "&IncludeAttachments=true" : "";
            URLParameter += IncludeReorderLevels ? "&IncludeReorderLevels=true" : "";

            if (SendHttpRequest(HTTPMethod.GET, out string httpResponse) == System.Net.HttpStatusCode.OK)
            {
                var data = JsonConvert.DeserializeObject<ProductList>(httpResponse);
                result = data.Products.FirstOrDefault();
            }
            return result;
        }

        public string AddProduct(Product Product)
        {
            string result = string.Empty;
            URLParameter = URLAttribute;
            if (SendHttpRequest(HTTPMethod.POST, out string httpResponse, content: Product) == System.Net.HttpStatusCode.OK)
            {
                var data = JsonConvert.DeserializeObject<ProductList>(httpResponse);
                var productAdded = data.Products.FirstOrDefault();
                result = productAdded.ID.ToString();
            }
            return result;
        }

        public bool EditProduct(Product Product)
        {
            URLParameter = URLAttribute;
            if (SendHttpRequest(HTTPMethod.PUT, out _, content: Product) == System.Net.HttpStatusCode.OK)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<AttachmentLineModel> GetProductAttachmentsByProductID(Guid ProductId)
        {
            List<AttachmentLineModel> result = new List<AttachmentLineModel>();
            string _productId = ProductId.ToString();
            URLParameter = $"{URLAttributeAttachments}?ProductID={_productId}";
            if (SendHttpRequest(HTTPMethod.GET, out string httpResponse) == System.Net.HttpStatusCode.OK)
            {
                var data = JsonConvert.DeserializeObject<List<AttachmentLineModel>>(httpResponse);
                result = data;
            }
            return result;
        }

        public List<AttachmentLineModel> AddProductAttachment(ProductAttachment ProductAttachment)
        {
            List<AttachmentLineModel> result = new List<AttachmentLineModel>();
            URLParameter = $"{URLAttributeAttachments}";
            if (SendHttpRequest(HTTPMethod.POST, out string httpResponse, content: ProductAttachment) == System.Net.HttpStatusCode.OK)
            {
                var data = JsonConvert.DeserializeObject<List<AttachmentLineModel>>(httpResponse);               
                result = data;
            }
            return result;
        }

        public bool DeleteProductAttachment(Guid AttachmentId)
        {
            string id = AttachmentId.ToString();
            URLParameter = $"{URLAttributeAttachments}?ID={id}";
            if (SendHttpRequest(HTTPMethod.DELETE, out _) == System.Net.HttpStatusCode.OK)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<ProductAvailabilityList> GetProductsAvailability()
        {
            List<ProductAvailabilityList> result = new List<ProductAvailabilityList>();
            int page = 1;
            bool moveToNextPage = true;
            int defaultPageSize = 100;
            do
            {
                URLParameter = $"{URLAttributeAvailability}?Page={page}&Limit={defaultPageSize}";
                if (SendHttpRequest(HTTPMethod.GET, out string httpResponse) == System.Net.HttpStatusCode.OK)
                {
                    var data = JsonConvert.DeserializeObject<ProductAvailability>(httpResponse);
                    if (data.ProductAvailabilityList.Count() > 0)
                    {
                        result.AddRange(data.ProductAvailabilityList);
                        page++;
                    }
                    else
                    {
                        moveToNextPage = false;
                    }
                }
            }
            while (moveToNextPage);
            return result;
        }

        public ProductAvailabilityList GetProductAvailabilityBySKU(string Sku)
        {
            string filter = Sku;
            ProductAvailabilityList result = JsonConvert.DeserializeObject<ProductAvailability>(RetrieveDataByField(Field.SKU, filter, URLAttributeAvailability)).ProductAvailabilityList.FirstOrDefault();
            return result;
        }

        public ProductAvailabilityList GetProductAvailabilityByProductID(Guid ProductId)
        {
            string filter = ProductId.ToString();
            ProductAvailabilityList result = JsonConvert.DeserializeObject<ProductAvailability>(RetrieveDataByField(Field.ID, filter, URLAttributeAvailability)).ProductAvailabilityList.FirstOrDefault();
            return result;
        }

        public List<ProductFamily> GetAllProductFamilies()
        {
            List<ProductFamily> result = new List<ProductFamily>();
            int page = 1;
            bool moveToNextPage = true;
            int defaultPageSize = 100;
            do
            {
                URLParameter = $"{URLAttributeProductFamily}?Page={page}&Limit={defaultPageSize}";
                if (SendHttpRequest(HTTPMethod.GET, out string httpResponse) == System.Net.HttpStatusCode.OK)
                {
                    var data = JsonConvert.DeserializeObject<ProductFamilyList>(httpResponse);
                    if (data.ProductFamilies.Count() > 0)
                    {
                        result.AddRange(data.ProductFamilies);
                        page++;
                    }
                    else
                    {
                        moveToNextPage = false;
                    }
                }
            }
            while (moveToNextPage);
            return result;
        }

        public bool EditProductFamily(ProductFamily ProductFamily)
        {
            URLParameter = URLAttributeProductFamily;
            if (SendHttpRequest(HTTPMethod.PUT, out _, content: ProductFamily) == System.Net.HttpStatusCode.OK)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string AddProductFamily(ProductFamily ProductFamily)
        {
            string result = string.Empty;
            URLParameter = $"{URLAttributeAttachments}";
            if (SendHttpRequest(HTTPMethod.POST, out string httpResponse, content: ProductFamily) == System.Net.HttpStatusCode.OK)
            {
                var data = JsonConvert.DeserializeObject<ProductFamilyList>(httpResponse);
                var productFamilyAdded = data.ProductFamilies.FirstOrDefault();
                result = productFamilyAdded.ID.ToString();
            }
            return result;            
        }

        public List<ProductCategory> GetProductCategories()
        {
            List<ProductCategory> result = new List<ProductCategory>();
            int page = 1;
            bool moveToNextPage = true;
            int defaultPageSize = 100;
            do
            {
                URLParameter = $"{URLAttributeProductCategories}?Page={page}&Limit={defaultPageSize}";
                if (SendHttpRequest(HTTPMethod.GET, out string httpResponse) == System.Net.HttpStatusCode.OK)
                {
                    var data = JsonConvert.DeserializeObject<ProductCategoryList>(httpResponse);
                    if (data.CategoryList.Count() > 0)
                    {
                        result.AddRange(data.CategoryList);
                        page++;
                    }
                    else
                    {
                        moveToNextPage = false;
                    }
                }
            }
            while (moveToNextPage);
            return result;
        }

        public string AddProductCategory(ProductCategory ProductCategory)
        {
            string result = string.Empty;
            URLParameter = $"{URLAttributeProductCategories}";
            if (SendHttpRequest(HTTPMethod.POST, out string httpResponse, content: ProductCategory) == System.Net.HttpStatusCode.OK)
            {
                ProductCategory p = JsonConvert.DeserializeObject<ProductCategory>(httpResponse);
                result = p.ID.ToString();
            }
            return result;
        }

        public bool EditProductCategory(ProductCategory ProductCategory)
        {
            URLParameter = URLAttributeProductCategories;
            if (SendHttpRequest(HTTPMethod.PUT, out _, content: ProductCategory) == System.Net.HttpStatusCode.OK)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteProductCategory(Guid Guid)
        {
            string id = Guid.ToString();
            URLParameter = $"{URLAttributeProductCategories}?ID={id}";
            if (SendHttpRequest(HTTPMethod.DELETE, out _) == System.Net.HttpStatusCode.OK)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
