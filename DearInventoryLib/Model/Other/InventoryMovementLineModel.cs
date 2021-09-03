using System;

namespace DearInventoryLib.Model.Other
{
    public class InventoryMovementLineModel
    {
        public Guid TaskID { get; set; }
        public Guid ProductID { get; set; }
        public DateTime Date { get; set; }
        public decimal COGS { get; set; }
    }
}
