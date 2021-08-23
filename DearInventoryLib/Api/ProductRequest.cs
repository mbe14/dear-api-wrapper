using DearInventoryLib.Interface;
using DearInventoryLib.Model.Other;
using DearInventoryLib.Model.Product;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

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

                using (var response = _httpClient.GetAsync(s).GetAwaiter().GetResult())
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

            using (var response = _httpClient.GetAsync(s).GetAwaiter().GetResult())
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

            using (var response = _httpClient.GetAsync($"product?SKU={s}").GetAwaiter().GetResult())
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
                using (var response = _httpClient.PostAsync("product", content).GetAwaiter().GetResult())
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
            var data = JsonConvert.SerializeObject(product);
            using (var content = new StringContent(data, System.Text.Encoding.Default, "application/json"))
            {
                using (var response = _httpClient.PutAsync("product", content).GetAwaiter().GetResult())
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

        public List<AttachmentLineModel> GetAllProductAttachments(Guid productId)
        {
            string _productId = productId.ToString();
            List<AttachmentLineModel> result = new List<AttachmentLineModel>();
            string s = $"product/attachments?ProductID={_productId}";
            using (var response = _httpClient.GetAsync(s).GetAwaiter().GetResult())
            {
                string responseData = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                result = JsonConvert.DeserializeObject<List<AttachmentLineModel>>(responseData);
            }
            return result;
        }
    }
}
