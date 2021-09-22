using DearInventoryLib.Model.Common;
using System;
using System.Collections.Generic;

namespace DearInventoryLib.Model.FinishedGoods
{
    public class FinishedGoods : AdditionalFields
    {
        public Guid TaskID { get; set; }
        public string AssemblyNumber {  get; set; }
        public FinishedGoodsTaskStatus Status {  get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public Guid LocationID { get; set; }
        public decimal Location { get; set; }
        public Guid BinID { get; set; }
        public decimal Bin { get; set; }
        public string WIPAccount { get; set; }
        public DateTime WIPDate { get; set; }
        public string Account { get; set; }
        public decimal Quantity { get; set; }
        public string AssemblyInstructionURL { get; set; }
        public DateTime CompletionDate {  get; set; }
        public string BatchSN {  get; set; }
        public DateTime ExpiryDate {  get; set; }
        public string Notes { get; set; }
        public List<FinishedGoodsOrderLineModel> OrderLines {  get; set; }
        public List<FinishedGoodsPickLineModel> PickLines { get; set; }
        public List<TransactionStockLineModel> Transactions { get; set; }
        public List<ErrorModel> Errors {  get; set; }
        public string CustomField1 { get; set; }
        public string CustomField2 { get; set; }
        public string CustomField3 { get; set; }
        public string CustomField4 { get; set; }
        public string CustomField5 { get; set; }
        public string CustomField6 { get; set; }
        public string CustomField7 { get; set; }
        public string CustomField8 { get; set; }
        public string CustomField9 { get; set; }
        public string CustomField10 { get; set; }

    }
}
