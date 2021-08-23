using DearInventoryLib.Api;
using DearInventoryLib.Model.Product;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Configuration;
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
            Guid guid = Guid.Parse("4778e3a5-2cff-4723-ab2a-4cb74de37ebb");
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
        public void GetAllProductAttachments()
        {
            Exception exc = null;
            try
            {
                Guid productId = Guid.Parse("97c3db78-7500-43bc-9ec2-a9a44d80996b");
                var attachments = Api.Product.GetAllProductAttachments(productId);
            }
            catch (Exception ex)
            {
                exc = ex;
            }
            Assert.IsTrue(exc == null);
        }
    }
}
