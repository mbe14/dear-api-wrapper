using DearInventoryLib.Api;
using DearInventoryLib.Model.Common;
using DearInventoryLib.Model.Product;
using DearInventoryLib.Model.ProductAttachment;
using DearInventoryLib.Model.ProductCategory;
using DearInventoryLib.Model.ProductFamily;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Configuration;
using System.Linq;
using Product = DearInventoryLib.Model.Product.Product;
using Type = DearInventoryLib.Model.Product.Type;

namespace Test.DearInventoryLib
{
    [TestClass]
    public class TestProduct
    {
        private string accountId;
        private string applicationKey;
        protected ApiRequest Api;

        [TestInitialize]
        public void Init()
        {
            accountId = ConfigurationManager.AppSettings["AccountId"];
            applicationKey = ConfigurationManager.AppSettings["ApplicationKey"];
            Api = new ApiRequest(accountId, applicationKey);
        }

        [TestMethod]
        public void GetAll()
        {
            Exception exc = null;
            try
            {
                var products = Api.Product.GetAllProducts(IncludeSuppliers: true);
            }
            catch (Exception ex)
            {
                exc = ex;
            }
            Assert.IsTrue(exc == null);
        }

        [TestMethod]
        public void GetBySKU()
        {
            string sku = "101-Gloves-011";
            Exception exc = null;
            try
            {
                var product = Api.Product.GetProductBySKU(sku);
            }
            catch (Exception ex)
            {
                exc = ex;
            }
            Assert.IsTrue(exc == null);
        }

        [TestMethod]
        public void GetByGuid()
        {
            Guid guid = Guid.Parse("907f3980-059b-4374-be26-42604e553257");
            Exception exc = null;
            try
            {
                var product = Api.Product.GetProductByID(guid);
            }
            catch (Exception ex)
            {
                exc = ex;
            }
            Assert.IsTrue(exc == null);
        }

        [TestMethod]
        public void AddNewProduct()
        {
            Product p = new Product()
            {
                Name = "Test Item number 1",
                Barcode = "6009001001010",
                Status = Status.Active,
                AverageCost = 50,
                SKU = "PCO01",
                Type = Type.Stock,
                CostingMethod = CostingMethod.FIFO,
                QuantityToProduce = 100
            };
            Exception exc = null;
            try
            {
                var id = Api.Product.AddProduct(p);
            }
            catch (Exception ex)
            {
                exc = ex;
            }
            Assert.IsTrue(exc == null);
        }

        [TestMethod]
        public void EditProduct()
        {
            Product p = new Product()
            {
                ID = Guid.Parse("97c3db78-7500-43bc-9ec2-a9a44d80996b"),
                Name = "Test Item number 3",
                Barcode = "6009001001010",
                Status = Status.Active,
                AverageCost = 50,
                SKU = "PCO01",
                Type = Type.Stock,
                CostingMethod = CostingMethod.FIFO,
                QuantityToProduce = 100,
                Category = "Test Category",
                UOM = "PAK"
            };
            Exception exc = null;
            try
            {
                var id = Api.Product.EditProduct(p);
            }
            catch (Exception ex)
            {
                exc = ex;
            }
            Assert.IsTrue(exc == null);
        }

        [TestMethod]
        public void GetProductAttachmentsByProductID()
        {
            Exception exc = null;
            try
            {
                Guid productId = Guid.Parse("97c3db78-7500-43bc-9ec2-a9a44d80996b");
                var attachments = Api.Product.GetProductAttachmentsByProductID(productId);
            }
            catch (Exception ex)
            {
                exc = ex;
            }
            Assert.IsTrue(exc == null);
        }

        [TestMethod]
        public void AddProductAttachment()
        {
            Exception exc = null;
            try
            {
                ProductAttachment productAttachment = new ProductAttachment()
                {
                    ProductID = Guid.Parse("97c3db78-7500-43bc-9ec2-a9a44d80996b"),
                    FileName = "Test",
                    Content = "f89sd7f9ds7fs",
                    FileDownloadUrl = "https://file-examples-com.github.io/uploads/2017/10/file_example_JPG_100kB.jpg"
                };
                var attachments = Api.Product.AddProductAttachment(productAttachment);
            }
            catch (Exception ex)
            {
                exc = ex;
            }
            Assert.IsTrue(exc == null);
        }

