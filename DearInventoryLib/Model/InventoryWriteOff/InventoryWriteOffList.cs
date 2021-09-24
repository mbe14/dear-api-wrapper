using DearInventoryLib.Model.Common.Enums;
using System;

namespace DearInventoryLib.Model.InventoryWriteOff
{
    public class InventoryWriteOffList
    {
        public Guid TaskID { get; set; }
        public string InventoryWriteOffNumber {  get; set; }
        public DITaskStatus InventoryWriteOffStatus {  get; set; }
        public Guid LocationID {  get; set; }
        public decimal Location { get; set; }
        public DateTime Date {  get; set; }
        public string Notes {  get; set; }
    }
}
