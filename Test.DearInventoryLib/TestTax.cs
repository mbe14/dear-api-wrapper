using DearInventoryLib.Api;
using DearInventoryLib.Model.Common;
using DearInventoryLib.Model.Tax;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;

namespace Test.DearInventoryLib
{
    [TestClass]
    public class TestTax
    {
        private string AccountId;
        private string ApplicationKey;
        protected ApiRequest Api;

        [TestInitialize]
        public void Init()
        {
            AccountId = ConfigurationManager.AppSettings["AccountId"];
            ApplicationKey = ConfigurationManager.AppSettings["ApplicationKey"];
            Api = new ApiRequest(AccountId, ApplicationKey);
        }

        [TestMethod]
        public void GetTaxes()
        {
            Exception exc = null;
            try
            {
                var t = Api.Tax.GetAllTaxes();
                var tax = t.FirstOrDefault();
                string account = tax.Account;
                var r = Api.Tax.GetTaxForAccount(account);
            }
            catch (Exception ex)
            {
                exc = ex;
            }
            Assert.IsTrue(exc == null);
        }

        [TestMethod]
        public void AddTax()
        {
            Tax tax = new Tax()
            {
                Account = "2000",
                Name = "A new tax5",
                IsTaxForSale = true,
                IsTaxForPurchase = false,
                Components = new List<TaxComponent>()
                {
                    new TaxComponent()
                    {
                        AccountCode = "2000",
                        ComponentOrder = 1,
                        Name = "Some tax5",
                        Percent = 15
                    }
                }
            };
            Exception exc = null;
            try
            {
                var r = Api.Tax.AddTax(tax);
            }
            catch (Exception ex)
            {
                exc = ex;
            }
            Assert.IsTrue(exc == null);
        }

        [TestMethod]
        public void EditTax()
        {
            Tax tax = new Tax()
            {
                ID = Guid.Parse("fb70894a-8292-4eab-8772-aac28a0d5f5f"),
                Account = "2000",
                Name = "A new tax 2",
                IsTaxForSale = true,
                IsTaxForPurchase = false,
                Components = new List<TaxComponent>()
                {
                    new TaxComponent()
                    {
                        AccountCode = "2000",
                        ComponentOrder = 1,
                        Name = "Some tax",
                        Percent = 15
                    }
                }
            };
            Exception exc = null;
            try
            {
                var r = Api.Tax.EditTax(tax);
            }
            catch (Exception ex)
            {
                exc = ex;
            }
            Assert.IsTrue(exc == null);
        }
    }
}
