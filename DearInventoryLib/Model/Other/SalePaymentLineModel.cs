using System;

namespace DearInventoryLib.Model.Other
{
    public class SalePaymentLineModel
    {
        public Guid ID { get; set; }
        public string Reference { get; set; }
        public decimal Amount { get; set; }
        public DateTime DatePaid { get; set; }
        public string Account { get; set; }
        public decimal CurrencyRate { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
