using DearInventoryLib.Model.Common;
using DearInventoryLib.Model.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DearInventoryLib.Model.InventoryWriteOff
{
    public class InventoryWriteOff
    {
        public Guid TaskID {  get; set; }
        public string InventoryWriteOffNumber {  get; set; }
        public DITaskStatus Status {  get; set; }
        public Guid LocationID { get; set; }
        public decimal Location { get; set; }
        public string Account {  get; set; }
        public DateTime EffectiveDate {  get; set; }
        public string Notes { get; set; }
        public List<InventoryWriteOffLineModel> Lines { get; set; }
        public List<TransactionStockLineModel> Transactions {  get; set; }
        public List<ErrorModel> Errors {  get; }


    }
}
