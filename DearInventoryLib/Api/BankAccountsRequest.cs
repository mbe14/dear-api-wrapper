using DearInventoryLib.Interface;
using DearInventoryLib.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace DearInventoryLib.Api
{
    public class BankAccountsRequest : RequestBase, IBankAccountsRequest
    {
        public BankAccountsRequest(HttpClient httpClient, string accountId, string applicationKey) : base(httpClient, accountId, applicationKey)
        {

        }

        public List<BankAccount> GetAll()
        {
            List<BankAccount> result = new List<BankAccount>();
            int page = 1;
            bool moveToNextPage;
            int defaultPageSize = 100;
            do
            {
                using (var response = _httpClient.GetAsync($"ref/account/bank?Page={page}&Limit={defaultPageSize}").GetAwaiter().GetResult())
                {
                    string responseData = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                    var data = JsonConvert.DeserializeObject<BankAccountsList>(responseData);
                    if (data.BankAccounts.Count() > 0)
                    {
                        result.AddRange(data.BankAccounts);
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

        public BankAccount GetById(Guid guid)
        {
            string id = guid.ToString();
            BankAccount result = null;
            using (var response = _httpClient.GetAsync($"ref/account/bank?ID={id}").GetAwaiter().GetResult())
            {
                string responseData = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                var data = JsonConvert.DeserializeObject<BankAccount>(responseData);
                result = data;
            }
            return result;
        }

        public BankAccount GetByAccountName(string name)
        {
            string s = name;
            BankAccount result = null;
            using (var response = _httpClient.GetAsync($"ref/account/bank?Name={s}").GetAwaiter().GetResult())
            {
                string responseData = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                var data = JsonConvert.DeserializeObject<BankAccount>(responseData);
                result = data;
            }
            return result;
        }

        public BankAccount GetByBank(string bank)
        {
            string s = bank;
            BankAccount result = null;
            using (var response = _httpClient.GetAsync($"ref/account/bank?Bank={s}").GetAwaiter().GetResult())
            {
                string responseData = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                var data = JsonConvert.DeserializeObject<BankAccount>(responseData);
                result = data;
            }
            return result;
        }
    }
}
