using DearInventoryLib.Model.Common;
using System.Collections.Generic;

namespace DearInventoryLib.Model.Other
{
    public class PurchaseManualJournalModel
    {
        public DocumentStatus Status { get; set; }
        public List<PurchaseManualJournalLineModel> Lines { get; set; }
    }
}
