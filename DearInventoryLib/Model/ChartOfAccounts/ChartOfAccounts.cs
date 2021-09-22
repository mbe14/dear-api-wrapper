using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DearInventoryLib.Model.ChartOfAccounts
{
    public class ChartOfAccounts
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public COAType Type { get; set; }
        public string Status {  get; set; }
        public string Description {  get; set; }
        public COAClass Class {  get; set; }
        public COASystemAccount SystemAccount { get; set; }
        public string ForPayments { get; set; }
        public string DisplayName {  get; set; }
        public string OldCode {  get; }
        public string Bank { get; set; } //Name of the Bank. Only for PUT and POST. Required if Account Type is BANK
        public string BankAccountNumber {  get; set; } //Bank Account Number. Only for PUT and POST. Required if Account Type is BANK
        public Guid BankAccountId {  get; set; }
        public string Currency {  get; set; }
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum COAType
    {
        [EnumMember(Value = "BANK")]
        BANK,

        [EnumMember(Value = "CURRLIAB")]
        CURRLIAB,

        [EnumMember(Value = "LIABILITY")]
        LIABILITY,

        [EnumMember(Value = "TERMLIA")]
        TERMLIA,

        [EnumMember(Value = "PAYGLIABILITY")]
        PAYGLIABILITY,

        [EnumMember(Value = "SUPERANNUATIONLIABILITY")]
        SUPERANNUATIONLIABILITY,

        [EnumMember(Value = "WAGESPAYABLELIABILITY")]
        WAGESPAYABLELIABILITY
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum COAClass
    {
        [EnumMember(Value = "ASSET")]
        ASSET,

        [EnumMember(Value = "LIABILITY")]
        LIABILITY,

        [EnumMember(Value = "EXPENSE")]
        EXPENSE,

        [EnumMember(Value = "EQUITY")]
        EQUITY,

        [EnumMember(Value = "REVENUE")]
        REVENUE
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum COASystemAccount
    {
        [EnumMember(Value = "BANKCURRENCYGAIN")]
        BANKCURRENCYGAIN,

        [EnumMember(Value = "CREDITORS")]
        CREDITORS,

        [EnumMember(Value = "DEBTORS")]
        DEBTORS,

        [EnumMember(Value = "GST")]
        GST,

        [EnumMember(Value = "GSTONIMPORTS")]
        GSTONIMPORTS,

        [EnumMember(Value = "HISTORICAL")]
        HISTORICAL,

        [EnumMember(Value = "REALISEDCURRENCYGAIN")]
        REALISEDCURRENCYGAIN,

        [EnumMember(Value = "RETAINEDEARNINGS")]
        RETAINEDEARNINGS,

        [EnumMember(Value = "ROUNDING")]
        ROUNDING,

        [EnumMember(Value = "TRACKINGTRANSFERS")]
        TRACKINGTRANSFERS,

        [EnumMember(Value = "UNPAIDEXPCLM")]
        UNPAIDEXPCLM,

        [EnumMember(Value = "UNREALISEDCURRENCYGAIN")]
        UNREALISEDCURRENCYGAIN,

        [EnumMember(Value = "WAGEPAYABLES")]
        WAGEPAYABLES
    }
}
