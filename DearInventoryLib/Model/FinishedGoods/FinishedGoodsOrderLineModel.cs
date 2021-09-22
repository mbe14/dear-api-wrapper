using DearInventoryLib.Model.Common;

namespace DearInventoryLib.Model.FinishedGoods
{
    public class FinishedGoodsOrderLineModel : AdditionalFields
    {
        public string ProductCode { get; set; }
        public string Name { get; set; }
        public string ExpenseAccount {  get; set; }
        public decimal Quantity { get; set; }
        public string Unit { get; set; }
        public decimal WastagePercent { get; set; }
        public decimal WastageQuantity { get; set; }
        public decimal TotalQuantity {  get; set;}
        public decimal TotalCost { get; set; }
    }
}
