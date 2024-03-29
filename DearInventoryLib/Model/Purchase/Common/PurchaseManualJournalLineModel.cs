﻿using System;

namespace DearInventoryLib.Model.Purchase.Common
{
    public class PurchaseManualJournalLineModel
    {
        public string Reference { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string Debit { get; set; }
        public string Credit { get; set; }
        public bool IsSystem { get; set; }
    }
}
