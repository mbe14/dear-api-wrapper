using System;

namespace DearInventoryLib.Model.Disassembly
{
    public class DisassemblyPickLineModel
    {
        public Guid BinID { get; set; }
        public string Bin {  get; set; }
        public DateTime Date {  get; set; }
        public string BatchSN {  get; set; }
        public DateTime ExpiryDate {  get; set; }
        public decimal Available {  get; set;}
        public decimal UnitCost {  get; set;}
        public decimal Quantity {  get; set;}
        public decimal TotalCost {  get; set;}
    }
}
