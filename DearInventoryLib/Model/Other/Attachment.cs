using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DearInventoryLib.Model.Other
{
    public class Attachment
    {
        public string ID { get; set; }
        public string ContentType { get; set; }
        public string FileName { get; set; }
        public string DownloadUrl { get; set; }
    }
}
