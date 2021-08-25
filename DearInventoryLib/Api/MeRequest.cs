﻿using DearInventoryLib.Interface;
using DearInventoryLib.Model;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;

namespace DearInventoryLib.Api
{
    public class MeRequest : RequestBase, IMeRequest
    {
        public MeRequest(HttpClient HttpClient, string AccountId, string ApplicationKey) : base(HttpClient, AccountId, ApplicationKey)
        {

        }

        public Me Get()
        {
            Me result = null;
            using (var response = _httpClient.GetAsync("me").GetAwaiter().GetResult())
            {
                string responseData = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                result = JsonConvert.DeserializeObject<Me>(responseData);
            }
            return result;
        }
    }
}
