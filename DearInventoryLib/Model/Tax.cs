using DearInventoryLib.Model.Other;
using System;
using System.Collections.Generic;

namespace DearInventoryLib.Model
{
    public class TaxList
    {
        public int Total { get; set; }
        public int Page { get; set; }
        public List<Tax> TaxRuleList { get; set; }
    }

    public class Tax
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Account { get; set; }
        public bool IsActive { get; set; }
        public bool TaxInclusive { get; set; }
        public decimal TaxPercent { get; set; }
        public bool IsTaxForSale { get; set; }
        public bool IsTaxForPurchase { get; set; }
        public List<TaxComponent> Components { get; set; }
    }
}
