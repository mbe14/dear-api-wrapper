using System;
using System.Collections.Generic;

namespace DearInventoryLib.Model
{
    public class BankAccount
    {
        public Guid AccountID { get; set; }
        public string Bank { get; set; }
        public string AccountName { get; set; }
        public string AccountNumber { get; set; }
        public string AccountCode { get; set; }
        public string Currency { get; set; }
        public decimal StatementBalance { get; set; }
        public decimal BalanceInDear { get; set; }
        public string InitialBalance { get; set; }

    }

    public class BankAccountsList
    {
        public int Total { get; set; }
        public int Page { get; set; }
        public List<BankAccount> BankAccounts { get; set; }
    }
}
