using DearInventoryLib.Interface;
using DearInventoryLib.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace DearInventoryLib.Api
{
    public class TaxRequest : RequestBase, ITaxRequest
    {
        public TaxRequest(HttpClient HttpClient, string AccountId, string ApplicationKey) : base(HttpClient, AccountId, ApplicationKey)
        {

        }

        public List<Tax> GetAllTaxes(bool IsActive = true, bool IsTaxForSale = true, bool IsTaxForPurchase = false)
        {
            List<Tax> result = new List<Tax>();
            int page = 1;
            bool moveToNextPage;
            int defaultPageSize = 100;

            do
            {
                string s = $"ref/tax?Page={page}&Limit={defaultPageSize}";
                s += IsActive ? "&IsActive=true" : "";
                s += IsTaxForSale ? "&IsTaxForSale=true" : "";
                s += IsTaxForPurchase ? "&IsTaxForPurchase=true" : "";


                using (HttpResponseMessage response = _httpClient.GetAsync(s).GetAwaiter().GetResult())
                {
                    string responseData = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                    var data = JsonConvert.DeserializeObject<TaxList>(responseData);
                    if (data.TaxRuleList.Count() > 0)
                    {
                        result.AddRange(data.TaxRuleList);
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

        public List<Tax> GetTaxForAccount(string Account)
        {
            List<Tax> result = new List<Tax>();
            string s = $"ref/tax?Account={Account}";
            using (HttpResponseMessage response = _httpClient.GetAsync(s).GetAwaiter().GetResult())
            {
                string responseData = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                var data = JsonConvert.DeserializeObject<TaxList>(responseData);
                result = data.TaxRuleList;
            }
            return result;
        }

        public string AddTax(Tax Tax)
        {
            string result = string.Empty;
            var data = JsonConvert.SerializeObject(Tax);
            using (var content = new StringContent(data, System.Text.Encoding.Default, "application/json"))
            {
                using (HttpResponseMessage response = _httpClient.PostAsync("ref/tax", content).GetAwaiter().GetResult())
                {
                    string responseData = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                    if (!response.IsSuccessStatusCode)
                    {
                        throw new Exception(responseData);
                    }
                    else
                    {
                        TaxList t = JsonConvert.DeserializeObject<TaxList>(responseData);
                        var tax = t.TaxRuleList.FirstOrDefault();
                        result = tax.ID.ToString();
                    }
                }
            }
            return result;
        }

        public bool EditTax(Tax Tax)
        {
            bool result;
            if (Tax.ID == Guid.Empty || Tax.ID == null)
            {
                throw new ArgumentNullException("Tax ID not declared.");
            }
            var data = JsonConvert.SerializeObject(Tax);
            using (var content = new StringContent(data, System.Text.Encoding.Default, "application/json"))
            {
                using (HttpResponseMessage response = _httpClient.PutAsync("ref/tax", content).GetAwaiter().GetResult())
                {
                    string responseData = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                    if (!response.IsSuccessStatusCode)
                    {
                        throw new Exception(responseData);
                    }
                    else
                    {
                        TaxList t = JsonConvert.DeserializeObject<TaxList>(responseData);
                        result = response.StatusCode == System.Net.HttpStatusCode.OK ? true : false;
                    }
                }
            }
            return result;
        }
    }
}
