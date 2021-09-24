using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DearInventoryLib.Model.FinishedGoods
{
    public class FinishedGoodsOrder
    {
        public Guid TaskID { get; set; }
        public FinishedGoodsTaskStatus Status {  get; set; }
        public List<FinishedGoodsOrderLineModel> OrderLines { get; set; }
    }
}
