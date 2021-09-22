using DearInventoryLib.Model.Common;
using System;
using System.Collections.Generic;

namespace DearInventoryLib.Model.Disassembly
{
    public class Disassembly : AdditionalFields
    {
        public Guid TaskID { get; set; }
        public string DisassemblyNumber {  get; set; }
        public DisassemblyStatus Status {  get; set; }        
        public string ProductCode {  get; set; }
        public string ProductName {  get; set; }
        public Guid LocationID {  get; set; }
        public decimal Location { get; set; }
        public string WIPAccount {  get; set; }
        public decimal Quantity { get; set; }
        public string AssemblyInstructionURL {  get; set; }
        public List<DisassemblyPickLineModel> PickLines { get; set; }
        public List<DisassemblyOrderLineModel> OrderLines { get; set; }
        public List<DisassemblyOrderServiceLineModel> OrderServiceLines { get; set; }
        public List<TransactionStockLineModel> Transactions { get; set; }
        public List<ErrorModel> Errors {  get; set; }
    }
}
