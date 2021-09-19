using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DearInventoryLib.Service
{
    public class RequestService : HttpRequestService
    {
        internal static string URLParameter;
        public RequestService(HttpClient HttpClient, string AccountId, string ApplicationKey) :base(HttpClient, AccountId, ApplicationKey)
        {

        }

        internal System.Net.HttpStatusCode SendHttpRequest(HTTPMethod httpMethod, out string response, object content = null)
        {
            HttpResponseMessage httpResponseMessage = null;
            response = string.Empty;
            Task<HttpResponseMessage> callTask;
            StringContent stringContent = null;
            if ((httpMethod == HTTPMethod.POST || httpMethod == HTTPMethod.PUT) && content != null)
            {
                Type type = content.GetType();
                var jsonSerializerSettings = new JsonSerializerSettings()
                {
                    TypeNameHandling = TypeNameHandling.All
                };
                var serializedObject = JsonConvert.SerializeObject(value: content, type: type, jsonSerializerSettings);
                stringContent = new StringContent(serializedObject, Encoding.Default, "application/json");
            }
            switch (httpMethod)
            {
                case HTTPMethod.GET:
                    callTask = Task.Run(() => _httpClient.GetAsync(URLParameter));
                    httpResponseMessage = callTask.GetAwaiter().GetResult();
                    break;
                case HTTPMethod.POST:
                    callTask = Task.Run(() => _httpClient.PostAsync(URLParameter, stringContent));
                    httpResponseMessage = callTask.GetAwaiter().GetResult();
                    break;
                case HTTPMethod.PUT:
                    callTask = Task.Run(() => _httpClient.PutAsync(URLParameter, stringContent));
                    httpResponseMessage = callTask.GetAwaiter().GetResult();
                    break;
                case HTTPMethod.DELETE:
                    callTask = Task.Run(() => _httpClient.DeleteAsync(URLParameter));
                    httpResponseMessage = callTask.GetAwaiter().GetResult();
                    break;
            }
            var responseTask = Task.Run(() => httpResponseMessage.Content.ReadAsStringAsync());
            response = responseTask.GetAwaiter().GetResult();
            return httpResponseMessage.StatusCode;
        }

        public string RetrieveDataByField(Field field, string filter, string URLAttribute)
        {
            string result = string.Empty;
            switch (field)
            {
                case Field.ID:
                    URLParameter = $"{URLAttribute}?ID={filter}";
                    break;
                case Field.Bank:
                    URLParameter = $"{URLAttribute}?Bank={filter}";
                    break;
                case Field.AccountName:
                    URLParameter = $"{URLAttribute}?Name={filter}";
                    break;
                case Field.SKU:
                    URLParameter = $"{URLAttribute}?Sku={filter}";
                    break;
            }
            if (SendHttpRequest(HTTPMethod.GET, out string httpResponse) == System.Net.HttpStatusCode.OK)
            {
                result = httpResponse;
            }
            return result;
        }
    }
}
