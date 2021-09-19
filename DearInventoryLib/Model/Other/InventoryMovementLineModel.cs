using DearInventoryLib.Model.Common;
using System;

namespace DearInventoryLib.Model.Other
{
    public class InventoryMovementLineModel : AdditionalFields
    {
        public Guid TaskID { get; set; }
        public DateTime Date { get; set; }
        public decimal COGS { get; set; }
    }
}
