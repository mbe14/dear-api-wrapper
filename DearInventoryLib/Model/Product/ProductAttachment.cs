using DearInventoryLib.Model.Common;
using System;

namespace DearInventoryLib.Model.ProductAttachment
{
    public class ProductAttachment : AdditionalFields
    {
        public Guid ProductID { get; set; }
        public string FileName { get; set; }
        public bool IsDefault { get; set; }
        public string FileDownloadUrl { get; set; }
        public string Content { get; set; }

    }
}
