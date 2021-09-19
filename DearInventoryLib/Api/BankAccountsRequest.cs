using DearInventoryLib.DataAccess;
using DearInventoryLib.DataAccess.Enum;
using DearInventoryLib.Interface;
using DearInventoryLib.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace DearInventoryLib.Api
{
    public class BankAccountsRequest : RequestService, IBankAccountsRequest
    {
        private const string URLAttribute = "ref/account/bank";
        public BankAccountsRequest(HttpClient HttpClient, string AccountId, string ApplicationKey) : base(HttpClient, AccountId, ApplicationKey)
        {

        }

        public List<BankAccount> GetAll()
        {
            List<BankAccount> result = new List<BankAccount>();
            int page = 1;
            bool moveToNextPage = true;
            int defaultPageSize = 100;
            do
            {
                URLParameter = $"{URLAttribute}?Page={page}&Limit={defaultPageSize}";
                if (SendHttpRequest(HTTPMethod.GET, out string httpResponse) == System.Net.HttpStatusCode.OK)
                {
                    var data = JsonConvert.DeserializeObject<BankAccountsList>(httpResponse);
                    if (data.BankAccounts.Count() > 0)
                    {
                        result.AddRange(data.BankAccounts);
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

        public BankAccount GetById(Guid Guid)
        {
            string filter = Guid.ToString();
            BankAccount result = JsonConvert.DeserializeObject<BankAccount>(RetrieveDataByField(Field.ID, filter, URLAttribute));
            return result;
        }

        public BankAccount GetByAccountName(string Name)
        {
            string filter = Name;
            BankAccount result = JsonConvert.DeserializeObject<BankAccount>(RetrieveDataByField(Field.AccountName, filter, URLAttribute));
            return result;
        }

        public BankAccount GetByBank(string Bank)
        {
            string filter = Bank;
            BankAccount result = JsonConvert.DeserializeObject<BankAccount>(RetrieveDataByField(Field.Bank, filter, URLAttribute));
            return result;
        }
    }
}
