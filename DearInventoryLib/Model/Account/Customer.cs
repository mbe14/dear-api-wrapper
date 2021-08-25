using DearInventoryLib.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    public class CustomersList
    {
        public int Total { get; set; }
        public int Page { get; set; }
        public List<Customer> CustomerList { get; set; }
    }
}
