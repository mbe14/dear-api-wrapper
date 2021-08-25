using DearInventoryLib.Interface;
using DearInventoryLib.Model.Account;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace DearInventoryLib.Api
{
    public class AccountRequest : RequestBase, IAccountRequest
    {
        public AccountRequest(HttpClient HttpClient, string AccountId, string ApplicationKey) : base(HttpClient, AccountId, ApplicationKey)
        {

        }

        public List<Customer> GetAllCustomers()
        {
            List<Customer> result = new List<Customer>();
            int page = 1;
            bool moveToNextPage;
            int defaultPageSize = 100;

            do
            {
                string s = $"customer?Page={page}&Limit={defaultPageSize}";
                using (HttpResponseMessage response = _httpClient.GetAsync(s).GetAwaiter().GetResult())
                {
                    string responseData = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                    var data = JsonConvert.DeserializeObject<CustomersList>(responseData);
                    if (data.CustomerList.Count() > 0)
                    {
                        result.AddRange(data.CustomerList);
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

        public string AddCustomer(Customer Customer)
        {
            string result = string.Empty;
            var data = JsonConvert.SerializeObject(Customer);
            using (var content = new StringContent(data, System.Text.Encoding.Default, "application/json"))
            {
                using (HttpResponseMessage response = _httpClient.PostAsync("customer", content).GetAwaiter().GetResult())
                {
                    string responseData = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                    if (!response.IsSuccessStatusCode)
                    {
                        throw new Exception(responseData);
                    }
                    else
                    {
                        CustomersList c = JsonConvert.DeserializeObject<CustomersList>(responseData);
                        var customer = c.CustomerList.FirstOrDefault();
                        result = customer.ID.ToString();
                    }
                }
            }
            return result;
        }

        public bool EditCustomer(Customer Customer)
        {
            bool result;
            if (Customer.ID == Guid.Empty || Customer.ID == null)
            {
                throw new ArgumentNullException("Customer ID not declared.");
            }
            var data = JsonConvert.SerializeObject(Customer);
            using (var content = new StringContent(data, System.Text.Encoding.Default, "application/json"))
            {
                using (HttpResponseMessage response = _httpClient.PutAsync("customer", content).GetAwaiter().GetResult())
                {
                    string responseData = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                    if (!response.IsSuccessStatusCode)
                    {
                        throw new Exception(responseData);
                    }
                    else
                    {
                        CustomersList c = JsonConvert.DeserializeObject<CustomersList>(responseData);
                        result = response.StatusCode == System.Net.HttpStatusCode.OK ? true : false;
                    }
                }
            }
            return result;
        }

        public List<Supplier> GetAllSuppliers()
        {
            List<Supplier> result = new List<Supplier>();
            int page = 1;
            bool moveToNextPage;
            int defaultPageSize = 100;

            do
            {
                string s = $"supplier?Page={page}&Limit={defaultPageSize}";
                using (HttpResponseMessage response = _httpClient.GetAsync(s).GetAwaiter().GetResult())
                {
                    string responseData = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                    var data = JsonConvert.DeserializeObject<SuppliersList>(responseData);
                    if (data.SupplierList.Count() > 0)
                    {
                        result.AddRange(data.SupplierList);
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

        public string AddSupplier(Supplier Supplier)
        {
            string result = string.Empty;
            var data = JsonConvert.SerializeObject(Supplier);
            using (var content = new StringContent(data, System.Text.Encoding.Default, "application/json"))
            {
                using (HttpResponseMessage response = _httpClient.PostAsync("supplier", content).GetAwaiter().GetResult())
                {
                    string responseData = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                    if (!response.IsSuccessStatusCode)
                    {
                        throw new Exception(responseData);
                    }
                    else
                    {
                        SuppliersList s = JsonConvert.DeserializeObject<SuppliersList>(responseData);
                        var supplier = s.SupplierList.FirstOrDefault();
                        result = supplier.ID.ToString();
                    }
                }
            }
            return result;
        }

        public bool EditSupplier(Supplier Supplier)
        {
            bool result;
            if (Supplier.ID == Guid.Empty || Supplier.ID == null)
            {
                throw new ArgumentNullException("Supplier ID not declared.");
            }
            var data = JsonConvert.SerializeObject(Supplier);
            using (var content = new StringContent(data, System.Text.Encoding.Default, "application/json"))
            {
                using (HttpResponseMessage response = _httpClient.PutAsync("supplier", content).GetAwaiter().GetResult())
                {
                    string responseData = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                    if (!response.IsSuccessStatusCode)
                    {
                        throw new Exception(responseData);
                    }
                    else
                    {
                        SuppliersList s = JsonConvert.DeserializeObject<SuppliersList>(responseData);
                        result = response.StatusCode == System.Net.HttpStatusCode.OK ? true : false;
                    }
                }
            }
            return result;
        }
    }
}
