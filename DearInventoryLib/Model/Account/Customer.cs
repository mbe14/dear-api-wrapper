using System.Collections.Generic;

namespace DearInventoryLib.Model.Account
{
    public class Customer : Account
    {
        public string Carrier { get; set; }
        public object SalesRepresentative { get; set; }
        public string Location { get; set; }
        public string AccountReceivable { get; set; }
        public string RevenueAccount { get; set; }
        public string PriceTier { get; set; }
        public string Tags { get; set; }
        public int CreditLimit { get; set; }
    }

    public class CustomersList : PagedData
    {
        public List<Customer> CustomerList { get; set; }
    }
}
