﻿using DearInventoryLib.Model;
using DearInventoryLib.Model.Bank;
using System;
using System.Collections.Generic;

namespace DearInventoryLib.Interface
{
    interface IBankAccountsRequest
    {
        List<BankAccount> GetAll();
        BankAccount GetById(Guid Guid);
        BankAccount GetByAccountName(string AccountName);
        BankAccount GetByBank(string Bank);
    }
}
