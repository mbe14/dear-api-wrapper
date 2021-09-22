using DearInventoryLib.Model.Common;
using System;

namespace DearInventoryLib.Model.FinnishedGoods
{
    public class FinishedGoodsList : AdditionalFields
    {
        public Guid TaskID {  get; set; }
        public string AssemblyNumber { get; set; }
        public string BatchSN {  get; set; }
        public DateTime ExpiryDate {  get; set; }
        public string ProductCode {  get; set; }
        public string ProductName {  get; set; }
        public decimal Quantity {  get; set; }
        public Guid LocationID { get; set; }
        public decimal Location { get; set; }
        public DateTime Date { get; set; }
        public FinishedGoodsTaskStatus Status { get; set; }
        public decimal UnitCost { get; set; }
        public string Notes {  get; set; }
        public string CustomField1 {  get; set; }
        public string CustomField2 {  get; set; }
        public string CustomField3 {  get; set; }
        public string CustomField4 {  get; set; }
        public string CustomField5 {  get; set; }
        public string CustomField6 {  get; set; }
        public string CustomField7 {  get; set; }
        public string CustomField8 {  get; set; }
        public string CustomField9 {  get; set; }
        public string CustomField10 {  get; set; }
    }
}
