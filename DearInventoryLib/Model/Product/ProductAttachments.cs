using System;

namespace DearInventoryLib.Model.Product
{
    public class ProductAttachments
    {
        public Guid ProductID { get; set; }
        public string FileName { get; set; }
        public bool IsDefault { get; set; }
        public string FileDownloadUrl { get; set; }
        public string Content { get; set; }

    }
}
