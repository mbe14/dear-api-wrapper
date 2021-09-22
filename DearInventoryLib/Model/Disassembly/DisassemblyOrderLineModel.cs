using DearInventoryLib.Model.Common;
using System;

namespace DearInventoryLib.Model.Disassembly
{
    public class DisassemblyOrderLineModel : AdditionalFields
    {
        public string ProductCode {  get; set; }
        public string Name {  get; set; }
        public Guid BinID { get; set; }
        public string Bin {  get; set; }
        public string Unit {  get; set; }
        public string BatchSN {  get; set; }
        public DateTime ExpiryDate {  get; set; }
        public string Account {  get; set;}
        public decimal Quantity {  get; set; }
        public decimal Cost {  get; set; }
    }
}
