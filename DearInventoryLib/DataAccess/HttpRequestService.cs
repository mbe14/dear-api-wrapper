using System.Net.Http;

namespace DearInventoryLib.DataAccess
{
    public class HttpRequestService
    {
        protected readonly HttpClient _httpClient;
        protected readonly string _accountId;
        protected readonly string _applicationKey;       

        public HttpRequestService(HttpClient HttpClient, string AccountId, string ApplicationKey)
        {
            _httpClient = HttpClient;
            _accountId = AccountId;
            _applicationKey = ApplicationKey;
        }     
    }
}
