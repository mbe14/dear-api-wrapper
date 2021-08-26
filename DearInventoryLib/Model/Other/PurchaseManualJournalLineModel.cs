using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DearInventoryLib.Model.Other
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
