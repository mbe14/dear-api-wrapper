using DearInventoryLib.Model;
using System;
using System.Collections.Generic;

namespace DearInventoryLib.Interface
{
    interface IBankAccountsRequest
    {
        List<BankAccount> GetAll();
        BankAccount GetById(Guid guid);
        BankAccount GetByAccountName(string accountName);
        BankAccount GetByBank(string bank);
    }
}
