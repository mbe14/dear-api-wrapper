using DearInventoryLib.DataAccess;
using DearInventoryLib.DataAccess.Enum;
using DearInventoryLib.Interface;
using DearInventoryLib.Model.Account;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace DearInventoryLib.Api
{
    public class AccountRequest : RequestService, IAccountRequest
    {
        private const string URLAttributeCustomer = "customer";
        private const string URLAttributeSupplier = "supplier";
        public AccountRequest(HttpClient HttpClient, string AccountId, string ApplicationKey) : base(HttpClient, AccountId, ApplicationKey)
        {

        }

        public List<Customer> GetAllCustomers()
        {
            List<Customer> result = new List<Customer>();
            int page = 1;
            bool moveToNextPage = true;
            int defaultPageSize = 100;
            do
            {
                URLParameter = $"{URLAttributeCustomer}?Page={page}&Limit={defaultPageSize}";
                if (SendHttpRequest(HTTPMethod.GET, out string httpResponse) == System.Net.HttpStatusCode.OK)
                {
                    var data = JsonConvert.DeserializeObject<CustomersList>(httpResponse);
                    if (data.CustomerList.Count() > 0)
                    {
                        result.AddRange(data.CustomerList);
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

        public string AddCustomer(Customer Customer)
        {
            string result = string.Empty;
            URLParameter = URLAttributeCustomer;
            if (SendHttpRequest(HTTPMethod.POST, out string httpResponse, content: Customer) == System.Net.HttpStatusCode.OK)
            {
                var data = JsonConvert.DeserializeObject<CustomersList>(httpResponse);
                var customer = data.CustomerList.FirstOrDefault();
                result = customer.ID.ToString();
            }
            return result;
        }

        public bool EditCustomer(Customer Customer)
        {
            URLParameter = URLAttributeCustomer;
            if (SendHttpRequest(HTTPMethod.PUT, out _, content: Customer) == System.Net.HttpStatusCode.OK)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Supplier> GetAllSuppliers()
        {
            List<Supplier> result = new List<Supplier>();
            int page = 1;
            bool moveToNextPage = true;
            int defaultPageSize = 100;
            do
            {
                URLParameter = $"{URLAttributeSupplier}?Page={page}&Limit={defaultPageSize}";
                if (SendHttpRequest(HTTPMethod.GET, out string httpResponse) == System.Net.HttpStatusCode.OK)
                {
                    var data = JsonConvert.DeserializeObject<SuppliersList>(httpResponse);
                    if (data.SupplierList.Count() > 0)
                    {
                        result.AddRange(data.SupplierList);
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

        public string AddSupplier(Supplier Supplier)
        {
            string result = string.Empty;
            URLParameter = URLAttributeSupplier;
            if (SendHttpRequest(HTTPMethod.POST, out string httpResponse, content: Supplier) == System.Net.HttpStatusCode.OK)
            {
                var data = JsonConvert.DeserializeObject<SuppliersList>(httpResponse);
                var supplier = data.SupplierList.FirstOrDefault();
                result = supplier.ID.ToString();
            }
            return result;
        }

        public bool EditSupplier(Supplier Supplier)
        {
            URLParameter = URLAttributeSupplier;
            if (SendHttpRequest(HTTPMethod.PUT, out _, content: Supplier) == System.Net.HttpStatusCode.OK)
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
