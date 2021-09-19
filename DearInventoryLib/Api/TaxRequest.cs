using DearInventoryLib.Interface;
using DearInventoryLib.Model.Tax;
using DearInventoryLib.Service;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace DearInventoryLib.Api
{
    public class TaxRequest : RequestService, ITaxRequest
    {
        private const string URLAttribute = "ref/tax";
        public TaxRequest(HttpClient HttpClient, string AccountId, string ApplicationKey) : base(HttpClient, AccountId, ApplicationKey)
        {

        }

        public List<Tax> GetAllTaxes(bool IsActive = true, bool IsTaxForSale = true, bool IsTaxForPurchase = false)
        {
            List<Tax> result = new List<Tax>();
            int page = 1;
            bool moveToNextPage = true;
            int defaultPageSize = 100;

            do
            {
                URLParameter = $"{URLAttribute}?Page={page}&Limit={defaultPageSize}";
                URLParameter += IsActive ? "&IsActive=true" : "";
                URLParameter += IsTaxForSale ? "&IsTaxForSale=true" : "";
                URLParameter += IsTaxForPurchase ? "&IsTaxForPurchase=true" : "";

                if (SendHttpRequest(HTTPMethod.GET, out string httpResponse) == System.Net.HttpStatusCode.OK)
                {
                    var data = JsonConvert.DeserializeObject<TaxList>(httpResponse);
                    if (data.TaxRuleList.Count() > 0)
                    {
                        result.AddRange(data.TaxRuleList);
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

        public List<Tax> GetTaxForAccount(string Account)
        {
            List<Tax> result = new List<Tax>();
            URLParameter = $"{URLAttribute}?Account={Account}";
            if (SendHttpRequest(HTTPMethod.GET, out string httpResponse) == System.Net.HttpStatusCode.OK)
            {
                var data = JsonConvert.DeserializeObject<TaxList>(httpResponse);
                result = data.TaxRuleList;
            }
            return result;
        }

        public string AddTax(Tax Tax)
        {
            string result = string.Empty;
            URLParameter = $"{URLAttribute}";
            if (SendHttpRequest(HTTPMethod.POST, out string httpResponse, content: Tax) == System.Net.HttpStatusCode.OK)
            {
                TaxList t = JsonConvert.DeserializeObject<TaxList>(httpResponse);
                var tax = t.TaxRuleList.FirstOrDefault();
                result = tax.ID.ToString();
            }
            return result;
        }

        public bool EditTax(Tax Tax)
        {
            URLParameter = URLAttribute;
            if (SendHttpRequest(HTTPMethod.PUT, out _, content: Tax) == System.Net.HttpStatusCode.OK)
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
