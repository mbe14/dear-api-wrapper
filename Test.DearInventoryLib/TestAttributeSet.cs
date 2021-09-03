using DearInventoryLib.Api;
using DearInventoryLib.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Configuration;

namespace Test.DearInventoryLib
{
    [TestClass]
    public class TestAttributeSet
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
                var attribute = Api.AttributeSet.GetAll();
            }
            catch (Exception ex)
            {
                exc = ex;
            }
            Assert.IsTrue(exc == null);
        }

        [TestMethod]
        public void GetById()
        {
            Guid id = Guid.Parse("eda5fdb2-50db-4b47-a050-24eb41c305c0");
            Exception exc = null;
            try
            {
                var attribute = Api.AttributeSet.GetById(id);
            }
            catch (Exception ex)
            {
                exc = ex;
            }
            Assert.IsTrue(exc == null);
        }

        [TestMethod]
        public void GetByName()
        {
            string name = "Additional_Properties";
            Exception exc = null;
            try
            {
                var attribute = Api.AttributeSet.GetByName(name);
            }
            catch (Exception ex)
            {
                exc = ex;
            }
            Assert.IsTrue(exc == null);
        }

        [TestMethod]
        public void Add()
        {
            AttributeSetList newAttribute = new AttributeSetList()
            {
                Name = "Test set 14",
                Attribute1Name = "List attribute name",
                Attribute1Type = "List",
                Attribute1Values = "Red, Black, Blue, Aqua",
                Attribute2Name = "Check box attribute name",
                Attribute2Type = "Checkbox",
                Attribute2Values = "",
                Attribute3Name = "Text attribute name",
                Attribute3Type = "Text",
                Attribute3Values = "",
            };
            Exception exc = null;
            try
            {
                var id = Api.AttributeSet.Add(newAttribute);
            }
            catch (Exception ex)
            {
                exc = ex;
            }
            Assert.IsTrue(exc == null);
        }

        [TestMethod]
        public void Edit()
        {
            AttributeSetList newAttribute = new AttributeSetList()
            {
                //ID is mandatory
                ID = Guid.Parse("6bc753b8-caf6-48e7-aa69-c5b1f42e01b6"),
                Name = "Test set 28",
                Attribute1Name = "List attribute name",
                Attribute1Type = "List",
                Attribute1Values = "Red, Black, Blue, Aqua",
                Attribute2Name = "Check box attribute name",
                Attribute2Type = "Checkbox",
                Attribute2Values = "",
                Attribute3Name = "Text attribute name",
                Attribute3Type = "Text",
                Attribute3Values = "",
            };
            Exception exc = null;
            try
            {
                var result = Api.AttributeSet.Edit(newAttribute);
            }
            catch (Exception ex)
            {
                exc = ex;
            }
            Assert.IsTrue(exc == null);
        }

        [TestMethod]
        public void Delete()
        {
            string id = "6bc753b8-caf6-48e7-aa69-c5b1f42e01b6";
            Exception exc = null;
            try
            {
                var result = Api.AttributeSet.Delete(Guid.Parse(id));
            }
            catch (Exception ex)
            {
                exc = ex;
            }
            Assert.IsTrue(exc == null);
        }
    }
}
