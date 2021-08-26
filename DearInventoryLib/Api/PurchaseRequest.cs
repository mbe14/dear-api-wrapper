using DearInventoryLib.Interface;
using DearInventoryLib.Model.Common;
using DearInventoryLib.Model.Purchase;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DearInventoryLib.Api
{
    public class PurchaseRequest : RequestBase, IPurchaseRequest
    {
        public PurchaseRequest(HttpClient HttpClient, string AccountId, string ApplicationKey) : base(HttpClient, AccountId, ApplicationKey)
        {

        }

        public List<PurchaseData> GetPurchaseList(string Search = null)
        {
            List<PurchaseData> result = new List<PurchaseData>();
            int page = 1;
            bool moveToNextPage;
            int defaultPageSize = 100;

            do
            {
                string s = $"purchaseList?Page={page}&Limit={defaultPageSize}";
                s += !string.IsNullOrWhiteSpace(Search) ? $"&Search={Search}" : "";
                using (HttpResponseMessage response = _httpClient.GetAsync(s).GetAwaiter().GetResult())
                {
                    string responseData = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                    var data = JsonConvert.DeserializeObject<PurchasesList>(responseData);
                    if (data.PurchaseList.Count() > 0)
                    {
                        result.AddRange(data.PurchaseList);
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

        public SimplePurchase GetSimplePurchase(Guid ID)
        {
            string id = ID.ToString();
            SimplePurchase result = null;

            string s = $"purchase?ID={id}&CombineAdditionalCharges=true";

            using (HttpResponseMessage response = _httpClient.GetAsync(s).GetAwaiter().GetResult())
            {
                string responseData = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                var data = JsonConvert.DeserializeObject<SimplePurchase>(responseData);
                result = data;
            }
            return result;
        }
    }
}
