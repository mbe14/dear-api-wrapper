using DearInventoryLib.DataAccess;
using DearInventoryLib.DataAccess.Enum;
using DearInventoryLib.Interface;
using DearInventoryLib.Model;
using Newtonsoft.Json;
using System.Net.Http;

namespace DearInventoryLib.Api
{
    public class MeRequest : RequestService, IMeRequest
    {
        private const string URLAttribute = "me";
        public MeRequest(HttpClient HttpClient, string AccountId, string ApplicationKey) : base(HttpClient, AccountId, ApplicationKey)
        {

        }

        public Me Get()
        {
            Me result = null;
            URLParameter = URLAttribute;
            if (SendHttpRequest(HTTPMethod.GET, out string httpResponse) == System.Net.HttpStatusCode.OK)
            {
                var data = JsonConvert.DeserializeObject<Me>(httpResponse);
                result = data;
            };
            return result;
        }
    }
}
