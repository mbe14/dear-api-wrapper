using System;
using System.Collections.Generic;

namespace DearInventoryLib.Model.Disassembly
{
    public class DisassemblyOrder
    {
        public Guid TaskID { get; set; }
        public DisassemblyStatus Status { get; set; }
        public List<DisassemblyOrderLineModel> OrderLines {  get; set; }
    }
}
