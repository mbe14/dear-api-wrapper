using DearInventoryLib.Model.Purchase.Common;
using System;
using System.Collections.Generic;

namespace DearInventoryLib.Model.Purchase
{
    public class PurchaseManualJournal
    {
        public Guid TaskID { get; set; }
        public Status Status { get; set; }
        public List<PurchaseManualJournalLineModel> Lines { get; set; }
    }
}