        [TestMethod]
        public void DeleteProductAttachment()
        {
            Guid attachmentId = Guid.Parse("47b19777-a767-4737-8998-f234b2a7b70f");
            Exception exc = null;
            try
            {
                var attachments = Api.Product.DeleteProductAttachment(attachmentId);
            }
            catch (Exception ex)
            {
                exc = ex;
            }
            Assert.IsTrue(exc == null);
        }

        [TestMethod]
        public void GetProductsAvailability()
        {
            Exception exc = null;
            try
            {
                var p = Api.Product.GetProductsAvailability();
            }
            catch (Exception ex)
            {
                exc = ex;
            }
            Assert.IsTrue(exc == null);
        }

        [TestMethod]
        public void GetProductAvailabilityBySKU()
        {
            string sku = "101-Gloves-012";
            Exception exc = null;
            try
            {
                var p = Api.Product.GetProductAvailabilityBySKU(sku);
            }
            catch (Exception ex)
            {
                exc = ex;
            }
            Assert.IsTrue(exc == null);
        }

        [TestMethod]
        public void GetProductAvailabilityByProductID()
        {
            Guid productId = Guid.Parse("4629d3ad-dd15-4700-8a52-8447bc9bc558");
            Exception exc = null;
            try
            {
                var p = Api.Product.GetProductAvailabilityByProductID(productId);
            }
            catch (Exception ex)
            {
                exc = ex;
            }
            Assert.IsTrue(exc == null);
        }

        [TestMethod]
        public void GetAllProductFamilies()
        {
            Exception exc = null;
            try
            {
                var p = Api.Product.GetAllProductFamilies();
            }
            catch (Exception ex)
            {
                exc = ex;
            }
            Assert.IsTrue(exc == null);
        }

        [TestMethod]
        public void AddNewProductFamily()
        {
            Exception exc = null;
            string rnd = Guid.NewGuid().ToString("n").Substring(0, 8);
            try
            {
                var p = Api.Product.GetAllProductFamilies();
                ProductFamily productFamily = new ProductFamily();
                productFamily = p.FirstOrDefault();
                productFamily.Name += rnd;
                productFamily.SKU = rnd;
                var result = Api.Product.AddProductFamily(productFamily);
            }
            catch (Exception ex)
            {
                exc = ex;
            }
            Assert.IsTrue(exc == null);
        }

        [TestMethod]
        public void EditProductFamily()
        {
            Exception exc = null;
            string rnd = Guid.NewGuid().ToString("n").Substring(0, 8);
            try
            {
                var p = Api.Product.GetAllProductFamilies();
                ProductFamily productFamily = new ProductFamily();
                productFamily = p.FirstOrDefault();
                productFamily.ID = Guid.Parse("2cb5b513-61f1-4ace-ab4f-814ec7965ff8");
                productFamily.Name += rnd;
                productFamily.SKU = rnd;
                var result = Api.Product.EditProductFamily(productFamily);
            }
            catch (Exception ex)
            {
                exc = ex;
            }
            Assert.IsTrue(exc == null);
        }

        [TestMethod]
        public void GetProductCategories()
        {
            Exception exc = null;
            try
            {
                var result = Api.Product.GetProductCategories();
            }
            catch (Exception ex)
            {
                exc = ex;
            }
            Assert.IsTrue(exc == null);
        }

        [TestMethod]
        public void AddProductCategory()
        {
            ProductCategory p = new ProductCategory()
            {
                Name = "Test Category"
            };
            Exception exc = null;
            try
            {
                var result = Api.Product.AddProductCategory(p);
            }
            catch (Exception ex)
            {
                exc = ex;
            }
            Assert.IsTrue(exc == null);
        }

        [TestMethod]
        public void EditProductCategory()
        {
            ProductCategory p = new ProductCategory()
            {
                ID = Guid.Parse(""),
                Name = "New Test Category"
            };
            Exception exc = null;
            try
            {
                var result = Api.Product.EditProductCategory(p);
            }
            catch (Exception ex)
            {
                exc = ex;
            }
            Assert.IsTrue(exc == null);
        }

        [TestMethod]
        public void DeleteProductCategory()
        {
           //Add test
        }

    }
}
