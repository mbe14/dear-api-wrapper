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
    public class AttributeSetRequest : RequestService, IAttributeSetRequest
    {
        private const string URLAttribute = "ref/attributeset";
        public AttributeSetRequest(HttpClient HttpClient, string AccountId, string ApplicationKey) : base(HttpClient, AccountId, ApplicationKey)
        {

        }

        public List<AttributeSetList> GetAll()
        {
            List<AttributeSetList> result = new List<AttributeSetList>();
            int page = 1;
            bool moveToNextPage = true;
            int defaultPageSize = 100;
            do
            {
                URLParameter = $"{URLAttribute}?Page={page}&Limit={defaultPageSize}";
                if (SendHttpRequest(HTTPMethod.GET, out string httpResponse) == System.Net.HttpStatusCode.OK)
                {
                    var data = JsonConvert.DeserializeObject<AttributeSet>(httpResponse);
                    if (data.AttributeSetList.Count() > 0)
                    {
                        result.AddRange(data.AttributeSetList);
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

        public AttributeSetList GetById(Guid Guid)
        {
            string filter = Guid.ToString();
            var data = JsonConvert.DeserializeObject<AttributeSet>(RetrieveDataByField(Field.ID, filter, URLAttribute));
            AttributeSetList result = data.LocationList;
            return result;
        }

        public AttributeSetList GetByName(string Name)
        {
            string filter = Name;
            var data = JsonConvert.DeserializeObject<AttributeSet>(RetrieveDataByField(Field.AccountName, filter, URLAttribute));
            AttributeSetList result = data.AttributeSetList.FirstOrDefault();
            return result;
        }

        public string Add(AttributeSetList Attribute)
        {
            string result = string.Empty;
            URLParameter = URLAttribute;
            if (SendHttpRequest(HTTPMethod.POST, out string httpResponse, content: Attribute) == System.Net.HttpStatusCode.OK)
            {
                var data = JsonConvert.DeserializeObject<AttributeSet>(httpResponse);
                result = data.LocationList.ID.ToString();
            }
            return result;
        }

        public bool Edit(AttributeSetList Attribute)
        {
            URLParameter = URLAttribute;
            if (SendHttpRequest(HTTPMethod.PUT, out _, content: Attribute) == System.Net.HttpStatusCode.OK)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Delete(Guid Guid)
        {
            string id = Guid.ToString();
            URLParameter = $"{URLAttribute}?ID={id}";
            if (SendHttpRequest(HTTPMethod.DELETE, out _) == System.Net.HttpStatusCode.OK)
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
