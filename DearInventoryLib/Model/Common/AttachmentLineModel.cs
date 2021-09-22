using System;

namespace DearInventoryLib.Model.Common
{
    public class AttachmentLineModel : DIModel
    {
        public string ContentType { get; set; }
        public bool IsDefault { get; set; }
        public string FileName { get; set; }
        public string DownloadUrl { get; set; }

    }
}
