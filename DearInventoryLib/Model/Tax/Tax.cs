using DearInventoryLib.Model.Common;
using System;
using System.Collections.Generic;

namespace DearInventoryLib.Model.Tax
{
    public class TaxList : PagedData
    {
        public List<Tax> TaxRuleList { get; set; }
    }

    public class Tax : DIModel
    {
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
