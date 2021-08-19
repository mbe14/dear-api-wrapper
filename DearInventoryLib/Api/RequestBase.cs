using System.Net;
using System.Net.Http;

namespace DearInventoryLib.Api
{
    public class RequestBase
    {
        protected readonly HttpClient _httpClient;
        protected readonly string _accountId;
        protected readonly string _applicationKey;

        public RequestBase(HttpClient httpClient, string accountId, string applicationKey)
        {
            _httpClient = httpClient;
            _accountId = accountId;
            _applicationKey = applicationKey;
        }
    }
}
