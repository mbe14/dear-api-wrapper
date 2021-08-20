using DearInventoryLib.Api;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Configuration;

namespace Test.DearInventoryLib
{
    [TestClass]
    public class TestBankAccount
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
                var attribute = Api.BankAccounts.GetAll();
            }
            catch (Exception ex)
            {
                exc = ex;
            }
            Assert.IsTrue(exc == null);
        }
    }
}
