using System;
using System.Collections.Generic;

namespace DearInventoryLib.Model.Purchase
{
    public class PurchaseList
    {
        public int Total { get; set; }
        public int Page { get; set; }
        public List<Purchase> PurchaseList { get; set; }

    }

    public class Purchase
    {
        public Guid ID { get; set; }
        public bool BlindReceipt { get; set; }
        public string OrderNumber { get; set; }
    }
}

