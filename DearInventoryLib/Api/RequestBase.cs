using System.Net;
using System.Net.Http;

namespace DearInventoryLib.Api
{
    public class RequestBase
    {
        protected readonly HttpClient _httpClient;
        protected readonly string _accountId;
        protected readonly string _applicationKey;

        public RequestBase(HttpClient HttpClient, string AccountId, string ApplicationKey)
        {
            _httpClient = HttpClient;
            _accountId = AccountId;
            _applicationKey = ApplicationKey;
        }
    }
}
