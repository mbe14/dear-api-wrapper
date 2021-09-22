using System;

namespace DearInventoryLib.Model.Common
{
    public class SalePaymentLineModel : DIModel
    {
        public string Reference { get; set; }
        public decimal Amount { get; set; }
        public DateTime DatePaid { get; set; }
        public string Account { get; set; }
        public decimal CurrencyRate { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
