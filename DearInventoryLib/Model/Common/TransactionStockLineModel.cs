using System;

namespace DearInventoryLib.Model.Common
{
    public class TransactionStockLineModel : DIModel
    {
        public string Debit { get; set; }
        public string Credit {  get; set; }
        public decimal Amount {  get; set; }
        public DateTime EffectiveDate { get; set; }
    }
}
