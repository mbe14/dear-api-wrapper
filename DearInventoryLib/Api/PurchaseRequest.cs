using DearInventoryLib.Interface;
using DearInventoryLib.Model.Purchase;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace DearInventoryLib.Api
{
    public class PurchaseRequest : RequestBase, IPurchaseRequest
    {
        private const string URLAttribute = "purchaseList";
        private const string URLAttributePurchaseOrder = "purchase/order";
        public PurchaseRequest(HttpClient HttpClient, string AccountId, string ApplicationKey) : base(HttpClient, AccountId, ApplicationKey)
        {

        }

        public List<PurchaseData> GetPurchaseList(string Search = null)
        {
            List<PurchaseData> result = new List<PurchaseData>();
            int page = 1;
            bool moveToNextPage = true;
            int defaultPageSize = 100;

            do
            {
                URLParameter = $"{URLAttribute}?Page={page}&Limit={defaultPageSize}";
                URLParameter += !string.IsNullOrWhiteSpace(Search) ? $"&Search={Search}" : "";
                if (SendHttpRequest(HTTPMethod.GET, out string httpResponse) == System.Net.HttpStatusCode.OK)
                {
                    var data = JsonConvert.DeserializeObject<PurchasesList>(httpResponse);
                    if (data.PurchaseList.Count() > 0)
                    {
                        result.AddRange(data.PurchaseList);
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

        public SimplePurchase GetSimplePurchase(Guid ID)
        {
            string filter = ID.ToString();
            SimplePurchase result = JsonConvert.DeserializeObject<SimplePurchase>(RetrieveDataByField(Field.ID, filter, URLAttribute));
            return result;
        }

        string IPurchaseRequest.AddPurchaseOrder(PurchaseOrder PurchaseOrder)
        {
            throw new NotImplementedException();
        }

        PurchaseOrder IPurchaseRequest.GetPurchaseOrder(Guid TaskID)
        {
            throw new NotImplementedException();
        }
    }
}
