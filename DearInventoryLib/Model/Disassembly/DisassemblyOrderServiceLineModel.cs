using DearInventoryLib.Model.Common;
using System;

namespace DearInventoryLib.Model.Disassembly
{
    public class DisassemblyOrderServiceLineModel : AdditionalFields
    {
        public string Name {  get; set; }
        public string Account {  get; set; }
        public string Comments {  get; set; }
        public decimal Amount { get; set; }
    }
}
