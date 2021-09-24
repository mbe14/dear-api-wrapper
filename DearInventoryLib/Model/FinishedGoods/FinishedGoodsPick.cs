using System;
using System.Collections.Generic;

namespace DearInventoryLib.Model.FinishedGoods
{
    public class FinishedGoodsPick
    {
        public Guid TaskID { get; set; }
        public FinishedGoodsTaskStatus Status { get; set; }
        public string WIPAccount { get; set; }
        public DateTime WIPDate { get; set; }
        public string Account { get; set; }
        public DateTime CompletionDate { get; set; }
        public List<FinishedGoodsPickLineModel> PickLines { get; set; }
    }
}
