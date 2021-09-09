using DearInventoryLib.Model.Other;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DearInventoryLib.Model.Purchase
{
    public class PurchaseAttachment
    {
        public Guid TaskID { get; set; }
        public List<AttachmentLineModel> Lines { get; set; }
    }
}
