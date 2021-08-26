using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
