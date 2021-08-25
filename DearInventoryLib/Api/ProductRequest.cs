using DearInventoryLib.Interface;
using DearInventoryLib.Model.Other;
using DearInventoryLib.Model.Product;
using DearInventoryLib.Model.ProductAttachment;
using DearInventoryLib.Model.ProductAvailability;
using DearInventoryLib.Model.ProductFamily;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Product = DearInventoryLib.Model.Product.Product;

namespace DearInventoryLib.Api
{
    public class ProductRequest : RequestBase, IProductRequest
    {
        public ProductRequest(HttpClient httpClient, string accountId, string applicationKey) : base(httpClient, accountId, applicationKey)
        {

        }

        public List<Product> GetAllProducts(bool IncludeDeprecated = false, bool IncludeBOM = false, bool IncludeSuppliers = false, bool IncludeMovements = false, bool IncludeAttachments = false, bool IncludeReorderLevels = false)
        {
            List<Product> result = new List<Product>();
            int page = 1;
            bool moveToNextPage;
            int defaultPageSize = 100;
            
            do
            {
                string s = $"product?Page={page}&Limit={defaultPageSize}";
                s += IncludeDeprecated ? "&IncludeDeprecated=true" : "";
                s += IncludeBOM ? "&IncludeBOM=true" : "";
                s += IncludeSuppliers ? "&IncludeSuppliers=true" : "";
                s += IncludeMovements ? "&IncludeMovements=true" : "";
                s += IncludeAttachments ? "&IncludeAttachments=true" : "";
                s += IncludeReorderLevels ? "&IncludeReorderLevels=true" : "";

                using (HttpResponseMessage response = _httpClient.GetAsync(s).GetAwaiter().GetResult())
                {
                    string responseData = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                    var data = JsonConvert.DeserializeObject<ProductList>(responseData);
                    if (data.Products.Count() > 0)
                    {
                        result.AddRange(data.Products);
                        page++;
                        moveToNextPage = true;
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

        public Product GetProductByID(Guid guid, bool IncludeDeprecated = false, bool IncludeBOM = false, bool IncludeSuppliers = false, bool IncludeMovements = false, bool IncludeAttachments = false, bool IncludeReorderLevels = false)
        {
            string id = guid.ToString();
            Product result = null;

            string s = $"product?ID={id}";
            s += IncludeDeprecated ? "&IncludeDeprecated=true" : "";
            s += IncludeBOM ? "&IncludeBOM=true" : "";
            s += IncludeSuppliers ? "&IncludeSuppliers=true" : "";
            s += IncludeMovements ? "&IncludeMovements=true" : "";
            s += IncludeAttachments ? "&IncludeAttachments=true" : "";
            s += IncludeReorderLevels ? "&IncludeReorderLevels=true" : "";

            using (HttpResponseMessage response = _httpClient.GetAsync(s).GetAwaiter().GetResult())
            {
                string responseData = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                var data = JsonConvert.DeserializeObject<ProductList>(responseData);
                result = data.Products.FirstOrDefault();
            }
            return result;
        }

        public Product GetProductBySKU(string sku, bool IncludeDeprecated = false, bool IncludeBOM = false, bool IncludeSuppliers = false, bool IncludeMovements = false, bool IncludeAttachments = false, bool IncludeReorderLevels = false)
        {
            string _sku = sku;
            Product result = null;

            string s = $"product?SKU={_sku}";
            s += IncludeDeprecated ? "&IncludeDeprecated=true" : "";
            s += IncludeBOM ? "&IncludeBOM=true" : "";
            s += IncludeSuppliers ? "&IncludeSuppliers=true" : "";
            s += IncludeMovements ? "&IncludeMovements=true" : "";
            s += IncludeAttachments ? "&IncludeAttachments=true" : "";
            s += IncludeReorderLevels ? "&IncludeReorderLevels=true" : "";

            using (HttpResponseMessage response = _httpClient.GetAsync($"product?SKU={s}").GetAwaiter().GetResult())
            {
                string responseData = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                var data = JsonConvert.DeserializeObject<ProductList>(responseData);
                result = data.Products.FirstOrDefault();
            }
            return result;
        }

        public string AddProduct(Product product)
        {
            string result = string.Empty;
            var data = JsonConvert.SerializeObject(product);
            using (var content = new StringContent(data, System.Text.Encoding.Default, "application/json"))
            {
                using (HttpResponseMessage response = _httpClient.PostAsync("product", content).GetAwaiter().GetResult())
                {
                    string responseData = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                    if (!response.IsSuccessStatusCode)
                    {
                        throw new Exception(responseData);
                    }
                    else
                    {                       
                        ProductList p = JsonConvert.DeserializeObject<ProductList>(responseData);
                        var productAdded = p.Products.FirstOrDefault();
                        result = productAdded.ID.ToString();
                    }                   
                }
            }
            return result;
        }

        public bool EditProduct(Product product)
        {
            bool result;
            if (product.ID == Guid.Empty || product.ID == null)
            {
                throw new ArgumentNullException("Product ID not declared.");
            }
            var data = JsonConvert.SerializeObject(product);
            using (var content = new StringContent(data, System.Text.Encoding.Default, "application/json"))
            {
                using (HttpResponseMessage response = _httpClient.PutAsync("product", content).GetAwaiter().GetResult())
                {
                    string responseData = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                    if (!response.IsSuccessStatusCode)
                    {
                        throw new Exception(responseData);
                    }
                    else
                    {
                        ProductList p = JsonConvert.DeserializeObject<ProductList>(responseData);
                        result = response.StatusCode == System.Net.HttpStatusCode.OK ? true : false;
                    }                  
                }
            }
            return result;
        }

        public List<AttachmentLineModel> GetProductAttachmentsByProductID(Guid productId)
        {
            string _productId = productId.ToString();
            List<AttachmentLineModel> result = new List<AttachmentLineModel>();
            string s = $"product/attachments?ProductID={_productId}";
            using (HttpResponseMessage response = _httpClient.GetAsync(s).GetAwaiter().GetResult())
            {
                string responseData = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                result = JsonConvert.DeserializeObject<List<AttachmentLineModel>>(responseData);
            }
            return result;
        }

        public List<AttachmentLineModel> AddProductAttachment(ProductAttachment productAttachment)
        {
            List<AttachmentLineModel> result = new List<AttachmentLineModel>();
            if (productAttachment.ProductID == Guid.Empty || productAttachment.ProductID == null)
            {
                throw new ArgumentNullException("Product ID not declared.");
            }
            var data = JsonConvert.SerializeObject(productAttachment);
            using (var content = new StringContent(data, System.Text.Encoding.Default, "application/json"))
            {
                using (HttpResponseMessage response = _httpClient.PostAsync("product/attachments", content).GetAwaiter().GetResult())
                {
                    string responseData = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                    result = JsonConvert.DeserializeObject<List<AttachmentLineModel>>(responseData);
                }
            }
            return result;
        }

        public List<AttachmentLineModel> DeleteProductAttachment(Guid attachmentId)
        {
            List<AttachmentLineModel> result = new List<AttachmentLineModel>();
            if (attachmentId == Guid.Empty || attachmentId == null)
            {
                throw new ArgumentNullException("Attachment ID not declared.");
            }
            string id = attachmentId.ToString();
            using (HttpResponseMessage response = _httpClient.DeleteAsync($"product/attachments?ID={id}").GetAwaiter().GetResult())
            {
                string responseData = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                result = JsonConvert.DeserializeObject<List<AttachmentLineModel>>(responseData);
            }
            return result;
        }

        public List<ProductAvailabilityList> GetProductsAvailability()
        {
            List<ProductAvailabilityList> result = new List<ProductAvailabilityList>();
            int page = 1;
            bool moveToNextPage;
            int defaultPageSize = 100;
            do
            {
                string s = $"ref/productavailability?Page={page}&Limit={defaultPageSize}";

                using (HttpResponseMessage response = _httpClient.GetAsync(s).GetAwaiter().GetResult())
                {
                    string responseData = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                    var data = JsonConvert.DeserializeObject<ProductAvailability>(responseData);
                    if (data.ProductAvailabilityList.Count() > 0)
                    {
                        result.AddRange(data.ProductAvailabilityList);
                        page++;
                        moveToNextPage = true;
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

        public ProductAvailabilityList GetProductAvailabilityBySKU(string sku)
        {
            ProductAvailabilityList result;
            string s = $"ref/productavailability?Sku={sku}";
            using (HttpResponseMessage response = _httpClient.GetAsync(s).GetAwaiter().GetResult())
            {
                string responseData = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                var data = JsonConvert.DeserializeObject<ProductAvailability>(responseData);
                result = data.ProductAvailabilityList.FirstOrDefault();                
            }
            return result;
        }

        public ProductAvailabilityList GetProductAvailabilityByProductID(Guid productId)
        {
            ProductAvailabilityList result;
            string id = productId.ToString();
            string s = $"ref/productavailability?ID={id}";
            using (HttpResponseMessage response = _httpClient.GetAsync(s).GetAwaiter().GetResult())
            {
                string responseData = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                var data = JsonConvert.DeserializeObject<ProductAvailability>(responseData);
                result = data.ProductAvailabilityList.FirstOrDefault();
            }
            return result;
        }

        public List<ProductFamily> GetAllProductFamilies()
        {
            List<ProductFamily> result = new List<ProductFamily>();
            int page = 1;
            bool moveToNextPage;
            int defaultPageSize = 100;
            do
            {
                string s = $"productFamily?Page={page}&Limit={defaultPageSize}";

                using (HttpResponseMessage response = _httpClient.GetAsync(s).GetAwaiter().GetResult())
                {
                    string responseData = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                    var data = JsonConvert.DeserializeObject<ProductFamilyList>(responseData);
                    if (data.ProductFamilies.Count() > 0)
                    {
                        result.AddRange(data.ProductFamilies);
                        page++;
                        moveToNextPage = true;
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

        public bool EditProductFamily(ProductFamily productFamily)
        {
            bool result;
            if (productFamily.ID == Guid.Empty || productFamily.ID == null)
            {
                throw new ArgumentNullException("ProductFamily ID not declared.");
            }
            var data = JsonConvert.SerializeObject(productFamily);
            using (var content = new StringContent(data, System.Text.Encoding.Default, "application/json"))
            {
                using (HttpResponseMessage response = _httpClient.PutAsync("productFamily", content).GetAwaiter().GetResult())
                {
                    string responseData = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                    if (!response.IsSuccessStatusCode)
                    {
                        throw new Exception(responseData);
                    }
                    else
                    {
                        ProductFamilyList p = JsonConvert.DeserializeObject<ProductFamilyList>(responseData);
                        result = response.StatusCode == System.Net.HttpStatusCode.OK ? true : false;
                    }
                }
            }
            return result;
        }

        public string AddProductFamily(ProductFamily productFamily)
        {
            string result = string.Empty;
            var data = JsonConvert.SerializeObject(productFamily);
            using (var content = new StringContent(data, System.Text.Encoding.Default, "application/json"))
            {
                using (HttpResponseMessage response = _httpClient.PostAsync("productFamily", content).GetAwaiter().GetResult())
                {
                    string responseData = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                    if (!response.IsSuccessStatusCode)
                    {
                        throw new Exception(responseData);
                    }
                    else
                    {
                        ProductFamilyList p = JsonConvert.DeserializeObject<ProductFamilyList>(responseData);
                        var productFamilyAdded = p.ProductFamilies.FirstOrDefault();
                        result = productFamilyAdded.ID.ToString();
                    }
                }
            }
            return result;
        }
    }
}
