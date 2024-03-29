﻿using System;
using System.Net.Http;

namespace DearInventoryLib.Api
{
    public class ApiRequest
    {
        private static string _accountId;
        private static string _applicationKey;
        private static HttpClient _httpClient;

        public ApiRequest(string AccountId, string ApplicationKey)
        {
            _accountId = AccountId;
            _applicationKey = ApplicationKey;
            _httpClient = new HttpClient() { BaseAddress = new Uri("https://inventory.dearsystems.com/ExternalApi/v2/") };
            _httpClient.DefaultRequestHeaders.TryAddWithoutValidation("api-auth-accountid", _accountId);
            _httpClient.DefaultRequestHeaders.TryAddWithoutValidation("api-auth-applicationkey", _applicationKey);
        }

        public MeRequest Me { get { return new MeRequest(_httpClient, _accountId, _applicationKey); } }
        public AttributeSetRequest AttributeSet { get { return new AttributeSetRequest(_httpClient, _accountId, _applicationKey); } }
        public BankAccountsRequest BankAccounts { get { return new BankAccountsRequest(_httpClient, _accountId, _applicationKey); } }
        public ProductRequest Product { get { return new ProductRequest(_httpClient, _accountId, _applicationKey); } }
        public TaxRequest Tax { get { return new TaxRequest(_httpClient, _accountId, _applicationKey); } }
        public AccountRequest Account { get { return new AccountRequest(_httpClient, _accountId, _applicationKey); } }
        public PurchaseRequest Purchase { get { return new PurchaseRequest(_httpClient, _accountId, _applicationKey); } }
    }
}
