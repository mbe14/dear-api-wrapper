using DearInventoryLib.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DearInventoryLib.Model.Account
{
    public class Account
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Currency { get; set; }
        public string PaymentTerm { get; set; }
        public int Discount { get; set; }
        public string TaxRule { get; set; }
        public Status Status { get; set; }
        public List<Address> Addresses { get; set; }
        public List<Contact> Contacts { get; set; }
        public string AdditionalAttribute1 { get; set; }
        public string AdditionalAttribute2 { get; set; }
        public string AdditionalAttribute3 { get; set; }
        public string AdditionalAttribute4 { get; set; }
        public string AdditionalAttribute5 { get; set; }
        public string AdditionalAttribute6 { get; set; }
        public string AdditionalAttribute7 { get; set; }
        public string AdditionalAttribute8 { get; set; }
        public string AdditionalAttribute9 { get; set; }
        public string AdditionalAttribute10 { get; set; }
        public DateTime LastModifiedOn { get; set; }
        public int TaxNumber { get; set; }
        public object AttributeSet { get; set; }
        public string Comments { get; set; }
    }
}
