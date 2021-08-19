using DearInventoryLib.Interface;
using DearInventoryLib.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace DearInventoryLib.Api
{
    public class AttributeSetRequest : RequestBase, IAttributeSetRequest
    {
        public AttributeSetRequest(HttpClient httpClient, string accountId, string applicationKey) : base(httpClient, accountId, applicationKey)
        {
            
        }

        public List<AttributeSetList> GetAll()
        {
            List<AttributeSetList> result = new List<AttributeSetList>();
            int page = 1;
            bool moveToNextPage;
            int defaultPageSize = 100;
            do
            {
                using (var response = _httpClient.GetAsync($"ref/attributeset?Page={page}&Limit={defaultPageSize}").GetAwaiter().GetResult())
                {
                    string responseData = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                    var data = JsonConvert.DeserializeObject<AttributeSet>(responseData);
                    if (data.AttributeSetList.Count() > 0)
                    {
                        result.AddRange(data.AttributeSetList);
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

        public AttributeSetList GetById(Guid guid)
        {
            string id = guid.ToString();
            AttributeSetList result = null;
            using (var response = _httpClient.GetAsync($"ref/attributeset?ID={id}").GetAwaiter().GetResult())
            {
                string responseData = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                var data = JsonConvert.DeserializeObject<AttributeSet>(responseData);
                result = data.LocationList;
            }
            return result;
        }

        public AttributeSetList GetByName(string name)
        {
            string s = name;
            AttributeSetList result = null;
            using (var response = _httpClient.GetAsync($"ref/attributeset?Name={s}").GetAwaiter().GetResult())
            {
                string responseData = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                var data = JsonConvert.DeserializeObject<AttributeSet>(responseData);
                result = data.AttributeSetList.FirstOrDefault();
            }
            return result;
        }

        public string Add(AttributeSetList attribute)
        {
            string result = string.Empty;
            var data = JsonConvert.SerializeObject(attribute);
            using (var content = new StringContent(data, System.Text.Encoding.Default, "application/json"))
            {
                using (var response = _httpClient.PostAsync("ref/attributeset", content).GetAwaiter().GetResult())
                {
                    string responseData = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                    AttributeSet attributeSet = JsonConvert.DeserializeObject<AttributeSet>(responseData);
                    result = attributeSet.LocationList.ID.ToString();
                }
            }
            return result;
        }

        public bool Edit(AttributeSetList attribute)
        {
            bool result;
            var data = JsonConvert.SerializeObject(attribute);
            using (var content = new StringContent(data, System.Text.Encoding.Default, "application/json"))
            {
                using (var response = _httpClient.PutAsync("ref/attributeset", content).GetAwaiter().GetResult())
                {
                    string responseData = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                    AttributeSet attributeSet = JsonConvert.DeserializeObject<AttributeSet>(responseData);
                    result = response.StatusCode == System.Net.HttpStatusCode.OK ? true : false;
                }
            }
            return result;
        }

        public bool Delete(Guid guid)
        {
            string id = guid.ToString();
            bool result;
            using (var response = _httpClient.DeleteAsync($"ref/attributeset?ID={id}").GetAwaiter().GetResult())
            {
                string responseData = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                result = response.StatusCode == System.Net.HttpStatusCode.OK ? true : false;
            }
            return result;
        }
    }
}
