using DearInventoryLib.Model.Common;
using System;

namespace DearInventoryLib.Model.Disassembly
{
    public class DisassemblyList : AdditionalFields
    {
        public Guid TaskID { get; set; }
        public string DisassemblyNumber {  get; set; }
        public string ProductCode {  get; set; }
        public string ProductName {  get; set; }
        public decimal Quantity {  get; set; }
        public Guid LocationID { get; set; }
        public decimal Location { get; set; }
        public DateTime Date {  get; set; }
        public DisassemblyStatus Status { get; set; }
    }   
}
