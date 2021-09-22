using System;

namespace DearInventoryLib.Model.Common
{
    public class InventoryMovementLineModel : AdditionalFields
    {
        public Guid TaskID { get; set; }
        public DateTime Date { get; set; }
        public decimal COGS { get; set; }
    }
}
