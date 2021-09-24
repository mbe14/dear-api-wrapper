using DearInventoryLib.Model.Common;
using DearInventoryLib.Model.Common.Enums;
using System;
using System.Collections.Generic;

namespace DearInventoryLib.Model.Journal
{
    public class Journal
    {
        public Guid TaskID { get; set; }
        public DITaskStatus Status { get; set; }
        public string JournalNumber { get; set; }
        public string Currency { get; set; }
        public decimal CurrencyConversionRate { get; set; }
        public DateTime EffectiveDate { get; set; }
        public string Narration { get; set; }
        public decimal Notes { get; set; }
        public List<JournalLineModel> Lines { get; set; }
        public List<AttachmentLineModel> Attachments {  get; set; }
    }
}
