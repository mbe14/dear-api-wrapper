using DearInventoryLib.Model.Common;
using System.Collections.Generic;

namespace DearInventoryLib.Model.Purchase.Common
{
    public class PurchaseManualJournalModel
    {
        public DocumentStatus Status { get; set; }
        public List<PurchaseManualJournalLineModel> Lines { get; set; }
    }
}
