using DearInventoryLib.Api;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.DearInventoryLib
{
    [TestClass]
    public class TestPurchase
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
        public void GetPurchaseList()
        {
            Exception exc = null;
            try
            {
                var r = Api.Purchase.GetPurchaseList();
            }
            catch (Exception ex)
            {
                exc = ex;
            }
            Assert.IsTrue(exc == null);
        }

        [TestMethod]
        public void GetPurchaseByID()
        {
            Guid guid = Guid.Parse("e0b3671b-568a-4691-b577-40e65bb591b5");
            Exception exc = null;
            try
            {
                var r = Api.Purchase.GetSimplePurchase(guid);
            }
            catch (Exception ex)
            {
                exc = ex;
            }
            Assert.IsTrue(exc == null);
        }
    }
}
